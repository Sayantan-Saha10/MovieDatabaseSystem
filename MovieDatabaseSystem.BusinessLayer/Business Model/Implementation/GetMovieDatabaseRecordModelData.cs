using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using MovieDatabaseSystem.Entities.Entities;
using MovieDatabaseSystem.Common.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation
{
    public class GetMovieDatabaseRecordModelData : IGetMovieDatabaseRecordModelData
    {
        private readonly IGetMovieRecordsFromDB _getMovieRecordsFromDB;

        public GetMovieDatabaseRecordModelData(IGetMovieRecordsFromDB getMovieRecordsFromDB)
        {
            _getMovieRecordsFromDB = getMovieRecordsFromDB;
        }

        public List<MovieDatabaseRecordViewModel> MovieDatabaseRecordModel()
        {
            List<MovieDatabaseRecordViewModel> movieRecordViewModel = _getMovieRecordsFromDB.GetRecords();
            return movieRecordViewModel;
        }
    }
}