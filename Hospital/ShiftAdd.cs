using System;
using System.Diagnostics;
using static Hospital.Func;

namespace Hospital
{
    public partial class ShiftAdd : Form
    {
        private readonly string selectedPesel;
        private readonly DateTime selectedDate;
        private readonly bool edit;
        public ShiftAdd(string selectedPesel, bool edit, DateTime? time = null)
        {
            InitializeComponent();
            if (time != null && time <= dateTimePicker1.MaxDate && time >= dateTimePicker1.MinDate)
                selectedDate = (DateTime)time;
            else
                selectedDate = DateTime.Now;
            if (edit)
                button1.Text = Properties.Resources.Change;
            this.edit = edit;
            this.selectedPesel = selectedPesel;
            dateTimePicker1.Value = selectedDate;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime wybranaData = dateTimePicker1.Value.Date;
                if (CzyWykorzystanaData(wybranaData, selectedPesel) || !CzyDataDostepna(wybranaData, selectedPesel) || CzyZaDuzoDyzurow(wybranaData, selectedPesel)) PokazText(label2, 3000);
                else
                {
                    if (dyzuryPesel.Contains(selectedPesel))
                    {
                        if (edit)
                        {
                            for(int i =0;i< dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, selectedPesel)].Count; i++)
                            {
                                if(dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, selectedPesel)][i] == selectedDate)
                                {
                                    dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, selectedPesel)][i] = wybranaData;
                                    PokazText(sukcesLabel, 3000);
                                }
                            }
                        }
                        else
                        {
                            dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, selectedPesel)].Add(wybranaData);
                            PokazText(sukcesLabel, 3000);
                        }
                    }
                    else
                    {
                        List<DateTime> listaDat = new();
                        listaDat.Add(wybranaData);
                        dyzuryDaty.Add(listaDat);
                        dyzuryPesel.Add(selectedPesel);
                        dyzurySpecjalizacja.Add(listspecjalizacja[SprawdzIndexWystapienia(listpesel, selectedPesel)]);
                        PokazText(sukcesLabel, 3000);
                    }
                }
        }
    }
}
