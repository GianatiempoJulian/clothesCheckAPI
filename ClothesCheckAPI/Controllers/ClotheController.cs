using ClothesCheckAPI.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ClothesCheckAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClotheController : Controller
    {
        public async Task <ClotheDTO> GetClothes()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task <ClotheDTO> GetClothe(long id)
        {
            throw new NotImplementedException();
        }
    }
}
