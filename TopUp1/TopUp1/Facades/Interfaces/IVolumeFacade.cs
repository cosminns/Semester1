using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopUp1.Facades.Interfaces
{
    public interface IVolumeFacade
    {
        public bool SaveVolume(Volume volume);
        public bool UpdateVolume(Volume volume);
        public bool DeleteVolume(Volume volume);
        public Volume GetVolumeInfo(string isbn, int volumeNumber);
    }
}