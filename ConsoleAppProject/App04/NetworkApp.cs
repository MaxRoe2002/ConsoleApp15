using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
   public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("   Max's Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "Remove Post", "Display All",
                "Display By Author", "Display by Date",
                "Add Comment", "Like Posts", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.MakeChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Enter the post id > ",
                1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write("Enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write("Enter a caption for the image: ");

            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle(" You have just posted this image");
            post.Display();     
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string author = InputName();

            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have successfully posted this message: ");
            post.Display();
        }

        private string InputName()
        {
            Console.Write(" Enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
