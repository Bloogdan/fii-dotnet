using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PostCommentService
{
    [DataContract(IsReference = true)]
    public partial class CommentDTO
    {
        [DataMember]
        public int CommentId { get; set; }
        [DataMember]
        public string CommentText { get; set; }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public int PostPostId { get; set; }
        [DataMember]
        public virtual PostDTO Post { get; set; }
    }
}
