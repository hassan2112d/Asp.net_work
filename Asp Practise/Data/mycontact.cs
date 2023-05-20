

using Microsoft.EntityFrameworkCore;

namespace Asp_Practise.Data
{
    public class mycontact :DbContext
    {
    
       public mycontact(DbContextOptions<mycontact> options) : base(options)
        {
        
        
        }
    
    }
}
