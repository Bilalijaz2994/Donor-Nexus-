using System.Drawing;
using System.Windows.Forms;

namespace DonorNexus.UI
{
    partial class HomePageForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.Panel pnlStatDonors;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Panel panel3;
            System.Windows.Forms.Panel panel4;
            System.Windows.Forms.Panel panel5;
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegisterDonor = new System.Windows.Forms.Button();
            this.btnSearchHospital = new System.Windows.Forms.Button();
            this.btnSearchDonor = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            pnlStatDonors = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            pnlStatDonors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStatDonors
            // 
            pnlStatDonors.BackColor = System.Drawing.Color.WhiteSmoke;
            pnlStatDonors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlStatDonors.CausesValidation = false;
            pnlStatDonors.Controls.Add(this.label2);
            pnlStatDonors.Controls.Add(this.label1);
            pnlStatDonors.Controls.Add(this.pictureBox5);
            pnlStatDonors.ForeColor = System.Drawing.Color.BurlyWood;
            pnlStatDonors.Location = new System.Drawing.Point(294, 186);
            pnlStatDonors.Name = "pnlStatDonors";
            pnlStatDonors.Size = new System.Drawing.Size(369, 184);
            pnlStatDonors.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter available donors by blood group,\ncity and need.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Blood Donors";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.CausesValidation = false;
            panel2.Controls.Add(this.label14);
            panel2.Controls.Add(this.label10);
            panel2.Controls.Add(this.label11);
            panel2.ForeColor = System.Drawing.Color.BurlyWood;
            panel2.Location = new System.Drawing.Point(299, 409);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(369, 184);
            panel2.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkRed;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 59);
            this.label14.TabIndex = 11;
            this.label14.Text = "+";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 40);
            this.label10.TabIndex = 9;
            this.label10.Text = "Register new donors and manage donor\r\n records.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "Donor Registration";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.CausesValidation = false;
            panel3.Controls.Add(this.pictureBox6);
            panel3.Controls.Add(this.label12);
            panel3.Controls.Add(this.label13);
            panel3.ForeColor = System.Drawing.Color.BurlyWood;
            panel3.Location = new System.Drawing.Point(707, 409);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(369, 184);
            panel3.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 40);
            this.label12.TabIndex = 9;
            this.label12.Text = "Reach our support team\nfor assistance.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 37);
            this.label13.TabIndex = 1;
            this.label13.Text = "Contact Support";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel4.CausesValidation = false;
            panel4.Controls.Add(this.pictureBox7);
            panel4.Controls.Add(this.label15);
            panel4.Controls.Add(this.label16);
            panel4.ForeColor = System.Drawing.Color.BurlyWood;
            panel4.Location = new System.Drawing.Point(1106, 177);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(369, 184);
            panel4.TabIndex = 12;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.ErrorImage")));
            this.pictureBox7.ImageLocation = "C:\\Users\\Bilal\\Desktop\\DonorNexus";
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(3, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(72, 63);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 40);
            this.label15.TabIndex = 9;
            this.label15.Text = "Quickly request blood during\ncritical situations.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(299, 37);
            this.label16.TabIndex = 1;
            this.label16.Text = "Emergency Request";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel5.CausesValidation = false;
            panel5.Controls.Add(this.pictureBox8);
            panel5.Controls.Add(this.label17);
            panel5.Controls.Add(this.label18);
            panel5.ForeColor = System.Drawing.Color.BurlyWood;
            panel5.Location = new System.Drawing.Point(1106, 409);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(369, 184);
            panel5.TabIndex = 13;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(10, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(72, 63);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(217, 40);
            this.label17.TabIndex = 9;
            this.label17.Text = "View donation activity and\nblood availability insights.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(234, 37);
            this.label18.TabIndex = 1;
            this.label18.Text = "Blood Statistics";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Firebrick;
            this.pnlHeader.Controls.Add(this.lblHeaderText);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(387, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1088, 150);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeaderText.Location = new System.Drawing.Point(34, 102);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(747, 25);
            this.lblHeaderText.TabIndex = 2;
            this.lblHeaderText.Text = "Here you can search blood donors, check hospitals, and support emergency needs.";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.MistyRose;
            this.lblSubtitle.Location = new System.Drawing.Point(34, 68);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(398, 30);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Smart Blood Donation Support System";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(34, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(468, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Donor Nexus";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.pictureBox4);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.label5);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnContact);
            this.pnlMenu.Controls.Add(this.btnLogin);
            this.pnlMenu.Controls.Add(this.btnRegisterDonor);
            this.pnlMenu.Controls.Add(this.btnSearchHospital);
            this.pnlMenu.Controls.Add(this.btnSearchDonor);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(17, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 608);
            this.pnlMenu.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(7, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 59);
            this.label5.TabIndex = 10;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 59);
            this.label4.TabIndex = 9;
            this.label4.Text = "H";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "H";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(14, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnContact
            // 
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnContact.Location = new System.Drawing.Point(52, 405);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(171, 59);
            this.btnContact.TabIndex = 5;
            this.btnContact.Text = "Contact Us";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.Location = new System.Drawing.Point(51, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 59);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegisterDonor
            // 
            this.btnRegisterDonor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegisterDonor.Location = new System.Drawing.Point(51, 236);
            this.btnRegisterDonor.Name = "btnRegisterDonor";
            this.btnRegisterDonor.Size = new System.Drawing.Size(172, 59);
            this.btnRegisterDonor.TabIndex = 3;
            this.btnRegisterDonor.Text = "Register Donor";
            this.btnRegisterDonor.UseVisualStyleBackColor = true;
            this.btnRegisterDonor.Click += new System.EventHandler(this.btnRegisterDonor_Click);
            // 
            // btnSearchHospital
            // 
            this.btnSearchHospital.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchHospital.Location = new System.Drawing.Point(51, 150);
            this.btnSearchHospital.Name = "btnSearchHospital";
            this.btnSearchHospital.Size = new System.Drawing.Size(172, 59);
            this.btnSearchHospital.TabIndex = 2;
            this.btnSearchHospital.Text = "Search Hospitals";
            this.btnSearchHospital.UseVisualStyleBackColor = true;
            this.btnSearchHospital.Click += new System.EventHandler(this.btnSearchHospital_Click);
            // 
            // btnSearchDonor
            // 
            this.btnSearchDonor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchDonor.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearchDonor.Location = new System.Drawing.Point(55, 67);
            this.btnSearchDonor.Name = "btnSearchDonor";
            this.btnSearchDonor.Size = new System.Drawing.Size(168, 59);
            this.btnSearchDonor.TabIndex = 1;
            this.btnSearchDonor.Text = "Search Donors";
            this.btnSearchDonor.UseVisualStyleBackColor = true;
            this.btnSearchDonor.Click += new System.EventHandler(this.btnSearchDonor_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMenu.Location = new System.Drawing.Point(22, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(130, 30);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Main Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "C:\\Users\\Bilal\\Desktop\\DonorNexus";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(695, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 184);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 40);
            this.label9.TabIndex = 13;
            this.label9.Text = "Check hospitals and blood banks\nnear your location.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Hospital Availability";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 37);
            this.label7.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 50);
            this.label6.TabIndex = 10;
            this.label6.Text = "H";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1510, 656);
            this.Controls.Add(panel5);
            this.Controls.Add(panel4);
            this.Controls.Add(panel3);
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(pnlStatDonors);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Nexus - Home";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            pnlStatDonors.ResumeLayout(false);
            pnlStatDonors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegisterDonor;
        private System.Windows.Forms.Button btnSearchHospital;
        private System.Windows.Forms.Button btnSearchDonor;
        private System.Windows.Forms.Label lblMenu;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label1;
        private PictureBox pictureBox5;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label14;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox6;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox7;
        private Label label17;
        private Label label18;
        private System.Diagnostics.EventLog eventLog1;
        private PictureBox pictureBox8;
    }
}
