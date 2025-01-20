using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public interface IProductDal
    {
        List<IProductDal> GetAll();
        void Add(IProductDal product);
    }
}
