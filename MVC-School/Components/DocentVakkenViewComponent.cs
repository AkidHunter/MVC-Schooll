using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_School.Data;
using Microsoft.AspNetCore.Mvc;

namespace MVC_School.Components
{
    public class DocentVakkenViewComponent : ViewComponent
    {
        private readonly SchoolDbContext _context;


        public DocentVakkenViewComponent(SchoolDbContext context)
        {
            _context = context;
        }
    }

}