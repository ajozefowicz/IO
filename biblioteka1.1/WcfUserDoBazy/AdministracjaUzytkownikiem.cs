using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfUserDoBazy
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class AdministracjaUzytkownikiem : IService1
    {

        public AdministracjaUzytkownikiem()
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
            connStringBuilder.InitialCatalog = "WCFUzytkownik";
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

        public int InsertCzytelnik(Czytelnik u) // czytelnik
        {
            try
            {
                comm.CommandText = "Insert into IUzytkownik2 values(@id, @haslo, @imie, @nazwisko, @pesel, @email, @limit, @maxCzasWypozyczenia, @kategoria, @stanowisko)";

                comm.Parameters.AddWithValue("id", u.id);
                comm.Parameters.AddWithValue("haslo", u.haslo);
                comm.Parameters.AddWithValue("imie", u.imie);
                comm.Parameters.AddWithValue("nazwisko", u.nazwisko);
                comm.Parameters.AddWithValue("pesel", u.pesel);
                comm.Parameters.AddWithValue("email", u.emaileee);

                comm.Parameters.AddWithValue("limit", u.limit);
                comm.Parameters.AddWithValue("maxCzasWypozyczenia", u.maxCzasWypozyczenia);
                comm.Parameters.AddWithValue("kategoria", u.kategoria);
                comm.Parameters.AddWithValue("stanowisko", "nie dotyczy");


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



        public int InsertPracownik(Pracownik u)
        {


            try
            {
                comm.CommandText = "Insert into IUzytkownik2 values(@id, @haslo, @imie, @nazwisko, @pesel, @email, @limit, @maxCzasWypozyczenia, @kategoria, @stanowisko)";

                comm.Parameters.AddWithValue("id", u.id);
                comm.Parameters.AddWithValue("haslo", u.haslo);
                comm.Parameters.AddWithValue("imie", u.imie);
                comm.Parameters.AddWithValue("nazwisko", u.nazwisko);
                comm.Parameters.AddWithValue("pesel", u.pesel);
                comm.Parameters.AddWithValue("email", u.emaileee);

                comm.Parameters.AddWithValue("limit", u.limit);
                comm.Parameters.AddWithValue("maxCzasWypozyczenia", u.maxCzasWypozyczenia);
                comm.Parameters.AddWithValue("kategoria", u.kategoria);
                comm.Parameters.AddWithValue("stanowisko", u.stanowisko);


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



        //tego juz nie uzywamy
        public List<Czytelnik> SelectUzytkownicy()
        {

            List<Czytelnik> uzytkownicy = new List<Czytelnik>();


            try
            {
                string cmdText = "Select * from IUzytkownik2";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Czytelnik uz = new Czytelnik();
                    uz.id = reader["id"].ToString();
                    uz.haslo = reader["haslo"].ToString();
                    uz.imie = reader["imie"].ToString();
                    uz.nazwisko = reader["nazwisko"].ToString();
                    uz.pesel = reader["pesel"].ToString();
                    uz.emaileee = reader["email"].ToString();

                    uzytkownicy.Add(uz);

                }
                return uzytkownicy;

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
            ///////////////////////////////
            ///



            public List<Czytelnik> SelectCzytelnicy()
        {

            List<Czytelnik> uzytkownicy = new List<Czytelnik>();


            try
            {

                ////////////////////////////////// wersja 


                string cmdText = "Select * from IUzytkownik2 where CONVERT(VARCHAR, kategoria) not like 'pracownik'";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Czytelnik uz = new Czytelnik();
                    uz.id = reader["id"].ToString();
                    uz.haslo = reader["haslo"].ToString();
                    uz.imie = reader["imie"].ToString();
                    uz.nazwisko = reader["nazwisko"].ToString();
                    uz.pesel = reader["pesel"].ToString();
                    uz.emaileee = reader["email"].ToString();

                    uz.kategoria = reader["kategoria"].ToString();
                    uz.limit = Convert.ToInt32(reader["limit"].ToString());
                    uz.maxCzasWypozyczenia = Convert.ToInt32(reader["maxCzasWypozyczenia"].ToString());



                    uzytkownicy.Add(uz);


                }
                return uzytkownicy;


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




        public List<Pracownik> SelectPracownicy()
        {

            List<Pracownik> uzytkownicy = new List<Pracownik>();


            try
            {

                ////////////////////////////////// wersja 


                string cmdText = "Select * from IUzytkownik2 where CONVERT(VARCHAR, kategoria)  like 'pracownik' ";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Pracownik uz = new Pracownik();
                    uz.id = reader["id"].ToString();
                    uz.haslo = reader["haslo"].ToString();
                    uz.imie = reader["imie"].ToString();
                    uz.nazwisko = reader["nazwisko"].ToString();
                    uz.pesel = reader["pesel"].ToString();
                    uz.emaileee = reader["email"].ToString();

                    uz.kategoria = reader["kategoria"].ToString();
                    uz.limit = Convert.ToInt32(reader["limit"].ToString());
                    uz.maxCzasWypozyczenia = Convert.ToInt32(reader["maxCzasWypozyczenia"].ToString());
                    uz.stanowisko = reader["stanowisko"].ToString();



                    uzytkownicy.Add(uz);


                }
                return uzytkownicy;


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












        /////////////////////////////////////////////////////
        ///
        public void DeleteUzytkownik (Uzytkownik u)
        {

            try
            {
                
                string cmddText = "Delete from IUzytkownik2 where id = @id";
                SqlCommand cmd = new SqlCommand(cmddText, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                

                //SqlCommand cmd = new SqlCommand (Delate from IUzytkonicy where id = dataG, conn)
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

        ///////////
        ///

        public bool DeleteUzytkownik2(string key)
        {

            try
            {


                conn.Open();
                string cmddText = "Delete from IUzytkownik2 where " + key;
                SqlCommand cmd = new SqlCommand(cmddText, conn);
                cmd.ExecuteNonQuery();
                return true;


                //SqlCommand cmd = new SqlCommand (Delate from IUzytkonicy where id = dataG, conn)
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

        ///////////////////////////////////////////////////////
        //powitanie uzytkownika

        public void powitajUsera(string p)
        {
            string powitanie = null; //label7witajUser

            string nazwa_Usera = null; //textBox1_loginCzytelnika

            powitanie = nazwa_Usera;
        }



        public int SelectLimitUzytkownika(string key, string idU)
        {

            //List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();


            try
            {


                string cmdText = "Select limit from IUzytkownik2" +
                                    " where  " + key;


                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                int wynik = 0;

                while (reader.Read())
                {

                    Uzytkownik c = new Czytelnik();
                    c.limit = Convert.ToInt32(reader["limit"].ToString());

                    wynik = c.limit;

                    //wypozyczenia.Add(w);


                }
                return wynik;


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





        public int SelectMaxCzasWypozyczeniaUsera(string key, string idU)
        {



            try
            {


                string cmdText = "Select maxCzasWypozyczenia from IUzytkownik2" +
                                    " where  " + key;


                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                int wynik = 0;

                while (reader.Read())
                {

                    Uzytkownik c = new Czytelnik();
                    c.maxCzasWypozyczenia = Convert.ToInt32(reader["maxCzasWypozyczenia"].ToString());

                    wynik = c.maxCzasWypozyczenia;

                    //wypozyczenia.Add(w);


                }
                return wynik;


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
