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
    public partial class Finish_Operation : Form
    {
       
        public Finish_Operation()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {

                this.Opacity -= 0.1;

            }
            else
            {
                timer1.Stop();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}
