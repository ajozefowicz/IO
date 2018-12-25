using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfWypozyczeniaDoBazy
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class Service1 : IService1
    {

        ///
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
            connStringBuilder.InitialCatalog = "WCFWypozyczenie";
            connStringBuilder.Encrypt = true;
            connStringBuilder.TrustServerCertificate = true;
            connStringBuilder.ConnectTimeout = 30;
            connStringBuilder.AsynchronousProcessing = true;
            connStringBuilder.MultipleActiveResultSets = true;
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());

            comm = conn.CreateCommand();
        }

        //////////////////////








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


        public int InsertWypozyczenie(Wypozyczenie w)
        {


            try
            {
                comm.CommandText = "Insert into IWypozyczenie values( @idKsiazki, @idUsera, @dataWypozyczenia, @dataZwrotu, @czyAktualne)";

               // comm.Parameters.AddWithValue("id", w.id);
                comm.Parameters.AddWithValue("idKsiazki", w.idKsiazki);
                comm.Parameters.AddWithValue("idUsera", w.idUsera);
                comm.Parameters.AddWithValue("dataWypozyczenia", DateTime.UtcNow.ToLocalTime());
                comm.Parameters.AddWithValue("dataZwrotu", DateTime.UtcNow.ToLocalTime());
                comm.Parameters.AddWithValue("czyAktualne", w.czyAktualne);



                // // tu jeszcze trzeba zmienic stan oryginalnej ksiazki na niedostępna czyli update dodac do funkcji wypozyczenia i date trza zmienic
                // ale to trza zrobic w ksiązce by mmiec dostep do bazy ksiazka
                // i tam mozna tez pwprowadzic, że jak status false to wypozyczenie nie mozliwe


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




        public List<Wypozyczenie> FillWypozyczeniaDataGridViewTabela()
        {

            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();


            try
            {

                ////////////////////////////////// wersja 


                string cmdText = "Select * from IWypozyczenie";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Wypozyczenie w = new Wypozyczenie();
                    w.id = Convert.ToInt32(reader["id"].ToString());
                    w.idKsiazki = Convert.ToInt32(reader["idKsiazki"].ToString());
                    w.idUsera = reader["idUsera"].ToString();
                    w.dataWypozyczyenia = Convert.ToDateTime(reader["dataWypozyczenia"].ToString());
                    w.dataZwrotu = Convert.ToDateTime(reader["dataZwrotu"].ToString());
                    w.czyAktualne = Convert.ToBoolean(reader["czyAktualne"].ToString());


                    wypozyczenia.Add(w);


                }
                return wypozyczenia;


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
