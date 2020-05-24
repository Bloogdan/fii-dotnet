using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp
{
    public class PhotosDetailsModel : PageModel
    {
        ServiceReferencePhotoTag.PhotoTagClient ptc = new ServiceReferencePhotoTag.PhotoTagClient();
        public List<Models.TagDTO> Tags { get; set; }
        public PhotosDetailsModel()
        {
            Tags = new List<Models.TagDTO>();
        }

        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            var photos = await ptc.GetAllPhotosAsync();
            foreach (var p in photos)
                if (p.PhotoId == id.Value)
                {
                    ViewData["Photo"] = p.PhotoId.ToString() + " : " + p.Path;
                    foreach(var tag in p.Tags)
                    {
                        Models.TagDTO tdto = new Models.TagDTO();
                        tdto.TagId = tag.TagId;
                        tdto.Name = tag.Name;
                        tdto.Type = tag.Type;
                        Tags.Add(tdto);
                    }
                    Tags.Sort(new Comparer());
                    break;
                }
        }
    }
}