namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Part 03 What Is Linq
			Console.WriteLine("test Push Demo");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 5, 4 };
            List<int> Odd = numbers.Where((N) => N % 2 == 1).ToList(); //LinQ Orerator

            foreach (int n in Odd)
            {
                Console.WriteLine(n);
            } 
            #endregion
        }
    }
}
