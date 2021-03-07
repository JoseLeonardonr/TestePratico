using CadastroEstabelecimento.Data;
using CadastroEstabelecimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroEstabelecimento.Services.Exceptions;

namespace CadastroEstabelecimento.Services
{
    public class EstabelecimentosServices
    {
        private readonly CadastroEstabelecimentoContext _context;

        public EstabelecimentosServices(CadastroEstabelecimentoContext context)
        {
            _context = context;
        }

        public List<Estabelecimentos> FindAll()
        {
            return _context.Estabelecimentos.ToList();
        }

        public void Insert(Estabelecimentos obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Estabelecimentos FindById(int id)
        {
            return _context.Estabelecimentos.Include(obj => obj.Categorias).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {

            var obj = _context.Estabelecimentos.Find(id);
            _context.Estabelecimentos.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Estabelecimentos obj)
        {
            
            if (!_context.Estabelecimentos.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {

                _context.Update(obj);
                _context.SaveChanges();
            }
                catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
       
                
      

    }


}
