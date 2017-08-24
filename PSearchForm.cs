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
    public partial class PSearchForm : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
        Form1 parent;
        public PSearchForm(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }
        private void PSearchForm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;userid=root;password=root;database=clinic1 ");
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


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtFname.Clear();
            radioButton1.Checked = true;
        }

        private void txtLname_MouseClick(object sender, MouseEventArgs e)
        {
            txtLname.Clear();
            radioButton1.Checked = true;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            txtcode.Clear();
            radioButton2.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand();
            command.Connection = connection;
            if (radioButton1.Checked)
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                if (fname != "" && lname != "")
                {

                    try
                    {

                        command.CommandText = "select * from patient where f_namme like '" + fname + "'and l_name like '" + lname + "';";

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
                    MessageBox.Show("من فضلك ادخلك البيانات بطريقة صحيحة ..", "خطأ");
                }

            }
            else if (radioButton2.Checked)
            {
                if (txtcode.Text == "")
                { MessageBox.Show("من فضلك ادخلك البيانات بطريقة صحيحة ..", "خطأ"); }

                else
                {
                    try
                    {
                        command.CommandText = "select * from Patient where Ic_number = " + txtcode.Text;

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
                    finally
                    {
                        connection.Close();

                    }
                }
            }

        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand();
            command.Connection = connection;
            if (radioButton2.Checked)
            {
                if (txtcode.Text == "")
                { MessageBox.Show("من فضلك ادخل البيانات بطريقة صحيحة ", "خطأ"); }
                else
                {

                    try
                    {
                        command.CommandText = "select f_namme , l_name , register_day from patient where Ic_number =" + txtcode.Text;
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
            else
            {

                if (radioButton1.Checked)
                {
                    if (txtFname.Text == "" || txtLname.Text == "")
                    { MessageBox.Show("من فضلك ادخل البيانات بطريقة صحيحة ", "خطأ"); }
                    else
                    {
                        try
                        {
                            command.CommandText = "select f_namme , l_name , register_day from patient where f_namme like '" + txtFname.Text + "'and l_name like '" + txtLname.Text + "';";
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand();
            command.Connection = connection;
            if (radioButton2.Checked)
            {
                if (txtcode.Text == "")
                { MessageBox.Show("من فضلك ادخل البيانات بطريقة صحيحة ", "خطأ"); }
                else
                {
                    try
                    {
                        command.CommandText = "select * from p_medicine where fic_num  = (select Ic_number from patient where Ic_number=" + txtcode.Text + ");";
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
            else
            {
                if (radioButton1.Checked)
                {
                    if (txtFname.Text == "" || txtLname.Text == "")
                    { MessageBox.Show("من فضلك ادخل البيانات بطريقة صحيحة "); }
                    else
                    {
                        try
                        {
                            command.CommandText = "select * from p_medicine where fic_num  = (select Ic_number from patient where f_namme like '" + txtFname.Text + "'and l_name like '" + txtLname.Text + "');";
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


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("هل انت متأكد من الحذف؟", "تنبيه", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something

                command = new MySqlCommand();
                DataSet ds = new DataSet();
                command.Connection = connection;
                if (radioButton1.Checked)
                {
                    string fname = txtFname.Text;
                    string lname = txtLname.Text;
                    if (fname != "" && lname != "")
                    {

                        try
                        {

                            command.CommandText = "delete  from patient where f_namme like '" + fname + "'and l_name like '" + lname + "';";
                               

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
                        MessageBox.Show("من فضلك ادخلك البيانات بطريقة صحيحة ..");
                    }

                }
                else if (radioButton2.Checked)
                {
                    if (txtcode.Text == "")
                    { MessageBox.Show("من فضلك ادخلك البيانات بطريقة صحيحة .."); }

                    else
                    {
                        try
                        {
                            command.CommandText = "delete  from patient where Ic_number  =" + txtcode.Text + ";";

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
                        finally
                        {
                            connection.Close();

                        }
                    }
                }
            }

            else if (dialogResult == DialogResult.No)
            {
                dialogResult = DialogResult.Cancel;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                parent.Show();
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnviewAll_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;

            try
            {
                command.CommandText = "select * from patient;";
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

        private void button4_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (radioButton1.Checked)
            {
                string fname = txtFname.Text;
                string lname = txtLname.Text;
                if (fname != "" && lname != "")
                {

                    try
                    {

                        command.CommandText = "select * from description where fp_number  = (select Ic_number from patient where f_namme like '" + fname + "'and l_name like '" + lname + "');";

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
                    MessageBox.Show("من فضلك ادخلك البيانات بطريقة صحيحة ..", "خطأ");
                }

            }
            else if (radioButton2.Checked)
             
            {
                if (txtcode.Text == "")
                { MessageBox.Show("من فضلك ادخل البيانات بطريقة صحيحة ", "خطأ"); }
                else
                {
                    try
                    {
                        command.CommandText = "select * from description where fp_number  = " + txtcode.Text;
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
        }

        private void PSearchForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            try
            {
                parent.Show();
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }


    }
}
       
    

