using System;

namespace LearningCSharp
{
    class Song
    {
        // static "attribute" variable
        // NB. This is a class "Song" value, not an instance value
        public static int songCount = 0;

        // Instance variables
        public string title;
        public string artist;
        public int duration;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            // This constructor called every time an object is created
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        // This method enables each Song object access to the "song count"
        public int GetSongCount()
        {
            return songCount;
        }

    }
}
