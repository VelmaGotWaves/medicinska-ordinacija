using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Prenos
    {
        private static string pacientDoktor;
        private static string doktorSamo;

        public static string PacientDoktor { get => pacientDoktor; set => pacientDoktor = value; }
        public static string DoktorSamo { get => doktorSamo; set => doktorSamo = value; }
    }
}
