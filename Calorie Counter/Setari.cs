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

namespace Calorie_Counter
{
    public partial class Setari : Form
    {
        private Meniu _meniu;

        public Setari()
        {
            InitializeComponent();
        }

        public Setari(Meniu meniu)
        {
            InitializeComponent();
            _meniu = meniu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _meniu.Show();
            this.Hide();
        }

        private void Setari_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
