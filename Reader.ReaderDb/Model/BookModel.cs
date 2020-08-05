using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reader.ReaderDb.Model
{
    [Table("Books")]
    public class BookModel : ICloneable
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public int AutorId { get; set; }
        public int BookGenreId1 { get; set; }
        public int BookGenreId2 { get; set; }
        public int BookGenreId3 { get; set; }
        public int Age { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
