using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	public class tblApplicationsModel
	{
        public int applicationID { get; set; }
        public int userID { get; set; }
        public int joblistingsID { get; set; }
        public DateTime dateApplied { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}