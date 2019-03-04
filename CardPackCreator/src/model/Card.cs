using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPackCreator.src.model
{
    class Card
    {
        public string Title { get; set; }
        public string Set { get; set; }
        public string Description { get; set; }
        public string Faction { get; set; }
        public string Rarity { get; set; }
        public int Value { get; set; }

        public Card(String title, String set, String description, String faction, String rarity, int value)
        {
            Title = title;
            Set = set;
            Description = description;
            Faction = faction;
            Rarity = rarity;
            Value = value;
        }

        public string[] ArrayString()
        {
            return new string[] { Title, Set, Description, Faction, Rarity, Value.ToString()};
        }
    }
}
