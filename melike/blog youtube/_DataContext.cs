namespace YoutubeDersleri.Data
{
    using Microsoft.EntityFrameworkCore;
    using YoutubeDersleri.Data.Infrastructure;

    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base (new DbContextOptionsBuilder().UseMySQL(connectionString).Options)
        {
        }

        public DbSet<Model.Author> Authors { get; set; }
        public DbSet<Model.Category> Categories { get; set; }
        public DbSet<Model.Comment> Comments { get; set; }
        public DbSet<Model.Content> Contents { get; set; }
        public DbSet<Model.ContentCategory> ContentCategories { get; set; }
        public DbSet<Model.ContentTag> ContentTags { get; set; }
        public DbSet<Model.Media> Medias { get; set; }
        public DbSet<Model.Tag> Tags { get; set; }
        public DbSet<Model.Setting> Setting { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Model.Author>(entity => entity.ToTable("you_authors"));
            builder.Entity<Model.Category>(entity => entity.ToTable("you_categories"));
            builder.Entity<Model.Comment>(entity => entity.ToTable("you_comments"));
            builder.Entity<Model.Content>(entity => entity.ToTable("you_contents"));
            builder.Entity<Model.ContentCategory>(entity => entity.ToTable("you_content_categories"));
            builder.Entity<Model.ContentTag>(entity => entity.ToTable("you_content_tags"));
            builder.Entity<Model.Media>(entity => entity.ToTable("you_medias"));
            builder.Entity<Model.Tag>(entity => entity.ToTable("you_tags"));
            builder.Entity<Model.Setting>(entity => entity.ToTable("you_setting"));

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(bool))
                    {
                        property.SetValueConverter(new BoolToIntConverter());
                    }
                }
            }
        }
    }
}
