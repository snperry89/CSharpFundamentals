using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    // interface between data and front end
    {
        // a field is a variable that exists within the class level
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD methods below: anytime you interact with data
        // Create, Read, Update, Delete

        // Content
        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        // Movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        // Show


        // Episode

        // Read All

        // Content Read All
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //Movie Read All
        public List<Movie> GetMovies()
        {
            // initialize empty list
            List<Movie> allMovies = new List<Movie>();
            // Look through our directory
            foreach (StreamingContent content in _contentDirectory)
            {
                // check if object is a Movie class
                if (content is Movie)
                {
                    // Load into our list
                    allMovies.Add((Movie)content); //instead of ((Movie)content) could do (content as Movie)

                }
            }
            // Return our list
            return allMovies;
        }
        // Show Read All
        public List<Show> GetShows()
        {
            // setup our list
            List<Show> allShows = new List<Show>();
                // Find our shows
            foreach(StreamingContent content in _contentDirectory)
            {
                //Check that it is a show
                if (content.GetType() == typeof(Show))
                {
                    // Yes? Add to the listTeam
                    allShows.Add((Show)content);
                }
            }
            // Give shows back
            return allShows;
        }

        // Episode Read All

        // Get By Title

        // Content
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())  // makes so search results arent case sensitive
                {
                    return content;
                }
            }
            return null;        // once you hit a return keyword, you break out of the method altogether
        }
        // Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {                       // Using is to make sure movie 'is' of class type Movie
                if (movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    // using 'as' as a way to cast
                    return (Movie)movie;
                }
            }
            return null;
        }
        // Show
        // GetShowByTitle
        // Accessor // Return Type // Name (Parameters)
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }

            return null;
        }



        //public List<StreamingContent> GetContents()------// ???where does this go???
        //{
        //    return _contentDirectory;
        //}



        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if (contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
