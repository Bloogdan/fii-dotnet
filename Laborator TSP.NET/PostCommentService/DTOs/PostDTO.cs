using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostCommentService
{
    [DataContract]
    public partial class PostDTO
    {
        public PostDTO()
        {
            this.Comments = new List<CommentDTO>(); //new HashSet<Comment>();
        }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public virtual List<CommentDTO> Comments { get; set; }
    }

}
