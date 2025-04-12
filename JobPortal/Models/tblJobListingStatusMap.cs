using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	public class tblJobListingStatusMap : EntityTypeConfiguration<tblJobListingStatusModel>
    {
        public tblJobListingStatusMap()
        {
            HasKey(i => i.listingstatusID);
            ToTable("tbl_joblistingstatus");
        }
    }
}