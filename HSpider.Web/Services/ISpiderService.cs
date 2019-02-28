using System.Collections.Generic;
using HSpider.Web.Models;

namespace HSpider.Web.Services
{
    public interface ISpiderService
    {
        void AddComic(Comic comic);
        Comic GetComic(int id);
        List<Comic> GetAllComics();
        void UpdateComic(Comic comic);
        void DeleteComic(Comic comic);
    }
}
