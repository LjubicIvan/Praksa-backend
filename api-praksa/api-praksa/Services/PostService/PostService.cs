﻿using System;
using api_praksa.Controllers.Models;
using api_praksa.Controllers;
using api_praksa.Services;


namespace api_praksa.Services.PostService
{
	public class PostService:IPostService

    {
        private static List<Post> Posts = new List<Post>
            {
                new Post{Id=1,Title="Test title",Description="test description",Text="test texta"},
                new Post{Id=2,Title="Test title2",Description="test description2",Text="test texta2"},
                                new Post{Id=3,Title="Test title2",Description="test description2",Text="test texta2"},

            };





        public List<Post> AddPost(Post postId)
        {
            Posts.Add(postId);
            return Posts;
        }




        public List<Post>? DeletePost(int id)
        {

            var postId = Posts.Find(x => x.Id == id);

            if (postId is null)
                return null;

            Posts.Remove(postId);
            return Posts;
        }





        public Post GetSinglePost(int id)
        {
            var postId = Posts.Find(x => x.Id == id);

            if (postId is null)
                return null;
            return postId;
        }





        public List<Post>? UpdatePost(int id, Post request)
        {
            var postId = Posts.Find(x => x.Id == id);

            if (postId is null)
                return null;


            postId.Title = request.Title;
            postId.Description = request.Description;
            postId.Text = request.Text;

            return Posts;
        }


        List<Post> IPostService.GetAllPosts()
        {
            return Posts;
        }
    }
}

