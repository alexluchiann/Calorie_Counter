/**************************************************************************
 *                                                                        *
 *  File:        DB_DLL                                                   *
 *                                                                        *
 *  Descriere:   Clasa care se ocupa de inserarea in tabela Register Tabel*
 *                de unde se extrag date pentru a fi folosite in program  *
 *  Autor:  Luchian Alexandru                                             *
 *                                                                        *
 *                                                                        *
 **************************************************************************/



using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security;


namespace DB_DLL
{
    public class DB_Class
    {

        ///<summary>  
        ///  Se face conexiunea la serverul local
        ///</summary>
        private SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-SJBG723\SQLEXPRESS;Initial Catalog=Persoane_Db;Integrated Security=True");

        public void addData(string User, string parola, float greutate, float inaltime, int varsta, string sex, string Niv_Activ)
        {
            try
            {
                ///<summary>
                ///Se face conexiunea la baza de date
                ///</summary>
                conex.Open();
                

                ///<summary>  
                ///  Variabila ce va tine locul Scopului pana aceasta va fi introdusa ,
                ///</summary>
                int scop = 999;

                ///<summary>  
                ///  Comanda ce insereaza in baza de date datele date ca parametru
                ///</summary>
                SqlCommand comm = new SqlCommand("INSERT INTO [Register_Tabel] (Utilizator,Parola,Greutate,Inaltime,Varsta,Sex,Nivel_Activitate,Scop) values(@Utilizator,@Parola,@Greutate,@Inaltime,@Varsta,@Sex,@Nivel_Activitate,@Scop)", conex);
                comm.Parameters.AddWithValue("@Utilizator", User);
                comm.Parameters.AddWithValue("@Parola", parola);
                comm.Parameters.AddWithValue("@Greutate", greutate);
                comm.Parameters.AddWithValue("@Inaltime", inaltime);
                comm.Parameters.AddWithValue("@Varsta", varsta);
                comm.Parameters.AddWithValue("@Sex", sex);
                comm.Parameters.AddWithValue("@Nivel_Activitate", Niv_Activ);
                comm.Parameters.AddWithValue("@Scop", scop);

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
        ///<summary>
        ///Verifica daca Username si parola 
        ///</summary>
        public int check(string User, string parola)
        {
            int verif = 1;
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere BD in functia check: " + ex.Message);

            }
            try
            {
                ///<summary>
                ///Se incearca cautare in Baza de Date a User si parola
                ///</summary
                SqlCommand comm = new SqlCommand($"select count(*) from [Register_Tabel] where [Utilizator]=@Utilizator AND [Parola]=@Parola", conex);
                comm.Parameters.AddWithValue("@Utilizator", User);
                comm.Parameters.AddWithValue("@Parola", parola);
                try
                {
                    ///<summary>  
                    ///  Daca exista se va returna o valoare deiferita de 0
                    ///</summary>
                    verif = Convert.ToInt32(comm.ExecuteScalar());
                }
                catch
                {
                    ///<summary>  
                    ///  Daca nu exista usernamul si parola se va return 0
                    ///</summary>
                    verif = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare BD in functia check: " + ex.Message);
            }
            finally
            {
                ///<summary>  
                ///  Se inchide conexiunea cu baza de date
                ///</summary>
                conex.Close();
            }

            return verif;
        }

        public int getAge(string User, string parola)
        {
            int Age = 0;
            try
            {

                ///<summary>  
                ///  Se incearca deschiderea bazei de date 
                ///</summary>
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere BD in functia getAge" + ex.Message);
            }

            try
            {
                ///<summary>  
                ///  Se extrage varsta in funcite de usernam si parola 
                ///</summary>
                SqlCommand comm = new SqlCommand("SELECT Varsta FROM [Register_Tabel] where [Utilizator]=@Utilizator And [Parola]=@Parola", conex);
                comm.Parameters.AddWithValue("@Utilizator", User);
                comm.Parameters.AddWithValue("@Parola", parola);
                comm.ExecuteNonQuery();
                ///<summary>  
                ///  Se returneaza Varsta 
                ///</summary>
                Age = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in baza de date in functia getAge" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea Bazei de date in functia getAge" + ex.Message);
            }
            return Age;
        }

        public float getGreutate(string User, string parola)
        {
           
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getGreut" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Greutate from [Register_Tabel] where [Utilizator]=@Utilizator and Parola=@Parola", conex);
                conn.Parameters.AddWithValue("@Utilizator", User);
                conn.Parameters.AddWithValue("@Parola", parola);
                conn.ExecuteNonQuery();
                var GG =conn.ExecuteScalar();
                float Greut = Convert.ToSingle(GG);
                return Greut;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getGreutate" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getGreut" + ex.Message);
            }
            return 0;

        }

        public float getInaltime(string User, string parola)
        {
            
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getInaltime" + ex.Message);
            }
            try
            {
               
                SqlCommand conn = new SqlCommand("Select Inaltime from [Register_Tabel] where [Utilizator]=@Utilizator and Parola=@Parola ", conex);
                conn.Parameters.AddWithValue("@Utilizator", User);
                conn.Parameters.AddWithValue("@Parola", parola);
                conn.ExecuteNonQuery();
                var height = conn.ExecuteScalar();
      
                float HG = Convert.ToSingle(height);
                return HG;

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Exceptie SQL" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getInaltime" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getInaltime" + ex.Message);
            }

            return 0;

        }

        public string getSex(string User, string parola)
        {
            string sex = "";
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getSex" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Sex from [Register_Tabel] where [Utilizator]=@Utilizator and Parola=@Parola", conex);
                conn.Parameters.AddWithValue("@Utilizator", User);
                conn.Parameters.AddWithValue("@Parola", parola);
                conn.ExecuteNonQuery();
                sex = (string)conn.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getSex" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getSex" + ex.Message);
            }
            return sex;

        }



        public string get_Activity_Level(string User, string parola)
        {
            string ACT_LVL = "";
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct get_Activity_Level" + ex.Message);
            }
            try
            {
                SqlCommand conn = new SqlCommand("Select Sex from [Register_Tabel] where [Utilizator]=@Utilizator and Parola=@Parola", conex);
                conn.Parameters.AddWithValue("@Utilizator", User);
                conn.Parameters.AddWithValue("@Parola", parola);
                conn.ExecuteNonQuery();
                ACT_LVL = (string)conn.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct get_Activity_Level" + ex.Message);
            }
            try
            {
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct get_Activity_Level" + ex.Message);
            }
            return ACT_LVL;

        }

        public int AlreadyExist(string user) {
            //Variabila cu ajutorul careia aflam daca Userul este deja in baza de date
            int verif = 0;
            try
            {
                ///<summary>
                ///Se incearca conectarea la Baza de Date
                ///</summary>
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceptie la deschiderea bazei de date in fct AlreadyExists");
            }
            try
            {
                ///<summary>
                ///Se cauta in baza de date Userul
                ///</summary>
                SqlCommand comm = new SqlCommand("SELECT * from [Register_Tabel] where Username='" + user + "'", conex);
                verif = (int)comm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in baza de date " + ex.Message);
            }
            try
            {
                //Se inchide coneziunea
                conex.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inchiderea bazei de date in functia AlreadyExists" + ex.Message);
            }
            return verif;

        }
        public void ADD_SCOP(string user, string pass, int scope)
        {

            ///<summary>  
            ///  Comanda ce Updateaza scopul in baza de date
            ///</summary>
            string Update = "UPDATE [Register_Tabel] SET Scop  = @Scop WHERE Utilizator = @Utilizator AND Parola = @Parola";
            
            try
            {
                ///<summary>  
                ///  Se incearca deschiderea bazei de date 
                ///</summary>
                conex.Open();
                using (SqlCommand comm = new SqlCommand(Update, conex))
                {
                    comm.Parameters.AddWithValue("@Scop", scope);
                    comm.Parameters.AddWithValue("@Utilizator", user);
                    comm.Parameters.AddWithValue("@Parola", pass);

                    comm.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("AN SQL exception occures " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la inserare in functia ADD_SCOPE  ,A aparut o eorare", ex.Message);
            }


        }

        public int getScop(string User, string parola)
        {
            int Scopul = 0;
            try
            {
                
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erare la deschidere BD in fct getScop" + ex.Message);
            }
            try
            {
                ///<summary>  
                ///  Se extrage valoarea scop din baza de date 
                ///</summary>
                SqlCommand conn = new SqlCommand("Select Scop from [Register_Tabel] where [Utilizator]=@Utilizator and Parola=@Parola", conex);
                conn.Parameters.AddWithValue("@Utilizator", User);
                conn.Parameters.AddWithValue("@Parola", parola);
                //conn.ExecuteNonQuery();
                ///<summary>  
                ///  se updateaza variabila Scop 
                ///</summary>
                var rez = conn.ExecuteScalar();
                Scopul = (int)rez;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautarea in baza de date in fct getScop" + ex.Message);
            }
            try
            {
                ///<summary>  
                ///  Se inchide conexiunea la baza de date 
                ///</summary>
                conex.Close();
            }
            catch (Exception ex)


            {
                Console.WriteLine("Eroare la inchiderea bazei de date in fct getScop" + ex.Message);
            }
            return Scopul;

        }






    }
}