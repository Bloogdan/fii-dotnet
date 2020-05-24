using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp
{
    public class TagsIndexModel : PageModel
    {
        ServiceReferencePhotoTag.PhotoTagClient ptc = new ServiceReferencePhotoTag.PhotoTagClient();

        public List<Models.TagDTO> Tags;
        public TagsIndexModel()
        {
            Tags = new List<Models.TagDTO>();
        }
        public async Task OnGetAsync()
        {
            var tags = await ptc.GetAllTagsAsync();
            foreach(var t in tags)
            {
                Models.TagDTO tdto = new Models.TagDTO();
                tdto.TagId = t.TagId;
                tdto.Type = t.Type;
                tdto.Name = t.Name;
                Tags.Add(tdto);
            }
            Tags.Sort(new Comparer());
        }
    }
}