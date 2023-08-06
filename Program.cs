using System;

namespace DecoTablas
{
    enum Colores
    {
        Amarillo,
        Morado,
        Rosa,
        Azul,
        Blanco
    }

    class Program
    {
        static void Main(string[] args)
        {

            Colores inputColor = PideColor();

            ImprimirTablaConIf(inputColor);
            ImprimirTablaConSwitch(inputColor);

            Console.ReadLine();
        }

        static Colores PideColor()
        {
            Colores color;
            Console.WriteLine("Ingrese un color (Amarillo, Morado, Rosa, Azul o Blanco):");
            while (!Enum.TryParse(Console.ReadLine(), true, out color))
            {
                Console.WriteLine("Color no válido.\nIngrese un color (Amarillo, Morado, Rosa, Azul o Blanco)");
            }
            return color;
        }

        static void ImprimirTablaConIf(Colores inputColor)
        {
            int numeroTabla = ObtenerNumeroTablaIf(inputColor);
            Console.WriteLine("\nTabla del " + numeroTabla + ":");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numeroTabla * i;
                Console.WriteLine($"{numeroTabla} x {i} = {resultado}");
            }
        }

        static void ImprimirTablaConSwitch(Colores inputColor)
        {
            int numeroTabla = ObtenerNumeroTablaSwitch(inputColor);

            Console.WriteLine("\nTabla del " + numeroTabla + ":");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numeroTabla * i;
                Console.WriteLine($"{numeroTabla} x {i} = {resultado}");
            }
        }

        static int ObtenerNumeroTablaIf(Colores color)
        {
            if (color.Equals(Colores.Amarillo)) return 2;
            if (color.Equals(Colores.Morado)) return 7;
            if (color.Equals(Colores.Rosa)) return 9;
            if (color.Equals(Colores.Azul)) return 6;
            if (color.Equals(Colores.Blanco)) return 12;
            return -1;
        }

        static int ObtenerNumeroTablaSwitch(Colores color)
        {
            switch (color)
            {
                case Colores.Amarillo:
                    return 2;
                case Colores.Morado:
                    return 7;
                case Colores.Rosa:
                    return 9;
                case Colores.Azul:
                    return 6;
                case Colores.Blanco:
                    return 12;
                default:
                    return -1;
            }
        }
    }
}