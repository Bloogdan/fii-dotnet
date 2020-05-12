using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPC_Service
{
    public partial class PostItem 
    {
        public static PostItem FromRepositoryModel(Post source)
        {
            if (source is null) return null;

            var target = new PostItem
            {
                PostId = source.PostId,
                Description = source.Description,
                Domain = source.Domain,
                Date = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.Date)
            };

            target.Comments.AddRange(source.Comments.Select(CommentItem.FromRepositoryModel));

            return target;
        }
    }

    public partial class CommentItem
    {
        public static CommentItem FromRepositoryModel(Comment source)
        {
            if (source is null) return null;

            return new CommentItem
            {
                CommentId = source.CommentId,
                Text = source.Text,
                PostPostId = source.PostPostId
            };
        }
    }
}
