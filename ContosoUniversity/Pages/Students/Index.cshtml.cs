using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Students
{
    public class IndexModel : PageModel
    {
        // Adicionei esse contexto para pegar a quantidade inicial de alunos
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        // Aqui devemos mandar pro index a quantidade de alunos na hora que a chamada foi feita
        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
