using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.DataAccess
{
    public class PepoleContext : DbContext
    {
        public PepoleContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
