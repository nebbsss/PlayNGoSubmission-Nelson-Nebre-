using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayNGoSubmission.Models;

namespace PlayNGoSubmission.Controllers
{
    public class UserController : Controller
    {
        [Route("~/")]
        [Route]
        public ActionResult Index()
        {
            using (PlayNGoEntities db = new PlayNGoEntities())
            {
                var users = (from u in db.user_tbl 
                             select u
                            ).ToList();

                return View(users);
            }
        }
	}
}