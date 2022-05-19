using Microsoft.AspNetCore.Mvc;

namespace TopUp1.Controllers
{
    public class VolumeController : Controller
    {
        [Route("api/volume")]
        [HttpGet]
        public List<Volume> GetVolume()
        {
            var volumes = new List<Volume>();
            return volumes;
        }
        [HttpGet]
        [Route("api/volume/{id}")]
        public Volume GetVolumeById(int id)
        {
            var volume = new Volume("string",1,true);
            return volume;
        }
        [HttpPost]
        [Route("api/volume")]
        public bool CreateVolume(string titleISBN, int volumeNumber, bool borrowed)
        {
            var result = true;
            return result;
        }
        [HttpPut]
        [Route("api/volume/{id}")]
        public bool UpdateVolume(string titleISBN, int volumeNumber, bool borrowed)
        {
            //Checks for null parameters
            var result = true;
            return result;
        }
        [HttpDelete]
        [Route("api/volume/{id}")]
        public bool DeleteVolume(int id)
        {
            bool result = true;
            return result;
        }
    }
}
