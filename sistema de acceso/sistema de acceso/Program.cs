using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_acceso
{
    class Program
    {     
        static void Main(string[] args)
        {
            DateTime[] fechaDcreacion = new DateTime[3];
            string conver = "";

            string[] usuario = new string[3];
            int[] contraseña = new int[3];
            string[] nombre = new string[3];

            for (int i = 0; i <= 2 ; i++)
            {
                Console.Write("\nDigite su usuario: ");
                usuario[i] = (Console.ReadLine());
                conver = Convert.ToString(usuario[i]);

                if (conver.Length != 11)
                {
                    do
                    {
                        Console.WriteLine("El valor o caracter ingresado no es valido");
                        Console.Write("Digite su usuario: ");
                        conver = Console.ReadLine();
                    } 
                    while (conver.Length != 11);
                }

                Console.Write("Digite la contraseña: ");
                contraseña[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite el nombre del usuario: ");
                nombre[i] = Console.ReadLine();

                fechaDcreacion[i] = DateTime.Now;
                Console.WriteLine("Creado el " + fechaDcreacion[i]);

                Console.WriteLine("\nSe ha registrado!");
            }

            Console.WriteLine("\n.............INICIO DE SESION.............");

            string usuario2;
            int contraseña2;
            int usu = 0;

            do 
            {
   
            Console.Write("\nDigite el usuario: ");
            usuario2 = (Console.ReadLine());

            Console.Write("Digite la contraseña: ");
            contraseña2 = Convert.ToInt32(Console.ReadLine());

            if (usuario[0] == usuario2 && contraseña[0] == contraseña2)
            {
                usu = 0;
            }
            else if (usuario[1] == usuario2 && contraseña[1] == contraseña2)
            {
                usu = 1;
            }
            else if (usuario[2] == usuario2 && contraseña[2] == contraseña2)
            {
                usu = 2;
            }
            else

            {
                Console.WriteLine("Los datos no concuerdan, intentelo denuevo");
            }

            } while (usuario[usu] != usuario2 && contraseña[usu] != contraseña2);

            Random rol = new Random();
            int user = rol.Next(1,3);
            string rol1 = ""; 

            if (user == 1)
            {
                rol1 = "Administrador";
            }
            else if (user == 2)
            {
                rol1 = "Vendedor";
            }
            else if (user == 3)
            {
                rol1 = "Supervisor";
            }

            Random estado = new Random();
            int AoI = estado.Next(1,2);
            string AoI1 = "";

            if (AoI == 1)
            {
                AoI1 = "Activo";
            }
            else if (AoI == 2)
            {
                AoI1 = "Inactivo";
            }

            Console.WriteLine("\nUsted ha iniciado sesion con el usuario " + usuario[usu] + " y su rol es " + rol1);

            if (AoI1 == "Inactivo")
            {
                do
                {

                    Console.Write("\nDigite el usuario: ");
                    usuario2 = (Console.ReadLine());

                    Console.Write("Digite la contraseña: ");
                    contraseña2 = Convert.ToInt32(Console.ReadLine());

                    if (usuario[0] == usuario2 && contraseña[0] == contraseña2)
                    {
                        usu = 0;
                    }
                    else if (usuario[1] == usuario2 && contraseña[1] == contraseña2)
                    {
                        usu = 1;
                    }
                    else if (usuario[2] == usuario2 && contraseña[2] == contraseña2)
                    {
                        usu = 2;
                    }
                    else
                    {
                        Console.WriteLine("Los datos no concuerdan, intentelo denuevo");
                    }

                } while (usuario[usu] != usuario2 && contraseña[usu] != contraseña2);

                 rol = new Random();
                 user = rol.Next(1, 3);
                 rol1 = "";

                if (user == 1)
                {
                    rol1 = "Administrador";
                }
                else if (user == 2)
                {
                    rol1 = "Vendedor";
                }
                else if (user == 3)
                {
                    rol1 = "Supervisor";
                }

                estado = new Random();
                AoI = estado.Next(1, 2);
                AoI1 = "";

                if (AoI == 1)
                {
                    AoI1 = "Activo";
                }
                else if (AoI == 2)
                {
                    AoI1 = "Inactivo";
                }

                Console.WriteLine("\nUsted ha iniciado sesion con el usuario " + usuario[usu] + " y su rol es " + rol1);
            }

            Console.ReadKey();
        }
    }
}
