namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = "202403958";
            int firstNumber = int.Parse(id[0].ToString());
            int lastNumber = int.Parse(id[id.Length - 1].ToString());
            Console.WriteLine(Sum(firstNumber, lastNumber));
        }

        static int Sum(int x, int y)
        {
            return x + y;
        } 
    }
}