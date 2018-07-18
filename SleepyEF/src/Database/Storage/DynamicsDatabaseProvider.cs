using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace SleepyEF.EntityFrameworkCore.Dynamics.Database.Storage
{
    public class DynamicsDatabaseProvider : IDatabaseProvider
    {
        public bool IsConfigured(IDbContextOptions options)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
    }
}