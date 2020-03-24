using System;

namespace zoo
{
    class Zoo
    {
        static void Main(string[] args)
        {
            Crocodile dundee = new Crocodile("Dundee", Animal.gendertypes.male);
            HummingBird chirp = new Animal ("Chirp", Animal.gendertypes.female);
            Koala eucalyptAddict = new Koala("EucalyptAddict", Animal.gendertypes.female);

            

            Console.WriteLine(dundee.GetName() + ", " + dundee.GetGender().ToString() + " " + dundee.WantChild());
            Console.WriteLine(chirp.GetName() + ", " + chirp.WantChild());
            Console.WriteLine(eucalyptAddict.GetName() + ", " + eucalyptAddict.WantChild());

            /*dundee.MakeSound();
            chirp.MakeSound();
            eucalyptAddict.MakeSound();
            Console.WriteLine(dundee.GetGender());
*/
        }
    }
}
