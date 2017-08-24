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
using System.Configuration;

namespace ABC_clinic
{
    public partial class Patient : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
      
        Form1 parent;
        public Patient(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)//; convert zero datetime= true
        {

            connection = new MySqlConnection("server=localhost;userid=root;password=root;database=clinic1 ");
            try
            {//
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
        }

        private void btnAddpatient_Click(object sender, EventArgs e)
        {
            
            command = new MySqlCommand();
            command.Connection = connection;
            //check empty fields 

            if (txtIC_Num.Text == "" || txtF_Name.Text == "" || txtL_Name.Text == "" || txtAddress.Text == "" || txtphone.Text == "" || txtage.Text == ""  || txtweight.Text == "")
            { MessageBox.Show("من فضلك ادخل جميع البيانات بطريقة صحيحة بعض الحقول فارغة ! "); }
            else
            {
                try
                {
                    command.CommandText = "insert into Patient values ('" + txtIC_Num.Text + "','" + txtF_Name.Text + "','" + txtL_Name.Text + "','" + txtAddress.Text + "','" + txtphone.Text + "','" + txtage.Text + "','" + dateTimePicker1.Value.ToString() + "','" + txtweight.Text + "','" + cmboType.Text + "');";
                connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم تسجيل المريض بنجاح");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }

            }
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {

            command = new MySqlCommand();
            command.Connection = connection;

            if (txtfpnum.Text != "" && txtsymp.Text != "" && txtana_result.Text != "" && txtchronic.Text != "" && txtdName.Text != "" && txtXresult.Text!="" && txtnote.Text != "")
            {
                try
                {
                    command.CommandText = "insert into description(fp_number,symptoms,analysis_result,As_a_Result_of_x,chronic_diseases,disease_name,notes,return_time) values ('" + txtfpnum.Text + "','" + txtsymp.Text + "','" + txtana_result.Text + "','" + txtXresult.Text + "','" + txtchronic.Text + "','" + txtdName.Text + "','" + txtnote.Text + "','" + dateTimePicker2.Value.ToString()+ "');";
                    connection.Open();
                    dr = command.ExecuteReader();
                    MessageBox.Show("تم الأضافة بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { connection.Close(); }

            }
            else
            {
                txtfpnum.Focus();
                MessageBox.Show("من فضلك ادخل جميع البيانات المطلوبة","خطأ");
            }
        }
        
        private void txtIC_Num_TextChanged(object sender, EventArgs e)
        {
            txtfpnum.Text = txtIC_Num.Text;
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand();
            command.Connection = connection;
            if (txtIC_Num.Text != "" && txtMedName.Text != "" && txtMedQui.Text != "" && txtMednums.Text != "" && txtMedRepeat.Text != "")
            {
                try
                {
                    command.CommandText = "insert into p_medicine  values ('" + txtIC_Num.Text + "','" + txtMedName.Text + "','" + txtMedQui.Text + "','" + txtMednums.Text + "','" + txtMedRepeat.Text + "');";
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
                    txtIC_Num.Clear();
                    txtMedName.Clear();
                    txtMednums.Clear();
                    txtMedQui.Clear();
                    txtMedRepeat.Clear();
                }
            }
            else
            {
                txtfpnum.Focus();
                MessageBox.Show("من فضلك ادخل جميع البيانات المطلوبة","خطأ");
            }
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void Patient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void Patient_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void txtIC_Num_TextChanged_1(object sender, EventArgs e)
        {
            txtfpnum.Text = txtIC_Num.Text;
        }

       
        }
        }
    

