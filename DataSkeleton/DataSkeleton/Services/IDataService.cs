namespace DataSkeleton.Services
{
    using DataSkeleton.Data;
    using System.Collections.Generic;

    public interface IDataService
    {
        List<Cars> GetAll();
    }
}
