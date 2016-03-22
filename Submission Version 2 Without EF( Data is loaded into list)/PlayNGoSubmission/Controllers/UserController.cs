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
            var persons = PopulatePersonList();

            return View(persons);
        }

        private List<Person> PopulatePersonList()
        {
            var personList = new List<Person>()
            {
                new Person{ firstName = "Juan",    middleName = "Santos",    lastName = "Dela Cruz", contactNumber = 09356236521 },
                new Person{ firstName = "Nora",    middleName = "Aguilas",   lastName = "Aunor",     contactNumber = 09356236523 },
                new Person{ firstName = "Vilma",   middleName = "Santos",    lastName = "Recto",     contactNumber = 09356238542 },
                new Person{ firstName = "Anne",    middleName = "Curtis",    lastName = "Smith",     contactNumber = 09356236214 },
                new Person{ firstName = "Larry",   middleName = "Narida",    lastName = "Chung",     contactNumber = 09356214568 },
                new Person{ firstName = "John",    middleName = "Angeles",   lastName = "Uy",        contactNumber = 09365236589 },
                new Person{ firstName = "Nelson",  middleName = "Albutra",   lastName = "Nebre",     contactNumber = 09356236526 },
                new Person{ firstName = "Joy",     middleName = "Macaranas", lastName = "Capili",    contactNumber = 09356289634 },
                new Person{ firstName = "Rusty",   middleName = "David",     lastName = "Pongcol",   contactNumber = 09358962548 },
                new Person{ firstName = "Joanna",  middleName = "Borral",    lastName = "Pongcol",   contactNumber = 09369856985 },
                new Person{ firstName = "Dominic", middleName = "Sajonia",   lastName = "Zabala",    contactNumber = 09358962548 },
                new Person{ firstName = "Theresa", middleName = "Morral",    lastName = "Baldo",     contactNumber = 09741256358 },
                new Person{ firstName = "Benjie",  middleName = "Cruz",      lastName = "Reyes",     contactNumber = 09875632514 },
            };

            return personList;
        }
	}

}