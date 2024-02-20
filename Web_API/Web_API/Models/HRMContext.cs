using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Web_API.Models
{
    public partial class HRMContext : DbContext
    {
        public HRMContext()
        {
        }

        public HRMContext(DbContextOptions<HRMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<BankName> BankName { get; set; }
        public virtual DbSet<BloodGroup> BloodGroup { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EmpInfo> EmpInfo { get; set; }
        public virtual DbSet<EmpWorkInfo> EmpWorkInfo { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LastUpdateT> LastUpdateT { get; set; }
        public virtual DbSet<NfcNameView> NfcNameView { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<NoticeView> NoticeView { get; set; }
        public virtual DbSet<Pass> Pass { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<SaleTShirt> SaleTShirt { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TShirtName> TShirtName { get; set; }
        public virtual DbSet<TShirtSize> TShirtSize { get; set; }
        public virtual DbSet<TShirtStock> TShirtStock { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Test2> Test2 { get; set; }
        public virtual DbSet<WorkType> WorkType { get; set; }
        public virtual DbSet<ToDoListStates> ToDoListStates { get; set; }
        public virtual DbSet<EmpToDoList> EmpToDoList { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = HRM; Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Access>(entity =>
            {
                entity.ToTable("ACCESS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.MenuA).HasColumnName("MENU_A");

                entity.Property(e => e.MenuB).HasColumnName("MENU_B");

                entity.Property(e => e.MenuC).HasColumnName("MENU_C");

                entity.Property(e => e.MenuD).HasColumnName("MENU_D");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("ATTENDANCE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.InTime)
                    .HasColumnName("IN_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutTime)
                    .HasColumnName("OUT_TIME")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BankName>(entity =>
            {
                entity.HasKey(e => e.BId);

                entity.ToTable("BANK_NAME");

                entity.Property(e => e.BId).HasColumnName("B_ID");

                entity.Property(e => e.BName)
                    .HasColumnName("B_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.HasKey(e => e.BId);

                entity.ToTable("BLOOD_GROUP");

                entity.Property(e => e.BId).HasColumnName("B_ID");

                entity.Property(e => e.BloodName)
                    .HasColumnName("BLOOD_NAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BId);

                entity.ToTable("BRANCH");

                entity.Property(e => e.BId).HasColumnName("B_ID");

                entity.Property(e => e.BranchName)
                    .HasColumnName("BRANCH_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepName)
                    .HasColumnName("DEP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpInfo>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK_Table_1");

                entity.ToTable("EMP_INFO");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(100);

                entity.Property(e => e.BloodId).HasColumnName("BLOOD_ID");

                entity.Property(e => e.CreateEmpId).HasColumnName("CREATE_EMP_ID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpCreateDate)
                    .HasColumnName("EMP_CREATE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.FristName)
                    .HasColumnName("FRIST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.Language).HasColumnName("LANGUAGE");

                entity.Property(e => e.Mobile).HasColumnName("MOBILE");

                entity.Property(e => e.NameSurename)
                    .HasColumnName("NAME_SURENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Nic)
                    .HasColumnName("NIC")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<EmpWorkInfo>(entity =>
            {
                entity.ToTable("EMP_WORK_INFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BId).HasColumnName("B_ID");

                entity.Property(e => e.DId).HasColumnName("D_ID");

                entity.Property(e => e.DOfA)
                    .HasColumnName("D/OF_A")
                    .HasColumnType("date");

                entity.Property(e => e.DOfC)
                    .HasColumnName("D/OF_C")
                    .HasColumnType("date");

                entity.Property(e => e.DOfJoin)
                    .HasColumnName("D/OF_JOIN")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250);

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.NfcNumber)
                    .HasColumnName("NFC_NUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.ReEmpId).HasColumnName("RE_EMP_ID");

                entity.Property(e => e.WTId).HasColumnName("W_T_ID");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.GId);

                entity.ToTable("GENDER");

                entity.Property(e => e.GId).HasColumnName("G_ID");

                entity.Property(e => e.Gender1)
                    .HasColumnName("GENDER")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LId);

                entity.ToTable("LANGUAGE");

                entity.Property(e => e.LId).HasColumnName("L_ID");

                entity.Property(e => e.Language1)
                    .HasColumnName("LANGUAGE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LastUpdateT>(entity =>
            {
                entity.ToTable("LAST_UPDATE_T");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            });

            modelBuilder.Entity<NfcNameView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NFC_NAME_VIEW");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.FristName)
                    .HasColumnName("FRIST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.NameSurename)
                    .HasColumnName("NAME_SURENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.NfcNumber)
                    .HasColumnName("NFC_NUMBER")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.HasKey(e => e.NoId);

                entity.ToTable("NOTICE");

                entity.Property(e => e.NoId).HasColumnName("NO_ID");

                entity.Property(e => e.DId).HasColumnName("D_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.From)
                    .HasColumnName("FROM")
                    .HasColumnType("date");

                entity.Property(e => e.NBody)
                    .HasColumnName("N_BODY")
                    .HasMaxLength(500);

                entity.Property(e => e.NFromAll).HasColumnName("N_FROM_ALL");

                entity.Property(e => e.NLUpdateDate)
                    .HasColumnName("N_L_UPDATE_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.NPutId).HasColumnName("N_PUT_ID");

                entity.Property(e => e.NTitel)
                    .HasColumnName("N_TITEL")
                    .HasMaxLength(100);

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.PutPId).HasColumnName("PUT_P_ID");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("date");

                entity.HasOne(d => d.PutP)
                    .WithMany(p => p.Notice)
                    .HasForeignKey(d => d.PutPId)
                    .HasConstraintName("FK_NOTICE_POSITION");
            });

            modelBuilder.Entity<NoticeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NOTICE_VIEW");

                entity.Property(e => e.DId).HasColumnName("D_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.From)
                    .HasColumnName("FROM")
                    .HasColumnType("date");

                entity.Property(e => e.NTitel)
                    .HasColumnName("N_TITEL")
                    .HasMaxLength(100);

                entity.Property(e => e.NameSurename)
                    .HasColumnName("NAME_SURENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.NoId).HasColumnName("NO_ID");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.PositionName)
                    .HasColumnName("POSITION_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                


                 entity.Property(e => e.NBody) // add new 
                    .HasColumnName("N_BODY")
                    .HasMaxLength(500);

            });

            modelBuilder.Entity<Pass>(entity =>
            {
                entity.ToTable("PASS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BRANCH_ID");

                entity.Property(e => e.CreatDate)
                    .HasColumnName("CREAT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.CreatEmpId).HasColumnName("CREAT_EMP_ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Lock1).HasColumnName("LOCK1");

                entity.Property(e => e.Lock2).HasColumnName("LOCK2");

                entity.Property(e => e.LogInOut).HasColumnName("LOG_IN_OUT");

                entity.Property(e => e.Path).HasColumnName("Path");

                entity.Property(e => e.Pass1)
                    .HasColumnName("PASS")
                    .HasMaxLength(150);

                entity.Property(e => e.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Path) // add new table 
                   .HasColumnName("Path")
                   .HasMaxLength(100);

                entity.Property(e => e.LastLDateTime) //add
                    .HasColumnName("LAST_L_DATE_TIME")
                    .HasColumnType("datetime"); // Update the "date" to "datetime" // Only save date only 
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("POSITION");

                entity.Property(e => e.PId).HasColumnName("P_ID");

                entity.Property(e => e.DId).HasColumnName("D_ID");

                entity.Property(e => e.PositionName)
                    .HasColumnName("POSITION_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaleTShirt>(entity =>
            {
                entity.ToTable("SALE_T_SHIRT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BId).HasColumnName("B_ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.ResiptNo)
                    .HasColumnName("RESIPT_NO")
                    .HasMaxLength(50);

                entity.Property(e => e.States).HasColumnName("STATES");

                entity.Property(e => e.TSNId).HasColumnName("T_S_N_ID");

                entity.Property(e => e.TSSizeId).HasColumnName("T_S_SIZE_ID");

                entity.Property(e => e.OderId).HasColumnName("ODER_ID");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("STATUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status1)
                    .HasColumnName("STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TShirtName>(entity =>
            {
                entity.ToTable("T_SHIRT_NAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.TName)
                    .HasColumnName("T_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TShirtSize>(entity =>
            {
                entity.HasKey(e => e.SizeId)
                    .HasName("PK_T_SHART_SIZE");

                entity.ToTable("T_SHIRT_SIZE");

                entity.Property(e => e.SizeId).HasColumnName("SIZE_ID");

                entity.Property(e => e.Length)
                    .HasColumnName("LENGTH")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SizeName)
                    .HasColumnName("SIZE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Width)
                    .HasColumnName("WIDTH")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TShirtStock>(entity =>
            {
                entity.ToTable("T_SHIRT_STOCK");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TSNId).HasColumnName("T_S_N_ID");

                entity.Property(e => e.TSSizeId).HasColumnName("T_S_SIZE_ID");

                entity.Property(e => e.TStockQuantity).HasColumnName("T_STOCK_QUANTITY");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("TEST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.OutDate)
                    .HasColumnName("OUT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Search)
                    .HasColumnName("SEARCH")
                    .HasMaxLength(1);

                entity.Property(e => e.Search2)
                    .HasColumnName("SEARCH_2")
                    .HasMaxLength(50);

                entity.Property(e => e.Test1)
                    .HasColumnName("TEST")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test2>(entity =>
            {
                entity.ToTable("TEST_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Test)
                    .HasColumnName("TEST")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkType>(entity =>
            {
                entity.HasKey(e => e.WId);

                entity.ToTable("WORK_TYPE");

                entity.Property(e => e.WId).HasColumnName("W_ID");

                entity.Property(e => e.WName)
                    .IsRequired()
                    .HasColumnName("W_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            // add new tabel is TODOList 
            modelBuilder.Entity<ToDoListStates>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("TO_DO_LIST_STATES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ToListProccess)
                    .IsRequired()
                    .HasColumnName("TO_LIST_Proccess")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpToDoList>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("EMP_TO_DO_LIST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(50);


                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasColumnName("STATUS");


            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
