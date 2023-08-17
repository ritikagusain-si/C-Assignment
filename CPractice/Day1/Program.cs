namespace Day1Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------ARRAY--------------------------------------------------------------

            /* Question1
             Console.WriteLine("Enter the no of numbers to be entered");
             int a = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[a];
             for (int i = 0; i < a; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             for (int i = a - 1; i >= 0; i--)
             {
                 Console.WriteLine(arr[i]);
             }*/

            /*Question 2
            Console.WriteLine("Enter the length of the array:");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[b];
            for (int i = 0; i < b; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int c= 0;
            for (int i =0; i <b; i++)
            {
                c = c + arr[i];

            }
            Console.WriteLine(c);*/

            //Control structure
            //1
            /* Console.WriteLine("CheckCredit");
             Console.WriteLine("Enter your Purchase price");
             int value = Convert.ToInt32(Console.ReadLine());
             if (value > 10000)
             {
                 Console.WriteLine("ERROR");
             }
             else
             {
                 Console.WriteLine("Approved");
             }*/

            /*Question 3
            Console.WriteLine("Enter the length of the array:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[a];
            int[] arr_new = new int[a];
            for (int i = 0; i < a; i++)
           {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            arr_new[i] = arr[i];
            }
          for (int i = 0; i < a; i++)
          {
         Console.WriteLine(arr_new[i]);
          }*/


            //Question 4
            /* Console.WriteLine("Enter the value of n");
             int n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the positon from where you want to delete");
             int pos = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[n];
             for (int i = 0; i < n; i++)
             {
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             for (int i = pos; i < n-1; i++)
             {
                 arr[i - 1] = arr[i];
             }
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine(arr[i]);
             }*/
            /*
                        Console.WriteLine("Enter marks of the students");

                        int[] a = new int[10];

                        for (int i = 0; i < a.Length; i++)
                        {
                            a[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        int max = 0;
                        int avg = 0;

                        for (int i = 0; i < a.Length; i++)
                        {

                            if (a[i] >= max)
                            {
                                max = a[i];
                            }

                            avg = avg + a[i];

                        }

                        Console.WriteLine(max);
                        Console.WriteLine(avg / 10);

                    }*/
            //4
            /* int pos;
             Console.WriteLine("Enter the size of an array");
             int n = Convert.ToInt32(Console.ReadLine());

             int[] num = new int[n];
             Console.WriteLine("Elements before deletion:");
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine($"Enter the numbers{i + 1}");
                 num[i] = Convert.ToInt32(Console.ReadLine());
             }

             Console.WriteLine("Enter the Position");
             pos = Convert.ToInt32(Console.ReadLine());
             for (int i = pos ; i < n; i++)
             {
                if( i == pos)
                 {

                 }
             }
             Console.WriteLine("Elements after deletion: ");
             for (int i = 0; i < n-1; i++)
             {
                 Console.WriteLine(num[i]);
             }*/








            //const int NoOfStudents = 10;
            //int[] marks = new int[NoOfStudents];

            //for(int i = 0; i < NoOfStudents; i++)
            //{
            //    Console.WriteLine($"Enter marks of student {i+1} ");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //double sumMarks = 0;
            //int HighestMarks = marks[0];

            //foreach(int mark in marks)
            //{
            //    sumMarks += mark;

            //    if (mark > HighestMarks)
            //    {
            //        HighestMarks = mark;
            //    }
            //}

            //double AverageMarks = sumMarks / NoOfStudents;
            //Console.WriteLine($"Average marks of students: {AverageMarks}");
            //Console.WriteLine($"Highest marks of students: {HighestMarks}");





            // ----------------------------------------------------------STRING----------------------------------------------------------------


            //1           //    Console.WriteLine("Enter the String");
            //    string str = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine("Enter the character");
            //    char ch = Convert.ToChar(Console.ReadLine());

            //    int count = 0;
            //    for (int i = 0; i < str.Length;  i++)
            //    {
            //        if (ch == str[i])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //    Console.ReadKey();
            //}

            //2          Console.WriteLine("Enter the String");
            //string str = Console.ReadLine().ToLower();

            //char[] chars = str.ToCharArray();
            //Array.Sort(chars);
            //string SortedArray = new string(chars);

            //Console.WriteLine($"The sorted String in alphabetical order is : {SortedArray}");


            //3          Console.Write("Enter a string: ");
            //          string input = Console.ReadLine();

            //          Console.Write("Enter the starting index: ");
            //          int startIndex = Convert.ToInt32(Console.ReadLine());

            //          Console.Write("Enter the length of the substring: ");
            //          int length = Convert.ToInt32(Console.ReadLine());

            //          // Check if the starting index is within the valid range
            //          if (startIndex >= 0 && startIndex < input.Length)
            //          {
            //              // Check if the length is within the valid range
            //              if (length > 0 && length <= input.Length - startIndex)
            //              {
            //                  string substring = input.Substring(startIndex, length);
            //                  Console.WriteLine($"The extracted substring is: {substring}");
            //              }
            //              else
            //              {
            //                  Console.WriteLine("Invalid length for the substring.");
            //              }
            //          }
            //          else
            //          {
            //              Console.WriteLine("Invalid starting index.");
            //          }

            //      Console.ReadKey();



            //4         //Console.WriteLine("Enter the string : ");
            //string input = Console.ReadLine();

            //Console.WriteLine("Enter the substring to search");
            //string substring = Console.ReadLine();

            //int position = input.IndexOf(substring);

            //if (position != -1)
            //{
            //    Console.WriteLine($"The elements {substring} is at position {position}");
            //}
            //else
            //{
            //    Console.WriteLine("The element not found");
            //}


            //5         //Console.Write("Enter the first string : ");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter the starting  index : ");
            //int startIndex1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the length of substring : ");
            //int length1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second string : ");
            //string str2 = Console.ReadLine();

            //Console.Write("Enter the starting  index : ");
            //int startIndex2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the length of substring : ");
            //int length2 = Convert.ToInt32(Console.ReadLine());

            //string substring1 = str1.Substring(startIndex1, length1);
            //string substring2 = str2.Substring(startIndex2, length2);

            //bool equalIgnoreCase = string.Equals(substring1, substring2, StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine($"The substring are {(equalIgnoreCase ? "equal" : "not equal")}.");

            //bool equalWithCase = string.Equals(substring1, substring2, StringComparison.Ordinal);
            //Console.WriteLine($"The substring are {(equalWithCase ? "equal" : "not equal")}.");


            // ----------------------------------------------- CONTROL STRUCTURE-------------------------------------------------------------


            //Console.WriteLine("Enter the Purchase Price : ");
            //int PurchasePrice = Convert.ToInt32(Console.ReadLine());

            //double CreditLimit = 10000.0;

            //if (PurchasePrice < CreditLimit)
            //{
            //    Console.WriteLine("APPROVED");
            //}
            //else
            //{
            //    Console.WriteLine("DENIED");
            //}


            //int TotalTemperature = 0;
            //int SumTemperature = 0;

            //Console.Write("Enter daily high temperatures (Fahrenheit) from 20 to 130.");
            //Console.WriteLine("ENter a value outside temperature to stop.");
            //bool a = true;

            //while(true)
            //{
            //    Console.WriteLine("ENter temperature");
            //    int temperature = Convert.ToInt32(Console.ReadLine());

            //    if (temperature >= 20 && temperature <= 130)
            //    {
            //        // Add the valid temperature to the sum
            //        SumTemperature += temperature;
            //        TotalTemperature++;
            //        a = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Temperature must be between 20 and 130.");
            //    }

            //    if (TotalTemperature > 0)
            //    {
            //        // Calculate and display average temperature
            //        double averageTemperature = (double)SumTemperature / TotalTemperature;
            //        Console.WriteLine($"Number of temperatures entered: {TotalTemperature}");
            //        Console.WriteLine($"Average temperature: {averageTemperature:F2} Fahrenheit");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No valid temperatures entered.");
            //    }
            //}


        }
    }
}