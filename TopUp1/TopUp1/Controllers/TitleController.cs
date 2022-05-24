using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;

namespace TopUp1.Controllers
{
    public class TitleController : Controller
    {
        ITitleFacade titleFacade = new TitleFacade(new TitleDAO());
        
        [HttpGet]
        [Route("api/title/{isbn}")]
        public Title GetTitleById(string isbn)
        {
            return titleFacade.GetTitleInfo(isbn);
        }
        [HttpPost]
        [Route("api/title")]
        public bool CreateTitle(string isbn, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            Title t = new Title();
            t.ISBN = isbn;
            t.TitleDesc = titleDesc;
            t.TitleTitle = title;
            t.Publisher = publisher;
            t.PublishingDate = publishingDate;
            t.SubjectArea = subjectArea;
            t.TitleType = titleType;
            t.TitleStatus = titleStatus;
            return titleFacade.SaveTitle(t);
        }
        [HttpPut]
        [Route("api/title/{isbn}")]
        public bool UpdateTitle(string isbn, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            Title t = new Title();
            t.ISBN = isbn;
            t.TitleDesc = titleDesc;
            t.TitleTitle = title;
            t.Publisher = publisher;
            t.PublishingDate = publishingDate;
            t.SubjectArea = subjectArea;
            t.TitleType = titleType;
            t.TitleStatus = titleStatus;
            return titleFacade.UpdateTitle(t);
        }
        [HttpDelete]
        [Route("api/title/{isbn}")]
        public bool DeleteTitle(string isbn)
        {
            Title t = new Title();
            t.ISBN = isbn;
            return titleFacade.DeleteTitle(t);
        }
    }
}
