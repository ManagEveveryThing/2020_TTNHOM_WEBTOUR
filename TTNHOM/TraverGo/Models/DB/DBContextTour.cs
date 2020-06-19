namespace TraverGo.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContextTour : DbContext
    {
        public DBContextTour()
            : base("name=DBContextTour")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DetailCart> DetailCarts { get; set; }
        public virtual DbSet<DSDatXe> DSDatXes { get; set; }
        public virtual DbSet<DSKSCanTT> DSKSCanTTs { get; set; }
        public virtual DbSet<DSKSTheoTrip> DSKSTheoTrips { get; set; }
        public virtual DbSet<DSKSTrongWL> DSKSTrongWLs { get; set; }
        public virtual DbSet<DSTourCanTT> DSTourCanTTs { get; set; }
        public virtual DbSet<DSTourTrongWL> DSTourTrongWLs { get; set; }
        public virtual DbSet<DSTripTheoTour> DSTripTheoTours { get; set; }
        public virtual DbSet<ElecBill> ElecBills { get; set; }
        public virtual DbSet<HomeStay> HomeStays { get; set; }
        public virtual DbSet<HotelSevice> HotelSevices { get; set; }
        public virtual DbSet<MyWebSite> MyWebSites { get; set; }
        public virtual DbSet<Nation> Nations { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Taxi> Taxis { get; set; }
        public virtual DbSet<TenCacBang> TenCacBangs { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<TourDestination> TourDestinations { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<colName> colNames { get; set; }
        public virtual DbSet<DestinationReview> DestinationReviews { get; set; }
        public virtual DbSet<DestinationTour> DestinationTours { get; set; }
        public virtual DbSet<detailBlog> detailBlogs { get; set; }
        public virtual DbSet<VIEW_detailCart> VIEW_detailCart { get; set; }
        public virtual DbSet<VIEW_top4Nation> VIEW_top4Nation { get; set; }
        public virtual DbSet<VIEW_top6DestianationTour> VIEW_top6DestianationTour { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(e => e.maBlog)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.pic)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.cartID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Cart>()
                .HasMany(e => e.DetailCarts)
                .WithRequired(e => e.Cart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.phoneNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.ElecBills)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.WishLists)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DetailCart>()
                .Property(e => e.cartID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DetailCart>()
                .Property(e => e.desTourID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSDatXe>()
                .Property(e => e.maHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSDatXe>()
                .Property(e => e.bienSo)
                .IsUnicode(false);

            modelBuilder.Entity<DSKSCanTT>()
                .Property(e => e.maKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKSCanTT>()
                .Property(e => e.maHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKSTheoTrip>()
                .Property(e => e.maCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKSTheoTrip>()
                .Property(e => e.maKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKSTrongWL>()
                .Property(e => e.maKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSKSTrongWL>()
                .Property(e => e.maWL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSTourCanTT>()
                .Property(e => e.maTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSTourCanTT>()
                .Property(e => e.maHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSTourTrongWL>()
                .Property(e => e.maTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSTourTrongWL>()
                .Property(e => e.maWL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSTripTheoTour>()
                .Property(e => e.maCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DSTripTheoTour>()
                .Property(e => e.maTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ElecBill>()
                .Property(e => e.maHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ElecBill>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<ElecBill>()
                .HasMany(e => e.DSDatXes)
                .WithRequired(e => e.ElecBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ElecBill>()
                .HasMany(e => e.DSKSCanTTs)
                .WithRequired(e => e.ElecBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ElecBill>()
                .HasMany(e => e.DSTourCanTTs)
                .WithRequired(e => e.ElecBill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HomeStay>()
                .Property(e => e.maKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HomeStay>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HomeStay>()
                .Property(e => e.phoneNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HomeStay>()
                .HasMany(e => e.DSKSCanTTs)
                .WithRequired(e => e.HomeStay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HomeStay>()
                .HasMany(e => e.DSKSTheoTrips)
                .WithRequired(e => e.HomeStay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HomeStay>()
                .HasMany(e => e.DSKSTrongWLs)
                .WithRequired(e => e.HomeStay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HotelSevice>()
                .Property(e => e.IDHotel)
                .IsFixedLength();

            modelBuilder.Entity<MyWebSite>()
                .Property(e => e.phoneNum1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MyWebSite>()
                .Property(e => e.phoneNum2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nation>()
                .Property(e => e.maQG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nation>()
                .HasMany(e => e.Provinces)
                .WithRequired(e => e.Nation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.maTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .Property(e => e.maQG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.TourDestinations)
                .WithRequired(e => e.Province)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taxi>()
                .Property(e => e.bienSo)
                .IsUnicode(false);

            modelBuilder.Entity<Taxi>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Taxi>()
                .Property(e => e.phoneNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Taxi>()
                .HasMany(e => e.DSDatXes)
                .WithRequired(e => e.Taxi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .Property(e => e.maTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.DSTourCanTTs)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.DSTourTrongWLs)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.DSTripTheoTours)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourDestination>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TourDestination>()
                .Property(e => e.maTinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TourDestination>()
                .HasMany(e => e.Blogs)
                .WithRequired(e => e.TourDestination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourDestination>()
                .HasMany(e => e.DetailCarts)
                .WithRequired(e => e.TourDestination)
                .HasForeignKey(e => e.desTourID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourDestination>()
                .HasMany(e => e.HomeStays)
                .WithRequired(e => e.TourDestination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourDestination>()
                .HasMany(e => e.Taxis)
                .WithRequired(e => e.TourDestination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourDestination>()
                .HasMany(e => e.Trips)
                .WithRequired(e => e.TourDestination)
                .HasForeignKey(e => e.maDDEnd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourDestination>()
                .HasMany(e => e.Trips1)
                .WithRequired(e => e.TourDestination1)
                .HasForeignKey(e => e.maDDStart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.maCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.maDDStart)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.maDDEnd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .HasMany(e => e.DSKSTheoTrips)
                .WithRequired(e => e.Trip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trip>()
                .HasMany(e => e.DSTripTheoTours)
                .WithRequired(e => e.Trip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WishList>()
                .Property(e => e.maWL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WishList>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<WishList>()
                .HasMany(e => e.DSKSTrongWLs)
                .WithRequired(e => e.WishList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WishList>()
                .HasMany(e => e.DSTourTrongWLs)
                .WithRequired(e => e.WishList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DestinationReview>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DestinationTour>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<detailBlog>()
                .Property(e => e.maBlog)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<detailBlog>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<detailBlog>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<detailBlog>()
                .Property(e => e.pic)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_detailCart>()
                .Property(e => e.cartID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_detailCart>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_top4Nation>()
                .Property(e => e.maQG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEW_top6DestianationTour>()
                .Property(e => e.maDD)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
