using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.ConcrEte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
   public class EfContantRepository: GenericRepository<Contact>, IContactDal
    {
    }
}
