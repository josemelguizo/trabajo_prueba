using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_rick_and_morty
{
    public class caracter
    {
        public caracter(string name, string url)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
