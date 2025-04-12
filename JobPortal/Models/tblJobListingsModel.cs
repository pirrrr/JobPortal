using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	public class tblJobListingsModel
	{
        public int joblistingID { get; set; }
        public int jobID { get; set; }
        public int userID { get; set; }
        public String jobDescription { get; set; }

        public String jobRequirements { get; set; }
        public int joblocationID { get; set; }
        public int minSalary { get; set; }
        public int maxSalaryy { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}