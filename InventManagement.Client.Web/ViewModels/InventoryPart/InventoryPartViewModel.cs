using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventManagement.Client.Web.ViewModels.InventoryPart
{
    public class InventoryPartViewModel
    {
        #region Model Properties
        // We don't use UI to save cars, 
        // so I don't apply Model Validations here. :)
        public int Id { get; set; }
        public string PartName { get; set; }       
        public DateTime ManufDate { get; set; }        
        public DateTime ExpiryDate { get; set; }
        public decimal Price { get; set; }        
        public string Comments { get; set; }
        #endregion

        #region Calculated properties        

        public Decimal TimeForExpiry
        {
            get
            {
                // add the calculation here
                return 0;            
            }
        }

        public bool ExpiryStatus
        {
            get
            {
                // add the calculation here
                return false;
            }
        }
        #endregion
    }
}