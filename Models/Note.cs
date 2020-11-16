using System;

namespace ChangeManagement.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Creator { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ChangeId { get; set; }
    }
}