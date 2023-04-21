using MovieDatabaseSystem.Common.Models.ViewModels;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using MovieDatabaseSystem.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MovieDatabaseSystem.DataAccessLayer.Repository.Implementation
{
    public class GetMovieRecordsFromDB : IGetMovieRecordsFromDB
    {
        public List<MovieDatabaseRecordViewModel> GetRecords()
        {
            List<MovieDatabaseRecordViewModel> movieRecords = new List<MovieDatabaseRecordViewModel>();

            using (MovieDBEntities context = new MovieDBEntities())
            {
                movieRecords = (from records in context.MovieRecords 
                                join category in context.MovieCategories on records.Category equals category.CategoryId
                                join description in context.MovieDescriptions on records.Id equals description.MovieId
                                select new MovieDatabaseRecordViewModel()
                                {
                                    Id = records.Id,
                                    Title = records.Title,
                                    CategoryId = records.Category,
                                    Category = category.CategoryName,
                                    Runtime = records.Runtime.ToString().Substring(0,5),
                                    ReleasedDate = records.ReleasedDate.ToString(),
                                    Director = records.Director,
                                    Rating = (records.Rating != null) ? records.Rating.ToString() : string.Empty,
                                    Description = description.Description
                                }).ToList();
            }

            return movieRecords;
        }
    }
}