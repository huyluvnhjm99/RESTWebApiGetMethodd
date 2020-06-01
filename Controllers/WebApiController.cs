using RESTWebApiGetMethodd.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTWebApiGetMethodd.Controllers
{
    public class WebApiController : ApiController
    { 
        public IEnumerable<tbl_question> Get()
        {
            using(quizonlineEntities1 entities = new quizonlineEntities1())
            {
                return entities.tbl_question.ToList<tbl_question>();
            }
        }

        public tbl_question Get(int id)
        {
            using (quizonlineEntities1 entities = new quizonlineEntities1())
            {
                return entities.tbl_question.FirstOrDefault(e => e.id == id);
            }
        }
    }
}
