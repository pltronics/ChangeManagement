using System;
using System.Linq;
using System.Threading.Tasks;
using ChangeManagement.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using ChangeManagement.Pages;

namespace ChangeManagement.Data
{
    public class ChangeManagementService
    {
        private readonly ChangeContext _context;
        private string querystring;
        public ChangeManagementService(ChangeContext context)
        {
            _context = context;
        }
        
        public Task<List<Change>> GetChangesAsync()
        {
            return Task.FromResult(_context.Set<Change>().FromSqlRaw("Select c.Id, c.Title, c.Description, c.Owner, c.CreatedOn from Changes c").ToList());
        }
        public Task DeleteChangesAsync()
        {
            return Task.FromResult(_context.Database.ExecuteSqlRaw("Delete From [dbo].[Changes] where 1=1"));
        }
        public Task AddChangeAsync(string title, string description, string owner)
        {
            Console.WriteLine("AddingChange");
            return Task.FromResult(_context.Database.ExecuteSqlRaw("insert into dbo.Changes (Title, Description, Owner, CreatedOn) Values ('"+ title + "', '" + description + "','"+ owner +"',GetDate())"));
        }
        public Task<List<Note>> GetNotesAsync(int Id)
        {
            querystring = "Execute GetNotes " + "'" + Id + "'";
            return Task.FromResult(_context.Set<Note>().FromSqlRaw(querystring).ToList());
        }
    }
}
