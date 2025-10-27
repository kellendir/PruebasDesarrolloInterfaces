namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] semana = new double[6];
            string[] DIAS = { "MARTES", "MIERCOLES", "JUEVES", "VIERNES", "SABADO", "DOMINGO" };
            bool maxEmpate = false, minEmpate = false;
            double maxValue = int.MinValue,minValue = int.MaxValue, average = 0;
            int maxDay = 0, minDay = 0;
            for(int i = 0; i < 6; i++)
            {
                double ventas = double.Parse(Console.ReadLine());
                semana[i] = ventas; 
                average += ventas;

                if(ventas > maxValue)
                {
                    maxValue = ventas;
                    maxEmpate = false;
                    maxDay = i;
                }
                else if(ventas == maxValue)
                {
                    maxEmpate = true;
                }

                if(ventas < minValue)
                {
                    minValue = ventas;
                    minEmpate = false;
                    minDay = i;
                }
                else if (ventas == minValue)
                {
                    minEmpate = true;
                }
            }


            if (maxEmpate)
            {
                Console.Write("EMPATE");
            }
            else Console.Write(DIAS[maxDay]);

            Console.Write(' ');

            if (minEmpate)
            {
                Console.Write("EMPATE");
            }
            else Console.Write(DIAS[minDay]);

            Console.Write(' ');

            if (average / 6 > semana[5]) Console.WriteLine("NO");
            else Console.WriteLine("SI");

        }
    }
}
