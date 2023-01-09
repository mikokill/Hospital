using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Shifts : Form
    {
        private readonly string selectedPesel;
        public Shifts(string selectedPesel)
        {
            this.selectedPesel = selectedPesel;
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ShiftAdd f6 = new(selectedPesel, false);
            f6.ShowDialog();
            Dyzury_Load(sender, e);
        }

        private void Dyzury_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for(int i = 0; i < Func.dyzuryPesel.Count; i++)
            {
                if(Func.dyzuryPesel[i] == selectedPesel)
                {
                    for(int n = 0; n < Func.dyzuryDaty[i].Count; n++)
                        listView1.Items.Add(new ListViewItem(Func.dyzuryDaty[i][n].ToShortDateString()));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            int x = -1;
            for (i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].Selected)
                    x = i;
            if (x != -1)
            {
                DialogResult wynik = MessageBox.Show(
                    $"Czy na pewno chcesz usunąć wybrany dyżur?",
                    "UWAGA",
                    MessageBoxButtons.YesNo,
                    0,
                    MessageBoxDefaultButton.Button2
                );
                if (wynik == DialogResult.Yes)
                    Func.dyzuryDaty[Func.SprawdzIndexWystapienia(Func.dyzuryPesel, selectedPesel)].RemoveAt(x);
                Dyzury_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Wybierz dyżur do usunięcia", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int x = -1;
            for (i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].Selected)
                    x = i;
            if (x != -1)
            {
                DateTime date = DateTime.ParseExact(listView1.Items[x].Text, "dd/MM/yyyy", null);
                ShiftAdd f = new(selectedPesel, true, date);
                f.ShowDialog();
                Dyzury_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Wybierz dyżur do edycji", "Uwaga", MessageBoxButtons.OK);
            }
        }
    }
}