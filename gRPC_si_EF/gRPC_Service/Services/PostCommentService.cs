using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;


namespace gRPC_Service
{
    public class PostCommentService : PostComment.PostCommentBase
    {
        private readonly IPostCommentRepository _repository;
        public PostCommentService(IPostCommentRepository repository)
        {
            _repository = repository;
        }

        public override async Task<BooleanResponse> AddPost(PostItem request, ServerCallContext context)
        {
            Post post = new Post()
            {
                PostId = request.PostId,
                Description = request.Description,
                Domain = request.Domain,
                Date = request.Date.ToDateTime()
            };

            BooleanResponse response = new BooleanResponse
            {
                Response = _repository.AddPost(post)
            };

            return response;
        }

        public override async Task<BooleanResponse> AddComment(CommentItem request, ServerCallContext context)
        {
            Comment comment = new Comment()
            {
                CommentId = request.CommentId,
                Text = request.Text,
                PostPostId = request.PostPostId,
                Post = _repository.GetPostById(request.PostPostId)
            };

            BooleanResponse response = new BooleanResponse
            {
                Response = _repository.AddComment(comment)
            };

            return response;
        }
    }
}
