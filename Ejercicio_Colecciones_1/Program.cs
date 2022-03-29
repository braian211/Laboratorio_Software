using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_Colecciones
{
	class Program
	{
		static void Main(string[] args)
		{

            Dictionary<string, string> values = new Dictionary<string, string>();

            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            if (values.ContainsKey("Juan"))
            {
                Console.WriteLine(values["Juan"]);
            }

            string valor = "654648564";
            if (values.TryGetValue("Pedro", out valor))
            {
                Console.WriteLine(values["Pedro"]);
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            foreach (KeyValuePair<string, string> value in values)
            {
                Console.WriteLine(value.Key + ", " + value.Value);
            }


            values["Mariana"] = "58251425";
            Console.WriteLine("Nuevo teléfono de Mariana: " + values["Mariana"]);
            Console.ReadKey();

        }
	}
}
