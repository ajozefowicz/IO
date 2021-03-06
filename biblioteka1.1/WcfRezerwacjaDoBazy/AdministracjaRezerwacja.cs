﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRezerwacjaDoBazy
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class AdministracjaRezerwacja : IService1
    {


        ///
        public AdministracjaRezerwacja()
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
            connStringBuilder.InitialCatalog = "WCFRezerwacja";
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


        public int InsertRezerwacja(Rezerwacja r)
        {


            try
            {
                comm.CommandText = "Insert into IRezerwacja3 values( @idUsera, @idKsiazki, @tytul, @nazwiskoAutora, @dataZwrotu)";

                // comm.Parameters.AddWithValue("id", w.id);
                comm.Parameters.AddWithValue("idUsera", r.idUsera);
                comm.Parameters.AddWithValue("idKsiazki", r.idEgzemplarza);
                comm.Parameters.AddWithValue("tytul", r.tytul);
                comm.Parameters.AddWithValue("nazwiskoAutora", r.nazwiskoAutora); 
                comm.Parameters.AddWithValue("dataZwrotu", r.dataZwrotu);

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




        public List<Rezerwacja> SelectRezerwacjeUzytkownika(string key)
        {
            List<Rezerwacja> rezerwacje = new List<Rezerwacja>();

            try
            {

                string cmdText = "Select * from IRezerwacja3" +
                                    " where  " + key;      //

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Rezerwacja r = new Rezerwacja();
                    r.id = Convert.ToInt32(reader["id"].ToString());
                    r.idUsera = reader["idUsera"].ToString();
                    r.idEgzemplarza = Convert.ToInt32(reader["idKsiazki"].ToString());
                    r.tytul = reader["tytul"].ToString();
                    r.nazwiskoAutora= reader["nazwiskoAutora"].ToString();
                    r.dataZwrotu = Convert.ToDateTime(reader["dataZwrotu"].ToString());


                    rezerwacje.Add(r);

                }
                return rezerwacje;

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






        public bool SelectCzyKsiazkaJestNaRzerwacji(string idK)
        {

            try
            {

                string cmdText = " select count(dataZwrotu)  " +
                "from IRezerwacja3    " +
                "where idKsiazki  = '" + idK + "'";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                //SqlDataReader reader = cmd.ExecuteReader();

                Int32 count = (Int32)cmd.ExecuteScalar();

                if (count > 0)
                {
                    return true; // jest na liscie

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


        public int SelectNaKtorejUserJestPozycjiWRezerwacji(string idU, int idK)
        {

            try
            {

                ////////////////////sprawdzone w sql
               /*
   select count (*)
    from dbo.IRezerwacja3 e
    inner join dbo.IRezerwacja3 m
    on e.idKsiazki = m.idKsiazki
   and e.id >= m.id
   and e.idKsiazki=3
   and e.idUsera like 'ana'
                
    */





               string cmdText = "select count(*) " +
                    "from dbo.IRezerwacja3 e " +
                    "inner join dbo.IRezerwacja3 m " +
                    "on e.idKsiazki = m.idKsiazki " +
                    "and e.id >= m.id and e.idKsiazki = " + idK + 
                    " and CONVERT(VARCHAR, e.idUsera)  = '" + idU + "'";

                //"and e.idUsera like 'ana' "


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




        public bool DeleteRezerwacja(string key)
        {

            try
            {


                conn.Open();
                string cmddText = "Delete from IRezerwacja3 where " + key;
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



        //musi byc update, bo jak zwraca to data zwrotu musi sie zmienic
        public void UpdateNaZwrot(string key, Rezerwacja rNowa)
        {

            //key to bedzie pozycja wybrana z listywypozyczen usera wiec z IWypozyczenie

            try
            {


                comm.CommandText = "Update IRezerwacja3 set  tytul=@tytul, nazwiskoAutora=@nazwiskoAutora,   dataZwrotu=@dataZwrotu where idKsiazki = '" + key + "'";



                //comm.CommandText = "Insert into IRezerwacja3 values( @idUsera, @idKsiazki, @tytul, @nazwiskoAutora, @dataZwrotu)";

                // comm.Parameters.AddWithValue("id", w.id);
              //  comm.Parameters.AddWithValue("idUsera", rNowa.idUsera);
               // comm.Parameters.AddWithValue("idKsiazki", r.idKsiazki);
                comm.Parameters.AddWithValue("tytul", rNowa.tytul);
                comm.Parameters.AddWithValue("nazwiskoAutora", rNowa.nazwiskoAutora);
                comm.Parameters.AddWithValue("dataZwrotu", rNowa.dataZwrotu);



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


        public void UpdateNaPrzedluzenie(string key, Rezerwacja rNowa)
        {

            try
            {


                comm.CommandText = "Update IRezerwacja3 set  dataZwrotu = @dataZwrotu " +
                    " where idKsiazki = '" + key + "'";


                comm.Parameters.AddWithValue("@dataZwrotu", rNowa.dataZwrotu);//DateTime.UtcNow.ToLocalTime().AddDays(14));



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







        public bool SelectCzyUserJuzZarezerowalDanaKsiazka(string idK, string idU) //jesli true to nie moze zarezerowac drugi raz
        {

            try
            {

                string cmdText = " select count(dataZwrotu)  " +
                "from IRezerwacja3    " +
                "where CONVERT(VARCHAR, idUsera)  = '" + idU + "' "+
                "and idKsiazki  = '" + idK + "'";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                conn.Open();

                //SqlDataReader reader = cmd.ExecuteReader();

                Int32 count = (Int32)cmd.ExecuteScalar();

                if (count > 0)
                {
                    return true; // jest na liscie

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


    }
}
