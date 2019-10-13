using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service_Set
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }

        SqlConnection conn;
        SqlCommand comm;
        //SqlCommand comm = new SqlCommand("insert into BillPesan(Tgl_Pemesanan,ID_Menu,jml_Pesana,Totalharga) values(@Tgl_Pemesanan,@ID_Menu,@jml_Pesana,@Totalharga)",);

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDb()
        {
            //conn.ConnectionString = @"Data Source=DESKTOP-DK319Q3;Initial Catalog=WCF_Cashier;integrated security=True";
            //comm = conn.CreateCommand("insert into BillPesan(Tgl_Pemesanan,ID_Menu,jml_Pesana,Totalharga) values(@Tgl_Pemesanan,@ID_Menu,@jml_Pesana,@Totalharga)",conn);
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-DK319Q3";
            connStringBuilder.InitialCatalog = "WCF_Cashier";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
            comm = conn.CreateCommand();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int InsertBill(Bill b)
        {

            try
            {
                //conn.Open();
                //SqlCommand comm = new SqlCommand("insert into BillPesan(Tgl_Pemesanan,ID_Menu,jml_Pesana,Totalharga) values(@Tgl_Pemesanan,@ID_Menu,@jml_Pesana,@Totalharga)",conn);
                comm.CommandText = "INSERT INTO BillPesan VALUES(@Tgl_Pemesanan, @ID_Menu, @jml_Pesana, @Totalharga)";
                comm.Parameters.AddWithValue("Tgl_Pemesanan", b.tglpesan);
                comm.Parameters.AddWithValue("ID_Menu", b.idmenu);
                comm.Parameters.AddWithValue("jml_Pesana", b.jmlpesan);
                comm.Parameters.AddWithValue("Totalharga", b.ttlhrg);

                comm.CommandType = CommandType.Text;
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                    throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }
}
