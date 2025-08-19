using System.Collections;
using Demoo.Data;
using static Demoo.ListGenerator;
namespace Demoo;

class Program
{
    static void Main(string[] args)
    {
        
        #region Demo

        #region 1] Implicitly Typed Local Variables [var , dynamic]

        // // var 
        //
        // var name = "mohamed"; // compiler detect data type based on init value [detect in compile time]
        // //var name; // invalid
        // // name = 10; // invalid 
        //
        // Console.WriteLine($"{name.GetType().Name}");
        //
        // for (var i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }
        //
        // // dynamic
        //
        // dynamic name1 = "mohamed"; // CLR detect data type based on last assigned val value [detect in run time]
        //
        // name1 = 10; // valid
        //
        //
        // // **********  Var vs Dynamic [Scope & Comparison]   *********** //


        
        
        
        #endregion
        
        #region 2] Extention Method [Reverse Number]

        // int num1 = 12345;
        // int res = IntExtentions.ReverseNumber(num1);
        // Console.WriteLine($"{res}");
        //
        // long num2 = 123456789;
        // long res2 = IntExtentions.ReverseNumber(num2);
        // Console.WriteLine($"{res2}");

        #endregion

        #region 3] Anonymous Types [Employee]

        // Employee emp1 = new Employee() { Id = 1, Name = "mohamed", Salary = 10000 };
        // Console.WriteLine($"{emp1.Name} {emp1.Salary}");
            
        // Anonymous Type 
        
        // var employee = new { Id = 1, Name = "mohamed", Salary = 10000 };
        // Console.WriteLine($" {employee.Id} {employee.Name} {employee.Salary}");
        
        // compiler change class of anonymous method based on : 
        // 1] Order of props
        // 2] Num of props 
        // 3] Name of props 
        
        //*************      Array ,ArrayList of Anonymous Type   ************ //
        
        
        // var students = new[]
        // {
        //     new { Id = 1, Name = "mohamed", Salary = 10000 },
        //     new { Id = 2, Name = "mohamed", Salary = 10000 },
        //     new { Id = 3, Name = "mohamed", Salary = 10000 }
        // };
        //
        // foreach (var student in students)
        //     Console.WriteLine($"{student.Id} {student.Name} {student.Salary}");
        // Console.WriteLine();


        // var students = new ArrayList()
        // {
        //     new { Id = 1, Name = "mohamed", Salary = 10000 },
        //     new { Id = 2, Name = "mohamed" },
        //     new { Id = 3 }
        // };
        //
        // foreach (var student in students)
        //     Console.WriteLine($"{student} ");
        // Console.WriteLine();
        
        // ***********   Anonymous initialized with predefined variables   ******** //
        
        // string country = "Egypt" , street = "Agouza";
        // var place = new
        // {
        //     country, street
        // };
        // Console.WriteLine($"{place}");
        //

        // var employee = new {Id = 1, Name = "mohamed", Salary = 10000};
        // Console.WriteLine($"{employee}");
        //
        // // var employee2 = new { Id = 100, employee.Name, employee.Salary }; // till c# 9.0
        //
        // var employee2 = employee with { Id = 100 }; // c# 10.0
        // Console.WriteLine($"{employee2}");
        //
        //
        

        #endregion

        #region 4] LINQ
 
        
        // // use linq operators agianst sequence 
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5};
        // List<int> evenNumbers = numbers.Where(x => x > 2).ToList();
        // foreach (var item in evenNumbers)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        


        #endregion

        #region 5] LINQ Syntax
        
        // ***********   Fluent/ Method Syntax   *********** //
        
        // var numbers = new List<int>() { 1, 2, 3, 4, 5};
        //  ********   Call linq op as static methods   ********* //
        
        // not recommended
        // Enumerable.Where(numbers, x => (x & 1) == 0).ToList().ForEach(x => Console.WriteLine($"{x} "));
        //
        // var evenNumbers = numbers.Where(x => (x & 1) == 0).ToList();
        // foreach (var item in evenNumbers)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        // ***********    Query Syntax - [Like sql server style]    *********** //
        
        // when u create complex query [join - groupBy] like sql queries
        /*
         * select *
         * from numbers n
         * where n % 2 = 0
         */
        
        // Execution Order ==> 1]From  2]Where 3]Select
        // Query Syntax ==> must start with from, must end with select or groupBy 
        
        // var evenNumbers = from n in numbers
        //                        where n % 2 == 0
        //                            select n;
        // foreach (var item in evenNumbers)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        // ***********    Hybird Syntax  *********** //
                            
          // #######   Query Syntax + Fluent Syntax  ######## //
        
          
          
        
        #endregion

        #region 6] LINQ Execution Way 
        
        //1] Executed Deffered or lazy execution 
        
        // Where --> Deffered [Lazy linq op]
        
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //
        // var oddNumbers = numbers.Where(x => x % 2 == 1);
        // numbers.AddRange(Enumerable.Range(11, 5));
        //
        // foreach (var item in oddNumbers)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        // 2] ***********   Executed Immetidate or greedy execution   *********** //
        
        // 1] Aggregate op , 2] Element op  3] Casting op 
        
        // List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        // var oddNumbers = numbers.Where(x => x % 2 == 1).ToList();
        // numbers.AddRange(Enumerable.Range(11, 5));
        // foreach (var item in oddNumbers)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        #endregion

        #region 7] Data Setup
        
        // Console.WriteLine(ProductList[0]);
        // Console.WriteLine(ProductList[1]);
        // Console.WriteLine(ProductList[2]);

        #endregion

        #region 8] Filteration / Restriction operator (Where) [Deffered] 
        
        // // *********** Get Products out of stock  ********** //
        //
        // // ***** Fluent synatx
        //
        // var res = ProductList.Where(p => p.UnitsInStock == 0);
        //
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        //
        // // ********   Query Syntax
        //
        // res = from p in ProductList
        //     where p.UnitsInStock == 0
        //         select p;
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        // *****     Get Product in stock and their Category SeaFood   ****** //
        
        // // ****   Fluent Syntax
        // var res = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Seafood");
        // // res = Enumerable.Where(ProductList , p => p.UnitsInStock > 0 && p.Category == "Seafood" );   // not recomended
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // // ****   Query Syntax        
        // res = from p in ProductList
        //     where (p.UnitsInStock > 0 && p.Category == "Seafood")
        //         select p;
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        
        // ****   Indexed Where  
        // **** Get products out of stock in first 10 elements 
        
        // *** Fluent Synatx
        // var res = ProductList.Where((p, i) => i < 10 && p.UnitsInStock > 0);
        
        
        #endregion

        #region 9] Transformation / Projection operator (Select - Select Many) [Deffered] 

        // *****   Select Product Name 
        // *** Fluent Syntax
        
        // var res = ProductList.Select(p => p.ProductName);
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // // *** Query Syntax
        //
        // res = from p in ProductList
        //     select p.ProductName;
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        //
        // // Select Customer Orders 
        // // Fluent Syntax 
        //
        // var result = CustomerList.SelectMany(c => c.Orders);
        // foreach (var item in result)
        //     Console.WriteLine($"{item} ");  
        // Console.WriteLine();
        //
        // // Query Syntax 
        //
        // result = from c in CustomerList
        //     from o in c.Orders
        //     select o;
        //
        // foreach (var item in result)
        //     Console.WriteLine($"{item} ");  
        // Console.WriteLine();
        
        
        // // Select product id and product name
        //
        // // *** Fluent Syntax
        // var ans = ProductList.Select(p => new  { p.ProductID,  p.ProductName}  );
        // foreach (var item in ans)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // // *** Query Syntax 
        //
        // ans = from p in ProductList
        //     select new  { p.ProductID,  p.ProductName}  ;  // Anonymous Type
        // foreach (var item in ans)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        
        // *** Select product idx and product name for products in stock *** //
        // Indexed Select , Indexed Where ==> valid only with fluent Syntax  
        
        // var res = ProductList.Where(p => p.UnitsInStock > 0)
        //     .Select((p, i) => new { i, p.ProductName });  // Anonymous Type --> used only one time
        // foreach (var item in res)
        //     Console.WriteLine($"{item.i} {item.ProductName}");  
        // Console.WriteLine();
        
        
        #endregion

        #region 10] Ordering operator (Order - Order Desc - Order By - Order By Desc - Then By - Then By Desc) [Deffered] 

        // var res = ProductList.Order(); // Exception --> must implement IComparable 
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        // ************     1] Get Products Ordered By Price asc      ************
        // // Fluent Syntax
        //
        // var res = ProductList.OrderBy(p => p.UnitPrice);
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // res = ProductList.OrderByDescending(p => p.UnitPrice);
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // // Query Syntax
        //
        // res = from p in ProductList
        //     orderby p.UnitPrice
        //         select p;
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // res = from p in ProductList
        //     orderby p.UnitPrice descending
        //         select p;
        //
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        
        
        // Reverse ==> is only valid with fluent syntax
        
        // // ************   2] Get Products Ordered By Price Asc and Order By Num of Item in stock Desc   **********
        //
        // // var res2 = ProductList.OrderBy(p => p.UnitPrice).OrderByDescending(p => p.UnitsInStock);
        // //
        // // // Sort based on unitprice 
        // // // sort desc based on unit in stock 
        //
        // // Fluent Syntax
        //
        // var res2 = ProductList.OrderBy(p => p.UnitPrice).ThenByDescending(p => p.UnitsInStock);
        //
        // foreach (var item in res2)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        // // Query Syntax
        //
        // res2 = from p in ProductList
        //     orderby p.UnitPrice , p.UnitsInStock descending  // then by desc
        //         select p;
        //
        // foreach (var item in res2)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        
        
        // 3] Get Products Out of stock in Reversed Order 
        
        // // not have way to implement with Query Syntax 
        // // only by Fluent Syntax
        //
        //
        // var res = ProductList.Where(p => p.UnitsInStock == 0).Reverse();
        // foreach (var item in res)
        //     Console.WriteLine($"{item} ");
        // Console.WriteLine();
        //
        

        #endregion

        #region 11] Element Operators [First , Last , Single , SingleOrDefault , ElementAt , ElementAtOrDefault] [Deffered] 
        
        // var firstProduct = ProductList.First();
        // Console.WriteLine($"{firstProduct}");
        // var lastProduct = ProductList.Last();
        // Console.WriteLine($"{lastProduct}");
        // var singleProduct = ProductList.Single();
        // Console.WriteLine($"{singleProduct}");
        //
        // First, Last --> throw Exception if the Sequence is empty 

        // firstProduct = ProductList.FirstOrDefault();
        // Console.WriteLine($"{firstProduct? .ProductName ?? "N/A"}");
        // lastProduct = ProductList.LastOrDefault();
        // Console.WriteLine($"{lastProduct? .ProductName ?? "N/A"}");
        //
        // var firstElement = ProductList.FirstOrDefault(p => p.ProductID == 10);
        // Console.WriteLine($"{firstElement?.ProductName ?? "N/A"}");
        //
        // var lastElement = ProductList.LastOrDefault(p => p.ProductID == 10);
        // Console.WriteLine($"{lastElement?.ProductName ?? "N/A"}");
        //
        // // ********   Element At - ElementAtOrDefault   ******** //
        //
        // // Find Product at index 0, 100 
        //
        // var productAt0 = ProductList.ElementAt(0);
        // Console.WriteLine($"{productAt0?.ProductName ?? "N/A"}");
        // var productAt100 = ProductList.ElementAtOrDefault(100);
        // Console.WriteLine($"{productAt100?.ProductName ?? "N/A"}");
        
        
        // Element At --> will throw exception in case working with empty sequence 
        
        // Element At Or Default --> will return the defualt val in case working with empty sequence 

        // var res = ProductList.ElementAt(new Index(10 , true)); // idx 10 from end
        // Console.WriteLine($"{res?.ProductName ?? "N/A"}");
        // var res2 = ProductList.ElementAt(new Index(10 , false)); // idx 10 from start
        // Console.WriteLine($"{res2?.ProductName ?? "N/A"}");
        //
        // // new index --> appear in c# 8.0 with .Net 3.0
        //
        // res = ProductList.ElementAtOrDefault(^10); // idx 10 from end
        // Console.WriteLine($"{res?.ProductName ?? "N/A"}");
        // res2 = ProductList.ElementAtOrDefault(10); // idx 10 from start
        // Console.WriteLine($"{res2?.ProductName ?? "N/A"}");
        //
        // // ^ ==> not Xor bitwise op is just operator overload 
        //
        // // Single ==> can work with seq with one Element, Seq contains more than 1 Element, Empty Seq: throw Ex   
        //
        // var res3 = ProductList.Single();
        // Console.WriteLine($"{res3?.ProductName ?? "N/A"}");
        //
        // var res4 = ProductList.SingleOrDefault();
        // Console.WriteLine($"{res4?.ProductName ?? "N/A"}");
        //
        // // Single Or Default ==> can work with seq with one Element, Seq contains more than 1 Element: throw Ex
        //
        // var res5 = ProductList.Single(p => p.ProductID == 10);  // if exist exactly 1 Element that match this predicate
        // Console.WriteLine($"{res5?.ProductName ?? "N/A"}");
        //
        //
        // var res6 = ProductList.SingleOrDefault(p => p.ProductID == 10 , new (){ProductID = 100, ProductName = "test"});  // if exist exactly 1 Element that match this predicate
        // Console.WriteLine($"{res6?.ProductName ?? "N/A"}");
        //
        //
        // // ******   Find First product that has id = 10   ******* // 
        // // ******   FirstOrDefault , Single Or Default    ******* //
        //
        // var res7 = ProductList.FirstOrDefault(p => p.ProductID == 10);  // Top 1
        // Console.WriteLine($"{res7?.ProductName ?? "N/A"}");     
        //
        // var res8 = ProductList.SingleOrDefault(p => p.ProductID == 10);  // Top 2 --> to ensure that not exist any other element in collection that match predicate
        // Console.WriteLine($"{res8?.ProductName ?? "N/A"}");
        //
        //
        // // Elements Operators only valid with the Fluent syntax 
        // // *******   Hybird Syntax  = Fluent + Query   ******** //
        // // ****    Find First Element out of stock        **** //
        //
        // var res9 = (from p in ProductList
        //     where p.UnitsInStock == 0
        //         select p).FirstOrDefault();
        //
        // Console.WriteLine($"{res9}");

        
        #endregion

        #endregion
    }
}