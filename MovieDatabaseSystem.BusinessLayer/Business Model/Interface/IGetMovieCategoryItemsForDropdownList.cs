using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Interface
{
    public interface IGetMovieCategoryItemsForDropdownList
    {
        List<SelectListItem> GetMoviecategories();
    }
}