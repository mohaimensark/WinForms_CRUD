using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using WinForms_CRUD.Models;

namespace WinForms_CRUD.Repositories
{
    public class ClientRepositories
    {
        private readonly string connectionString = "Data Source=DESKTOP-L9HKHVG\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";


        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                using (SqlConnection conneciton = new SqlConnection(connectionString))
                {
                    conneciton.Open();

                    string sql = "SELECT * FROM clients ORDER BY id DESC";
                    using(SqlCommand cmd = new SqlCommand(sql, conneciton))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) {

                            while (reader.Read()) {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstname = reader.GetString(1);
                                client.lastname = reader.GetString(2);
                                client.email = reader.GetString(3);
                                client.phone = reader.GetString(4);
                                client.address = reader.GetString(5);
                                client.createdAt = reader.GetDateTime(6).ToString();

                                clients.Add(client);
                            }

                        }

                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine("Exception: " + ex.ToString());
            }

          

            return clients;
        }

        public Client? GetClient(int id){
            try
            {
                using (SqlConnection conneciton = new SqlConnection(connectionString))
                {
                    conneciton.Open();

                    string sql = "SELECT * FROM clients WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, conneciton))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstname = reader.GetString(1);
                                client.lastname = reader.GetString(2);
                                client.email = reader.GetString(3);
                                client.phone = reader.GetString(4);
                                client.address = reader.GetString(5);
                                client.createdAt = reader.GetDateTime(6).ToString();

                                return client;
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }


            return null;
        }
        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection conneciton = new SqlConnection(connectionString))
                {
                    conneciton.Open();
                    string sql = "INSERT INTO clients " +
                        "(firstname, lastname, email, phone, address) VALUES " +
                        "(@firstname, @lastname, @email, @phone, @address);";

                    using (SqlCommand command = new SqlCommand(sql, conneciton))
                    {
                        command.Parameters.AddWithValue("@firstname", client.firstname);
                        command.Parameters.AddWithValue("@lastname", client.lastname);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);

                        command.ExecuteNonQuery();
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }


        }

        public void UpdateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients " +
                                 "SET firstname = @firstname, lastname = @lastname, " +
                                 "email = @email, phone = @phone, address = @address " + // Added space here
                                 "WHERE id = @id"; // Ensure proper spacing

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Use AddWithValue, but consider the types carefully. Alternatively, you can use SqlParameter.
                        command.Parameters.AddWithValue("@firstname", client.firstname);
                        command.Parameters.AddWithValue("@lastname", client.lastname);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);
                        command.Parameters.AddWithValue("@id", client.id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }


        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection conneciton = new SqlConnection(connectionString))
                {
                    conneciton.Open();
                    string sql = "DELETE FROM clients WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, conneciton))
                    {
                       
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }
}
