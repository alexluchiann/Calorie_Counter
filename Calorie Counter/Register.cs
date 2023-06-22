/**************************************************************************
 *                                                                        *
 *  File:        Register.cs                                                 *
 *                                                                        *
 *  Descriere:   Interfata de Register ,unde userul intrroduce datele     *  
 *               ce vor fi inserate in baza de date si vor fi utilizate   *  
 *               in program                                               *  
 *                                                                        *
 *  Autor:  Ivanov Ioan                                                   *
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Facade_DLL;
using TextBox = System.Windows.Forms.TextBox;
using Calculator1;
using Food_DB;

namespace Calorie_Counter
{
    public partial class Register : Form
    {
        /// <summary>
        /// Variabila de acces pentru interfata grafica 
        /// </summary>
        private Login _login;
        /// <summary>
        /// Instanta a clasei Facade_DLL folosita pentru a lucra cu datele din aceasta interfata
        /// </summary>
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();

        /// <summary>
        /// Instanta a clasei Calc folosita pentru calcule 
        /// </summary>
        private Calculator1.Calculator1 Calc = new Calculator1.Calculator1();
        public int flagg=0;


        /// <summary>
        /// Variabila de acces la interfata grafica Register
        /// </summary>
        public static Register instance;

        /// <summary>
        /// Se creaza textobxurile tb1 tb2 ce vor fi folosite in aceasta interfata 
        /// </summary>
        public TextBox tb1;
        public TextBox tb2;


        public Register()
        {
            InitializeComponent();

        }

        public Register(Login login)
        {
            InitializeComponent();
            _login = login;
            ///<summary>
            ///butonul "pasul urmator" va fi desabled pana cand vom introudce toae datele si vom apasa pe butonul de inregistrare 
            ///</summary>
            //btnPas.Enabled = false;
            tbParola.UseSystemPasswordChar = true;
            instance= this;
            tb1 = tbUtilzator;
            tb2 = tbParola;
       
        }

        private void btnIntoarcere_Click(object sender, EventArgs e)
        {
            _login.Show();
            this.Hide();
        }

        private void btnPas_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Ai intrat in Fct Passss");
            ///<summary>
            ///Se verifica daca campurile sunt completate pentru a adauga userul in baza de date
            ///</summary>
            if (tbUtilzator.Text != "" && tbParola.Text != "" && tbGreutate.Text != "" && tbInaltime.Text != "" && tbVarsta.Text != "" && cbSex.Text != "" && cbActivitate.Text != "")
            {
                ///<summary>
                ///Se incarca in baza de date 
                ///</summary>
                DB.addData(tbUtilzator.Text, tbParola.Text, float.Parse(tbGreutate.Text), float.Parse(tbInaltime.Text), int.Parse(tbVarsta.Text), cbSex.Text, cbActivitate.Text);
                //Butonul "Pasil urmator " va fi Enabled
                btnPas.Enabled = true;
                

            }
            else
            {
                btnPas.Enabled = false;
                MessageBox.Show("Trebuie sa completezi toate camputile !!!");
            }

            Scop scop = new Scop(this);

            /// <summary>
            /// Se va insera in interfata Scop greutate ideala a utilizatorului in functie de datele introduse in interfata
            /// </summary>
            Scop.instance.label.Text= "Greutatea ideala pentru tine ar fi.... " + Calc.Calc_IBW(tb1.Text,tb2.Text) + "Kg";
            scop.Show();
            this.Hide();

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
