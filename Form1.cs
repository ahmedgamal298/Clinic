using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace ABC_clinic
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;  
 
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            connection = new MySqlConnection("server=localhost;userid=root;password=root ; database=clinic1");
            try
            {
                connection.Open();

               // MessageBox.Show("Welcome to our Program , press ok to continue ..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }

        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient f2 = new  Patient(this);
            this.Hide();
            f2.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Program ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Patient pform = new Patient(this);
            this.Hide();
            pform.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalenderForm calform = new CalenderForm();
          //  this.Hide();
           calform.ShowDialog();
        }

        //private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Restart();
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            MedForm mdform = new MedForm(this);
            this.Hide();
            mdform.ShowDialog();
        }

        private void searchToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MedForm mdform = new MedForm(this);
            this.Hide();
            mdform.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           Environment.Exit(1);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Following_Form fform = new Following_Form(this);
            this.Hide();
            fform.ShowDialog();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MedForm mdform = new MedForm(this);
            this.Hide();
            mdform.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            PSearchForm psearch = new PSearchForm(this);
            this.Hide();
            psearch.ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm emform = new EmployeeForm(this);
            this.Hide();
            emform.ShowDialog();
        }

        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PSearchForm p = new PSearchForm(this);
            this.Hide();
            p.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmployeeForm emform = new EmployeeForm(this);
            this.Hide();
            emform.ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm emform = new EmployeeForm(this);
            this.Hide();
            emform.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            med_disease medDfrom = new med_disease(this);
            this.Hide();
            medDfrom.ShowDialog();
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hlFrom = new HelpForm(this);
            this.Hide();
            hlFrom.ShowDialog();

        }
        //display current time in a label1
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            this.label1.Text = DateTime.Now.ToString();
        }
         
        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PSearchForm preport = new PSearchForm(this);
            this.Hide();
            preport.Show();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutForm aboutf = new aboutForm();
            aboutf.Show();

        }
    }
}
