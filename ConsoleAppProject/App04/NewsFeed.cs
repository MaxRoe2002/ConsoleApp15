﻿using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///  edited by Max Roe
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
        }

        public Post Post
        {
            get => default;
            set
            {
            }
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($" \n The post with ID = {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($" \nThe post {id} has been deleted! \n");

                posts.Remove(post);
            }
        }

        public Post FindPost(int id)
        {
            foreach(Post post in posts)
            {
                if(post.PostId == id)
                {
                    return post;
                }
            }
            return null;
        }          
        public Post FindPostByUser(string author)
        {
            int counter = 0;

            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                    Console.WriteLine();
                    counter++;
                }
                if (counter == 0)
                {
                    Console.WriteLine("A user has not been found");
                }
            }
            return null;
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
               Console.WriteLine();  
            }
        }
    }

}
