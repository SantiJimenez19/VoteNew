

namespace VoteNew.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    
    public class DataContext : DbContext
    {
        public DbSet<Candidate> Candidates{ get; set; }

        public DataContext()
        {
                
        }


    }
}
