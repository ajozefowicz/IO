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

                //LICZY SIE TO W JAKIEJ KOLEJNOSCI TU SA POLA WPISANE, TAK DODAJE DO BAZY
                comm.CommandText = "Insert into IKsiazka values(@id, @tytul, @stan, @rodzaj, @licznikWypozyczen," +
                    " @dataWypozyczenia, @dataZwrotu, @licznikPrzedluzen, @iloscStron, @imieAutora, @nazwiskoAutora, @nrISBN )";


                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("2000-12-12");

                string dataZero = Convert.ToString(DateTime.UtcNow.ToLocalTime());

                var aaa = DateTime.Parse(dataZero);

                DateTime myDateTime2 = DateTime.Now;
                string sqlFormattedDate2 = myDateTime.ToString("20001212");

                comm.Parameters.AddWithValue("@id", k.id);
                comm.Parameters.AddWithValue("@tytul", k.tytul);
                comm.Parameters.AddWithValue("@stan", k.stan);
                comm.Parameters.AddWithValue("@rodzaj", k.rodzaj);
                comm.Parameters.AddWithValue("@licznikWypozyczen", k.licznikWypozyczen);
                comm.Parameters.AddWithValue("@dataWypozyczenia", DateTime.UtcNow.ToLocalTime()); //DateTime.UtcNow.ToLocalTime()
                comm.Parameters.AddWithValue("@dataZwrotu", DateTime.UtcNow.ToLocalTime()); // tez można podac "2010-10-10"
                comm.Parameters.AddWithValue("@licznikPrzedluzen", k.licznikPrzedluzen);
                comm.Parameters.AddWithValue("@iloscStron", k.iloscStron);
                comm.Parameters.AddWithValue("@imieAutora", k.imieAutora);
                comm.Parameters.AddWithValue("@nazwiskoAutora", k.nazwiskoAutora);
                comm.Parameters.AddWithValue("@nrISBN", k.nrISBN);


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



        //  POKAZ KSIAZKI DLA PANELU cZYTELNIKA


        public List<string> FillListBoxKsiazki()
        {

            WCFKsiazkaDataSet wc = new WCFKsiazkaDataSet();

            List<Ksiazka> ksiazki = new List<Ksiazka>();

            List<string> stringi = new List<string>();

            try
            {

                ////////////////////////////////// wersja 1 
                
                
                string cmdText = "Select tytul, id, stan, imieAutora, nazwiskoAutora, nrISBN from IKsiazka";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Ksiazka ks = new Ksiazka();
                    ks.tytul = reader["tytul"].ToString();
                    ks.id = Convert.ToInt32(reader["id"].ToString());
                    
                    ks.stan = Convert.ToBoolean(reader["stan"].ToString());
                    ks.imieAutora = reader["imieAutora"].ToString();
                    ks.nazwiskoAutora = reader["nazwiskoAutora"].ToString();
                    ks.nrISBN = reader["nrISBN"].ToString();


                    string ss = ks.id + " " + ks.tytul + " " + ks.stan + " " + ks.imieAutora + " " + ks.nazwiskoAutora + " " + ks.nrISBN;
                    

                    stringi.Add(ss);

                }
                return stringi;

                



                ///////////////////// wersja 2 nic nie wyswietla
                /*
                var data = from o in wc.IKsiazka
                          select o ;
                //List<object> baba = data.ToList();
         
                foreach (var item in data)
               {
                    // Wypisujemy podstawowe informacje

                    string ss = item.id + item.tytul + item.stan + item.imieAutora + item.nazwiskoAutora + item.nrISBN;
                    //Console.WriteLine("Id: {0}, Numer: {1}, Nazwa: {2}", item.ProductID, item.ProductNumber, item.Name);

                    

                    stringi.Add(ss);

                }

                */

                ////////////// wersja 3 - nic
                ///
                
                /*
                var employees = from emps in wc.IKsiazka

                                select new
                {
                    emps.id,
                    emps.tytul,
                    emps.stan,
                    emps.nazwiskoAutora,
                    emps.imieAutora,
                    emps.nrISBN,

                };

                  return employees;

                
                */

                /*


                   foreach (var item in employees)
                   {

                       string ss = item.id + item.tytul + item.stan + item.imieAutora + item.nazwiskoAutora + item.nrISBN;

                    stringi.Add(ss);

                    }

                       return stringi; 
                */
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


        ////////////////////

        //  POKAZ KSIAZKI DLA PANELU CZYTELNIKA


        public List<Ksiazka> FillListBoxKsiazkiTabela ()
        {

            WCFKsiazkaDataSet wc = new WCFKsiazkaDataSet();

            List<Ksiazka> ksiazki = new List<Ksiazka>();

            List<string> stringi = new List<string>();

            try
            {

                ////////////////////////////////// wersja 


                string cmdText = "Select tytul, id, stan, imieAutora, nazwiskoAutora, nrISBN from IKsiazka";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Ksiazka ks = new Ksiazka();
                    ks.tytul = reader["tytul"].ToString();
                    ks.id = Convert.ToInt32(reader["id"].ToString());

                    ks.stan = Convert.ToBoolean(reader["stan"].ToString());
                    ks.imieAutora = reader["imieAutora"].ToString();
                    ks.nazwiskoAutora = reader["nazwiskoAutora"].ToString();
                    ks.nrISBN = reader["nrISBN"].ToString();


                    //string ss = ks.id + ks.tytul + ks.stan + ks.imieAutora + ks.nazwiskoAutora + ks.nrISBN;


                    ksiazki.Add(ks);

                }
                return ksiazki;





                ///////////////////// wersja 2 nic nie wyswietla
                /*
                var data = from o in wc.IKsiazka
                          select o ;
                //List<object> baba = data.ToList();
         
                foreach (var item in data)
               {
                    // Wypisujemy podstawowe informacje

                    string ss = item.id + item.tytul + item.stan + item.imieAutora + item.nazwiskoAutora + item.nrISBN;
                    //Console.WriteLine("Id: {0}, Numer: {1}, Nazwa: {2}", item.ProductID, item.ProductNumber, item.Name);

                    

                    stringi.Add(ss);

                }

                */

                ////////////// wersja 3 - nic
                ///

                /*
                var employees = from emps in wc.IKsiazka

                                select new
                {
                    emps.id,
                    emps.tytul,
                    emps.stan,
                    emps.nazwiskoAutora,
                    emps.imieAutora,
                    emps.nrISBN,

                };

                  return employees;

                
                */

                /*


                   foreach (var item in employees)
                   {

                       string ss = item.id + item.tytul + item.stan + item.imieAutora + item.nazwiskoAutora + item.nrISBN;

                    stringi.Add(ss);

                    }

                       return stringi; 
                */
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



        //  POKAZ KSIAZKI DLA PANELU PRACOWNIKA


        public List<Ksiazka> FillListBoxKsiazkiPanelPracownika()
        {

            List<Ksiazka> ksiazki = new List<Ksiazka>();


            try
            {
                string cmdText = "Select id, tytul, stan, rodzaj, imieAutora, nazwiskoAutora, nrISBN, dataWypozyczenia" +
                    ", dataZwrotu, licznikWypozyczen, licznikPrzedluzen, iloscStron from IKsiazka";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Ksiazka ks = new Ksiazka();
                    ks.tytul = reader["tytul"].ToString();
                    ks.id = Convert.ToInt32(reader["id"].ToString());
                    ks.stan = Convert.ToBoolean(reader["stan"].ToString());
                    ks.rodzaj = reader["rodzaj"].ToString();
                    ks.imieAutora = reader["imieAutora"].ToString();
                    ks.nazwiskoAutora = reader["nazwiskoAutora"].ToString();
                    ks.nrISBN = reader["nrISBN"].ToString();
                    ks.dataWypozyczenia = Convert.ToDateTime(reader["dataWypozyczenia"].ToString());
                    ks.dataZwrotu = Convert.ToDateTime(reader["dataZwrotu"].ToString());
                    ks.licznikWypozyczen = Convert.ToInt32(reader["licznikWypozyczen"].ToString());
                    ks.licznikPrzedluzen = Convert.ToInt32(reader["licznikPrzedluzen"].ToString());
                    ks.iloscStron = Convert.ToInt32(reader["iloscStron"].ToString());



                    ksiazki.Add(ks);

                }
                return ksiazki;

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


        /////////////////////////////////
        public List<Ksiazka> FillListBoxksiazkiTabela()
        {

            List<Ksiazka> ksiazki = new List<Ksiazka>();


            try
            {

                ////////////////////////////////// wersja 


                string cmdText = "Select * from IKsiazka";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Ksiazka ks = new Ksiazka();
                    ks.tytul = reader["tytul"].ToString();
                    ks.id = Convert.ToInt32(reader["id"].ToString());
                    ks.stan = Convert.ToBoolean(reader["stan"].ToString());
                    ks.rodzaj = reader["rodzaj"].ToString();
                    ks.imieAutora = reader["imieAutora"].ToString();
                    ks.nazwiskoAutora = reader["nazwiskoAutora"].ToString();
                    ks.nrISBN = reader["nrISBN"].ToString();
                    ks.dataWypozyczenia = Convert.ToDateTime(reader["dataWypozyczenia"].ToString());
                    ks.dataZwrotu = Convert.ToDateTime(reader["dataZwrotu"].ToString());
                    ks.licznikWypozyczen = Convert.ToInt32(reader["licznikWypozyczen"].ToString());
                    ks.licznikPrzedluzen = Convert.ToInt32(reader["licznikPrzedluzen"].ToString());
                    ks.iloscStron = Convert.ToInt32(reader["iloscStron"].ToString());

                    ksiazki.Add(ks);


                }
                return ksiazki;


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


        //////////////////
        ///
        public bool DeleteKsiazka2(string key)
        {
            try
            {
                conn.Open();
                string cmddText = "Delete from IKsiazka where " + key;
                SqlCommand cmd = new SqlCommand(cmddText, conn);
                cmd.ExecuteNonQuery();
                return true;

            }

            catch
            {
                throw;
                //return false;
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        //////////////////////////////////////// wyszukiwanie przez userea


        public List<Ksiazka> FillListBoxKsiazkiWybranePrzezUsera(string key)
        {

            WCFKsiazkaDataSet wc = new WCFKsiazkaDataSet();

            List<Ksiazka> ksiazki = new List<Ksiazka>();
            try
            {


                string cmdText = "Select imieAutora, nazwiskoAutora, tytul, nrISBN, stan, id from IKsiazka" +
                    " where  " + key;      //textBox_imieAutora.Text

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Ksiazka ks = new Ksiazka();
                    ks.tytul = reader["tytul"].ToString();
                    ks.imieAutora = reader["imieAutora"].ToString();
                    ks.nazwiskoAutora = reader["nazwiskoAutora"].ToString();
                    ks.nrISBN = reader["nrISBN"].ToString();
                    ks.stan = Convert.ToBoolean(reader["stan"].ToString());
                    ks.id = Convert.ToInt32(reader["id"].ToString());

                    //string ss = ks.id + " " + ks.tytul + " " + ks.stan + " " + ks.imieAutora + " " + ks.nazwiskoAutora + " " + ks.nrISBN;


                    ksiazki.Add(ks);

                }
                return ksiazki;


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
