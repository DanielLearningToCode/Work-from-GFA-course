using System;

namespace Blog_post
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BlogPost postOne = new BlogPost();
            BlogPost postTwo = new BlogPost();
            BlogPost postThree = new BlogPost();

            postOne.AuthorName = "John Doe";
            postOne.TitleName = "Lorem Ipsum";
            postOne.Text = "Lorem ipsum dolor sit amet.";
            postOne.PublicationDate = new DateTime (2000, 04, 05);
            Console.WriteLine(postOne.PublicationDate);

            postTwo.AuthorName = "Tim Urban";
            postTwo.TitleName = "Wait but why";
            postTwo.Text = " A popular long-form, stick-figure-illustrated blog about almost everything.";
            postTwo.PublicationDate = new DateTime(2010,10,10);
            Console.WriteLine(postTwo.PublicationDate);

            postThree.AuthorName = "William Turton";
            postThree.TitleName = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            postThree.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to " +
                "be the center of attention.When I asked to take his picture outside one of IBM’s " +
                "New York City offices, he told me that he wasn’t really into the whole organizer " +
                "profile thing.";
            postThree.PublicationDate = new DateTime(2017,03,28);
            Console.WriteLine(postThree.PublicationDate);
            Console.WriteLine(postThree.Text);
        }
    }
}
/*Create a few blog post objects:

    "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
        Lorem ipsum dolor sit amet.
    "Wait but why" titled by Tim Urban posted at "2010.10.10."
        A popular long-form, stick-figure-illustrated blog about almost everything.
    "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
        Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.
*/
