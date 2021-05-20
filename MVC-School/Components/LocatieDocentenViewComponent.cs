using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_School.Data;
using Microsoft.AspNetCore.Mvc;

namespace MVC_School.Components
{
    public class LocatieDocentenViewComponent : ViewComponent
    {
        private readonly SchoolDbContext _context;


        public LocatieDocentenViewComponent(SchoolDbContext context)
        {
            _context = context;
        }
    }

}
