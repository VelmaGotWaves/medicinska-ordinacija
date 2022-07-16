using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PrenosDoktora
    {
        //prenos pacienta :(((((
        private static string ime;
        private static string prezime;
        private static string pol;
        private static DateTime datRodjenja;
        private static string adresa;
        private static DateTime datTermina;
        private static string problem;
        

        public static string Ime { get => ime; set => ime = value; }
        public static string Prezime { get => prezime; set => prezime = value; }
        public static string Pol { get => pol; set => pol = value; }
       
        public static string Adresa { get => adresa; set => adresa = value; }
        
        public static string Problem { get => problem; set => problem = value; }
        public static DateTime DatRodjenja { get => datRodjenja; set => datRodjenja = value; }
        public static DateTime DatTermina { get => datTermina; set => datTermina = value; }
    }
}
