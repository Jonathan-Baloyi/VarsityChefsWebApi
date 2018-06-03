using AuthWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarsityChefsWebApi.data.DbContext;
using VarsityChefsWebApi.Models;

namespace VarsityChefsWebApi.Controllers
{
    public class ApplicantController: Controller
    {
        private ApplicationDbContext context;

        public ApplicantController(ApplicationDbContext _context)
        {
            this.context = _context;
        }


        // GET
        [HttpGet("{IdentityId}")]
        public async Task<RegistrationViewModel> GetById(string IdentityId)
        {
            var user = await context.Applicants
                .Where(x => x.IdentityId == IdentityId)
                .Include(a => a.Identity)
                .FirstAsync();

                RegistrationViewModel reg = new RegistrationViewModel();
                reg.FirstName = user.Identity.FirstName;
                reg.LastName = user.Identity.LastName;
                reg.Email= user.Identity.Email;
                reg.PhoneNumber = user.Identity.PhoneNumber;
            return reg;
        }
    }
}
