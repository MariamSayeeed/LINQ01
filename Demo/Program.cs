using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee E01 = new Employee() { Id = 1, Name = "Mariam", Salary = 12000 };
            //Employee E02 = new Employee() { Id = 1, Name = "Mariam", Salary = 12000 };

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //Console.WriteLine(E01.Equals(E02));

            #region Implicitly Typed Local Variable[var , dynamic]
            //var name = "Ahmed";//2021 .net 6  , c# 10 => 
            ////C# => Strongly Typed
            ////Compiler will Detect the Type of Variable Based on it's Initial Value at Compile Time
            ////Must Be Initialized 
            ////Can't Assign Null Value (Inialization)
            ////After Inialization , U Can't Change Variable Datatype
            ////Console.WriteLine(name.);

            //dynamic x = null;
            //x = 5;
            //x = "Ahmed";
            //CLR Will Detect the type of Variable Based on Last value at Runtime
            //Not Must be Inailization
            //Can Be Assign with null value (Inialization)
            //After Inialization , U Can Change Variable Datatype
            //Console.WriteLine(x.Hamada());
            #endregion

            #region Anonymous Types
            //Anonymous Functions => 1 Time 
            //Anonymous Type => 1 Time per application life time 
            //Employee employee = new Employee() { Id = 1,Name = "Ahmed",Salary = 5000,Age = 25};
            //var emp1 = new  { Name = "Ahmed", Salary = 5000, Age = 25 };
            //var emp2 = emp1 with { Salary = 8000 };

            //new { emp1.Name, emp1.Salary, emp1.Age };

            // Immutable => Can't Change After Creation
            //The Same Anonymous Type As long as 
            //1) the  same prop Name [Case Sens ]
            //2) the same prop Order 
            // var Product = new { ProductId = 1, ProductName = "Meat" };
            //Console.WriteLine(emp1.GetType().Name);
            //Console.WriteLine(emp2.GetType().Name);
            #endregion

            #region Extention Methods
            // إضافة => أضيف دالة لنوع int 
            // int x = 12345;

            // x.Reverse();
            //Console.WriteLine(x);
            #endregion

            #region What is LINQ
            //LINQ => Language Integreted Query 
            //SQL [DQL] => Select 
            //LINQ: +40 Extention Methods => Collection that Implement Interface "IEnumrable"
            //Methods Implementation Class "Enumrable"
            // 13 Category
            //Linq Operators

            //List<int> Numbers = Enumerable.Range(0,100).ToList();
            //Numbers.Where(c => c % 2 == 1);//FindAll
            //List<int> nums = new List<int>() { 1,2,3,4,5,6,7,8,9};
            //you can use LinQ Operators againest Data [Sorted in Sequance]
            //Sequance: Object from Any Class Implement Interface 'IEnumrable'
            //Regardless DataSource(MySQL,sql Server)
            //1) Local Sequance => L2O || XML Data L2xml
            //2) Remote Sequance => L2EF
            #endregion

            #region LINQ Syntax [Fluent Syntax, Query Syntax]
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region Fluent Syntax
            //1) Call LinQ Functions as Static Methods through Enumrable
            //var OddNumbers = Enumerable.Where(Numbers, num => num % 2 == 1);
            //foreach (int num in OddNumbers)
            //    Console.WriteLine(num);

            //2)Call Linq Functions as Extention Methods Sequance [Recommended]
            //var OddNumbers  = Numbers.Where(x=>x %2 ==1);
            //foreach(int number in OddNumbers)
            //    Console.WriteLine(number);
            #endregion
            #region Query Syntax
            //select Num 
            //from Numbers
            //Where Num % 2 == 1
            //---------Execution Order------------------
            //Must Begin With [From] KeyWord => Reperesent Each Element at Sequance
            //End With Select Keyword or Groupby KeyWord
            //var OddNumbers = from Num in Numbers
            //                 where Num % 2 == 1
            //                 select Num;

            //foreach (var Num in OddNumbers)
            //    Console.WriteLine(Num);
            #endregion
            #endregion

            #region LINQ Execution Ways [Differd / Immediate]
            //10 Categories => Differd Execution
            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            #region Differed Execution
            ////var EvenNumbers = Numbers.Where(N=>N %2 ==0);

            ////Numbers.AddRange(new List<int>() { 11, 12, 13, 14, 15 });

            ////foreach(int n in EvenNumbers)
            ////    Console.WriteLine(n);// 2 4 6 8 10 
            #endregion

            #region Immediate Execution => Element Operators / Casting Operators / Aggregate Operator
            // var EvenNumbers = Numbers.Where(N => N % 2 == 0).ToList();
            //Numbers.AddRange(new List<int>() { 11, 12, 13, 14, 15 });
            // foreach(var num in EvenNumbers)
            //     Console.WriteLine(num);
            #endregion
            #endregion

            #region Data Setup


            Console.WriteLine(ProductList[0]);
            Console.WriteLine(CustomerList[0]);
            //foreach (var Product in ProductList)
            // {
            //     Console.WriteLine(Product);
            // }
            //foreach(var Customer in CustomerList)
            // {
            //     Console.WriteLine($"{Customer}  \n");
            // }
            #endregion


        }
    }
}
