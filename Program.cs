using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cnpersona
{
    internal class ClsProgram
    {

        /// <summary>
        /// 21/02/2023
        /// jaider Andres Oquendo Zapata
        /// Programa que pide el nombre de una persona y evalua que sea mayor de edad.
        /// para continuar pidiendo demás datos personales.
        /// </summary>
        /// <param name="args"></param>f
        static void Main(string[] args)
        {
                Console.WriteLine( "Bienvenido" );
                Console.WriteLine("Por favor ingrese su nombre ");
                string Nombre = (Console.ReadLine());
                Console.WriteLine( Nombre + " Por favor ingrese su edad");
                int Edad= Convert.ToInt16( Console.ReadLine());
           

            //estructura de desicion logica para saber si es mayor de edad y continuar con el metodo.
            if (Edad >=18)
             {

                Console.WriteLine(DatosPersonales(Nombre, Edad));

             }
            else
            {
             Console.WriteLine(Nombre + " su edad no es acta para continuar pidiendo los demas datos personales, que tenga un buen dia. ");
            }
                

                Console.ReadKey();

        }

            //metodo
            static string DatosPersonales(string Nombre, int Edad)
            {
            Console.WriteLine("Por favor ingrese su apellido ");
            string Apellido = (Console.ReadLine());
            Console.WriteLine("Por favor ingrese su correo electronico");
            string Correo = (Console.ReadLine());
            string cofirmacion =("la persona con nombre: " + Nombre +" " + Apellido + " con edad de : " + Edad + " años, y correo electronico: " + Correo + " ha sido registrada.");
            return cofirmacion;
            }
            

            
        
    }
}
