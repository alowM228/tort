using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace торт
{
    internal class tort
    {
        public string Name;
        public List<tort> add_Menu = new List<tort>();
        public int Price;
        private bool start = true;
        private int cur_pos1 = 0;
        private List<tort> und_Menu;
        private bool witch = false;
        private int fin_Price;
        private List<tort> alr_torted = new List<tort>();

        public void Write_Menu(List<tort> a)
        {
            while(start)
            {
                Console.Clear();
                if (witch == true)
                {
                    foreach (var element in a)
                    {
                        Console.WriteLine(" " + element.Name + " - " + element.Price);
                    }
                    Console.WriteLine(" Добавить товар");
                }
                else
                {
                    foreach (var element in a)
                    {
                        Console.WriteLine(" " + element.Name);
                    }
                    Console.WriteLine("Общая цена: " + fin_Price);
                    Console.Write("Ваш торт: ");
                    if (alr_torted.Count() != 0)
                    {
                        foreach (var element in alr_torted)
                        {
                            Console.Write(element.Name + " - " + element.Price + "; ");
                        }
                    } 
                }
                ConsoleKeyInfo key = Arrow(a);
                
                if (key.Key == ConsoleKey.Escape) 
                {
                    witch = false;
                    start = false;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (witch == true)
                    {
                        if (cur_pos1 == a.Count())
                        {
                            a = create_new_element(a);
                            Console.Clear();
                        }
                        else
                        {
                            var element = a[cur_pos1];
                            fin_Price = fin_Price + element.Price;
                            alr_torted.Add(element);
                            witch = false;
                            start = false;
                        }
                    }
                    else
                    {
                        if (cur_pos1 == a.Count() - 1)
                        {
                            if (File.Exists("D:\\tort\\tort.txt"))
                            {
                                File.AppendAllText("D:\\tort\\tort.txt", "\n");
                                File.AppendAllText("D:\\tort\\tort.txt", DateTime.Now + "\n" + "Общая цена: " + fin_Price + "\n" + "Заказ: " + "\n");
                                foreach (var element in alr_torted)
                                {
                                    File.AppendAllText("D:\\tort\\tort.txt", element.Name + " - " + element.Price + "\n");
                                }
                            }
                            else
                            {
                                File.WriteAllText("D:\\tort\\tort.txt", DateTime.Now + "\n" + "Общая цена: " + fin_Price + "\n" + "Заказ: " + "\n");
                                foreach (var element in alr_torted)
                                {
                                    File.AppendAllText("D:\\tort\\tort.txt", element.Name + " - " + element.Price + "\n");
                                }
                            }
                            fin_Price = 0;
                            alr_torted.Clear();
                        }
                        else
                        {
                            var element = a[cur_pos1];
                            und_Menu = element.add_Menu;
                            witch = true;
                            cur_pos1 = 0;
                            Write_Menu(und_Menu);
                            start = true;
                        }
                    }
                }
            }
        }
        private ConsoleKeyInfo Arrow(List<tort> a)
        {
            Console.SetCursorPosition(0, cur_pos1);
            Console.WriteLine("-");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow)
            {
                cur_pos1--;
                if (cur_pos1 < 0 && witch == false)
                {
                    cur_pos1 = a.Count() - 1;
                }
                else if (cur_pos1 < 0)
                {
                    cur_pos1 = a.Count();
                }
            } 
            else if (key.Key == ConsoleKey.DownArrow)
            {
                cur_pos1++;
                if (cur_pos1 > a.Count() - 1 && witch == false)
                {
                    cur_pos1 = 0;
                }
                else if (cur_pos1 > a.Count())
                {
                    cur_pos1 = 0;
                }
            }
            return (key);
        }
        private List<tort> create_new_element(List<tort> a)
        {
            Console.Clear();
            var element = new tort();
            Console.WriteLine("Введите название нового пункта: ");
            element.Name = Console.ReadLine();
            Console.WriteLine("Введите цену нового пункта: ");
            element.Price = Convert.ToInt32(Console.ReadLine());
            a.Add(element);
            return(a);
        }
    }
}
