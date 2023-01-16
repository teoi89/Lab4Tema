using System;

namespace Lab4Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            Ex5();
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
            CalculeazaSuma(ReadMatriceWithThreeDimensions());
            ElementMaxim(ReadMatriceWithThreeDimensions());
        }
        static void Ex3()
        {
            /* Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
            m, respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
            tastaura.Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
            rezultatul. */
            ReadMatriceWithTwoDimensions();
        }
        static void Ex5()
        {
            /*Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
            apelati-o si afisati-i rezultatul.  */
            Console.WriteLine(ReturnSum(ReadNumber()));
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
        static int[,,] ReadMatriceWithThreeDimensions()
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
            Console.WriteLine("Suma elementelor matricii este: " + suma);
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
            Console.WriteLine("Elementul maxim al matricii este: " + max);
            return max;
        }
        static int[,] ReadMatriceWithTwoDimensions()
        {
            Console.WriteLine("Enter the dimensions of the first array (n m):");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] array1 = new int[n, m];

            Console.WriteLine("Enter the elements of the first array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the dimensions of the second array (m n):");
            int m2 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int[,] array2 = new int[m2, n2];

            Console.WriteLine("Enter the elements of the second array:");
            for (int i = 0; i < m2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return CalculateProduct(array1, array2);
        }
        static int[,] CalculateProduct(int[,] array1, int[,] array2)
        {
            int n = array1.GetLength(0);
            int m = array1.GetLength(1);
            int n2 = array2.GetLength(1);
            int[,] product = new int[n, n2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        sum += array1[i, k] * array2[k, j];
                    }
                    product[i, j] = sum;
                }
            }
            Console.WriteLine("The product of the two arrays is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write(product[i, j] + " ");
                }
                Console.WriteLine();
            }
            return product;
        }
        static int ReadNumber() 
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        static int ReturnSum(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + ReturnSum(n - 1);

        }
    }
}
