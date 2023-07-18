// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Adventurer's Emporium and Bazaar!");

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

menu.Add("Potion", 5.00m);
menu.Add("Hi-Potion", 20.00m);
menu.Add("Phoenix Down", 15.00m);
menu.Add("Dagger", 3.20m);
menu.Add("Coral Sword", 43.00m);
menu.Add("Mythril Armor", 185.00m);
menu.Add("Cat's Claw", 500.00m);
menu.Add("Heaven's Lance", 1100.00m);
//NOTE: I had to tweak the names so that there were no duplicate substrings within the ("holy lance" conflicted with "phoenix down" when entering just "ho")

//dictionary originally on line 15 here
//display menu of items & prices
//foreach (KeyValuePair<string, decimal> kvp in menu)
//{
//    Console.WriteLine($"{kvp.Key}: {kvp.Value} gil");
//}

List<string> shoppingList = new List<string>();

bool runShopping = true;
while (runShopping)
{
    foreach (KeyValuePair<string, decimal> kvp in menu)
    {
        Console.WriteLine($"{kvp.Key}: {kvp.Value} gil");
    }
    Console.WriteLine("Please make a selection from the above to add to your shopping list.");
    string item = (Console.ReadLine()).ToLower();
    
    if (menu.Keys.Any(n => n.ToLower().Contains(item)))
    {
        string result = menu.Keys.FirstOrDefault(n => n.ToLower().Contains(item));
        shoppingList.Add(result);
        
    } else
    {
        Console.WriteLine("Sorry, we don't carry that!");
    }

    if (shoppingList.Count >= 0)
    {
        Console.WriteLine("Here is your shopping list:");

        foreach (string i in shoppingList)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Would you like to add another item to your shopping list? (y/n)");
    } else
    {
        Console.WriteLine("Your shopping list has no items on it.");
        Console.WriteLine("Would you like to add an item to your shopping list? (y/n)");
    }
    //this is a funnel. 

    while (true)
    {
        
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            Console.WriteLine($"\n\nWe are most grateful for your patronage, brave adventurer.");
            Console.WriteLine("Here is your receipt for today:");
            decimal sum = 0;
            foreach (string i in shoppingList)
            {
                Console.WriteLine($"{i}.....{menu[i]} gil");
                sum += menu[i];
                
            }
            decimal average = Math.Round(sum / shoppingList.Count, 2);
        
            Console.WriteLine($"Your total today comes to {sum} gil.");
            Console.WriteLine($"Your average cost per item comes to {average} gil.");
            Console.WriteLine("Thanks for stopping by! \nHave fun storming the castle!");
            //make a list of shoppingList's values
            //do I have to for loop to loop through the shoppingList, nab the values from the dictionary, and then add?
            //use list.Sum() method to add 'em to together?
            
            //foreach (string i in shoppingList)
            //{
            //    menu.Values;
            //}
           
            runShopping = false;
            break;
        }
        else if (choice == "y")
        {
            runShopping = true;
            break;
        }
        else
        {
            Console.WriteLine("Please answer yes or no if you'd like to proceed.");
        }
    }

} //end of RunShopping loop aka user shopping time

Console.ReadLine();

//8 items:
/*
 * Potion: 5.00m
 * Hi-Potion: 20.00m
 * Phoenix Down: 15.00m
 * Dagger: 3.20m
 * Coral Sword: 43.00m
 * Mythril Armor: 185.00m
 * Cat's Claw: 500.00m
 * Holy Lance: 1100.00m
 * 
 * Tent: 80.00m
 * Egoist's Armlet: 200.00m
 * Gaia Gear: 870.00
 * Golden Hairpin: 369.99m
 * Eye Drops: 0.50m
 */

