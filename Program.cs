class Program
{
    static void Main()
    { 
    List<Food> list = new List<Food>()
    {
        new Food(){name = "bred" , price =3.50},
        new Food(){name = "xinkali" , price =1.50},
        new Food(){name = "pizza" , price =4.00},
        new Food(){name = "bwadi" , price =5.00},
        new Food(){name = "lobiani" , price =3.70},
        new Food(){name = "kartoshka free" , price =17.50},
        
    };
       
        
        List<Table> list2 = new List<Table>()
       {
            new Table(){table = "N1"},
            new Table(){table = "N2"},
            new Table(){table = "N3"},
            new Table(){table = "N4"},
            new Table(){table = "N5"},
       };

        bool true1 = true;
        while (true1)
        {
            Console.WriteLine("1)enter to the restoran");
            Console.WriteLine("2)exit");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                Console.WriteLine("choose table:");
                foreach (Table table in list2)
                {
                    Console.WriteLine($" table {table.table} ");
 
                }
                
                string input2 = Console.ReadLine();
                Console.Clear();
                if (input2 == "1")
                {
                    Console.WriteLine("you table is N1");
                    Console.WriteLine("make order");
                    Console.WriteLine("____________________");
                    foreach (Food food in list)
                    {
                        Console.WriteLine($"food:{food.name} price: {food.price}");
                    }
                    Console.WriteLine("take all?");
                    Console.WriteLine("y/n");
                    string yes = Console.ReadLine();
                    if (yes == "y")
                    {
                        Food food2 = new Food();    
                        Console.WriteLine($"food will be in 30 minutes and finall cost is 34.20 lari");
                    }
                    string y = Console.ReadLine();
                    Console.Clear();
                }
                if (input2 == "2")
                {
                    Console.WriteLine("you table is N2");
                    Console.WriteLine("make order");
                    Console.WriteLine("____________________");
                    foreach (Food food in list)
                    {
                        Console.WriteLine($"food:{food.name} price: {food.price}");
                    }
                    Console.WriteLine("take all?");
                    Console.WriteLine("y/n");
                    string yes = Console.ReadLine();
                    if (yes == "y")
                    {
                        Food food2 = new Food();
                        Console.WriteLine($"food will be in 30 minutes and finall cost is 34.20 lari");
                    }
                    string y = Console.ReadLine();
                    Console.Clear();
                }
                if (input2 == "3")
                {
                    Console.WriteLine("you table is N3");
                    Console.WriteLine("make order");
                    Console.WriteLine("____________________");
                      for (int i = 1; i  < list.Count; i++)
                        {
                            Console.WriteLine($"{i})food:{list[i].name} price: {list[i].price }");
                        }
                  
                    
                    Console.WriteLine("take all?");
                    Console.WriteLine("y/n");
                    string yes = Console.ReadLine();
                    if (yes == "y")
                    {
                        Food food2 = new Food();
                        Console.WriteLine($"food will be in 30 minutes and finall cost is 34.20 lari");
                        Console.Clear();
                    }
                    string y = Console.ReadLine();
               
                    if (yes =="n" )
                    {
                        Console.WriteLine("choo the number for food press o to stop : ");
                        while (true)
                        {
                            string order = Console.ReadLine();
                            
                            if (order == "1")
                            {
                                for (int i = 5; i < list.Count; i++)
                                {
                                    Console.WriteLine($"food:{list[1].name} price: {list[1].price }");
                              
                                }
                            }
                            if (order == "2")
                            {
                                for (int i = 5; i < list.Count; i++)
                                {
                                    Console.WriteLine($"food:{list[2].name} price: {list[2].price }");
                                }
                            }
                            if (order == "3")
                            {
                                for (int i = 5; i < list.Count; i++)
                                {
                                    Console.WriteLine($"food:{list[3].name} price: {list[3].price }");
                                }
                            }
                            if (order == "4")
                            {
                                for (int i = 5; i < list.Count; i++)
                                {
                                    Console.WriteLine($"food:{list[4].name} price: {list[4].price }");
                                }
                            }
                            if (order == "5")
                            {
                                for (int i = 5; i < list.Count; i++)
                                {
                                    Console.WriteLine($"food:{list[5].name} price: {list[5].price }");
                                }
                            }
                            if (order == "o")
                            {
                                Console.WriteLine($"this is your order cost is :???  ");
                            }
                        }
                       
                        
                       
                    }
                }
                if (input2 == "4")
                {
                    Console.WriteLine("you table is N4");
                    Console.WriteLine("make order");
                    Console.WriteLine("____________________");
                    foreach (Food food in list)
                    {
                        Console.WriteLine($"food:{food.name} price: {food.price}");
                    }
                    Console.WriteLine("take all?");
                    Console.WriteLine("y/n");
                    string yes = Console.ReadLine();
                    if (yes == "y")
                    {
                        Food food2 = new Food();
                        Console.WriteLine($"food will be in 30 minutes and finall cost is 34.20 lari");
                    }
                    string y = Console.ReadLine();
                    Console.Clear();
                }
                if (input2 == "5")
                {
                    Console.WriteLine("you table is N5");
                    Console.WriteLine("make order");
                    Console.WriteLine("____________________");
                    foreach (Food food in list)
                    {
                        Console.WriteLine($"food:{food.name} price: {food.price}");
                    }
                    Console.WriteLine("take all?");
                    Console.WriteLine("y/n");
                    string yes = Console.ReadLine();
                    if (yes == "y")
                    {
                        Food food2 = new Food();
                        Console.WriteLine($"food will be in 30 minutes and finall cost is 34.20 lari");
                    }
                    string y = Console.ReadLine();
                    Console.Clear();
                }
             
            }
            if (input =="2")
            {
                true1 = false;
            }
        
        }
    }
    
}
class Table
{
    public string table { get; set; }

}
class Food
{
    public string name { get; set; }
    public double price { get; set; }

}
