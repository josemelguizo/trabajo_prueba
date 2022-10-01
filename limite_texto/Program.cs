
class program
{
    static void Main(string[] args)
    {
        String texto;
        int conteo;
        string textos;

        Console.WriteLine("Introduzca el texto");
        texto = Console.ReadLine();
        conteo = texto.Length;
        textos = texto.Substring(0, 20);

        if(conteo > 20)
            Console.WriteLine(textos + "...");
        else
            Console.Write(textos);
        Console.ReadKey();

    }
}
