namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Default" },
                    new ProductType { Id = 2, Name = "Fresh" },
                    new ProductType { Id = 3, Name = "Frozen" },
                    new ProductType { Id = 4, Name = "Canned" },
                    new ProductType { Id = 5, Name = "Dried" },
                    new ProductType { Id = 6, Name = "Packaged" },
                    new ProductType { Id = 7, Name = "Baked" },
                    new ProductType { Id = 8, Name = "Grilled" },
                    new ProductType { Id = 9, Name = "Fried" },
                    new ProductType { Id = 10, Name = "Boiled" }
                );

            modelBuilder.Entity<User>().HasData(
    new User
    {
        Id = 1,
        Email = "admin@gmail.com",
        PasswordHash = new byte[]
        {
            0xB0, 0x38, 0x33, 0xCE, 0xE2, 0x12, 0x23, 0xC9, 0x26, 0xA4, 0x3C, 0x71, 0xE4, 0xF6, 0xD0, 0x3D,
            0x88, 0xB2, 0xC5, 0x4A, 0xE2, 0x43, 0x38, 0x91, 0x3E, 0x37, 0x7F, 0x7D, 0x62, 0x4B, 0xA8, 0xB3,
            0xA9, 0xC5, 0x08, 0xDE, 0x5D, 0xBF, 0x65, 0x45, 0x19, 0x5B, 0x72, 0x6E, 0xFC, 0xC1, 0x80, 0xA8,
            0x41, 0x2F, 0x34, 0x8C, 0x32, 0xBA, 0xBE, 0xA7, 0x32, 0x78, 0x24, 0xFF, 0xEE, 0x99, 0x3A, 0x5C
        },
        PasswordSalt = new byte[]
        {
            0x6E, 0x51, 0x39, 0x90, 0xBD, 0xD2, 0x4B, 0x98, 0x64, 0xFF, 0x74, 0x8A, 0x90, 0x22, 0x7B, 0x8E,
            0xC4, 0xB4, 0x38, 0xF5, 0xD5, 0x88, 0x8E, 0x7D, 0x85, 0xEA, 0x87, 0x98, 0x9A, 0xB8, 0x7B, 0x0F,
            0x2C, 0xA5, 0x67, 0xDB, 0xC5, 0x2F, 0xF9, 0x05, 0xBF, 0x49, 0x85, 0xFA, 0x84, 0x33, 0x5A, 0xC5,
            0x85, 0x1A, 0xC3, 0x6A, 0xB5, 0x97, 0x44, 0xC1, 0xFA, 0xA1, 0x06, 0xDA, 0x63, 0xE7, 0xD8, 0xD3,
            0x24, 0x1F, 0xC0, 0xB5, 0x9A, 0x5E, 0xDC, 0x74, 0x4B, 0x9D, 0x46, 0xC4, 0xEA, 0xF0, 0x00, 0x22,
            0x92, 0x5F, 0xC4, 0xF0, 0xD5, 0x34, 0xDC, 0x5A, 0xB3, 0x38, 0x3F, 0x35, 0xD7, 0xBD, 0x80, 0x3A,
            0x15, 0x33, 0xA6, 0x9F, 0x54, 0xFC, 0x48, 0x72, 0x3A, 0xC4, 0x7A, 0xAF, 0xF3, 0x56, 0x07, 0xD9,
            0x52, 0x07, 0x6D, 0xB5, 0x76, 0x6B, 0xDB, 0xF5, 0xE4, 0xAE, 0x6F, 0xC7, 0x57, 0x53, 0x32, 0xC4
        },
        DateCreated = DateTime.Now,
        Role = "Admin"
    });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Pizza",
                    Url = "pizza"
                },
                new Category
                {
                    Id = 2,
                    Name = "Biscuits",
                    Url = "biscuits"
                },
                new Category
                {
                    Id = 3,
                    Name = "Meats",
                    Url = "Meats"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        CategoryId = 1,
                        Featured = true
                    },
                        new Product
                        {
                            Id = 2,
                            Title = "Sourdough Bread",
                            Description = "Artisanal sourdough bread made with natural fermentation techniques.",
                            ImageUrl = "https://example.com/sourdough.jpg",
                            CategoryId = 2,
                            Featured = true
                        },
                        new Product
                        {
                            Id = 3,
                            Title = "Grilled Steak",
                            Description = "Juicy grilled steak served with seasonal vegetables.",
                            ImageUrl = "https://example.com/grilled-steak.jpg",
                            CategoryId = 3,
                            Featured = false
                        }, new Product
                        {
                            Id = 4,
                            Title = "Margherita Pizza",
                            Description = "Classic Margherita pizza with fresh tomatoes, mozzarella cheese, and basil.",
                            ImageUrl = "https://example.com/margherita-pizza.jpg",
                            CategoryId = 1,
                            Featured = true
                        },
                        new Product
                        {
                            Id = 5,
                            Title = "Chocolate Chip Cookies",
                            Description = "Crispy chocolate chip cookies made with premium ingredients.",
                            ImageUrl = "https://example.com/chocolate-chip-cookies.jpg",
                            CategoryId = 2,
                            Featured = true
                        },
                        new Product
                        {
                            Id = 6,
                            Title = "Roast Chicken",
                            Description = "Tender roast chicken seasoned with herbs and served with roasted potatoes.",
                            ImageUrl = "https://example.com/roast-chicken.jpg",
                            CategoryId = 3,
                            Featured = false
                        }
                    );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 7,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 5,
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 5,
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 8,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 9,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 9,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 8,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 8,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId =1,
                    ProductTypeId = 1,
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 79.99m,
                    OriginalPrice = 399m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
