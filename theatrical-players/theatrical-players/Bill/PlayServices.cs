using System;
using System.Collections.Generic;
using System.Linq;

namespace theatrical_players.Bill
{
    public class PlayServices
    {
        private Play.Play CurrentItem;
        public List<Play.Play> GetList()
        {
            return new List<Play.Play>()
            {
                new Play.Play(){ Id = "hamlet", Type = "tragedy" },
                new Play.Play(){ Id = "as-like", Type = "comedy" },
                new Play.Play(){ Id = "othello", Type = "tragedy" }
            };
        }

        public Play.Play GetItem(string id)
        {
            var List = GetList();
            CurrentItem = List.FirstOrDefault(x => x.Id == id);
            Validate();
            return CurrentItem;
        }

        private void Validate()
        {
            if (CurrentItem == null)
            {
                throw new Exception("Play not found!");
            }
        }
    }
}
