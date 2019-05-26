using System;
using System.Collections.Generic;
using System.Text;

namespace theatrical_players.Performance
{
    public class Performance
    {
        public Performance(string playId, int audience)
        {
            PlayId = playId;
            Audience = audience;
        }

        public string PlayId { get; set; }
        public int Audience { get; set; }
    }
}
