using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;

namespace TopUp1.Controllers
{
    public class VolumeController : Controller
    {
        IVolumeFacade volumeFacade = new VolumeFacade(new VolumeDAO(), new TitleFacade(new TitleDAO()));
        
        [Route("api/volume")]
        [HttpGet]
        public List<Volume> GetVolume()
        {
            var volumes = new List<Volume>();
            return volumes;
        }
        [HttpGet]
        [Route("api/volume/{titleISBN}/{volumeNumber}")]
        public Volume GetVolumeById(string titleISBN, int volumeNumber)
        {
            return volumeFacade.GetVolumeInfo(titleISBN, volumeNumber);
        }
        [HttpPost]
        [Route("api/volume")]
        public bool CreateVolume(string titleISBN, int volumeNumber, bool borrowed)
        {
            Volume volume = new Volume();
            volume.Title.ISBN = titleISBN;
            volume.VolumeNumber = volumeNumber;
            volume.Borrowed = borrowed;
            return volumeFacade.SaveVolume(volume);
        }
        [HttpPut]
        [Route("api/volume/{titleISBN}/{volumeNumber}")]
        public bool UpdateVolume(string titleISBN, int volumeNumber, bool borrowed)
        {
            Volume volume = new Volume();
            volume.Title.ISBN = titleISBN;
            volume.VolumeNumber = volumeNumber;
            volume.Borrowed = borrowed;
            return volumeFacade.UpdateVolume(volume);
        }
        [HttpDelete]
        [Route("api/volume/{titleISBN}/{volumeNumber}")]
        public bool DeleteVolume(string titleISBN, int volumeNumber)
        {
            Volume volume = new Volume();
            volume.Title.ISBN = titleISBN;
            volume.VolumeNumber = volumeNumber;
            return volumeFacade.DeleteVolume(volume);
        }
    }
}
