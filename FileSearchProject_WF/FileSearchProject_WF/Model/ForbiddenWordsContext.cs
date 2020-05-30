using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearchProject_WF.Model
{
    public class ForbiddenWordsContext:DbContext
    {
        public ForbiddenWordsContext():base("MyConString")
        {
            Database.SetInitializer<ForbiddenWordsContext>
                (new DropCreateDatabaseIfModelChanges<ForbiddenWordsContext>());
        }

        public DbSet<Statistic> statisticClass { set; get; }
        public DbSet<TopWords> TopWords { set; get; }
    }
}
