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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Finish_Operation obj = new Finish_Operation();
            obj.Show();
            this.Hide();
            
        }
    }
}
