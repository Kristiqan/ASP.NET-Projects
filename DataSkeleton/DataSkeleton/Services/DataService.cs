namespace DataSkeleton.Services
{
    using DataSkeleton.Data;
    using DataSkeleton.DataAccess;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DataService : IDataService
    {
        private readonly ApplicationDbContext db;

        public DataService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<Cars> GetAll()
        {
            return db.Cars.ToList();
        }
    }
}
 