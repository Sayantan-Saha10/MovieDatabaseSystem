using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using MovieDatabaseSystem.Entities.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.Tests.Home
{
    [TestClass]
    public class GetMovieCategoryItemsForDropdownListTest
    {
        private Mock<IGetMovieCategoryFromDB> _getMovieCategoryFromDB;
        private Mock<IBuildMovieCategoryForDropdownList> _buildMovieCategoryForDropdownList;
        private IGetMovieCategoryItemsForDropdownList getMovieCategoryItemsForDropdownList;

        [TestInitialize]
        public void TestInit()
        {
            _getMovieCategoryFromDB = new Mock<IGetMovieCategoryFromDB>();
            _buildMovieCategoryForDropdownList = new Mock<IBuildMovieCategoryForDropdownList>();
            getMovieCategoryItemsForDropdownList = new GetMovieCategoryItemsForDropdownList(_getMovieCategoryFromDB.Object, _buildMovieCategoryForDropdownList.Object);
        }

        [TestMethod]
        public void When_I_Call_GetMoviecategories_Then_GetCategories_Will_Be_Called_Once()
        {
            List<MovieCategory> movieCategories = new List<MovieCategory>()
            {
                new MovieCategory()
                {
                    CategoryId = 1,
                    CategoryName = "Action"
                },
                new MovieCategory()
                {
                    CategoryId = 2,
                    CategoryName = "Thriller"
                },
                new MovieCategory()
                {
                    CategoryId = 3,
                    CategoryName = "Musical"
                }
            };

            _getMovieCategoryFromDB.Setup(x => x.GetCategories()).Returns(movieCategories);

            //When I call GetMoviecategories
            getMovieCategoryItemsForDropdownList.GetMoviecategories();

            //Then GetCategories will be called once
            _getMovieCategoryFromDB.Verify(x => x.GetCategories(), Times.Once);
        }

        [TestMethod]
        public void When_I_Call_GetMoviecategories_Then_BuildMovieCategorySelectListModel_Will_Be_Called_Once()
        {
            List<MovieCategory> movieCategories = new List<MovieCategory>()
            {
                new MovieCategory()
                {
                    CategoryId = 1,
                    CategoryName = "Action"
                },
                new MovieCategory()
                {
                    CategoryId = 2,
                    CategoryName = "Thriller"
                },
                new MovieCategory()
                {
                    CategoryId = 3,
                    CategoryName = "Musical"
                }
            };

            List<SelectListItem> selectCategory = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = "1",
                    Text = "Action"
                },
                new SelectListItem()
                {
                    Value = "2",
                    Text = "Thriller"
                },
                new SelectListItem()
                {
                    Value = "3",
                    Text = "Musical"
                }
            };

            _getMovieCategoryFromDB.Setup(x => x.GetCategories()).Returns(movieCategories);
            _buildMovieCategoryForDropdownList.Setup(x => x.BuildMovieCategorySelectListModel(movieCategories)).Returns(selectCategory);

            //When I call GetMoviecategories
            getMovieCategoryItemsForDropdownList.GetMoviecategories();

            //Then BuildMovieCategorySelectListModel will be called once
            _buildMovieCategoryForDropdownList.Verify(x => x.BuildMovieCategorySelectListModel(movieCategories), Times.Once);
        }
    }
}
