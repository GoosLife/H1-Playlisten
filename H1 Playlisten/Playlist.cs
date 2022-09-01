using System.Collections.Generic;

namespace H1_Playlisten
{
    internal class Playlist
    {
        private string name;
        /// <summary>
        /// The name of the playlist.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private LinkedList<Track> tracks;
        /// <summary>
        /// A linked list of all the tracks on the playlist.
        /// </summary>
        public LinkedList<Track> Tracks
        {
            get { return tracks; }
        }

        public Playlist(string name)
        {
            this.name = name;
            tracks = new LinkedList<Track>();
        }
    }
}
