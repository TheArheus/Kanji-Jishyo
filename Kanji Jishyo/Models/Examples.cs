using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kanji_Jishyo.Models
{
    [Table("Examples")]
    public partial class Examples
    {
        public int Id { get; set; }

        [Column("KanjiId")]
        public int KanjiId { get; set; }

        [MaxLength(50), Column("KanjiExample")]
        public string KanjiExample { get; set; }

        [MaxLength(50), Column("ExampleTranslation")]
        public string ExampleTranslation { get; set; }
    }
}