namespace C__HW_modul_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter chice");

            int c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    Journal journal1 = new Journal(5); 
                    Journal journal2 = new Journal(7); 
                    Console.WriteLine($"Journal 1 Employees: {journal1._employees}");
                    Console.WriteLine($"Journal 2 Employees: {journal2._employees}"); 
                    journal1 += 3;
                    journal2 -= 2;  
                    Console.WriteLine($"Journal 1 Employees after addition: {journal1._employees}");
                    Console.WriteLine($"Journal 2 Employees after subtraction: {journal2._employees}");   
                    if (journal1 == journal2)
                        Console.WriteLine("Both journals have the same number of employees.");
                    else if (journal1 < journal2)
                        Console.WriteLine("Journal 1 has fewer employees than Journal 2.");
                    else
                        Console.WriteLine("Journal 1 has more employees than Journal 2.");

                    
                    Console.WriteLine($"journal1.Equals(journal2): {journal1.Equals(journal2)}");
                    break;
                case 1:
                    Shop shop1 = new Shop(100);
                    Shop shop2 = new Shop(50);

                    shop1 += 50; 
                    shop2 -= 30; 

                    Console.WriteLine($"Shop 1 area: {shop1.area}");
                    Console.WriteLine($"Shop 2 area: {shop2.area}");

                    if (shop1 == shop2)
                        Console.WriteLine("Both shops have the same area.");
                    else if (shop1 > shop2)
                        Console.WriteLine("Shop 1 has a larger area than Shop 2.");
                    else
                        Console.WriteLine("Shop 2 has a larger area than Shop 1.");
                    break;

                case 2:

                    ReadingList myReadingList = new ReadingList(5);

                    
                    myReadingList.AddBook("The Great Gatsby");
                    myReadingList.AddBook("To Kill a Mockingbird");
                    myReadingList.AddBook("1984");

                  
                    myReadingList.DisplayBooks();

                   
                    Console.WriteLine("Is 'To Kill a Mockingbird' in the reading list? " + myReadingList.ContainsBook("To Kill a Mockingbird"));

                   
                    myReadingList.RemoveBook("To Kill a Mockingbird");

                   
                    myReadingList.DisplayBooks();
                    break;
            }
            
        }

    }
}

