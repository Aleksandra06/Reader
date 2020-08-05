using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reader.ReaderDb.Model
{
    [Table("Read")]
    public class ReadModel : ICloneable
    {
        [Key]
        public int ReadId { get; set; }
        public int BookId { get; set; }
        public string Commentary { get; set; }
        public int Rating { get; set; }
        public DateTime DateRead { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Age { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
