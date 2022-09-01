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
        /// <summary>
        /// The songs title.
        /// </summary>
        public string SongName
        {
            get { return songName; }
        }

        private string artist;
        /// <summary>
        /// The artist performing the song.
        /// </summary>
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
