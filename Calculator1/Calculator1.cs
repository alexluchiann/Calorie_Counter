/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *                                                                        *
 *  Descriere:   Clasa cu metodele calculator                             *
 *                                                                        *
 *  Autor:  Ivanov Ioan                                                   *
 *                                                                        *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade_DLL;

/// Ioan 
namespace Calculator1
{
    public class Calculator1
    {

        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();
        private Food_DB.Food_DB F_DB = new Food_DB.Food_DB();


        /// <summary>
        /// Functie ce alculeaza greutatea ideala 
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public double Calc_IBW(string User, string Pass)
        {
            if (DB.getSex(User, Pass) == "Barbat")
            {

                return 50 + 0.91 * (DB.getHeight(User, Pass) - 152.4);
            }
            else if (DB.getSex(User, Pass) == "Femeie")
            {
                return 45.5 + 0.91 * (DB.getHeight(User, Pass) - 152.4);
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// Functie ce calculeaza Nr de calorii potrivit pentru mentinere
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public double Cal_CaloricIntake(string User, string Pass)
        {
            double BMR = 0;
            if (DB.getSex(User, Pass) == "Barbat")
            {
                BMR = 66 + (13.75 * DB.getGreutate(User, Pass)) + (5 * DB.getHeight(User, Pass)) - (6.75 * DB.getAge(User, Pass));
            }
            else if (DB.getSex(User, Pass) == "Femeie")
            {
                BMR = 655 + (9.56 * DB.getGreutate(User, Pass)) + (1.85 * DB.getHeight(User, Pass)) - (4.68 * DB.getAge(User, Pass));
            }
            
            if (DB.get_Activity_Level(User, Pass) == " Scazut(sedentar , majoritatea timpului stat pe scaun)")
            {
                return BMR * 1.2;
            }
            else if (DB.get_Activity_Level(User, Pass) == "Moderat(practici un  sport 1-3 ori pe saptaman)")
            {
                return BMR * 1.375;
            }
            else if (DB.get_Activity_Level(User, Pass) == "Activ(practici un sport mai mult de 3 ori pe saptaman si ai un stil de viata activ)")
            {
                return BMR * 1.65;
            }

            return BMR;
        }


        /// <summary>
        /// Functie care determina bugetul caloric in functie de scop
        /// </summary>
        /// <param name="User"></param>
        /// <param name="pass"></param>
        /// <returns></returns>

        public double Buget_Cal(string User,string pass)
        {
            if(DB.getScop(User,pass) == 1)
            {
                return Cal_CaloricIntake(User, pass) - 400;
            }
            else if(DB.getScop(User, pass) == 2)
            {
                return Cal_CaloricIntake(User, pass);
            }
            else if(DB.getScop(User, pass) == 3)
            {
                return Cal_CaloricIntake(User, pass) + 250;
            }
            return 1;
        }




        /// <summary>
        /// Functie ce calculeaza micronutrientii in functie de gramajul dat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gramaj"></param>
        /// <returns></returns>

        public int CalcCalories(string name,int gramaj)
        {
            return (gramaj * F_DB.getCalories(name))/100;
        }
        public float ProteinCalc(string name,int gramaj)
        {
            return (gramaj * F_DB.getProteins(name)) / 100;
        }
        public float FatsCalc(string name, int gramaj)
        {
            return (gramaj * F_DB.getFats(name)) / 100;
        }
        public float CarbsCalc(string name,int gramaj)
        {
            return (gramaj * F_DB.getCarbs(name)) / 100;
        }


    }
}

