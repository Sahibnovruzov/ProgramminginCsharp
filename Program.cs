using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Message.Goodbye();
            Message.Hello();
           
            Console.ReadLine();




        }
    }
     

}


/*
int x;
int y;
double a;
bool b;
b = true;
x = 5;
y = 10;
a = 23.5;
char c = 'a';;
string s = "name";
string username = c + s;
Console.WriteLine(username);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(a);
Console.WriteLine(s);
Console.WriteLine(c);
Console.WriteLine(b);
*/
/*
const double pi = 3.14159;
pi = 45;
Console.WriteLine(pi);

*/
/*
double x = 3.14;
int y = Convert.ToInt32(x);

int z = 6;
double t = Convert.ToDouble(z) + 0.1;

int e = 12;
string s = Convert.ToString(e);

string g = "$";
char c = Convert.ToChar(g);
string i = "true";
bool j =Convert.ToBoolean(i);
Console.WriteLine(t);
Console.WriteLine(s);
Console.WriteLine(c.GetType());
Console.WriteLine(j);


*/
/*
Console.WriteLine("Your name?");
string name = Console.ReadLine();

Console.WriteLine("Hello " + name);
Console.WriteLine("Your age?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is " + age);

*/
/*
int a = 6;
a /= 5;
int b = 8;
b %= 3;

Console.WriteLine(a);
Console.WriteLine(b);


*/

/*
double a = 3.99999;
double b = 5;


//double b = Math.Pow(a, 3);
//double b = Math.Sqrt(a);
//double b = Math.Abs(a);
//double b = Math.Round(a);
//double b = Math.Ceiling(a);
//double b = Math.Floor(a);
double c = Math.Min(a, b);




Console.WriteLine(c);
*/
/*
Random random = new Random();   

//int a = random.Next(1,90);
double b = random.NextDouble(); 

Console.WriteLine(b);

*/

/*
Console.WriteLine("Ente side of A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ente side of B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c =Math.Sqrt((a * a) + (b * b));
Console.WriteLine("Hipetonus :" + c);

*/
/*
string name = "Sahib";
//string fullname = name.ToLower();

//string phonedayber = "012-459-14-04";
//phonenumber = phonenumber.Replace("-", "!");

//string username = name.Insert(0, "@"); 
Console.WriteLine(name.Substring(0,3)); 


*/

/*
Console.WriteLine("enter your name :");
string name = Console.ReadLine();

if (name != "")
{
    Console.WriteLine("Your name is " + name);

}
else
{
    Console.WriteLine("Please enter your name");

}
*/

/*
Console.WriteLine("What day is today?");
int num = Convert.ToInt32(Console.ReadLine());  

switch (num)
{
    case 1:
        Console.WriteLine("Today is a " + num);  
        break;
    case 2:
        Console.WriteLine("Today is a " + num);
        break;
    case 3:
        Console.WriteLine("Today is a " + num);
        break;
    case 4:
        Console.WriteLine("Today is a " + num);
        break;
    case 5:
        Console.WriteLine("Today is a " + num);
        break;
    case 6:
        Console.WriteLine("Today is a " + num);
        break;
    case 7:
        Console.WriteLine("Today is a " + num);
        break;
    default: Console.WriteLine("Unreachable value");
        break;
}

*/
/*
Console.WriteLine("What's the tempurature outside: (C)");
double  d = Convert.ToDouble(Console.ReadLine());

if (d>=10 && d<=25)
{
    Console.WriteLine("It's warm outside");
}
else if (d<=-50 || d >= 50)
{
    Console.WriteLine("Do not go outside");
}
*/

/*
Console.WriteLine("Enter your name");
string name = Console.ReadLine();

while (name == "Sahib")
{
    Console.WriteLine("Entering to the site");

}
*/
/*
for (int i = 21; i > 0; i-=3)
{
    Console.WriteLine(i);
}
*/

/*
Console.Write("How many rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("How many columns ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("What symbol : ");
string character = Console.ReadLine();


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write(character);
    }
}
*/


// reqem texmin etmek

/*
Random random = new Random();

bool playagain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;

while (playagain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min , max+1);

    while (guess != number)
    {
        Console.WriteLine("Guess number between " + min + "-" + max + ":");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("guess" +guess);

        if (guess >number)
        {
            Console.WriteLine(guess + "too high");
        }
        else if (guess<number)
        {
            Console.WriteLine(guess + "too low");
        }
        guesses++;
    }
    Console.WriteLine("number :" + number);
    Console.WriteLine("You win");
    Console.WriteLine("guesses :" + guesses);
    Console.WriteLine("Would you like to play again (Y/N): ");
    response = Console.ReadLine();  
    response = response.ToUpper();

    if (response == "Y")
    {
        playagain = true;
    }
    else
    {
        playagain=false;    
    }

}
Console.WriteLine("Thaks for playing...");

*/

/*
Random random = new Random();
bool playagain = true;
string player;
string computer;

while (playagain)
{
    player = "";
    computer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER or SCISSORS :");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    Console.WriteLine(player);

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;

        case 3:
            computer = "SCISSORS";
            break;

    }

Console.WriteLine("Player: " + player);
Console.WriteLine("Computer: " + computer);

switch (player)
{
    case "ROCK":
        if (computer == "ROCK")
        {
            Console.WriteLine("It's a draw");
        }
        else if (computer == "PAPER")
        {
            Console.WriteLine("You are lost");
        }
        else
        {
            Console.WriteLine("You win");
        }
        break;

    case "PAPER":
        if (computer == "ROCK")
        {
            Console.WriteLine("You win");
        }
        else if (computer == "PAPER")
        {
            Console.WriteLine("It's a draw");
        }
        else
        {
            Console.WriteLine("You are lost");
        }
        break;

    case "SCISSORS":
        if (computer == "ROCK")
        {
            Console.WriteLine("You are lost");
        }
        else if (computer == "PAPER")
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("It's a draw");
        }
        break;


    }
}
*/

//calculator prog
/*
double num1 = 0;
double num2 = 0;
double result = 0;

Console.WriteLine("********************************");
Console.WriteLine(" \tCalculator program ");
Console.WriteLine("********************************");

Console.Write("Enter 1: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter 2: ");
num2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Enter an option: ");
Console.WriteLine("\t+ : Add");
Console.WriteLine("\t- : Minus");
Console.WriteLine("\t* : Multipy");
Console.WriteLine("\t/ : Divide");

switch (Console.ReadLine())
{
    case "+":
        result = num1 + num2; Console.WriteLine($"Result: {num1} + {num2} = " + result );
        break;
        case "-": result = num1 - num2; Console.WriteLine($"Result: {num1} - {num2} = " + result);
        break;
    case "*":
        result = num1 * num2; Console.WriteLine($"Result: {num1} * {num2} = " + result);
        break;
    case "/":
        result = num1 / num2; Console.WriteLine($"Result: {num1} / {num2} = " + result);
        break;
    default:
        Console.WriteLine("Invalid value");
        break;
}


*/

/*
string[] car = { "BMW", "MERCEDES", "VOLVO" };

for (int i = 0; i < car.Length; i++)
{
    Console.WriteLine(car[i]);
}
foreach (string cars in car)
{
    Console.WriteLine(cars);
}

*/

/*
string name = "Sahib";
int age = 26;
asanpay(name,age);


Console.ReadKey();
}

static void asanpay(string name, int age)
{
Console.Write($"salam {name} senin yasin {age}-ya beraberdir ");
}


*/


/*
static void mymethod()
{
    string name1 = "Saleh";
    string name2 = "Sahib";
    string name3 = "Ayten";
    int age1 = Convert.ToInt32(Console.ReadLine());
    int age2 = Convert.ToInt32(Console.ReadLine());
    int age3 = Convert.ToInt32(Console.ReadLine());

    if (age1>age2 && age1>age3 || age2>age3)
    {
        Console.WriteLine($"{name1} {name2} ve {name3}-den boyukdur");

    if (age2>age3)
        {
            Console.WriteLine($"{name2} {name3}-den boyukdur");
        }
        else if (age3>age2)
        {
            Console.WriteLine($"{name3} {name2}-den boyukdur");

        }
        else
        {
            Console.WriteLine($"{name1} {name3}-e beraberdir");

        }
    }
    else if (age2 > age1 && age2 > age3 || age1 > age3)
    {
        Console.WriteLine($"{name2} {name1} ve {name3}-den boyukdur");

        if (age1 > age3)
        {
            Console.WriteLine($"{name1} {name3}-den boyukdur");
        }
        else if (age3 > age1)
        {
            Console.WriteLine($"{name3} {name1}-den boyukdur");

        }
        else
        {
            Console.WriteLine($"{name1} {name3}-e beraberdir");

        }

    }
    else if (age3 > age1 && age3 > age2 || age1 > age2 )
    {
        Console.WriteLine($"{name3} {name1} ve {name2}-den boyukdur");

        if (age2 > age1)
        {
            Console.WriteLine($"{name2} {name1}-den boyukdur");
        }
        else if (age1 > age2)
        {
            Console.WriteLine($"{name1} {name2}-den boyukdur");

        }
        else
        {
            Console.WriteLine($"{name1} {name2}-e beraberdir");

        }

    }
*/

/*
double total =check(4.5, 4.6, 3.8);
Console.WriteLine(total);






static double check(params double[] prices)
{
double total = 0;
foreach (double price in prices)
{
    total += price;
}
return total;   
}


*/

/*
int a;
int b;
int c;


try
{
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = a / b;
    Console.WriteLine(c);
}
catch (FormatException e)
{
    Console.WriteLine("Enter valid value");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide to zero");
}
finally 
{
    Console.WriteLine("Thank you");
}



*/

/*
double tempurature = 21;
string message;



message = (tempurature>=15) ? "Warm outside" : "Cold outside";

Console.WriteLine(message);

*/
/*
string[] car1 = { "Volvo", "Bmw", "Vaz" };
string[] car2 = { "Mercedes", "Ford", "Cruzo" };
string[] car3 = { "Corolla", "Camry", "2107" };

string[,] park = { { "Volvo", "Bmw", "Vaz" },
    { "Mercedes", "Ford", "Cruzo" },{ "Corolla", "Camry", "2107" } };

park[0, 2] = "Fusion";
park[2, 0] = "Mazda";
/*
foreach (string car in park)
{
    Console.WriteLine(car);
}

*/
/*

for (int i = 0; i < park.GetLength(0); i++)
{
    for (int j = 0; j < park.GetLength(1); j++)
    {
        Console.Write(park[i,j] + " ");
    }
    Console.WriteLine();
}
*/


//CLASSES












