using System;

namespace MavenThought.MovieLibrary
{
    /// <summary>
    /// Args for movie library events
    /// </summary>
    public class MovieLibraryArgs : EventArgs
    {
        public IMovie Movie { get; set; }

        public bool Equals(MovieLibraryArgs obj)
        {
            return !ReferenceEquals(null, obj) && (ReferenceEquals(this, obj) || Equals(obj.Movie, Movie));
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) &&
                   (ReferenceEquals(this, obj) ||
                    (obj is MovieLibraryArgs && Equals((MovieLibraryArgs) obj)));
        }

        public override int GetHashCode()
        {
            return Movie.GetHashCode();
        }
    }
}