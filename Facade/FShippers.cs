using Entity;
using System.Data.SqlClient;

namespace Facade
{
    public class FShippers
    {
        public static bool Insert(EShipper shipper)
        {
            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "pr_ShipperAdd";

            SqlParameter[] parameters =
            {
                new SqlParameter{ParameterName="CompanyName", Value =shipper.CompanyName},
                new SqlParameter{ParameterName="Phone", Value=shipper.Phone}
            };

            cmd.Parameters.AddRange(parameters);

            try
            {
                if(conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch
            {
                sonuc = false;
            }
            finally
            {
                if(conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }

        public static bool Update(EShipper shipper)
        {
            if (shipper == null)
                return false;

            if (shipper.ShipperID <= 0 || string.IsNullOrEmpty(shipper.CompanyName))
                return false;

            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "pr_ShipperUpdate";

            SqlParameter[] parameters =
            {
                new SqlParameter{ParameterName="ShipperID", Value =shipper.ShipperID},
                new SqlParameter{ParameterName="CompanyName", Value =shipper.CompanyName},
                new SqlParameter{ParameterName="Phone", Value=shipper.Phone}
            };

            cmd.Parameters.AddRange(parameters);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch
            {
                sonuc = false;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }

        public static bool Delete(int shipperID)
        {

            if (shipperID <= 0)
                return false;

            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "pr_ShipperDelete";

            SqlParameter parameter = new SqlParameter
            {
                ParameterName="ShipperID", Value =shipperID
            };

            cmd.Parameters.Add(parameter);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch
            {
                sonuc = false;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }
    }
}
