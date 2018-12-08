using System;
using System.Collections.Generic;
using System.Linq;
namespace Models
{
  public  class Medicine: BaseEntity
    {

        public Medicine():base()
        {

        }
        public String Name { get; set;  }
       
        public String Description { get; set; }

        public bool requiresdrpermit { get; set; }
 
        
        public int amount { get; set;  }

        public int price { get; set; }

        public string display {
            get {
                return $"{Name} --------------{amount} ---------------{price}-------{requiresdrpermit}";


            }
        }
        
    }
}
