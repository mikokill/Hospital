using Hospital.Properties;
namespace Hospital
{
    partial class DoctorAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorAdd));
            this.dodano = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hasla = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.Label();
            this.pustePola = new System.Windows.Forms.Label();
            this.blednyPWZ = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mocne = new System.Windows.Forms.Label();
            this.srednie = new System.Windows.Forms.Label();
            this.zle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.duza = new System.Windows.Forms.Label();
            this.mala = new System.Windows.Forms.Label();
            this.cyfra = new System.Windows.Forms.Label();
            this.znak = new System.Windows.Forms.Label();
            this.zajetyLoginLabel = new System.Windows.Forms.Label();
            this.slabeHaslo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dodano
            // 
            this.dodano.AutoSize = true;
            this.dodano.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dodano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dodano.Location = new System.Drawing.Point(287, 477);
            this.dodano.Name = "dodano";
            this.dodano.Size = new System.Drawing.Size(54, 15);
            this.dodano.TabIndex = 13;
            this.dodano.Text = Resources.Success;
            this.dodano.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(12, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = Resources.LoginPlaceholder;
            this.textBox1.Size = new System.Drawing.Size(300, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(12, 172);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = Resources.PasswordPlaceholder;
            this.textBox2.Size = new System.Drawing.Size(300, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = Resources.Password;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = Resources.Login;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = Resources.DoctorAddTitle;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 68);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(611, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = Resources.Create;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(323, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = Resources.SpecLabel;
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Location = new System.Drawing.Point(322, 95);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = Resources.NamePlaceholder;
            this.textBox3.Size = new System.Drawing.Size(300, 23);
            this.textBox3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(322, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = Resources.Name;
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Location = new System.Drawing.Point(322, 157);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = Resources.SurnamePlaceholder;
            this.textBox4.Size = new System.Drawing.Size(300, 23);
            this.textBox4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(322, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = Resources.Surname;
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Location = new System.Drawing.Point(322, 219);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = Resources.PeselPlaceholder;
            this.textBox5.Size = new System.Drawing.Size(300, 23);
            this.textBox5.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(322, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = Resources.Pesel;
            // 
            // textBox6
            // 
            this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox6.Location = new System.Drawing.Point(323, 296);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5);
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = Resources.PwzPlaceholder;
            this.textBox6.Size = new System.Drawing.Size(300, 23);
            this.textBox6.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(323, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = Resources.Pwz;
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.Location = new System.Drawing.Point(12, 244);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = Resources.Password2Placeholder;
            this.textBox7.Size = new System.Drawing.Size(300, 23);
            this.textBox7.TabIndex = 3;
            this.textBox7.UseSystemPasswordChar = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Location = new System.Drawing.Point(224, 271);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = Resources.ShowPass;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(11, 215);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = Resources.Password2;
            // 
            // hasla
            // 
            this.hasla.AutoSize = true;
            this.hasla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hasla.ForeColor = System.Drawing.Color.Red;
            this.hasla.Location = new System.Drawing.Point(11, 272);
            this.hasla.Name = "hasla";
            this.hasla.Size = new System.Drawing.Size(167, 15);
            this.hasla.TabIndex = 25;
            this.hasla.Text = Resources.Password2Fail;
            this.hasla.Visible = false;
            // 
            // pesel
            // 
            this.pesel.AutoSize = true;
            this.pesel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pesel.ForeColor = System.Drawing.Color.Red;
            this.pesel.Location = new System.Drawing.Point(323, 247);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(81, 15);
            this.pesel.TabIndex = 26;
            this.pesel.Text = Resources.PeselFail;
            this.pesel.Visible = false;
            // 
            // pustePola
            // 
            this.pustePola.AutoSize = true;
            this.pustePola.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pustePola.ForeColor = System.Drawing.Color.Red;
            this.pustePola.Location = new System.Drawing.Point(249, 477);
            this.pustePola.Name = "pustePola";
            this.pustePola.Size = new System.Drawing.Size(139, 15);
            this.pustePola.TabIndex = 27;
            this.pustePola.Text = Resources.EmptyFail;
            this.pustePola.Visible = false;
            // 
            // blednyPWZ
            // 
            this.blednyPWZ.AutoSize = true;
            this.blednyPWZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blednyPWZ.ForeColor = System.Drawing.Color.Red;
            this.blednyPWZ.Location = new System.Drawing.Point(324, 324);
            this.blednyPWZ.Name = "blednyPWZ";
            this.blednyPWZ.Size = new System.Drawing.Size(131, 15);
            this.blednyPWZ.TabIndex = 28;
            this.blednyPWZ.Text = Resources.PwzFail;
            this.blednyPWZ.Visible = false;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.link.ForeColor = System.Drawing.Color.Blue;
            this.link.Location = new System.Drawing.Point(451, 324);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(161, 15);
            this.link.TabIndex = 29;
            this.link.Text = Resources.PwzFail2;
            this.link.Visible = false;
            this.link.Click += new System.EventHandler(this.Link_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = Resources.PasswordStrength;
            // 
            // mocne
            // 
            this.mocne.AutoSize = true;
            this.mocne.BackColor = System.Drawing.Color.Lime;
            this.mocne.Location = new System.Drawing.Point(213, 320);
            this.mocne.Margin = new System.Windows.Forms.Padding(0);
            this.mocne.Name = "mocne";
            this.mocne.Padding = new System.Windows.Forms.Padding(50, 5, 50, 0);
            this.mocne.Size = new System.Drawing.Size(100, 20);
            this.mocne.TabIndex = 36;
            this.mocne.Visible = false;
            // 
            // srednie
            // 
            this.srednie.AutoSize = true;
            this.srednie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.srednie.Location = new System.Drawing.Point(113, 320);
            this.srednie.Margin = new System.Windows.Forms.Padding(0);
            this.srednie.Name = "srednie";
            this.srednie.Padding = new System.Windows.Forms.Padding(50, 5, 50, 0);
            this.srednie.Size = new System.Drawing.Size(100, 20);
            this.srednie.TabIndex = 35;
            this.srednie.Visible = false;
            // 
            // zle
            // 
            this.zle.AutoSize = true;
            this.zle.BackColor = System.Drawing.Color.Red;
            this.zle.Location = new System.Drawing.Point(13, 320);
            this.zle.Margin = new System.Windows.Forms.Padding(0);
            this.zle.Name = "zle";
            this.zle.Padding = new System.Windows.Forms.Padding(50, 5, 50, 0);
            this.zle.Size = new System.Drawing.Size(100, 20);
            this.zle.TabIndex = 34;
            this.zle.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 354);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = Resources.PassReq;
            // 
            // duza
            // 
            this.duza.AutoSize = true;
            this.duza.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duza.Location = new System.Drawing.Point(12, 367);
            this.duza.Margin = new System.Windows.Forms.Padding(0);
            this.duza.Name = "duza";
            this.duza.Size = new System.Drawing.Size(105, 13);
            this.duza.TabIndex = 38;
            this.duza.Text = Resources.PassReq1;
            // 
            // mala
            // 
            this.mala.AutoSize = true;
            this.mala.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mala.Location = new System.Drawing.Point(12, 380);
            this.mala.Margin = new System.Windows.Forms.Padding(0);
            this.mala.Name = "mala";
            this.mala.Size = new System.Drawing.Size(104, 13);
            this.mala.TabIndex = 39;
            this.mala.Text = Resources.PassReq2;
            // 
            // cyfra
            // 
            this.cyfra.AutoSize = true;
            this.cyfra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cyfra.Location = new System.Drawing.Point(12, 393);
            this.cyfra.Margin = new System.Windows.Forms.Padding(0);
            this.cyfra.Name = "cyfra";
            this.cyfra.Size = new System.Drawing.Size(72, 13);
            this.cyfra.TabIndex = 40;
            this.cyfra.Text = Resources.PassReq3;
            // 
            // znak
            // 
            this.znak.AutoSize = true;
            this.znak.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.znak.Location = new System.Drawing.Point(12, 406);
            this.znak.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(91, 13);
            this.znak.TabIndex = 41;
            this.znak.Text = Resources.PassReq4;
            // 
            // zajetyLoginLabel
            // 
            this.zajetyLoginLabel.AutoSize = true;
            this.zajetyLoginLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zajetyLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.zajetyLoginLabel.Location = new System.Drawing.Point(12, 123);
            this.zajetyLoginLabel.Name = "zajetyLoginLabel";
            this.zajetyLoginLabel.Size = new System.Drawing.Size(155, 15);
            this.zajetyLoginLabel.TabIndex = 42;
            this.zajetyLoginLabel.Text = Resources.LoginTaken;
            this.zajetyLoginLabel.Visible = false;
            // 
            // slabeHaslo
            // 
            this.slabeHaslo.AutoSize = true;
            this.slabeHaslo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slabeHaslo.ForeColor = System.Drawing.Color.Red;
            this.slabeHaslo.Location = new System.Drawing.Point(11, 200);
            this.slabeHaslo.Name = "slabeHaslo";
            this.slabeHaslo.Size = new System.Drawing.Size(295, 15);
            this.slabeHaslo.TabIndex = 43;
            this.slabeHaslo.Text = Resources.PasswordFail;
            this.slabeHaslo.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Items.AddRange(new object[] {
            Resources.Cardiologist,
            Resources.Urologist,
            Resources.Neurologist,
            Resources.Laryngologist});
            this.comboBox1.Location = new System.Drawing.Point(324, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 23);
            this.comboBox1.TabIndex = 44;
            // 
            // LekarzAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 506);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.slabeHaslo);
            this.Controls.Add(this.zajetyLoginLabel);
            this.Controls.Add(this.zle);
            this.Controls.Add(this.srednie);
            this.Controls.Add(this.mocne);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.cyfra);
            this.Controls.Add(this.mala);
            this.Controls.Add(this.duza);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.link);
            this.Controls.Add(this.blednyPWZ);
            this.Controls.Add(this.pustePola);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.hasla);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dodano);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(Resources.szpital));
            this.MaximizeBox = false;
            this.Name = "LekarzAdd";
            this.Text = Resources.AppTitle;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dodano;
        public TextBox textBox1;
        public TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        public Button button1;
        private Label label6;
        public TextBox textBox3;
        private Label label7;
        public TextBox textBox4;
        private Label label8;
        public TextBox textBox5;
        private Label label9;
        public TextBox textBox6;
        private Label label10;
        private TextBox textBox7;
        public CheckBox checkBox2;
        private Label label11;
        private Label hasla;
        private Label pesel;
        private Label pustePola;
        private Label blednyPWZ;
        private Label link;
        private Label label4;
        private Label mocne;
        private Label srednie;
        private Label zle;
        private Label label12;
        private Label duza;
        private Label mala;
        private Label cyfra;
        private Label znak;
        private Label zajetyLoginLabel;
        private Label slabeHaslo;
        public ComboBox comboBox1;
    }
}