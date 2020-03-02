using System;
using System.Data.SqlClient;

class DisposeNotCalledOnExceptionGood
{
  public SqlDataReader GetAllCustomers() {
    using (var conn = new SqlConnection("connection string")) {
      conn.Open();
      using (var cmd = new SqlCommand("SELECT * FROM Customers", conn)) {
        return cmd.ExecuteReader();
      }
    }
  }
}
