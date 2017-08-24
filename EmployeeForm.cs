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
    public partial class EmployeeForm : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
       // MySqlDataAdapter da;
        //DataSet ds;
        Form1 parent;
       
        public EmployeeForm(Form1 p)
        {     parent = p;

            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand();
            command.Connection = connection;
            if (txtem_code.Text == "" || txtaddress.Text == "" || txtage.Text == "" || txtem_name.Text == "")
            { MessageBox.Show("من فضلك ادخل البيانات بطريقة صحيحة "); }
            else
            {
                try
                {
                    command.CommandText = "insert into employee values ('" + txtem_code.Text + "','" + txtaddress.Text + "','" + txtjoptype.Text + "','" + txtem_name.Text + "','" + txtage.Text + "','" + txtsalary.Text + "');";
                    connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم تسجيل الموظف بنجاح");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtinput.Text == "")
            { MessageBox.Show("من فضلك ادخل الكود"); }
            else
            {

                try
                {
                    command.CommandText = "select * from employee where em_code =" + txtinput.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtinput.Text == "")
            { MessageBox.Show("من فضلك ادخل الكود"); }
            else
            {
                DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "تنبيه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    try
                    {


                        command.CommandText = "delete from employee where em_code =" + txtinput.Text;
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
                else
                {
                    if (dialogResult == DialogResult.No)
                        dialogResult = DialogResult.Cancel;
                }
            }
        
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
           
                try
                {
                    command.CommandText = "select * from employee ;";
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

        private void button5_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void EmployeeForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            this.Close();
        }
        }
    }

