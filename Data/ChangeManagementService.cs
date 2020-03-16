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
            return Task.FromResult(_context.Database.ExecuteSqlRaw("insert into dbo.Changes (Title, Description, Owner, CreatedOn, Status) Values ('New!Change!', 'Description3','the change owner4',GetDate(), 'NotCompleted' )"));
        }
        public Task<List<Stake>> GetStakesAsync()
        {
            return Task.FromResult(_context.Set<Stake>().FromSqlRaw("Select s.Description, sq.Question, sq.Examples, ss.Signer AS Signers from Stakes s LEFT JOIN StakeQuestions sq ON s.Id = sq.StakeId Left Join StakeSigners ss ON s.Id = ss.StakeId where (s.EndDate <= GetDate() OR s.EndDate IS NULL) AND (sq.EndDate <= GetDate() OR sq.EndDate IS NULL) AND (ss.EndDate <= GetDate() OR ss.EndDate IS NULL)").ToList());
        }
    }
}
