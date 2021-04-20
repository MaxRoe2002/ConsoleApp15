using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
   public class NetworkApp
    {
        private readonly NewsFeed news = new NewsFeed();

        /// <summary>
        /// Displays the menu for the user
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("   Max's Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "Remove Post", "Display All",
                "Display By Author", "Display by Date",
                "Add Comment", "Like Posts", "Unlike Posts",
                "Quit"
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
                    case 9: UnlikePosts(); break;
                    case 10: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }
        /// <summary>
        /// Unlikes a post
        /// </summary>
        private void UnlikePosts()
        {
            Console.WriteLine("Unlike a post");
            Post post = FindPost();

            post.Unlike();
        }
        /// <summary>
        /// Likes a post
        /// </summary>
        private void LikePosts()
        {
            Console.WriteLine("Like a post");
            Post post = FindPost();

            post.Like();
        }
            /// <summary>
            /// Adds a comment
            /// </summary>
        private void AddComment()
        {
            Console.WriteLine("Add a comment to a post");
            Post post = FindPost();
            post.Display();

            Console.WriteLine("Enter your comment: ");
            string comment = Console.ReadLine();
            post.AddComment(comment);
        }
        /// <summary>
        /// Displays all posts by a specific user
        /// </summary>
        private void DisplayByAuthor()
        {
            Console.WriteLine("What users posts do you want to find?");
            string author = Console.ReadLine();

            news.FindPostByUser(author);
        }
        /// <summary>
        /// Displays the posts on a specific date
        /// </summary>
        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Removes a previous post the user has made
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Enter the post id > ",
                1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }
        /// <summary>
        /// Displays all the posts available to see
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }
        /// <summary>
        /// Posts an image
        /// </summary>
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
        /// <summary>
        /// Posts a message
        /// </summary>
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
        /// <summary>
        /// Finds a post using a specific ID
        /// </summary>
        /// <returns></returns>
        public Post FindPost()
        {
            int postID;
            postID = (int)ConsoleHelper.InputNumber("Enter the ID of the post");
            return news.FindPost(postID);
        }
        /// <summary>
        /// Allows the user to input their name so they can see who posted the post
        /// </summary>
        /// <returns></returns>
        private string InputName()
        {
            Console.Write(" Enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
