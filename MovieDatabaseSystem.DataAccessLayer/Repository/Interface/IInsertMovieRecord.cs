using MovieDatabaseSystem.Common.Models.ViewModels;

namespace MovieDatabaseSystem.DataAccessLayer.Repository.Interface
{
    public interface IInsertMovieRecord
    {
        bool Insert(MovieDatabaseRecordViewModel movieRecord);
    }
}