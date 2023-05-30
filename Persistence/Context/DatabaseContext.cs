using Microsoft.EntityFrameworkCore;
using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    internal class DatabaseContext:DbContext, ContextInterface
    {
        DbSet<Profile> Profiles { get; set; }
    }
}
