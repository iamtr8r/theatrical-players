using System;
using System.Collections.Generic;
using System.Text;

namespace theatrical_players.Play
{
    public class Play
    {
        public Play(string id, string type)
        {
            Id = id;
            Type = type;
        }

        public string Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Performance.Performance> Performances { get; set; } = new List<Performance.Performance>();
    }
}
