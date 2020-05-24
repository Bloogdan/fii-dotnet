using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp
{
    public class PhotosIndexModel : PageModel
    {
        ServiceReferencePhotoTag.PhotoTagClient ptc = new ServiceReferencePhotoTag.PhotoTagClient();
        public List<Models.PhotoDTO> Photos { get; set; }

        public PhotosIndexModel()
        {
            Photos = new List<Models.PhotoDTO>();
        }
        public async Task OnGetAsync()
        {
            var photos = await ptc.GetAllPhotosAsync();
            foreach (var item in photos)
            {
                Models.PhotoDTO pdto = new Models.PhotoDTO();
                pdto.CreatedAt = item.CreatedAt;
                pdto.Deleted = item.Deleted;
                pdto.Path = item.Path;
                pdto.PhotoId = item.PhotoId;
                foreach (var t in item.Tags)
                {
                    Models.TagDTO tdto = new Models.TagDTO();
                    tdto.Name = t.Name;
                    tdto.TagId = t.TagId;
                    tdto.Type = t.Type;
                    pdto.Tags.Add(tdto);
                }
                Photos.Add(pdto);
            }
        }
    }
}