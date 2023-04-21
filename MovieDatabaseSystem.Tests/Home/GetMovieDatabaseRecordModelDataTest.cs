using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Common.Models.ViewModels;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using System.Collections.Generic;

namespace MovieDatabaseSystem.Tests.Home
{
    [TestClass]
    public class GetMovieDatabaseRecordModelDataTest
    {
        private Mock<IGetMovieRecordsFromDB> _getMovieRecordsFromDB;
        private IGetMovieDatabaseRecordModelData getMovieDatabaseRecordModelData;

        [TestInitialize]
        public void TestInit()
        {
            _getMovieRecordsFromDB = new Mock<IGetMovieRecordsFromDB>();
            getMovieDatabaseRecordModelData = new GetMovieDatabaseRecordModelData(_getMovieRecordsFromDB.Object);
        }

        [TestMethod]
        public void When_I_Call_MovieDatabaseRecordModel_Then_GetRecords_Will_Be_Called_Once()
        {
            List<MovieDatabaseRecordViewModel> movieDatabaseRecordViewModel = new List<MovieDatabaseRecordViewModel>()
            {
                new MovieDatabaseRecordViewModel()
                {
                   Id = 1,
                   Title = "La La Land",
                   CategoryId = 2,
                   Category = "Romance",
                   Runtime = "3:50",
                   ReleasedDate = "02/17/19",
                   Director = "Bing George",
                   Rating = "7.5",
                   Description = "Face the world of Dance-Offs in this awsome movie" 
                },
                new MovieDatabaseRecordViewModel()
                {
                   Id = 2,
                   Title = "Jupiter Ascending",
                   CategoryId = 5,
                   Category = "Sci-Fi",
                   Runtime = "1:38",
                   ReleasedDate = "07/18/15",
                   Director = "Ryan Coogler",
                   Rating = "5.5",
                   Description = "Jupiter a high school teen learns about her new life along with her newly aquired powers."
                }
            };

            _getMovieRecordsFromDB.Setup(x => x.GetRecords()).Returns(movieDatabaseRecordViewModel);

            //When I call MovieDatabaseRecordModel
            getMovieDatabaseRecordModelData.MovieDatabaseRecordModel();

            //Then I GetRecords will be called once
            _getMovieRecordsFromDB.Verify(x => x.GetRecords(), Times.Once);
        }
    }
}
