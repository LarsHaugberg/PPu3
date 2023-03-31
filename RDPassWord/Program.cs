

namespace RDPassWord
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("hvor langt ønsker du passordet skal være?");
            int passwordLength = 4;
            Console.WriteLine("hvilke options vil du ha?\n- l = lower case letter\r\n  - L = upper case letter\r\n  - d = digit\r\n  - s = special character (!\"#¤%&/(){}[]");
            string pattern = "lLsd";

            string password = "";

            foreach (char character in pattern) 
            {
                if (character == 'l')
                {
                   password += WriteRandomLowerCaseLetter();
                }

                else if (character == 'L')
                {
                    password += WriteRandomUpperCaseLetter();
                }

                else if (character == 's')
                {
                    password += WriteRandomSpecialCharacter();
                }

                else if (character == 'd')
                {
                   password += WriteRandomDigit();
                }
            }

            Console.WriteLine($"The password is: {password}");
        }

        public static char WriteRandomLowerCaseLetter()
        {
            Random rnd = new Random();
            int getRandomLowerCase = rnd.Next(0, 26);
            char[] randomLowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            return randomLowerCase[getRandomLowerCase];
        }

        public static char WriteRandomUpperCaseLetter()
        {
            Random rnd = new Random();
            int getRandomUpperCase = rnd.Next(0, 26);
            char[] randomUpperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            return randomUpperCase[getRandomUpperCase];
        }

        public static char WriteRandomSpecialCharacter()
        {
            Random rnd = new Random();
            int getrandomSpecialCharacter = rnd.Next(0, 14);
            char[] randomSpecialCharacter = { '!', '#', '%', '&', '(', ')', '*', '+', '-', ':', '<', '=', '>', '[' };

            return randomSpecialCharacter[getrandomSpecialCharacter];
        }

        public static int WriteRandomDigit() 
        {
            Random rnd = new Random();
            int getRandomDigit = rnd.Next(0, 10);

            return getRandomDigit;
        }
    }
    // ']', '^', '_', '`', '{', '|', '}', '~'

}
