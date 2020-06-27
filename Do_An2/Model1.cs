namespace Do_An2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Do_An2.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
            Database.SetInitializer<Model1>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

        }

        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Managers> Manager { get; set; }
        public virtual DbSet<Local_Store> Local_Store { get; set; }
        public virtual DbSet<Drink> Drink { get; set; }
        public virtual DbSet<Order_detail> Order_Detail { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ThanhTien> ThanhTien { get; set; }
        public virtual DbSet<NHACUNGCAP> NhaCungCap { get; set; }
        public virtual DbSet<NGUYENLIEU> NguyenLieu { get; set; }
        public virtual DbSet<DONDATNGUYENLIEU> DonDatHang { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}