using LibreriaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaApi
{
    public class LibrosContext :  DbContext
    {
        public DbSet<Cliente> Cliente{get;set;}
        public DbSet<Compra> Compra{get;set;}
        public DbSet<Libro> Libro{get;set;}
        public DbSet<Pedido> Pedido{get;set;}
        public DbSet<Prestamo> Prestamo{get;set;}
        public DbSet<Proveedor> Proveedor{get;set;}
        public DbSet<Categoria> Categoria{get;set;}

        public LibrosContext(DbContextOptions<LibrosContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Prestamo>(prestamo=>{
                prestamo.ToTable("Pedido");
                prestamo.HasKey(p=>p.Id);
                prestamo.Property(p=>p.IdLibro).IsRequired();
            });


            List<Proveedor>proveedores = new List<Proveedor>();
            proveedores.Add(new Proveedor{Id =Guid.Parse("fb28a544-2b63-4d33-b031-302c9371989d"), Nombre="Libreria Sanitas",Direccion="C.A.B.A.",Email="sanitas@gmail.com", Telefono="48484684618", FechaCreacion=DateTime.Now});
            proveedores.Add(new Proveedor{Id =Guid.Parse("fb28a544-2b63-4d33-b031-302c9372587d"), Nombre="Editorial Santander",Direccion="C.A.B.A.",Email="santander@gmail.com", Telefono="484846846891", FechaCreacion=DateTime.Now});

            modelBuilder.Entity<Proveedor>(proveedor=>{
                proveedor.ToTable("proveedor");
                proveedor.HasKey(p=>p.Id);
                proveedor.Property(p=>p.Nombre).IsRequired().HasMaxLength(150);
                proveedor.Property(p=>p.Direccion).IsRequired(false);
                proveedor.Property(p=>p.Email).IsRequired(false);
                proveedor.Property(p=>p.Telefono).IsRequired(false); 
                proveedor.HasData(proveedores);
            });

            List<Categoria>categoriasInit =  new List<Categoria>();
            categoriasInit.Add(new Categoria() {Id= Guid.Parse("14ab2c00-fa1f-4107-996c-15900e473350"), Nombre ="Ciencia Ficción", Descripcion="Ciencia Ficción", Peso= 10});
            categoriasInit.Add(new Categoria() {Id= Guid.Parse("14ab2c00-fa1f-4107-996c-15900e473330"), Nombre ="Dramas del siglo XX", Descripcion="Dramas del siglo XX", Peso= 05});

            modelBuilder.Entity<Categoria>(categoria=>{
                categoria.ToTable("categoria");
                categoria.HasKey(p=>p.Id);
                categoria.Property(p=>p.Nombre).IsRequired().HasMaxLength(150);
                categoria.Property(p=>p.Descripcion).IsRequired(false).HasMaxLength(500);
                categoria.Property(p=>p.Peso);
               categoria.HasData(categoriasInit);
            });
        }

    }


}