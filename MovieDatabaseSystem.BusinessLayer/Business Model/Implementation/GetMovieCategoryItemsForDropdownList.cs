using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using MovieDatabaseSystem.Entities.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation
{
    public class GetMovieCategoryItemsForDropdownList: IGetMovieCategoryItemsForDropdownList
    {
        private readonly IGetMovieCategoryFromDB _getMovieCategoryFromDB;
        private readonly IBuildMovieCategoryForDropdownList _buildMovieCategoryForDropdownList;

        public GetMovieCategoryItemsForDropdownList (IGetMovieCategoryFromDB getMovieCategoryFromDB, IBuildMovieCategoryForDropdownList buildMovieCategoryForDropdownList)
        {
            _getMovieCategoryFromDB = getMovieCategoryFromDB;
            _buildMovieCategoryForDropdownList = buildMovieCategoryForDropdownList;
        }

        public List<SelectListItem> GetMoviecategories()
        {
            List<MovieCategory> movieCategories = _getMovieCategoryFromDB.GetCategories();
            List<SelectListItem> movieCategoryDrpdownListItems = _buildMovieCategoryForDropdownList.BuildMovieCategorySelectListModel(movieCategories);

            return movieCategoryDrpdownListItems;
        }
    }
}