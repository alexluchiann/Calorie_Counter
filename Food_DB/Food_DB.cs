/**************************************************************************
 *                                                                        *
 *  File:        Food_DB.cs                                               *
 *                                                                        *
 *  Descriere:   Clasa ce  se ocupa cu inserare in tabela Alimnete_Tabel  *
 *               date care vor fi folosite in program                     *
 *  Autor:  Luchian Alexandru                                             *
 *                                                                        *
 *                                                                        *
 **************************************************************************/





using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Food;
using System.Windows;

namespace Food_DB
{
    public class Food_DB
    {

        ///<summary>  
        ///  Se face conexiunea la serverul local
        ///</summary>
        private SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-SJBG723\SQLEXPRESS;Initial Catalog=Persoane_Db;Integrated Security=True");


        
        private Food.Food Alimente = new Food.Food();

        ///<summary>  
        ///  Lista in care s-au incarcat toate alimentele 
        ///</summary>
        private List<Food.Food> foodList = new List<Food.Food>();


        /*public void InsertFood()
        {
            ///             Legume 
            Food.Food.AddFood(foodList, "Morcov", 41, 0.9, 0.2, 9.6);
            Food.Food.AddFood(foodList, "Rosii", 18, 0.9, 0.2, 3.9);
            Food.Food.AddFood(foodList, "Broccoli", 34, 2.8, 0.4, 6.6);
            Food.Food.AddFood(foodList, "Spanac", 23, 2.9, 0.4, 3.6);
            Food.Food.AddFood(foodList, "Salată verde", 5, 0.5, 0.1, 1.0);
            Food.Food.AddFood(foodList, "Ceapă", 40, 1.1, 0.1, 9.3);
            Food.Food.AddFood(foodList, "Ardei gras", 31, 1.3, 0.3, 5.5);
            Food.Food.AddFood(foodList, "Conopidă", 25, 1.9, 0.3, 4.9);
            Food.Food.AddFood(foodList, "Dovlecel", 17, 1.2, 0.2, 3.1);
            Food.Food.AddFood(foodList, "Vinete", 25, 0.9, 0.2, 5.5);
            Food.Food.AddFood(foodList, "Varză", 31, 1.8, 0.2, 6.0);
            Food.Food.AddFood(foodList, "Fasole verde", 31, 1.8, 0.2, 6.0);
            //Food.Foodteod.AddFood(foodList, "Roșie", 23, 1.1, 0.2, 4.4);
            //Food.Foodteod.AddFood(foodList, "Morcov", 35, 0.9, 0.2, 8.3);
            Food.Food.AddFood(foodList, "Sparanghel", 20, 2.2, 0.2, 3.7);
            Food.Food.AddFood(foodList, "Ardei iute", 40, 1.9, 0.4, 8.8);
            Food.Food.AddFood(foodList, "Gulie", 31, 1.6, 0.2, 7.0);
            Food.Food.AddFood(foodList, "Țelină", 16, 0.7, 0.2, 3.5);
            Food.Food.AddFood(foodList, "Sfeclă roșie", 43, 1.6, 0.2, 9.6);
            Food.Food.AddFood(foodList, "Leurdă", 47, 6.8, 0.7, 4.9);
            Food.Food.AddFood(foodList, "Dovleac", 26, 1.0, 0.1, 6.5);
            Food.Food.AddFood(foodList, "Linte", 353, 24.0, 1.1, 63.0);
            Food.Food.AddFood(foodList, "Cartofii albi", 77, 2.0, 0.1, 17.5);
            Food.Food.AddFood(foodList, "Orez", 130, 2.7, 0.3, 28.0);
            Food.Food.AddFood(foodList, "Ciuperci", 22, 3.1, 0.3, 3.3);
            Food.Food.AddFood(foodList, "Naut", 180, 8.9, 2.7, 30.0);
            Food.Food.AddFood(foodList, "Cartofi roșii", 77, 2.0, 0.1, 17.5);
            //Insert Legume       


            ///         Fructe 
            Food.Food.AddFood(foodList, "Portocale", 43, 0.9, 0.2, 9.0);
            Food.Food.AddFood(foodList, "Mere", 52, 0.3, 0.2, 14.0);
            Food.Food.AddFood(foodList, "Banane", 96, 1.1, 0.2, 22.0);
            Food.Food.AddFood(foodList, "Kiwi", 61, 1.1, 0.5, 15.0);
            Food.Food.AddFood(foodList, "Pere", 57, 0.4, 0.1, 15.0);
            Food.Food.AddFood(foodList, "Cireșe", 50, 1.0, 0.4, 12.0);
            Food.Food.AddFood(foodList, "Pepene verde", 30, 0.6, 0.2, 7.6);
            Food.Food.AddFood(foodList, "Prune", 46, 0.7, 0.2, 11.0);
            Food.Food.AddFood(foodList, "Ananas", 50, 0.5, 0.1, 13.0);
            Food.Food.AddFood(foodList, "Piersici", 39, 0.9, 0.3, 10.0);
            Food.Food.AddFood(foodList, "Mango", 60, 0.8, 0.4, 15.0);
            Food.Food.AddFood(foodList, "Afine", 57, 0.7, 0.3, 14.0);
            Food.Food.AddFood(foodList, "Zmeură", 53, 1.2, 0.7, 12.0);
            Food.Food.AddFood(foodList, "Mure", 43, 1.4, 0.4, 9.6);
            Food.Food.AddFood(foodList, "Capsuni", 32, 0.7, 0.3, 7.7);
            Food.Food.AddFood(foodList, "Lămâi", 29, 1.1, 0.3, 9.3);
            //Food.Foodte.AddFood(foodList, "Grapefruit", 42, 0.8, 0.2, 0, 1);
            Food.Food.AddFood(foodList, "Alune", 567, 21.0, 49.9, 21.0);
            Food.Food.AddFood(foodList, "Avocado", 160, 2.0, 14.7, 8.5);
            Food.Food.AddFood(foodList, "Caise", 48, 0.8, 0.1, 12.0);
            Food.Food.AddFood(foodList, "Clementine", 35, 0.9, 0.1, 8.5);
            Food.Food.AddFood(foodList, "Coacaze", 44, 0.4, 0.3, 10.1);
            Food.Food.AddFood(foodList, "Mandarine", 53, 0.8, 0.3, 13.3);
            Food.Food.AddFood(foodList, "Masline", 115, 0.8, 10.7, 6.3);
            Food.Food.AddFood(foodList, "Mure", 43, 1.4, 0.4, 9.6);
            Food.Food.AddFood(foodList, "Cocos", 354, 3.3, 33.5, 15.2);
            Food.Food.AddFood(foodList, "Nectarine", 44, 0.9, 0.2, 10.6);
            Food.Food.AddFood(foodList, "Porumb", 86, 3.2, 1.2, 19.1);
            Food.Food.AddFood(foodList, "Struguri", 69, 0.7, 0.2, 18.1);
            Food.Food.AddFood(foodList, "Dude", 578, 13.5, 49.2, 28.0);
            Food.Food.AddFood(foodList, "Gutuie", 57, 0.4, 0.1, 15.3);




            Food.Food.AddFood(foodList, "Pui", 165, 31.0, 3.6, 0.0);
            Food.Food.AddFood(foodList, "Vită", 250, 26.0, 17.0, 0.0);
            Food.Food.AddFood(foodList, "Porc", 242, 17.0, 18.0, 0.0);
            Food.Food.AddFood(foodList, "Curcan", 189, 29.0, 7.0, 0.0);
            Food.Food.AddFood(foodList, "Rață", 337, 16.0, 30.0, 0.0);
            Food.Food.AddFood(foodList, "Gâscă", 361, 14.0, 33.0, 0.0);
            Food.Food.AddFood(foodList, "Pește", 206, 22.0, 13.0, 0.0);
            Food.Food.AddFood(foodList, "Somon", 206, 22.0, 13.0, 0.0);
            Food.Food.AddFood(foodList, "Tocătură de vită", 250, 17.0, 18.0, 0.0);
            Food.Food.AddFood(foodList, "Cârnați", 297, 16.0, 26.0, 0.0);



            Food.Food.AddFood(foodList, "Brânză de vaci", 98, 11.0, 4.3, 2.6);
            Food.Food.AddFood(foodList, "Cașcaval", 352, 25.0, 28.0, 2.0);
            Food.Food.AddFood(foodList, "Mozzarella", 280, 22.0, 20.0, 2.0);
            Food.Food.AddFood(foodList, "Parmezan", 431, 38.0, 29.0, 4.0);
            Food.Food.AddFood(foodList, "Brie", 334, 21.0, 28.0, 0.0);
            Food.Food.AddFood(foodList, "Roquefort", 369, 21.5, 30.0, 2.0);
            Food.Food.AddFood(foodList, "Gouda", 356, 24.0, 27.0, 2.2);
            Food.Food.AddFood(foodList, "Feta", 264, 14.0, 21.0, 4.0);
            Food.Food.AddFood(foodList, "Brânză de oaie", 277, 14.0, 23.0, 1.0);
            Food.Food.AddFood(foodList, "Caș", 242, 18.0, 20.0, 1.0);
            Food.Food.AddFood(foodList, "Brânză de casă", 310, 20.0, 25.0, 1.0);
            //Food.Foodre Branzeturii

            Food.Food.AddFood(foodList, "Pâine", 265, 9.5, 1.0, 51.0);
            Food.Food.AddFood(foodList, "Făină", 364, 10.3, 1.2, 75.2);


            //              Alinte de la super market 

            Food.Food.AddFood(foodList, "Lapte", 61, 3.3, 3.6, 4.8);
            Food.Food.AddFood(foodList, "Ouă", 155, 12.6, 10.6, 0.6);
            Food.Food.AddFood(foodList, "Pâine", 265, 9.5, 1.0, 51.0);
            Food.Food.AddFood(foodList, "Brânză", 402, 25.0, 33.0, 1.0);
            Food.Food.AddFood(foodList, "Țelină", 16, 0.7, 0.2, 3.8);
            Food.Food.AddFood(foodList, "Morcovi", 41, 0.9, 0.2, 9.6);
            Food.Food.AddFood(foodList, "Cartofi", 77, 2.0, 0.1, 17.5);
            Food.Food.AddFood(foodList, "Castraveți", 15, 0.7, 0.1, 3.6);
            Food.Food.AddFood(foodList, "Rosii", 18, 0.9, 0.2, 3.9);
            Food.Food.AddFood(foodList, "Ceapă", 40, 1.1, 0.1, 9.3);
            Food.Food.AddFood(foodList, "Usturoi", 149, 6.4, 0.5, 33.1);
            Food.Food.AddFood(foodList, "Pătrunjel", 36, 3.7, 0.8, 6.3);
            Food.Food.AddFood(foodList, "Lămâie", 29, 1.1, 0.3, 9.3);
            Food.Food.AddFood(foodList, "Miere", 304, 0.3, 0.0, 82.4);
            Food.Food.AddFood(foodList, "Cârnați", 297, 16.0, 26.0, 0.0);
            Food.Food.AddFood(foodList, "Somon", 206, 22.0, 13.0, 0.0);

            InsertFoodItemsIntoDatabase(foodList);

            Console.WriteLine("Food items inserted successfully.");
        }

        public void InsertFoodItemsIntoDatabase(List<Food.Food> foodItems)
        {
            conex.Open();

            foreach (Food.Food food in foodItems)
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Alimente_Table]  (Name, Calories, Proteins, Fats, Carbs) VALUES (@Name, @Calories, @Proteins, @Fats, @Carbs)", conex);
                //SqlCommand comm = new SqlCommand("INSERT INTO [Register_Tabel] (Utilizator,Parola,Greutate,Inaltime,Varsta,Sex,Nivel_Activitate,Scop) values(@Utilizator,@Parola,@Greutate,@Inaltime,@Varsta,@Sex,@Nivel_Activitate,@Scop)", conex);

                command.Parameters.AddWithValue("@Name", food.Name);
                command.Parameters.AddWithValue("@Calories", food.Cloaries);
                command.Parameters.AddWithValue("@Proteins", food.Proteins);
                command.Parameters.AddWithValue("@Fats", food.Fats);
                command.Parameters.AddWithValue("@Carbs", food.Carbs);
                command.ExecuteNonQuery();
                Console.WriteLine(food.Name);
                Console.WriteLine(food.Cloaries);
                Console.WriteLine(food.Proteins);
                Console.WriteLine(food.Fats);
                Console.WriteLine(food.Carbs);

            }
        } */

        ///<summary>  
        ///   Functie folosita pentru a returna nr de calorii pe 100g din tabela Alimente_Table 
        ///</summary>
        public int getCalories(string name)
        {
            int val = 0;
            try
            {
                conex.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Eroare la deschidere baza date fct get call    ",ex.Message);
            }

            try
            {
                ///<summary>  
                ///   Comanda ce selecteaza Caloriile unui alimnet din tabela Alimente_Tabel
                ///</summary>
                SqlCommand comm = new SqlCommand("Select Calories From [Alimente_Table] where Name=@Name", conex);
                comm.Parameters.AddWithValue("@Name", name);
                comm.ExecuteNonQuery();
                val = (int)comm.ExecuteScalar();
                ///<summary>  
                ///   Inchide conexiunea cu baza de date
                ///</summary>
                conex.Close();    
                                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Eroare la cautare in BD fct fetCalories", ex.Message);
            }
            return val;

        }

        ///<summary>  
        ///   Functie folosita pentru a returna nr de proteine pe 100g din tabela Alimente_Table 
        ///</summary>
        public float getProteins(string name)
        {
            
            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere baza date fct getProt    ", ex.Message);
            }

            try
            {
                SqlCommand comm = new SqlCommand("Select Proteins From [Alimente_Table] where Name=@Name", conex);
                comm.Parameters.AddWithValue("@Name", name);
                comm.ExecuteNonQuery();
                var prot1 = comm.ExecuteScalar();
                float prot = Convert.ToSingle(prot1);
                conex.Close();
                return prot;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in BD fct getProt", ex.Message);
            }
            return 1;

        }


        ///<summary>  
        ///   Functie folosita pentru a returna nr de grasimi pe 100g din tabela Alimente_Table 
        ///</summary>
        public float getFats(string name)
        {

            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere baza date fct getFats    ", ex.Message);
            }

            try
            {
                SqlCommand comm = new SqlCommand("Select Fats From [Alimente_Table] where Name=@Name", conex);
                comm.Parameters.AddWithValue("@Name", name);
                comm.ExecuteNonQuery();
                var fat1 = comm.ExecuteScalar();
                float fat = Convert.ToSingle(fat1);
                conex.Close();
                return fat;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in BD fct getProt", ex.Message);
            }
            return 1;

        }

        ///<summary>  
        ///   Functie folosita pentru a returna nr de carbohidrati pe 100g din tabela Alimente_Table 
        ///</summary>
        public float getCarbs(string name)
        {

            try
            {
                conex.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la deschidere baza date fct getCarbs    ", ex.Message);
            }

            try
            {
                SqlCommand comm = new SqlCommand("Select Carbs From [Alimente_Table] where Name=@Name", conex);
                comm.Parameters.AddWithValue("@Name", name);
                comm.ExecuteNonQuery();
                var carb1 = comm.ExecuteScalar();
                float carb = Convert.ToSingle(carb1);
                conex.Close();
                return carb;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la cautare in BD fct getCarbs", ex.Message);
            }
            return 1;

        
        }

        public List<string> CombReader()
        {
            List<string> vect = new List<string>(); 
            string query = "Select Name from [Alimente_Table]";
            conex.Open();
            SqlCommand comm = new SqlCommand(query, conex);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                vect.Add(name);
                Console.WriteLine(name);
            }
            reader.Close();
            conex.Close();

            return vect;


        }
    }
}
