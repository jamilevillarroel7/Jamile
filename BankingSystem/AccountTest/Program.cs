using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingModel;

namespace AccountTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account cuentaJ = new Account();
            cuentaJ.Nombre = "Jamile";
            cuentaJ.Edad = 20;
            cuentaJ.Numero = 984773868;
            cuentaJ.Correo = "jamilevillarroel7@gmail.com";

            Console.WriteLine("El nombre de la persona es:{0}" +
                              "Su edad es: {1} " +
                              "Su numero de celular es: {2} " +
                              "Su correo es: {3}", cuentaJ.Nombre,cuentaJ.Edad,cuentaJ.Numero,cuentaJ.Correo);



            

        }
    }
}
