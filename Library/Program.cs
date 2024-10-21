using System;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library Axundov = null;
            bool isFalse = false;

            do
            {
                Console.WriteLine("1. Library elave edin \n2. Book elave edin \n3. Jurnal elave edin \n4. Mehsullar haqqinda melumat elde edin \n5. Mehsulun adina gore axtaris edin. \n6. Mehsulun qiymetine gore axtaris edin. \n0. EXIT \n");
                string input = Console.ReadLine();
                isFalse = int.TryParse(input, out int result);

                if (!isFalse)
                {
                    Console.WriteLine("Zehmet olmasa reqem daxil edin:");
                    continue;
                }
                isFalse = false; 
                switch (result)
                {
                    case 0:
                        isFalse = true;
                        break;

                    case 1:
                        Console.WriteLine("Kitabxananin adini daxil edin.");
                        string name = Console.ReadLine();
                        Axundov = new Library(name);
                        Console.WriteLine($"{name} adli kitabxana yaradildi \n");
                        break;

                    case 2:
                        if (Axundov == null)
                        {
                            Console.WriteLine("Zehmet olmasa evvel kitabxana elave edin.");
                            break;
                        }

                        Console.WriteLine("Kitabin adini daxil edin:");
                        string bookName = Console.ReadLine();

                        Console.WriteLine("Kitabin qiymetini daxil edin:");
                        string priceInput = Console.ReadLine();
                        bool a = double.TryParse(priceInput, out double bookPrice); 
                        if (!a)
                        {
                            do
                            {
                                Console.WriteLine("Reqem daxil edin!");
                                
                            }
                            while (!a);
                            break;
                        }

                        Console.WriteLine("Kitabin janrini daxil edin:");
                        string bookGenre = Console.ReadLine();

                        Console.WriteLine("Authorun adini daxil edin:");
                        string bookAuthor = Console.ReadLine();

                        Book book = new Book(bookName, bookPrice, bookAuthor, bookGenre);
                        Axundov.AddProduct(book);
                        Console.WriteLine("Book elave olundu\n");
                        break;

                    case 3:
                        if (Axundov == null)
                        {
                            Console.WriteLine("Zehmet olmasa evvel kitabxana elave edin\n");
                            break;
                        }

                        Console.WriteLine("Jurnal adini daxil edin:");
                        string journalName = Console.ReadLine();

                        Console.WriteLine("Jurnal qiymetini daxil edin:");
                        string journalPriceInput = Console.ReadLine();

                        if (!double.TryParse(journalPriceInput, out double journalPrice))
                        {
                            Console.WriteLine("Reqem daxil edin!\n");
                            break;
                        }

                        Console.WriteLine("Jurnali cap eden sirketin adi:");
                        string journalCompany = Console.ReadLine();

                        Journal journal = new Journal { Name = journalName, Price = journalPrice, Company = journalCompany };
                        Axundov.AddProduct(journal);



                        Console.WriteLine("Jurnal elave olundu\n");
                        break;

                    case 4:
                        if (Axundov == null)
                        {
                            Console.WriteLine("Kitabxana yoxdur\n");
                            break;
                        }

                        Console.WriteLine("Kitabxanadaki mehsullar:");
                        foreach (var product in Axundov.Products)
                        {
                            product.GetInfo();
                        }
                        break;

                    case 5:
                        if (Axundov == null)
                        {
                            Console.WriteLine("Kitabxana yoxdur\n");
                            break;
                        }

                        Console.WriteLine("Axtarilan mehsulun adini daxil edin:");
                        string searchName = Console.ReadLine();
                        var productsByName = Axundov.GetProductsByName(searchName);
                        if (productsByName.Length > 0)
                        {
                            foreach (var product in productsByName)
                            {
                                product.GetInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Mehsul tapilmadi\n");
                        }
                        break;

                    case 6:
                        if (Axundov == null)
                        {
                            Console.WriteLine("Kitabxana yoxdur\n");
                            break;
                        }

                        Console.WriteLine("Min qiymeti daxil edin:");
                        string minPriceInput = Console.ReadLine();
                        Console.WriteLine("Max qiymeti daxil edin:");
                        string maxPriceInput = Console.ReadLine();

                        if (!double.TryParse(minPriceInput, out double minPrice) || !double.TryParse(maxPriceInput, out double maxPrice))
                        {
                            Console.WriteLine("Reqem daxil edin!\n");
                            break;
                        }

                        var productsByPrice = Axundov.GetProductsByPrice(minPrice, maxPrice);
                        if (productsByPrice.Length > 0)
                        {
                            foreach (var product in productsByPrice)
                            {
                                product.GetInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Mehsul tapilmadi\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Yanlis secim\n");
                        break;
                }
            }
            while (!isFalse);
        }
    }
}