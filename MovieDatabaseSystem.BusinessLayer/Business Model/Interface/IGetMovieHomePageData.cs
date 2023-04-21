using MovieDatabaseSystem.Common.Models.ViewModels;
using System.Collections.Generic;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Interface
{
    public interface IGetMovieHomePageData
    {
        MovieHomePageModel GetHomePageData();
    }
}