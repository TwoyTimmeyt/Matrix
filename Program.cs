using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Матрица
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание генератора случ. чисел
            Random rand = new Random();

            //Задание множителя, кол-ва столбцов, строк
            Console.WriteLine("Введите число на которое будет умножена матрица");
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во столбцов");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во строк");
            int lines = int.Parse(Console.ReadLine());

            //Задание матрицы из n строк и столбцов
            int[,] matrix = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.Next(10);
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Вывод матрицы умноженой на число
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = matrix[i, j] * multiplier;
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
