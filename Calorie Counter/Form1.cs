/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *                                                                        *
 *  Descriere:   Interfata de Start                                       *
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


namespace Calorie_Counter
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Buton de iesire
        /// </summary>
        private void btnIesire_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSetari_Click(object sender, EventArgs e)
        {
            Setari setari = new Setari(this);
            setari.Show();
            this.Hide();
        }

        /// <summary>
        /// Buton care te duce la pagina de login
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
            this.Hide();
        }


        /// <summary>
        /// Buton de exit
        /// </summary>
        private void Meniu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("Calorie Counter.chm");
        }
    }
}
