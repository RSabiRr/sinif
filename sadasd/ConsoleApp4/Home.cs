using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Home
    {
        public int otaqSayi;
        public int mertebeSayi;
        public string unvan;
        public string telefon;
        public string seher;



        //public Home(string unvan, string telefon, string seher)
        //{
        //    this.unvan = unvan;
        //    this.telefon = telefon;
        //    this.seher = seher;
        //    //Console.WriteLine($"Unvan: {unvan} , Telefon: {telefon} , Seher : {seher}   ");

        //}

        public string melumatlar()
        {
            return $"Seherler: {seher}";
        }






    }
}
