using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
public class Client
{
    public int ClientId { get; set; }
    public string FullName { get; set; }
    public int TotalAmount { get; set; }
    public int DownPayment { get; set; }
    public int FullPayment { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Amenities { get; set; }
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
    private readonly string connectionString =
    @"Data Source=DESKTOP-4JC0DPF\SQLEXPRESS;
                            Initial Catalog=master;
                            Integrated Security=True;
                            Persist Security Info=False;
                            Pooling=False;
                            MultipleActiveResultSets=False;
                            Encrypt=True;
                            TrustServerCertificate=True;";
    public int InsertNewClient(string fullName, int totalamount, int downpayment, DateTime startdate, DateTime enddate, List<int> amenityIDS, List<int> roomIDS, int PaidinFull)
    {
        int newClientID = 0;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                // INSERT client and return new ID
                string query = @"
                INSERT INTO dbo.Clients (FullName, TotalAmount, DownPayment, startDate, endDate, isFullPaid)
                VALUES (@name, @totalamount, @downpayment, @startdate, @enddate, @isFullPaid);
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn, trans))
                {
                    cmd.Parameters.AddWithValue("@name", fullName);
                    cmd.Parameters.AddWithValue("@totalamount", totalamount);
                    cmd.Parameters.AddWithValue("@downpayment", downpayment);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.Parameters.AddWithValue("@enddate", enddate);
                    cmd.Parameters.AddWithValue("@isFullPaid", PaidinFull);

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
                string query = "SELECT * FROM Clients";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ClientId = Convert.ToInt32(reader["ClientId"]),
                            FullName = reader["FullName"].ToString(),
                            DownPayment = Convert.ToInt32(reader["DownPayment"]),
                            StartDate = Convert.ToDateTime(reader["StartDate"]),
                            EndDate = Convert.ToDateTime(reader["EndDate"])
                        });
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        return clients;
    }
    public Client GetClient(int clientId)
    {
        Client clientInfo = new Client();
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT C.FullName, C.TotalAmount, C.isFullPaid, C.DownPayment, C.StartDate, C.EndDate, " +
                               "STRING_AGG(a.amenitiesName, ', ') AS Amenities " +
                               "FROM Clients C " +
                               "LEFT JOIN clientAmenities ca ON C.ClientId = ca.clientID " +
                               "LEFT JOIN amenities a ON a.amenitiesID = ca.amenitiesID " +
                               "WHERE C.ClientId = @clientId " +
                               "GROUP BY C.FullName, C.TotalAmount, C.isFullPaid, C.DownPayment, C.StartDate, C.EndDate";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@clientId", clientId); 

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        clientInfo = new Client
                        {
                            //ClientId = Convert.ToInt32(reader["ClientId"]),
                            FullName = reader["FullName"].ToString(),
                            TotalAmount = Convert.ToInt32(reader["TotalAmount"]),
                            FullPayment = Convert.ToInt32(reader["isFullPaid"]),
                            DownPayment = Convert.ToInt32(reader["DownPayment"]),
                            StartDate = Convert.ToDateTime(reader["StartDate"]),
                            EndDate = Convert.ToDateTime(reader["EndDate"]),
                            Amenities = reader["Amenities"].ToString()
                        };
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        return clientInfo;
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
}

