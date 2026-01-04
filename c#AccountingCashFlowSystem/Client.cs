using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
public class Client
{
    public int ClientId { get; set; }
    public string FullName { get; set; }
    public int TotalAmount { get; set; }
    public int DownPayment { get; set; }
    public int FullPayment { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ReferenceNo { get; set; }
    public int PaymentMethod { get; set; }
    public List<ClientAmenities> ClientAmenities { get; set; }
    public List<ClientRooms> ClientRooms { get; set; }
    public string Connection()
    {
        string connectionString = @"Data Source=DESKTOP-4JC0DPF\SQLEXPRESS;
                            Initial Catalog=master;
                            Integrated Security=True;
                            Persist Security Info=False;
                            Pooling=False;
                            MultipleActiveResultSets=False;
                            Encrypt=True;
                            TrustServerCertificate=True;";
        return connectionString;
    }
}
public class ClientAmenities
{
    public string amenitiesName { get; set; }
}
public class ClientRooms
{
    public string roomName { get; set; }
}
public class AmenitiesAndRooms
{
    public string roomName { get; set; }
    public int amenitiesID { get; set; }
    public string amenitiesName { get; set; }
    public int roomID { get; set; }
}
public class ClientDatabase
{
    private readonly string connectionString = new Client().Connection();

    public static string GenerateReferenceNumber()
    {
        string datePart = DateTime.Now.ToString("yyyyMMddHHmm");
        string randomPart = Guid.NewGuid().ToString().Substring(0, 5).ToUpper();

        return $"REF-{datePart}-{randomPart}";
    }

    public int InsertNewClient(string fullName, int totalamount, int downpayment, DateTime startdate, DateTime enddate, List<int> amenityIDS, List<int> roomIDS, int PaidinFull, int paymentMethod)
    {
        int newClientID = 0;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            string referenceNumber = GenerateReferenceNumber();

            try
            {
                // INSERT client and return new ID
                string query = @"
                INSERT INTO dbo.Clients (FullName, TotalAmount, DownPayment, startDate, endDate, isFullPaid, referenceNo, paymenthMethod)
                VALUES (@name, @totalamount, @downpayment, @startdate, @enddate, @isFullPaid, @referenceNo, @pymethod);
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@totalamount", totalamount);
                    cmd.Parameters.AddWithValue("@downpayment", downpayment);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.Parameters.AddWithValue("@enddate", enddate);
                    cmd.Parameters.AddWithValue("@isFullPaid", PaidinFull);
                    cmd.Parameters.AddWithValue("@referenceNo", referenceNumber);
                    cmd.Parameters.AddWithValue("@pymethod", paymentMethod);

                    newClientID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (int amenityID in amenityIDS)
                {
                    string queryA = @"
                    INSERT INTO dbo.clientAmenities (clientID, amenitiesID)
                    VALUES (@clientID, @amenityID)";

                    using (SqlCommand junctionCmd = new SqlCommand(queryA, conn, trans))
                    {
                        junctionCmd.Parameters.AddWithValue("@clientID", newClientID);
                        junctionCmd.Parameters.AddWithValue("@amenityID", amenityID);
                        junctionCmd.ExecuteNonQuery();
                    }
                }

                foreach (int roomID in roomIDS)
                {
                    string queryR = @"
                    INSERT INTO dbo.clientRooms (clientID, roomID)
                    VALUES (@clientID, @roomID)";

                    using (SqlCommand junctionCmd = new SqlCommand(queryR, conn, trans))
                    {
                        junctionCmd.Parameters.AddWithValue("@clientID", newClientID);
                        junctionCmd.Parameters.AddWithValue("@roomID", roomID);
                        junctionCmd.ExecuteNonQuery();
                    }
                }

                trans.Commit();
                return newClientID;
            }
            catch
            {
                trans.Rollback();
                return 0;
            }
        }
    }
    public List<Client> GetCurrentEvents()
    {
        List<Client> clients = new List<Client>();

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clients WHERE status = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ReferenceNo = reader["referenceNo"].ToString(),
                            ClientId = Convert.ToInt32(reader["ClientId"]),
                            FullName = reader["FullName"].ToString(),
                            TotalAmount = Convert.ToInt32(reader["TotalAmount"]),
                            //DownPayment = Convert.ToInt32(reader["DownPayment"]),
                            StartDate = Convert.ToDateTime(reader["StartDate"]),
                            EndDate = Convert.ToDateTime(reader["EndDate"])
                        });
                    }
                }
            }
            return clients;
        }
        catch
        {
            throw;
        }

    }
    public Client GetClient(int clientId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                Client clientInfo = null;

                string CQuery = "SELECT FullName, TotalAmount, isFullPaid, DownPayment, StartDate, EndDate, referenceNo, paymenthMethod FROM Clients WHERE ClientId = @clientId";

                using (var cmdClient = new SqlCommand(CQuery, conn, trans))
                {
                    cmdClient.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;

                    using (var reader = cmdClient.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientInfo = new Client
                            {
                                FullName = reader["FullName"].ToString(),
                                TotalAmount = Convert.ToInt32(reader["TotalAmount"]),
                                FullPayment = Convert.ToInt32(reader["isFullPaid"]),
                                DownPayment = Convert.ToInt32(reader["DownPayment"]),
                                StartDate = Convert.ToDateTime(reader["StartDate"]),
                                EndDate = Convert.ToDateTime(reader["EndDate"]),
                                ReferenceNo = reader["referenceNo"].ToString(),
                                PaymentMethod = Convert.ToInt32(reader["paymenthMethod"]),
                                ClientAmenities = new List<ClientAmenities>(),
                                ClientRooms = new List<ClientRooms>()
                            };
                        }
                    }
                }
                if (clientInfo == null)
                {
                    trans.Rollback();
                    return null;
                }

                string CAquery = "SELECT a.amenitiesName, a.amenitiesID FROM clientAmenities ca JOIN amenities a ON a.amenitiesID = ca.amenitiesID WHERE ca.clientID = @clientId";

                using (var cmdClientAmenities = new SqlCommand(CAquery, conn, trans))
                {
                    cmdClientAmenities.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;

                    using (var reader = cmdClientAmenities.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["amenitiesID"] != DBNull.Value)
                            {
                                clientInfo.ClientAmenities.Add(new ClientAmenities
                                {
                                    amenitiesName = reader["amenitiesName"].ToString()
                                });
                            }
                        }
                    }
                }

                string Rquery = "SELECT r.roomName, r.roomID FROM clientRooms cr JOIN rooms r ON r.roomID = cr.roomID WHERE cr.clientID = @clientId";

                using (var cmdClientRooms = new SqlCommand(Rquery, conn, trans))
                {
                    cmdClientRooms.Parameters.Add("@clientId", SqlDbType.Int).Value = clientId;

                    using (var reader = cmdClientRooms.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["roomID"] != DBNull.Value)
                            {
                                clientInfo.ClientRooms.Add(new ClientRooms
                                {
                                    roomName = reader["roomName"].ToString()
                                });
                            }
                        }
                    }
                }


                trans.Commit();
                return clientInfo;
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }
    }
    public List<AmenitiesAndRooms> getAmenties()
    {
        List<AmenitiesAndRooms> amenities = new List<AmenitiesAndRooms>();

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string Aquery = "SELECT amenitiesName, amenitiesID FROM amenities";
                SqlCommand Acmd = new SqlCommand(Aquery, conn);

                conn.Open();

                using (SqlDataReader reader = Acmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        amenities.Add(new AmenitiesAndRooms
                        {
                            amenitiesName = reader["amenitiesName"].ToString(),
                            amenitiesID = Convert.ToInt32(reader["amenitiesID"])
                        });
                    }
                }
            }

        }
        catch
        {
            return null;
        }
        return amenities;
    }
    public List<AmenitiesAndRooms> getRooms()
    {
        List<AmenitiesAndRooms> rooms = new List<AmenitiesAndRooms>();
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string Rquery = "SELECT roomName, roomID FROM rooms";
                SqlCommand Rcmd = new SqlCommand(Rquery, conn);
                conn.Open();
                using (SqlDataReader reader = Rcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new AmenitiesAndRooms
                        {
                            roomName = reader["roomName"].ToString(),
                            roomID = Convert.ToInt32(reader["roomID"])
                        });
                    }
                }
            }
        }
        catch
        {
            return null;
        }
        return rooms;
    }
    public bool completeTransac(int ClientID)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                string query = "UPDATE Clients SET status = 1 WHERE ClientId = @clientID";

                using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                {
                    cmd.Parameters.Add("@clientID", SqlDbType.Int).Value = ClientID;
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;

            }
            catch
            {
                trans.Rollback();
                throw;
            }

        }
    }


}

