using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using MovieDatabaseSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDatabaseSystem.DataAccessLayer.Repository.Implementation
{
    public class GetMovieCategoryFromDB : IGetMovieCategoryFromDB
    {
        public List<MovieCategory> GetCategories()
        {
            List<MovieCategory> categoryList = new List<MovieCategory>();

            using (MovieDBEntities context = new MovieDBEntities())
            {
                categoryList = (from categories in context.MovieCategories select categories).ToList();
            }

            return categoryList;
        }
    }
}