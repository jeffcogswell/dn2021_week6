using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
	//public class Deck
	//{
	//	public string deck_id { get; set; }
	//	public int remaining { get; set; }
	//}

	public class CardGameCard
	{
		public string code { get; set; }
		public string image { get; set; }
		public string whoHasIt { get; set; }
		public bool inPile { get; set; }
	}

	public class Card
	{
		public string code { get; set; }
		public string value { get; set; }
		public string suit { get; set; }
		public string image { get; set; }
	}

	public class CardApiResponse
	{
		public string deck_id { get; set; }
		public int remaining { get; set; }

		public List<Card> cards { get; set; }
	}
}
