namespace part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            string  text = " ababababcdcdcdcdcdcd";
            Console.WriteLine(text.IndexOf('d'));
            text = text.Replace('a', 'b');
            Console.WriteLine(text);
            Console.WriteLine(text.Replace('a', 'b').Replace('c', 'd'));
        
            string numberString = "1,2,3,4,5";
            int sum = 0;
            string[] numbersString = numberString.Split(',');
            foreach (string s in numberString.Split(','))
            {
                sum += int.Parse(s);
            }
            Console.WriteLine(sum);

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] letters = alphabet.ToCharArray();
            int[] counts = CountOccurrences("abcdefghijkl", letters);
            for (int i = 0; i < counts.Length; i++)
               Console.WriteLine($"{alphabet[i]}  {counts[i]}");
           
        }
       static  int[] CountOccurrences(string s, char[] letters) 
        {
            int[] count = new int[letters.Length];

            for(int i=0;i<count.Length;i++)
            {
                if (s.Contains(letters[i]))
                {
                    count[i]++;
                }
            
            }

            return count;
        }

    }
}
