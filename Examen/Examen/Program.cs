namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Pelicula> ListaPeliculas = new List<Pelicula>();
                bool Explotar = true;
                while (Explotar)
                {
                    Console.Clear();
                    Console.WriteLine("Peliculas");
                    Console.WriteLine("1-agregar pelicula\n2-Ver lista\n3-Editar\n4-Borrar");
                    Console.WriteLine("");
                    Console.WriteLine("0-Salir");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre de la pelicula");
                            string Titulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el Genero de la pelicula");
                            string Genero = Console.ReadLine();
                            Console.WriteLine("Ingrese el año de la pelicula");
                            int Año = int.Parse(Console.ReadLine());
                            Pelicula Peli = new Pelicula(Titulo, Genero, Año);
                            ListaPeliculas.Add(Peli);
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Aqui esta tu lista de peliculas");
                            Console.WriteLine("ID        Nombre           Genero              Año");
                            Console.WriteLine("-----------------------------------------------------");
                            for (int i = 0; ListaPeliculas.Count > i; i++)
                            {
                                Console.WriteLine($"{i + 1}        {ListaPeliculas[i].Titulo}           {ListaPeliculas[i].Genero}              {ListaPeliculas[i].Año}");
                            }
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("Enter para salir");
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------");
                            for (int i = 0; ListaPeliculas.Count > i; i++)
                            {
                                Console.WriteLine($"{i + 1}        {ListaPeliculas[i].Titulo}           {ListaPeliculas[i].Genero}              {ListaPeliculas[i].Año}");
                            }
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("Digite el ID que desea Editar");
                            int Editar = int.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese el nuevo titulo de la pelicula");
                            string NewTitulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo genero de la pelicula");
                            string NewGenero = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo Año de la pelicula");
                            int NewAño = int.Parse(Console.ReadLine());
                            ListaPeliculas[Editar - 1] = new Pelicula(NewTitulo, NewGenero, NewAño);
                            Console.WriteLine("La pelicula fue editada Correctamente\nPresionar enter para salir");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-----------------------------------------------------");
                            for (int i = 0; ListaPeliculas.Count > i; i++)
                            {
                                Console.WriteLine($"{i + 1}        {ListaPeliculas[i].Titulo}           {ListaPeliculas[i].Genero}              {ListaPeliculas[i].Año}");
                            }
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("Digite el ID que desea Borrar");
                            int Borrar = int.Parse(Console.ReadLine());
                            Console.WriteLine("Esta Seguro que desea eliminar de la existencia esta pelicula (S/N)");
                            string confirmar = Console.ReadLine();
                            if (confirmar == "S")
                            {
                                ListaPeliculas.RemoveAt(Borrar - 1);
                                Console.WriteLine("Usted acaba de borar de la existencia la pelicula exitosamente");
                                Console.WriteLine("Presione ENTER para salir");
                                Console.ReadLine();
                                break;
                            }
                            else
                                Console.WriteLine("Le perdonaste la existencia a esta pelicula\nEnter para salir");
                            Console.ReadLine();
                            break;
                        case 0:
                            Explotar = false;
                            Console.Clear();
                            Console.WriteLine("Adios Gracias por Usar Peliculas");
                            break;
                        default:
                            Console.WriteLine("Hubo un error\nEnter para salir");
                            Console.ReadLine();
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Hiciste que el codigo tuviera un error");
            }
        }
    }
}
