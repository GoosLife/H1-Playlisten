using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlisten
{
    internal class Track
    {
        private string songName;

        public string SongName
        {
            get { return songName; }
        }

        private string artist;

        public string Artist
        {
            get { return artist; }
        }

        public Track(string songName, string artist)
        {
            this.songName = songName;
            this.artist = artist;
        }
    }
}
