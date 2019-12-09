using System;

public enum FaceValue { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
public enum SuitValue { Diamonds, Clubs, Hearts, Spades };

public class Card
{
    public FaceValue Face { get; private set; }
    public SuitValue Suit { get; private set; }

    public Card(SuitValue suit, FaceValue face)
    {
    	this.Face = face;
        this.Suit = suit;
     }

	public override string ToString()
    {
       	return Face + " of " + Suit;
    }

}

public class Deck
{
    private Card[] deck;
    private Random random = new Random();

    public Deck()
    {
   	var suits = Enum.GetNames(typeof(SuitValue)).Length;
        var faces = Enum.GetNames(typeof(FaceValue)).Length;

         int deckSize = suits * faces;
         deck = new Card[deckSize];

	int i = 0;
        
	foreach (SuitValue Suit in Enum.GetValues(typeof(SuitValue)))
        {
            foreach (FaceValue Face in Enum.GetValues(typeof(FaceValue)))
            {
            	Card card = new Card(Suit, Face);
                deck[i++] = card;
             }
        }
    }
}
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
