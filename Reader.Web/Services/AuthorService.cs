using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reader.ReaderDb;
using Reader.ReaderDb.Model;
using Reader.Web.PageModel;

namespace Reader.Web.Services
{
    public class AuthorService
    {
        EFRepository<AuthorModel> mAuthorRepository { get; set; }

        public AuthorService(ReaderDbContext dbContext)
        {
            mAuthorRepository = new EFRepository<AuthorModel>(dbContext);
        }

        public List<AuthorItemViewModel> GetListAllModel()
        {
            var authorList = mAuthorRepository.Get().Select(r=>new AuthorItemViewModel(r)).ToList();
            return authorList;
        }
    }
}
