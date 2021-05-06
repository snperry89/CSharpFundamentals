using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SteamingContent_Console
{
    public class ProgramUI
    {
        //  '_' is a naming convention for fields
        //we created a field that is an instance of our streaming content repo
        private StreamingContentRepository _repo = new StreamingContentRepository();

        // create a method that Program.cs will call to start
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            //Console.WriteLine("This is my menu");
            //Console.ReadLine();  ---example---
            bool keepRunning = true;
            while (keepRunning)
            {


                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                // Another option, we're going to use a switch
                //if (input == "1" || input.ToLower() == "one")
                //{

                //}

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        CreateNewContent();
                        //CreateNewContent
                        break;
                    case "2":
                    case "two":
                        //ViewAllContent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        DisplayContentByTitle();
                        //View Content By Title
                        break;
                    case "4":
                    case "four":
                        //Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                    case "five":
                        //Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue:");
                Console.ReadKey();
                Console.Clear();
            }

        }
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content:");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the Star Rating for this content:(0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();

            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine());
            //shorthand to do the same as above 3 lines

            //GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            //Casting -- don't fully understand
            // we receive console read line as string, but needs to be integer
            // in order to get integer to coordinate with genretype (which is an enum) we need to convert (cast) our integer into our genre type at the same numeric value
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //MaturityRating
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA\n");
            //string maturityRatingAsString = Console.ReadLine();
            //int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            //newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;
            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly");
            }
            else
            {
                Console.WriteLine("Could not add the content");
            }

        } // optional challenge - ask the user to confirm information
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = (ConsoleColor.Green);
                Console.WriteLine($"Title:  {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }
        private void DisplayContentByTitle() //get a title from the user then display all properties of the content that has that title.
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("What title are you looking for?");

            StreamingContent contentToDisplay = _repo.GetContentByTitle(Console.ReadLine());

            if (contentToDisplay != null)
            {
                Console.WriteLine($"Title: {contentToDisplay.Title}\n" +
                    $"Description: {contentToDisplay.Description}\n" +
                    $"Star Rating: {contentToDisplay.StarRating}\n" +
                    $"Genre: {contentToDisplay.TypeOfGenre}\n" +
                    $"Maturity Rating: {contentToDisplay.MaturityRating}\n" +
                    $"Is Family Friendly: {contentToDisplay.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("There is no content by that title.");
            }
            //newContent.Title = Console.ReadLine();
            //List<StreamingContent> allContent = _repo.GetContents();
            //foreach (StreamingContent content in allContent)
            //{
            //    if (content.Title == newContent.Title) // && not necessary?
            //    {
            //        Console.WriteLine(newContent.Title);
            //        Console.WriteLine(newContent.Description);
            //        Console.WriteLine(newContent.StarRating);
            //        Console.WriteLine(newContent.TypeOfGenre);
            //        Console.WriteLine(newContent.MaturityRating);

            //    }
            //    else
            //    {
            //        Console.WriteLine("We do not have that title in our database");
            //    }
            //    Console.WriteLine("Please press any key to continue:");
            //Console.ReadKey();


        }
        private void UpdateExistingContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("What is the new title for this content?");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Enter the new description of the content:");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Enter the new Star Rating for this content:(0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();

            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            Console.WriteLine("Enter the new genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
  
            newContent.TypeOfGenre = (GenreType)genreAsInt;


            Console.WriteLine("Enter the new Maturity Rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully");
            }
            else
            {
                Console.WriteLine("No content by that title exists");
            }
        }
        private void DeleteExistingContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }
        }
        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty goes back in time", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the day", 3.1, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on a killing spree", 1.2, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}


// when run, all maturity ratings show family friendly