using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; 
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Main_Form obj = new Main_Form();
            obj.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Main_Form obj = new Main_Form();
            obj.Show();
            this.Hide();

        }
    }
}
