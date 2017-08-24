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

namespace ABC_clinic
{
    public partial class med_disease : Form
    {
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlConnection connection;
        Form1 parent;
        public med_disease(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtDname.Text == "")
            { MessageBox.Show(" من فضلك ادخل اسم المرض "); }
            else
            {

                try
                {
                    command.CommandText = "select med_code , trade_name ,sc_name ,effic_ma ,effic_side from medecine where med_code in (select fmed_code from treat_diseases where fd_id in (select d_id from diseases where d_name like '" + txtDname.Text + "') );";
                    connection.Open();
                    dr = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }
            }
        }

        private void med_disease_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;userid=root;password=root;database=clinic1");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void med_disease_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

               parent.Show();
               this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              ///  this.Close();
            }
        }
    }
}
