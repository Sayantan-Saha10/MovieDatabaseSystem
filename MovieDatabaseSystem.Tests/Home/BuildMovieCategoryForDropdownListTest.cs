using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation;
using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Entities.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.Tests.Home
{
    [TestClass]
    public class BuildMovieCategoryForDropdownListTest
    {
        private IBuildMovieCategoryForDropdownList buildMovieCategoryForDropdownList;

        [TestInitialize]
        public void TestInit()
        {
            buildMovieCategoryForDropdownList = new BuildMovieCategoryForDropdownList();
        }

        [TestMethod]
        public void Given_I_Have_movieCategories_When_I_Call_BuildMovieCategorySelectListModel_Then_I_Will_Get_CategorySelectList_As_Expected()
        {
            //Given I have movieCategories
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

            List<SelectListItem> expected = new List<SelectListItem>()
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

            //When I Call BuildMovieCategorySelectListModel
            var actual = buildMovieCategoryForDropdownList.BuildMovieCategorySelectListModel(movieCategories);

            //Then I will get expected
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [TestMethod]
        public void Given_I_Have_movieCategories_As_Null_When_I_Call_BuildMovieCategorySelectListModel_Then_I_Will_Get_Empty_CategorySelectList()
        {
            //Given I have movieCategories as null
            List<MovieCategory> movieCategories = null;

            List<SelectListItem> expected = new List<SelectListItem>();

            //When I Call BuildMovieCategorySelectListModel
            var actual = buildMovieCategoryForDropdownList.BuildMovieCategorySelectListModel(movieCategories);

            //Then I will get Empty SelectCategoryList
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        [TestMethod]
        public void Given_I_Have_Empty_movieCategories_When_I_Call_BuildMovieCategorySelectListModel_Then_I_Will_Get_Empty_CategorySelectList()
        {
            //Given I have movieCategories as null
            List<MovieCategory> movieCategories = new List<MovieCategory>();

            List<SelectListItem> expected = new List<SelectListItem>();

            //When I Call BuildMovieCategorySelectListModel
            var actual = buildMovieCategoryForDropdownList.BuildMovieCategorySelectListModel(movieCategories);

            //Then I will get Empty SelectCategoryList
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }
    }
}
