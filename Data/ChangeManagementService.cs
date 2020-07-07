using System;
using System.Linq;
using System.Threading.Tasks;
using ChangeManagement.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChangeManagement.Data
{
    public class ChangeManagementService
    {
        private readonly ChangeContext _context;
        public ChangeManagementService(ChangeContext context)
        {
            _context = context;
        }
        
        public Task<List<Change>> GetChangesAsync()
        {
            return Task.FromResult(_context.Set<Change>().FromSqlRaw("Select c.Id, c.Title, c.Description, c.CreatedOn from Changes c").ToList());
        }
        public Task DeleteChangesAsync()
        {
            return Task.FromResult(_context.Database.ExecuteSqlRaw("Delete From [dbo].[Changes] where 1=1"));
        }
        public Task AddChangeAsync()
        {
            Console.WriteLine("AddingChange");
            return Task.FromResult(_context.Database.ExecuteSqlRaw("insert into dbo.Changes (Title, Description, Owner, CreatedOn) Values ('New!Change!', 'Description3','the change owner4',GetDate())"));
        }

    }
}
