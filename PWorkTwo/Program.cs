using System;
namespace ConsoleApp3
{
    static class Program_1// в моей программе выход из программы не предусматривает какого либо кода относящегося к выходу.
    {                      // пользователю достаточно ввести число 4. а так как программа ничего не найдет привязанного к 4, то она закончится.
        public static int prog_method_1(int choice)
        {
            Console.WriteLine("Введите число от 1 до 100");
            string b = Console.ReadLine();
            int inputb = Convert.ToInt32(b);
            Random rnd = new Random();
            int randm = rnd.Next(1, 100);
            if (inputb > randm)
            Console.WriteLine("Вашим числом было. Попробуйте еще раз "+randm);
            while (inputb != randm)
            {
                prog_method_1(choice);
            }
            if (inputb == randm)
            {
                Console.WriteLine("Вы угадали число");
                choice_prog(choice);
            }
            return choice;
        }
        public static int prog_method_2(int choice)
            {
                int numb_on_eage;
                int multiplication;
                for (numb_on_eage = 1; numb_on_eage <= 9; numb_on_eage++)
                {
                    Console.WriteLine("\t");
                    for (multiplication = 1; multiplication <= 9; multiplication++)
                    {
                        Console.Write("\t" + numb_on_eage * multiplication ) ; // \ табуляция = большой отступ. В данном случае зацикленный
                    }
                }
                Console.WriteLine("\n");
                choice_prog(choice);
                return choice;
            }
            public static int prog_method_3(int choice)
            {
                int result_,x;
                Console.WriteLine("Введиет число");
                x = int.Parse(Console.ReadLine());
                if ((x % 2) == 0)
                {
                    for (int idu = 1; idu <= x; idu++)
                    {
                        if (x % idu == 0)
                        {
                            Console.Write(" " + idu);

                        }
                    }
                }
                else
                {
                    if (x % 11 == 0)
                    { Console.WriteLine("1 11 " + x);
                    }
                    else
                    {
                        Console.WriteLine("1 "+ x);
                    }
                }
                choice_prog(choice);
                return choice;
            }
            public static int choice_prog(int choice2)
            {
                Console.WriteLine("Выберите одну из программ: \n 1.Игра Угадай число\n 2.Таблица умножения\n 3.Вывод делителей числа\n 4.Выход из программы");
                int choice = int.Parse(Console.ReadLine());
                int result_ = 0;
                switch (choice)
                {
                    case 1:
                        result_ = Program_1.prog_method_1(choice);
                        break;
                    case 2:
                        result_ = Program_1.prog_method_2(choice);
                        break;
                    case 3:
                        result_ = Program_1.prog_method_3(choice);
                        break;
                }
                return choice;
            }
            class Program
        {
            static void Main(string[] args)
            {
                int choice = 0;
                choice_prog(choice);
            }
        }
    }
}