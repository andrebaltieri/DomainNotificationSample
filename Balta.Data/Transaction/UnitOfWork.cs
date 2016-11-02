using Balta.Data.Contexts;

namespace Balta.Data.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private BaltaDataContext _context;

        public UnitOfWork(BaltaDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // 
        }
    }
}
