/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *                                                                        *
 *  Descriere:   Interfata de Login,unde se autentifica utilizatorul      *
 *                                                                        *
 *  Autor:  Victor Teslaru                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/


using Calculator1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 



namespace Calorie_Counter
{
    public partial class Login : Form
    {
        private Meniu _meniu;

        /// <summary>
        /// Initalizare baza de date DB
        /// </summary>
        private Facade_DLL.Facade_DLL DB = new Facade_DLL.Facade_DLL();

        /// <summaryyy>
        /// Initializare Calc folosit pentru calcule 
        /// </summary>
        private Calculator1.Calculator1 Calc = new Calculator1.Calculator1();
        
        public string User;
        public string Pass;

        /// <summary>
        /// Variabila de acces la interfata
        /// </summary>
        public static Login instance;
        public int flag=0;
        
        
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructorul
        /// </summary>
        public Login(Meniu meniu)
        {
            InitializeComponent();
            _meniu = meniu;
            /// <summary>
            /// Textul din textboxul tbParola devine de tipul ***
            /// </summary>
            tbParola.UseSystemPasswordChar = true;
            User = tbUtilizator.Text;
            Pass = tbParola.Text;
            instance = this;
            
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();

        }
        ///<summary>
        ///Butonul "Trimite " de pe interfata 
        ///</summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            ///<summary>
            ///Username luat de pe interfata
            ///</summary>
            string User = tbUtilizator.Text;
        
            ///<summary>
            ///Parola luata de pe interfata
            ///</summary>
            string Pass = tbParola.Text;
            


            ///<summary>
            ///Verificam daca s-au introdus Date in campurile Username si Parola
            ///</summary>
            if (tbUtilizator.Text == "" && tbParola.Text == "")
            {
                MessageBox.Show("Trebuie sa introduci parola si Usernamul pentru a te loga");
            }
            else 
            {
                
                ///<summary>
                ///Se verifica da exista contul in baza de date 
                ///</summary>
                if (DB.check(User, Pass) != 0)
                {
                    Main.instance.bugett.Text = "Buget caloric: " + Calc.Buget_Cal(User, Pass) + " kcal";

                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Imi pare rau dar Numele de Utilizator nu exista sau Parola este gresita !!!!");
                }
            }
        }



        /// <summary>
        /// Buton de intoarecere la interfata de start 
        /// </summary>
        private void btIntoarcere_Click(object sender, EventArgs e)
        {
            _meniu.Show();
            this.Hide();
        }



        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
