using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
class PostIt
{
    public string BackgroundColor { get; set; }
    public string Text { get; set; }
    public string ForegroundColor { get; set; }

    public static void SetGreenOnYellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
        }
}
}

/// Create a PostIt a class that has 
/// a BackgroundColor a Text on it 
/// a TextColor