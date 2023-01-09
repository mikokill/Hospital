using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Hospital
{
    
    class Data
    {
        public List<string> Imie { get; set; }
        public List<string> Nazwisko { get; set; }
        public List<string> Pesel { get; set; }
        public List<string> Typ { get; set; }
        public List<string> Login { get; set; }
        public List<byte[]> Haslo { get; set; }
        public List<string> Specjalizacja { get; set; }
        public List<string> Nrpwz { get; set; }
    }
}
