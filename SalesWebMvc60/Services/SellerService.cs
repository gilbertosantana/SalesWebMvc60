using SalesWebMvc60.Data;
using SalesWebMvc60.Models;

namespace SalesWebMvc60.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc60Context _context;

        public SellerService(SalesWebMvc60Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
