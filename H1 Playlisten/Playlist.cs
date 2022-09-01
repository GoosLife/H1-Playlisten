using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlisten
{
    internal class Playlist
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private LinkedList<Track> tracks;

        public LinkedList<Track> Tracks
        {
            get { return tracks; }
        }

        public Playlist(string name)
        {
            this.name = name;
        }
    }
}
