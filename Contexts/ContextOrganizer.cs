using Microsoft.EntityFrameworkCore;

namespace tech_test_payment_api.Contexts
{
    public class ContextOrganizer : DbContext
    {
        public ContextOrganizer(DbContextOptions<ContextOrganizer> options) : base (options)
        {

        }
    }
}