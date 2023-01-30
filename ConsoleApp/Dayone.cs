using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp
{
    internal class Dayone
    {

        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;  
        }
        public int MinutesToSeconds(int minutes)
        {
            return minutes* 60;
        }
        public int NextNumber(int number)
        {
            number++;
            return number ;
        }
        public int CircuitPower(int voltage, int current)
        {
            return voltage * current;
        }
        public int AgeToDays(int age)
        {
            return age * 365;
        }
        public int AreaOfTriangle(int base1, int height)
        {
            return (base1 * height) / 2; 
        }
        public int Remainder(int dividend, int divisor)
        {
            return dividend % divisor;
        }
        public bool CheckNumber(int number)
        {
            if (number <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LessThan100(int firstNumber, int secondNumber)
        {
           int result = firstNumber + secondNumber;
            if (result <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEqual(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
                return true;
            else
                return false;
        }
        public bool FlipBool(bool value)
        {
            if (value == true)
                return false;
            else
                return true;


        }
        public string ReturnSomething(string value)
        {
            // return ("Something" + " " + $"{value}");
            return $"Something {value}";
        }
        public bool And(bool value1, bool value2)
        {
            bool result = value1 && value2;
            return result;
        }
        public int PerimeterOfRectangle(int length, int breadth)
        {
            return 2*(length + breadth);
        }
        public string MonthConverter(int number)
        {
            string month=""; 
            switch (number)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
                default:
                    month = "Invalid input";
                    break;
            }
            return month;
        }
        public int FindLargest(int[] arr)
        {
            int largest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
        public int FindSmallest(int[] arr)
        {
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }
        public int SumOfAbsoluteValue(int[] arr)
        {
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += Math.Abs(arr[i]);
            }
            return sum;
        }
        public double CalculatePower(double number, double exponent)
        {
            return Math.Pow(number, exponent);
        } 
        public int[] MultiplyByLength(int[] arr)
        {
            for(int i=0; i< arr.Length; i++ )
            {
                arr[i] *= arr.Length;
            }
            return arr;
        }
  
    }
}
