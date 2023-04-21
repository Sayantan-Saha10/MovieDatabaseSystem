using MovieDatabaseSystem.Entities.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Interface
{
    public interface IBuildMovieCategoryForDropdownList
    {
        List<SelectListItem> BuildMovieCategorySelectListModel(List<MovieCategory> movieCategories);
    }
}