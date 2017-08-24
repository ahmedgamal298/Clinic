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
    public partial class Following_Form : Form
    {
         MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataSet ds;
        Form1 parent;
        public Following_Form(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void Following_Form_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;userid=root;password=root;database=clinic1;convert zero datetime=True");
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtIC_number.Text == "")
            { MessageBox.Show("من فضلك ادخل الرقم الطبي للمريض", "خطأ"); }
            else
            {
                try
                {
                    command.CommandText = "select * from patient where Ic_number =" + txtIC_number.Text;
                    connection.Open();
                    dr = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    //check if dataGrideView empty?
                    if (dr.HasRows)
                    {
                        
                        string message = "هذا المريض غير موجود هل تريد اضافة جديد ؟?";

                        string title = "نتبيه";

                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                        DialogResult result = MessageBox.Show(message, title, buttons);

                        if (result == DialogResult.Yes)
                        {
                            Form1 f = new Form1();
                            Patient pform = new Patient(f);
                            this.Hide();
                            pform.ShowDialog();

                        }

                        else
                        {

                            this.Close();

                        }
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                    
                    

                    }
                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void Following_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtIC_number.Text != "" && txtMedName.Text != "" && txtMedQui.Text != "" && txtMednums.Text != "" && txtMedRepeat.Text != "")
            {
                try
                {
                    command.CommandText = "insert into p_medicine  values ('" + txtIC_number.Text + "','" + txtMedName.Text + "','" + txtMedQui.Text + "','" + txtMednums.Text + "','" + txtMedRepeat.Text + "');";
                    connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم الأضافة بنجاح");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                   
                    txtMedName.Clear();
                    txtMednums.Clear();
                    txtMedQui.Clear();
                    txtMedRepeat.Clear();
                }
            }
            else
            {
                txtfpnum.Focus();
                MessageBox.Show("من فضلك ادخل جميع البيانات المطلوبة", "خطأ");
            }
          
        }

        private void txtIC_number_TextChanged(object sender, EventArgs e)
        {
            txtfpnum.Text = txtIC_number.Text;
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtfpnum.Text != "" && txtsymp.Text != "" && txtana_result.Text != "" && txtana_result.Text != "" && txtchronic.Text != "" &&txtdName.Text!="" )
            {
                try
                {
                    command.CommandText = "insert into description(fp_number,symptoms,analysis_result,As_a_Result_of_x,chronic_diseases,disease_name,notes,return_time) values ('" + txtfpnum.Text + "','" + txtsymp.Text + "','" + txtana_result.Text + "','" + txtXresult.Text + "','" + txtchronic.Text + "','" + txtdName.Text + "','" + txtnote.Text + "','" + dateTimePicker1.Value.ToString() + "');";
                    connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم الأضافة بنجاح");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    //txtIC_number.Clear();
                    txtMedName.Clear();
                    txtMednums.Clear();
                    txtMedQui.Clear();
                    txtMedRepeat.Clear();
                }
            }
            else
            {
                txtfpnum.Focus();
                MessageBox.Show("من فضلك ادخل جميع البيانات المطلوبة", "خطأ");
            }
          
        }
        }

        }
    

