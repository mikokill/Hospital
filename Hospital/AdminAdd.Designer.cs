using Hospital.Properties;
namespace Hospital
{
    partial class AdminAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAdd));
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.hasloTextbox = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.utworzButton = new System.Windows.Forms.Button();
            this.dodano = new System.Windows.Forms.Label();
            this.pokazHasloCheckbox = new System.Windows.Forms.CheckBox();
            this.haslo2Textbox = new System.Windows.Forms.TextBox();
            this.haslo2 = new System.Windows.Forms.Label();
            this.peselTextbox = new System.Windows.Forms.TextBox();
            this.pesel = new System.Windows.Forms.Label();
            this.nazwiskoTextbox = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.Label();
            this.imieTextbox = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.Label();
            this.niezgodneHaslaLabel = new System.Windows.Forms.Label();
            this.istniejacyPesel = new System.Windows.Forms.Label();
            this.pustePola = new System.Windows.Forms.Label();
            this.zajetyLoginLabel = new System.Windows.Forms.Label();
            this.zle = new System.Windows.Forms.Label();
            this.srednie = new System.Windows.Forms.Label();
            this.mocne = new System.Windows.Forms.Label();
            this.znak = new System.Windows.Forms.Label();
            this.cyfra = new System.Windows.Forms.Label();
            this.mala = new System.Windows.Forms.Label();
            this.duza = new System.Windows.Forms.Label();
            this.opisHasla = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.slabeHaslo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.loginTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.loginTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextbox.Location = new System.Drawing.Point(12, 92);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.PlaceholderText = Resources.LoginPlaceholder;
            this.loginTextbox.Size = new System.Drawing.Size(300, 23);
            this.loginTextbox.TabIndex = 1;
            this.loginTextbox.TextChanged += new System.EventHandler(this.LoginTextbox_TextChanged);
            // 
            // hasloTextbox
            // 
            this.hasloTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hasloTextbox.Location = new System.Drawing.Point(12, 167);
            this.hasloTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.hasloTextbox.Name = "hasloTextbox";
            this.hasloTextbox.PlaceholderText = Resources.PasswordPlaceholder;
            this.hasloTextbox.Size = new System.Drawing.Size(300, 23);
            this.hasloTextbox.TabIndex = 2;
            this.hasloTextbox.UseSystemPasswordChar = true;
            this.hasloTextbox.TextChanged += new System.EventHandler(this.HasloTextbox_TextChanged);
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.BackColor = System.Drawing.Color.Transparent;
            this.haslo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haslo.Location = new System.Drawing.Point(12, 138);
            this.haslo.Margin = new System.Windows.Forms.Padding(5);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(44, 19);
            this.haslo.TabIndex = 11;
            this.haslo.Text = Resources.Password;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(12, 63);
            this.login.Margin = new System.Windows.Forms.Padding(5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(43, 19);
            this.login.TabIndex = 13;
            this.login.Text = Resources.Login;
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tytul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tytul.ForeColor = System.Drawing.Color.White;
            this.tytul.Location = new System.Drawing.Point(12, 22);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(327, 21);
            this.tytul.TabIndex = 7;
            this.tytul.Text = Resources.AdminAddTitle;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 68);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // utworzButton
            // 
            this.utworzButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.utworzButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.utworzButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.utworzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utworzButton.Location = new System.Drawing.Point(14, 357);
            this.utworzButton.Margin = new System.Windows.Forms.Padding(10);
            this.utworzButton.Name = "utworzButton";
            this.utworzButton.Size = new System.Drawing.Size(610, 33);
            this.utworzButton.TabIndex = 9;
            this.utworzButton.Text = Resources.Create;
            this.utworzButton.UseVisualStyleBackColor = false;
            this.utworzButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dodano
            // 
            this.dodano.AutoSize = true;
            this.dodano.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dodano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dodano.Location = new System.Drawing.Point(288, 400);
            this.dodano.Name = "dodano";
            this.dodano.Size = new System.Drawing.Size(54, 15);
            this.dodano.TabIndex = 15;
            this.dodano.Text = Resources.Success;
            this.dodano.Visible = false;
            // 
            // pokazHasloCheckbox
            // 
            this.pokazHasloCheckbox.AutoSize = true;
            this.pokazHasloCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.pokazHasloCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pokazHasloCheckbox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pokazHasloCheckbox.Location = new System.Drawing.Point(224, 271);
            this.pokazHasloCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.pokazHasloCheckbox.Name = "pokazHasloCheckbox";
            this.pokazHasloCheckbox.Size = new System.Drawing.Size(88, 17);
            this.pokazHasloCheckbox.TabIndex = 5;
            this.pokazHasloCheckbox.Text = Resources.ShowPass;
            this.pokazHasloCheckbox.UseVisualStyleBackColor = false;
            this.pokazHasloCheckbox.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // haslo2Textbox
            // 
            this.haslo2Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.haslo2Textbox.Location = new System.Drawing.Point(12, 243);
            this.haslo2Textbox.Margin = new System.Windows.Forms.Padding(5);
            this.haslo2Textbox.Name = "haslo2Textbox";
            this.haslo2Textbox.PlaceholderText = "podaj swoje hasło";
            this.haslo2Textbox.Size = new System.Drawing.Size(300, 23);
            this.haslo2Textbox.TabIndex = 4;
            this.haslo2Textbox.UseSystemPasswordChar = true;
            // 
            // haslo2
            // 
            this.haslo2.AutoSize = true;
            this.haslo2.BackColor = System.Drawing.Color.Transparent;
            this.haslo2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.haslo2.Location = new System.Drawing.Point(12, 215);
            this.haslo2.Margin = new System.Windows.Forms.Padding(5);
            this.haslo2.Name = "haslo2";
            this.haslo2.Size = new System.Drawing.Size(95, 19);
            this.haslo2.TabIndex = 11;
            this.haslo2.Text = Resources.Password2;
            // 
            // peselTextbox
            // 
            this.peselTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.peselTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.peselTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.peselTextbox.Location = new System.Drawing.Point(322, 216);
            this.peselTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.peselTextbox.Name = "peselTextbox";
            this.peselTextbox.PlaceholderText = Resources.PeselPlaceholder;
            this.peselTextbox.Size = new System.Drawing.Size(300, 23);
            this.peselTextbox.TabIndex = 8;
            this.peselTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox2_KeyDown);
            // 
            // pesel
            // 
            this.pesel.AutoSize = true;
            this.pesel.BackColor = System.Drawing.Color.Transparent;
            this.pesel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesel.Location = new System.Drawing.Point(322, 187);
            this.pesel.Margin = new System.Windows.Forms.Padding(5);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(45, 19);
            this.pesel.TabIndex = 19;
            this.pesel.Text = Resources.Pesel;
            // 
            // nazwiskoTextbox
            // 
            this.nazwiskoTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nazwiskoTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.nazwiskoTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nazwiskoTextbox.Location = new System.Drawing.Point(322, 154);
            this.nazwiskoTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.nazwiskoTextbox.Name = "nazwiskoTextbox";
            this.nazwiskoTextbox.PlaceholderText = Resources.SurnamePlaceholder;
            this.nazwiskoTextbox.Size = new System.Drawing.Size(300, 23);
            this.nazwiskoTextbox.TabIndex = 7;
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.BackColor = System.Drawing.Color.Transparent;
            this.nazwisko.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwisko.Location = new System.Drawing.Point(322, 125);
            this.nazwisko.Margin = new System.Windows.Forms.Padding(5);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(66, 19);
            this.nazwisko.TabIndex = 20;
            this.nazwisko.Text = Resources.Surname;
            // 
            // imieTextbox
            // 
            this.imieTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.imieTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.imieTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imieTextbox.Location = new System.Drawing.Point(322, 92);
            this.imieTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.imieTextbox.Name = "imieTextbox";
            this.imieTextbox.PlaceholderText = Resources.NamePlaceholder;
            this.imieTextbox.Size = new System.Drawing.Size(300, 23);
            this.imieTextbox.TabIndex = 6;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.BackColor = System.Drawing.Color.Transparent;
            this.imie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imie.Location = new System.Drawing.Point(322, 63);
            this.imie.Margin = new System.Windows.Forms.Padding(5);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(35, 19);
            this.imie.TabIndex = 21;
            this.imie.Text = Resources.Name;
            // 
            // niezgodneHaslaLabel
            // 
            this.niezgodneHaslaLabel.AutoSize = true;
            this.niezgodneHaslaLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.niezgodneHaslaLabel.ForeColor = System.Drawing.Color.Red;
            this.niezgodneHaslaLabel.Location = new System.Drawing.Point(12, 271);
            this.niezgodneHaslaLabel.Margin = new System.Windows.Forms.Padding(0);
            this.niezgodneHaslaLabel.Name = "niezgodneHaslaLabel";
            this.niezgodneHaslaLabel.Size = new System.Drawing.Size(161, 13);
            this.niezgodneHaslaLabel.TabIndex = 22;
            this.niezgodneHaslaLabel.Text = Resources.Password2Fail;
            this.niezgodneHaslaLabel.Visible = false;
            // 
            // istniejacyPesel
            // 
            this.istniejacyPesel.AutoSize = true;
            this.istniejacyPesel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.istniejacyPesel.ForeColor = System.Drawing.Color.Red;
            this.istniejacyPesel.Location = new System.Drawing.Point(322, 244);
            this.istniejacyPesel.Margin = new System.Windows.Forms.Padding(0);
            this.istniejacyPesel.Name = "istniejacyPesel";
            this.istniejacyPesel.Size = new System.Drawing.Size(77, 13);
            this.istniejacyPesel.TabIndex = 23;
            this.istniejacyPesel.Text = Resources.PeselFail;
            this.istniejacyPesel.Visible = false;
            // 
            // pustePola
            // 
            this.pustePola.AutoSize = true;
            this.pustePola.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pustePola.ForeColor = System.Drawing.Color.Red;
            this.pustePola.Location = new System.Drawing.Point(249, 400);
            this.pustePola.Name = "pustePola";
            this.pustePola.Size = new System.Drawing.Size(139, 15);
            this.pustePola.TabIndex = 24;
            this.pustePola.Text = Resources.EmptyFail;
            this.pustePola.Visible = false;
            // 
            // zajetyLoginLabel
            // 
            this.zajetyLoginLabel.AutoSize = true;
            this.zajetyLoginLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zajetyLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.zajetyLoginLabel.Location = new System.Drawing.Point(12, 120);
            this.zajetyLoginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.zajetyLoginLabel.Name = "zajetyLoginLabel";
            this.zajetyLoginLabel.Size = new System.Drawing.Size(131, 13);
            this.zajetyLoginLabel.TabIndex = 25;
            this.zajetyLoginLabel.Text = Resources.LoginTaken;
            this.zajetyLoginLabel.Visible = false;
            // 
            // zle
            // 
            this.zle.AutoSize = true;
            this.zle.BackColor = System.Drawing.Color.Red;
            this.zle.Location = new System.Drawing.Point(12, 321);
            this.zle.Margin = new System.Windows.Forms.Padding(0);
            this.zle.Name = "zle";
            this.zle.Padding = new System.Windows.Forms.Padding(50, 5, 50, 0);
            this.zle.Size = new System.Drawing.Size(100, 20);
            this.zle.TabIndex = 43;
            this.zle.Visible = false;
            // 
            // srednie
            // 
            this.srednie.AutoSize = true;
            this.srednie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.srednie.Location = new System.Drawing.Point(112, 321);
            this.srednie.Margin = new System.Windows.Forms.Padding(0);
            this.srednie.Name = "srednie";
            this.srednie.Padding = new System.Windows.Forms.Padding(50, 5, 50, 0);
            this.srednie.Size = new System.Drawing.Size(100, 20);
            this.srednie.TabIndex = 44;
            this.srednie.Visible = false;
            // 
            // mocne
            // 
            this.mocne.AutoSize = true;
            this.mocne.BackColor = System.Drawing.Color.Lime;
            this.mocne.Location = new System.Drawing.Point(212, 321);
            this.mocne.Margin = new System.Windows.Forms.Padding(0);
            this.mocne.Name = "mocne";
            this.mocne.Padding = new System.Windows.Forms.Padding(50, 5, 50, 0);
            this.mocne.Size = new System.Drawing.Size(100, 20);
            this.mocne.TabIndex = 45;
            this.mocne.Visible = false;
            // 
            // znak
            // 
            this.znak.AutoSize = true;
            this.znak.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.znak.Location = new System.Drawing.Point(322, 323);
            this.znak.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(91, 13);
            this.znak.TabIndex = 50;
            this.znak.Text = Resources.PassReq4;
            // 
            // cyfra
            // 
            this.cyfra.AutoSize = true;
            this.cyfra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cyfra.Location = new System.Drawing.Point(322, 310);
            this.cyfra.Margin = new System.Windows.Forms.Padding(0);
            this.cyfra.Name = "cyfra";
            this.cyfra.Size = new System.Drawing.Size(72, 13);
            this.cyfra.TabIndex = 49;
            this.cyfra.Text = Resources.PassReq3;
            // 
            // mala
            // 
            this.mala.AutoSize = true;
            this.mala.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mala.Location = new System.Drawing.Point(322, 297);
            this.mala.Margin = new System.Windows.Forms.Padding(0);
            this.mala.Name = "mala";
            this.mala.Size = new System.Drawing.Size(104, 13);
            this.mala.TabIndex = 48;
            this.mala.Text = Resources.PassReq2;
            // 
            // duza
            // 
            this.duza.AutoSize = true;
            this.duza.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duza.Location = new System.Drawing.Point(322, 284);
            this.duza.Margin = new System.Windows.Forms.Padding(0);
            this.duza.Name = "duza";
            this.duza.Size = new System.Drawing.Size(105, 13);
            this.duza.TabIndex = 47;
            this.duza.Text = Resources.PassReq1;
            // 
            // opisHasla
            // 
            this.opisHasla.AutoSize = true;
            this.opisHasla.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opisHasla.Location = new System.Drawing.Point(322, 271);
            this.opisHasla.Margin = new System.Windows.Forms.Padding(0);
            this.opisHasla.Name = "opisHasla";
            this.opisHasla.Size = new System.Drawing.Size(194, 13);
            this.opisHasla.TabIndex = 46;
            this.opisHasla.Text = Resources.PassReq;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = Resources.PasswordStrength;
            // 
            // slabeHaslo
            // 
            this.slabeHaslo.AutoSize = true;
            this.slabeHaslo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slabeHaslo.ForeColor = System.Drawing.Color.Red;
            this.slabeHaslo.Location = new System.Drawing.Point(12, 195);
            this.slabeHaslo.Margin = new System.Windows.Forms.Padding(0);
            this.slabeHaslo.Name = "slabeHaslo";
            this.slabeHaslo.Size = new System.Drawing.Size(279, 13);
            this.slabeHaslo.TabIndex = 51;
            this.slabeHaslo.Text = Resources.PasswordFail;
            this.slabeHaslo.Visible = false;
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 426);
            this.Controls.Add(this.slabeHaslo);
            this.Controls.Add(this.zle);
            this.Controls.Add(this.srednie);
            this.Controls.Add(this.mocne);
            this.Controls.Add(this.znak);
            this.Controls.Add(this.cyfra);
            this.Controls.Add(this.mala);
            this.Controls.Add(this.duza);
            this.Controls.Add(this.opisHasla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zajetyLoginLabel);
            this.Controls.Add(this.haslo2Textbox);
            this.Controls.Add(this.peselTextbox);
            this.Controls.Add(this.pustePola);
            this.Controls.Add(this.istniejacyPesel);
            this.Controls.Add(this.niezgodneHaslaLabel);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.nazwiskoTextbox);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imieTextbox);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.dodano);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.pokazHasloCheckbox);
            this.Controls.Add(this.hasloTextbox);
            this.Controls.Add(this.haslo2);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.utworzButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Resources.AppTitle;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox loginTextbox; //
        public TextBox hasloTextbox;
        private Label haslo;
        private Label login;
        private Label tytul;
        private PictureBox pictureBox1;
        public Button utworzButton; //
        private Label dodano;
        public CheckBox pokazHasloCheckbox;
        public TextBox haslo2Textbox;
        private Label haslo2;
        public TextBox peselTextbox; //
        private Label pesel;
        public TextBox nazwiskoTextbox; //
        private Label nazwisko;
        public TextBox imieTextbox; //
        private Label imie;
        private Label niezgodneHaslaLabel;
        private Label istniejacyPesel;
        private Label pustePola;
        private Label zajetyLoginLabel;
        private Label zle;
        private Label srednie;
        private Label mocne;
        private Label znak;
        private Label cyfra;
        private Label mala;
        private Label duza;
        private Label opisHasla;
        private Label label4;
        private Label slabeHaslo;
    }
}