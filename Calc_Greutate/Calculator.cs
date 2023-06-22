using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade_DLL;
using Microsoft.Win32;

namespace Calculator
{
    //Clasa calculeaza greutatea optima si 
    public class Calculator
    {   
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();   

        public double Calc_IBW(string User,string Pass)
        {
            if (DB.getSex(User,Pass) == "Barbat")
            {
                return 56.2 + 1.41 * ((DB.getHeight(User,Pass) / 2.54) - 60) - (double)(0.12 *DB.getAge(User,Pass));
            }
            else if(DB.getSex(User, Pass) == "Femeie")
            {
                return 53.1 + 1.36 * ((DB.getHeight(User, Pass) / 2.54) - 60) - 0.11 * DB.getAge(User, Pass);
            }
            else
            {
                return 0;
            }

        }
       
    }
}
