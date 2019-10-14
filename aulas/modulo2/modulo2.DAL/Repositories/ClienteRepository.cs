using System;
using modulo2.DAL.Contexts;
using modulo2.DAL.Domain;

namespace modulo2.DAL.Repositories
{
    public class ClienteRepository : IRepositoryBase<Cliente>
    {
        private readonly Modulo2Context _context;
        public ClienteRepository(Modulo2Context context)
        {
            _context = context;

        }
        public void Add(Cliente obj)
        {
            _context.Clientes.Add(obj);
            _context.SaveChanges();
        }

        public void AddRange(System.Collections.Generic.ICollection<Cliente> obj)
        {
            _context.Clientes.AddRange(obj);
            _context.SaveChanges();
        }

        public System.Collections.Generic.IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes;
        }

        public Cliente GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void Remove(Cliente obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Update(Cliente obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;            
            _context.SaveChanges();
        }
    }
}