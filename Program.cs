//Cuong Brandon Le
//10-18-22
//Mini Challenge 9 - Restaurant Picker



bool playAgain = true;
string userInput;
string num1;
string option;
int validNum;
bool canParse = true;

string [] asianFood = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ", "RAW Sushi Bistro"};
string [] fastFood = {"McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Sonic's", "Del Taco", "Raising Cane's"};
string [] beverages = {"T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea", "Tea Dazed"};


while (playAgain = true)
{

Console.WriteLine("Welcome to the restaurant picker!");
Console.WriteLine("You can choose from 3 categories: Asian Food, Fast Food, and Beverages.");
Console.WriteLine("Please enter your choice: ONE = Asian Food, TWO = Fast Food, and THREE = Beverages if you're thirsty!");
option = Console.ReadLine().ToUpper();

while (option != "ONE" && option != "TWO" && option != "THREE")
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("You entered an invalid choice, try again.");
    Console.WriteLine("Enter ONE, TWO, or THREE.");
    Console.WriteLine("----------------------------------------");
    option = Console.ReadLine().ToUpper();
}

if(option == "ONE")
{
    Console.WriteLine("You chose Asian Food!");
    Console.WriteLine("Choose a number from 0-9:");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    Console.WriteLine(asianFood[validNum]);
}

if(option == "TWO")
{
    Console.WriteLine("You chose Fast Food!");
    Console.WriteLine("Choose a number from 0-9:");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    Console.WriteLine(fastFood[validNum]);
}

if(option == "THREE")
{
    Console.WriteLine("You chose Beverages! Someone's thirsty.");
    Console.WriteLine("Choose a number from 0-9:");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);
    Console.WriteLine(beverages[validNum]);
}

}

