namespace торт
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<tort> Menu = new List<tort>
            {
                new tort
                {
                    Name = "Форма торта",
                    add_Menu = new List<tort>
                    {
                        new tort
                        {
                            Name = "Цилиндр",
                            Price = 150
                        },
                        new tort
                        {
                            Name = "Пирамида",
                            Price = 250
                        },
                        new tort
                        {
                            Name = "Куб",
                            Price = 120
                        },
                    }
                },
                new tort
                {
                    Name = "Размер торта",
                    add_Menu = new List<tort>
                    {
                        new tort
                        {
                            Name = "Маленький",
                            Price = 150
                        },
                        new tort
                        {
                            Name = "Обычный",
                            Price = 250
                        },
                        new tort
                        {
                            Name = "Большой",
                            Price = 120
                        },
                    }
                },
                new tort
                {
                    Name = "Вкус коржей",
                    add_Menu = new List<tort>
                    {
                        new tort
                        {
                            Name = "Ванильный",
                            Price = 150
                        },
                        new tort
                        {
                            Name = "Шоколадный",
                            Price = 250
                        },
                        new tort
                        {
                            Name = "Кокосовый",
                            Price = 120
                        },
                    }
                },
                new tort
                {
                    Name = "Количество коржей",
                    add_Menu = new List<tort>
                    {
                        new tort
                        {
                            Name = "1 корж",
                            Price = 150
                        },
                        new tort
                        {
                            Name = "2 коржа",
                            Price = 250
                        },
                        new tort
                        {
                            Name = "3 коржа",
                            Price = 120
                        },
                    }
                },
                new tort
                {
                    Name = "Глазурь",
                    add_Menu = new List<tort>
                    {
                        new tort
                        {
                            Name = "Шоколад",
                            Price = 150
                        },
                        new tort
                        {
                            Name = "Крем",
                            Price = 250
                        },
                        new tort
                        {
                            Name = "Ягоды",
                            Price = 120
                        },
                    }
                },
                new tort
                {
                    Name = "Конец заказа"
                }
            };

            tort func = new tort();
            func.Write_Menu(Menu);
        }
    }
}