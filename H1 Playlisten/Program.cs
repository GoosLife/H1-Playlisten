using System;
using System.Collections.Generic;

namespace H1_Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create array of tracks to add to playlist
            Track[] tracks = new Track[]
            {
                new Track("Willy Oneka", "Charlie and the Chocolate Factories"),
                new Track("The Second Track", "The 2th Fairy"),
                new Track("Third Time's The Charm", "Threehuggers"),
                new Track("Fourk you", "The Quadripeds")
            };

            // Create playlist 
            Playlist myFirstPlaylist = new Playlist("My first playlist");
            for (int i = 0; i < tracks.Length; i++)
            {
                myFirstPlaylist.Tracks.AddLast(tracks[i]);
            }

            // Create new array of tracks to add to new playlist
            Track[] americanIdiotTracks = new Track[]
            {
                new Track("American Idiot","Green Day"),
                new Track("Jesus of Suburbia","Green Day"),
                new Track("Holiday/Boulevard of Broken Dreams","Green Day")
            };

            // Create playlist with pre-determined tracks.
            Playlist americanIdiotPlaylist = new Playlist("American Idiot");

            for (int i = 0; i < americanIdiotTracks.Length; i++)
            {
                americanIdiotPlaylist.Tracks.AddLast(americanIdiotTracks[i]);
            }

            // Add a new track to playlist by creating the track object in the method call as a parameter.
            americanIdiotPlaylist.Tracks.AddLast(new Track("Are We The Waiting?", "Green Day"));

            // Add Give Me Novacaine
            Track giveMeNovacaine = new Track("Give Me Novacaine", "Green Day");
            americanIdiotPlaylist.Tracks.AddLast(giveMeNovacaine);

            // Add Extraordinary Girl before Give Me Novacaine
            Track extraordinaryGirl = new Track("Extraordinary Girl", "Green Day");
            // In order to AddBefore, I have to find the LinkedListNode associated with the track I want to add before.
            americanIdiotPlaylist.Tracks.AddBefore(americanIdiotPlaylist.Tracks.Find(giveMeNovacaine), extraordinaryGirl);

            // Write songs from playlist to console.
            Console.WriteLine("Songs in playlist " + americanIdiotPlaylist.Name + ":\n");
            foreach (Track t in americanIdiotPlaylist.Tracks)
            {
                Console.WriteLine(t.SongName + " by " + t.Artist);
            }

            Console.ReadKey();
        }
    }
}
