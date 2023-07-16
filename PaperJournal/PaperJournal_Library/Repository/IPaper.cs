using PaperJournal_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperJournal_Library.Repository
{
    public interface IPaper
    {
        public IEnumerable<Paper> GetAllPaper();
        bool Add(Paper paper);
        bool Delete(Paper paper);
        bool Update(Paper paper);
    }
}
