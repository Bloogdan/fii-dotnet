using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PostCommentService
{
    [ServiceContract]
    public interface IPostComment : IPost, IComment, ILoadData
    { }
}
