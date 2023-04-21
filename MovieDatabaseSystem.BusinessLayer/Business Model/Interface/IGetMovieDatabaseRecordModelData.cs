using MovieDatabaseSystem.Common.Models.ViewModels;
using System.Collections.Generic;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Interface
{
    public interface IGetMovieDatabaseRecordModelData
    {
        List<MovieDatabaseRecordViewModel> MovieDatabaseRecordModel();
    }
}