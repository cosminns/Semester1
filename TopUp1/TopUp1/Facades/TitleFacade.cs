using TopUp1.Facades.Interfaces;
using TopUp1.DAL.Interfaces;

namespace TopUp1.Facades
{
    public class TitleFacade : ITitleFacade
    {
        private IDAO<Title> titleDao;

        public TitleFacade(IDAO<Title> titleDao)
        {
            this.titleDao = titleDao;
        }

        public bool DeleteTitle(Title title)
        {
            return titleDao.Delete(title);
        }

        public Title GetTitleInfo(string isbn)
        {
            return titleDao.GetById(new Title { ISBN = isbn });
        }

        public bool SaveTitle(Title title)
        {
            return titleDao.Create(title);
        }

        public bool UpdateTitle(Title title)
        {
            return titleDao.Update(title);
        }
    }
}