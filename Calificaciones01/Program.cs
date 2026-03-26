namespace Calificaciones01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REPORTE DE CALIFICACIONES");
            Console.WriteLine();

            //Declaración de una lista
            List<double> calificaciones = new List<double>();

            //Agregar los elementos a la lista
            calificaciones.Add(75);
            calificaciones.Add(69);
            calificaciones.Add(88);
            calificaciones.Add(71);

            foreach (double value in calificaciones) 
            {
                Console.WriteLine($"Calificación {value}");
            }
            double promedio= calificaciones.Average();
            Console.WriteLine();

            string mensaje = "El promedio es: ";
            Console.WriteLine(mensaje + promedio);
        }
    }
}
