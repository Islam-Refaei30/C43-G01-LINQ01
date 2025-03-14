namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Part 03 What Is Linq
			//Console.WriteLine("test Push Demo");

			//         List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 5, 4 };
			//         List<int> Odd = numbers.Where((N) => N % 2 == 1).ToList(); //LinQ Orerator

			//         foreach (int n in Odd)
			//         {
			//             Console.WriteLine(n);
			//         } 
			#endregion

			#region Part 04 Linq Syntax
			List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 5, 4 };
			#region Fluent Syntax
			
			// 1-call "LinQ Operator" as static method throgh (Enumrable class)
			List<int> OddNumbers = Enumerable.Where(Numbers, (N) => N % 2 == 1).ToList();


			// 2-call "LinQ Operator" as extention method
			List<int> OddNumbers2 = Numbers.Where((N) => N % 2 == 1).ToList();


			#endregion
			#region Query Syntax (Experssion)
			// Query Syntax : Query Experssion : Like sql server style
			/*
			 *Select
			 *From Numbers N
			 *Where N%2==1
			 */
			var OddNumbers3 = from N in Numbers
							  where N % 2 == 1
							  select N;

			#endregion
			foreach (int n in OddNumbers3)
			{
				Console.WriteLine(n);
			}
			#endregion
		}
	}
}
