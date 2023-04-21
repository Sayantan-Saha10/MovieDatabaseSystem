using MovieDatabaseSystem.Common.Models.ViewModels;
using System.Collections.Generic;

namespace MovieDatabaseSystem.DataAccessLayer.Repository.Interface
{
    public interface IGetMovieRecordsFromDB
    {
        List<MovieDatabaseRecordViewModel> GetRecords();
    }
}