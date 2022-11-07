using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace WebApiCoreWithEF.Models
{
    public partial class MAFDbContext : DbContext
    {
        public MAFDbContext()
        {
        }

        public MAFDbContext(DbContextOptions<MAFDbContext> options)
            : base(options)
        {
        }
        public DbSet<tr_bpkb>? tr_bpkb { get; set; }
        public DbSet<ms_storage_location>? ms_storage_location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tr_bpkb>(entity =>
            {
                entity.HasKey("agreement_number");

                entity.ToTable("tr_bpkb");

                entity.Property(e => e.agreement_number).HasColumnName("agreement_number")
                    .HasMaxLength(100)
                    .IsUnicode(true);

                entity.Property(e => e.bpkb_no)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.branch_id)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.bpkb_date)
                    .IsUnicode(false);

                entity.Property(e => e.faktur_no)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.faktur_date)
                    .IsUnicode(false);

                entity.Property(e => e.location_id)
                   .HasMaxLength(10)
                   .IsUnicode(false); 
                
                entity.Property(e => e.police_no)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.bpkb_date_in)
                    .IsUnicode(false);

            });

            modelBuilder.Entity<ms_storage_location>(entity =>
            {
                entity.HasKey("location_id");
                entity.ToTable("ms_storage_location");
                entity.Property(e => e.location_id).HasColumnName("location_id");
                entity.Property(e => e.location_name).HasMaxLength(100).IsUnicode(false);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
