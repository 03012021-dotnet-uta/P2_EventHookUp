using System;
using System.Collections.Generic;
using Domain.Models;
using Domain.RawModels;
using Logic;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly EventLogic eventLogic;
        public EventController(EventLogic sL)
        {
            eventLogic = sL;
        }

        /// <summary>
        /// Gets all upcoming events
        /// </summary>
        /// <returns></returns>
        [HttpGet("allupcoming")]
        public ActionResult<List<Event>> GetAllUpcoming()
        {
            List<Event> allUsers = eventLogic.GetUpcomingEvents();
            return allUsers;
        }

        /// <summary>
        /// Gets all events a user signed up for
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns></returns>
        [HttpGet("allsigned/{id}")]
        public ActionResult<List<Event>> GetAllSignedUpEvents(Guid id)
        {
            List<Event> allUsers = eventLogic.GetAllSignedUpEvents(id);
            return allUsers;
        }

        /// <summary>
        /// Gets all events a user has been to
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns></returns>
        [HttpGet("allprevious/{id}")]
        public ActionResult<List<Event>> GetAllPreviousEvents(Guid id)
        {
            List<Event> allUsers = eventLogic.GetAllPreviousEvents(id);
            return allUsers;
        }

        /// <summary>
        /// Gets all the reviews from an event
        /// </summary>
        /// <param name="id">Event ID</param>
        /// <returns></returns>
        [HttpGet("allreviews/{id}")]
        public ActionResult<List<Review>> GetAllReviews(Guid id)
        {
            List<Review> allUsers = eventLogic.GetAllReviews(id);
            return allUsers;
        }
    }
}
