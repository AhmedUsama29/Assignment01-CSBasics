using System.Runtime.ExceptionServices;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01 : Write a program that allows the user to enter a number then print it
            //Console.WriteLine("Enter a number: ");
            //int Num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"You Entered: {Num}");

            #endregion

            #region Question 02 : Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //Console.WriteLine("Enter a String: ");
            //String Text = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(Text));
            ////Error [FormatException], it can be handeled better by using try parse [next session]
            #endregion

            #region Question 03 : Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float x = 3.14f;
            //float y = 4.29f;
            //Console.WriteLine($"x + y = {x + y}");
            ////it will run

            #endregion

            #region Question 04 : Write C# program that Extract a substring from a given string.
            //String Text = "Hi Route";
            //Text = Text.Substring(0, 2);
            //Console.WriteLine(Text);

            #endregion

            #region Question 05 : Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int FirstNum = 10;
            //Console.WriteLine($"Value of firstNumber: {FirstNum}");

            //int SecondNum = FirstNum;
            //Console.WriteLine($"Value of secondNumber after assignment: {SecondNum}");

            //FirstNum = 20;
            //Console.WriteLine($"After modifying firstNumber:");
            //Console.WriteLine($"Value of firstNumber: {FirstNum}");
            //Console.WriteLine($"Value of secondNumber: {SecondNum}");

            //// they will be different
            #endregion

            #region Question 06 : Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Point P;
            //P = new Point(1,2);
            //Console.WriteLine(P.ToString());

            //Point C;
            //C = new Point(3,4);
            //Console.WriteLine(C.ToString());

            //Console.WriteLine("------------------------");

            //C = P;
            //P.x = 15; P.y = 20;
            //Console.WriteLine(C.ToString());
            //Console.WriteLine(P.ToString());

            //They will be the same

            #endregion

            #region Question 07 : Write C# program that take two string variables and print them as one variable
            //String FirstString = "Ahmed";
            //String SecondString = "Osama";

            //String CombinedString = String.Concat(FirstString," ",SecondString);

            //Console.WriteLine(CombinedString);
            #endregion

            #region Question 08 : Which of the following statements is correct about the C#.NET code snippet given below?
            /*
            30 > 20 ----> Flase
            ! ----> True
            Convert.ToInt32(True) ----> 1
            d = 1
            -- Answer : b) A value 1 will be assigned to d.
            */
            #endregion

            #region Question 09 : Which of the following is the correct output for the C# code given below?
            /*
            / ----> Integer Division ----> 13 / 2 = 6
            % ----> Module ----> 13 % 6 = 1
            -- Answer : d) 6 1
            */
            #endregion

            #region Question 10 : What will be the output of the C# code given below?
            /*
            num = 1 , z = 5 
             
            (1 <= 0) ----> False
            ! ----> True

             ++num + z++ + " " + ++z 

            (2) + 5         + " " + (7) -------------> 7 7
                    (z = 6)
            -- Answer : d) 7 7
            */
            #endregion

        }
    }
}
