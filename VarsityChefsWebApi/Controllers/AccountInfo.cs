using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsityChefsWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize(Policy = "ApiUser")]
    public class AccountInfo : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly UserManager < AppUser > _userManager;
        private readonly IMapper _mapper;


        public AccountsController(UserManager < AppUser > userManager, IMapper mapper, ApplicationDbContext appDbContext)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }


        [HttpGet("{id}")]
        [Authorize]
        public async Task<Applicant> GetById(int id) {
            return await _appDbContext.Applicants
                .Where(x => x.Id == id)
                .Include(u => u.Identity)
                .FirstAsync();
        }
    }     
}
