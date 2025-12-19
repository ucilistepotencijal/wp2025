using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebShopApp.Models;

public partial class WebshopdbContext : DbContext
{
    public WebshopdbContext()
    {
    }

    public WebshopdbContext(DbContextOptions<WebshopdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategorije> Kategorijes { get; set; }

    public virtual DbSet<KategorijeProizvodi> KategorijeProizvodis { get; set; }

    public virtual DbSet<Korisnici> Korisnicis { get; set; }

    public virtual DbSet<MjereProizvodum> MjereProizvoda { get; set; }

    public virtual DbSet<Narudzbe> Narudzbes { get; set; }

    public virtual DbSet<NarudzbeDetalji> NarudzbeDetaljis { get; set; }

    public virtual DbSet<Proizvodi> Proizvodis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-I22TPGNV\\SQLEXPRESS; initial catalog=WEBSHOPDB; trusted_connection=yes; trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kategorije>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kategori__3214EC070C231F54");

            entity.ToTable("Kategorije");

            entity.Property(e => e.Naziv).HasMaxLength(50);
            entity.Property(e => e.Opis).HasMaxLength(500);
        });

        modelBuilder.Entity<KategorijeProizvodi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kategori__3214EC07F101D73F");

            entity.ToTable("KategorijeProizvodi");

            entity.HasOne(d => d.Kategorija).WithMany(p => p.KategorijeProizvodis)
                .HasForeignKey(d => d.KategorijaId)
                .HasConstraintName("FK__Kategorij__Kateg__412EB0B6");

            entity.HasOne(d => d.ProizvodNavigation).WithMany(p => p.KategorijeProizvodis)
                .HasForeignKey(d => d.Proizvod)
                .HasConstraintName("FK__Kategorij__Proiz__403A8C7D");
        });

        modelBuilder.Entity<Korisnici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Korisnic__3214EC07F38321B1");

            entity.ToTable("Korisnici");

            entity.Property(e => e.AdresaDostave).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Ime).HasMaxLength(50);
            entity.Property(e => e.Kontakt).HasMaxLength(50);
            entity.Property(e => e.Napomena).HasMaxLength(250);
            entity.Property(e => e.Prezime).HasMaxLength(100);
        });

        modelBuilder.Entity<MjereProizvodum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MjerePro__3214EC07D9D467B0");

            entity.Property(e => e.Naziv).HasMaxLength(50);
        });

        modelBuilder.Entity<Narudzbe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Narudzbe__3214EC07223C69CF");

            entity.ToTable("Narudzbe");

            entity.Property(e => e.DatumKreiranja)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DatumVrijemeDostave).HasColumnType("datetime");

            entity.HasOne(d => d.Korisnik).WithMany(p => p.Narudzbes)
                .HasForeignKey(d => d.KorisnikId)
                .HasConstraintName("FK__Narudzbe__Korisn__440B1D61");
        });

        modelBuilder.Entity<NarudzbeDetalji>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Narudzbe__3214EC07F08A0838");

            entity.ToTable("NarudzbeDetalji");

            entity.Property(e => e.JedCijena).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Narudzba).WithMany(p => p.NarudzbeDetaljis)
                .HasForeignKey(d => d.NarudzbaId)
                .HasConstraintName("FK__NarudzbeD__Narud__47DBAE45");

            entity.HasOne(d => d.Proizvod).WithMany(p => p.NarudzbeDetaljis)
                .HasForeignKey(d => d.ProizvodId)
                .HasConstraintName("FK__NarudzbeD__Proiz__48CFD27E");
        });

        modelBuilder.Entity<Proizvodi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proizvod__3214EC0774A1C318");

            entity.ToTable("Proizvodi");

            entity.Property(e => e.Cijena).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.Naziv).HasMaxLength(100);
            entity.Property(e => e.VrijemeKreiranja)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.MjereProizvoda).WithMany(p => p.Proizvodis)
                .HasForeignKey(d => d.MjereProizvodaId)
                .HasConstraintName("FK__Proizvodi__Mjere__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
