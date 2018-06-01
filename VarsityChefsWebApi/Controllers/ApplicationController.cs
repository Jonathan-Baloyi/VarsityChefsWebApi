﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using VarsityChefsWebApi.data.DbContext;
using VarsityChefsWebApi.Models;

namespace VarsityChefsWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ApplicationController : Controller
    {
        private ApplicationDbContext context;

        public ApplicationController(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        //// GET api/values
        //[HttpGet]
        //public async Task<IEnumerable<Application>> Get()
        //{
        //    return await context.Applications.ToListAsync();
        //}

        // GET
        [HttpGet("{email}")]
        public async Task<Application> Get(string email)
        {
            return await context.Applications
                .Where(x => x.Email == email)
                .Include(a => a.AlternativePerson)
                .ThenInclude(p => p.AlternativeAddress)
                .Include(postal => postal.PostalAddress)
                .Include(res => res.ResidentialAddress)
                .FirstAsync();
        }

        //[HttpGet]
        //[Route("/api/login")]
        //public bool Login([FromQuery] string email, [FromQuery] string password)
        //{
        //    var user = context.Applications.FirstOrDefault(x => x.Email == email);
        //    bool loggedIn = false;

        //    if ( user != null && user.Password == password)
        //    {
        //         loggedIn = true;
        //    } else
        //    {
        //        loggedIn = false;
        //    }
        //    return loggedIn;    
        //}

        // POST
        [HttpPost]
        public string Post([FromBody] Application application)
        {
            if (context.Applications.FirstOrDefault(x => x.Email == application.Email) != null)
            {
                return "Email already exist";
  
            } 
            application.IsDeleted = false;
            context.Applications.Add(application);
            context.SaveChanges();
            return "Successfully saved";
        }

        // PUT
        [HttpPut("{id}")]
        public Application Put(int id, [FromBody] Application application)
        {
            if (id != application.Id)
            {
                throw new Exception("invalid operation");
            }

            context.Applications.Update(application);
            context.SaveChanges();

            return application;

        }

        // DELETE 
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var student = context.Applications.Find(id);
        //    student.IsDeleted = true; // Soft Delete
        //    context.Applications.Update(student);
        //    context.SaveChanges();

        //}
    }
}