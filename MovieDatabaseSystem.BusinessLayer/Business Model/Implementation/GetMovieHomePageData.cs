using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Common.Models.ViewModels;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation
{
    public class GetMovieHomePageData : IGetMovieHomePageData
    {
        private readonly IGetMovieCategoryItemsForDropdownList _getMovieCategoryItemsForDropdownList;

        public GetMovieHomePageData(IGetMovieCategoryItemsForDropdownList getMovieCategoryItemsForDropdownList)
        {
            _getMovieCategoryItemsForDropdownList = getMovieCategoryItemsForDropdownList;
        }

        public MovieHomePageModel GetHomePageData()
        {
            MovieHomePageModel movieHomePageModel = new MovieHomePageModel();

            movieHomePageModel.CategoryItems = _getMovieCategoryItemsForDropdownList.GetMoviecategories();

            return movieHomePageModel;
        }
    }
}