using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventManagement.Domain.Models;
using InventManagement.Domain.Context;
using Serilog;

namespace InventManagement.Client.Web.Manager
{
    public class InventoryPartManager : ManagerBase, IInventoryPartManager
    {
        private readonly InventContext _inventContext;

        public InventoryPartManager(InventContext inventManager, ILogger logger) : base(logger)
        {
            _inventContext = inventManager;
        }

        public IList<InventoryPart> FindAll()
        {
            return _inventContext.Parts.ToList<InventoryPart>();

        }
        //InventoryPart FindById(int id);
    }
}