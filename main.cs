using System;

class Program {
  public static void Main (string[] args) {
    //declare operands
    Console.WriteLine ("Press\n \"+\" for Addition,\n \"-\" for Subtraction,\n \"/\" for Division and\n \"*\" for Multiplication");
   do{
    //input first number
    Console.Write("Enter first number: ");
    double firstNumber = Convert.ToDouble(Console.ReadLine());
      //enter operand
    Console.Write("Enter operator: ");
    string operand = Console.ReadLine();
    //input second number
    Console.Write("Enter Second Number: ");
    double secondNumber = Convert.ToDouble(Console.ReadLine());
     double result = 0;
     //Condition and operation
     switch(operand){
     case "+":
       {
         result = (firstNumber + secondNumber);
         break;
       }
     case "-":
       {
         result = (firstNumber - secondNumber);
         break;
       }
     case "/":
       {
         result = (firstNumber / secondNumber);
         break;
       }
     case "*":
       {
         result = (firstNumber * secondNumber);
         break;
       }
     default:
       Console.WriteLine("Error! Please enter a valid operator");
         break;
       }
  Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, operand, secondNumber, result);
    Console.Write("Do you want to perform another operation?\n (Enter y = yes, N = No)");
} while(Console.ReadLine().ToUpper() == "Y");
    Console.WriteLine("Bye");
    }  
}