using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ValhallaVault.Models;

namespace ValhallaVault.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubcategoryModel> Subcategories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<ResponseModel> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryModel>().HasData(new CategoryModel
            {
                Id = 1,
                CategoryName = "Test Category",
                Description = "Test Category-desc",
            });
            builder.Entity<SegmentModel>().HasData(new SegmentModel
            {
                Id = 1,
                SegmentName = "Test Segment",
                Description = "Test Segment-desc",
                CategoryId = 1,
            });

            builder.Entity<SubcategoryModel>().HasData(new SubcategoryModel
            {
                Id = 1,
                SubCategoryName = "Test Subcategory",
                Description = "Test Subcategory-desc",
                SegmentId = 1,
            });

            builder.Entity<QuestionModel>().HasData(new QuestionModel
            {
                Id = 1,
                Question = "Test Question",
                SubcategoryId = 1,
            });

            builder.Entity<CategoryModel>()
                .HasMany(x => x.Segments)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId);

            builder.Entity<SegmentModel>()
                .HasMany(x => x.SubCategories)
                .WithOne(c => c.Segment)
                .HasForeignKey(c => c.SegmentId);

            builder.Entity<SubcategoryModel>()
                .HasMany(x => x.Questions)
                .WithOne(c => c.SubCategory)
                .HasForeignKey(c => c.SubcategoryId);

            builder.Entity<ApplicationUser>()
                .HasMany(x => x.Responses)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);
        }
    }
}
