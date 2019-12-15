using System;				

public class Card
{
	private string face;
	private string suit;
	
	public Card(string cardFace, string cardSuit) // constructor
	{
		face = cardFace;
		suit = cardSuit;
	}
	
	public override string ToString() // override - to provide my own define tostring function
	{
		return face + " of " + suit; // ex. 3 of hearts
	}
}

public class Deck
{
	private Card[] deck; // an array of cards called deck
	private int currentCard; // keeep track where in the deck
	private const int numOfCards = 52;
	Random rand; // for the shuffle function
	
	public Deck() // constructor
	{
		string[] faces = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
		string[] suits = {"Spade", "Club", "Hearts", "Diamonds"};
		deck = new Card[numOfCards];
		currentCard = 0;
		rand = new Random();
		
		for(int count = 0; count < deck.Length; count++)
		{
			deck[count] = new Card(faces[count % 11], suits[count / 13]);
		}
	}
	
	public void Shuffle()
	{
		currentCard = 0;
		for(int firstCard = 0; firstCard < deck.Length; firstCard++)
		{
			int secondCard = rand.Next(numOfCards);
			Card temp = deck[firstCard];
			deck[firstCard] = deck[secondCard];
			deck[secondCard] = temp;
		}
	}
	
	public Card DealCard()
	{
		if(currentCard < deck.Length)
			return deck[currentCard++];
		else
			return null;
	}
}

public class Player
{
	public string newPlayrer = "Player";
	public int drawCount = 0;
	//public Card currentCard = new Card(faces, suits);
	public Deck myDeck = new Deck();
}

public class Program
{
	 public static void Main()
	 {
	 	Deck newDeck = new Deck();
		newDeck.Shuffle();
		for(int i = 0; i < 8; i++)
		{
			Console.WriteLine("{0, -19}", newDeck.DealCard());
			if((i + 1) % 4 == 0)
				Console.WriteLine();
		}
		 Console.ReadLine();
	 }
}
