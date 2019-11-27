using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {

            Console.WriteLine("5x^2+3x+1");//問題
            Console.WriteLine("(a^x+b)^x+cの場合のXを入力");//問題
            int X = int.Parse(Console.ReadLine());//intに変換して入力

            Console.WriteLine("(a^x+b)^x+cの場合のaを入力");//問題
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("(a^x+b)^x+cの場合のbを入力");//問題
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("(a^x+b)^x+cの場合のcを入力");//問題
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine(TEST(X, a, b, c));//関数呼び出しと表示

        }
        static int TEST(int X, int a, int b, int c)
        {
            int AN;//答え保存
            var NN = Math.Pow(X, 2);
            var N = Convert.ToInt32(NN);
            AN = X * (a * X + b) + c;//計算式

            return AN;
        }

        static int TEST2(int X, int a, int b, int c)
        {
            int AN;//答え保存
            var NN = Math.Pow(X, 2);
            var N = Convert.ToInt32(NN);
            AN = X * (a * X + b) + c;//計算式

            return AN;
        }
    }
}
