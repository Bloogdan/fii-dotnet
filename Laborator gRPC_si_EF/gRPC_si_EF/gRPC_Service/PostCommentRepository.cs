﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPC_Service
{
    public class PostCommentRepository : IPostCommentRepository
    {
        bool InterfaceComment.AddComment(Comment comment)
        {
            return comment.AddComment();
        }
        bool InterfacePost.AddPost(Post post)
        {
            return post.AddPost();
        }
        int InterfacePost.DeletePost(int id)
        {
            Post post = new Post();
            return post.DeletePost(id);
        }
        Comment InterfaceComment.GetCommentById(int id)
        {
            Comment comment = new Comment();
            return comment.GetCommentById(id);
        }
        Post InterfacePost.GetPostById(int id)
        {
            // E nevoie de ac instanta. Metodele din API sunt metode ale instantei.
            Post post = new Post();
            // Mesaj ce apare in server CUI. Nu e necesar.
            Console.WriteLine("GetPostById. Id = {0}", id);
            post = post.GetPostById(id); // Neclar acest cod.
            Console.WriteLine("Post returnat. Id = {0} , Description = {1}", post.PostId, post.Description);
            return post;
        }
        List<Post> InterfacePost.GetPosts()
        {
            Post post = new Post();
            return post.GetAllPosts();
        }
        Comment InterfaceComment.UpdateComment(Comment newComment)
        {
            return newComment.UpdateComment(newComment);
        }
        Post InterfacePost.UpdatePost(Post post)
        {
            return post.UpdatePost(post);
        }
    }
}
