using System;
public class Hello
{
    public static void Main()
    {
        int[] vs = { };

        Console.WriteLine("Xの値を入力");
        int x = Console.Read();
        Console.WriteLine("Aの値を入力");
        int a = Console.Read();
        Console.WriteLine("Nの値を入力");
        int n = Console.Read();
        
        vs = new int[n];
        for(int i = 0; i < n; i++)
        {
            vs[i]=i;
        }

        Console.Write(Horner(x,n,a));
    }

    public  static double Horner(int x,int n,int a)
    {
        //int f = 0;


        int[] vs = new int[n+1];
        for (int i = 0; i < n; i++)
        {
            vs[i] = i;
        }

        double f = vs[n];
        for (int i = n - 1; i >= 0; i--)
        {
            f = f * x + vs[i];
        }
        return f;

        //      for (int i = n-1; i >= 0; i--)
        //f = f* x + vs[i];
        //      return f;
    }
}
