// See https://aka.ms/new-console-template for more information
{   //establish variables
    string userFoodType;
    string userMainIngredient;
    string userSeasoning;

    //call methods to print menu and take order
    MenuPrint();
    BuildYourOwn();

    //touple that contains the user's selections
    (string, string, string) userCreation = (userSeasoning, userMainIngredient, userFoodType);
    
    //reads back user order
    Console.WriteLine($"Your {userCreation.Item1} {userCreation.Item2} {userCreation.Item3} is ready!");

    //prints the menu for the user
    void MenuPrint()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"| {"Foods",-10} {"Main Ingredient",-10}\t{"Seasoning"} |");
        Console.WriteLine("|-----------------------------------------|");
        Console.WriteLine($"| {FoodType.Soup,-10}\t{FoodMainIngredient.Mushrooms,-10}\t{FoodSeasoning.Spicey,-10}|");
        Console.WriteLine($"| {FoodType.Stew,-10}\t{FoodMainIngredient.Chicken,-10}\t{FoodSeasoning.Salty,-10}|");
        Console.WriteLine($"| {FoodType.Gumbo,-10}\t{FoodMainIngredient.Carrots,-10}\t{FoodSeasoning.Sweet,-10}|");
        Console.WriteLine($"| {"*****",-10}\t{FoodMainIngredient.Potatoes,-10}\t{"*****",-10}|");
        Console.WriteLine("-------------------------------------------");
    }

    //collects the user's order
    void BuildYourOwn()
    {


        Console.Write("Which type of meal can I get started for you? ");
        userFoodType = Console.ReadLine();

        //verifies user input
        while (true)
        {
            if (userFoodType == "soup" || userFoodType == "stew" || userFoodType == "gumbo" || userFoodType == "Soup" || userFoodType == "Stew" || userFoodType == "Gumbo")
            {
                break;
            }
            Console.WriteLine("I'm sorry, but you have made a selection that is not on our menu. Please select a type of meal from our menu.");
            userFoodType = Console.ReadLine();
        }


        Console.Write("Which main ingredient would you like? ");
        userMainIngredient = Console.ReadLine();

        //verifies user input
        while (true)
        {
            if (userMainIngredient == "mushrooms" || userMainIngredient == "Mushrooms" || userMainIngredient == "chicken" || userMainIngredient == "Chicken" 
                || userMainIngredient == "carrots" || userMainIngredient == "Carrots" || userMainIngredient == "potatoes" || userMainIngredient == "Potatoes")
            {
                break;
            }
            Console.WriteLine("I'm sorry, but you have made a selection that is not on our menu. Please select a main ingredient from our menu.");
            userMainIngredient = Console.ReadLine();
        }


        Console.Write("And, would you like that spicey, salty, or sweet?");
        userSeasoning = Console.ReadLine();
        
        //verifies user input
        while (true)
        {
            if (userSeasoning == "spicey" || userSeasoning == "Spicey" || userSeasoning == "salty" || userSeasoning == "Salty" || userSeasoning == "sweet" || userSeasoning == "Sweet")
            {
                break;
            }
            Console.WriteLine("I'm sorry, but you have made a selection that is not on our menu. Please select a main ingredient from our menu.");
            userSeasoning = Console.ReadLine();
        }

    }
    //holds console window open
    Console.ReadKey();
}
//enums called for recipe elements
enum FoodType { Soup, Stew, Gumbo };
enum FoodMainIngredient { Mushrooms, Chicken, Carrots, Potatoes };
enum FoodSeasoning { Spicey, Salty, Sweet };
