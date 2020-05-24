using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class TagDTO
    {
        public TagDTO()
        {
            this.Photos = new List<PhotoDTO>();
        }
        public int TagId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public virtual IList<PhotoDTO> Photos { get; set; }
    }
}
