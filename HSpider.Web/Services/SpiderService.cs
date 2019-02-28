using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HSpider.Web.Models;

namespace HSpider.Web.Services
{
    public class SpiderService : ISpiderService
    {
        private readonly HSpiderContext _context;

        public SpiderService(HSpiderContext context)
        {
            _context = context;
        }

        public void AddComic(Comic comic)
        {
            _context.Comic.Add(comic);
            _context.SaveChanges();
        }

        public void DeleteComic(Comic comic)
        {
            throw new NotImplementedException();
        }

        public List<Comic> GetAllComics()
        {
            return _context.Comic.ToList();
        }

        public Comic GetComic(int id)
        {
            return _context.Comic.Find(id);
        }

        public void UpdateComic(Comic comic)
        {
            throw new NotImplementedException();
        }
    }
}
