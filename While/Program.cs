﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña1, contraseña2 = "";

            Console.WriteLine("Escribe tu contraseña: ");
            contraseña1 = Console.ReadLine();

            while(contraseña1 != contraseña2)
            {
                Console.WriteLine("Confirma tu contraseña: ");
                contraseña2 = Console.ReadLine();
            }

            Console.WriteLine("¡La contraseña ha sido guardada!");
            Console.ReadKey();
        }
    }
}
