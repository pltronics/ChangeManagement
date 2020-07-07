using System;

namespace ChangeManagement.Models
{
    public class Stake
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Question { get; set; }
        public string Examples { get; set; }
        public string Signers { get; set; }
    }
}