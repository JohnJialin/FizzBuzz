namespace FizzBuzz
{
    public class Helper
    {
        public Helper()
        {

        }

        public int[] ConvertStringToIntArray(string[] args)
        {

            int[] numberArray = new int[args.Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (args[i] == null || args[i] == "" || !int.TryParse(args[i], out int number))
                {
                    numberArray[i] = -1;
                }
                else
                {
                    numberArray[i] = Int32.Parse(args[i]);
                }
            }

            return numberArray;
        }

        public List<string> FizzBuzzValues(int[] values)
        {
            List<string> result = new List<string>();

            foreach (var value in values)
            {
                if (value == -1)
                {
                    result.Add("Invalid Item");
                }
                else
                {
                    result.AddRange(FizzBuzzCalculate(value));
                }
            }

            return result;
        }

        private List<string> FizzBuzzCalculate(int n)
        {
            List<string> result = new List<string>();

            if (n % 3 == 0 && n % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (n % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if (n % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add($"{n % 3}");
                result.Add($"{n % 5}");
            }

            return result;
        }
    }
}
