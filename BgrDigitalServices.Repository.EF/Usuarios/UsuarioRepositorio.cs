using Ardalis.Specification.EntityFrameworkCore;
using BgrDigitalServices.Core.Usuarios.Dominio.Agregado;

namespace BgrDigitalServices.Repository.EF.Usuarios
{
    public class UsuarioRepositorio(BancaDigitalDbContext dbContext) : RepositoryBase<Usuario>(dbContext);
}