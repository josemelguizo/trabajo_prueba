using System.Net.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Api_rick_and_morty
{
    class program
{
    public static void Main(string[] args)
    {
        getcaracter();
        Console.ReadLine();
        Console.ReadKey();


    }
    public static async void getcaracter()
    {
        string baseUrl = "https://rickandmortyapi.com/api/character";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                {
                    using (HttpContent content = res.Content)
                    {
                        var data = await content.ReadAsStringAsync();
                        if (content != null)
                        {
                            Console.WriteLine("data-------------{0}", JObject.Parse(data)["results"]);
                        }
                        else
                        {
                            Console.WriteLine("no hay datos");
                        }
                    }
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("excepcion-------");
            Console.WriteLine(exception);
        }
    }
    
}
}