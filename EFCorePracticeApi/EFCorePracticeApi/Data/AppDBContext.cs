using Microsoft.EntityFrameworkCore;

namespace EFCorePracticeApi.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
    
        
    }
}
