using System;

namespace HomeWork_Abstract
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Figure [] array = new Figure [4];

            array[0] = new Parallelepiped(2, 3, 4);
            array[1] = new Pyramid(8, 6, 4);
            array[2] = new Tetrahedron(6);
            array[3] = new Ball(9);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is Figure)
                {
                    Console.WriteLine($"Все верно. Класс {array[i].GetType()} унаследован от базового абстрактного класса Figure");
                    Console.WriteLine($"Объем данной фигуры  равeн {String.Format("{0:f2}",array[i].Volume())}\n"); 
                }
                else
                    Console.WriteLine("Неверно");
            }

            Console.ReadLine();

        }
    }
}
