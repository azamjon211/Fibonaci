internal class Program
{
    private static void Main(string[] args)
    {
     Console.WriteLine("Hi everyone Welcome to my program ");
string input = "";
int num = 0;

do
{
    Console.WriteLine(" \nchoose your task ");
    Console.Write("1. Finding out Fibonaci numbers  or  2. check out for Prime numbers : ");
    
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            {
                Console.Write("N :");
                num = Convert.ToInt32(Console.ReadLine());
                Fibonaci(num);
            }
            break;
        case "2":
            {
                Console.Write("N:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(isPrime(num));

            }
            break;

    }

} while (input != "3");


    }

    static void Fibonaci(int n)
{
    int[] nums = new int[n];
    nums[0] = 0;
    nums[1] = 1;
    for (int i = 2; i < n; i++)
    {
        nums[i] = nums[i - 1] + nums[i - 2];
    }
    foreach (int num in nums)
    {
        Console.Write(num + " ");
    }

}
static bool isPrime(int n)
{
   if(n <= 1) return false;
   for(int i =2; i<=n/2; i++)
   {
    if( n % i == 0 ) return false;
   }
   return true; 
}
}