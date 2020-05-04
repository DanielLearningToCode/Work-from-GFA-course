using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.Models;

namespace REST
{
    public class Services
    {
        internal object Greet(Person person)
        {
            if (person.Name == null && person.Title == null)
            {
                //object value = new { error = "Please provide a name and a title!" };
                return new { error = "Please provide a name and a title!", status = 400 };
            }
            else if (person.Name == null)
            {
                return new { error = "Please provide a Name!", status = 400 }; ;
            }
            else if (person.Title == null)
            {
                return new { error = "Please provide a title!", status = 400 };
            }
            else
            {
                return new { welcome_message = $"Oh, hi there {person.Name}, my dear {person.Title}!" };
            }
        }
       public static int Sum(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                return input + Sum(input - 1);
            }
        }
        public static int Factor(int input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                return input * Factor(input - 1);
            }
        }


    }
}
