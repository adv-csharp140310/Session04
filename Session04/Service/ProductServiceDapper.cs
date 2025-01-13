using session04.Model;
using Microsoft.Data.SqlClient;
using Dapper;

namespace session04.Service;
public class ProductServiceDapper
{
    string connectionString = "Server=.;Database=cs140310;Trusted_Connection=True;TrustServerCertificate=True";

    public void Create(Product model)
    {
        using var conn = new SqlConnection(connectionString);
        var sql = "INSERT into [dbo].[Product] ([Name], [Price], [IsActive]) values" +
            "(@Name, @Price, @IsActive)";
        conn.Execute(sql, model);
    }

    public Product GetById(int id)
    {
        using var conn = new SqlConnection(connectionString);
        var sql = "SELECT * FROM [dbo].[Product] WHERE ID = @ID";
        return conn.QueryFirstOrDefault<Product>(sql, new { ID = id});
    }

    public List<Product> Read()
    {
        using var conn = new SqlConnection(connectionString);
        var sql = "SELECT * FROM [dbo].[Product]";
        return conn.Query<Product>(sql).AsList();
    }

    public void Delete(int id)
    {
        using var conn = new SqlConnection(connectionString);
        var sql = "DELETE FROM [dbo].[Product] WHERE id = @ID";
        conn.Execute(sql, new { ID = id });
    }

    public void Update(Product model)
    {
        using var conn = new SqlConnection(connectionString);
        var sql =
            "UPDATE [dbo].[Product] SET Name=@Name, Price=@Price  WHERE id = @ID";
        conn.Execute(sql, model);
    }
}
