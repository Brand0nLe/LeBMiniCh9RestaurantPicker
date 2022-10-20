//Cuong Brandon Le
//10-18-22
//Mini Challenge 9 - Restaurant Picker



bool playAgain = true;
string userInput;
string userInputEnd;
string num1;
string option;
int validNum;
bool canParse = true;
int indexRandom;

string [] asianFood = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro"};
string [] fastFood = {"McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's"};
string [] beverages = {"T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};
string [] randomizer = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro", "McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's", "T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};


while (playAgain = true)
{
Console.WriteLine("-------------------------------------------------------------------------------------------------------");
Console.WriteLine("Welcome to the restaurant picker!");
Console.WriteLine("You have 4 options: Asian Food, Fast Food, Beverages, or Help");
Console.WriteLine("Please enter your choice: ONE = Asian Food, TWO = Fast Food, and THREE = Beverages if you're thirsty!");
Console.WriteLine("When you're feeling lazy choose HELP and we'll decide for you!");
Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");
option = Console.ReadLine().ToUpper();

while (option != "ONE" && option != "TWO" && option != "THREE" && option !="HELP")
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You entered an invalid choice, try again.");
    Console.WriteLine("Enter ONE, TWO, THREE or HELP.");
    Console.WriteLine("----------------------------------------");
    option = Console.ReadLine().ToUpper();
}

if(option == "ONE")
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You chose Asian Food!");
    Console.WriteLine("Choose a number from 0-9:");
    Console.WriteLine("----------------------------------------\n");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    Console.WriteLine(asianFood[validNum]);
}

if(option == "TWO")
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You chose Fast Food!");
    Console.WriteLine("Choose a number from 0-9:");
    Console.WriteLine("----------------------------------------\n");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    Console.WriteLine(fastFood[validNum]);
}

if(option == "THREE")
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You chose Beverages! Someone's thirsty.");
    Console.WriteLine("Choose a number from 0-9:");
    Console.WriteLine("----------------------------------------\n");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    Console.WriteLine(beverages[validNum]);
}

if(option == "HELP")
{
    Random r = new Random();
    int rInt = r.Next(0, 29);
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You don't know what to eat? I'll help you choose!");
    Console.WriteLine("You should go to:");
    Console.WriteLine(randomizer[rInt]);
    Console.WriteLine("----------------------------------------\n");   
}

    Console.WriteLine("Do you want to play again? (YES/NO)");
    userInputEnd = Console.ReadLine().ToUpper();

if(userInputEnd == "YES")
{
    playAgain = true;
}
else
{
    playAgain = false;
    Console.WriteLine("Come back again when you need food suggestions!");
}





}

