using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string DUrodzenia { get; set; }
        public int Pensja { get; set; }
        public string Stanowisko { get; set; }
        public string Umowa { get; set; }

        public Pracownik() { }
        public Pracownik(string imie, string nazwisko, string durodzenia, int pensja, string stanowisko, string umowa)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DUrodzenia = durodzenia;
            Pensja = pensja;
            Stanowisko = stanowisko;
            Umowa = umowa;
        }
        public override string ToString()
        {
            return $"{Nazwisko} {Imie}, {DUrodzenia}, {Stanowisko}, {Pensja} zł, {Umowa}";
        }
    }
}
