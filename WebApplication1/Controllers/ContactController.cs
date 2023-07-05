using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ContactController:Controller
    {
        [HttpGet("")]
        public List<ContactModel> Get()
        {
            return new List<ContactModel>
            {
                new ContactModel{Id=1, Firstname="Omer",LastName="Balci"}
            };

        }

    }
}
