using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieDatabaseSystem.Common.Models.ViewModels
{
    public class MovieHomePageModel
    {
        public List<SelectListItem> CategoryItems { get; set; }
    }
}