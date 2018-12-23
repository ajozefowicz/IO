using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfKsiazkaDoBazy
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class Service1 : IService1
    {

        public Service1()
        {
            ConnectToDB();
        }


        SqlConnection conn;
        SqlCommand comm;

        SqlConnectionStringBuilder connStringBuilder;

        void ConnectToDB()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "DESKTOP-PD78ORB";
            connStringBuilder.InitialCatalog = "WCFKsiazka";
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


        public int InsertKsiazka(Ksiazka k)
        {

            try
            {
                comm.CommandText = "Insert into IKsiazka values(@id, @tytul, @stan, @rodzaj, @licznikWypozyczen," +
                    " @licznikPrzedluzen, @iloscStron, @imieAutora, @nazwiskoAutora, @nrISBN, @dataWypozyczenia, @dataZwrotu)";


                //proba inna

                /*

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@dataWypozyczenia";
                parameter.SqlDbType = SqlDbType.DateTime;
                parameter.Value = DateTime.Parse("2000 - 09 - 02");

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@dataZwrotu";
                parameter2.SqlDbType = SqlDbType.DateTime;
                parameter2.Value = DateTime.Parse("2000 - 09 - 02");
                */

                /*
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@dataWypozyczenia";
                param.SqlDbType = System.Data.SqlDbType.DateTime;
                param.Value=null;
                comm.Parameters.Add(param);

                
                SqlParameter param2 = new SqlParameter();
                param2.ParameterName = "@dataZwrotu";
                param2.DbType = System.Data.DbType.DateTime;
                comm.Parameters.Add(param2);

                */


                comm.Parameters.AddWithValue("id", k.id);
                comm.Parameters.AddWithValue("tytul", k.tytul);
                comm.Parameters.AddWithValue("stan", k.stan);
                comm.Parameters.AddWithValue("rodzaj", k.rodzaj);
                comm.Parameters.AddWithValue("licznikWypozyczen", k.licznikWypozyczen);
                comm.Parameters.AddWithValue("licznikPrzedluzen", k.licznikPrzedluzen);
                comm.Parameters.AddWithValue("iloscStron", k.iloscStron);
                comm.Parameters.AddWithValue("imieAutora", k.imieAutora);
                comm.Parameters.AddWithValue("nazwiskoAutora", k.nazwiskoAutora);
                comm.Parameters.AddWithValue("nrISBN", k.nrISBN);

                //comm.Parameters.Add(parameter); //'2005-04-12' //Operand type clash: int is incompatible with date
                //comm.Parameters.Add(parameter2);

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("2000-12-12");

                string dataZero = Convert.ToString(DateTime.UtcNow.ToLocalTime());

                var aaa = DateTime.Parse(dataZero);


                /////
              
                DateTime myDateTime2 = DateTime.Now;
                string sqlFormattedDate2 = myDateTime.ToString("2000-10-10");

                comm.Parameters.AddWithValue("dataWypozyczenia", DateTime.UtcNow.ToLocalTime()); //
                comm.Parameters.AddWithValue("dataZwrotu", DateTime.UtcNow.ToLocalTime()); //


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
