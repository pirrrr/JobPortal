using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	public class tblEmployerInfoMap : EntityTypeConfiguration<tblEmployerInfoModel>
    {
        public tblEmployerInfoMap()
        {
            HasKey(i => i.userID);
            ToTable("tbl_employerinfo");
        }
    }
}