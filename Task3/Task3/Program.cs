using System;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexForArray1;
            int indexForArray2;

            int scalarForArray1;
            int scalarForArray2;

            Array array1 = ReadFromFile("Array1.txt", out indexForArray1, out scalarForArray1);
            Array array2 = ReadFromFile("Array2.txt", out indexForArray2, out scalarForArray2);

            Console.WriteLine("The first array: ");
            array1.DisplayArray();

            Console.WriteLine("\nThe second array: ");
            array2.DisplayArray();

            Console.WriteLine("\nAdding arrays: ");
            try
            {
                (array1 + array2).DisplayArray();
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nSubtraction of vectors: ");
            try
            {
                (array2 - array1).DisplayArray();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nMultiplying the first array on the scalar({0}): ",scalarForArray1);
            (array1 * scalarForArray1).DisplayArray();

            Console.WriteLine("\nMultiplying the second array on the scalar({0}): ", scalarForArray2);
            (array2 * scalarForArray2).DisplayArray();

            Console.WriteLine("\nAccess to the first array element by index ({0}): ", indexForArray1);
            try
            {
                Console.Write("array[" + (indexForArray1) + "] =" + array1[indexForArray1 - 1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nAccess to the second array element by index ({0}): ", indexForArray2);
            try
            {
                
                Console.Write("array[" + (indexForArray2) + "] =" + array2[indexForArray2 - 1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static Array ReadFromFile(string path, out int index, out int scalar)
        {
            using (StreamReader sr = new StreamReader(path)) 
            {
                int size = int.Parse(sr.ReadLine());

                Array array = new Array(size);

                string[] text = sr.ReadLine().Split(' ');

                for(int i=0;i<text.Length;i++)
                {
                    array[i] = int.Parse(text[i]);
                }

                index = int.Parse(sr.ReadLine());
                scalar = int.Parse(sr.ReadLine());

                return array;
            }
        }
    }
}
