using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Common.Models.ViewModels;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;

namespace MovieDatabaseSystem.Tests.Home
{
    [TestClass]
    public class SaveMovieRecordTest
    {
        private Mock<IInsertMovieRecord> _insertMovieRecord;
        private ISaveMovieRecord saveMovieRecord;

        [TestInitialize]
        public void TestInit()
        {
            _insertMovieRecord = new Mock<IInsertMovieRecord>();
            saveMovieRecord = new SaveMovieRecord(_insertMovieRecord.Object);
        }

        [TestMethod]
        public void Given_I_Have_MovieRecord_When_I_Call_Save_Then_I_Verify_Insert_Will_Get_Called_Once()
        {
            //Given I Have MovieRecord
            MovieDatabaseRecordViewModel movieRecord = new MovieDatabaseRecordViewModel()
            {
                Title = "Titanic",
                CategoryId = 1,
                Category = "Romance",
                Runtime = "03:45",
                ReleasedDate = "04/13/1998",
                Director = "James Cameron",
                Rating = "8.5",
                Description = "Love story Jack and Rose over the great Titanic the unsinkable machine"
            };

            _insertMovieRecord.Setup(x => x.Insert(movieRecord)).Returns(true);

            //When I call Save
            saveMovieRecord.Save(movieRecord);

            //Then Insert will be called once
            _insertMovieRecord.Verify(x => x.Insert(movieRecord), Times.Once);
        }
    }
}
