//Cuong Brandon Le
//10-18-22
//Mini Challenge 9 - Restaurant Picker


//place holder - note to self: this challenge should be similar to magic 8 ball but without unity.

bool playAgain = true;
string userInput;
string option;


string [] asianFood = {"Mama's Pho", "Green Papaya", "Komachi Sushi", "OZ Korean BBQ", "Bonchon", "Royal Siam", "M Sushi", "Tasty Pot", "Blue House Korean BBQ"};
string [] fastFood = {"McDonald's", "Taco Bell", "Wendy's", "Jack In The Box", "Popeye's", "Burger King", "Wingstop", "Panda Express", "Del Taco", "Raising Cane's"};
string [] beverages = {"T4", "Happy Lemon", "Jamba Juice", "Bober Tea", "Kung Fu Tea", "7 Leaves Cafe", "Purple Kow", "Boba Guys", "Sharetea"};


while (playAgain = true)
{

Console.WriteLine("Welcome to the restaurant picker!");
Console.WriteLine("You can choose from 3 categories: Asian Food, Fast Food, and Drinks.");
Console.WriteLine("Please enter your choice: ONE = Asian Food, TWO = Fast Food, and THREE = drinks if you're thirsty!");
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
}

if(option == "TWO")
{
    Console.WriteLine("You chose Fast Food!");
}

if(option == "THREE")
{
    Console.WriteLine("You chose drinks! Someone's thirsty.");
}

}

