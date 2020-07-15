using System;

namespace ChangeManagement.Models
{
    public class Change
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public DateTime CreatedOn { get; set; }
/*        
        public string RequiredSignatures { get; set; }
        public Nullable<DateTime> MtgDate { get; set; }
        public Nullable<DateTime> TargetDate { get; set; }
        public string Status {get; set;}
*/
    }
}
