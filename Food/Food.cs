/**************************************************************************
 *                                                                        *
 *  File:        Food.cs                                                  *
 *                                                                        *
 *  Descriere:   Clasa food utilizata pentru a introduce                  *   
 *              alimente in baza de date Alimente_Table                   *  
 *                                                                        *
 *  Autor:  Victor Teslaru                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/




using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Food
{
    public class Food
    {
        public string Name { get; set; }
        public int Cloaries { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public double Carbs { get; set; }

        ///<summary>  
        ///  Functie folosita pentru a crea o lista cu alimente ce va fi introdus in tabela Alimente_Table
        ///</summary>
        public static void AddFood(List<Food> foodList,string name,int calories,double protains,double fats,double carbs)
        {
            foodList.Add(new Food
            {
                Name = name,
                Cloaries = calories,
                Proteins = protains,
                Carbs = carbs,
                Fats=fats
            });
        }
    }
}
