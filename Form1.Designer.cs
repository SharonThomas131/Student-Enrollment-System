namespace Thomas_Assign2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrntRoster = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchZid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnAddS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDeptCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCnum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnAddC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.bttnEnroll = new System.Windows.Forms.Button();
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrntRoster
            // 
            this.btnPrntRoster.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnPrntRoster.Location = new System.Drawing.Point(12, 75);
            this.btnPrntRoster.Name = "btnPrntRoster";
            this.btnPrntRoster.Size = new System.Drawing.Size(134, 23);
            this.btnPrntRoster.TabIndex = 0;
            this.btnPrntRoster.Text = "Print Course Roaster";
            this.btnPrntRoster.UseVisualStyleBackColor = true;
            this.btnPrntRoster.Click += new System.EventHandler(this.btnPrntRoster_Click);
            this.btnPrntRoster.MouseLeave += new System.EventHandler(this.btnPrntRoster_MouseLeave);
            this.btnPrntRoster.MouseHover += new System.EventHandler(this.btnPrntRoster_MouseHover);
            // 
            // btnDrop
            // 
            this.btnDrop.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnDrop.Location = new System.Drawing.Point(12, 133);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(134, 23);
            this.btnDrop.TabIndex = 2;
            this.btnDrop.Text = "Drop Student";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            this.btnDrop.MouseLeave += new System.EventHandler(this.btnDrop_MouseLeave);
            this.btnDrop.MouseHover += new System.EventHandler(this.btnDrop_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnSearch.Location = new System.Drawing.Point(12, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Apply Search Criteria";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Student ( by Z-ID )";
            // 
            // txtSearchZid
            // 
            this.txtSearchZid.Location = new System.Drawing.Point(164, 91);
            this.txtSearchZid.Name = "txtSearchZid";
            this.txtSearchZid.Size = new System.Drawing.Size(122, 20);
            this.txtSearchZid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label2.Location = new System.Drawing.Point(161, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter Courses ( by Dept )";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(164, 130);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(122, 20);
            this.txtCourse.TabIndex = 7;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name, First Name ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 232);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Major";
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Items.AddRange(new object[] {
            "Computer Science",
            "Mathematics",
            "Statistics",
            "Theater",
            "Art",
            "Anthropology",
            "Psychology",
            "Marketing",
            "Physics",
            "Finance",
            "Economics",
            "Biological Sciences",
            "Chemistry",
            "Undecided - Any College"});
            this.cbMajor.Location = new System.Drawing.Point(15, 271);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(131, 21);
            this.cbMajor.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label5.Location = new System.Drawing.Point(161, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Z-ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtZid
            // 
            this.txtZid.Location = new System.Drawing.Point(161, 232);
            this.txtZid.Name = "txtZid";
            this.txtZid.Size = new System.Drawing.Size(125, 20);
            this.txtZid.TabIndex = 13;
            this.txtZid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label6.Location = new System.Drawing.Point(161, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Academic Year";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior",
            "PostBacc"});
            this.cbYear.Location = new System.Drawing.Point(161, 271);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(125, 21);
            this.cbYear.TabIndex = 15;
            // 
            // btnAddS
            // 
            this.btnAddS.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.btnAddS.Location = new System.Drawing.Point(15, 298);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(85, 23);
            this.btnAddS.TabIndex = 16;
            this.btnAddS.Text = "Add Student";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            this.btnAddS.MouseLeave += new System.EventHandler(this.btnAddS_MouseLeave);
            this.btnAddS.MouseHover += new System.EventHandler(this.btnAddS_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Department Code";
            // 
            // cbDeptCode
            // 
            this.cbDeptCode.FormattingEnabled = true;
            this.cbDeptCode.Items.AddRange(new object[] {
            "CSCI",
            "MATH",
            "FLGL",
            "ANTH",
            "PSYC",
            "MGMT",
            "ART",
            "MUSE",
            "STAT",
            "PHYS"});
            this.cbDeptCode.Location = new System.Drawing.Point(15, 365);
            this.cbDeptCode.Name = "cbDeptCode";
            this.cbDeptCode.Size = new System.Drawing.Size(131, 21);
            this.cbDeptCode.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Section Number";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(15, 405);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(131, 20);
            this.txtSec.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label9.Location = new System.Drawing.Point(161, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Course Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCnum
            // 
            this.txtCnum.Location = new System.Drawing.Point(161, 366);
            this.txtCnum.Name = "txtCnum";
            this.txtCnum.Size = new System.Drawing.Size(125, 20);
            this.txtCnum.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.label10.Location = new System.Drawing.Point(161, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Capacity";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(164, 406);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(120, 20);
            this.nudCapacity.TabIndex = 24;
            // 
            // btnAddC
            // 
            this.btnAddC.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC.Location = new System.Drawing.Point(15, 431);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(85, 23);
            this.btnAddC.TabIndex = 25;
            this.btnAddC.Text = "Add Course";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            this.btnAddC.MouseLeave += new System.EventHandler(this.btnAddC_MouseLeave);
            this.btnAddC.MouseHover += new System.EventHandler(this.btnAddC_MouseHover);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(323, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(465, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "NIU Enrollment Management System";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(15, 530);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1022, 96);
            this.rtbOutput.TabIndex = 27;
            this.rtbOutput.Text = "";
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(0, 0);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(75, 23);
            this.btnEnroll.TabIndex = 32;
            // 
            // bttnEnroll
            // 
            this.bttnEnroll.Font = new System.Drawing.Font("Modern No. 20", 9.75F);
            this.bttnEnroll.Location = new System.Drawing.Point(12, 104);
            this.bttnEnroll.Name = "bttnEnroll";
            this.bttnEnroll.Size = new System.Drawing.Size(134, 23);
            this.bttnEnroll.TabIndex = 31;
            this.bttnEnroll.Text = "Enroll Student";
            this.bttnEnroll.UseVisualStyleBackColor = true;
            this.bttnEnroll.Click += new System.EventHandler(this.bttnEnroll_Click);
            this.bttnEnroll.MouseLeave += new System.EventHandler(this.bttnEnroll_MouseLeave);
            this.bttnEnroll.MouseHover += new System.EventHandler(this.bttnEnroll_MouseHover);
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.Location = new System.Drawing.Point(469, 75);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(233, 394);
            this.lstStudent.TabIndex = 33;
            this.lstStudent.SelectedIndexChanged += new System.EventHandler(this.lstStudent_SelectedIndexChanged);
            // 
            // lstCourse
            // 
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.Location = new System.Drawing.Point(749, 75);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(233, 394);
            this.lstCourse.TabIndex = 34;
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstCourse);
            this.Controls.Add(this.lstStudent);
            this.Controls.Add(this.bttnEnroll);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddC);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCnum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDeptCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMajor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchZid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnPrntRoster);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrntRoster;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchZid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDeptCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCnum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button bttnEnroll;
        private System.Windows.Forms.ListBox lstStudent;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

