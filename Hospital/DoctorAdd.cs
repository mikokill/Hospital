using System.Diagnostics;
using System.Text.RegularExpressions;
using static Hospital.Func;

namespace Hospital
{
    public partial class DoctorAdd : Form
    {
        private readonly string login="";
        private readonly bool edycja;
        public DoctorAdd(bool edycja, string login="", string haslo="", string imie="", string nazwisko="", string pesel="", string nrpwz="", string specjalizacja="")
        {
            InitializeComponent();
            if (edycja)
            {
                this.edycja = edycja;
                this.login = login;
                textBox1.Text = login;
                textBox2.Text = haslo;
                textBox3.Text = imie;
                textBox4.Text = nazwisko;
                textBox5.Text = pesel;
                textBox6.Text = nrpwz;
                comboBox1.Text = specjalizacja;
                button1.Text = Properties.Resources.Change;
            }
            else
                comboBox1.Text = Properties.Resources.Cardiologist;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listpesel.Count != 0)
            {
                //sprawdzenie czy wszystkie pola zostały wypełnione
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
                { PokazText(pustePola, 3000); }

                //sprawdzenie czy login nie jest już zajęty
                else if (SprawdzWystapienia(listlogin, textBox1.Text)) { PokazText(zajetyLoginLabel, 3000); }

                //sprawdzenie zgodności haseł
                else if (textBox2.Text != textBox7.Text) PokazText(hasla, 3000);

                //sprawdzenie poprawności numeru PESEL
                else if (textBox5.Text.Length != 11 && !CzySkladaSieZCyfr(textBox5.Text)) PokazText(pesel, 3000);

                //sprawdzenie poprawności numeru PWZ
                else if (!CheckPWZ(textBox6.Text)) 
                { 
                    PokazText(blednyPWZ, 3000); 
                    PokazText(link, 3000); 
                }

                //sprawdzenie czy użytkownik o podanym peselu nie figuruje już w liście wszystkich użytkowników
                else if (SprawdzWystapienia(listpesel, textBox5.Text)) PokazText(pesel, 3000);

                //sprawdzenie złożoności hasła
                else if (!new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])").IsMatch(textBox2.Text)) PokazText(slabeHaslo, 3000);

                else
                {
                    //dodanie do list
                    DodajDoListy(
                        string.Concat(textBox3.Text[0].ToString().ToUpper(), textBox3.Text.AsSpan(1)), //imię 
                        string.Concat(textBox4.Text[0].ToString().ToUpper(), textBox4.Text.AsSpan(1)),  //nazwisko
                        textBox5.Text, //pesel
                        "Lekarz", //typ
                        textBox1.Text, //login
                        textBox2.Text, //hasło
                        comboBox1.Text, //specjalizacja
                        textBox6.Text //nr PWZ
                    );
                    PokazText(dodano, 3000);
                }
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { textBox7.UseSystemPasswordChar = false; textBox2.UseSystemPasswordChar = false; }
            else { textBox7.UseSystemPasswordChar = true; textBox2.UseSystemPasswordChar = true; }
        }

        private void Link_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://nil.org.pl/rejestry/centralny-rejestr-lekarzy/zasady-weryfikowania-nr-prawa-wykonywania-zawodu");
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { zle.Visible = false; srednie.Visible = false; mocne.Visible = false; }
            else
            {
                if (textBox2.TextLength <= 4 && textBox2.TextLength > 0) { zle.Visible = true; srednie.Visible = false; mocne.Visible = false; }
                if (textBox2.TextLength > 4 && textBox2.TextLength < 12) { zle.Visible = true; srednie.Visible = true; mocne.Visible = false; }
                if (textBox2.TextLength >= 12) { zle.Visible = true; srednie.Visible = true; mocne.Visible = true; }
            }
            if(new Regex("[a-z]").IsMatch(textBox2.Text)) 
            { 
                mala.ForeColor = Color.DarkGray; 
            }
            else 
            { 
                mala.ForeColor = Color.Black; 
            }
            if(new Regex("[A-Z]").IsMatch(textBox2.Text)) 
            { 
                duza.ForeColor = Color.DarkGray; 
            }
            else 
            { 
                duza.ForeColor = Color.Black; 
            }
            if(new Regex("[0-9]").IsMatch(textBox2.Text)) 
            { 
                cyfra.ForeColor = Color.DarkGray; 
            }
            else
            {
                cyfra.ForeColor = Color.Black;
            }
            if(new Regex("[^A-Za-z0-9]").IsMatch(textBox2.Text)) 
            { 
                znak.ForeColor = Color.DarkGray; 
            }
            else
            {
                znak.ForeColor = Color.Black;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (listpesel.Count != 0 && !edycja || textBox1.Text != login)
            {
                if (SprawdzWystapienia(listlogin, textBox1.Text)) zajetyLoginLabel.Visible = true;
                else zajetyLoginLabel.Visible = false;
            }
        }
    }
}
