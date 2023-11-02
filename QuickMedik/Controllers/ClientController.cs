using Microsoft.AspNetCore.Mvc;
using QuickMedik.Model;
using QuickMedik.Data;
using Microsoft.EntityFrameworkCore;
namespace QuickMedik.Controllers
{

    [Route("api/ClientAPI")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;

        public ClientController(DataBaseContext dbContext)
        {
            this._dbContext = dbContext;
        }


        /*[HttpPost]
        public async Task<IActionResult> Create()
        {
            Client client = new Client
            {
                
            };
        }*/
    }
}
