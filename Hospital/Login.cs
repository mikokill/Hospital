using static Hospital.Func;
namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox2.UseSystemPasswordChar = false; }
            else { textBox2.UseSystemPasswordChar = true; }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { button1.PerformClick(); }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listpesel.Count != 0)
            {
                for(int i = 0; i < listpesel.Count; i++)
                {
                    if (textBox1.Text == listlogin[i] && textBox2.Text == GetString(listhaslo[i]))
                    {
                        if (listtyp[i] == "Admin") { isAdmin = true; }
                        currentPesel = listpesel[i];
                        currentSpecjalizacja = listspecjalizacja[i];
                        currentTyp = listtyp[i];
                        //currentLogin = listlogin[i];
                        Hide();
                        MainWindow f2 = new();
                        f2.ShowDialog();
                    }
                }
                PokazText(blad,3000);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadEventHandler(object sender, EventArgs e)
        {
        }
    }
}