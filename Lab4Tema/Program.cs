using System;

namespace Lab4Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            Ex2();
        }

        static void Ex1()
        {
            /* Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
            functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul */

            InverseazaVector(ReadVector());
        }
        static void Ex2()
        {
            /* Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m, k.
            Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
             * Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
                rezultatul.
             * Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
                rezultatul. */
            CalculeazaSuma(ReadMatrice());
            ElementMaxim(ReadMatrice());
        }
        static int[] ReadVector()
        {
            Console.WriteLine("Introduceti dimensiunea vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            return vector;
        }
        static int[] InverseazaVector(int[] vector)
        {
            int n = vector.Length;
            int aux;
            for (int i = 0; i < n / 2; i++)
            {
                aux = vector[i];
                vector[i] = vector[n - i - 1];
                vector[n - i - 1] = aux;
            }
            Console.WriteLine("Vectorul inversat este:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            return vector;
        }
        static int[,,] ReadMatrice()
        {
            Console.WriteLine("Introduceti dimensiunile matricii (n m k):");
            Console.WriteLine("Introduceti dimensiunea matricii n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunea matricii m");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti dimensiunea matricii k");
            int k = int.Parse(Console.ReadLine());

            int[,,] matrix = new int[n, m, k];

            Console.WriteLine("Introduceti elementele matricii:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        Console.Write("Enter element[{0},{1},{2}]: ", i, j, l);
                        matrix[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return matrix;
        }
        static int CalculeazaSuma(int[,,] matrice)
        {
            int suma = 0;
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        suma += matrice[i, j, l];
                    }
                }
            }
            return suma;
        }
        static int ElementMaxim(int[,,] matrice)
        {
            int max = int.MinValue;
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    for (int l = 0; l < matrice.GetLength(2); l++)
                    {
                        if (matrice[i, j, l] > max)
                        {
                            max = matrice[i, j, l];
                        }
                    }
                }
            }
            return max;
        }
    }
}
