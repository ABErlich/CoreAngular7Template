using System;
using System.Collections.Generic;

namespace Organigrama.Models.EntityBase
{
    public class EntityBase
    {
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool Deleted { get; set; }

        public EntityBase(){
            Deleted = false;
        }

        public virtual int IdentityID(){
            return 0;
        }

        public virtual object[] IdentityID(bool dummy = true){
            return new List<object>().ToArray();
        }
    }
}
