using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Problem01
            Employee[] employeesP1 = new Employee[]
            {
                new Employee(1, "Alice", 75000m),
                new Employee(2, "Bob", 50000m),
                new Employee(3, "Charlie", 90000m),
                new Employee(4, "Dave", 60000m)
            };

            Console.WriteLine("Original Employees:");
            foreach (var emp in employeesP1)
                Console.WriteLine(emp);

            SortingAlgorithm<Employee>.Sort(employeesP1);

            Console.WriteLine("\nSorted Employees by Salary (Ascending):");
            foreach (var emp in employeesP1)
                Console.WriteLine(emp);
            #endregion

            #region Question01
            /*
             * Question: What are the benefits of using a generic sorting algorithm over a non-generic one?
             * Answer:
             * 1. Type Safety: Catch type mismatch errors at compile-time rather than throwing runtime exceptions (e.g., InvalidCastException).
             * 2. Performance (No Boxing/Unboxing): Avoids boxing value types (like int, double, structs) to object and unboxing them back, reducing memory overhead and improving execution speed.
             * 3. Code Reusability: A single generic sorting method can handle any data type without duplicating code or writing type-specific sort methods.
             */
            #endregion

            #region Problem02
            int[] numbersP2 = new int[] { 15, 3, 42, 8, 23, 4 };

            Console.WriteLine("Original Integers: " + string.Join(", ", numbersP2));

            SortingTwo<int>.Sort(numbersP2, (a, b) => a < b);

            Console.WriteLine("Sorted Integers (Descending via Lambda): " + string.Join(", ", numbersP2));
            #endregion

            #region Question02
            /*
             * Question: How do lambda expressions improve the readability and flexibility of sorting methods?
             * Answer:
             * 1. Readability: Eliminates boilerplate delegate syntax and separate method declarations, allowing concise inline logic (e.g., (a, b) => a < b).
             * 2. Flexibility: Enables dynamic sorting criteria directly at the call site without needing to modify the sorting class or declare separate comparison functions.
             */
            #endregion

            #region Problem03
            string[] wordsP3 = new string[] { "Elephant", "Cat", "Hippopotamus", "Dog", "Giraffe" };

            Console.WriteLine("Original Strings: " + string.Join(", ", wordsP3));

            SortingTwo<string>.Sort(wordsP3, (s1, s2) => s1.Length > s2.Length);

            Console.WriteLine("Sorted Strings by Length (Ascending): " + string.Join(", ", wordsP3));
            #endregion

            #region Question03
            /*
             * Question: Why is it important to use a dynamic comparer function when sorting objects of various data types?
             * Answer:
             * 1. Decoupling: Separates the sorting mechanism from specific domain properties or hardcoded object rules.
             * 2. Adaptability: Allows sorting the same objects by different criteria (e.g., strings by length vs alphabetically, employees by salary vs name) depending on application context.
             */
            #endregion

            #region Problem04
            Manager[] managersP4 = new Manager[]
            {
                new Manager(101, "Sarah", 120000m, "IT"),
                new Manager(102, "Michael", 95000m, "HR"),
                new Manager(103, "Emily", 150000m, "Executive")
            };

            Console.WriteLine("Original Managers:");
            foreach (var mgr in managersP4)
                Console.WriteLine(mgr);

            SortingAlgorithm<Manager>.Sort(managersP4);

            Console.WriteLine("\nSorted Managers by Salary (Ascending):");
            foreach (var mgr in managersP4)
                Console.WriteLine(mgr);
            #endregion

            #region Question04
            /*
             * Question: How does implementing IComparable<T> in derived classes enable custom sorting?
             * Answer:
             * 1. Defines Natural Sort Order: Allows derived classes to specify their own type-safe comparison logic tailored to their attributes.
             * 2. Polymorphic Behavior: Derived objects can be sorted cleanly using generic sorting routines without requiring explicit delegates.
             */
            #endregion

            #region Problem05
            Employee[] employeesP5 = new Employee[]
            {
                new Employee(1, "Christopher", 70000m),
                new Employee(2, "Ana", 80000m),
                new Employee(3, "Alexander", 65000m),
                new Employee(4, "Jo", 75000m)
            };

            Func<Employee, Employee, bool> compareByNameLength = (e1, e2) => e1.Name.Length > e2.Name.Length;

            Console.WriteLine("Original Employees:");
            foreach (var emp in employeesP5)
                Console.WriteLine(emp);

            SortingTwo<Employee>.Sort(employeesP5, compareByNameLength);

            Console.WriteLine("\nSorted Employees by Name Length (Ascending):");
            foreach (var emp in employeesP5)
                Console.WriteLine(emp);
            #endregion

            #region Question05
            /*
             * Question: What is the advantage of using built-in delegates like Func<T, T, TResult> in generic programming?
             * Answer:
             * 1. Standardization: Provides a consistent delegate signature across .NET libraries without cluttering code with custom delegate definitions.
             * 2. Interoperability: Integrates seamlessly with LINQ, collections, and modern C# API frameworks.
             */
            #endregion

            #region Problem06
            int[] arrAnonymous = new int[] { 34, 12, 5, 89, 1 };
            int[] arrLambda = new int[] { 34, 12, 5, 89, 1 };

            Func<int, int, bool> anonymousSort = delegate(int a, int b) { return a > b; };
            SortingTwo<int>.Sort(arrAnonymous, anonymousSort);
            Console.WriteLine("Sorted using Anonymous Function: " + string.Join(", ", arrAnonymous));

            Func<int, int, bool> lambdaSort = (a, b) => a > b;
            SortingTwo<int>.Sort(arrLambda, lambdaSort);
            Console.WriteLine("Sorted using Lambda Expression:  " + string.Join(", ", arrLambda));
            #endregion

            #region Question06
            /*
             * Question: How does the usage of anonymous functions differ from lambda expressions in terms of readability and efficiency?
             * Answer:
             * 1. Readability: Lambda expressions offer a cleaner, more concise syntax ((a, b) => a > b) compared to anonymous methods (delegate(int a, int b) { return a > b; }).
             * 2. Efficiency: Both compile down to compiler-generated methods or delegates at runtime, but lambda expressions can also be transformed into Expression Trees for dynamic querying (e.g., LINQ to SQL), which anonymous methods cannot.
             */
            #endregion

            #region Problem07
            int[] numbersP7 = new int[] { 100, 200, 300 };

            Console.WriteLine($"Before Swap: Index 0 = {numbersP7[0]}, Index 1 = {numbersP7[1]}");
            SortingAlgorithm.Swap(ref numbersP7[0], ref numbersP7[1]);
            Console.WriteLine($"After Swap via ref: Index 0 = {numbersP7[0]}, Index 1 = {numbersP7[1]}");

            SortingAlgorithm.Swap(numbersP7, 1, 2);
            Console.WriteLine($"After Swap via Array Indices (1 & 2): " + string.Join(", ", numbersP7));
            #endregion

            #region Question07
            /*
             * Question: Why is the use of generic methods beneficial when creating utility functions like Swap?
             * Answer:
             * 1. Type Safety: Ensures both swap operands match in type at compile time.
             * 2. Reusability: Operates on any type (value or reference) without requiring separate implementations.
             * 3. Zero Boxing: Keeps performance high by avoiding memory allocations when swapping value types.
             */
            #endregion

            #region Problem08
            Employee[] employeesP8 = new Employee[]
            {
                new Employee(1, "Bob", 60000m),
                new Employee(2, "Alice", 80000m),
                new Employee(3, "Charlie", 60000m),
                new Employee(4, "Adam", 60000m)
            };

            Console.WriteLine("Original Employees:");
            foreach (var emp in employeesP8)
                Console.WriteLine(emp);

            Func<Employee, Employee, int> multiCriteriaComparer = (e1, e2) =>
            {
                int salaryComparison = e1.Salary.CompareTo(e2.Salary);
                if (salaryComparison != 0)
                    return salaryComparison;
                return string.Compare(e1.Name, e2.Name, StringComparison.Ordinal);
            };

            SortingTwo<Employee>.Sort(employeesP8, multiCriteriaComparer);

            Console.WriteLine("\nSorted Employees (Salary Ascending, then Name Ascending):");
            foreach (var emp in employeesP8)
                Console.WriteLine(emp);
            #endregion

            #region Question08
            /*
             * Question: What are the challenges and benefits of implementing multi-criteria sorting logic in generic methods?
             * Answer:
             * 1. Benefits: Supports realistic business sorting requirements (e.g., sorting by primary key then tie-breaking by secondary key) cleanly.
             * 2. Challenges: Increasing code complexity when handling multiple fallback comparisons, ensuring stable tie-breaking, and avoiding performance bottlenecks from nested evaluations.
             */
            #endregion

            #region Problem09
            Console.WriteLine($"Default int: {GetDefault<int>()}");
            Console.WriteLine($"Default bool: {GetDefault<bool>()}");
            Console.WriteLine($"Default string: {(GetDefault<string>() == null ? "null" : GetDefault<string>())}");
            Console.WriteLine($"Default Employee: {(GetDefault<Employee>() == null ? "null" : GetDefault<Employee>())}");
            #endregion

            #region Question09
            /*
             * Question: Why is the default(T) keyword crucial in generic programming, and how does it handle value and reference types differently?
             * Answer:
             * 1. Crucial Role: Allows initializing variables of a generic type T safely when the underlying type (value vs reference) is unknown at compile time.
             * 2. Value vs Reference Handling: Returns null for reference types, and zero-initialized bit patterns (e.g., 0, false, empty struct) for value types.
             */
            #endregion

            #region Problem10
            Employee[] employeesP10 = new Employee[]
            {
                new Employee(1, "Zoe", 90000m),
                new Employee(2, "Aaron", 45000m),
                new Employee(3, "Brian", 70000m)
            };

            Console.WriteLine("Original Array:");
            foreach (var emp in employeesP10)
                Console.WriteLine(emp);

            Employee[] clonedEmployees = CloneEmployeeArray(employeesP10);
            SortingAlgorithm<Employee>.Sort(clonedEmployees);

            Console.WriteLine("\nCloned & Sorted Array:");
            foreach (var emp in clonedEmployees)
                Console.WriteLine(emp);

            Console.WriteLine("\nOriginal Array Remains Unchanged:");
            foreach (var emp in employeesP10)
                Console.WriteLine(emp);
            #endregion

            #region Question10
            /*
             * Question: How do constraints in generic programming ensure type safety and improve the reliability of generic methods?
             * Answer:
             * 1. Compile-Time Safety: Guarantees that generic type parameters satisfy required interfaces (e.g., ICloneable, IComparable<T>), preventing invalid operations.
             * 2. Reliability & IntelliSense: Enables safe method invocation on generic instances directly without casting or risking runtime exceptions.
             */
            #endregion

            #region Problem11
            List<string> stringListP11 = new List<string> { "apple", "banana", "cherry" };

            StringTransformer uppercaseTransformer = s => s.ToUpper();
            StringTransformer reverseTransformer = s =>
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            };

            List<string> uppercaseList = TransformStrings(stringListP11, uppercaseTransformer);
            List<string> reversedList = TransformStrings(stringListP11, reverseTransformer);

            Console.WriteLine("Original List:  " + string.Join(", ", stringListP11));
            Console.WriteLine("Uppercase List: " + string.Join(", ", uppercaseList));
            Console.WriteLine("Reversed List:  " + string.Join(", ", reversedList));
            #endregion

            #region Question11
            /*
             * Question: What are the benefits of using delegates for string transformations in a functional programming style?
             * Answer:
             * 1. Higher-Order Abstraction: Encapsulates string logic into pluggable delegates, keeping list traversal code reusable.
             * 2. Immutability: Encourages producing new transformed collections without modifying original data.
             */
            #endregion

            #region Problem12
            int aP12 = 20, bP12 = 5;

            MathOperation add = (x, y) => x + y;
            MathOperation subtract = (x, y) => x - y;
            MathOperation multiply = (x, y) => x * y;
            MathOperation divide = (x, y) => x / y;

            Console.WriteLine($"Addition ({aP12} + {bP12}): {PerformMathOperation(aP12, bP12, add)}");
            Console.WriteLine($"Subtraction ({aP12} - {bP12}): {PerformMathOperation(aP12, bP12, subtract)}");
            Console.WriteLine($"Multiplication ({aP12} * {bP12}): {PerformMathOperation(aP12, bP12, multiply)}");
            Console.WriteLine($"Division ({aP12} / {bP12}): {PerformMathOperation(aP12, bP12, divide)}");
            #endregion

            #region Question12
            /*
             * Question: How does the use of delegates promote code reusability and flexibility in implementing mathematical operations?
             * Answer:
             * 1. Reusability: A single wrapper method (PerformMathOperation) handles parameter passing and error handling, while delegates implement specific math rules.
             * 2. Flexibility: New mathematical operations can be added on-the-fly without altering existing execution frameworks.
             */
            #endregion

            #region Problem13
            List<int> numbersP13 = new List<int> { 1, 2, 3, 4, 5 };

            GenericTransformer<int, string> intToStringTransformer = num => $"Number: {num}";
            List<string> stringifiedNumbers = TransformList(numbersP13, intToStringTransformer);

            Console.WriteLine("Transformed List<int> to List<string>:");
            foreach (var str in stringifiedNumbers)
                Console.WriteLine(str);
            #endregion

            #region Question13
            /*
             * Question: What are the advantages of using generic delegates in transforming data structures?
             * Answer:
             * 1. Type Projection: Allows mapping data from type T to a completely different target type R cleanly.
             * 2. Adaptability: Supports diverse transformation scenarios (e.g., mapping DTOs, string conversions, numerical computations) with a single generic function.
             */
            #endregion

            #region Problem14
            List<int> numbersP14 = new List<int> { 2, 4, 6, 8 };
            Func<int, int> squareFunc = x => x * x;

            List<int> squaredNumbers = ProcessList(numbersP14, squareFunc);

            Console.WriteLine("Original Numbers: " + string.Join(", ", numbersP14));
            Console.WriteLine("Squared Numbers:  " + string.Join(", ", squaredNumbers));
            #endregion

            #region Question14
            /*
             * Question: How does Func simplify the creation and usage of delegates in C#?
             * Answer:
             * 1. Removes Boilerplate: Eliminates the need to explicitly define custom delegate types for functions that return values.
             * 2. Standardization: Integrates natively with LINQ and functional constructs throughout the .NET ecosystem.
             */
            #endregion

            #region Problem15
            List<string> messagesP15 = new List<string> { "Hello", "Generic", "Action", "Delegate" };
            Action<string> printAction = s => Console.WriteLine($"[Action Output]: {s}");

            ProcessList(messagesP15, printAction);
            #endregion

            #region Question15
            /*
             * Question: Why is Action preferred for operations that do not return values?
             * Answer:
             * 1. Expresses Intent: Explicitly communicates that the target delegate performs a void side-effect operation (such as logging or printing).
             * 2. Avoids Dummy Returns: Eliminates unnecessary return type definitions associated with Func delegates.
             */
            #endregion

            #region Problem16
            List<int> numbersP16 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> isEven = x => x % 2 == 0;

            List<int> evenNumbers = FilterList(numbersP16, isEven);

            Console.WriteLine("Original Numbers: " + string.Join(", ", numbersP16));
            Console.WriteLine("Even Numbers:     " + string.Join(", ", evenNumbers));
            #endregion

            #region Question16
            /*
             * Question: What role do predicates play in functional programming, and how do they enhance code clarity?
             * Answer:
             * 1. Boolean Evaluation: Predicate<T> encapsulates filtering conditions (T -> bool) into self-contained units.
             * 2. Declarative Code: Replaces procedural loop checks with clean, expressive filtering operations.
             */
            #endregion

            #region Problem17
            List<string> stringListP17 = new List<string> { "Apple", "Avocado", "Banana", "Apricot", "Blueberry" };

            List<string> startsWithA = FilterStrings(stringListP17, delegate(string s) { return s.StartsWith("A"); });
            List<string> containsBerry = FilterStrings(stringListP17, delegate(string s) { return s.Contains("berry"); });

            Console.WriteLine("Starts with 'A': " + string.Join(", ", startsWithA));
            Console.WriteLine("Contains 'berry': " + string.Join(", ", containsBerry));
            #endregion

            #region Question17
            /*
             * Question: How do anonymous functions improve code modularity and customization?
             * Answer:
             * 1. Locality of Logic: Allows writing inline custom functions right where they are needed without populating class scope with single-use methods.
             * 2. Closure Capture: Captures outer variables to construct dynamic, customized execution contexts.
             */
            #endregion

            #region Problem18
            int num1 = 12, num2 = 4;

            int addResult = Calculate(num1, num2, delegate(int x, int y) { return x + y; });
            int subResult = Calculate(num1, num2, delegate(int x, int y) { return x - y; });
            int mulResult = Calculate(num1, num2, delegate(int x, int y) { return x * y; });

            Console.WriteLine($"Anonymous Addition ({num1} + {num2}): {addResult}");
            Console.WriteLine($"Anonymous Subtraction ({num1} - {num2}): {subResult}");
            Console.WriteLine($"Anonymous Multiplication ({num1} * {num2}): {mulResult}");
            #endregion

            #region Question18
            /*
             * Question: When should you prefer anonymous functions over named methods in implementing mathematical operations?
             * Answer:
             * 1. One-off Logic: When the mathematical formula is unique to a single call site and not needed elsewhere.
             * 2. Capturing Context: When the math operation needs to capture state from the local calling scope.
             */
            #endregion

            #region Problem19
            List<string> stringListP19 = new List<string> { "Cat", "Elephant", "Dog", "Tiger", "Bee" };

            List<string> lengthGreaterThan3 = FilterStringsLambda(stringListP19, s => s.Length > 3);
            List<string> containsE = FilterStringsLambda(stringListP19, s => s.Contains('e') || s.Contains('E'));

            Console.WriteLine("Length > 3:      " + string.Join(", ", lengthGreaterThan3));
            Console.WriteLine("Contains 'e'/'E': " + string.Join(", ", containsE));
            #endregion

            #region Question19
            /*
             * Question: What makes lambda expressions an essential feature in modern C# programming?
             * Answer:
             * 1. Declarative Syntax: Enables compact functional programming and LINQ queries.
             * 2. Expression Trees: Powers modern frameworks (Entity Framework, Moq) by allowing code to be parsed into expression trees at runtime.
             */
            #endregion

            #region Problem20
            double val1 = 16.0, val2 = 4.0;

            double divResult = CalculateDouble(val1, val2, (x, y) => x / y);
            double powResult = CalculateDouble(val1, val2, (x, y) => Math.Pow(x, y));

            Console.WriteLine($"Lambda Division ({val1} / {val2}): {divResult}");
            Console.WriteLine($"Lambda Exponentiation ({val1} ^ {val2}): {powResult}");
            #endregion

            #region Question20
            /*
             * Question: How do lambda expressions enhance the expressiveness of mathematical computations in C#?
             * Answer:
             * 1. Mathematical Intuition: Mirrors standard math function notation (x, y) => f(x, y), making complex formulas clean and readable.
             * 2. Higher-Order Functions: Enables passing inline mathematical operations directly into generic algorithms or numerical execution pipelines.
             */
            #endregion
            #endregion
        }

        #region Helper Methods
        public static T GetDefault<T>() => default(T)!;

        public static Employee[] CloneEmployeeArray(Employee[] original)
        {
            Employee[] copy = new Employee[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = (Employee)original[i].Clone();
            }
            return copy;
        }

        public static List<string> TransformStrings(List<string> list, StringTransformer transformer)
        {
            List<string> result = new List<string>();
            foreach (var item in list)
            {
                result.Add(transformer(item));
            }
            return result;
        }

        public static int PerformMathOperation(int a, int b, MathOperation operation)
        {
            return operation(a, b);
        }

        public static List<R> TransformList<T, R>(List<T> list, GenericTransformer<T, R> transformer)
        {
            List<R> result = new List<R>();
            foreach (var item in list)
            {
                result.Add(transformer(item));
            }
            return result;
        }

        public static List<int> ProcessList(List<int> list, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                result.Add(func(item));
            }
            return result;
        }

        public static void ProcessList(List<string> list, Action<string> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        public static List<int> FilterList(List<int> list, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<string> FilterStrings(List<string> list, Func<string, bool> condition)
        {
            List<string> result = new List<string>();
            foreach (var item in list)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static int Calculate(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }

        public static List<string> FilterStringsLambda(List<string> list, Func<string, bool> predicate)
        {
            List<string> result = new List<string>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static double CalculateDouble(double a, double b, Func<double, double, double> operation)
        {
            return operation(a, b);
        }
        #endregion
    }
}
