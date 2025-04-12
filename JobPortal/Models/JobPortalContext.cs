using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobPortal.Models
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class JobPortalContext : DbContext
	{
		static JobPortalContext()
		{
			Database.SetInitializer<JobPortalContext>(null);

        }
		public JobPortalContext() : base("Name=jobportaldb")
		{


		}

		public virtual DbSet<tblUsersModel> tbl_users { get; set; }
        public virtual DbSet<tblStudentInfoModel> tbl_studentinfo { get; set; }
        public virtual DbSet<tblRolesModel> tbl_roles{ get; set; }
        public virtual DbSet<tblJobsModel> tbl_jobs{ get; set; }
        public virtual DbSet<tblJobLocationsModel> tbl_joblocations { get; set; }
        public virtual DbSet<tblJobListingStatusModel> tbl_joblistingstatus { get; set; }
        public virtual DbSet<tblJobListingsModel> tbl_joblistings { get; set; }
        public virtual DbSet<tblIndustriesModel> tbl_industries { get; set; }
        public virtual DbSet<tblEmployerInfoModel> tbl_employerinfo { get; set; }
        public virtual DbSet<tblApplicationStatusModel> tbl_applicationstatus { get; set; }
        public virtual DbSet<tblApplicationsModel> tbl_applications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new tblUsersMap());
            modelBuilder.Configurations.Add(new tblStudentInfoMap());
            modelBuilder.Configurations.Add(new tblRolesMap());
            modelBuilder.Configurations.Add(new tblJobsMap());
            modelBuilder.Configurations.Add(new tblJobLocationsMap());
            modelBuilder.Configurations.Add(new tblJobListingStatusMap());
            modelBuilder.Configurations.Add(new tblJobListingsMap());
            modelBuilder.Configurations.Add(new tblIndustriesMap());
            modelBuilder.Configurations.Add(new tblEmployerInfoMap());
            modelBuilder.Configurations.Add(new tblApplicationStatusMap());
            modelBuilder.Configurations.Add(new tblApplicationsMap());
        }

    }
}