using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.Tests.Home
{
    [TestClass]
    public class GetMovieHomePageDataTest
    {
        private Mock<IGetMovieCategoryItemsForDropdownList> _getMovieCategoryItemsForDropdownList;
        private IGetMovieHomePageData getMovieHomePageData;

        [TestInitialize]
        public void TestInit()
        {
            _getMovieCategoryItemsForDropdownList = new Mock<IGetMovieCategoryItemsForDropdownList>();
            getMovieHomePageData = new GetMovieHomePageData(_getMovieCategoryItemsForDropdownList.Object);
        }

        [TestMethod]
        public void When_I_Call_GetHomePageData_Then_GetMoviecategories_Gets_Called_Once()
        {
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

            _getMovieCategoryItemsForDropdownList.Setup(x => x.GetMoviecategories()).Returns(selectCategory);

            //When I call GetHomePageData
            getMovieHomePageData.GetHomePageData();

            //Then GetMoviecategories gets called once
            _getMovieCategoryItemsForDropdownList.Verify(x => x.GetMoviecategories(), Times.Once);
        }
    }
}
