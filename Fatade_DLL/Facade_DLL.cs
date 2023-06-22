/**************************************************************************
 *                                                                        *
 *  File:        Facade_DLL.cs                                            *
 *                                                                        *
 *  Descriere:   Clasa Facade_Dll se ocupa de implementarea design        *  
 *                paternul Facade                                         *  
 *                                                                        *
 *  Autor:  Ivanov Ioan                                                   *
 *                                                                        *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_DLL;

namespace Facade_DLL
{
    public class Facade_DLL
    {
        ///<summary>  
        /// Se foloseste pentru a crea functiile facade
        ///</summary>
        private DB_Class Data_Base;

        public Facade_DLL()
        {

            Data_Base = new DB_Class();
        }

        ///<summary>  
        ///  Functie de adaugare a datelor personale in tabela  RegisterTable
        ///</summary>
        public void addData(string User, string parola, float greutate, float inaltime, int varsta, string sex, string Niv_Activ)
        {
            Data_Base.addData(User, parola, greutate, inaltime, varsta, sex, Niv_Activ);
        }

        ///<summary>  
        ///  Functie care verifica daca exista userul in baza de date ,returneaza un numar defirit de 0 daca exista 
        ///</summary>
        public int check(string User, string parola)
        {
            return Data_Base.check(User, parola);

        }
        
        public int AlreadyExist(string user)
        {
            return Data_Base.AlreadyExist(user);
        }

        ///<summary>  
        ///  Functie ce returneza greutate din baza de date pentru un user 
        ///</summary>
        public float getGreutate(string User, string parola)
        {
            return Data_Base.getGreutate(User,parola);
        }

        ///<summary>  
        ///  Returneaza varsta uni user 
        ///</summary>
        public int getAge(string User, string parola)
        {
            return Data_Base.getAge(User,parola);
        }
        ///<summary>  
        ///  Returneaza inaltimea unui user 
        ///</summary>
        public float getHeight(string User, string parola)
        {
            return Data_Base.getInaltime(User,parola);
        }

        ///<summary>  
        ///  Rturneaza sexul unui user 
        ///</summary>
        public string getSex(string User,string parola)
        {
            return Data_Base.getSex(User,parola);
        }

        ///<summary>  
        ///  Updateaza Scopul unui user  
        ///</summary>
        public void ADD_SCOP(string user, string pass, int scope)
        {
            Data_Base.ADD_SCOP(user,pass,scope);
        }

        ///<summary>  
        /// Returneaza nevelul de activitate 
        ///</summary>
        public string get_Activity_Level(string User, string parola)
        {
            return Data_Base.get_Activity_Level(User, parola);
        }

        ///<summary>  
        ///  Returneaza scopul unui user 
        ///</summary>
        public int getScop(string User, string parola)
        {
            return Data_Base.getScop(User,parola);
        }



    }
}
