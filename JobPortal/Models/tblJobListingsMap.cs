
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	public class tblJobListingsMap : EntityTypeConfiguration<tblJobListingsModel>
    {
        public tblJobListingsMap()
        {
            HasKey(i => i.joblistingID);
            ToTable("tbl_joblistings");
        }
    }
}