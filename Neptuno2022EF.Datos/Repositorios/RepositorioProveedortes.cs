using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos.Proveedor;
using Neptuno2022EF.Entidades.Dtos.SupplierProducts;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioProveedores:IRepositorioProveedores
    {
        private readonly NeptunoDbContext _context;

        public RepositorioProveedores(NeptunoDbContext context)
        {
            _context = context;
        }

        public void Agregar(Proveedor proveedor)
        {
            try
            {
                _context.Proveedores.Add(proveedor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Borrar(int id)
        {
            try
            {
                var proveedorInDb = GetProveedorPorId(id);
                if (proveedorInDb == null)
                {
                    throw new Exception("Registro borrado por otro usuario");
                }
                _context.Entry(proveedorInDb).State = EntityState.Deleted;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Editar(Proveedor proveedor)
        {
            try
            {
                var proveedorInDb = GetProveedorPorId(proveedor.Id);
                if (proveedorInDb == null)
                {
                    throw new Exception("Registro borrado por otro usuario");
                }
                _context.Entry(proveedor).State = EntityState.Modified;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(Proveedor proveedor)
        {
            try
            {
                return _context.Productos.Any(p => p.ProveedorId == proveedor.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                if (proveedor.Id == 0)
                {
                    return _context.Proveedores.Any(c => c.Nombre == proveedor.Nombre);
                }
                return _context.Proveedores.Any(c => c.Nombre == proveedor.Nombre && c.Id != proveedor.Id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Exist(int supplierId)
        {
            try
            {
                return _context.Proveedores.Any(c => c.Id == supplierId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<ProveedorListDto> Filtrar(Func<Proveedor, bool> predicado)
        {
            return _context.Proveedores.Include(c => c.Pais)
                .Include(c => c.Ciudad)
                .Where(predicado)
                .Select(c => new ProveedorListDto
                {
                    ProveedorId = c.Id,
                    NombreProveedor = c.Nombre,
                    Pais = c.Pais.NombrePais,
                    Ciudad = c.Ciudad.NombreCiudad
                }).ToList();
        }

        public Proveedor GetProveedorPorId(int id)
        {
            try
            {
                return _context.Proveedores.Include(c => c.Pais)
                    .Include(c => c.Ciudad)
                    .SingleOrDefault(c => c.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProveedorListDto> GetProveedores()
        {
            return _context.Proveedores.Include(c => c.Pais)
                .Include(c => c.Ciudad).Select(c => new ProveedorListDto
                {
                    ProveedorId = c.Id,
                    NombreProveedor = c.Nombre,
                    Pais = c.Pais.NombrePais,
                    Ciudad = c.Ciudad.NombreCiudad
                }).ToList();
        }

        public List<ProveedorListDto> GetProveedores(int paisId, int ciudadId)
        {
            try
            {
                return _context.Proveedores.Include(c => c.Pais)
                    .Include(c => c.Ciudad)
                    .Where(c => c.PaisId == paisId && c.CiudadId == ciudadId)
                    .Select(c => new ProveedorListDto
                    {
                        ProveedorId = c.Id,
                        NombreProveedor = c.Nombre,
                        Pais = c.Pais.NombrePais,
                        Ciudad = c.Ciudad.NombreCiudad
                    }).ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<ProveedorListDto> GetSuppliersByPage(int actualPage, int elementsByPage)
        {
            try
            {
                return _context.Proveedores.Include(c => c.Pais)
                                           .Include(c => c.Ciudad)
                                           .OrderBy(c => c.Nombre)
                                           .Skip(elementsByPage * (actualPage - 1))
                                           .Take(elementsByPage)
                                            .Select(c => new ProveedorListDto
                                            {
                                                ProveedorId = c.Id,
                                                NombreProveedor = c.Nombre,
                                                Pais = c.Pais.NombrePais,
                                                Ciudad = c.Ciudad.NombreCiudad
                                            }).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<ProveedorListDto> GetSuppliersByPageAndCondition(Func<Proveedor, bool> filterCondition, int actualPage, int elementsByPage)
        {
            try
            {
                return _context.Proveedores.Include(c => c.Pais)
                                           .Include(c => c.Ciudad)
                                           .Where(filterCondition)
                                           .OrderBy(c => c.Nombre)
                                           .Skip(elementsByPage * (actualPage - 1))
                                           .Take(elementsByPage)
                                            .Select(c => new ProveedorListDto
                                            {
                                                ProveedorId = c.Id,
                                                NombreProveedor = c.Nombre,
                                                Pais = c.Pais.NombrePais,
                                                Ciudad = c.Ciudad.NombreCiudad
                                            }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SupplierProductsDtoList> GetSuppliersWithTotalProducts()
        {
            var suppliers = _context.Proveedores.ToList();
            var products = _context.Productos.ToList();

            var result = from supplier in suppliers
                         join product in products
                         on supplier.Id equals product.ProveedorId
                         orderby supplier.Nombre
                         group supplier by supplier.Id into groupedSuppliers
                         select new SupplierProductsDtoList()
                         {
                             Supplier = groupedSuppliers.FirstOrDefault(s => s.Id == groupedSuppliers.Key).Nombre,
                             TotalProducts = groupedSuppliers.Count()
                         };

            return result.ToList();
        }

    }
}
