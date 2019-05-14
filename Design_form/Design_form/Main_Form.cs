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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        
            Sidepanel.Height = button7.Height;
            Sidepanel.Top = button7.Top;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e) // Account
        {
            Sidepanel.Height = button7.Height;
            Sidepanel.Top = button7.Top;
            Account_panel.Visible = true;
            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = true;
            Cards_Panel.Visible = true;
            Mobile_Panel.Visible = true;
            Deposit_Panel.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e) // Cards
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;

            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = true;
            Cards_Panel.Visible = true;
            Mobile_Panel.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e) // Mobile  replenishme
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = true;
            Cards_Panel.Visible = true;
            Mobile_Panel.Visible = true;
            Deposit_Panel.Visible = false;

        }
        private void button4_Click(object sender, EventArgs e) // Tickets
        {
            Sidepanel.Height = button4.Height;
            Sidepanel.Top = button4.Top;
            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = false;
           
        }

        private void button5_Click(object sender, EventArgs e) // Deposits
        {
            Sidepanel.Height = button5.Height;
            Sidepanel.Top = button5.Top;

            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = true;
            Cards_Panel.Visible = true;
            Mobile_Panel.Visible = true;
            Deposit_Panel.Visible = true;
            Account_panel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e) // Exit
        {
            Sidepanel.Height = button6.Height;
            Sidepanel.Top = button6.Top;
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //купити квиткии travel
            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = false;
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //купити квиткии на фільм

            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = true;
            Cards_Panel.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //архів квитків
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //buy

            Payment obj = new Payment();
            obj.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Payment obj = new Payment();
            obj.Show();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
            // mobile pay
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {

        }
        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {

        }

        

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            //buy

            Payment obj = new Payment();
            obj.Show();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            //купити квиткии на фільм

            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = true;
            Cards_Panel.Visible = false;
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            //купити квиткии travel
            Tickets_Panel.Visible = true;
            Travel_Panel.Visible = true;
            Movie_Panel.Visible = false;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            this.bunifuDropdown1.Location = new System.Drawing.Point(463, 186);
            this.bunifuDropdown2.Location = new System.Drawing.Point(137, 186);
           
        }
       

        private void bunifuFlatButton17_Click_1(object sender, EventArgs e)
        {
            Payment obj = new Payment();
            obj.Show();
        }

        
        
    }
}
