using System.Text.RegularExpressions;
using static Hospital.Func;

namespace Hospital
{
    public partial class AdminAdd : Form
    {
        private readonly string? login1 = null;
        private readonly string? pesel1 = null;
        private readonly bool edycja;
        public AdminAdd(bool edycja, string? login1 = null, string haslo = "", string imie = "", string nazwisko = "", string pesel1 = "")
        {
            InitializeComponent();
            if (edycja)
            {
                this.edycja = edycja;
                this.pesel1 = pesel1;
                this.login1 = login1;
                loginTextbox.Text = login1;
                hasloTextbox.Text = haslo;
                imieTextbox.Text = imie;
                nazwiskoTextbox.Text = nazwisko;
                peselTextbox.Text = pesel1;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pokazHasloCheckbox.Checked) { haslo2Textbox.UseSystemPasswordChar = false; hasloTextbox.UseSystemPasswordChar = false; }
            else { haslo2Textbox.UseSystemPasswordChar = true; hasloTextbox.UseSystemPasswordChar = true; }
        }


        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { utworzButton.PerformClick(); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listpesel.Count!=0)
            {
                if (!edycja)
                {
                    if (SprawdzWystapienia(listpesel, peselTextbox.Text)) { PokazText(istniejacyPesel, 3000); }
                    else if (SprawdzWystapienia(listlogin, loginTextbox.Text)) { PokazText(zajetyLoginLabel, 3000); }
                }
                else if (edycja)
                {
                    if (SprawdzWystapienia(listpesel, peselTextbox.Text)) 
                    { 
                        if(peselTextbox.Text != pesel1) PokazText(istniejacyPesel, 3000); 
                    }
                    else if (SprawdzWystapienia(listlogin, loginTextbox.Text)) 
                    {
                        if (loginTextbox.Text != login1) PokazText(zajetyLoginLabel, 3000);
                    }
                }
                if (haslo2Textbox.Text != hasloTextbox.Text) { PokazText(niezgodneHaslaLabel, 3000); }
                else if (!CzySkladaSieZCyfr(peselTextbox.Text) || peselTextbox.Text.Length != 11) { PokazText(istniejacyPesel, 3000); }
                else if (string.IsNullOrWhiteSpace(loginTextbox.Text) || string.IsNullOrWhiteSpace(hasloTextbox.Text) || string.IsNullOrWhiteSpace(haslo2Textbox.Text) || string.IsNullOrWhiteSpace(nazwiskoTextbox.Text) || string.IsNullOrWhiteSpace(imieTextbox.Text) || string.IsNullOrWhiteSpace(imieTextbox.Text) && !istniejacyPesel.Visible)
                { PokazText(pustePola, 3000); }
                else
                {
                    if (!edycja)
                    {
                        DodajDoListy(string.Concat(imieTextbox.Text[0].ToString().ToUpper(), imieTextbox.Text.AsSpan(1)), string.Concat(nazwiskoTextbox.Text[0].ToString().ToUpper(), nazwiskoTextbox.Text.AsSpan(1)), peselTextbox.Text, "Admin", loginTextbox.Text, hasloTextbox.Text);
                        PokazText(dodano, 3000);
                    }
                    else
                    {
                        int index = SprawdzIndexWystapienia(listpesel, peselTextbox.Text);
                        listimie[index] = imieTextbox.Text;
                        listnazwisko[index] = nazwiskoTextbox.Text;
                        listpesel[index] = peselTextbox.Text;
                        listlogin[index] = loginTextbox.Text;
                        listhaslo[index] = GetBytes(hasloTextbox.Text);
                        //PokazText(zedytowano, 3000);
                    }
                }
            }
            else
            {
                if (haslo2Textbox.Text != hasloTextbox.Text) { PokazText(niezgodneHaslaLabel, 3000); }
                else if (!CzySkladaSieZCyfr(peselTextbox.Text) || peselTextbox.Text.Length != 11) { PokazText(istniejacyPesel, 3000); }
                else if (string.IsNullOrWhiteSpace(loginTextbox.Text) || string.IsNullOrWhiteSpace(hasloTextbox.Text) || string.IsNullOrWhiteSpace(haslo2Textbox.Text) || string.IsNullOrWhiteSpace(nazwiskoTextbox.Text) || string.IsNullOrWhiteSpace(imieTextbox.Text) || string.IsNullOrWhiteSpace(imieTextbox.Text) && !istniejacyPesel.Visible)
                {
                    PokazText(pustePola, 3000);
                }
                else if (!new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])").IsMatch(hasloTextbox.Text)) { PokazText(slabeHaslo, 3000); }
                else
                {
                    DodajDoListy(string.Concat(imieTextbox.Text[0].ToString().ToUpper(), imieTextbox.Text.AsSpan(1)), string.Concat(nazwiskoTextbox.Text[0].ToString().ToUpper(), nazwiskoTextbox.Text.AsSpan(1)), peselTextbox.Text, "Admin", loginTextbox.Text, hasloTextbox.Text);
                    PokazText(dodano, 3000);
                    MainWindow f2 = new();
                    if (!f2.Visible)
                    {
                        Hide();
                        Login f1 = new();
                        f1.ShowDialog();
                    }
                }
            }
        }

        private void HasloTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hasloTextbox.Text)) { zle.Visible = false; srednie.Visible = false; mocne.Visible = false; }
            else
            {
                if (hasloTextbox.TextLength <= 4 && hasloTextbox.TextLength > 0) { zle.Visible = true; srednie.Visible = false; mocne.Visible = false; }
                if (hasloTextbox.TextLength > 4 && hasloTextbox.TextLength < 12) { zle.Visible = true; srednie.Visible = true; mocne.Visible = false; }
                if (hasloTextbox.TextLength >= 12) { zle.Visible = true; srednie.Visible = true; mocne.Visible = true; }
            }
            if (new Regex("[a-z]").IsMatch(hasloTextbox.Text))
            {
                mala.ForeColor = Color.DarkGray;
            }
            else
            {
                mala.ForeColor = Color.Black;
            }
            if (new Regex("[A-Z]").IsMatch(hasloTextbox.Text))
            {
                duza.ForeColor = Color.DarkGray;
            }
            else
            {
                duza.ForeColor = Color.Black;
            }
            if (new Regex("[0-9]").IsMatch(hasloTextbox.Text))
            {
                cyfra.ForeColor = Color.DarkGray;
            }
            else
            {
                cyfra.ForeColor = Color.Black;
            }
            if (new Regex("[^A-Za-z0-9]").IsMatch(hasloTextbox.Text))
            {
                znak.ForeColor = Color.DarkGray;
            }
            else
            {
                znak.ForeColor = Color.Black;
            }
        }

        private void LoginTextbox_TextChanged(object sender, EventArgs e)
        {
            if (listpesel.Count != 0 && !edycja || loginTextbox.Text != login1)
            {
                    if (SprawdzWystapienia(listlogin, loginTextbox.Text)) zajetyLoginLabel.Visible = true;
                    else zajetyLoginLabel.Visible = false;
            }
        }
    }
}
