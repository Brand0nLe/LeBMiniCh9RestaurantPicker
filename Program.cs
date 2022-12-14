//Brandon Le
//10-20-22
//Mini Challenge 9 - Restaurant Picker
//This project will give the user 4 different array choices. Asian food, Fast food, Beverages, and a randomizer option. 
//There are 10 options in each array for a total of 30 options when the user decides to use the help function to target a random integer from the randomizer array. 
//There is a play again function and error messages for when the user input is not ONE, TWO, THREE, or HELP.
//Peer Review: Harrison Busby - I really liked how Brandon did his code. It is organized well and is easy to read. I liked how when he did his Console.WriteLine()'s
//he made almost boxes around what he was saying to the user, really interesting. If there was one thing
//to nitpick it was that when you type a number bigger than the options given to you it throws an error but other than that I really liked it. Good Job Brandon! :)


bool playAgain = true;
string userInput;
string userInputEnd;
string option;
int validNum;
bool canParse = true;

string [] asianFood = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro"};
string [] fastFood = {"McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's"};
string [] beverages = {"T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};
string [] randomizer = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro", "McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's", "T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};


while (playAgain == true)
{
    Console.Clear();
Console.WriteLine("-------------------------------------------------------------------------------------------------------");
Console.WriteLine("Welcome to the restaurant picker!");
Console.WriteLine("You have 4 options: Asian Food, Fast Food, Beverages, or Help");
Console.WriteLine("Please enter your choice: ONE = Asian Food, TWO = Fast Food, and THREE = Beverages if you're thirsty!");
Console.WriteLine("When you're feeling lazy choose HELP and we'll decide for you!");
Console.WriteLine("-------------------------------------------------------------------------------------------------------\n");
option = Console.ReadLine().ToUpper();

while (option != "ONE" && option != "TWO" && option != "THREE" && option != "HELP")
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
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY! Please enter a number from 0 - 9:");
        userInput = Console.ReadLine();
        canParse = Int32.TryParse(userInput, out validNum);
    }
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
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY! Please enter a number from 0 - 9:");
        userInput = Console.ReadLine();
        canParse = Int32.TryParse(userInput, out validNum);
    }
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
    while(canParse == false)
    {
        Console.WriteLine("INVALID ENTRY! Please enter a number from 0 - 9:");
        userInput = Console.ReadLine();
        canParse = Int32.TryParse(userInput, out validNum);
    }
    Console.WriteLine(beverages[validNum]);
}

if(option == "HELP")
{
    Random r = new Random();
    int randomInt = r.Next(0, 29);
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You don't know what to eat? I'll help you choose!");
    Console.WriteLine("You should go to:");
    Console.WriteLine(randomizer[randomInt]);
    Console.WriteLine("----------------------------------------\n");   
}

    Console.WriteLine("Do you want to play again? (YES/NO)");
    userInputEnd = Console.ReadLine().ToUpper();
while (userInputEnd != "YES" && userInputEnd!= "NO")
    {
        Console.WriteLine("INVALID ENTRY! Please enter YES or NO:");
        userInputEnd = Console.ReadLine().ToUpper();
    }


if(userInputEnd == "NO")
{
    playAgain = false;
    Console.WriteLine("Come back again when you need food suggestions!");
}
if(userInputEnd == "YES")
{
    playAgain = true;
}



}

