using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace LoopExpert;

class Program
{
    static void Main(string[] args)
    {
        //IsPassing(75);
        //GetGradeClassification(90);
        //ViewItemsInListWithForEachLoop();
        //ViewItemsInListWithForLoop();
        //ViewMenuItems();
       // UserChoiceFromMenu();
       // IsEggsInList();
      // CountIngredients();
        //IsItemInList();
      //PrintListInReverse();
      //HasEggsAndFlourAndButter();
    }

    // 1. TODO: Complete the method to determine if a grade is passing.
    // A grade of 70 or greater is considered passing.
    // Example: If the grade is 75, the method should return true. If the grade is 65, the method should return false.
    // After completing the method, call it in the Main method with different grade values to test its functionality.
   static bool IsPassing(int grade)
    {
        int number1 = 75;
        int number2 = 65;

        if (number1 > number2)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

        return false;
    }
    
    // 2. TODO: Complete the method to return a grade classification as "A", "B", or "C" based on the grade.
    // Return "A" if the grade is 90 or above.
    // Return "B" if the grade is between 70 and 89 (inclusive).
    // Return "C" if the grade is below 70.
    // After completing the method, call it in the Main method with different grade values to test its functionality.
    static string GetGradeClassification(int grade)
    {
        int number1 = 90;
        int number2 = 89;
        int number3 = 71;
        int number4 = 70;
        string response;

        if (number1 == 90)
        {
            Console.WriteLine("A");
        }
        else if (number2 > number3)
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("C");
        }

        return "D";

    }


    // 3. TODO: Complete the method to print out all items in the list using a foreach loop.
    // Iterate over the ingredientList and print each item to the console.
    // Example: The output should be:
    // flour
    // sugar
    // eggs
    // butter
    // milk
    // vanilla
    static void ViewItemsInListWithForEachLoop()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };

        foreach (string ingredient in ingredientList)
        {
            Console.WriteLine(ingredient);
        }
        
        
    }

    // 4. TODO: Complete the method to print out all items in the list using a for loop.
    // Use a standard for loop to iterate over the ingredientList and print each item to the console.
    // Example: The output should be:
    // flour
    // sugar
    // eggs
    // butter
    // milk
    // vanilla
    static void ViewItemsInListWithForLoop()
    {
        List<string> ingredientlist = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(ingredientlist[i]);
        }
    }

    // 5. TODO: Complete the method to check if "eggs" is in the list.
    // Return true if "eggs" is in the ingredientList, otherwise return false.
    // Example: If the list contains "eggs", the method should return true. If it does not, the method should return false.
    static void IsEggsInList()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };
        
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(ingredientList);
        }
        

    }

    // 6. TODO: Create a method that displays a menu with three items.
    // These can be three restaurant menu items. Print each item to the console.
    // Example: The menu might include:
    // 1. Cheeseburger
    // 2. Caesar Salad
    // 3. Spaghetti Bolognese
    static void  ViewMenuItems()
    {
        List<string> Menu = new List<string>() { "Cheesebuger", "Caesar Salad", "Spaghetti Bolognese" };

        foreach (string items in Menu)
        {
            Console.WriteLine(items);
        }
    }
    

    // 7. TODO: Complete the method to prompt the user to choose an item from the menu.
    // This method should print a message asking the user what item they want.
    // Then, return the user's input as a string.
    // Example: If the user selects "1", the method should return "1".
    static void UserChoiceFromMenu()
    {
        int cheesebuger = 1;
        int steak = 2;
        Console.WriteLine("Choose an item from the menu");
        string userInput = Console.ReadLine();
        int parsedUserInput = int.Parse(userInput);

        if (parsedUserInput > cheesebuger)
        {
            Console.WriteLine("You pick # 2 the steak");
        }
        else if (parsedUserInput < steak)
        {
            Console.WriteLine("You pick # 1 the cheesebuger");
        }
        else
        {
            Console.WriteLine("No thanks");
        }

    }

    // 8. TODO: Complete the method to count the number of ingredients in the list.
    // This method should return the total number of items in the ingredientList.
    // Example: If the list contains 6 items, the method should return 6.
    static void  CountIngredients()
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };

        int i = 1;
        while (i <= 6)
        {
            Console.WriteLine(i);
            i++;
        }
        

    }

    // 9. TODO: Complete the method to check if a specific item is in the list.
    // The method should take a string parameter for the item name and return true if the item is in the list, false otherwise.
    // Example: If the item is "sugar" and it exists in the list, return true.
    static bool IsItemInList(string food)
    {
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(true);
        }

        return false;
    }

    // 10. TODO: Complete the method to print out all items in the list in reverse order.
    // Use a loop to iterate over the list in reverse and print each item.
    // Example: If the list is { "flour", "sugar", "eggs", "butter", "milk", "vanilla" }, the output should be:
    // vanilla
    // milk
    // butter
    // eggs
    // sugar
    // flour
    static void PrintListInReverse()
    {
        Console.WriteLine("Decrease");
        List<string> ingredientList = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };

        for (int i = 6; i >= 0; i--)
        {
            Console.WriteLine($"ingredients{i}");
        }
        
    }

    // 11. BONUS -- TODO: Complete the method to check if the list contains "eggs", "flour", and "butter".
    // Use conditional statements to check if all three ingredients are present in the ingredientList.
    // Return true only if "eggs", "flour", and "butter" are all in the list; otherwise, return false.
    // Example: If the list is { "flour", "sugar", "eggs", "butter", "milk", "vanilla" }, the method should return true.
    // Example: If the list is { "flour", "sugar", "milk", "vanilla" }, the method should return false.
    static bool HasEggsAndFlourAndButter()
    {
       List<string> food = new List<string>() { "flour", "sugar", "eggs", "butter", "milk", "vanilla" };

       for (int i = 0; i < 6; i++)
       {
           Console.WriteLine();
       }

       return false;


    }
}