/**************************************************************************
 *                                                                        *
 *  File:        Day_DB                                                   *
 *                                                                        *
 *  Descriere:   Clasa pentru inserearea in tabela DayDb                  *  
 *                                                                        *
 *  Autor:  Victor Teslaru                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Day_DB
{
    public class Day_DB
    {
        /// <summary>
        /// Se face conexiune la server 
        /// </summary>
        private SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-SJBG723\SQLEXPRESS;Initial Catalog=Persoane_Db;Integrated Security=True");

        public void addData(string Name,int Calorii,int Day)
        {
            try
            {
                ///<summary>
                ///Se face conexiunea la baza de date
                ///</summary>
                conex.Open();

                /// <summary>
                /// Comanda de inserare in baza de date
                /// </summary>
                SqlCommand comm = new SqlCommand("INSERT INTO [DayDB] (Name,Calorii,Day) values(@Name,@Calorii,@Days)", conex);
                /// <summary>
                /// Se adauga parametrii introdusi ca argumente 
                /// </summary>
                comm.Parameters.AddWithValue("@Name",Name);
                comm.Parameters.AddWithValue("@Calorii", Calorii);
                comm.Parameters.AddWithValue("@Days",Day);
                var tmp = comm.ExecuteNonQuery();
                Console.WriteLine(tmp);
                Console.WriteLine("Merge inserare in baza de date");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la introducere date in BD: " + ex.Message);
            }
            finally
            {
                ///<summary>
                ///Se inchide conexiunea
                ///</summary>
                conex.Close();
            }


        }

        public int getDay(string Name)
        {
            int day = 0;
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere DB in Day_DB" ,ex.Message);
            }
            try
            {

                /// <summary>
                /// Comanda de extragere a zilei din baza de date 
                /// </summary>
                SqlCommand comm = new SqlCommand("Select Day from DayDB where Name=@Name", conex);
                comm.Parameters.AddWithValue("@Name", Name);
                comm.ExecuteNonQuery();
                
                var Day =comm.ExecuteScalar();

                /// <summary>
                /// Se verifica daca baza de date este goala
                /// </summary>
                if (Day == null)
                {
                    return 0;   
                }
                else
                {
                    /// <summary>
                    /// Daca baza de date nu este goala atunci se returneaza ziua
                    /// </summary>
                    day = (int)Day;
                    return day;
                }
                
                
            }catch(Exception ex)
            {
                Console.WriteLine("Eraore la cautare in baza de date Day_DB" ,ex.Message);
            }
            finally {

                /// <summary>
                /// Inchidere baza de date
                /// </summary>
                conex.Close(); 
            }
            return 0;
          
        }

    
        public int GetLastDay(string Name)
        {
            /// <summary>
            /// Initializare variabila care va retine ultima zi
            /// </summary>
            int day = 0;
            try
            {
                /// <summary>
                /// Se creaza conexiunea cu baza de date
                /// </summary>
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere DB in Day_DB", ex.Message);
            }
            try
            {
                /// <summary>
                /// Comanda ce va return cea mai mare zi din baza de date unde numele userului este data ca parametru
                /// </summary>
                SqlCommand comm = new SqlCommand("Select Max(Day) from DayDB where Name=@Name", conex);
                comm.Parameters.AddWithValue("@Name", Name);
                comm.ExecuteNonQuery();

                var Day = comm.ExecuteScalar();
                /// <summary>
                /// Se verifica daca baza de date ste goala/daca da se rturneaza 0
                /// </summary>
                if (Day == null)
                {
                    return 0;
                }
                else
                {
                    /// <summary>
                    /// Daca baza de date nu este gola se returneaza cea mai mare zi
                    /// </summary>
                    day = (int)Day;
                    return day;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Eraore la cautare in baza de date Day_DB", ex.Message);
            }
            finally
            {
                /// <summary>
                /// Se inchide conexiunea cu baza de date
                /// </summary>
                conex.Close();
            }
            return 0;

        }
        /// <summary>
        /// Functia va return o lista cu toate valorile Day bazei de date
        /// </summary>
        public List<int> getAllDays(string name)
            {
            /// <summary>
            /// Initializare lista ce va tine toate Day al bazei de date
            /// </summary>    
            List<int> dayList = new List<int>();

            /// <summary>
            /// Comanda ce returneza valoarea Day ,dupa un nume dat ca parametru
            /// </summary>
            string query = "SELECT Day FROM [DayDB] where Name=@name";

            /// <summary>
            /// Se face conexiunea la baza de date
            /// </summary>
            conex.Open();
                SqlCommand comm = new SqlCommand(query, conex);
                

            comm.Parameters.AddWithValue("@name",name );



            /// <summary>
            /// Se citeste fiecare rand din baza de date 
            /// </summa
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {

                /// <summary>
                /// Cat timp se citeste din baza de date ,valorile din Coloana Day sun introduse in Lista dayList
                /// </summary>
                int day = reader.GetInt32(0);
                dayList.Add(day);
            }
            /// <summary>
            /// Se inchide conexiune cu baza de date
            /// </summary>
            conex.Close();

            return dayList;   
        }


        /// <summary>
        /// Functia va return o lista cu toate valorile Calories al  bazei de date
        /// </summary>
        public List<float> GetAllCalories(string name)
        {
            /// <summary>
            /// Initializare lista ce va tine toate elementele Calories al bazei de date
            /// </summary>   
            List<float> CalList = new List<float>();


            /// <summary>
            /// Comanda ce returneza valoarea Calories ,dupa un nume dat ca parametru
            /// </summary>
            string query = "SELECT Calorii FROM [DayDB] where Name=@name";

            /// <summary>
            /// Se deschide baza de date
            /// </summary>
            conex.Open();
            SqlCommand comm = new SqlCommand(query, conex);
            
            comm.Parameters.AddWithValue("@name", name);
            /// <summary>
            /// Se citeste fiecare linie din baza de date
            /// </summary>
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                /// <summary>
                /// Se converteste valoarea returnata din baza de date in float
                /// </summary>
                var Cal = reader.GetValue(0);
                float call = Convert.ToSingle(Cal);
                /// <summary>
                ///  Cat timp se citeste din baza de date elementele extrase vor fi adaugate in lista CalList
                /// </summary>
                CalList.Add(call);
            }

            ///<summary>  
            /// Se inchide conexiunea la baza de date  
            ///</summary> 


            conex.Close();

            return CalList;
        }
    }
}

