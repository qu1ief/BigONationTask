namespace BigONation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] array = { 321, 131, 2, 12, 3, 12, 321, 41, 2, 3132, 314, 12 };

            int minimum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minimum > array[i])
                {
                    minimum = array[i];
                }
            }
            Console.WriteLine("minimum:" + minimum);


            //2

            string[] words = { "Salam", "Menim", "Adim", "Sabirdir" };


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 4)
                {
                    Console.WriteLine(words[i]);
                }
            }


            //3


            int[] numbers = { 21312, 1231, 212, 3, 4124, 12, 421, 21, 312, 21 };

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 10 && numbers[i] >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);



            //4

            string word = "Salam";

            bool isExist = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {

                    isExist = true; break;
                }
            }

            Console.WriteLine(isExist);


        }
    }
}
