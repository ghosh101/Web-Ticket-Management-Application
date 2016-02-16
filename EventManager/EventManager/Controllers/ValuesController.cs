using EventManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using System.Xml;

namespace EventManager.Controllers
{
    public class ValuesController : ApiController
    {        
        private UserDbContext _dbContext1 = new UserDbContext();
        private EventDbContext _dbContext2 = new EventDbContext();
        private EventManagerDbContext _dbContext = new EventManagerDbContext();
               
        private Event events;
        private List<Event> eventList = new List<Event>();

        private List<EventAttribute> ticketList = new List<EventAttribute>();
        
        private ErrorHandler err = new ErrorHandler();

        // GET api/values/getallevents
        public List<Event> GetAllEvents()
        {            
            try
            {
                if (!_dbContext2.Events.Any())
                {
                    eventList = _dbContext2.Events.ToList();
                    if (eventList == null)
                        return null;
                    else
                        return eventList;
                }
                else
                {
                    eventList = _dbContext2.Events.ToList();
                    return eventList;
                }
            }
            catch(Exception e)
            {
                err.ErrorMessage = e.Message.ToString();
                throw;
            }            
        }

        // GET api/values/getalltickets
        public List<EventAttribute> GetAllTickets()
        {
            try
            {
                if (!_dbContext.EventAttributes.Any())
                {
                    ticketList = _dbContext.EventAttributes.ToList();
                    if (ticketList == null)
                        return null;
                    else
                        return ticketList;
                }
                else
                {
                    ticketList = _dbContext.EventAttributes.ToList();
                    return ticketList;
                }
            }
            catch (Exception e)
            {
                err.ErrorMessage = e.Message.ToString();
                throw;
            }
        }
                
        // GET api/values/gettickets
        public Dictionary<int, int> GetTickets()
        {
            try
            {
                Dictionary<int, int> dictTicket = new Dictionary<int, int>();
                if (!_dbContext.EventAttributes.Any())
                {
                    ticketList = _dbContext.EventAttributes.ToList();
                    foreach (var i in ticketList)
                    {
                        dictTicket.Add(i.SeatNo, i.SectionNo);                       
                    }
                    return dictTicket;

                }
                else
                    return null;
            }
            catch (Exception e)
            {
                err.ErrorMessage = e.Message.ToString();
                throw;
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}