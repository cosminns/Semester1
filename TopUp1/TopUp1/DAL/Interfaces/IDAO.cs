using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopUp1.DAL.Interfaces
{
    public interface IDAO<T>
    {
        public T GetById(T t);
        public bool Create(T t);
        public bool Update(T t);
        public bool Delete(T t);
    }
}