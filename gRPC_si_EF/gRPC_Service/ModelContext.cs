using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPC_Service
{
    public partial class ModelPostCommentContainer : DbContext
    {
        public ModelPostCommentContainer(DbContextOptions<ModelPostCommentContainer> options) : base(options)
        {

        }

        public ModelPostCommentContainer() : base()
        {

        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
