using Microsoft.AspNetCore.Mvc;

namespace TopUp1.Controllers
{
    public class TitleController : Controller
    {
        [Route("api/title")]
        [HttpGet]
        public List<Title> GetTitle()
        {
            var titles = new List<Title>();
            return titles;
        }
        [HttpGet]
        [Route("api/title/{id}")]
        public Title GetTitleById(int id)
        {
            var title = new Title("string1","string2","string3", "string4", "string5", "string6", "string7", "string8");
            return title;
        }
        [HttpPost]
        [Route("api/title")]
        public bool CreateTitle(string iSBN, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            var result = true;
            return result;
        }
        [HttpPut]
        [Route("api/title/{id}")]
        public bool UpdateTitle(string iSBN, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            //Checks for null parameters
            var result = true;
            return result;
        }
        [HttpDelete]
        [Route("api/title/{id}")]
        public bool DeleteTitle(int id)
        {
            bool result = true;
            return result;
        }
    }
}
