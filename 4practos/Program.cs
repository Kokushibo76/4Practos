namespace abc
{
    class program
    {
        static void Main()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Заметки на 11.10.2023");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine();
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("-> 1.Сходить в магазин");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("2.Приготовить булочку с маком");

                int position = 2;
                ConsoleKeyInfo key = Console.ReadKey();


                while ((key.Key != ConsoleKey.Enter) || (key.Key != ConsoleKey.LeftArrow) || (key.Key != ConsoleKey.RightArrow))
                {
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("   ");

                    if (key.Key == ConsoleKey.UpArrow && position != 2)
                    {
                        position--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && position != 3)
                    {
                        position++;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        Second();
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();
                        Third();
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        if (position == 2)
                        {
                            Console.Clear();
                            A();
                        }
                        else if (position == 3)
                        {
                            Console.Clear();
                            B();
                        }
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");

                    key = Console.ReadKey();
                }

                Console.SetCursorPosition(0, 4);

            }
            static void Second()
            {
                while (true)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Заметки на 12.10.2023");
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("-> 1.Поиграть в Bloodborne");
                    Console.SetCursorPosition(3, 3);
                    Console.WriteLine("2.Прогулка");

                    int position = 2;
                    ConsoleKeyInfo key = Console.ReadKey();


                    while ((key.Key != ConsoleKey.Enter) || (key.Key != ConsoleKey.LeftArrow) || (key.Key != ConsoleKey.RightArrow))
                    {
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("   ");

                        if (key.Key == ConsoleKey.UpArrow && position != 2)
                        {
                            position--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow && position != 3)
                        {
                            position++;
                        }
                        else if (key.Key == ConsoleKey.RightArrow)
                        {
                            Console.Clear();
                            Third();
                        }
                        else if (key.Key == ConsoleKey.LeftArrow)
                        {
                            Main();
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            if (position == 2)
                            {
                                Console.Clear();
                                C();
                            }
                            else if (position == 3)
                            {
                                Console.Clear();
                                D();
                            }
                        }
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");

                        key = Console.ReadKey();
                    }

                    Console.SetCursorPosition(0, 4);
                }
            }
            static void Third()
            {
                while (true)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Заметки на 13.10.2023");
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine();
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("-> 1.Сделать практическую работу на C#");
                    Console.SetCursorPosition(3, 3);
                    Console.WriteLine("2.Поспать");

                    int position = 2;
                    ConsoleKeyInfo key = Console.ReadKey();


                    while ((key.Key != ConsoleKey.Enter) || (key.Key != ConsoleKey.LeftArrow) || (key.Key != ConsoleKey.RightArrow))
                    {
                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("   ");

                        if (key.Key == ConsoleKey.UpArrow && position != 2)
                        {
                            position--;
                        }
                        else if (key.Key == ConsoleKey.DownArrow && position != 3)
                        {
                            position++;
                        }
                        else if (key.Key == ConsoleKey.RightArrow)
                        {
                            Console.Clear();
                            Main();
                        }
                        else if (key.Key == ConsoleKey.LeftArrow)
                        {
                            Console.Clear();
                            Second();
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            if (position == 2)
                            {
                                Console.Clear();
                                E();
                            }
                            else if (position == 3)
                            {
                                Console.Clear();
                                F();
                            }
                        }

                        Console.SetCursorPosition(0, position);
                        Console.WriteLine("->");

                        key = Console.ReadKey();
                    }

                    Console.SetCursorPosition(0, 4);
                }
            }
            static void A()
            {
                Console.WriteLine("Сходить в магазин");
                Console.WriteLine("");
                Console.WriteLine("Описание: 1)сходить в магазин 2)купить тесто, мак, хлороформ");
                Console.WriteLine("Дата: 11.10.2023 Время: 12:00 - 12:25");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(0, 4);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
            }
            static void B()
            {
                Console.WriteLine("Приготовить булочку с маком");
                Console.WriteLine("");
                Console.WriteLine("Описание: 1)добавить в тесто мак и хлороформ 2)свернуть в форму булочки 3)выпекать +- 10 минут");
                Console.WriteLine("Дата: 11.10.2023 Время: 12:30 - 12:50");
                Console.SetCursorPosition(0, 4);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
            }
            static void C()
            {
                Console.WriteLine("Поиграть в Bloodborne");
                Console.WriteLine("");
                Console.WriteLine("Описание: 1)запустить Bloodborne 2)умереть от первого босса 3)разбить геймпад");
                Console.WriteLine("Дата: 12.10.2023 Время: 14:00 - 14:15");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Second();
                }
            }
            static void D()
            {
                Console.WriteLine("Прогулка");
                Console.WriteLine("");
                Console.WriteLine("Описание: 1)выйти на улицу 2)понять, что ты социофоб 3)вернуться домой");
                Console.WriteLine("Дата: 12.10.2023 Время: 19:00 - 19:10");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Second();
                }
            }
            static void E()
            {
                Console.WriteLine("Сделать практическую работу на C#");
                Console.WriteLine("");
                Console.WriteLine("Описание: 1)выключить сериал 2)запустить visual studio 3)сделать практическую");
                Console.WriteLine("Дата: 13.10.2023 Время: 00:00 - 02:20");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Third();
                }
            }
            static void F()
            {
                Console.WriteLine("Поспать");
                Console.WriteLine("");
                Console.WriteLine("Описание: 1)Закончить практическую работу 2)положить голову на клавиатуру 3)заснуть");
                Console.WriteLine("Дата: 13.10.2023 Время: 02:20 - 12:30");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Third();
                }
            }
        }
    }
}