/**************************************************************************
 *                                                                        *
 *  File:        Main.cs                                                  *
 *                                                                        *
 *  Descriere:   Interfata principala,unde utilizatorul vede targetul     *  
 *               caloric pe ziua respectiva si cate proteine,grasimi      *  
 *               carbohidrati si nr total de calorii                      *  
 *                                                                        *
 *  Autor:  Victor Teslaru                                                *
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
using System.Windows.Forms.DataVisualization.Charting;


namespace Calorie_Counter
{
    public partial class Main : Form
    {
        /// <summary>
        /// Variabila de acces la interfata grafica
        /// </summary>
        public static Main instance;

       
        public Label bugett;

        /// <summary>
        /// Se creaza o instanta a clasei F_DB
        /// </summary>
        public Food_DB.Food_DB F_DB = new Food_DB.Food_DB();

        /// <summary>
        /// Se creaza o instanta a clasei DayDB folosita pentru a introduce date in tabela DayDB
        /// </summary>
        public Day_DB.Day_DB DayDB = new Day_DB.Day_DB();

        /// <summary>
        /// Se creaza o instanta a clasei Calc folosita pentru realizare calculilor
        /// </summary>
        public Calculator1.Calculator1 Calc = new Calculator1.Calculator1();
        public Label LabelProt;
        public Label LabelCalRamase;
        public Label LabelCarbs;
        public Label LabelFats;



        /// <summary>
        /// Variabile folosite pentru retinerea nr total de calorii carbohidrati si grasimi ,variabile folosite in interfata Adauga
        /// </summary>
        public int TotCall = 0;
        public float TotProt = 0;
        public float TotFats = 0;
        public float TotCarbs = 0;
        public float Temp = 0; 

        public Main()
        {
            InitializeComponent();
            bugett = buget;
            instance = this;
            LabelCalRamase= CalRamase;
            LabelCarbs= carbohidrati;
            LabelFats=grasimi;
            LabelProt = proteine;
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
                        
                Adauga adauga = new Adauga(this);
                adauga.Show();
                this.Hide();
           
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btNextDay_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Variabila care retine ultima zi din baza de date DayDB
            /// </summary>
            int CurentDay = DayDB.GetLastDay(Login.instance.tbUtilizator.Text);
            /// <summary>
            /// Daca ziua curenta este 0 inseamna ca Userul este nou si se va egala cu 1 
            /// </summary>
            if (CurentDay == 0)
            {
                CurentDay = 1;

            }
            else
            {
                /// <summary>
                /// Se cauta ultima zi din DayDB si se incrementa cu 1 pentru a d ziua noua
                /// </summary>
                CurentDay = DayDB.GetLastDay(Login.instance.tbUtilizator.Text) +1;
             
            }
            /// <summary>
            /// Se adauga in baza de date noua zi
            /// </summary>
            DayDB.addData(Login.instance.tbUtilizator.Text, Main.instance.TotCall, CurentDay);
            Console.WriteLine(Login.instance.tbUtilizator.Text);


            /// <summary>
            /// Se reseteaza TotCall,TotCarbs,TotFats ,TotProt 
            /// </summary>
            Main.instance.TotCall = 0;
            Main.instance.TotCarbs = 0;
            Main.instance.TotFats = 0;
            Main.instance.TotProt = 0;

            Main.instance.LabelCalRamase.Text = "Calorii Ramase: ...";
            Main.instance.LabelCarbs.Text = "Carbohidrati: ...";
            Main.instance.LabelFats.Text = "Grasimi: ...";
            Main.instance.LabelProt.Text = "Proteine: ...";

            Main.instance.lbCina.Text = "...";
            Main.instance.lbDejun.Text = "...";

            Main.instance.lbGustari.Text = "...";
            Main.instance.lbPranz.Text = "...";




        }

        private void btProgres_Click(object sender, EventArgs e)
        {
            Progres _prog = new Progres();
            _prog.Show();
            this.Hide();
        }
    }
}
