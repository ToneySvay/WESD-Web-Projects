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

        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AttendanceAverage> AttendanceAverage { get; set; }
        public virtual DbSet<ChildLevel> ChildLevel { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<EducationLevel> EducationLevel { get; set; }
        public virtual DbSet<ExitReason> ExitReason { get; set; }
        public virtual DbSet<FileUpload> FileUpload { get; set; }
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
        public virtual DbSet<StudentLevel> StudentLevel { get; set; }

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
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.AttId);

                entity.Property(e => e.AttId)
                    .HasColumnName("ATT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttEndDate)
                    .HasColumnName("ATT_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttFromDateRange)
                    .HasColumnName("ATT_From_DateRange")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttSchoolYear)
                    .HasColumnName("ATT_SCHOOL_YEAR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AttStartDate)
                    .HasColumnName("ATT_StartDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AttendanceAverage>(entity =>
            {
                entity.HasKey(e => e.AtaId);

                entity.Property(e => e.AtaId).HasColumnName("ATA_ID");

                entity.Property(e => e.AtaAttId).HasColumnName("ATA_ATT_ID");

                entity.Property(e => e.AtaAverage)
                    .HasColumnName("ATA_Average")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClId).HasColumnName("CL_ID");
            });

            modelBuilder.Entity<ChildLevel>(entity =>
            {
                entity.HasKey(e => e.ClId);

                entity.Property(e => e.ClId)
                    .HasColumnName("CL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClAddress)
                    .IsRequired()
                    .HasColumnName("CL_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClAsqpeformedDate)
                    .HasColumnName("CL_ASQPeformedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClAssignedClassromName)
                    .HasColumnName("CL_AssignedClassromName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClAtaId).HasColumnName("CL_ATA_ID");

                entity.Property(e => e.ClBirthdate)
                    .HasColumnName("CL_Birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.ClChildAssessmentPerformDate1)
                    .HasColumnName("CL_ChildAssessmentPerformDate1")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClChildAssessmentPerformDate2)
                    .HasColumnName("CL_ChildAssessmentPerformDate2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClChildAssessmentPerformDate3)
                    .HasColumnName("CL_ChildAssessmentPerformDate3")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClCity)
                    .IsRequired()
                    .HasColumnName("CL_City")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClCoId).HasColumnName("CL_CO_ID");

                entity.Property(e => e.ClEmail)
                    .IsRequired()
                    .HasColumnName("CL_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClEndDate)
                    .HasColumnName("CL_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClErId).HasColumnName("CL_ER_ID");

                entity.Property(e => e.ClFirstLanguageLangId).HasColumnName("CL_FirstLanguage_LANG_ID");

                entity.Property(e => e.ClFosterCareOptId).HasColumnName("CL_FosterCare_OPT_ID");

                entity.Property(e => e.ClFreeReducedLunchProgramOptId).HasColumnName("CL_FreeReducedLunchProgram_OPT_ID");

                entity.Property(e => e.ClGeId).HasColumnName("CL_GE_ID");

                entity.Property(e => e.ClGenerationCode)
                    .IsRequired()
                    .HasColumnName("CL_GenerationCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClHomelessStatusOptId).HasColumnName("CL_HomelessStatus_OPT_ID");

                entity.Property(e => e.ClIfspOptId).HasColumnName("CL_IFSP_OPT_ID");

                entity.Property(e => e.ClIncId).HasColumnName("CL_INC_ID");

                entity.Property(e => e.ClLegalFirstName)
                    .IsRequired()
                    .HasColumnName("CL_LegalFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClLegalLastName)
                    .IsRequired()
                    .HasColumnName("CL_LegalLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClLegalMiddleName)
                    .IsRequired()
                    .HasColumnName("CL_Legal_MiddleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClMigrantStatusOptId)
                    .HasColumnName("CL_MigrantStatus_OPT_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClOntId).HasColumnName("CL_ONT_ID");

                entity.Property(e => e.ClOtherFirstName)
                    .HasColumnName("CL_OtherFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClOtherLastName)
                    .HasColumnName("CL_OtherLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClOtherMiddleName)
                    .HasColumnName("CL_OtherMiddleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClParentTeacherConferenceDate1)
                    .HasColumnName("CL_ParentTeacherConferenceDate1")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClParentTeacherConferenceDate2)
                    .HasColumnName("CL_ParentTeacherConferenceDate2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClPhoneNumber)
                    .IsRequired()
                    .HasColumnName("CL_PhoneNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClPostalCode)
                    .IsRequired()
                    .HasColumnName("CL_PostalCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClReId).HasColumnName("CL_RE_ID");

                entity.Property(e => e.ClRecieveServicesOptId).HasColumnName("CL_RecieveServices_OPT_ID");

                entity.Property(e => e.ClRequiredSpecializedServices).HasColumnName("CL_RequiredSpecializedServices");

                entity.Property(e => e.ClSecondLanguageLangId).HasColumnName("CL_SecondLanguage_LANG_ID");

                entity.Property(e => e.ClSnapOptId).HasColumnName("CL_SNAP_OPT_ID");

                entity.Property(e => e.ClSsiOptId).HasColumnName("CL_SSI_OPT_ID");

                entity.Property(e => e.ClSsid)
                    .HasColumnName("CL_SSID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClStId).HasColumnName("CL_ST_ID");

                entity.Property(e => e.ClStartDate)
                    .HasColumnName("CL_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClTanfOptId).HasColumnName("CL_TANF_OPT_ID");

                entity.Property(e => e.ClThirdLanguageLangId).HasColumnName("CL_ThirdLanguage_LANG_ID");

                entity.Property(e => e.ClWicOptId).HasColumnName("CL_WIC_OPT_ID");
            });

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

            modelBuilder.Entity<FileUpload>(entity =>
            {
                entity.HasKey(e => e.FiId);

                entity.Property(e => e.FiId).HasColumnName("FI_ID");

                entity.Property(e => e.FiContentType)
                    .IsRequired()
                    .HasColumnName("FI_ContentType")
                    .HasMaxLength(200);

                entity.Property(e => e.FiData)
                    .IsRequired()
                    .HasColumnName("FI_Data");

                entity.Property(e => e.FiName)
                    .IsRequired()
                    .HasColumnName("FI_NAME")
                    .HasMaxLength(50)
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

                entity.Property(e => e.PlProgEndDate)
                    .HasColumnName("PL_ProgEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlProgStartDate)
                    .HasColumnName("PL_ProgStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlPrvdId).HasColumnName("PL_PRVD_ID");

                entity.Property(e => e.PlPtId).HasColumnName("PL_PT_ID");

                entity.Property(e => e.PlQrId).HasColumnName("PL_QR_ID");

                entity.Property(e => e.PlSparkRatingBeginingOfYearSrId).HasColumnName("PL_SparkRatingBeginingOfYear_SR_ID");

                entity.Property(e => e.PlSparkRatingEndOfYearSrId).HasColumnName("PL_SparkRatingEndOfYear_SR_ID");

                entity.HasOne(d => d.PlElh)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlElhId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_Hub");

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

                entity.HasOne(d => d.PlPrvd)
                    .WithMany(p => p.ProviderLevel)
                    .HasForeignKey(d => d.PlPrvdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProviderLevel_Provider");

                entity.HasOne(d => d.PlPt)
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

            modelBuilder.Entity<StudentLevel>(entity =>
            {
                entity.HasKey(e => e.SlId);

                entity.Property(e => e.SlId).HasColumnName("SL_ID");

                entity.Property(e => e.SlAddress)
                    .IsRequired()
                    .HasColumnName("SL_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlAsqpeformedDate)
                    .HasColumnName("SL_ASQPeformedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlAssignedClassromName)
                    .HasColumnName("SL_AssignedClassromName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlAverageFromQ1)
                    .HasColumnName("SL_AverageFromQ1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlAverageFromQ2)
                    .HasColumnName("SL_AverageFromQ2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlAverageFromQ3)
                    .HasColumnName("SL_AverageFromQ3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlAverageFromQ4)
                    .HasColumnName("SL_AverageFromQ4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlBirthdate)
                    .HasColumnName("SL_Birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.SlChildAssessmentPerformDate1)
                    .HasColumnName("SL_ChildAssessmentPerformDate1")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlChildAssessmentPerformDate2)
                    .HasColumnName("SL_ChildAssessmentPerformDate2")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlChildAssessmentPerformDate3)
                    .HasColumnName("SL_ChildAssessmentPerformDate3")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlCity)
                    .IsRequired()
                    .HasColumnName("SL_City")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlCoId).HasColumnName("SL_CO_ID");

                entity.Property(e => e.SlEmail)
                    .IsRequired()
                    .HasColumnName("SL_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlEndDate)
                    .HasColumnName("SL_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlErId).HasColumnName("SL_ER_ID");

                entity.Property(e => e.SlFirstLanguageLangId).HasColumnName("SL_FirstLanguage_LANG_ID");

                entity.Property(e => e.SlFosterCareOptId).HasColumnName("SL_FosterCare_OPT_ID");

                entity.Property(e => e.SlFreeReducedLunchProgramOptId).HasColumnName("SL_FreeReducedLunchProgram_OPT_ID");

                entity.Property(e => e.SlGeId).HasColumnName("SL_GE_ID");

                entity.Property(e => e.SlGenerationCode)
                    .HasColumnName("SL_GenerationCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlHomelessStatusOptId).HasColumnName("SL_HomelessStatus_OPT_ID");

                entity.Property(e => e.SlIfspOptId).HasColumnName("SL_IFSP_OPT_ID");

                entity.Property(e => e.SlIncId).HasColumnName("SL_INC_ID");

                entity.Property(e => e.SlLegalFirstName)
                    .IsRequired()
                    .HasColumnName("SL_LegalFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlLegalLastName)
                    .IsRequired()
                    .HasColumnName("SL_LegalLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlLegalMiddleName)
                    .HasColumnName("SL_Legal_MiddleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlMigrantStatusOptId).HasColumnName("SL_MigrantStatus_OPT_ID");

                entity.Property(e => e.SlOntId).HasColumnName("SL_ONT_ID");

                entity.Property(e => e.SlOtherFirstName)
                    .HasColumnName("SL_OtherFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlOtherLastName)
                    .HasColumnName("SL_OtherLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlOtherMiddleName)
                    .HasColumnName("SL_OtherMiddleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlParentTeacherConferenceDate1)
                    .HasColumnName("SL_ParentTeacherConferenceDate1")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlParentTeacherConferenceDate2)
                    .HasColumnName("SL_ParentTeacherConferenceDate2")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlPhoneNumber)
                    .IsRequired()
                    .HasColumnName("SL_PhoneNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlPostalCode)
                    .IsRequired()
                    .HasColumnName("SL_PostalCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlPrvdId).HasColumnName("SL_PRVD_ID");

                entity.Property(e => e.SlReId).HasColumnName("SL_RE_ID");

                entity.Property(e => e.SlRecieveServicesOptId).HasColumnName("SL_RecieveServices_OPT_ID");

                entity.Property(e => e.SlRequiredSpecializedServices).HasColumnName("SL_RequiredSpecializedServices");

                entity.Property(e => e.SlSecondLanguageLangId).HasColumnName("SL_SecondLanguage_LANG_ID");

                entity.Property(e => e.SlSnapOptId).HasColumnName("SL_SNAP_OPT_ID");

                entity.Property(e => e.SlSsiOptId).HasColumnName("SL_SSI_OPT_ID");

                entity.Property(e => e.SlSsid)
                    .HasColumnName("SL_SSID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlStId).HasColumnName("SL_ST_ID");

                entity.Property(e => e.SlStartDate)
                    .HasColumnName("SL_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SlTanfOptId).HasColumnName("SL_TANF_OPT_ID");

                entity.Property(e => e.SlThirdLanguageLangId).HasColumnName("SL_ThirdLanguage_LANG_ID");

                entity.Property(e => e.SlWicOptId).HasColumnName("SL_WIC_OPT_ID");

                entity.HasOne(d => d.SlCo)
                    .WithMany(p => p.StudentLevel)
                    .HasForeignKey(d => d.SlCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_County");

                entity.HasOne(d => d.SlEr)
                    .WithMany(p => p.StudentLevel)
                    .HasForeignKey(d => d.SlErId)
                    .HasConstraintName("FK_StudentLevel_ExitReason");

                entity.HasOne(d => d.SlFirstLanguageLang)
                    .WithMany(p => p.StudentLevelSlFirstLanguageLang)
                    .HasForeignKey(d => d.SlFirstLanguageLangId)
                    .HasConstraintName("FK_StudentLevel_Language");

                entity.HasOne(d => d.SlFosterCareOpt)
                    .WithMany(p => p.StudentLevelSlFosterCareOpt)
                    .HasForeignKey(d => d.SlFosterCareOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option");

                entity.HasOne(d => d.SlFreeReducedLunchProgramOpt)
                    .WithMany(p => p.StudentLevelSlFreeReducedLunchProgramOpt)
                    .HasForeignKey(d => d.SlFreeReducedLunchProgramOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option4");

                entity.HasOne(d => d.SlHomelessStatusOpt)
                    .WithMany(p => p.StudentLevelSlHomelessStatusOpt)
                    .HasForeignKey(d => d.SlHomelessStatusOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option6");

                entity.HasOne(d => d.SlIfspOpt)
                    .WithMany(p => p.StudentLevelSlIfspOpt)
                    .HasForeignKey(d => d.SlIfspOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option8");

                entity.HasOne(d => d.SlInc)
                    .WithMany(p => p.StudentLevel)
                    .HasForeignKey(d => d.SlIncId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Income");

                entity.HasOne(d => d.SlMigrantStatusOpt)
                    .WithMany(p => p.StudentLevelSlMigrantStatusOpt)
                    .HasForeignKey(d => d.SlMigrantStatusOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option7");

                entity.HasOne(d => d.SlOnt)
                    .WithMany(p => p.StudentLevel)
                    .HasForeignKey(d => d.SlOntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_OtherNameType");

                entity.HasOne(d => d.SlPrvd)
                    .WithMany(p => p.StudentLevel)
                    .HasForeignKey(d => d.SlPrvdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Provider");

                entity.HasOne(d => d.SlRe)
                    .WithMany(p => p.StudentLevel)
                    .HasForeignKey(d => d.SlReId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_RaceEthnicity");

                entity.HasOne(d => d.SlRecieveServicesOpt)
                    .WithMany(p => p.StudentLevelSlRecieveServicesOpt)
                    .HasForeignKey(d => d.SlRecieveServicesOptId)
                    .HasConstraintName("FK_StudentLevel_Option9");

                entity.HasOne(d => d.SlSecondLanguageLang)
                    .WithMany(p => p.StudentLevelSlSecondLanguageLang)
                    .HasForeignKey(d => d.SlSecondLanguageLangId)
                    .HasConstraintName("FK_StudentLevel_Language1");

                entity.HasOne(d => d.SlSnapOpt)
                    .WithMany(p => p.StudentLevelSlSnapOpt)
                    .HasForeignKey(d => d.SlSnapOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option1");

                entity.HasOne(d => d.SlSsiOpt)
                    .WithMany(p => p.StudentLevelSlSsiOpt)
                    .HasForeignKey(d => d.SlSsiOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option5");

                entity.HasOne(d => d.SlTanfOpt)
                    .WithMany(p => p.StudentLevelSlTanfOpt)
                    .HasForeignKey(d => d.SlTanfOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option3");

                entity.HasOne(d => d.SlThirdLanguageLang)
                    .WithMany(p => p.StudentLevelSlThirdLanguageLang)
                    .HasForeignKey(d => d.SlThirdLanguageLangId)
                    .HasConstraintName("FK_StudentLevel_Language2");

                entity.HasOne(d => d.SlWicOpt)
                    .WithMany(p => p.StudentLevelSlWicOpt)
                    .HasForeignKey(d => d.SlWicOptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentLevel_Option2");
            });
        }
    }
}
