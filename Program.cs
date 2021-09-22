using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace HomeWork_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region targil1
            Console.WriteLine("Targil 1");

            Regex r1 = new Regex(@"^[D]");
            string word = "Dany";//true
            string word2 = "Meir";//false
            var match = r1.IsMatch(word);
            var match2 = r1.IsMatch(word2);
            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match2} \n");

            #endregion


            #region targil2
            Console.WriteLine("Targil 2");
            Regex r2 = new Regex(@"^[DFJ]");
            word = "Dudu";//true
            word2 = "Sara";//false
            string word3 = "Jedadia";//true
            match = r2.IsMatch(word);
            match2 = r2.IsMatch(word2);
            var match3 = r2.IsMatch(word3);

            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match2} ");
            Console.WriteLine($"{word3} is : {match3}\n ");



            #endregion

            #region Targil3
            Console.WriteLine("Targil 3");
            Regex r3 = new Regex(@"^[DFJ]\d{6}\w[A-Z]{2}");
            word = "F123456_AC";//true
            word2 = "J123457_A";//false
            word3 = "D123456-AZ";//false
            match = r3.IsMatch(word);
            match2 = r3.IsMatch(word2);
            match3 = r3.IsMatch(word3);
            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match2} ");
            Console.WriteLine($"{word3} is : {match3}\n ");

            #endregion

            #region Targil4
            Console.WriteLine("Targil4\n");
            string repleceWord = "Whyyy";
            Console.WriteLine("the first word is :"+ repleceWord);
            string result = Regex.Replace(repleceWord, "(y{3}| ז{4})", "  ");
            Console.WriteLine("after the replece :"+result+"\n");


            #endregion

            #region Targil5
            Console.WriteLine("Targil5");
            Regex r5 = new Regex(@"^[A-Z]");
            word = "dany";//false
            word2 = "Yakir";//true
            word3 = "eFRAIME";//false
            match = r5.IsMatch(word);
            match2 = r5.IsMatch(word2);
            match3 = r5.IsMatch(word3);
            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match2} ");
            Console.WriteLine($"{word3} is : {match3}\n ");
            #endregion

            #region Targil6
            Console.WriteLine("Targil6");
            Regex r6 = new Regex(@"(abc|ABC)");
            word = "blablabc";//true
            word2 = "ABCasd";//true
            word3 = "avbvcgf";//false
            match = r6.IsMatch(word);
            match2 = r6.IsMatch(word2);
            match3 = r6.IsMatch(word3);
            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match2} ");
            Console.WriteLine($"{word3} is : {match3}\n ");

            #endregion

            #region Targil7
            Console.WriteLine("Targil7");
            Regex r7 = new Regex(@"[a-zA-Z]{2}[\s][a-zA-Z]{2}");
            word = "yakir gigi";//true
            word2 = "Moshe C";//false
            word3 = "Efraim Teicher";//true
            match = r7.IsMatch(word);
            match2 = r7.IsMatch(word2);
            match3 = r7.IsMatch(word3);
            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match2} ");
            Console.WriteLine($"{word3} is : {match3}\n ");

            #endregion

            #region Targil8
            Console.WriteLine("Targil8");
            Regex r8 = new Regex(@"^[0-9]{1,}\.{1}[0-9]{1,}$");
            word = "33";//true
            word2 = "13.123";//false
   
            match = r8.IsMatch(word);
            match = r8.IsMatch(word2);
            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match} ");


            #endregion


            #region Targil9
            Console.WriteLine( "Targil 9");
            Regex r9 = new Regex(@"^[0-9]{1,}\.{1}[0-9]{3}$");
            word = "33";
            word2 = "33.23";
            word3 = "13.123";

            match = r9.IsMatch(word);
            match = r9.IsMatch(word2);
            match = r9.IsMatch(word3);

            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match} ");
            Console.WriteLine($"{word3} is : {match} ");

            #endregion

            #region Targil10
            Console.WriteLine("Targil10");
            Regex r10 = new Regex(@"^[a-zA-Z0-9]{2,15}\@(gmail|GMAIL|yahoo|YAHOO)\.\D{3,}$");
            word = "Yakir@gmail.com";
            word2 = "Momo@GMAilcom";
            word3 = "Meir@gmailcoil";

            match = r10.IsMatch(word);
            match = r10.IsMatch(word2);
            match = r10.IsMatch(word3);

            Console.WriteLine($"{word} is : {match} ");
            Console.WriteLine($"{word2} is : {match} ");
            Console.WriteLine($"{word3} is : {match} ");


            #endregion




        }
    }
}
