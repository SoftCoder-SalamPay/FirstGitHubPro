
namespace AlgoExample

{
    public class Algorithm1
    {
        public static void PrintVowel()
        {
            string word = "Wassup";
            var letters = GetVowelPositions(word);
            Console.WriteLine($"{letters}");
        }
        public static List<int> GetVowelPositions(string s)
        {
            char[] vowels = ['A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'];
            List<int> vowelsPositions = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (s[i] == vowels[j])
                    {
                        vowelsPositions.Add(i);
                    }
                }
            }
            return vowelsPositions;
        }
    }


    public class StringTransformation
    {
        public class PrintStringTransformation()
        {
            public static string StringTransformation(string inputString)
            {
                char[] splitInputString = new char[inputString.Length];
                for (int i = 0; i < inputString.Length; i++)
                {
                    char currentChar = inputString[i];
                    if (currentChar >= 'a' && currentChar <= 'z')
                    {
                        splitInputString[i] = (char)(currentChar - 32);
                    }
                    else if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        splitInputString[i] = (char)(currentChar + 32);
                    }
                    else
                    {
                        splitInputString[i] = currentChar;
                    }
                }

                return new string(splitInputString);
            }
        }

        public class ShiftLetters
        {
            public static void ShiftedLetters()
            {
                string names = "Ademola";
                string letters = PrintShiftLetters(names);
                Console.WriteLine(names);
            }

            public static string PrintShiftLetters(string inputString)
            {
                char[] result = new char[inputString.Length];

                for (int i = 0; i < inputString.Length; i++)
                {
                    char create = inputString[i];

                    if (create >= 'a' && create <= 'z')
                    {
                        result[i] = (create == 'z') ? 'a' : (char)(create + 1);
                    }
                    else if (create >= 'A' && create <= 'Z')
                    {
                        result[i] = (create == 'Z') ? 'A' : (char)(create + 1);
                    }
                    else
                    {
                        result[i] = create;
                    }

                }
                return new string(result);
            }
        }
    }
}



