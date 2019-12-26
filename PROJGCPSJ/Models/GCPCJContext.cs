using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PROJGCPSJ.Models
{
    public partial class GCPCJContext : DbContext
    {
        public GCPCJContext()
        {
        }

        public GCPCJContext(DbContextOptions<GCPCJContext> options)
            : base(options)
        {
        }

        public virtual DbSet<auditoria> auditoria { get; set; }
        public virtual DbSet<tbacaopap> tbacaopap { get; set; }
        public virtual DbSet<tbaditivo> tbaditivo { get; set; }
        public virtual DbSet<tbarea> tbarea { get; set; }
        public virtual DbSet<tbarqv> tbarqv { get; set; }
        public virtual DbSet<tbatributo> tbatributo { get; set; }
        public virtual DbSet<tbcampo> tbcampo { get; set; }
        public virtual DbSet<tbcargo> tbcargo { get; set; }
        public virtual DbSet<tbcontato> tbcontato { get; set; }
        public virtual DbSet<tbcontrato> tbcontrato { get; set; }
        public virtual DbSet<tbempresa> tbempresa { get; set; }
        public virtual DbSet<tbendereco> tbendereco { get; set; }
        public virtual DbSet<tbfonterecurso> tbfonterecurso { get; set; }
        public virtual DbSet<tbgrupopermss> tbgrupopermss { get; set; }
        public virtual DbSet<tbhistrc> tbhistrc { get; set; }
        public virtual DbSet<tbparcela> tbparcela { get; set; }
        public virtual DbSet<tbperfil> tbperfil { get; set; }
        public virtual DbSet<tbpermissvisulzc> tbpermissvisulzc { get; set; }
        public virtual DbSet<tbpermss> tbpermss { get; set; }
        public virtual DbSet<tbpessoa> tbpessoa { get; set; }
        public virtual DbSet<tbprodutos> tbprodutos { get; set; }
        public virtual DbSet<tbr_contrtemprs> tbr_contrtemprs { get; set; }
        public virtual DbSet<tbsituacao> tbsituacao { get; set; }
        public virtual DbSet<tbtipodemand> tbtipodemand { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;port=5460;Database=GCPCJ;user id=postgres;password=apigcpcj2020");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<auditoria>(entity =>
            {
                entity.HasKey(e => e.idauditoria)
                    .HasName("auditoria_pkey");

                entity.Property(e => e.horaauditoria).HasColumnType("date");

                entity.Property(e => e.tabelaauditoria).HasMaxLength(45);

                entity.Property(e => e.usuarioauditoria).HasMaxLength(45);

                entity.Property(e => e.valoranterior).HasMaxLength(45);

                entity.Property(e => e.valornovoauditoria).HasMaxLength(45);
            });

            modelBuilder.Entity<tbacaopap>(entity =>
            {
                entity.HasKey(e => e.idacaopap)
                    .HasName("tbacaopap_pkey");

                entity.Property(e => e.acaosubacaopap).HasMaxLength(30);

                entity.Property(e => e.papacaopap).HasMaxLength(30);
            });

            modelBuilder.Entity<tbaditivo>(entity =>
            {
                entity.HasKey(e => e.idtbaditivo)
                    .HasName("tbaditivo_pkey");

                entity.Property(e => e.diasmesestbaditivo).HasMaxLength(45);

                entity.Property(e => e.motivotbaditivo).HasMaxLength(45);

                entity.Property(e => e.valortbaditivo).HasColumnType("numeric");

                entity.HasOne(d => d.tbacaopap_idtbacaopapNavigation)
                    .WithMany(p => p.tbaditivo)
                    .HasForeignKey(d => d.tbacaopap_idtbacaopap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbaditivo_tbacaopap_idtbacaopap_fkey");

                entity.HasOne(d => d.tbcontrato_idtbcontratoNavigation)
                    .WithMany(p => p.tbaditivo)
                    .HasForeignKey(d => d.tbcontrato_idtbcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbaditivo_tbcontrato_idtbcontrato_fkey");

                entity.HasOne(d => d.tbfonterecurso_idtbfonterecursoNavigation)
                    .WithMany(p => p.tbaditivo)
                    .HasForeignKey(d => d.tbfonterecurso_idtbfonterecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbaditivo_tbfonterecurso_idtbfonterecurso_fkey");
            });

            modelBuilder.Entity<tbarea>(entity =>
            {
                entity.HasKey(e => e.idtbarea)
                    .HasName("tbarea_pkey");

                entity.Property(e => e.nometbarea).HasMaxLength(45);
            });

            modelBuilder.Entity<tbarqv>(entity =>
            {
                entity.HasKey(e => e.idarqvs)
                    .HasName("tbarqv_pkey");

                entity.Property(e => e.descricaoarqvs).IsRequired();

                entity.Property(e => e.linkarqvs).IsRequired();

                entity.Property(e => e.tipoarqvs).HasMaxLength(30);

                entity.HasOne(d => d.idtbpessoaNavigation)
                    .WithMany(p => p.tbarqv)
                    .HasForeignKey(d => d.idtbpessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbarqv_idtbpessoa_fkey");

                entity.HasOne(d => d.tbaditivo_idtbaditivoNavigation)
                    .WithMany(p => p.tbarqv)
                    .HasForeignKey(d => d.tbaditivo_idtbaditivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbarqv_tbaditivo_idtbaditivo_fkey");

                entity.HasOne(d => d.tbcontrato_idtbcontratoNavigation)
                    .WithMany(p => p.tbarqv)
                    .HasForeignKey(d => d.tbcontrato_idtbcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbarqv_tbcontrato_idtbcontrato_fkey");

                entity.HasOne(d => d.tbhistrc_idhistrcNavigation)
                    .WithMany(p => p.tbarqv)
                    .HasForeignKey(d => d.tbhistrc_idhistrc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbarqv_tbhistrc_idhistrc_fkey");

                entity.HasOne(d => d.tbparcela_idtbparcelaNavigation)
                    .WithMany(p => p.tbarqv)
                    .HasForeignKey(d => d.tbparcela_idtbparcela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbarqv_tbparcela_idtbparcela_fkey");
            });

            modelBuilder.Entity<tbatributo>(entity =>
            {
                entity.HasKey(e => e.idtbatributo)
                    .HasName("tbatributo_pkey");

                entity.Property(e => e.datatbatributo).HasMaxLength(45);

                entity.Property(e => e.valortbatributo).HasMaxLength(45);

                entity.HasOne(d => d.tbaditivo_idtbaditivoNavigation)
                    .WithMany(p => p.tbatributo)
                    .HasForeignKey(d => d.tbaditivo_idtbaditivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbatributo_tbaditivo_idtbaditivo_fkey");

                entity.HasOne(d => d.tbcontrato_idtbcontratoNavigation)
                    .WithMany(p => p.tbatributo)
                    .HasForeignKey(d => d.tbcontrato_idtbcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbatributo_tbcontrato_idtbcontrato_fkey");
            });

            modelBuilder.Entity<tbcampo>(entity =>
            {
                entity.HasKey(e => e.idtbcampo)
                    .HasName("tbcampo_pkey");

                entity.Property(e => e.descricaotbcampo).HasMaxLength(45);
            });

            modelBuilder.Entity<tbcargo>(entity =>
            {
                entity.HasKey(e => e.idtbcargo)
                    .HasName("tbcargo_pkey");

                entity.Property(e => e.descricaotbcargo).HasMaxLength(45);
            });

            modelBuilder.Entity<tbcontato>(entity =>
            {
                entity.HasKey(e => e.idtbcontato)
                    .HasName("tbcontato_pkey");

                entity.Property(e => e.descricaotbcontato).HasMaxLength(45);

                entity.Property(e => e.emailtbcontato).HasMaxLength(45);

                entity.Property(e => e.setortbcontato).HasMaxLength(45);
            });

            modelBuilder.Entity<tbcontrato>(entity =>
            {
                entity.HasKey(e => e.idcontrato)
                    .HasName("tbcontrato_pkey");

                entity.Property(e => e.Datafimcontrato).HasColumnType("date");

                entity.Property(e => e.Titulocontrato).HasMaxLength(250);

                entity.Property(e => e.datainiciocontrato).HasColumnType("date");

                entity.Property(e => e.objetocontrato).HasMaxLength(250);

                entity.Property(e => e.prazotipocontrato).HasMaxLength(5);

                entity.Property(e => e.tipolicitacaopcjcontrato).HasMaxLength(30);

                entity.Property(e => e.valorpcjcontrapartida).HasColumnType("numeric(30,5)");

                entity.Property(e => e.valorpcjcontrato).HasColumnType("numeric(30,5)");

                entity.HasOne(d => d.idacaopapNavigation)
                    .WithMany(p => p.tbcontrato)
                    .HasForeignKey(d => d.idacaopap)
                    .HasConstraintName("tbcontrato_idacaopap_fkey");

                entity.HasOne(d => d.idfontrecursNavigation)
                    .WithMany(p => p.tbcontrato)
                    .HasForeignKey(d => d.idfontrecurs)
                    .HasConstraintName("tbcontrato_idfontrecurs_fkey");

                entity.HasOne(d => d.idtbareaNavigation)
                    .WithMany(p => p.tbcontrato)
                    .HasForeignKey(d => d.idtbarea)
                    .HasConstraintName("tbcontrato_idtbarea_fkey");

                entity.HasOne(d => d.idtipodemandNavigation)
                    .WithMany(p => p.tbcontrato)
                    .HasForeignKey(d => d.idtipodemand)
                    .HasConstraintName("tbcontrato_idtipodemand_fkey");
            });

            modelBuilder.Entity<tbempresa>(entity =>
            {
                entity.HasKey(e => e.idtbempresa)
                    .HasName("tbempresa_pkey");

                entity.Property(e => e.nomefantasiatbempresa).HasMaxLength(45);

                entity.Property(e => e.razaotbempresa).HasMaxLength(45);
            });

            modelBuilder.Entity<tbendereco>(entity =>
            {
                entity.HasKey(e => e.idtbendereco)
                    .HasName("tbendereco_pkey");

                entity.Property(e => e.ceptbendereco).HasMaxLength(45);

                entity.Property(e => e.cidadetbendereco).HasMaxLength(45);

                entity.Property(e => e.enderecotbendereco).HasMaxLength(45);

                entity.Property(e => e.ibgetbendereco).HasMaxLength(45);
            });

            modelBuilder.Entity<tbfonterecurso>(entity =>
            {
                entity.HasKey(e => e.idtbfonterecurso)
                    .HasName("tbfonterecurso_pkey");

                entity.Property(e => e.descricaotbfonterecurso).HasMaxLength(45);
            });

            modelBuilder.Entity<tbgrupopermss>(entity =>
            {
                entity.HasKey(e => e.idtbgrupopermss)
                    .HasName("tbgrupopermss_pkey");

                entity.Property(e => e.descricaotbgrupopermss).HasMaxLength(45);
            });

            modelBuilder.Entity<tbhistrc>(entity =>
            {
                entity.HasKey(e => e.idhistrc)
                    .HasName("tbhistrc_pkey");

                entity.Property(e => e.datainclshistrc).HasColumnType("date");

                entity.Property(e => e.textohistrc).IsRequired();

                entity.Property(e => e.tipohistrc).HasMaxLength(30);

                entity.HasOne(d => d.idcontratoNavigation)
                    .WithMany(p => p.tbhistrc)
                    .HasForeignKey(d => d.idcontrato)
                    .HasConstraintName("tbhistrc_idcontrato_fkey");

                entity.HasOne(d => d.idpessrespnsvlNavigation)
                    .WithMany(p => p.tbhistrc)
                    .HasForeignKey(d => d.idpessrespnsvl)
                    .HasConstraintName("tbhistrc_idpessrespnsvl_fkey");

                entity.HasOne(d => d.idtbaditivoNavigation)
                    .WithMany(p => p.tbhistrc)
                    .HasForeignKey(d => d.idtbaditivo)
                    .HasConstraintName("tbhistrc_idtbaditivo_fkey");
            });

            modelBuilder.Entity<tbparcela>(entity =>
            {
                entity.HasKey(e => e.idtbparcela)
                    .HasName("tbparcela_pkey");

                entity.Property(e => e.valortbparcela).HasColumnType("numeric");

                entity.HasOne(d => d.tbaditivo_idtbaditivoNavigation)
                    .WithMany(p => p.tbparcela)
                    .HasForeignKey(d => d.tbaditivo_idtbaditivo)
                    .HasConstraintName("tbparcela_tbaditivo_idtbaditivo_fkey");

                entity.HasOne(d => d.tbcontrato_idtbcontratoNavigation)
                    .WithMany(p => p.tbparcela)
                    .HasForeignKey(d => d.tbcontrato_idtbcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbparcela_tbcontrato_idtbcontrato_fkey");
            });

            modelBuilder.Entity<tbperfil>(entity =>
            {
                entity.HasKey(e => e.idtbperfil)
                    .HasName("tbperfil_pkey");

                entity.Property(e => e.descricaotbperfil).HasMaxLength(45);
            });

            modelBuilder.Entity<tbpermissvisulzc>(entity =>
            {
                entity.HasKey(e => e.idpermissvisulzc)
                    .HasName("tbpermissvisulzc_pkey");

                entity.Property(e => e.datapermissvisulzc).HasColumnType("date");

                entity.Property(e => e.validadepermissvisulzc).HasColumnType("date");

                entity.HasOne(d => d.idcontratoNavigation)
                    .WithMany(p => p.tbpermissvisulzc)
                    .HasForeignKey(d => d.idcontrato)
                    .HasConstraintName("tbpermissvisulzc_idcontrato_fkey");

                entity.HasOne(d => d.idpessrespnsvlNavigation)
                    .WithMany(p => p.tbpermissvisulzc)
                    .HasForeignKey(d => d.idpessrespnsvl)
                    .HasConstraintName("tbpermissvisulzc_idpessrespnsvl_fkey");

                entity.HasOne(d => d.idtbareaNavigation)
                    .WithMany(p => p.tbpermissvisulzc)
                    .HasForeignKey(d => d.idtbarea)
                    .HasConstraintName("tbpermissvisulzc_idtbarea_fkey");
            });

            modelBuilder.Entity<tbpermss>(entity =>
            {
                entity.HasKey(e => e.idtbpermss)
                    .HasName("tbpermss_pkey");

                entity.HasOne(d => d.tbcontrato_idtbcontratoNavigation)
                    .WithMany(p => p.tbpermss)
                    .HasForeignKey(d => d.tbcontrato_idtbcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbpermss_tbcontrato_idtbcontrato_fkey");

                entity.HasOne(d => d.tbgrupopermss_idtbgrupopermssNavigation)
                    .WithMany(p => p.tbpermss)
                    .HasForeignKey(d => d.tbgrupopermss_idtbgrupopermss)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbpermss_tbgrupopermss_idtbgrupopermss_fkey");

                entity.HasOne(d => d.tbperfil_idtbperfilNavigation)
                    .WithMany(p => p.tbpermss)
                    .HasForeignKey(d => d.tbperfil_idtbperfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbpermss_tbperfil_idtbperfil_fkey");

                entity.HasOne(d => d.tbpessoa_idtbpessoaNavigation)
                    .WithMany(p => p.tbpermss)
                    .HasForeignKey(d => d.tbpessoa_idtbpessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbpermss_tbpessoa_idtbpessoa_fkey");
            });

            modelBuilder.Entity<tbpessoa>(entity =>
            {
                entity.HasKey(e => e.idtbpessoa)
                    .HasName("tbpessoa_pkey");

                entity.Property(e => e.documentotbpessoa).HasMaxLength(45);

                entity.Property(e => e.isrespnsvlagenctbpessoa).HasMaxLength(45);

                entity.Property(e => e.nometbpessoa).HasMaxLength(45);

                entity.Property(e => e.sobrenometbpessoa).HasMaxLength(45);

                entity.HasOne(d => d.tbarea_idtbareaNavigation)
                    .WithMany(p => p.tbpessoa)
                    .HasForeignKey(d => d.tbarea_idtbarea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbpessoa_tbarea_idtbarea_fkey");

                entity.HasOne(d => d.tbcargo_idtbcargoNavigation)
                    .WithMany(p => p.tbpessoa)
                    .HasForeignKey(d => d.tbcargo_idtbcargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbpessoa_tbcargo_idtbcargo_fkey");
            });

            modelBuilder.Entity<tbprodutos>(entity =>
            {
                entity.HasKey(e => e.idtbprodutos)
                    .HasName("tbprodutos_pkey");

                entity.Property(e => e.descricaotbprodutos).HasMaxLength(45);

                entity.Property(e => e.linktbprodutos).HasMaxLength(45);

                entity.Property(e => e.tipotbprodutos).HasMaxLength(45);

                entity.HasOne(d => d.tbaditivo_idtbaditivoNavigation)
                    .WithMany(p => p.tbprodutos)
                    .HasForeignKey(d => d.tbaditivo_idtbaditivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbprodutos_tbaditivo_idtbaditivo_fkey");

                entity.HasOne(d => d.tbarqv_idtbarqvNavigation)
                    .WithMany(p => p.tbprodutos)
                    .HasForeignKey(d => d.tbarqv_idtbarqv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbprodutos_tbarqv_idtbarqv_fkey");

                entity.HasOne(d => d.tbcontrato_idtbcontratoNavigation)
                    .WithMany(p => p.tbprodutos)
                    .HasForeignKey(d => d.tbcontrato_idtbcontrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbprodutos_tbcontrato_idtbcontrato_fkey");

                entity.HasOne(d => d.tbhistrc_idhistrcNavigation)
                    .WithMany(p => p.tbprodutos)
                    .HasForeignKey(d => d.tbhistrc_idhistrc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbprodutos_tbhistrc_idhistrc_fkey");

                entity.HasOne(d => d.tbparcela_idtbparcelaNavigation)
                    .WithMany(p => p.tbprodutos)
                    .HasForeignKey(d => d.tbparcela_idtbparcela)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbprodutos_tbparcela_idtbparcela_fkey");
            });

            modelBuilder.Entity<tbr_contrtemprs>(entity =>
            {
                entity.HasKey(e => e.idtbr_contrtemprs)
                    .HasName("tbr_contrtemprs_pkey");

                entity.HasOne(d => d.tbempresa_idtbempresaNavigation)
                    .WithMany(p => p.tbr_contrtemprs)
                    .HasForeignKey(d => d.tbempresa_idtbempresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbr_contrtemprs_tbempresa_idtbempresa_fkey");

                entity.HasOne(d => d.tbendereco_idtbenderecoNavigation)
                    .WithMany(p => p.tbr_contrtemprs)
                    .HasForeignKey(d => d.tbendereco_idtbendereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbr_contrtemprs_tbendereco_idtbendereco_fkey");
            });

            modelBuilder.Entity<tbsituacao>(entity =>
            {
                entity.HasKey(e => e.idtbsituacao)
                    .HasName("tbsituacao_pkey");

                entity.Property(e => e.descricaotbsituacao).HasMaxLength(45);
            });

            modelBuilder.Entity<tbtipodemand>(entity =>
            {
                entity.HasKey(e => e.idtipodemand)
                    .HasName("tbtipodemand_pkey");

                entity.Property(e => e.descricaotipodemand).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
