using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Home home2 = new Home();
            //home2.unvan = "H.Cavid pros";
            //home2.telefon = "244654564";
            //home2.seher = "Baki ";

            //Console.WriteLine(home2.melumatlar());

            //Console.WriteLine("*****************************************************************");
            //Console.WriteLine();


            //Home[] homes = new Home[3];
            //Console.WriteLine();
            //Home home1 = new Home();
            //home1.seher = "Baki ";



            //Home home2 = new Home();
            //home2.seher = "Bakii ";


            //Home home3 = new Home();
            //home3.seher = "BAKI";




            //homes[0] = home1;
            //homes[1] = home2;
            //homes[2] = home3;

            //for (int i = 0; i < homes.Length; i++)
            //{


            //    Console.WriteLine(homes[i].seher);

            //    Console.WriteLine($"**************");
            //}
            #endregion

            MyMath myMath = new MyMath();


            Console.WriteLine("Ededi daxil edin: ");

            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Quvveti daxil edin: ");

            decimal pow = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine(myMath.say(a,pow));


        }
    }
}
