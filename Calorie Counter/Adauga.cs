/**************************************************************************
 *                                                                        *
 *  File:        Adauga.cs                                                *
 *                                                                        *
 *  Descriere:   Interfata pentru ca utilizatorul sa introduca            *  
 *               alimentele pe care le consuma la fiecare masa            *  
 *                                                                        *
 *  Autor:  Luchian Alexandru                                             *
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



namespace Calorie_Counter
{
    public partial class Adauga : Form
    {
        
        private Main _main;
        /// <summary>
        /// Initializam variabila F_DB
        /// /// </summary>
        private Food_DB.Food_DB F_DB = new Food_DB.Food_DB();

        /// <summary>
        /// Variabila de acces la interfata
        /// </summary>
        public static Adauga instance;
        public ComboBox cmb1;
        /// <summary>
        /// Obiect prin intermediul caruia se fac toate calculele din program
        /// </summary>
        Calculator1.Calculator1 Calc = new Calculator1.Calculator1();
      

        public Adauga()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Constructorul Clasei
        /// </summary>
        public Adauga(Main main)
        {
            InitializeComponent();
            _main = main;
            instance = this;
            cmb1 = comboBox1;
        }

        private void Adauga_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }


        /// <summary>
        /// Functie care introduce datele in listBox si in Label-urile  din interfata main
        /// </summary>
        private void btConfirma_Click(object sender, EventArgs e)
        {
            //Se verifica daca Alimnetul selectat este in combobox si daca cantitatea este introdusa corect 
            if (!comboBox1.Items.Contains(comboBox1.Text) || !int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Alimnentul nu exista!!!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Alimentul nu exista in baza de date ");
            }
            else
            {

                listBox1.Items.Add(comboBox1.Text + " " + " grame " + textBox1.Text + " calorii: " + Calc.CalcCalories(comboBox1.Text, int.Parse(textBox1.Text)) + "             proteine: " + Calc.ProteinCalc(comboBox1.Text, int.Parse(textBox1.Text)) + "           carbohidratii: " + Calc.CarbsCalc(comboBox1.Text, int.Parse(textBox1.Text)) + "          grasimi: " + Calc.FatsCalc(comboBox1.Text, int.Parse(textBox1.Text)));
                
                
                Main.instance.TotCall = Main.instance.TotCall + Calc.CalcCalories(comboBox1.Text, int.Parse(textBox1.Text));



                /// <summary>
                /// Introduce date in Label-urile TotCarb,ToTFats,TotProt datele ,dupa calcule
                /// </summary>
                Main.instance.TotCarbs = Main.instance.TotCarbs + Calc.CarbsCalc(comboBox1.Text, int.Parse(textBox1.Text));
                Main.instance.TotFats = Main.instance.TotFats + Calc.FatsCalc(comboBox1.Text, int.Parse(textBox1.Text));
                Main.instance.TotProt = Main.instance.TotProt + Calc.ProteinCalc(comboBox1.Text, int.Parse(textBox1.Text));

                /// <summary>
                /// variabila temporara prin intermediul careia verificam caloriile ramase
                /// </summary>
                double var = Calc.Buget_Cal(Login.instance.tbUtilizator.Text, Login.instance.tbParola.Text);
                var -= Main.instance.TotCall;

                /// <summary>
                /// Introduce datele in Label
                /// </summary>
                Main.instance.LabelCalRamase.Text = "Calorii Ramase: ..." + var;
                Main.instance.LabelCarbs.Text = "Carbohidrati: ..." + Main.instance.TotCarbs;
                Main.instance.LabelFats.Text = "Grasimi: ..." + Main.instance.TotFats;
                Main.instance.LabelProt.Text = "Proteine: ..." + Main.instance.TotProt;


                Main.instance.Temp += Calc.CalcCalories(comboBox1.Text, int.Parse(textBox1.Text));

                /// <summary>
                /// In functie de radioButonul selectat se screi in label-ul corespondent nr de calorii consumate
                /// </summary>
                if (Main.instance.rbDejun.Checked == true)
                {

                    Main.instance.lbDejun.Text = "Mic Dejun ......" + Main.instance.Temp + " kcal";
                }
                if(Main.instance.rbCina.Checked == true)
                {
                    Main.instance.lbCina.Text = "Cina ......" + Main.instance.Temp + " kcal";

                }
                if(Main.instance.rbPranz.Checked == true)
                {
                    Main.instance.lbPranz.Text = "Pranz ......" + Main.instance.Temp + " kcal";
                }
                if (Main.instance.rbGustari.Checked == true)
                {
                    Main.instance.lbGustari.Text = "Gustare ......" + Main.instance.Temp + " kcal";
                }




            }

        }

        /// <summary>
        /// La apasarea butonului variabila publica Temp devine 0 si ne intoarece pe pagina Main
        /// </summary>
        private void btTerminat_Click(object sender, EventArgs e)
        {
            
            Main.instance.Temp = 0;
            _main.Show();
            this.Hide();
        }
    }
}
