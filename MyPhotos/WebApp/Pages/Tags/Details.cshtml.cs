using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp
{
    public class TagsDetailsModel : PageModel
    {
        ServiceReferencePhotoTag.PhotoTagClient ptc = new ServiceReferencePhotoTag.PhotoTagClient();

        public List<Models.PhotoDTO> Photos;

        public TagsDetailsModel()
        {
            Photos = new List<Models.PhotoDTO>();
        }

        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;

            var tags = await ptc.GetAllTagsAsync();
            foreach(var t in tags)
            {
                if(t.TagId == id.Value)
                {
                    ViewData["Tag"] = t.TagId.ToString() + " : " + t.Type + ", " + t.Name;
                    foreach (var p in t.Photos)
                    {
                        Models.PhotoDTO pdto = new Models.PhotoDTO();
                        pdto.PhotoId = p.PhotoId;
                        pdto.Path = p.Path;
                        pdto.CreatedAt = p.CreatedAt;
                        Photos.Add(pdto);
                    }
                    break;
                }
            }
        }
    }
}