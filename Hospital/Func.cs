using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;

namespace Hospital
{
    public static class Func
    {
        public static bool isAdmin = false;
        public static string currentPesel = "0";
        public static string currentSpecjalizacja = "0";
        public static string editLogin = "0";
        public static string currentTyp = "0";

        public static void PokazText(Label label, int czas)
        {
            label.Visible = true;
            System.Windows.Forms.Timer t = new()
            {
                Interval = czas
            };
            t.Tick += (s, events) =>
            {
                label.Visible = false;
                t.Stop();
            };
            t.Start();
        }

        public static byte[] GetBytes(string? str)
        {
            if (str is not null)
            {
                byte[] bytes = new byte[str.Length * sizeof(char)];
                System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
                return bytes;
            }
            else return Array.Empty<byte>();
        }

        public static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        public static bool CheckPWZ(string numerPwz)
        {
            if (numerPwz.Length != 7) { return false; }
            else
            {
                int liczbaKontrolna = numerPwz[0] - '0';
                int b = numerPwz[1] - '0';
                int c = (numerPwz[2] - '0') * 2;
                int d = (numerPwz[3] - '0') * 3;
                int e = (numerPwz[4] - '0') * 4;
                int f = (numerPwz[5] - '0') * 5;
                int g = (numerPwz[6] - '0') * 6;
                int suma = b + c + d + e + f + g;
                return suma % 11 == liczbaKontrolna;
            }
        }

        public static bool SprawdzWystapienia(List<string>? listaDoPrzeszukania, string slowoDoSprawdzenia)
        {
            if (listaDoPrzeszukania is not null)
            {
                for (int i = 0; i < listaDoPrzeszukania.Count; i++)
                {
                    if (slowoDoSprawdzenia == listaDoPrzeszukania[i]) { return true; }
                }
                return false;
            }
            else return false;
        }

        public static int SprawdzIndexWystapienia(List<string> listaDoPrzeszukania, string slowoDoSprawdzenia)
        {
            int i;
            for (i = 0; i < listaDoPrzeszukania.Count; i++)
            {
                if (listaDoPrzeszukania[i] == slowoDoSprawdzenia)
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool CzyZaDuzoDyzurow(DateTime data, string pesel)
        {
            int wybranyMiesiac = data.Month;
            int wybranyRok = data.Year;
            int sumaMiesiecy = 0;
            if (dyzuryPesel.Contains(pesel))
            {
                List<DateTime> aktualneDyzury = dyzuryDaty[SprawdzIndexWystapienia(dyzuryPesel, pesel)];
                for (int i = 0; i < aktualneDyzury.Count; i++)
                {
                    if (wybranyMiesiac == aktualneDyzury[i].Month && wybranyRok == aktualneDyzury[i].Year)
                        sumaMiesiecy++;
                }
            }
            if (sumaMiesiecy == 10)
                return true;
            else
                return false;
        }
        public static bool CzyWykorzystanaData(DateTime data, string pesel)
        {
            if (dyzuryPesel.Contains(pesel))
            {
                for (int i = 0; i < dyzuryPesel.Count; i++)
                {
                    if (dyzuryPesel[i] == pesel)
                    {
                        if (dyzuryDaty[i].Contains(data))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool CzyDataDostepna(DateTime data, string pesel)
        {
            if (dyzuryPesel.Contains(pesel))
            {
                for (int i = 0; i < dyzurySpecjalizacja.Count; i++)
                {
                    if (dyzurySpecjalizacja[i] == listspecjalizacja[SprawdzIndexWystapienia(listpesel, pesel)])
                    {
                        if (dyzuryDaty[i].Contains(data))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static bool CzySkladaSieZCyfr(string tekst)
        {
            foreach (char c in tekst)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static List<string> listimie = new();
        public static List<string> listnazwisko = new();
        public static List<string> listpesel = new();
        public static List<string> listtyp = new();
        public static List<string> listlogin = new();
        public static List<byte[]> listhaslo = new();
        public static List<string> listspecjalizacja = new();
        public static List<string> listnrpwz = new();

        public static List<List<DateTime>> dyzuryDaty = new();
        public static List<string> dyzuryPesel = new();
        public static List<string> dyzurySpecjalizacja = new();

        public static void DodajDoListy(string imie, string nazwisko, string pesel, string typ, string login, string haslo, string specjalizacja = "0", string nrpwz = "0")
        {
            if (imie == null || nazwisko == null || pesel == null || typ == null || login == null || haslo == null) { Debug.WriteLine("Nie podano któregoś z wymaganych parametrów funkcji DodajDoListy w cs"); }
            else
            {
                listimie.Add(imie);
                listnazwisko.Add(nazwisko);
                listpesel.Add(pesel);
                listtyp.Add(typ);
                listlogin.Add(login);
                listhaslo.Add(GetBytes(haslo));
                listspecjalizacja.Add(specjalizacja);
                listnrpwz.Add(nrpwz);
            }
        }

        public static void SerializujDyzury()
        {
            if (dyzuryPesel.Count != 0)
            {
                var dane = new DataShifts() 
                { 
                    Specjalizacja = dyzurySpecjalizacja,
                    Daty = dyzuryDaty,
                    Pesel = dyzuryPesel
                };
                string jsonString = JsonSerializer.Serialize(dane, new JsonSerializerOptions { WriteIndented = true });
                string nazwaPliku = "shiftsData.json";
                File.WriteAllText(nazwaPliku, jsonString);
                Debug.WriteLine("Zapisano do pliku " + dyzuryPesel.Count);
            }
            else Debug.WriteLine("Nie zapisano do pliku");
        }
        public static void SerializujDane()
        {
            if (listimie.Count != 0)
            {
                var dane = new Data()
                {
                    Imie = listimie,
                    Nazwisko = listnazwisko,
                    Pesel = listpesel,
                    Typ = listtyp,
                    Login = listlogin,
                    Haslo = listhaslo,
                    Specjalizacja = listspecjalizacja,
                    Nrpwz = listnrpwz
                };
                string jsonString = JsonSerializer.Serialize(dane, new JsonSerializerOptions { WriteIndented = true });
                string nazwaPliku = "usersData.json";
                File.WriteAllText(nazwaPliku, jsonString);
                Debug.WriteLine("Zapisano do pliku "+listimie.Count);
            }
            else Debug.WriteLine("Nie zapisano do pliku");
        }

        public static bool DeserializujDyzury()
        {
            string nazwaPliku = "shiftsData.json";
            if (File.Exists(nazwaPliku) && File.ReadAllText(nazwaPliku) != string.Empty)
            {
                string jsonString = File.ReadAllText(nazwaPliku);
                Console.WriteLine(File.ReadAllText(nazwaPliku));
                var stare = JsonSerializer.Deserialize<DataShifts>(jsonString);
                if (stare is not null)
                {
                    dyzuryPesel = stare.Pesel;
                    dyzurySpecjalizacja = stare.Specjalizacja;
                    dyzuryDaty = stare.Daty;
                    Debug.WriteLine("Wczytano z pliku "+dyzuryPesel.Count);
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public static bool DeserializujDane()
        {
            string nazwaPliku = "usersData.json";
            if (File.Exists(nazwaPliku) && File.ReadAllText(nazwaPliku) != string.Empty)
            {
                string jsonString = File.ReadAllText(nazwaPliku);
                Console.WriteLine(File.ReadAllText(nazwaPliku));
                var stare = JsonSerializer.Deserialize<Data>(jsonString);
                if (stare is not null)
                {
                    listimie = stare.Imie;
                    listnazwisko = stare.Nazwisko;
                    listpesel = stare.Pesel;
                    listtyp = stare.Typ;
                    listlogin = stare.Login;
                    listhaslo = stare.Haslo;
                    listspecjalizacja = stare.Specjalizacja;
                    listnrpwz = stare.Nrpwz;
                    Debug.WriteLine("Wczytano z pliku "+listimie.Count);
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
