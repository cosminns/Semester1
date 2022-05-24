using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopUp1.Facades.Interfaces;
using TopUp1.DAL.Interfaces;

namespace TopUp1.Facades
{
    public class VolumeFacade : IVolumeFacade
    {
        private IDAO<Volume> volumeDao;
        private ITitleFacade titleFacade;
        public VolumeFacade(IDAO<Volume> volumeDao, ITitleFacade titleFacade)
        {
            this.volumeDao = volumeDao;
            this.titleFacade = titleFacade;
        }

        public bool DeleteVolume(Volume volume)
        {
            return volumeDao.Delete(volume);
        }

        public Volume GetVolumeInfo(string isbn, int volumeNumber)
        {
            Volume volume;
            volume = volumeDao.GetById(new Volume { VolumeNumber = volumeNumber, Title = new Title { ISBN = isbn } });
            volume.Title = titleFacade.GetTitleInfo(volume.Title.ISBN);
            return volume;
        }

        public bool SaveVolume(Volume volume)
        {
            return volumeDao.Create(volume);
        }

        public bool UpdateVolume(Volume volume)
        {
            return volumeDao.Update(volume);
        }
    }
}