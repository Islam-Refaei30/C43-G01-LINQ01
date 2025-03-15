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
			//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			//var filteredReversedArr = Arr
			//	.Where(word => word.Length > 1 && word[1] == 'i')
			//	.Reverse();


			// filteredReversedArr = (from word in Arr
			//						where word.Length > 1 && word[1] == 'i'
			//						select word).Reverse();

			//foreach (var word in filteredReversedArr)
			//{
			//	Console.WriteLine(word);
			//}

			#endregion
			#endregion

			#region LINQ – Transformation Operators
			#region 1. Return a sequence of just the names of a list of products.
			////
			//var result = ProductList.Select(P => new
			//{
			//	P.ProductName
			//});

			////
			//result = from P in ProductList
			//		 select new { P.ProductName };
			#endregion
			#region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
			//string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
			//var result = words.Select(word => new
			//{
			//	Upper = word.ToUpper(),
			//	Lower = word.ToLower()
			//});


			//result = from word in words
			//		select new
			//		{
			//		 Upper = word.ToUpper(),
			//		 Lower = word.ToLower()
			//		};

			//foreach (var item in result)
			//{
			//	Console.WriteLine(item.Upper);
			//	Console.WriteLine(item.Lower);
			//}
			#endregion
			#region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
			////
			//var result = ProductList.Select(P => new
			//{
			//	ID = P.ProductID,
			//	Price = P.UnitPrice,
			//	Name = P.ProductName
			//});

			////
			//result = from P in ProductList
			//		 select new 
			//		 {
			//			 ID = P.ProductID,
			//			 Price = P.UnitPrice,
			//			 Name = P.ProductName
			//		 };
			#endregion
			#region 4. Determine if the value of ints in an array match their position in the array.
			//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			////var result = Arr.Select((Value, Index) => new { Value, Index }).Where(item => item.Value == item.Index);
			//var result = Arr.Select((value, index) => new { Number = value, InPlace = value == index });

			#endregion
			#region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
			//int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
			//int[] numbersB = { 1, 3, 5, 7, 8 };

			//var result = numbersA.SelectMany(a => numbersB.Where(b => a < b), (a, b) => $"{a} is less than {b}");


			//result = from a in numbersA
			//		 from b in numbersB
			//		 where a < b
			//		 select $"{a} is less than {b}";
			#endregion
			#region 6. Select all orders where the order total is less than 500.00.
			////
			//var result = CustomerList.SelectMany(O => O.Orders).Where(T => T.Total < 500.00M);

			////
			//result = from O in CustomerList
			//		 from T in O.Orders
			//		 where T.Total < 500.00M
			//		 select T;
			#endregion
			#region 7. Select all orders where the order was made in 1998 or later.
			//
			var result = CustomerList.SelectMany(O => O.Orders).Where(T => T.OrderDate.Year >= 1998);

			//
			result = from O in CustomerList
					 from T in O.Orders
					 where T.OrderDate.Year >= 1998
					 select T;
			#endregion

			#endregion


			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
