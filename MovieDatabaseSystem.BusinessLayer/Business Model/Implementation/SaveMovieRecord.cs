using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Common.Models.ViewModels;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation
{
    public class SaveMovieRecord : ISaveMovieRecord
    {
        private readonly IInsertMovieRecord _insertMovieRecord;

        public SaveMovieRecord(IInsertMovieRecord insertMovieRecord)
        {
            _insertMovieRecord = insertMovieRecord;
        }

        public bool Save(MovieDatabaseRecordViewModel movieRecord)
        {
            bool isSaved = _insertMovieRecord.Insert(movieRecord);
            return isSaved;
        }
    }
}