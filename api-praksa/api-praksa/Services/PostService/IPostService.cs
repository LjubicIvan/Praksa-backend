using System;
namespace api_praksa.Services.PostService
{
	public interface IPostService
	{


        List<Post>? GetAllPosts();

        Post GetSinglePost(int id);

        List<Post>? AddPost(Post postId);

        List<Post>? UpdatePost(int id, Post request);

        List<Post>? DeletePost(int id);

    }
}

