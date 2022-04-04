using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Product
{
    class Book : Product
    {
        public string Genre;
        public Book(int no, string name, int price,string genre):base(no,name,price)
        {
            Genre = genre;
        }
        public void Run()
        {
            Console.Write("Input Counter : ");
            Count = int.Parse(Console.ReadLine());
            if (Count == 0)
            {
                Console.WriteLine("0 olmamalidir");
                return;
            }
            Book[] Books = new Book[Count];
            for (int i = 0; i < Count; i++)
            {
                Books[i] = new Book();
                Console.Write("Name : ");
                Books[i].Name = Console.ReadLine();
                while (Books[i].Name == "" || Books[i].Name == " ")
                {
                    Console.WriteLine("Sehv formatda daxil edilib");
                    Console.Write("Name : ");
                    Books[i].Name = Console.ReadLine();
                }
                Console.Write("No : ");
                Books[i].No = int.Parse(Console.ReadLine());
                Console.Write("Price : ");
                Books[i].Price = int.Parse(Console.ReadLine());
                Console.Write("Genre : ");
                Books[i].Genre = Console.ReadLine();
                while (Books[i].Genre == "" || Books[i].Genre == " ")
                {
                    Console.WriteLine("Sevh format yeniden elave et");
                    Console.Write("Genre : ");
                    Books[i].Genre = Console.ReadLine();
                }
                Console.WriteLine("\n");
            }
            int value = 0;
            do
            {

                Console.WriteLine("1. Kitablari qiymete gore filtrle.\n2. Butun kitablari goster.\n0. Proqrami bagla\n");
                Console.Write("Sechiminiz : ");
                value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.Write("Min qiymeti input ele : ");
                        int minPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.Write("Max qiymeti input ele : ");
                        int maxPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Verdiyiniz qiymet diapozonunda olan kitablar : ");
                        foreach (var item in Books)
                        {
                            if (item.Price <= maxPrice && item.Price >= minPrice)
                            {
                                Console.WriteLine($"Name : {item.Name}\nPrice : {item.Price}\nGenre : {item.Genre}\nNo : {item.No}\n");
                            }
                        }
                        break;
                    case 2:
                        foreach (var item in Books)
                        {
                            Console.WriteLine($"Name : {item.Name}\nPrice : {item.Price}\nGenre : {item.Genre}\nNo : {item.No}\n");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Proqram sona catdi!");
                        break;
                    default:
                        Console.WriteLine("Bele punkt yoxdur! Yeniden Sechim edin :\n");
                        break;
                }
            } while (value != 0);
        }
    }
}


