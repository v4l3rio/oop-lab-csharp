namespace Properties
{
    using System;
    using System.Linq;

    /// <summary>
    /// The seeds of italian cards.
    /// </summary>
    public enum ItalianSeeds
    {
        DENARI,
        COPPE,
        SPADE,
        BASTONI,
    }

    /// <summary>
    /// The names of italian cards.
    /// </summary>
    public enum ItalianNames
    {
        ASSO,
        DUE,
        TRE,
        QUATTRO,
        CINQUE,
        SEI,
        SETTE,
        FANTE,
        CAVALLO,
        RE,
    }

    /// <summary>
    /// The runnable entrypoint of the exercise.
    /// </summary>
    public class Program
    {
        /// <inheritdoc cref="Program" />
        public static void Main()
        {
            DeckFactory df = new DeckFactory();

            df.Names=(Enum.GetNames(typeof(ItalianNames)).ToList());
            df.Seeds=(Enum.GetNames(typeof(ItalianSeeds)).ToList());

            // TODO understand string format convention
            Console.WriteLine("The {1} deck has {0} cards: ", df.DeckSize, "italian");

            foreach (Card c in df.Deck)
            {
                Console.WriteLine(c);
            }

            //test equals

            object o = new int();
            object o2 = new int();
            o = 2;
            o2 = 2;
            Console.WriteLine(o.Equals(o2));
        }
    }
}
