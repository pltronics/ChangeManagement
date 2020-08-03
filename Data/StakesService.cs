using System;
using System.Linq;
using System.Threading.Tasks;
using ChangeManagement.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Data.Entity;



namespace ChangeManagement.Data
{
    public class StakesService
    {
        private readonly StakeContext _context;
        public StakesService(StakeContext context)
        {
            _context = context;
        }
        public Task<List<Stake>> GetStakesAsync()
        {
            return Task.FromResult(_context.Set<Stake>().FromSqlRaw("Select s.Id, s.Description, sq.Question, sq.Examples, ss.Signer AS Signers from Stakes s LEFT JOIN StakeQuestions sq ON s.Id = sq.StakeId Left Join StakeSigners ss ON s.Id = ss.StakeId where (s.EndDate <= GetDate() OR s.EndDate IS NULL) AND (sq.EndDate <= GetDate() OR sq.EndDate IS NULL) AND (ss.EndDate <= GetDate() OR ss.EndDate IS NULL)").ToList());
        }
        public Task AddStakeAsync(string description, string question, string examples, string signers)
        {
            Console.WriteLine("Adding Stake");
            return Task.FromResult(_context.Database.ExecuteSqlRaw(
                "Execute AddStake '" + 
                    description + "', '" +
                    question + "', '" +
                    examples + "', '" +
                    signers + "', 'Person'"));
        }
    }
}
