/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *                                                                        *
 *  Descriere:   Interfata care arata progresul utilizatorului            *
 *                                                                        *
 *  Autor:  Luchian Alexandru                                             *
 *                                                                        *
 *                                                                        *
 **************************************************************************/




using Day_DB;
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
    public partial class Progres : Form
    {
        private Main _main;

        /// <summary>
        /// Variabila folosita pentru a avea aces la interfata grafica Progrs
        /// </summary>
        public static Progres instance;

        /// <summary>
        /// Se  creaza o DayDb din care se vor extrage date
        /// </summary>
        public Day_DB.Day_DB DayDB = new Day_DB.Day_DB();


        public Progres()
        {
            InitializeComponent();
        }
        public Progres(Main main)
        {
            InitializeComponent();
            _main = main;
            instance = this;
        }


        private void btBack_Click(object sender, EventArgs e)
        {
            Main.instance.Show();
            this.Hide();
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            Progres.instance = new Progres();
            /// <summary>
            /// Lista de inturi in care se tin toate zilele
            /// </summary>
            List<int> DayVect = DayDB.getAllDays(Login.instance.tbUtilizator.Text);
            /// <summary>
            /// Lista de vectroi in care si tine nr total de calorii consumat intr-o zi
            /// </summary>
            List<float> CalVect = DayDB.GetAllCalories(Login.instance.tbUtilizator.Text);


            /// <summary>
            /// Se creaza graficul din interfata progres 
            /// </summary>
            for (int i = 0; i < DayVect.Count; i++)
            {
                int Days = DayVect[i];
                float Call = CalVect[i];
                Console.WriteLine(Days);
                Console.WriteLine(Call);

                /// <summary>
                /// Adauga in chart1 datele extrase anterior
                /// </summary>
                this.chart1.Series["Calorii"].Points.AddXY(Days, Convert.ToDouble(Call));
            }

        }
    }
}
