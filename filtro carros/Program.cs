using System.Linq;

namespace filtro_carros
{

    class program
    {
        static void Main(String[] args)
        {
            controlventas cv = new controlventas();
            cv.getautos();
        }
    }

    class controlventas
    {
        DateTime fecha = DateTime.Now;
        DateTime resta = DateTime.Now;
        
        public controlventas()
        {
            listacarros = new List<carro>();
            listacarros.Add(new carro { id = 1, car = "mustang", model = 2018,color ="red", brand="ford"});
            listacarros.Add(new carro { id = 2, car = "ram", model = 2015, color = "black", brand = "ford" });
            listacarros.Add(new carro { id = 3, car = "hurricane", model = 2022, color = "white", brand = "lamborgini" });
        }
        public void getautos()
        {
            IEnumerable<carro> modelo = from carro in listacarros where carro.model >= 2017 && carro.model <= 2022 select carro;

            foreach(carro car1 in modelo)
            {
                car1.getdatoscar();
            }
        }

        public List<carro> listacarros;
    }

    class carro
    {
        public int id { get; set; }
        public string car { get; set; }
        public string brand { get; set; }
        public int model { get; set; }
        public string color { get; set; }

        public void getdatoscar()
        {
            Console.WriteLine("el carro {0} modelo {1} de color {2} de la marca {3} ",car,model,color,brand);
        }


    }
}