using System;

namespace Matrices
{
    class PruebaMatriz
    {
      
        private int[,] MatrizA;
        //Matriz A
        //1 5 
        //2 3
        //7 4 (3 x 2)
        private int[,] MatrizB;
        //Matriz B
        //6 7 8 9 
        //1 4 3 7 (2 x 4)

        private int[,] MatrizC;
        //matriz c 
        //1*6+5*1=11 1*7+5*4=27 1*8+5*3=23  1*9+5*7=44
        //2*5+3*1=15 2*7+3*4=26 2*8+3*3=25 2*9+3*7=39   
        //7*6+4*1=46 7*7+4*4=65 7*8+4*3=68  7*9+4*7=91
        public void Cargar()
        {
            MatrizA = new int[10, 10];
            MatrizB = new int[10, 10];
            MatrizC = new int[10, 10];
            //matriz a 3x2
            Console.WriteLine("Ingresando datos al matriz A");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizA[i, j] = int.Parse(linea);
                }
            }
            Console.WriteLine("Ingresando datos al matriz B");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizB[i, j] = int.Parse(linea);
                }
            } 
        
            //Sumamos la matrizA y la MatrizB
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] * MatrizB[i, j];
                }
            }
        }
        // visualizamos la suma de las matrices
        public void visualizar()
        {
            Console.WriteLine("La suma de la MatrizA y MatrizB es :");
            Console.WriteLine("La matriz C es igual a: ");

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(MatrizC[i, j] + "  ");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaMatriz pv = new PruebaMatriz();
            pv.Cargar();
            pv.visualizar();
       
        }
       
    }
}