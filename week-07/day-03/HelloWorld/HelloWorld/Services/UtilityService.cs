using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }
        public string[] ValidateEmail(string email)
        {
            string[] result = new string[2];
            if (email.Contains('@') && email.Contains('.'))
            {
                result[0] = $"{email} is a valid email address";
                result[1] = "green";
            }
            else
            {
                result[0] = $"{email} is not a valid email address";
                result[1] = "red";
            }
            return result;
        }
        public string Caesar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return result;
        }

    }
}