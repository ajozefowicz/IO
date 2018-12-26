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

        public int InsertUser(Uzytkownik u)
        {


            try
            {
                comm.CommandText = "Insert into IUzytkownik values(@id, @haslo, @imie, @nazwisko, @pesel, @email)";

                comm.Parameters.AddWithValue("id", u.id);
                comm.Parameters.AddWithValue("haslo", u.haslo);
                comm.Parameters.AddWithValue("imie", u.imie);
                comm.Parameters.AddWithValue("nazwisko", u.nazwisko);
                comm.Parameters.AddWithValue("pesel", u.pesel);
                comm.Parameters.AddWithValue("email", u.emaileee);



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



            //wypelnanie ListBoxa




        }


        public List<Uzytkownik> FillListBoxUzytkownicy()
        {

            List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();


            try
            {
                string cmdText = "Select * from IUzytkownik";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Uzytkownik uz = new Uzytkownik();
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

        public List<Uzytkownik> FillListBoxUserzyTabela()
        {

            List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();


            try
            {

                ////////////////////////////////// wersja 


                string cmdText = "Select * from IUzytkownik";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Uzytkownik uz = new Uzytkownik();
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
        /////////////////////////////////////////////////////
        ///
        public void DeleteUser (Uzytkownik u)
        {

            try
            {
                
                string cmddText = "Delete from IUzytkownik where id = @id";
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

        public bool DeleteUser2(string key)
        {

            try
            {


                conn.Open();
                string cmddText = "Delete from IUzytkownik where " + key;
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

       


    }
}
