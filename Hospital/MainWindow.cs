using System.Diagnostics;
using System.Globalization;
using static Hospital.Func;

namespace Hospital
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DoctorAdd frm = new(false);
            NurseAdd frm2 = new(false);
            AdminAdd frm3 = new(false);

            frm.button1.Click += new EventHandler(this.Form2_Load);
            frm2.button1.Click += new EventHandler(this.Form2_Load);
            frm3.utworzButton.Click += new EventHandler(this.Form2_Load);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form2_Load(object? sender, EventArgs e)
        {
            if (listpesel.Count == 0)
            {
                DialogResult result = MessageBox.Show(Properties.Resources.NoUsers, Properties.Resources.Warning, MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Hide();
                    AdminAdd f4 = new(false);
                    f4.ShowDialog();
                }
                else { Environment.Exit(0); }
            }
            else
            {
                if (isAdmin)
                {
                    lekarzeDodaj.Visible = true;
                    lekarzeEdytuj.Visible = true;
                    lekarzeUsun.Visible = true;
                    pielegniarkiDodaj.Visible = true;
                    pielegniarkiEdytuj.Visible = true;
                    pielegniarkiUsun.Visible = true;
                    administratorzyDodaj.Visible = true;
                    administratorzyEdytuj.Visible = true;
                    administratorzyLista.Visible = true;
                    administratorzyUsun.Visible = true;
                    button1.Visible = true;
                    button8.Visible = true;
                }
                else if(currentTyp=="Lekarz")
                {
                    listView1.Columns[0].Width = 166;
                    listView1.Columns[1].Width = 166;
                    listView1.Columns[2].Width = 166;
                    listView1.Columns[3].Width = 0;
                    listView1.Columns[4].Width = 0;
                    listView2.Columns[0].Width = 250;
                    listView2.Columns[1].Width = 250;
                    listView2.Columns[2].Width = 0;
                    button1.Location = new Point(3, 3);
                    button1.Visible = true;
                    karty.TabPages.Remove(tabPage3); 
                }
                else if (currentTyp == "Pielegniarka")
                {
                    listView1.Columns[0].Width = 166;
                    listView1.Columns[1].Width = 166;
                    listView1.Columns[2].Width = 166;
                    listView1.Columns[3].Width = 0;
                    listView1.Columns[4].Width = 0;
                    listView2.Columns[0].Width = 250;
                    listView2.Columns[1].Width = 250;
                    listView2.Columns[2].Width = 0;
                    button8.Location = new Point(3, 3);
                    button8.Visible = true;
                    karty.TabPages.Remove(tabPage3);
                }
                listView1.Items.Clear();
                listView2.Items.Clear();
                administratorzyLista.Items.Clear();
                List<string?[]> administratorzyList = new();
                List<string?[]> lekarzeList = new();
                List<string?[]> pielegniarkiList = new();
                for (int i = 0; i < listpesel.Count; i++)
                {
                    if (isAdmin)
                    {
                        if (listtyp[i] == "Admin")
                        {
                            administratorzyList.Add(new[] { listimie[i], listnazwisko[i], listpesel[i] });
                        }
                        else if (listtyp[i] == "Lekarz")
                        {
                            lekarzeList.Add(new[] { listimie[i], listnazwisko[i], listspecjalizacja[i], listpesel[i],  listnrpwz[i] });
                        }
                        else if (listtyp[i] == "Pielegniarka")
                        {
                            pielegniarkiList.Add(new[] { listimie[i], listnazwisko[i], listpesel[i]});
                        }
                    }
                    else
                    {
                        if (listtyp[i] == "Lekarz")
                        {
                            lekarzeList.Add(new[] { listimie[i], listnazwisko[i], listspecjalizacja[i]});
                        }
                        else if (listtyp[i] == "Pielegniarka")
                        {
                            pielegniarkiList.Add(new[] { listimie[i], listnazwisko[i] });
                        }
                    }
                }
                for (int i = 0; i < lekarzeList.Count; i++) 
                    listView1.Items.Add(new ListViewItem(lekarzeList[i]));
                for(int i = 0; i < pielegniarkiList.Count; i++)  
                    listView2.Items.Add(new ListViewItem(pielegniarkiList[i]));
                for (int i = 0; i < administratorzyList.Count; i++) 
                    administratorzyLista.Items.Add(new ListViewItem(administratorzyList[i]));
            }
        }

        private void Button_Dyzury(object sender, EventArgs e)
        {
            showupLabel_Click(sender, e);
            if (isAdmin)
            {
                int x=-1;
                for (int i = 0; i < listView1.Items.Count; i++)
                    if (listView1.Items[i].Selected)
                        x = i;
                if (x==-1)
                {
                    MessageBox.Show(Properties.Resources.EditShifts, Properties.Resources.Warning, MessageBoxButtons.OK);
                }
                else
                {
                        {
                            Shifts f3 = new(listView1.Items[x].SubItems[3].Text);
                            f3.ShowDialog();
                        }
                }
            }
            else
            {
                Shifts f3 = new(currentPesel);
                f3.ShowDialog();
            }
        }

        private void Button_Dyzury1(object sender, EventArgs e)
        {
            showupLabel_Click(sender, e);
            if (isAdmin)
            {
                int x=-1;
                for (int i = 0; i < listView2.Items.Count; i++)
                    if (listView2.Items[i].Selected)
                        x = i;
                if (x==-1)
                {
                    MessageBox.Show(Properties.Resources.EditShifts, Properties.Resources.Warning, MessageBoxButtons.OK);
                }
                else
                {
                        {
                            Shifts f3 = new(listView2.Items[x].SubItems[2].Text);
                            f3.ShowDialog();
                        }
                }
            }
            else
            {
                Shifts f3 = new(currentPesel);
                f3.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DoctorAdd f5 = new(false);
            f5.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            NurseAdd f5 = new(false);
            f5.ShowDialog();
        }

        private void Karty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (karty.SelectedIndex)
            {
                case 0:
                    if (listView1.Items.Count > 0) listView1.Items[0].Selected = true;
                    break;
                case 1:
                    if (listView2.Items.Count > 0) listView2.Items[0].Selected = true;
                    break;
                case 2:
                    if (administratorzyLista.Items.Count > 0) administratorzyLista.Items[0].Selected = true;
                    break;
                default:
                    break;
            }
            Form2_Load(sender, e);
        }

        private void LekarzeEdytuj_Click(object sender, EventArgs e)
        {
            int i;
            int x = -1;
            for (i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].Selected)
                    x=i;
            if(x!=-1)
            {
                string imie = listView1.Items[x].SubItems[0].Text;
                string nazwisko = listView1.Items[x].SubItems[1].Text;
                string pesel = listView1.Items[x].SubItems[3].Text;
                Debug.WriteLine(SprawdzIndexWystapienia(listpesel, pesel));
                string login = listlogin[SprawdzIndexWystapienia(listpesel, pesel)];
                string haslo = GetString(listhaslo[SprawdzIndexWystapienia(listpesel, pesel)]);
                string specjalizacja = listView1.Items[x].SubItems[2].Text;
                string nrpwz = listView1.Items[x].SubItems[4].Text;
                DoctorAdd f = new(true, login, haslo, imie, nazwisko, pesel, nrpwz, specjalizacja);
                f.textBox2.UseSystemPasswordChar = false;
                f.checkBox2.Checked = true;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(Properties.Resources.EditUser, Properties.Resources.Warning, MessageBoxButtons.OK);
            }
            Form2_Load(sender, e);
            Karty_SelectedIndexChanged(sender, e);
        }

        private void LekarzeUsun_Click(object sender, EventArgs e)
        {
            int i;
            int x=-1;
            for (i = 0; i < listView1.Items.Count; i++) 
                if (listView1.Items[i].Selected) 
                    x=i;
            if(x!=-1)
            {
                string imie = listView1.Items[x].SubItems[0].Text;
                string nazwisko = listView1.Items[x].SubItems[1].Text;
                string pesel = listView1.Items[x].SubItems[3].Text;
                string info = Properties.Resources.DeleteConfirmation.Replace("{imie}", imie).Replace("{nazwisko}", nazwisko).Replace("{pesel}", pesel);
                Debug.WriteLine(info);
                DialogResult wynik = MessageBox.Show(
                    info,
                    Properties.Resources.Warning,
                    MessageBoxButtons.YesNo,
                    0,
                    MessageBoxDefaultButton.Button2
                );
                if (wynik == DialogResult.Yes)
                    for (i = 0; i < listpesel.Count; i++)
                        if (listpesel[i] == pesel)
                        {
                            dyzuryDaty.RemoveAt(SprawdzIndexWystapienia(dyzuryPesel, listpesel[i]));
                            dyzurySpecjalizacja.RemoveAt(SprawdzIndexWystapienia(dyzuryPesel, listpesel[i]));
                            dyzuryPesel.RemoveAt(SprawdzIndexWystapienia(dyzuryPesel, listpesel[i]));
                            listimie.RemoveAt(i);
                            listnazwisko.RemoveAt(i);
                            listpesel.RemoveAt(i);
                            listtyp.RemoveAt(i);
                            listlogin.RemoveAt(i);
                            listhaslo.RemoveAt(i);
                            listspecjalizacja.RemoveAt(i);
                            listnrpwz.RemoveAt(i);
                            showupLabel_Click(sender, new EventArgs());
                        }
            }
            else
            {
                MessageBox.Show(Properties.Resources.DeleteUser, Properties.Resources.Warning, MessageBoxButtons.OK);
            }
            Form2_Load(sender, e);
            Karty_SelectedIndexChanged(sender, e);
        }

        private void AdministratorzyUsun_Click(object sender, EventArgs e)
        {
            if(administratorzyLista.Items.Count == 1) MessageBox.Show(Properties.Resources.OneAdmin, Properties.Resources.Warning, MessageBoxButtons.OK);
            else
            {
                int x = -1;
                for (int i = 0; i < administratorzyLista.Items.Count; i++)
                    if (administratorzyLista.Items[i].Selected)
                        x = i;

                if(x!=-1)
                {
                    string imie = administratorzyLista.Items[x].SubItems[0].Text;
                    string nazwisko = administratorzyLista.Items[x].SubItems[1].Text;
                    string pesel = administratorzyLista.Items[x].SubItems[2].Text;
                    string info = Properties.Resources.DeleteConfirmation.Replace("{imie}", imie).Replace("{nazwisko}", nazwisko).Replace("{pesel}", pesel);
                    DialogResult wynik = MessageBox.Show(
                        info,
                        Properties.Resources.Warning,
                        MessageBoxButtons.YesNo,
                        0,
                        MessageBoxDefaultButton.Button2
                    );
                    if (wynik == DialogResult.Yes)
                        for (int i = 0; i < listpesel.Count; i++)
                            if (listpesel[i] == pesel)
                            {
                                listimie.RemoveAt(i);
                                listnazwisko.RemoveAt(i);
                                listpesel.RemoveAt(i);
                                listtyp.RemoveAt(i);
                                listlogin.RemoveAt(i);
                                listhaslo.RemoveAt(i);
                                listspecjalizacja.RemoveAt(i);
                                listnrpwz.RemoveAt(i);
                                showupLabel_Click(sender, new EventArgs());
                            }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.DeleteUser, Properties.Resources.Warning, MessageBoxButtons.OK);
                }
                Form2_Load(sender, e);
                Karty_SelectedIndexChanged(sender, e);
            }
        }

        private void PielegniarkiUsun_Click(object sender, EventArgs e)
        {
            int x=-1;
            for (int i = 0; i < listView2.Items.Count; i++)
                if (listView2.Items[i].Selected)
                    x=i;
            if(x!=-1)
            {
                string imie = listView2.Items[x].SubItems[0].Text;
                string nazwisko = listView2.Items[x].SubItems[1].Text;
                string pesel = listView2.Items[x].SubItems[2].Text;
                string info = Properties.Resources.DeleteConfirmation.Replace("{imie}", imie).Replace("{nazwisko}", nazwisko).Replace("{pesel}", pesel);
                DialogResult wynik = MessageBox.Show(
                    info,
                    Properties.Resources.Warning,
                    MessageBoxButtons.YesNo,
                    0,
                    MessageBoxDefaultButton.Button2
                );
                if (wynik == DialogResult.Yes)
                    for (int i = 0; i < listpesel.Count; i++)
                        if (listpesel[i] == pesel)
                        {
                            dyzuryDaty.RemoveAt(SprawdzIndexWystapienia(dyzuryPesel, listpesel[i]));
                            dyzurySpecjalizacja.RemoveAt(SprawdzIndexWystapienia(dyzuryPesel, listpesel[i]));
                            dyzuryPesel.RemoveAt(SprawdzIndexWystapienia(dyzuryPesel, listpesel[i]));
                            listimie.RemoveAt(i);
                            listnazwisko.RemoveAt(i);
                            listpesel.RemoveAt(i);
                            listtyp.RemoveAt(i);
                            listlogin.RemoveAt(i);
                            listhaslo.RemoveAt(i);
                            listspecjalizacja.RemoveAt(i);
                            listnrpwz.RemoveAt(i);
                            showupLabel_Click(sender, new EventArgs());
                        }
            }
            else
            {
                MessageBox.Show(Properties.Resources.DeleteUser, Properties.Resources.Warning, MessageBoxButtons.OK);
            }
            Form2_Load(sender, e);
            Karty_SelectedIndexChanged(sender, e);
        }

        private void pielegniarkiEdytuj_Click(object sender, EventArgs e)
        {
            int x=-1;
            for (int i = 0; i < listView2.Items.Count; i++)
                if (listView2.Items[i].Selected)
                    x=i;
            if(x!=-1)
            {
                string imie = listView2.Items[x].SubItems[0].Text;
                string nazwisko = listView2.Items[x].SubItems[1].Text;
                string pesel = listView2.Items[x].SubItems[2].Text;
                string login = listlogin[SprawdzIndexWystapienia(listpesel, pesel)];
                string haslo = GetString(listhaslo[SprawdzIndexWystapienia(listpesel, pesel)]);
                NurseAdd f = new(true,login,haslo,imie,nazwisko,pesel);
                f.textBox2.UseSystemPasswordChar = false;
                f.checkBox2.Checked = true;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(Properties.Resources.EditUser, Properties.Resources.Warning, MessageBoxButtons.OK);
            }
            Form2_Load(sender, e);
            Karty_SelectedIndexChanged(sender, e);
        }

        private void administratorzyEdytuj_Click(object sender, EventArgs e)
        {
            int x=-1;
            for (int i = 0; i < administratorzyLista.Items.Count; i++)
                if (administratorzyLista.Items[i].Selected)
                    x=i;
            if(x!=-1)
            {
                string imie = administratorzyLista.Items[x].SubItems[0].Text;
                string nazwisko = administratorzyLista.Items[x].SubItems[1].Text;
                string pesel = administratorzyLista.Items[x].SubItems[2].Text;
                string login = listlogin[SprawdzIndexWystapienia(listpesel, pesel)];
                string haslo = GetString(listhaslo[SprawdzIndexWystapienia(listpesel, pesel)]);
                AdminAdd f = new(true,login,haslo,imie,nazwisko,pesel);
                f.hasloTextbox.UseSystemPasswordChar = false;
                f.pokazHasloCheckbox.Checked = true;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show(Properties.Resources.EditUser, Properties.Resources.Warning, MessageBoxButtons.OK);
            }
            Form2_Load(sender, e);
            Karty_SelectedIndexChanged(sender, e);
        }

        //lekarze
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showup_listView1.Items.Clear();
            showup_listView2.Items.Clear();
            showup_listView3.Items.Clear();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            List<string> list = new();
            int i;
            for(i = 0; i < listtyp.Count; i++)
            {
                if (listtyp[i] == "Lekarz")
                {
                    list.Add(listpesel[i]);
                }
            }
            for (i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    Size = new Size(869, 449);
                    showup_label1.Visible = true;
                    showup_label2.Visible = true;
                    showup_label3.Visible = true;
                    showup_label4.Visible = true;
                    showup_label5.Visible = true;
                    showup_label6.Visible = true;
                    showup_listView1.Visible = true;
                    showup_listView2.Visible = true;
                    showup_listView3.Visible = true;
                    showup_label3.Text = listView1.Items[i].Text + " " + listView1.Items[i].SubItems[1].Text;
                    showup_label4.Text = listView1.Items[i].Text + " " + listView1.Items[i].SubItems[1].Text;
                    showup_label6.Text = listView1.Items[i].Text + " " + listView1.Items[i].SubItems[1].Text;
                    string wybranyPesel = list[i];
                    if (dyzuryPesel.Contains(wybranyPesel))
                    {
                        for (int j = 0; j < dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)].Count; j++)
                        {
                            showup_listView1.Items.Add(new ListViewItem(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)][j].ToShortDateString()));
                            showup_listView2.Items.Add(new ListViewItem(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)][j].ToShortDateString()));
                            showup_listView3.Items.Add(new ListViewItem(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)][j].ToShortDateString()));
                        }
                    }
                }
            }
        }

        //pielęgniarki
        private void listView2_Click(object sender, EventArgs e)
        {
            showup_listView1.Items.Clear();
            showup_listView2.Items.Clear();
            showup_listView3.Items.Clear();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            List<string> list = new();
            int i;
            for (i = 0; i < listtyp.Count; i++)
            {
                if (listtyp[i] == "Pielegniarka")
                {
                    list.Add(listpesel[i]);
                }
            }
            for (i = 0; i < listView2.Items.Count; i++)
            {
                if (listView2.Items[i].Selected)
                {
                    Size = new Size(869, 449);
                    showup_label1.Visible = true;
                    showup_label2.Visible = true;
                    showup_label3.Visible = true;
                    showup_label4.Visible = true;
                    showup_label5.Visible = true;
                    showup_label6.Visible = true;
                    showup_listView1.Visible = true;
                    showup_listView2.Visible = true;
                    showup_listView3.Visible = true;
                    showup_label3.Text = listView2.Items[i].Text + " " + listView2.Items[i].SubItems[1].Text;
                    showup_label4.Text = listView2.Items[i].Text + " " + listView2.Items[i].SubItems[1].Text;
                    showup_label6.Text = listView2.Items[i].Text + " " + listView2.Items[i].SubItems[1].Text;
                    string wybranyPesel = list[i];
                    if (dyzuryPesel.Contains(wybranyPesel))
                    {
                        for (int j = 0; j < dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)].Count; j++)
                        {
                            showup_listView1.Items.Add(new ListViewItem(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)][j].ToShortDateString()));
                            showup_listView2.Items.Add(new ListViewItem(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)][j].ToShortDateString()));
                            showup_listView3.Items.Add(new ListViewItem(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, wybranyPesel)][j].ToShortDateString()));
                        }
                    }
                }
            }
        }
        private void showupLabel_Click(object sender, EventArgs e)
        {
            Size = new Size(666, 488);
            showup_listView1.Visible = false;
            showup_label1.Visible = false;
            showup_label3.Visible = false;
            showup_listView2.Visible = false;
            showup_listView3.Visible = false;
            showup_label2.Visible = false;
            showup_label4.Visible = false;
            showup_label5.Visible = false;
            showup_label6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void administratorzyDodaj_Click(object sender, EventArgs e)
        {
            AdminAdd f4 = new(false);
            f4.ShowDialog();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void listView2_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView2.Columns[e.ColumnIndex].Width;
        }

        private void angToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();
            Form2_Load(sender, e);
            this.Text = Properties.Resources.AppTitle;
        }

        private void polToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pl-PL");
            Controls.Clear();
            InitializeComponent();
            Form2_Load(sender, e);
            this.Text = Properties.Resources.AppTitle;
        }
    }
}
