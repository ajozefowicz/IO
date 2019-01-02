using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfUserDoBazy;

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
                comm.Parameters.AddWithValue("dataZwrotu", DateTime.UtcNow.ToLocalTime().AddDays(14));
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


        //////////////////////////////////////////////
        ///
        //wypozyczenia konkretnego usera
        public List<Wypozyczenie> FillWypozyczeniaUseraWszystkie(string key, string idU)
        {

            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();


            try
            {

                ////////////////////////////////// wersja 


                //string cmdText = "Select * from IWypozyczenie where idUsera = " +  idUsera ;



                string cmdText = "Select * from IWypozyczenie" +
                                    " where  " + key;      //textBox_imieAutora.Text


                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Wypozyczenie w = new Wypozyczenie();
                    w.id = Convert.ToInt32(reader["id"].ToString());
                    w.idKsiazki = Convert.ToInt32(reader["idKsiazki"].ToString());
                    w.idUsera = idU;//        reader["idUsera"].ToString();  // hmmmmmmmmmmmmm
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


        //////////////////////////
        // aktualne wypozyczenia usera


        public List<Wypozyczenie> FillWypozyczeniaUseraAktualne(string key)
        {
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();

            try
            {

                string cmdText = "Select * from IWypozyczenie" +
                                    " where  " + key;      //

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Wypozyczenie w = new Wypozyczenie();
                    w.id = Convert.ToInt32(reader["id"].ToString());
                    w.idKsiazki = Convert.ToInt32(reader["idKsiazki"].ToString());
                    w.idUsera = reader["idUsera"].ToString();  // hmmmmmmmmmmmmm
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


        public List<Wypozyczenie> FillWypozyczeniaUseraArchiwalne(string key)
        {
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();

            try
            {

                string cmdText = "Select * from IWypozyczenie" +
                                    " where  " + key;      //

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Wypozyczenie w = new Wypozyczenie();
                    w.id = Convert.ToInt32(reader["id"].ToString());
                    w.idKsiazki = Convert.ToInt32(reader["idKsiazki"].ToString());
                    w.idUsera = reader["idUsera"].ToString();  // hmmmmmmmmmmmmm
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


        //////////////////////////////
        ///
        public void UpdateNaZwrot(string key, Wypozyczenie wNowe)
        {

            //key to bedzie pozycja wybrana z listywypozyczen usera wiec z IWypozyczenie

            try
            {


                comm.CommandText = "Update IWypozyczenie set idUsera= @idUsera, dataWypozyczenia = @dataWypozyczenia, dataZwrotu = @dataZwrotu, " +
                    "czyAktualne = @czyAktualne where idKsiazki = '" + key + "'";

                // comm.Parameters.AddWithValue("id", w.id);
                //comm.Parameters.AddWithValue("idKsiazki", w.idKsiazki);
                comm.Parameters.AddWithValue("@idUsera", wNowe.idUsera);
                comm.Parameters.AddWithValue("@dataWypozyczenia", wNowe.dataZwrotu);
                comm.Parameters.AddWithValue("@dataZwrotu", wNowe.dataWypozyczyenia);
                comm.Parameters.AddWithValue("@czyAktualne", wNowe.czyAktualne);


                conn.Open();
                comm.ExecuteNonQuery();

                comm.Parameters.Clear();


            }
            catch
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



        //////////////////////////////////////
        ///


        public void UpdateNaPrzedluzenie(string key, Wypozyczenie wNowe)
        {

            //key to bedzie pozycja wybrana z listywypozyczen usera wiec z IWypozyczenie

            try
            {


                comm.CommandText = "Update IWypozyczenie set idUsera= @idUsera, dataWypozyczenia = @dataWypozyczenia, dataZwrotu = @dataZwrotu, " +
                    "czyAktualne = @czyAktualne where idKsiazki = '" + key + "'";

                // comm.Parameters.AddWithValue("id", w.id);
                //comm.Parameters.AddWithValue("idKsiazki", w.idKsiazki);
                comm.Parameters.AddWithValue("@idUsera", wNowe.idUsera);
                comm.Parameters.AddWithValue("@dataWypozyczenia", wNowe.dataZwrotu);
                comm.Parameters.AddWithValue("@dataZwrotu", DateTime.UtcNow.ToLocalTime().AddDays(14));
                comm.Parameters.AddWithValue("@czyAktualne", wNowe.czyAktualne);


                conn.Open();
                comm.ExecuteNonQuery();

                comm.Parameters.Clear();


            }
            catch
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





        public bool CzyUserNieZalegazeZwrotem(string idUzytkownika)
        {

            //sprawdzamy czy data żadnej pozycji nie została przekroczona i czy limit ksiązek nie zotsał przekroczony

            //spr czy any data jest wieksza niz obecna ale tylko dla aktualnych wypozyczen 

            //where czy aktualne true i dataWypozyczenia> data aktualna - nie można wypozyczyc -i id czytelnika = id 
            // i do tego count i spr czy wieksze od 0



            //zapytanie sprawdzone w bazie danych
            /*
            select count(dataZwrotu)
            from dbo.Iwypozyczenie
            where dataZwrotu < getDate()-- tzn nie oddał
            and czyAktualne = 'true'
            and CONVERT(VARCHAR, idUsera)   = 'qqq'

            */

            //jesli wieksze od 0 tzn nie moze wypozyczyc


            try
            {


                ///////////////////////////


                string cmdText = " select count(dataZwrotu)  " +
                "from IWypozyczenie    " +
                "where dataZwrotu < getDate() " +
                "and czyAktualne = 'true' " +
                //"and CONVERT(VARCHAR, idUsera)  = 'ana'";
                "and CONVERT(VARCHAR, idUsera)  = '"  + idUzytkownika + "'";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                //SqlDataReader reader = cmd.ExecuteReader();

                Int32 count = (Int32)cmd.ExecuteScalar();

                if (count == 0)
                {
                    return true; // nie zalega

                }

                else
                    return false;


            }
            catch
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


        public int IleMaWypozyczonych(string idUzytkownika)
        {

            try
            {


                string cmdText = " select count(dataZwrotu)  " +
                     "from IWypozyczenie    " +
                      "where  " +
                      "czyAktualne = 'true' " +
                      "and CONVERT(VARCHAR, idUsera)  = '" + idUzytkownika + "'";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();


                Int32 count = (Int32)cmd.ExecuteScalar();


                return count;

            }
            catch
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
