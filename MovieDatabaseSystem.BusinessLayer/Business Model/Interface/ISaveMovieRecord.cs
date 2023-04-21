using MovieDatabaseSystem.Common.Models.ViewModels;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Interface
{
    public interface ISaveMovieRecord
    {
        bool Save(MovieDatabaseRecordViewModel movieRecord);
    }
}