using session04.Model;
using Microsoft.Data.SqlClient;

namespace session04.Service;
public class ProductService
{
    string connectionString = "Server=.;Database=cs140310;Trusted_Connection=True;TrustServerCertificate=True";

    public void Create(Product model)
    {
        using var conn = new SqlConnection(connectionString);
        var cmd = conn.CreateCommand();

        cmd.CommandText = "INSERT into [dbo].[Product] ([Name], [Price], [IsActive]) values" +
            "(@Name, @Price, @IsActive)";

        cmd.Parameters.AddWithValue("Name", model.Name);
        cmd.Parameters.AddWithValue("Price", model.Price);
        cmd.Parameters.AddWithValue("IsActive", model.IsActive);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public Product GetById(int id)
    {
        using var conn = new SqlConnection(connectionString);
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM [dbo].[Product] WHERE ID = @ID";
        cmd.Parameters.AddWithValue("ID", id);

        conn.Open();
        var reader = cmd.ExecuteReader();
        reader.Read();

        return new Product
        {
            ID = Convert.ToInt32(reader["ID"]),
            Name = Convert.ToString(reader["Name"]),
            Price = Convert.ToInt32(reader["Price"]),
            IsActive = Convert.ToBoolean(reader["IsActive"]),
        };
    }

    public List<Product> Read()
    {
        var result = new List<Product>();

        using var conn = new SqlConnection(connectionString);
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM [dbo].[Product]";

        conn.Open();
        var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            result.Add(new Product
            {
                ID = Convert.ToInt32(reader["ID"]),
                Name = Convert.ToString(reader["Name"]),
                Price = Convert.ToInt32(reader["Price"]),
                IsActive = Convert.ToBoolean(reader["IsActive"]),
            });
        }
        return result;
    }

    public void Delete(int id)
    {
        using var conn = new SqlConnection(connectionString);
        var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM [dbo].[Product] WHERE id = @ID";
        cmd.Parameters.AddWithValue("ID", id);

        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Update(Product model)
    {
        using var conn = new SqlConnection(connectionString);
        var cmd = conn.CreateCommand();
        cmd.CommandText =
            "UPDATE [dbo].[Product] SET Name=@Name, Price=@Price  WHERE id = @ID";
        cmd.Parameters.AddWithValue ("ID", model.ID);
        cmd.Parameters.AddWithValue ("Name", model.Name);
        cmd.Parameters.AddWithValue ("Price", model.Price);

        conn.Open();
        cmd.ExecuteNonQuery();
    }
}
