using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI1
{
    class Program
    {
        static void Main(string[] args)
        {
            String usu;
            int con;
            Console.WriteLine("-------------");
            Console.WriteLine("LOGIN");
            Console.WriteLine("-------------");
            Console.WriteLine("Escribe tu ususario ");
            usu = Console.ReadLine();
            Console.WriteLine("Escribe tu contraseña");
            int.TryParse(Console.ReadLine(), out con);
            if ((usu == "admin") && (con == 1234))
            {
                int opciones;
                do
                {
                    Console.Clear();
                    Console.WriteLine("MENU\n 1. sumar \n 2. restar \n 3. multiplicar \n 4. dividir");
                    opciones = int.Parse(Console.ReadLine());

                    switch (opciones)
                    {
                        case 1:
                            Console.WriteLine("Escribe primer numero");
                            double primero = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe segundo numero");
                            double segundo = Double.Parse(Console.ReadLine());
                            Class1 on = new Class1(primero, segundo);
                            Console.WriteLine("Tu resultado es : " + on.sumar().ToString());
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Escribe primer numero");
                            primero = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe segundo numero");
                            segundo = Double.Parse(Console.ReadLine());
                            on = new Class1(primero, segundo);
                            Console.WriteLine("Tu resultado es : " + on.restar().ToString());
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Escribe primer numero");
                            primero = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe segundo numero");
                            segundo = Double.Parse(Console.ReadLine());
                            on = new Class1(primero, segundo);
                            Console.WriteLine("Tu resultado es : " + on.multiplicar().ToString());
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Escribe primer numero");
                            primero = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Escribe segundo numero");
                            segundo = Double.Parse(Console.ReadLine());
                            on = new Class1(primero, segundo);
                            Console.WriteLine("Tu resultado es : " + on.dividir().ToString());
                            Console.ReadLine();
                            break;


                    }

                } while (opciones <= 4);
                /*int menu;
                do { 
                 
                Console.WriteLine("Inicio sesion");
                Console.WriteLine("MENU DE JUEGOS");
                Console.WriteLine("1. League of Legend");
                Console.WriteLine("2. Rocket League");
                Console.WriteLine("3. Lost ark");
                int.TryParse(Console.ReadLine(), out menu);
                switch (menu)
                {
                    case 1:

                        int lol;
                        Console.WriteLine("League of Legend");
                        Console.WriteLine("1. Genero");
                        Console.WriteLine("2. Plataformas disponible");
                        Console.WriteLine("3. Requisitos minimo en pc");
                        int.TryParse(Console.ReadLine(), out lol);
                        switch (lol)
                        {
                            case 1:
                                Console.WriteLine("un videojuego del género multijugador de arena de batalla en línea (MOBA) y deporte electrónico el cual fue desarrollado por Riot Games para Microsoft Windows y OS X y para consolas digitales");
                                Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("PLATAFORMAS DISPONIBLES");
                                Console.WriteLine("1. Microsoft Windows \n 2.mas OS X");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Procesador: de 3 GHz (compatible con conjunto de instrucciones SSE2 o superior).");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 2:

                        int rl;
                        Console.WriteLine("Rocket League");
                        Console.WriteLine("1. genero \n 2. Plataformas Disponible \n 3. Requisitos minimos pc");
                        int.TryParse(Console.ReadLine(), out rl);
                        switch (rl)
                        {
                            case 1:
                                Console.WriteLine(" un videojuego que combina el fútbol con los vehículos. Fue desarrollado por Psyonix y lanzado el 7 de julio de 2015.");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("1. PlayStation \n 2. Xbox One \n 3. Nintendo Switch \n 4. Microsoft windows");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Procesador mínimo requerido	2.5 GHz Dual core");
                                Console.ReadLine();
                                break;
                        }
                        break;

                    case 3:

                        int ld;
                        Console.WriteLine("Lost ark");
                        Console.WriteLine("1. Genero \n 2. Plataformas disponibles \n 3. Requisitos minimos pc");
                        int.TryParse(Console.ReadLine(), out ld);
                        switch (ld)
                        {
                            case 1:
                                Console.WriteLine("un videojuego de rol multijugador 3D con perspectiva clásica al estilo de Diablo");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("1. Microsoft Winodws \n 2. mac OS");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Procesador: Intel i3 o AMD Ryzen 3");
                                break;
                        }

                        break;

                }
            } while (menu <= 3) ;
                */
            }else
            {
                Console.WriteLine("No puede acceder a su login");
            }
        }
    }
}
