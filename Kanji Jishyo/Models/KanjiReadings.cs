using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kanji_Jishyo.Models
{
    [Table("KanjiReadings")]
    public partial class KanjiReadings
    {
        public int Id { get; set; }

        [ForeignKey("KanjiId")]
        public Kanji Kanji { get; set; }

        //[ForeignKey("KanjiId")]
        public int KanjiId { get; set; }

        [MaxLength(30), Column("On")]
        public string On { get; set; }

        [MaxLength(30), Column("Kun")]
        public string Kun { get; set; }
    }
}