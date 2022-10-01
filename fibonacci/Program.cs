class program
{
    static void Main(string[] args)
    {
        int cont = 0;
        int acu = 1;
        bool veri = false;
        String num1;
        int suma;

        Console.WriteLine("ingrese un numero");
        num1 = Console.ReadLine();
        int num = Convert.ToInt32(num1);

        while(cont <= num)
        {
            if(cont == num)
            {
                veri = true;
            }
            suma = cont + acu;
            cont = acu;
            acu = suma;
        }
        if (veri)
        {
            Console.WriteLine("el numero pertenece a la serie fibonacci");
        }
        else
        {
            Console.WriteLine("el numero no pertenece a la serie fibonacci");
        }
    }
}