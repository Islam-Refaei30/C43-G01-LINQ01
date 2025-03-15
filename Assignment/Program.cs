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
			//Fluent Syntax
			var result = ProductList.Where(P => P.ProductName.Length < P.ProductID);

			//Query Syntax
			result = from P in ProductList
					 where P.ProductName.Length < P.ProductID
					 select P;
			#endregion

			#endregion


			foreach (var unit in result)
			{
				Console.WriteLine(unit);
			}
		}
	}
}
