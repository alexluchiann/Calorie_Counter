/**************************************************************************
 *                                                                        *
 *  File:        Scop.cs                                                  *
 *                                                                        *
 *  Descriere:   Interfata prin care utlizatorul isi selecteaza scopul    *  
 *               si ii este prezentata greutatea ideala in functie        *  
 *               de datele introduse                                      *  
 *                                                                        *
 *  Autor:  Victor Teslaru                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calorie_Counter
{
    public partial class Scop : Form
    {
        private Register _register;
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();
        private Calculator1.Calculator1 Calc = new Calculator1.Calculator1();
        private  string user;
        private string pass;

        /// <summary>
        /// Variabila de acces la interfata grafica
        /// </summary>
        public static Scop instance;

        /// <summary>
        /// Se creaza labelul ideal
        /// </summary>
        public Label label;
        

        public Scop()
        {
            InitializeComponent();
            
        }

        public Scop(Register register)
        {
            InitializeComponent();
            _register = register;

            /// <summary>
            /// Se folosesc textboxurile tb1 si tb2 create in Register pentru simplitate 
            /// </summary>
            user = Register.instance.tb1.Text;
            pass = Register.instance.tb2.Text;
            instance = this;
            label = ideal;
        }

      /*  private void btIntoarcere_Click(object sender, EventArgs e)
        {
            

            _register.Show();
            this.Hide();
        }*/

        private void Scop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btConfirma_Click(object sender, EventArgs e)
        {
            int raspuns=0;

            /// <summary>
            /// In functie de varianta selectata din interfata grafica varianta raspuns va lua o valoare 
            /// </summary>
            if (rbSlabire.Checked)
            {
                raspuns = 1;
                rbMentinere.Enabled = false;
                rbMasa.Enabled = false;
            }
            if (rbMentinere.Checked)
            {
                raspuns = 2;
                rbSlabire.Enabled= false;
                rbMasa.Enabled= false;
            }
            if (rbMasa.Checked)
            {
                raspuns = 3;
                rbSlabire.Enabled = false;
                rbMentinere.Enabled= false;
            }
            Main main = new Main();
            Login _log=new Login();
            _log.Show();
            this.Hide();
            try
            {

                /// <summary>
                /// Se adauga in coloana Scop din DB valoarea raspuns
                /// </summary>
                DB.ADD_SCOP(user, pass, raspuns);
                //Console.WriteLine("Varsta este " + DB.getAge(Register.instance.tb1.Text, Register.instance.tb2.Text));

                /// <summary>
                /// In main se va afisa bugetul caloric dupa datele luate din interfata 
                /// </summary>
                Main.instance.bugett.Text = "Buget caloric: " + Calc.Buget_Cal(Register.instance.tb1.Text, Register.instance.tb2.Text) + " kcal";


            }
            catch (Exception ex)
            {
                Console.WriteLine("Aroare in ADD_Scope  Interfata Scop",ex.Message);
            }

        }
    }
}
