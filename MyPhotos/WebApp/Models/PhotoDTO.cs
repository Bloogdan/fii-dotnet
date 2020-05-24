using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PhotoDTO
    {
        public PhotoDTO()
        {
            this.Tags = new List<TagDTO>();
        }
        public int PhotoId { get; set; }
        public string Path { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public virtual IList<TagDTO> Tags { get; set; }
    }
}
