using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.AspNet.Identity;
using Reindawn.Domain.Constants;
using Reindawn.Domain.Enumerations;
using Reindawn.Domain.Models;
using Reindawn.Repository;
using Reindawn.Service;
using Reindawn.Utilities.Extensions;
using ReindawnApi.Models;

namespace ReindawnApi.Controllers
{
    [RoutePrefix("api/disasterlocation")]
    public class DisasterLocationController : ApiController
    {

        public IEnumerable<DisasterLocationViewModel> GetAll()
        {
            var newsService = new DisasterLocationService(new UnitOfWork());
            List<DisasterLocationViewModel> newsList = new List<DisasterLocationViewModel>();
            foreach (var news in newsService.GetAll())
            {
                newsList.Add(news.Convert<DisasterLocation, DisasterLocationViewModel>());
            }

            return newsList;
        }

        [Route("getMyResponses")]
        [HttpPost]
        public IEnumerable<DisasterLocationViewModel> GetMyResponses([FromBody]Guid userId)
        {
            var newsService = new DisasterLocationService(new UnitOfWork());
            List<DisasterLocationViewModel> newsList = new List<DisasterLocationViewModel>();
            foreach (var news in newsService.Filter(o=>o.RespondentId == userId))
            {
                newsList.Add(news.Convert<DisasterLocation, DisasterLocationViewModel>());
            }

            return newsList;
        }



        [Route("adddisaster")]
        [HttpPost]
        //[ResponseType(typeof(RegisterViewModel))]
        public IHttpActionResult AddDisaster([FromBody]DisasterLocationViewModel model)
        {
            if (ModelState.IsValid)
            {

                var disasterLocationService = new DisasterLocationService(new UnitOfWork());
                disasterLocationService.Insert(new DisasterLocation
                {
                    UserId = model.UserId,
                    RespondentId = model.RespondentId,
                    Lat = model.Lat,
                    Lng = model.Lng,
                    Description = model.Description,
                    Status = model.Status,
                    DatePosted = model.DatePosted
                });
                disasterLocationService.Save();
                return new ResponseMessageResult(
                        Request.CreateResponse(HttpStatusCode.OK, RequestResultMessageConstant.SuccessfullyAddedNewDisasterLocation));
            }

            List<string> errors =
                (from modelState in ModelState.Values from error in modelState.Errors select error.ErrorMessage).ToList();
            return new ResponseMessageResult(
                Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                    string.Join(";", errors)));

        }


        [Route("responddisaster")]
        [HttpPost]
        //[ResponseType(typeof(RegisterViewModel))]
        public IHttpActionResult RespondDisaster([FromBody]DisasterLocationUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {

                var disasterLocationService = new DisasterLocationService(new UnitOfWork());
                var disaster = disasterLocationService.Find(model.Id);
                disaster.RespondentId = model.RespondentId;
                disaster.Status = DisasterLocationStatusEnum.Responding;
                disasterLocationService.Update(disaster);
                disasterLocationService.Save();
                return new ResponseMessageResult(
                        Request.CreateResponse(HttpStatusCode.OK, RequestResultMessageConstant.SuccessfullyUpdatedDisasterLocation));
            }

            List<string> errors =
                (from modelState in ModelState.Values from error in modelState.Errors select error.ErrorMessage).ToList();
            return new ResponseMessageResult(
                Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                    string.Join(";", errors)));

        }


        [Route("responsecomplete")]
        [HttpPost]
        //[ResponseType(typeof(RegisterViewModel))]
        public IHttpActionResult ResponseComplete([FromBody]DisasterLocationUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {

                var disasterLocationService = new DisasterLocationService(new UnitOfWork());
                var disaster = disasterLocationService.Find(model.Id);
                disaster.Status = DisasterLocationStatusEnum.Responded;
                disasterLocationService.Update(disaster);
                disasterLocationService.Save();
                return new ResponseMessageResult(
                        Request.CreateResponse(HttpStatusCode.OK, RequestResultMessageConstant.SuccessfullyUpdatedDisasterLocation));
            }

            List<string> errors =
                (from modelState in ModelState.Values from error in modelState.Errors select error.ErrorMessage).ToList();
            return new ResponseMessageResult(
                Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                    string.Join(";", errors)));

        }

        [Route("responsecancel")]
        [HttpPost]
        //[ResponseType(typeof(RegisterViewModel))]
        public IHttpActionResult ResponseCancel([FromBody]DisasterLocationUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {

                var disasterLocationService = new DisasterLocationService(new UnitOfWork());
                var disaster = disasterLocationService.Find(model.Id);
                disaster.Status = DisasterLocationStatusEnum.Cancelled;
                disasterLocationService.Update(disaster);
                disasterLocationService.Save();
                return new ResponseMessageResult(
                        Request.CreateResponse(HttpStatusCode.OK, RequestResultMessageConstant.SuccessfullyUpdatedDisasterLocation));
            }

            List<string> errors =
                (from modelState in ModelState.Values from error in modelState.Errors select error.ErrorMessage).ToList();
            return new ResponseMessageResult(
                Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                    string.Join(";", errors)));

        }
    }
}