using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	public class tblApplicationStatusMap : EntityTypeConfiguration<tblApplicationStatusModel>
    {
        public tblApplicationStatusMap()
        {
            HasKey(i => i.applicationstatusID);
            ToTable("tbl_applicationstatus");
        }
    }
}