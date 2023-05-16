namespace MethodOverloadingExerciseAnswer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 30;
            var y = 50;

            var intAdd = Add(x, y);

            var a = 30.00m;
            var b = 50.00m;

            var decimalAdd = Add(a, b);

            var checkedAdd = Add(5, 10, true);

            Console.WriteLine($"Int Add: {intAdd}\nDecimal Add: {decimalAdd}\nAdd With Bool: {checkedAdd}");            
        }     

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isChecked)
        {
            var sum = num1 + num2;

            if (isChecked == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isChecked == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isChecked == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}