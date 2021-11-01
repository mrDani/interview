
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class Service : IServices
    {
        private AppDbContext _context;

        public Service(AppDbContext context)
        {
            _context = context;
        }


    }
}
