using Hospital.Properties;
namespace Hospital
{
    partial class MainWindow
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Ludzie", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Ludzie", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            "",
            ""}, -1);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Ludzie", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.karty = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.showup_label3 = new System.Windows.Forms.Label();
            this.showup_label1 = new System.Windows.Forms.Label();
            this.showup_listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lekarzeUsun = new System.Windows.Forms.Button();
            this.lekarzeEdytuj = new System.Windows.Forms.Button();
            this.lekarzeDodaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imie = new System.Windows.Forms.ColumnHeader();
            this.nazwisko = new System.Windows.Forms.ColumnHeader();
            this.pesel = new System.Windows.Forms.ColumnHeader();
            this.specjalizacja = new System.Windows.Forms.ColumnHeader();
            this.nrpwz = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.showup_label4 = new System.Windows.Forms.Label();
            this.showup_label2 = new System.Windows.Forms.Label();
            this.showup_listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.pielegniarkiUsun = new System.Windows.Forms.Button();
            this.pielegniarkiEdytuj = new System.Windows.Forms.Button();
            this.pielegniarkiDodaj = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.showup_label6 = new System.Windows.Forms.Label();
            this.showup_label5 = new System.Windows.Forms.Label();
            this.showup_listView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.administratorzyUsun = new System.Windows.Forms.Button();
            this.administratorzyEdytuj = new System.Windows.Forms.Button();
            this.administratorzyDodaj = new System.Windows.Forms.Button();
            this.administratorzyLista = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zmieńJęzykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.angToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karty.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // karty
            // 
            this.karty.Controls.Add(this.tabPage1);
            this.karty.Controls.Add(this.tabPage2);
            this.karty.Controls.Add(this.tabPage3);
            this.karty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.karty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.karty.HotTrack = true;
            this.karty.Location = new System.Drawing.Point(0, 24);
            this.karty.Margin = new System.Windows.Forms.Padding(0);
            this.karty.MaximumSize = new System.Drawing.Size(869, 488);
            this.karty.Multiline = true;
            this.karty.Name = "karty";
            this.karty.SelectedIndex = 0;
            this.karty.Size = new System.Drawing.Size(650, 450);
            this.karty.TabIndex = 0;
            this.karty.SelectedIndexChanged += new System.EventHandler(this.Karty_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.showup_label3);
            this.tabPage1.Controls.Add(this.showup_label1);
            this.tabPage1.Controls.Add(this.showup_listView1);
            this.tabPage1.Controls.Add(this.lekarzeUsun);
            this.tabPage1.Controls.Add(this.lekarzeEdytuj);
            this.tabPage1.Controls.Add(this.lekarzeDodaj);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = global::Hospital.Properties.Resources.Doctors;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(822, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.showupLabel_Click);
            // 
            // showup_label3
            // 
            this.showup_label3.AutoSize = true;
            this.showup_label3.Location = new System.Drawing.Point(642, 21);
            this.showup_label3.Name = "showup_label3";
            this.showup_label3.Size = new System.Drawing.Size(0, 15);
            this.showup_label3.TabIndex = 11;
            // 
            // showup_label1
            // 
            this.showup_label1.AutoSize = true;
            this.showup_label1.Location = new System.Drawing.Point(642, 3);
            this.showup_label1.Name = "showup_label1";
            this.showup_label1.Size = new System.Drawing.Size(115, 15);
            this.showup_label1.TabIndex = 10;
            this.showup_label1.Text = "Dyżury użytkownika:";
            this.showup_label1.Visible = false;
            // 
            // showup_listView1
            // 
            this.showup_listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.showup_listView1.Location = new System.Drawing.Point(642, 42);
            this.showup_listView1.Name = "showup_listView1";
            this.showup_listView1.Size = new System.Drawing.Size(200, 377);
            this.showup_listView1.TabIndex = 9;
            this.showup_listView1.UseCompatibleStateImageBehavior = false;
            this.showup_listView1.View = System.Windows.Forms.View.Details;
            this.showup_listView1.Visible = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            this.columnHeader4.Width = 195;
            // 
            // lekarzeUsun
            // 
            this.lekarzeUsun.AccessibleDescription = "opis";
            this.lekarzeUsun.AccessibleName = "nazwa";
            this.lekarzeUsun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lekarzeUsun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lekarzeUsun.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.lekarzeUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lekarzeUsun.Location = new System.Drawing.Point(3, 81);
            this.lekarzeUsun.Name = "lekarzeUsun";
            this.lekarzeUsun.Size = new System.Drawing.Size(133, 33);
            this.lekarzeUsun.TabIndex = 8;
            this.lekarzeUsun.Text = global::Hospital.Properties.Resources.Delete;
            this.lekarzeUsun.UseVisualStyleBackColor = false;
            this.lekarzeUsun.Visible = false;
            this.lekarzeUsun.Click += new System.EventHandler(this.LekarzeUsun_Click);
            // 
            // lekarzeEdytuj
            // 
            this.lekarzeEdytuj.AccessibleDescription = "opis";
            this.lekarzeEdytuj.AccessibleName = "nazwa";
            this.lekarzeEdytuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lekarzeEdytuj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lekarzeEdytuj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.lekarzeEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lekarzeEdytuj.Location = new System.Drawing.Point(3, 42);
            this.lekarzeEdytuj.Name = "lekarzeEdytuj";
            this.lekarzeEdytuj.Size = new System.Drawing.Size(133, 33);
            this.lekarzeEdytuj.TabIndex = 7;
            this.lekarzeEdytuj.Text = global::Hospital.Properties.Resources.Edit;
            this.lekarzeEdytuj.UseVisualStyleBackColor = false;
            this.lekarzeEdytuj.Visible = false;
            this.lekarzeEdytuj.Click += new System.EventHandler(this.LekarzeEdytuj_Click);
            // 
            // lekarzeDodaj
            // 
            this.lekarzeDodaj.AccessibleDescription = "opis";
            this.lekarzeDodaj.AccessibleName = "nazwa";
            this.lekarzeDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lekarzeDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lekarzeDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.lekarzeDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lekarzeDodaj.Location = new System.Drawing.Point(3, 3);
            this.lekarzeDodaj.Name = "lekarzeDodaj";
            this.lekarzeDodaj.Size = new System.Drawing.Size(133, 33);
            this.lekarzeDodaj.TabIndex = 6;
            this.lekarzeDodaj.Text = global::Hospital.Properties.Resources.Add;
            this.lekarzeDodaj.UseVisualStyleBackColor = false;
            this.lekarzeDodaj.Visible = false;
            this.lekarzeDodaj.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "opis";
            this.button1.AccessibleName = "nazwa";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = global::Hospital.Properties.Resources.Shifts;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button_Dyzury);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.imie,
            this.nazwisko,
            this.pesel,
            this.specjalizacja,
            this.nrpwz});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "Ludzie";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(139, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(500, 416);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.Click += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imie
            // 
            this.imie.Text = global::Hospital.Properties.Resources.Name;
            this.imie.Width = 100;
            // 
            // nazwisko
            // 
            this.nazwisko.Text = global::Hospital.Properties.Resources.Surname;
            this.nazwisko.Width = 100;
            // 
            // pesel
            // 
            this.pesel.Text = global::Hospital.Properties.Resources.Spec;
            this.pesel.Width = 100;
            // 
            // specjalizacja
            // 
            this.specjalizacja.Text = global::Hospital.Properties.Resources.Pesel;
            this.specjalizacja.Width = 100;
            // 
            // nrpwz
            // 
            this.nrpwz.Text = global::Hospital.Properties.Resources.Pwz;
            this.nrpwz.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.showup_label4);
            this.tabPage2.Controls.Add(this.showup_label2);
            this.tabPage2.Controls.Add(this.showup_listView2);
            this.tabPage2.Controls.Add(this.pielegniarkiUsun);
            this.tabPage2.Controls.Add(this.pielegniarkiEdytuj);
            this.tabPage2.Controls.Add(this.pielegniarkiDodaj);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = global::Hospital.Properties.Resources.Nurses;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(822, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.showupLabel_Click);
            // 
            // showup_label4
            // 
            this.showup_label4.AutoSize = true;
            this.showup_label4.Location = new System.Drawing.Point(642, 21);
            this.showup_label4.Name = "showup_label4";
            this.showup_label4.Size = new System.Drawing.Size(0, 15);
            this.showup_label4.TabIndex = 13;
            // 
            // showup_label2
            // 
            this.showup_label2.AutoSize = true;
            this.showup_label2.Location = new System.Drawing.Point(642, 3);
            this.showup_label2.Name = "showup_label2";
            this.showup_label2.Size = new System.Drawing.Size(115, 15);
            this.showup_label2.TabIndex = 12;
            this.showup_label2.Text = "Dyżury użytkownika:";
            this.showup_label2.Visible = false;
            // 
            // showup_listView2
            // 
            this.showup_listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.showup_listView2.Location = new System.Drawing.Point(642, 42);
            this.showup_listView2.Name = "showup_listView2";
            this.showup_listView2.Size = new System.Drawing.Size(200, 377);
            this.showup_listView2.TabIndex = 11;
            this.showup_listView2.UseCompatibleStateImageBehavior = false;
            this.showup_listView2.View = System.Windows.Forms.View.Details;
            this.showup_listView2.Visible = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data";
            this.columnHeader5.Width = 195;
            // 
            // pielegniarkiUsun
            // 
            this.pielegniarkiUsun.AccessibleDescription = "opis";
            this.pielegniarkiUsun.AccessibleName = "nazwa";
            this.pielegniarkiUsun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pielegniarkiUsun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pielegniarkiUsun.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.pielegniarkiUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pielegniarkiUsun.Location = new System.Drawing.Point(3, 81);
            this.pielegniarkiUsun.Name = "pielegniarkiUsun";
            this.pielegniarkiUsun.Size = new System.Drawing.Size(133, 33);
            this.pielegniarkiUsun.TabIndex = 8;
            this.pielegniarkiUsun.Text = global::Hospital.Properties.Resources.Delete;
            this.pielegniarkiUsun.UseVisualStyleBackColor = false;
            this.pielegniarkiUsun.Visible = false;
            this.pielegniarkiUsun.Click += new System.EventHandler(this.PielegniarkiUsun_Click);
            // 
            // pielegniarkiEdytuj
            // 
            this.pielegniarkiEdytuj.AccessibleDescription = "opis";
            this.pielegniarkiEdytuj.AccessibleName = "nazwa";
            this.pielegniarkiEdytuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pielegniarkiEdytuj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pielegniarkiEdytuj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.pielegniarkiEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pielegniarkiEdytuj.Location = new System.Drawing.Point(3, 42);
            this.pielegniarkiEdytuj.Name = "pielegniarkiEdytuj";
            this.pielegniarkiEdytuj.Size = new System.Drawing.Size(133, 33);
            this.pielegniarkiEdytuj.TabIndex = 7;
            this.pielegniarkiEdytuj.Text = global::Hospital.Properties.Resources.Edit;
            this.pielegniarkiEdytuj.UseVisualStyleBackColor = false;
            this.pielegniarkiEdytuj.Visible = false;
            this.pielegniarkiEdytuj.Click += new System.EventHandler(this.pielegniarkiEdytuj_Click);
            // 
            // pielegniarkiDodaj
            // 
            this.pielegniarkiDodaj.AccessibleDescription = "opis";
            this.pielegniarkiDodaj.AccessibleName = "nazwa";
            this.pielegniarkiDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pielegniarkiDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pielegniarkiDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.pielegniarkiDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pielegniarkiDodaj.Location = new System.Drawing.Point(3, 3);
            this.pielegniarkiDodaj.Name = "pielegniarkiDodaj";
            this.pielegniarkiDodaj.Size = new System.Drawing.Size(133, 33);
            this.pielegniarkiDodaj.TabIndex = 6;
            this.pielegniarkiDodaj.Text = global::Hospital.Properties.Resources.Add;
            this.pielegniarkiDodaj.UseVisualStyleBackColor = false;
            this.pielegniarkiDodaj.Visible = false;
            this.pielegniarkiDodaj.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.AccessibleDescription = "opis";
            this.button8.AccessibleName = "nazwa";
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(3, 383);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 33);
            this.button8.TabIndex = 4;
            this.button8.Text = global::Hospital.Properties.Resources.Shifts;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.Button_Dyzury1);
            // 
            // listView2
            // 
            this.listView2.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView2.AllowColumnReorder = true;
            this.listView2.BackgroundImageTiled = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            listViewGroup2.Header = "Ludzie";
            listViewGroup2.Name = "listViewGroup1";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView2.Location = new System.Drawing.Point(139, 3);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.ShowGroups = false;
            this.listView2.Size = new System.Drawing.Size(500, 416);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView2_ColumnWidthChanging);
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = global::Hospital.Properties.Resources.Name;
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = global::Hospital.Properties.Resources.Surname;
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = global::Hospital.Properties.Resources.Pesel;
            this.columnHeader3.Width = 166;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.showup_label6);
            this.tabPage3.Controls.Add(this.showup_label5);
            this.tabPage3.Controls.Add(this.showup_listView3);
            this.tabPage3.Controls.Add(this.administratorzyUsun);
            this.tabPage3.Controls.Add(this.administratorzyEdytuj);
            this.tabPage3.Controls.Add(this.administratorzyDodaj);
            this.tabPage3.Controls.Add(this.administratorzyLista);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(642, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = global::Hospital.Properties.Resources.Admins;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(822, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.showupLabel_Click);
            // 
            // showup_label6
            // 
            this.showup_label6.AutoSize = true;
            this.showup_label6.Location = new System.Drawing.Point(642, 21);
            this.showup_label6.Name = "showup_label6";
            this.showup_label6.Size = new System.Drawing.Size(0, 15);
            this.showup_label6.TabIndex = 17;
            // 
            // showup_label5
            // 
            this.showup_label5.AutoSize = true;
            this.showup_label5.Location = new System.Drawing.Point(642, 3);
            this.showup_label5.Name = "showup_label5";
            this.showup_label5.Size = new System.Drawing.Size(115, 15);
            this.showup_label5.TabIndex = 16;
            this.showup_label5.Text = "Dyżury użytkownika:";
            this.showup_label5.Visible = false;
            // 
            // showup_listView3
            // 
            this.showup_listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.showup_listView3.Location = new System.Drawing.Point(642, 42);
            this.showup_listView3.Name = "showup_listView3";
            this.showup_listView3.Size = new System.Drawing.Size(200, 377);
            this.showup_listView3.TabIndex = 15;
            this.showup_listView3.UseCompatibleStateImageBehavior = false;
            this.showup_listView3.View = System.Windows.Forms.View.Details;
            this.showup_listView3.Visible = false;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data";
            this.columnHeader9.Width = 195;
            // 
            // administratorzyUsun
            // 
            this.administratorzyUsun.AccessibleDescription = "opis";
            this.administratorzyUsun.AccessibleName = "nazwa";
            this.administratorzyUsun.AutoSize = true;
            this.administratorzyUsun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.administratorzyUsun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administratorzyUsun.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.administratorzyUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administratorzyUsun.Location = new System.Drawing.Point(3, 81);
            this.administratorzyUsun.Name = "administratorzyUsun";
            this.administratorzyUsun.Size = new System.Drawing.Size(133, 33);
            this.administratorzyUsun.TabIndex = 7;
            this.administratorzyUsun.Text = global::Hospital.Properties.Resources.Delete;
            this.administratorzyUsun.UseVisualStyleBackColor = false;
            this.administratorzyUsun.Visible = false;
            this.administratorzyUsun.Click += new System.EventHandler(this.AdministratorzyUsun_Click);
            // 
            // administratorzyEdytuj
            // 
            this.administratorzyEdytuj.AccessibleDescription = "opis";
            this.administratorzyEdytuj.AccessibleName = "nazwa";
            this.administratorzyEdytuj.AutoSize = true;
            this.administratorzyEdytuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.administratorzyEdytuj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administratorzyEdytuj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.administratorzyEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administratorzyEdytuj.Location = new System.Drawing.Point(3, 42);
            this.administratorzyEdytuj.Name = "administratorzyEdytuj";
            this.administratorzyEdytuj.Size = new System.Drawing.Size(133, 33);
            this.administratorzyEdytuj.TabIndex = 6;
            this.administratorzyEdytuj.Text = global::Hospital.Properties.Resources.Edit;
            this.administratorzyEdytuj.UseVisualStyleBackColor = false;
            this.administratorzyEdytuj.Visible = false;
            this.administratorzyEdytuj.Click += new System.EventHandler(this.administratorzyEdytuj_Click);
            // 
            // administratorzyDodaj
            // 
            this.administratorzyDodaj.AccessibleDescription = "opis";
            this.administratorzyDodaj.AccessibleName = "nazwa";
            this.administratorzyDodaj.AutoSize = true;
            this.administratorzyDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.administratorzyDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administratorzyDodaj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.administratorzyDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administratorzyDodaj.Location = new System.Drawing.Point(3, 3);
            this.administratorzyDodaj.Name = "administratorzyDodaj";
            this.administratorzyDodaj.Size = new System.Drawing.Size(133, 33);
            this.administratorzyDodaj.TabIndex = 5;
            this.administratorzyDodaj.Text = global::Hospital.Properties.Resources.Add;
            this.administratorzyDodaj.UseVisualStyleBackColor = false;
            this.administratorzyDodaj.Visible = false;
            this.administratorzyDodaj.Click += new System.EventHandler(this.administratorzyDodaj_Click);
            // 
            // administratorzyLista
            // 
            this.administratorzyLista.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.administratorzyLista.AllowColumnReorder = true;
            this.administratorzyLista.BackgroundImageTiled = true;
            this.administratorzyLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.administratorzyLista.FullRowSelect = true;
            this.administratorzyLista.GridLines = true;
            listViewGroup3.Header = "Ludzie";
            listViewGroup3.Name = "listViewGroup1";
            this.administratorzyLista.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            this.administratorzyLista.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.administratorzyLista.Location = new System.Drawing.Point(139, 3);
            this.administratorzyLista.MultiSelect = false;
            this.administratorzyLista.Name = "administratorzyLista";
            this.administratorzyLista.ShowGroups = false;
            this.administratorzyLista.Size = new System.Drawing.Size(500, 416);
            this.administratorzyLista.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.administratorzyLista.TabIndex = 4;
            this.administratorzyLista.UseCompatibleStateImageBehavior = false;
            this.administratorzyLista.View = System.Windows.Forms.View.Details;
            this.administratorzyLista.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = global::Hospital.Properties.Resources.Name;
            this.columnHeader6.Width = 166;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = global::Hospital.Properties.Resources.Surname;
            this.columnHeader7.Width = 166;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = global::Hospital.Properties.Resources.Pesel;
            this.columnHeader8.Width = 166;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńJęzykToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zmieńJęzykToolStripMenuItem
            // 
            this.zmieńJęzykToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.zmieńJęzykToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.zmieńJęzykToolStripMenuItem.Name = "zmieńJęzykToolStripMenuItem";
            this.zmieńJęzykToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.zmieńJęzykToolStripMenuItem.Text = global::Hospital.Properties.Resources.Options;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angToolStripMenuItem,
            this.polToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = global::Hospital.Properties.Resources.ChangeLanguage;
            // 
            // angToolStripMenuItem
            // 
            this.angToolStripMenuItem.Name = "angToolStripMenuItem";
            this.angToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.angToolStripMenuItem.Text = global::Hospital.Properties.Resources.English;
            this.angToolStripMenuItem.Click += new System.EventHandler(this.angToolStripMenuItem_Click);
            // 
            // polToolStripMenuItem
            // 
            this.polToolStripMenuItem.Name = "polToolStripMenuItem";
            this.polToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polToolStripMenuItem.Text = global::Hospital.Properties.Resources.Polish;
            this.polToolStripMenuItem.Click += new System.EventHandler(this.polToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(650, 474);
            this.Controls.Add(this.karty);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(868, 513);
            this.MinimumSize = new System.Drawing.Size(666, 513);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Ewidencji Pracowników Szpitala";
            this.Activated += new System.EventHandler(this.Form2_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Enter += new System.EventHandler(this.Form2_Load);
            this.karty.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl karty;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button lekarzeUsun;
        private Button lekarzeEdytuj;
        private Button lekarzeDodaj;
        private Button button1;
        private ListView listView1;
        private ColumnHeader imie;
        private ColumnHeader nazwisko;
        private ColumnHeader pesel;
        private ColumnHeader specjalizacja;
        private ColumnHeader nrpwz;
        private Button pielegniarkiUsun;
        private Button pielegniarkiEdytuj;
        private Button pielegniarkiDodaj;
        private Button button8;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label showup_label1;
        private ListView showup_listView1;
        private ColumnHeader columnHeader4;
        private Label showup_label2;
        private ListView showup_listView2;
        private ColumnHeader columnHeader5;
        private Button administratorzyUsun;
        private Button administratorzyEdytuj;
        private Button administratorzyDodaj;
        private ListView administratorzyLista;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label showup_label3;
        private Label showup_label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label showup_label6;
        private Label showup_label5;
        private ListView showup_listView3;
        private ColumnHeader columnHeader9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem zmieńJęzykToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem angToolStripMenuItem;
        private ToolStripMenuItem polToolStripMenuItem;
    }
}