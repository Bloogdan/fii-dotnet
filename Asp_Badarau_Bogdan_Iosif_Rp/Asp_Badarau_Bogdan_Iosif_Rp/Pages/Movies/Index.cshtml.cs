using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp_Badarau_Bogdan_Iosif_Rp.Data;
using Asp_Badarau_Bogdan_Iosif_Rp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp_Badarau_Bogdan_Iosif_Rp
{
    public class IndexModel : PageModel
    {
        private readonly Asp_Badarau_Bogdan_Iosif_Rp.Data.Asp_Badarau_Bogdan_Iosif_RpContext _context;

        public IndexModel(Asp_Badarau_Bogdan_Iosif_Rp.Data.Asp_Badarau_Bogdan_Iosif_RpContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync(); 
        }
    }
}
