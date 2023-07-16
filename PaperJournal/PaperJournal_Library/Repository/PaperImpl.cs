using Microsoft.EntityFrameworkCore;
using PaperJournal_Library.Models;

namespace PaperJournal_Library.Repository
{
    public class PaperImpl : IPaper
    {
        private PaperJournalSp2023DBContext _db;

        public PaperImpl()
        {
            _db = new PaperJournalSp2023DBContext();
        }

        public bool Add(Paper paper)
        {
            try
            {
                var checkExist = _db.Papers.Find(paper.PaperId);
                if (checkExist != null)
                {
                    _db.Entry(checkExist).State = EntityState.Detached;
                }
                _db.Papers.Add(paper);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Paper paper)
        {
            try
            {
                var checkExist = _db.Papers.Find(paper.PaperId);
                if (checkExist != null)
                {
                    _db.Entry(checkExist).State = EntityState.Detached;
                }
                _db.Papers.Remove(paper);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Paper> GetAllPaper()
        {
            return _db.Papers.Include(p => p.Journal).ToList();
        }

        public bool Update(Paper paper)
        {
            try
            {
                var checkExist = _db.Papers.Find(paper.PaperId);
                if (checkExist != null)
                {
                    _db.Entry(checkExist).State = EntityState.Detached;
                }
                _db.Papers.Update(paper);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
