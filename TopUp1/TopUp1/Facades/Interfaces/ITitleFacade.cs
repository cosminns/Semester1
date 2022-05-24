using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopUp1.Facades.Interfaces
{
    public interface ITitleFacade
    {
        public bool SaveTitle(Title title);
        public bool UpdateTitle(Title title);
        public bool DeleteTitle(Title title);
        public Title GetTitleInfo(string isbn);
    }
}