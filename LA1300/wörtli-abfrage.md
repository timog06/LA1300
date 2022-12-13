```c#
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> alreadyUsed = new();
            int i = 1;
            while (true)
            {
                string randomPosition = generateRandomPosition("ABCDE", 5, alreadyUsed);
                alreadyUsed.Add(randomPosition);
                Console.Write(i++ + ": " + randomPosition);
                Console.ReadLine();
            }
        }

        static string generateRandomPosition(String alphabet, int rows, List<string> alreadyUsed)
        {
            if (alreadyUsed.Count >= rows*alphabet.Length)
            {
                return "Alle aufgebraucht!";
            }


            Random ran = new Random();
            string randomPosition;
            do
            {
                int lengthAlph = 1;

                String randomAlph = "";

                for (int i = 0; i < lengthAlph; i++)
                {
                    int a = ran.Next(5);
                    randomAlph = randomAlph + alphabet.ElementAt(a);
                }

                int randomNumber = ran.Next(rows) + 1;
                randomPosition = randomAlph + randomNumber;
            } while (alreadyUsed.Contains(randomPosition));
            return randomPosition;

        }
    }
}
```
