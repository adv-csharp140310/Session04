using session04.Model;
using Microsoft.Data.SqlClient;

namespace session04.Service;
public class UserService
{
    string connectionString = "Server=.;Database=cs140310;Trusted_Connection=True;TrustServerCertificate=True";
    /**
     *  ADO.net
         * 1. new SQLConnection -> connection string - https://www.connectionstrings.com/
         * 2. new SQLCommad
         * 3. SQLCommad.Text
         * 4. SQLCommad -> SQLConnection
         * 5. SQLConnection open
         * 6. SQLCommad exec
         * 7. SQLConnection close
    * */


    //CRUD - Create, Read, Update, Delete
    //       Insert, Select, Update, Delete


    public void Create(User user)
    {
        var conn = new SqlConnection(connectionString);
        var cmd = conn.CreateCommand();
        //var cmd = new SqlCommand();
        //cmd.Connection = conn;

        //SQL Injection 🐞🐞 💉💉💉
        //user.Email =  "xyz'); delete  users"
        //cmd.CommandText = $"INSERT into users (Name, Family, Email, IsActive)" +
        //    $"VALUES ('{user.Name}', '{user.Family}', '{user.Email}', {user.IsActive})";
        //;

        cmd.CommandText = "INSERT into [dbo].[User] ([FirstName], [Family], [Email], [IsActive]) values" +
            "(@FirstName, @Family, @Email, @IsActive)";
        cmd.Parameters.AddWithValue("FirstName", user.Name);
        cmd.Parameters.AddWithValue("Family", user.Family);
        cmd.Parameters.AddWithValue("Email", user.Email);
        cmd.Parameters.AddWithValue("IsActive", user.IsActive);


        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

    }

}
