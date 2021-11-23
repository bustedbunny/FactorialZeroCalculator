Console.WriteLine("Enter number of factorial.");
string input = Console.ReadLine();
int N = 0;
try
{
    N = Int32.Parse(input);
}
catch (Exception ex)
{
    Console.WriteLine("Input is not valid number: " + input);
    return;
}
int num = 0;
while (N > 0)
{
    N /= 5;
    num += N;
}
Console.WriteLine(num);
