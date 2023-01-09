using static Hospital.Func;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Hospital
{
    public partial class NurseAdd : Form
    {
        private readonly string? login;
        private readonly bool edycja;
        public NurseAdd(bool edycja, string? login=null, string haslo = "", string imie = "", string nazwisko = "", string pesel = "")
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
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (listpesel.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox7.Text)) 
                    PokazText(pustePola, 3000);
                else if (textBox2.Text != textBox7.Text) 
                    PokazText(hasla, 3000);
                else if (SprawdzWystapienia(listlogin, textBox1.Text))
                    PokazText(label13, 3000);
                else if (textBox5.Text.Length != 11 && !CzySkladaSieZCyfr(textBox5.Text))
                    PokazText(pesel, 3000);
                else if (SprawdzWystapienia(listpesel, textBox5.Text))
                    PokazText(pesel, 3000);
                else if (!new Regex("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])").IsMatch(textBox2.Text))
                    PokazText(slabeHaslo, 3000);
                else
                {
                    DodajDoListy(
                        string.Concat(textBox3.Text[0].ToString().ToUpper(), textBox3.Text.AsSpan(1)), 
                        string.Concat(textBox4.Text[0].ToString().ToUpper(), textBox4.Text.AsSpan(1)), 
                        textBox5.Text, 
                        "Pielegniarka", 
                        textBox1.Text, 
                        textBox2.Text
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
            if (new Regex("[a-z]").IsMatch(textBox2.Text))
            {
                mala.ForeColor = Color.DarkGray;
            }
            else
            {
                mala.ForeColor = Color.Black;
            }
            if (new Regex("[A-Z]").IsMatch(textBox2.Text))
            {
                duza.ForeColor = Color.DarkGray;
            }
            else
            {
                duza.ForeColor = Color.Black;
            }
            if (new Regex("[0-9]").IsMatch(textBox2.Text))
            {
                cyfra.ForeColor = Color.DarkGray;
            }
            else
            {
                cyfra.ForeColor = Color.Black;
            }
            if (new Regex("[^A-Za-z0-9]").IsMatch(textBox2.Text))
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
                if (SprawdzWystapienia(listlogin, textBox1.Text)) label13.Visible = true;
                else label13.Visible = false;
            }
        }
    }
}
