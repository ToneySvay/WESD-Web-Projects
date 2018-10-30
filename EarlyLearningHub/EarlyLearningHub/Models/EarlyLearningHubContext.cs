using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EarlyLearningHub.Models
{
    public partial class EarlyLearningHubContext : DbContext
    {
        public EarlyLearningHubContext()
        {
        }

        public EarlyLearningHubContext(DbContextOptions<EarlyLearningHubContext> options)
            : base(options)
        {
        }

        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<EducationLevel> EducationLevel { get; set; }
        public virtual DbSet<ExitReason> ExitReason { get; set; }
        public virtual DbSet<FosterCare> FosterCare { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HomelessStatus> HomelessStatus { get; set; }
        public virtual DbSet<Hub> Hub { get; set; }
        public virtual DbSet<Ifspstatus> Ifspstatus { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<MigrantStatus> MigrantStatus { get; set; }
        public virtual DbSet<Option> Option { get; set; }
        public virtual DbSet<OtherNameType> OtherNameType { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderLevel> ProviderLevel { get; set; }
        public virtual DbSet<ProviderType> ProviderType { get; set; }
        public virtual DbSet<QuarterlyRange> QuarterlyRange { get; set; }
        public virtual DbSet<RaceEthnicity> RaceEthnicity { get; set; }
        public virtual DbSet<ReceiveService> ReceiveService { get; set; }
        public virtual DbSet<SparkRating> SparkRating { get; set; }
        public virtual DbSet<State> State { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=198.237.190.87;Database=EarlyLearningHub;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<County>(entity =>
            {
                entity.HasKey(e => e.CoId);

                entity.Property(e => e.CoId).HasColumnName("CO_ID");

                entity.Property(e => e.CoName)
                    .IsRequired()
                    .HasColumnName("CO_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.HasKey(e => e.ElId);

                entity.Property(e => e.ElId).HasColumnName("EL_ID");

                entity.Property(e => e.ElName)
                    .IsRequired()
                    .HasColumnName("EL_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExitReason>(entity =>
            {
                entity.HasKey(e => e.ErId);

                entity.Property(e => e.ErId).HasColumnName("ER_ID");

                entity.Property(e => e.ErType)
                    .IsRequired()
                    .HasColumnName("ER_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FosterCare>(entity =>
            {
                entity.HasKey(e => e.FcId);

                entity.Property(e => e.FcId).HasColumnName("FC_ID");

                entity.Property(e => e.FcOptions)
                    .HasColumnName("FC_Options")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.GeId);

                entity.Property(e => e.GeId).HasColumnName("GE_ID");

                entity.Property(e => e.GeAbbreviation)
                    .IsRequired()
                    .HasColumnName("GE_Abbreviation")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GeName)
                    .IsRequired()
                    .HasColumnName("GE_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HomelessStatus>(entity =>
            {
                entity.HasKey(e => e.HsId);

                entity.Property(e => e.HsId).HasColumnName("HS_ID");

                entity.Property(e => e.HsOptions)
                    .HasColumnName("HS_Options")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hub>(entity =>
            {
                entity.HasKey(e => e.ElhId);

                entity.Property(e => e.ElhId).HasColumnName("ELH_ID");

                entity.Property(e => e.ElhName)
                    .IsRequired()
                    .HasColumnName("ELH_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ifspstatus>(entity =>
            {
                entity.HasKey(e => e.IsId);

                entity.ToTable("IFSPStatus");

                entity.Property(e => e.IsId).HasColumnName("IS_ID");

                entity.Property(e => e.IsOptions)
                    .HasColumnName("IS_Options")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasKey(e => e.IncId);

                entity.Property(e => e.IncId).HasColumnName("INC_ID");

                entity.Property(e => e.IncRange)
                    .IsRequired()
                    .HasColumnName("INC_Range")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LangId);

                entity.Property(e => e.LangId).HasColumnName("LANG_ID");

                entity.Property(e => e.LangName)
                    .IsRequired()
                    .HasColumnName("LANG_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrantStatus>(entity =>
            {
                entity.HasKey(e => e.MsId);

                entity.Property(e => e.MsId).HasColumnName("MS_ID");

                entity.Property(e => e.MsOptions)
                    .HasColumnName("MS_Options")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Option>(entity =>
            {
                entity.HasKey(e => e.OptId);

                entity.Property(e => e.OptId).HasColumnName("OPT_ID");

                entity.Property(e => e.OptValue)
                    .IsRequired()
                    .HasColumnName("OPT_Value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtherNameType>(entity =>
            {
                entity.HasKey(e => e.OntId);

                entity.Property(e => e.OntId).HasColumnName("ONT_ID");

                entity.Property(e => e.OntName)
                    .IsRequired()
                    .HasColumnName("ONT_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PeId);

                entity.Property(e => e.PeId).HasColumnName("PE_ID");

                entity.Property(e => e.PeEmail)
                    .IsRequired()
                    .HasColumnName("PE_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeFirstName)
                    .IsRequired()
                    .HasColumnName("PE_FirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeLastName)
                    .IsRequired()
                    .HasColumnName("PE_LastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.PrvdId);

                entity.Property(e => e.PrvdId).HasColumnName("PRVD_ID");

                entity.Property(e => e.PrvdName)
                    .IsRequired()
                    .HasColumnName("PRVD_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrvdPtId).HasColumnName("PRVD_PT_ID");

                entity.HasOne(d => d.PrvdPt)
                    .WithMany(p => p.Provider)
                    .HasForeignKey(d => d.PrvdPtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Provider_ProviderType");
            });

            modelBuilder.Entity<ProviderLevel>(entity =>
            {
                entity.HasKey(e => e.PlId);

                entity.Property(e => e.PlId).HasColumnName("PL_ID");

                entity.Property(e => e.PlChildLevelAssessmentTools)
                    .IsRequired()
                    .HasColumnName("PL_ChildLevelAssessmentTools")
                    .IsUnicode(false);

                entity.Property(e => e.PlChildLevelScreeningTools)
                    .IsRequired()
                    .HasColumnName("PL_ChildLevelScreeningTools")
                    .IsUnicode(false);

                entity.Property(e => e.PlClassroomClassObservationCompleted).HasColumnName("PL_ClassroomClassObservationCompleted");

                entity.Property(e => e.PlCurriculaUsedPpc)
                    .IsRequired()
                    .HasColumnName("PL_CurriculaUsedPPC")
                    .IsUnicode(false);

                entity.Property(e => e.PlDailyEndTime).HasColumnName("PL_DailyEndTIme");

                entity.Property(e => e.PlDailyStartTime).HasColumnName("PL_DailyStartTime");

                entity.Property(e => e.PlDaysOfWeekPpsoccurs)
                    .IsRequired()
                    .HasColumnName("PL_DaysOfWeekPPSOccurs")
                    .IsUnicode(false);

                entity.Property(e => e.PlElhId).HasColumnName("PL_ELH_ID");

                entity.Property(e => e.PlLicencedOfficeChildCareOptId).HasColumnName("PL_LicencedOfficeChildCare_OPT_ID");

                entity.Property(e => e.PlNumChildrenOnWaitlist).HasColumnName("PL_NumChildrenOnWaitlist");

                entity.Property(e => e.PlNumClassroomServingPpc).HasColumnName("PL_NumClassroomServingPPC");

                entity.Property(e => e.PlNumOfActualServiceHrsYtd).HasColumnName("PL_NumOfActualServiceHrsYTD");

                entity.Property(e => e.PlNumOfDaysInProgramYear).HasColumnName("PL_NumOfDaysInProgramYear");

                entity.Property(e => e.PlPeId).HasColumnName("PL_PE_ID");

                entity.Property(e => e.PlPlannedServiceHours).HasColumnName("PL_PlannedServiceHours");

                entity.Property(e => e.PlPrId).HasColumnName("PL_PR_ID");

                entity.Property(e => e.PlProgEndDate)
                    .HasColumnName("PL_ProgEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlProgStartDate)
                    .HasColumnName("PL_ProgStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlPtId).HasColumnName("PL_PT_ID");

                entity.Property(e => e.PlQrId).HasColumnName("PL_QR_ID");

                entity.Property(e => e.PlSparkRatingBeginingOfYearSrId).HasColumnName("PL_SparkRatingBeginingOfYear_SR_ID");

                entity.Property(e => e.PlSparkRatingEndOfYearSrId).HasColumnName("PL_SparkRatingEndOfYear_SR_ID");

                entity.HasOne(d => d.PlElh)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlElhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_ProviderLevel");

                entity.HasOne(d => d.PlLicencedOfficeChildCareOpt)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlLicencedOfficeChildCareOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_Option");

                entity.HasOne(d => d.PlPe)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlPeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_Person");

                entity.HasOne(d => d.PlPt)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlPtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_Provider");

                entity.HasOne(d => d.PlPtNavigation)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlPtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_ProviderType");

                entity.HasOne(d => d.PlQr)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlQrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_QuarterlyRange");

                entity.HasOne(d => d.PlSparkRatingBeginingOfYearSr)
                    .WithMany(p => p.ProviderLevelPlSparkRatingBeginingOfYearSr)
                    .HasForeignKey(d => d.PlSparkRatingBeginingOfYearSrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_SparkRating");

                entity.HasOne(d => d.PlSparkRatingEndOfYearSr)
                    .WithMany(p => p.ProviderLevelPlSparkRatingEndOfYearSr)
                    .HasForeignKey(d => d.PlSparkRatingEndOfYearSrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_SparkRating1");
            });

            modelBuilder.Entity<ProviderType>(entity =>
            {
                entity.HasKey(e => e.PtId);

                entity.Property(e => e.PtId).HasColumnName("PT_ID");

                entity.Property(e => e.PtName)
                    .IsRequired()
                    .HasColumnName("PT_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuarterlyRange>(entity =>
            {
                entity.HasKey(e => e.QrId);

                entity.Property(e => e.QrId).HasColumnName("QR_ID");

                entity.Property(e => e.QrActive).HasColumnName("QR_Active");

                entity.Property(e => e.QrBeginDate)
                    .HasColumnName("QR_BeginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.QrEndDate)
                    .HasColumnName("QR_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.QrName)
                    .IsRequired()
                    .HasColumnName("QR_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaceEthnicity>(entity =>
            {
                entity.HasKey(e => e.ReId);

                entity.Property(e => e.ReId).HasColumnName("RE_ID");

                entity.Property(e => e.ReName)
                    .IsRequired()
                    .HasColumnName("RE_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceiveService>(entity =>
            {
                entity.HasKey(e => e.RsId);

                entity.Property(e => e.RsId).HasColumnName("RS_ID");

                entity.Property(e => e.RsOptions)
                    .HasColumnName("RS_Options")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SparkRating>(entity =>
            {
                entity.HasKey(e => e.SrId);

                entity.Property(e => e.SrId).HasColumnName("SR_ID");

                entity.Property(e => e.SrName)
                    .IsRequired()
                    .HasColumnName("SR_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.Property(e => e.StId).HasColumnName("ST_ID");

                entity.Property(e => e.StAbbreviation)
                    .IsRequired()
                    .HasColumnName("ST_Abbreviation")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StName)
                    .IsRequired()
                    .HasColumnName("ST_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
