using MovieDatabaseSystem.Entities.Entities;
using System.Collections.Generic;

namespace MovieDatabaseSystem.DataAccessLayer.Repository.Interface
{
    public interface IGetMovieCategoryFromDB
    {
        List<MovieCategory> GetCategories();
    }
}