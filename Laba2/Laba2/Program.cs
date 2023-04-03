using System;

namespace SS123
{
    class Program
    {
        static void Main(string[] args)
        {
            Note[] array = new Note[3];
            array[0] = new Note();
            array[1] = new Friend("Даниил", "Сергеев", "Валерьевич", "danya@gmail.com", "16.11.2002");
            array[2] = new Note("Даниил", "Сергеев", "Валерьевич");

            for (int i = 0; i < 3; i++)
            {
                array[i].ShowInfo();
            }


            Console.ReadLine();
        }
    }
}
