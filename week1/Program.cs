
// Task 1 
int a = 9000;
bool b;

if (a >= 1000 && a <= 9999 && (a % 3 == 0 || a % 7 == 0))
{
    b = true;
}
else
{
    b = false;
}

Console.WriteLine(b);


// Task 2

String name = "Bilqeyis";

if (name == "Bilqeyis")
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


// Task 3

Console.Write("Please enter the number: ");

var c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(c % 10);