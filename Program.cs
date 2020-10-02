using System;
using System.Threading;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            string str = "Hello World!";
            int time=0;
            bool answer = false;

            do
            {
                str = GetStr();
                time = GetTime();
                ShowStr(str, time);
                answer = GetAnswer();

            } while (answer);

            
        }

        static string GetStr()
        {
            string str=Console.ReadLine();
            return str;
        }
        static int GetTime()
        {
            string num_str;
            int num;
            do
            {
                num_str=Console.ReadLine();

            } while (!int.TryParse(num_str, out num));
            return num;
        }

        static bool GetAnswer()
        {
            bool answer=false;
            Console.WriteLine("Повторить?\nДа/Нет-Y/N:");
            string answer_str=Console.ReadLine();
            answer_str = answer_str.ToUpper();
            answer = answer_str.Contains('Y');
            return answer;
        }

        static void ShowStr(string str,int time)
        {


            Console.Clear();
            foreach (char letter in str)
            {
                Console.WriteLine(letter);
                Thread.Sleep(time);

            }
        }

        static void Repeat(bool answer)
        {
            
            string str = GetStr();
            int time = GetTime();
            ShowStr(str, time);
        }

    }
}
