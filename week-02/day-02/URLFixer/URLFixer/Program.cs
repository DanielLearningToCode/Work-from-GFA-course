using System;

namespace URLFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            // 1st method
            /*url = url.Replace("bots", "odds");
            url = url.Insert(5, ":");
*/
            // 2nd method
            string[] array = url.Split("/");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "https")
                {
                    array[i] = "https:";
                }
                if (array[i] == "nevertellmethebots")
                {
                    array[i] = "nevertellmetheodds";
                }
            }

            url = String.Join("/", array);

            Console.WriteLine(url);
        }
    }
}
