using System;

namespace Assets.Models
{
   public abstract class BaseEntity
    {

        public string StatusCd { get; set; }

        public DateTime? CreateDate { get; set; }
        public string CreateByUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateByUser { get; set; }
        public virtual byte[] RecordTimeStamp { get; set; }
    }
}
