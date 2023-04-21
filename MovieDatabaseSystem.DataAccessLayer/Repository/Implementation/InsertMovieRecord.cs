using MovieDatabaseSystem.Common.Models.ViewModels;
using MovieDatabaseSystem.DataAccessLayer.Repository.Interface;
using MovieDatabaseSystem.Entities.Entities;
using System;

namespace MovieDatabaseSystem.DataAccessLayer.Repository.Implementation
{
    public class InsertMovieRecord : IInsertMovieRecord
    {
        public bool Insert(MovieDatabaseRecordViewModel movieRecord)
        {
            using (MovieDBEntities context = new MovieDBEntities())
            {
                context.Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");

                MovieRecord record = new MovieRecord()
                {
                    Title = movieRecord.Title,
                    Category = movieRecord.CategoryId,
                    Runtime = TimeSpan.Parse(movieRecord.Runtime),
                    ReleasedDate = DateTime.Parse(movieRecord.ReleasedDate),
                    Director = movieRecord.Director,
                    Rating = Decimal.Parse(movieRecord.Rating)
                };

                context.MovieRecords.Add(record);
                context.SaveChanges();

                MovieDescription description = new MovieDescription()
                {
                    MovieId = record.Id,
                    Description = movieRecord.Description
                };

                context.MovieDescriptions.Add(description);
                context.SaveChanges();

                return true;
            }
        }
    }
}