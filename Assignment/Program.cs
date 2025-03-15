using static Assignment.ListGenerator;
namespace Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("test Push Assignment");
			//Console.WriteLine(ListGenerator.ProductList[0]);
			//Console.WriteLine(ListGenerator.CustomerList[0]);
			#region LINQ - Restriction Operators

			#region 1. Find all products that are out of stock.
			////fluent syntax
			//var result = ProductList.Where(P => P.UnitsInStock < 1);

			////Query Syntax
			//result = from P in ProductList
			//		 where P.UnitsInStock < 1
			//		 select P;
			#endregion
			#region 2. Find all products that are in stock and cost more than 3.00 per unit
			////Fluent Syntax
			//var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);

			////Query Syntax
			//result = from P in ProductList
			//		 where P.UnitsInStock > 0 && P.UnitPrice > 3.00M
			//		 select P;
			#endregion
			#region 3. Returns digits whose name is shorter than their value.
			//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			//var result = Arr.Where((word, index) => word.Length < index);

			//foreach (var word in result)
			//{
			//	Console.WriteLine(word);
			//}
			#endregion

			#endregion

			#region LINQ - Ordering Operators
			#region 1. Sort a list of products by name
			////Fluent Syntax
			//var result = ProductList.OrderBy(P => P.ProductName);

			////Query Syntax
			//result = from P in ProductList
			//		 orderby P.ProductName
			//		 select P;
			#endregion
			#region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
			//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

			//var sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

			//foreach (var word in sortedArr)
			//{
			//	Console.WriteLine(word);
			//}
			#endregion
			#region 3. Sort a list of products by units in stock from highest to lowest.
			////Fluent Syntax
			//var result = ProductList.OrderByDescending(P => P.UnitsInStock);

			////Query Syntax
			//result = from P in ProductList
			//		 orderby P.UnitsInStock descending
			//		 select P;
			#endregion
			#region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
			//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			//var sortedArr = Arr.OrderBy(N => N.Length).ThenBy(N => N);
			//foreach (var word in sortedArr)
			//{
			//	Console.WriteLine(word);
			//}
			#endregion
			#region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
			//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

			//var SortedWords = words.OrderBy(W => W.Length).ThenBy(W => W, StringComparer.OrdinalIgnoreCase);

			//foreach (var word in SortedWords)
			//{
			//	Console.WriteLine(word);
			//}
			#endregion
			#region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
			////Fluent Syntax
			//var result = ProductList.OrderByDescending(P => P.Category).ThenBy(P => P.UnitPrice);

			////Query Syntaxz
			//result = from p in ProductList
			//		 orderby p.Category, p.UnitPrice descending
			//		 select p;
			#endregion
			#region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
			//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			//var SortedArr = Arr.OrderBy(W => W.Length).ThenByDescending(W => W, StringComparer.OrdinalIgnoreCase);

			//foreach (var word in SortedArr)
			//{
			//	Console.WriteLine(word);
			//}
			#endregion
			#region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
			string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			var filteredReversedArr = Arr
				.Where(word => word.Length > 1 && word[1] == 'i')
				.Reverse();


			 filteredReversedArr = (from word in Arr
									where word.Length > 1 && word[1] == 'i'
									select word).Reverse();

			foreach (var word in filteredReversedArr)
			{
				Console.WriteLine(word);
			}

			#endregion
			#endregion


			//foreach (var unit in result)
			//{
			//	Console.WriteLine(unit);
			//}
		}
	}
}
