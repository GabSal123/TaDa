using Microsoft.AspNetCore.Mvc;
using QuickMedik.Model;
using QuickMedik.Data;
using Microsoft.EntityFrameworkCore;
namespace QuickMedik.Controllers
{
    [Route("api/ProffesionalAPI")]
    [ApiController]
    public class ProffesionalController : ControllerBase
    {

        private readonly DataBaseContext _dbContext;

        public ProffesionalController(DataBaseContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /*[HttpPost]
        public async Task<IActionResult> Create(string name, string surname, string email, string phone, string workSpaceId)
        {
            string Id = "belekas";


        }*/
    }
}
