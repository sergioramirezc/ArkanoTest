namespace ArkanoTest.Service.Computer.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ComputerDbContext : DbContext
    {
        // Your context has been configured to use a 'ComputerDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ArkanoTest.Service.Computer.Data.ComputerDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ComputerDbContext' 
        // connection string in the application configuration file.
        public ComputerDbContext()
            : base("name=ComputerDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<StorageDrive> StorageDrivers { get; set; }
        public virtual DbSet<SSD> Ssd { get; set; }
        public virtual DbSet<HDD> Hdd { get; set; }
        public virtual DbSet<RAM> Ram { get; set; }
        public virtual DbSet<Processor> Processors { get; set; }
        public virtual DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Computer>()
            .HasRequired(c => c.Ram)
            .WithOptional(r => r.Computer);
        }

        public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<ComputerDbContext>
        {
            protected override void Seed(ComputerDbContext context)
            {
                base.Seed(context);

                Brand brand1 = new Brand() { Id = 1, Name = "Dell", Description = "Marca Dell" };
                Brand brand2 = new Brand() { Id = 2, Name = "HP", Description = "Marca HP" };
                Brand brand3 = new Brand() { Id = 3, Name = "Kingston", Description = "Marca Kingston" };
                Brand brand4 = new Brand() { Id = 4, Name = "Samsung", Description = "Marca Samsung" };
                Brand brand5 = new Brand() { Id = 5, Name = "HyperX", Description = "Marca HyperX" };
                Brand brand6 = new Brand() { Id = 6, Name = "Corsair", Description = "Marca Corsair" };
                Brand brand7 = new Brand() { Id = 7, Name = "Intel", Description = "Marca Intel" };
                Brand brand8 = new Brand() { Id = 8, Name = "AMD", Description = "Marca AMD" };

                context.Brands.Add(brand1);
                context.Brands.Add(brand2);
                context.Brands.Add(brand3);
                context.Brands.Add(brand4);
                context.Brands.Add(brand5);
                context.Brands.Add(brand6);
                context.Brands.Add(brand7);
                context.Brands.Add(brand8);

                Processor processor1 = new Processor() { Id = 1, ClockSpeed = 3.7, Brand = brand7, Model = "i7 8700k", Cores = 6, ItemTag = "PR-001" };
                Processor processor2 = new Processor() { Id = 2, ClockSpeed = 3.2, Brand = brand7, Model = "i5 8500k", Cores = 6, ItemTag = "PR-002" };
                Processor processor3 = new Processor() { Id = 3, ClockSpeed = 2.7, Brand = brand7, Model = "i5 7500k", Cores = 4, ItemTag = "PR-003" };

                context.Processors.Add(processor1);
                context.Processors.Add(processor2);

                RAM ram1 = new RAM() { Id = 1, Brand = brand5, Capacity = 4, ItemTag = "RAM-001", SerialNumber = "HQ-111002-9985", Standart = "DDR4" };
                RAM ram2 = new RAM() { Id = 2, Brand = brand6, Capacity = 8, ItemTag = "RAM-002", SerialNumber = "ZP-7778552-5552", Standart = "DDR4" };
                RAM ram3 = new RAM() { Id = 3, Brand = brand5, Capacity = 16, ItemTag = "RAM-003", SerialNumber = "PP-322855-0332", Standart = "DDR3" };

                context.Ram.Add(ram1);
                context.Ram.Add(ram2);
                context.Ram.Add(ram3);

                SSD ssd1 = new SSD() { Id = 1, Interface = "SATA", StorageDrive = new StorageDrive() { Id = 1, Brand = brand3, Capacity = 256, Model = "X-100", ItemTag = "SSD-001" } };
                HDD hdd1 = new HDD() { Id = 1, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 2, Brand = brand4, Capacity = 1024, Model = "Z-200", ItemTag = "HDD-001" } };
                HDD hdd2 = new HDD() { Id = 2, Rpm = "5400", StorageDrive = new StorageDrive() { Id = 3, Brand = brand4, Capacity = 512, Model = "Z-200", ItemTag = "HDD-002" } };
                context.Ssd.Add(ssd1);
                context.Hdd.Add(hdd1);
                context.Hdd.Add(hdd2);

                Computer computer1 = new Computer() { Id = 1, Hdd = hdd2, Ssd = null, Brand = brand1, Ram = ram3, Processor = processor1, SerialNumber = "440-112-221", Model = "Dell inspiron 5680", ItemTag = "PC-001", AsignedTo = "Sergio Ramirez" };
                Computer computer2 = new Computer() { Id = 2, Hdd = null, Ssd = ssd1, Brand = brand2, Ram = ram1, Processor = processor2, SerialNumber = "311-903-180", Model = "HP Pavilon 2200", ItemTag = "PC-002", AsignedTo = "Juan Perez" };
                Computer computer3 = new Computer() { Id = 3, Hdd = hdd2, Ssd = null, Brand = brand2, Ram = ram2, Processor = processor1, SerialNumber = "984-621-291", Model = "HP Omen 300", ItemTag = "PC-003", AsignedTo = "Alberto Cano" };
                context.Computers.Add(computer1);
                context.Computers.Add(computer2);
                context.Computers.Add(computer3);

                context.SaveChanges();
            }

        }
    }
}