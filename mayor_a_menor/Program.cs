using System.Numerics;
using System.Linq;

class program
{
    static void Main(String[] args)
    {
        String f1;
        String c1;
        int f;
        int c;
        int p =0;
        int x;
        Console.WriteLine("Ingrese de cuanto quiere el vector");
        f1 = Console.ReadLine();
        f = Convert.ToInt32(f1);
        int[] vector = new int[f];
        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine("ingrese el numero para el vector #"+ i);
            c1 = Console.ReadLine();
            c = Convert.ToInt32(c1);
            vector[i] = c;
        }
        Console.WriteLine("vector en desorden");
        for(int i = 0; i < vector.Length; i++)
        {
            
            Console.WriteLine(vector[i]);
        }
        Array.Sort(vector);
        Array.Reverse(vector);
        Console.WriteLine("vector en orden");
        foreach(int i in vector)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i < vector.Length; i++)
        {
            x = vector[i];
            if ((x % 2) == 0)
            {
                p++;
            }
        }
        Console.WriteLine("Total numeros pares: " + p);
    }
}