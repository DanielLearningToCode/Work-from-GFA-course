using System;

namespace Post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Create a few example post-it objects: an orange with blue text: "Idea 1" 
            /// a pink with black text: "Awesome" a yellow with green text: "Superb!"

            PostIt orangeObject = new PostIt();
            orangeObject.BackgroundColor = "Orange";
            orangeObject.ForegroundColor = "Blue";
            orangeObject.Text = "Idea 1";

            PostIt pinkObject = new PostIt();
            pinkObject.BackgroundColor = "Pink";
            pinkObject.ForegroundColor = "Black";
            pinkObject.Text = "Awsome";

            PostIt yellowObject = new PostIt();
            yellowObject.BackgroundColor = "Yellow";
            yellowObject.ForegroundColor = "Green";
            yellowObject.Text = "Superb!";

            PostIt.SetGreenOnYellow();
            Console.WriteLine(yellowObject.BackgroundColor + " " + yellowObject.ForegroundColor + " " + yellowObject.Text);
        }
    }
}
