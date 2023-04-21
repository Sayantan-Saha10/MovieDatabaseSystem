using MovieDatabaseSystem.BusinessLayer.Business_Model.Interface;
using MovieDatabaseSystem.Common.Interface;
using MovieDatabaseSystem.Common.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace MovieDatabaseSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetMovieDatabaseRecordModelData _getMovieDatabaseRecordModelData;
        private readonly ILogErrorMessages _logErrorMessages;
        private readonly IGetMovieHomePageData _getMovieHomePageData;
        private readonly ISaveMovieRecord _saveMovieRecord;

        public HomeController(IGetMovieDatabaseRecordModelData getMovieDatabaseRecordModelData, ILogErrorMessages logErrorMessages, IGetMovieHomePageData getMovieHomePageData, ISaveMovieRecord saveMovieRecord)
        {
            _getMovieDatabaseRecordModelData = getMovieDatabaseRecordModelData;
            _logErrorMessages = logErrorMessages;
            _getMovieHomePageData = getMovieHomePageData;
            _saveMovieRecord = saveMovieRecord;
        }

        public ActionResult Index()
        {
            MovieHomePageModel homePageModel = new MovieHomePageModel();

            homePageModel = _getMovieHomePageData.GetHomePageData();

            return View(homePageModel);
        }

        [HttpGet]
        public ActionResult GetMovieGridData()
        {
            List<MovieDatabaseRecordViewModel> movieDatabaseRecordViewModel = new List<MovieDatabaseRecordViewModel>();

            try
            {
                movieDatabaseRecordViewModel = _getMovieDatabaseRecordModelData.MovieDatabaseRecordModel();
            }
            catch (Exception ex)
            {
                _logErrorMessages.LogMessage(ex.StackTrace, $"Error occured while trying to fetch Movie Records data");
                throw new HttpException(ex.Message);
            }
            return Json(new { recordsFiltered = movieDatabaseRecordViewModel.Count, recordsTotal = movieDatabaseRecordViewModel.Count,  data = movieDatabaseRecordViewModel}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveMovieRecord(MovieDatabaseRecordViewModel movieRecord)
        {
            bool isSaved = false;

            try
            {
                isSaved = _saveMovieRecord.Save(movieRecord);
            }
            catch (Exception ex)
            {
                _logErrorMessages.LogMessage(ex.StackTrace, $"Error occured while tring to save Record.");
                isSaved = false;
                throw new HttpException(ex.Message);
            }
            string message = isSaved ? string.Empty : "Error occured. Please try again!";
            return Json(new { IsSuccess = isSaved, Message = message });
        }
    }
}