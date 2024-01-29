// See https://aka.ms/new-console-template for more information
Console.Write("Enter Number 1 : ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Number 2 : ");
int number_2 = Convert.ToInt32(Console.ReadLine());


for (int number = number_1; number <= number_2; number++)
{
    string check = "";
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            check = "error";
        }
    }
    if (check == "")
    {
        Console.WriteLine(number);
    }
    
}



