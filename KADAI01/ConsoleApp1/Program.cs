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
            int X = int.Parse(Console.ReadLine());//intに変換して入力
            Console.WriteLine(TEST(X));//関数呼び出しと表示

        }
        static int TEST(int XX)
        {
            int AN;//答え保存
            var NN = Math.Pow(XX, 2);
            var N = Convert.ToInt32(NN);
            AN = 5 * (N) + (3 * XX) + 1;//計算式

            return AN;
        }
    }
}
