using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reader.ReaderDb.Model
{
    [Table("Author")]
    public class AuthorModel : ICloneable
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime InsertDate { get; set; }
        public string Nickname { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime DeathDay { get; set; }
        public int Time { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
