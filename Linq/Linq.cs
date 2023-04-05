using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;


namespace Linq
{
    public class Linq
    {
        static void Main(string[] args)
        {
            //BasicLinq();
            //LinqNumbers();
            SearchExamples();
            //MultipleSelects();
            //linqCollections();
            //SkipTakeLinq();
            //LinqVariables();




            //Basic Statements
            static void BasicLinq()
            {
                string[] cars =
                {
                "VW Golf",
                "VW California",
                "Audi A3",
                "Audi A5",
                "Fiat Punto",
                "Seat Ibiza",
                "Seat León"
            };

                //1- Select * of cars. (SELECT ALL Cars)
                Console.WriteLine("********************");
                Console.WriteLine("Busco todos los Autos");
                Console.WriteLine("");
                var carsList = from car in cars select car;

                foreach (var car in carsList)
                {
                    Console.WriteLine(car);
                }


                //2- Select WHERE car is Audi. (SELECT Audi-Cars)

                var audiCarsList = from car in cars where car.Contains("Audi") select car;

                foreach (var audi in audiCarsList)
                {
                    Console.WriteLine(audi);
                }

                Console.WriteLine("********************");
                Console.WriteLine("Busco solamente los autos que tengan la palabra Audi");
                Console.WriteLine("");
            }




            //Numbers Examples
            static void LinqNumbers()
            {
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                //Each Number multiplied by 3
                //Take all numbers, but 9
                //Order numbers by ascending value

                var processedNumberList =
                    numbers
                            .Select(num => num * 3)             // { 3,6,9, etc. }
                            .Where(num => num != 9)             // {all but (except) the 9  }
                                                                //.OrderBy(num => num);             // Order by ascending
                            .OrderByDescending(num => num);     // Order by descending

                foreach (var number in processedNumberList)
                {
                    Console.WriteLine(number);
                }
            }


            static void SearchExamples()
            {
                List<string> letterList = new List<string>
                {
                    "a",
                    "bx",
                    "c",
                    "d",
                    "e",
                    "cj",
                    "f",
                    "p",
                };

                //1. Fist of all elements

                var first = letterList.First();

                Console.WriteLine(first);
                Console.WriteLine();
                //2. Fist elements that is 'c'

                var letterC = letterList.First(letter => letter.Equals("Hola"));

                Console.WriteLine(letterC);
                Console.WriteLine();

                //3. Fist elements that contains 'j'
                var containsLetterJ = letterList.First(letter => letter.Contains("j"));

                Console.WriteLine(containsLetterJ);
                Console.WriteLine();

                //4. Fist elements that contains 'z' or default value   (letter z no exist)
                var containsLetterZ = letterList.FirstOrDefault(letter => letter.Contains("q"));   // " "(null) or element that contains Z

                Console.WriteLine(containsLetterZ);
                Console.WriteLine();

                //5. Last elements that contains 'z' or default value 
                var lastOrDefaultLetterZ = letterList.LastOrDefault(letter => letter.Contains("z"));   // " "(empty) or last element that contains Z

                Console.WriteLine(lastOrDefaultLetterZ);
                Console.WriteLine();

                //6. Single Values (evita que haya elementos repetidos)
                /*var uniqueLetters = letterList.Single();

                Console.WriteLine(uniqueLetters);
                Console.WriteLine();

                var uniqueorDefaultLetters = letterList.SingleOrDefault();
                Console.WriteLine(uniqueorDefaultLetters);
                Console.WriteLine();*/

                int[] evenNumbers = { 0, 2, 4, 6, 8 };
                int[] otherEvenNumbers = { 0, 2, 6 };

                //Obtain { 4, 8 }
                var myEvenNumbers = evenNumbers.Except(otherEvenNumbers); //{ 4, 8}

                foreach (var myNumbers in myEvenNumbers) { Console.WriteLine(myNumbers); }
            }

            static void MultipleSelects()
            {
                //SELECT MANY
                string[] myOptions =
                {
                    "Title1, Text1",
                    "Title2, Text2",
                    "Title3, Text3",
                    "Title4, Text4",
                };

                var myOptionsSelection = myOptions.SelectMany(options => options.Split("Title"));

                foreach (var world in myOptionsSelection) { Console.WriteLine(world); }

                var listEnterprises = new[]
                {
                    new Enterprise ()
                {
                    Id = 1,
                    Name = "Enterprise 1",
                    Employees = new []
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Ariel",
                            Email = "a.b@ab.com",
                            Salary = 7500
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Francisco",
                            Email = "f.x@fx.com",
                            Salary = 2000
                        },new Employee
                        {
                            Id = 3,
                            Name = "Andres",
                            Email = "a.xv@axv.com",
                            Salary = 3000
                        }
                    }
                },
                new Enterprise ()
                {
                    Id = 1,
                    Name = "Enterprise 3"
                },
                 new Enterprise ()
                {
                    Id = 2,
                    Name = "Enterprise 2",
                    Employees = new []
                    {
                        new Employee
                        {
                            Id = 3,
                            Name = "Ana",
                            Email = "a.ds@ads.com",
                            Salary = 4000
                        },
                        new Employee
                        {
                            Id = 4,
                            Name = "Maria",
                            Email = "m.m@mm.com",
                            Salary = 600
                            },new Employee
                                {
                                    Id = 5,
                                    Name = "Alejandra",
                                    Email = "a.a@aa.com",
                                    Salary = 1500
                                }
                        }
                    }
                };


                //Obtain all Employees of all Enterprises

                var employeesList = listEnterprises.SelectMany(enterprise => enterprise.Employees);

                // Know if any list is empty

                bool hasEnterprises = listEnterprises.Any();

                // Know if any list contains employees
                bool hasEmployees = listEnterprises.Any(enterprise => enterprise.Employees.Any());

                // All enterprises at least employee with at least 1000 of salary

                bool hasEmployeeWithSalaryMoreThanOrEqual1000 =
               listEnterprises.Any(enterprise => enterprise.Employees.Any(employee => employee.Salary >= 1000));
            }


            static void linqCollections()
            {
                var firstList = new List<string>() { "a", "b", "c" };
                var secondList = new List<string>() { "a", "c", "d" };

                //INNER JOIN

                var commonResult = from element in firstList
                                   join secondElement in secondList
                                   on element equals secondElement
                                   select new { element, secondElement };

                foreach (var equalsElement in commonResult)
                {
                    Console.WriteLine(equalsElement);
                }

                // Another way
                var commonResult2 = firstList.Join(
                        secondList,
                        element => element,
                        secondElement => secondElement,
                        (element, secondElement) => new { element, secondElement }
                    );

                Console.WriteLine("****************************");
                foreach (var equalsElement2 in commonResult2)
                {
                    Console.WriteLine(equalsElement2);
                }

                //OUTER JOIN - LEFT

                var leftOuterJoin = from element in firstList
                                    join secondElement in secondList
                                    on element equals secondElement                 //Obtenemos los valores iguales (comunes) y lo almacena en una lista temporal
                                    into temporalList
                                    from temporalElement in temporalList.DefaultIfEmpty() //Puede que no haya ningun elemento (vacio)
                                    where element != temporalElement                // Entonces "restamos" los elementos de la 1er lista con lo de la listTemp
                                    select new { Element = element };

                //Compare all elements both list
                var lefOuterJoin2 = from element in firstList
                                    from secondElement in secondList.Where(second => second == element).DefaultIfEmpty()
                                    select new { Element = element, SecondElement = secondElement };





                //OUTER JOIN - RIGHT

                var rightOuterJoin = from secondElement in secondList
                                     join element in firstList
                                    on secondElement equals element
                                    into temporalList
                                     from temporalElement in temporalList.DefaultIfEmpty()
                                     where secondElement != temporalElement
                                     select new { Element = secondElement };

                //UNION
                var unionList = leftOuterJoin.Union(rightOuterJoin);
            }


            static void SkipTakeLinq()
            {
                var myList = new[]
                {
                    1,2,3, 4,5,6, 7, 8,9,10
                };

                // SKIP

                var skipTwoFistValues = myList.Skip(2);   // { 3, 4,5,6, 7, 8,9,10 }
                var skipLastTwoValues = myList.SkipLast(2);   // { 1,2 ,3, 4,5,6, 7, 8 }
                var skipWhile = myList.SkipWhile(num => num < 4);  // { 4, 5, 6 , 7 , 8 , 9 , 10 }

                // TAKE

                var takeFistTwoValues = myList.Take(2); // { 1 ,2 }
                var takeLastTwoValues = myList.TakeLast(2); // { 9, 10 }
                var takeWhileSmallerThan4 = myList.TakeWhile(num => num < 4); // { 1, 2 ,3  }




                //Search employees by email 

                var employees = new[]
                    {
                        new Employee
                        {
                            Id = 1,
                            Name = "Ariel",
                            Age= 30,
                            Email = "a.b@ab.com",
                            Salary = 7500
                        },
                        new Employee
                        {
                            Id = 2,
                            Name = "Francisco",
                            Age= 10,
                            Email = "f.x@fx.com",
                            Salary = 2000
                        },new Employee
                        {
                            Id = 3,
                            Name = "Andres",
                            Age= 40,
                            Email = "a.xv@axv.com",
                            Salary = 3000
                        }
                };
                var employeeByEmail = from emp in employees
                                      select new
                                      {
                                          email = emp.Email
                                      }.ToString();

                //Search employees with Age > 18 
                var employeeOver18 = from emp in employees
                                     where emp.Age > 18
                                     select emp;

            }
        
           //Paging with Skip & Take
            IEnumerable<T> GetPage<T>(IEnumerable<T> collection, int pageNumber, int resultsPerPage)
            {
                int startIndex = (pageNumber - 1 ) * resultsPerPage;
                return collection.Skip(startIndex ).Take( resultsPerPage );
            }

            //Variables
            static void LinqVariables()
            {
                int[] numbers = { 1,2,3,4,5,6,7,8,9,10};

                var aboveAverage = from number in numbers
                                   let numberAverage = numbers.Average()
                                   let nSquared = Math.Pow(number, 2)
                                   where nSquared > numberAverage
                                   select number;

                foreach(var number in aboveAverage) 
                {
                Console.WriteLine(number);
                }

            }

        }
    }

}