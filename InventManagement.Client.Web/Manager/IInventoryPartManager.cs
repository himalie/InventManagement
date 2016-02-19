using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventManagement.Domain.Models;

namespace InventManagement.Client.Web.Manager
{
    public interface IInventoryPartManager
    {
        IList<InventoryPart> FindAll();
        //InventoryPart FindById(int id);
    }
}
