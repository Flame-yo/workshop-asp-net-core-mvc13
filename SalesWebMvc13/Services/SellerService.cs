using Microsoft.EntityFrameworkCore;
using SalesWebMvc13.Data;
using SalesWebMvc13.Models;
using SalesWebMvc13.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc13.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc13Context _context;

        public SellerService(SalesWebMvc13Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(x => x.Department).FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            Seller obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller seller)
        {
            if (!_context.Seller.Any(x => x.Id == seller.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(seller);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
