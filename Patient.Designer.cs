namespace ABC_clinic
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmboType = new System.Windows.Forms.ComboBox();
            this.btnAddpatient = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtL_Name = new System.Windows.Forms.TextBox();
            this.txtF_Name = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtIC_Num = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAddDescription = new System.Windows.Forms.Button();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.txtdName = new System.Windows.Forms.TextBox();
            this.txtchronic = new System.Windows.Forms.TextBox();
            this.txtXresult = new System.Windows.Forms.TextBox();
            this.txtana_result = new System.Windows.Forms.TextBox();
            this.txtsymp = new System.Windows.Forms.TextBox();
            this.txtfpnum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMednums = new System.Windows.Forms.TextBox();
            this.txtMedRepeat = new System.Windows.Forms.TextBox();
            this.txtMedQui = new System.Windows.Forms.TextBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.btnAddMed = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmboType);
            this.groupBox1.Controls.Add(this.btnAddpatient);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtL_Name);
            this.groupBox1.Controls.Add(this.txtF_Name);
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtIC_Num);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(898, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات مريض ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // cmboType
            // 
            this.cmboType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmboType.Items.AddRange(new object[] {
            "ذكر ",
            "أنثي"});
            this.cmboType.Location = new System.Drawing.Point(688, 171);
            this.cmboType.Name = "cmboType";
            this.cmboType.Size = new System.Drawing.Size(100, 27);
            this.cmboType.TabIndex = 3;
            this.cmboType.Text = "اختر";
            // 
            // btnAddpatient
            // 
            this.btnAddpatient.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddpatient.Location = new System.Drawing.Point(25, 152);
            this.btnAddpatient.Name = "btnAddpatient";
            this.btnAddpatient.Size = new System.Drawing.Size(165, 36);
            this.btnAddpatient.TabIndex = 2;
            this.btnAddpatient.Text = "تسجيل";
            this.btnAddpatient.UseVisualStyleBackColor = true;
            this.btnAddpatient.Click += new System.EventHandler(this.btnAddpatient_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Location = new System.Drawing.Point(23, 31);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 27);
            this.txtAddress.TabIndex = 1;
            // 
            // txtL_Name
            // 
            this.txtL_Name.AutoCompleteCustomSource.AddRange(new string[] {
            "أحمد ",
            "محمد ",
            "محمود",
            "مصطفي",
            "اسلام ",
            "عصام",
            "عبدالله",
            "عبدالرحمن",
            "عبدالعزيز"});
            this.txtL_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtL_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtL_Name.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtL_Name.Location = new System.Drawing.Point(251, 34);
            this.txtL_Name.Name = "txtL_Name";
            this.txtL_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtL_Name.Size = new System.Drawing.Size(100, 27);
            this.txtL_Name.TabIndex = 1;
            // 
            // txtF_Name
            // 
            this.txtF_Name.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtF_Name.Location = new System.Drawing.Point(480, 31);
            this.txtF_Name.Name = "txtF_Name";
            this.txtF_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtF_Name.Size = new System.Drawing.Size(100, 27);
            this.txtF_Name.TabIndex = 1;
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtweight.Location = new System.Drawing.Point(25, 106);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(100, 27);
            this.txtweight.TabIndex = 1;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtage.Location = new System.Drawing.Point(480, 109);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 27);
            this.txtage.TabIndex = 1;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtphone.Location = new System.Drawing.Point(688, 109);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 27);
            this.txtphone.TabIndex = 1;
            // 
            // txtIC_Num
            // 
            this.txtIC_Num.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIC_Num.Location = new System.Drawing.Point(688, 34);
            this.txtIC_Num.Name = "txtIC_Num";
            this.txtIC_Num.Size = new System.Drawing.Size(100, 27);
            this.txtIC_Num.TabIndex = 1;
            this.txtIC_Num.TextChanged += new System.EventHandler(this.txtIC_Num_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(795, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "رقم التليفون ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(379, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاريخ الدخول ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(602, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "السن ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(850, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "النوع";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(141, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "الوزن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(129, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(379, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "أسم العائلة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(586, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المريض";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(795, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم الطبي";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.btnAddDescription);
            this.groupBox2.Controls.Add(this.txtnote);
            this.groupBox2.Controls.Add(this.txtdName);
            this.groupBox2.Controls.Add(this.txtchronic);
            this.groupBox2.Controls.Add(this.txtXresult);
            this.groupBox2.Controls.Add(this.txtana_result);
            this.groupBox2.Controls.Add(this.txtsymp);
            this.groupBox2.Controls.Add(this.txtfpnum);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(33, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(898, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تشخيص المريض";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 160);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 27);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnAddDescription
            // 
            this.btnAddDescription.Location = new System.Drawing.Point(305, 194);
            this.btnAddDescription.Name = "btnAddDescription";
            this.btnAddDescription.Size = new System.Drawing.Size(115, 36);
            this.btnAddDescription.TabIndex = 3;
            this.btnAddDescription.Text = "تم";
            this.btnAddDescription.UseVisualStyleBackColor = true;
            this.btnAddDescription.Click += new System.EventHandler(this.btnAddDescription_Click);
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(688, 120);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(100, 27);
            this.txtnote.TabIndex = 1;
            // 
            // txtdName
            // 
            this.txtdName.Location = new System.Drawing.Point(452, 82);
            this.txtdName.Name = "txtdName";
            this.txtdName.Size = new System.Drawing.Size(115, 27);
            this.txtdName.TabIndex = 1;
            // 
            // txtchronic
            // 
            this.txtchronic.Location = new System.Drawing.Point(692, 153);
            this.txtchronic.Name = "txtchronic";
            this.txtchronic.Size = new System.Drawing.Size(100, 27);
            this.txtchronic.TabIndex = 1;
            // 
            // txtXresult
            // 
            this.txtXresult.Location = new System.Drawing.Point(688, 73);
            this.txtXresult.Name = "txtXresult";
            this.txtXresult.Size = new System.Drawing.Size(100, 27);
            this.txtXresult.TabIndex = 1;
            // 
            // txtana_result
            // 
            this.txtana_result.Location = new System.Drawing.Point(452, 115);
            this.txtana_result.Name = "txtana_result";
            this.txtana_result.Size = new System.Drawing.Size(115, 27);
            this.txtana_result.TabIndex = 1;
            // 
            // txtsymp
            // 
            this.txtsymp.Location = new System.Drawing.Point(452, 43);
            this.txtsymp.Name = "txtsymp";
            this.txtsymp.Size = new System.Drawing.Size(115, 27);
            this.txtsymp.TabIndex = 1;
            // 
            // txtfpnum
            // 
            this.txtfpnum.Location = new System.Drawing.Point(688, 40);
            this.txtfpnum.Name = "txtfpnum";
            this.txtfpnum.Size = new System.Drawing.Size(100, 27);
            this.txtfpnum.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(798, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "أمراض مزمنة";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(817, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "ملاحظات";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(586, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "أسم المرض ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(582, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "نتيحة التحليل";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "موعد الأعادة";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(603, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "الأعراض ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(795, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "نتيجة الأشعة ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(801, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "الرقم الطبي";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txtMednums);
            this.groupBox3.Controls.Add(this.txtMedRepeat);
            this.groupBox3.Controls.Add(this.txtMedQui);
            this.groupBox3.Controls.Add(this.txtMedName);
            this.groupBox3.Controls.Add(this.btnAddMed);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox3.Location = new System.Drawing.Point(33, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(291, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العلاج";
            // 
            // txtMednums
            // 
            this.txtMednums.Location = new System.Drawing.Point(79, 83);
            this.txtMednums.Name = "txtMednums";
            this.txtMednums.Size = new System.Drawing.Size(100, 27);
            this.txtMednums.TabIndex = 2;
            // 
            // txtMedRepeat
            // 
            this.txtMedRepeat.Location = new System.Drawing.Point(79, 116);
            this.txtMedRepeat.Name = "txtMedRepeat";
            this.txtMedRepeat.Size = new System.Drawing.Size(100, 27);
            this.txtMedRepeat.TabIndex = 2;
            // 
            // txtMedQui
            // 
            this.txtMedQui.Location = new System.Drawing.Point(79, 50);
            this.txtMedQui.Name = "txtMedQui";
            this.txtMedQui.Size = new System.Drawing.Size(100, 27);
            this.txtMedQui.TabIndex = 2;
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(79, 17);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(100, 27);
            this.txtMedName.TabIndex = 2;
            // 
            // btnAddMed
            // 
            this.btnAddMed.Location = new System.Drawing.Point(25, 170);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(115, 36);
            this.btnAddMed.TabIndex = 1;
            this.btnAddMed.Text = "إضافة ";
            this.btnAddMed.UseVisualStyleBackColor = true;
            this.btnAddMed.Click += new System.EventHandler(this.btnAddMed_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(198, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "فترة التكرار";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(204, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "العدد يومياً";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(198, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "كمية العلاج";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(198, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "أسم العلاج";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(764, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "رجوع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(941, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.HelpButton = true;
            this.Name = "Patient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "مريض جديد";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Patient_FormClosed_1);
            this.Load += new System.EventHandler(this.Patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddpatient;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtL_Name;
        private System.Windows.Forms.TextBox txtF_Name;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtIC_Num;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.TextBox txtdName;
        private System.Windows.Forms.TextBox txtchronic;
        private System.Windows.Forms.TextBox txtXresult;
        private System.Windows.Forms.TextBox txtana_result;
        private System.Windows.Forms.TextBox txtsymp;
        private System.Windows.Forms.TextBox txtfpnum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddDescription;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMednums;
        private System.Windows.Forms.TextBox txtMedRepeat;
        private System.Windows.Forms.TextBox txtMedQui;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmboType;

    }
}