using AspCRUD.Interfaces;
using AspCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : Controller
    {
        private readonly ISongService _productService;

        public SongController(ISongService songService)
        {
            _productService = songService;
        }

        [HttpGet]
        public List<Song> GetAll()
        {
             return (_productService.GetAll());
        }

        [HttpPost]
        public string Create( Song song)
        {
            if (_productService.Post(song))
            {
                return "Created ";
            }
            return "no Created no";
        }

        [HttpPatch("{id}")]
        public Song Update(int id)
        {
            return (_productService.Update(id));
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            if(_productService.Delete(id))
            {
                return "Deleted ";
            }
            return "no Deleted no";
        }    
    }
}
