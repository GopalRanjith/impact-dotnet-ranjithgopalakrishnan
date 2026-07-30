using System;

namespace CSharpLearning
{
    public class Playlist
    {
        private string[] songs =
        {
            "Song1",
            "Song2",
            "Song3",
            "Song4",
            "Song5"
        };

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < songs.Length)
                    return songs[index];

                return "Invalid Index";
            }

            set
            {
                if (index >= 0 && index < songs.Length)
                    songs[index] = value;
            }
        }

        public string this[string song]
        {
            get
            {
                foreach (string s in songs)
                {
                    if (s.Equals(song,
                    StringComparison.OrdinalIgnoreCase))
                        return s;
                }

                return "Song Not Found";
            }
        }
    }
}