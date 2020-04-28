using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPC_Service
{
    public interface InterfacePost
    {
        bool AddPost(Post post);
        Post UpdatePost(Post post);
        int DeletePost(int id);
        Post GetPostById(int id);
        List<Post> GetPosts();
    }
    public interface InterfaceComment
    {
        bool AddComment(Comment comment);
        Comment UpdateComment(Comment newComment);
        Comment GetCommentById(int id);
    }
    public interface IPostCommentRepository : InterfacePost, InterfaceComment
    {

    }
}
