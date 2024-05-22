﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManagementUniversity.Models;
using SchoolContext_ManagementUniversityContext_ManagementUniversity.Data;

namespace ManagementUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext_ManagementUniversityContext_ManagementUniversity.Data.SchoolContext _context;

        public IndexModel(SchoolContext_ManagementUniversityContext_ManagementUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
