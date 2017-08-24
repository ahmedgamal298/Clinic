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
    public partial class MedForm : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
      //  MySqlDataAdapter da;
        Form1 parent;
        public MedForm(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }


        private void MedForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;userid=root;password=root;database=clinic1;convert zero datetime=True");
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



        private void button3_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
           
                try
                {
                    command.CommandText = "select * from medecine;";
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtcode.Text == "")
            { MessageBox.Show("من فضلك ادخل الكود"); }
            else
            {

                try
                {
                    command.CommandText = "select * from medecine where med_code =" + txtcode.Text;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (med1.Text != "" && med2.Text != "" && med3.Text != "" && med4.Text != "" && med5.Text != "")
            {
                try
                {
                    command.CommandText = "insert into medecine values ('" + med1.Text + "','" + med2.Text + "','" + med3.Text + "','" + med4.Text + "','" + med5.Text + "');";
                    connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم إضافة دواء بنجاح","رسالة");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }

            }
            else
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات !","تنبيه"); 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (med1.Text != "" && med2.Text != "" && med3.Text != "" && med4.Text != "" && med5.Text != "" )
            {
                try
                {
                  //  command.CommandText = "insert into medecine values ('" + med1.Text + "','" + med2.Text + "','" + med3.Text + "','" + med4.Text + "','" + med5.Text + "');";
                    connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم إضافة دواء بنجاح","رسالة");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }

            }
            else
            {
                MessageBox.Show("من فضلك ادخل جميع البيانات !","تنبيه");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void MedForm_Leave(object sender, EventArgs e)
        {

        }

        private void MedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            this.Close();
        }

    }
}

