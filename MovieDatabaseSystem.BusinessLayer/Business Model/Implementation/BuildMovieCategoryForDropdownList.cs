using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Entities.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.BusinessLayer.Business_Model.Implementation
{
    public class BuildMovieCategoryForDropdownList : IBuildMovieCategoryForDropdownList
    {
        public List<SelectListItem> BuildMovieCategorySelectListModel(List<MovieCategory> movieCategories)
        {
            List<SelectListItem> categorySelectlist = new List<SelectListItem>();
            
            if (movieCategories != null)
            {
                foreach (var categories in movieCategories)
                {
                    SelectListItem categoryItem = new SelectListItem()
                    {
                        Value = categories.CategoryId.ToString(),
                        Text = categories.CategoryName
                    };

                    categorySelectlist.Add(categoryItem);
                }
            }

            return categorySelectlist;
        }
    }
}