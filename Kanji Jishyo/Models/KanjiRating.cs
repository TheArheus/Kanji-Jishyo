using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kanji_Jishyo.Models
{
    [Table("KanjiRating")]
    public class KanjiRating
    {
        [Key]
        public int KanjiRatingId { get; set; }

        [Column("PopularityRating")]
        public double PopularityRating { get; set; }

        [Column("JLPTRating")]
        public double JLPTRating { get; set; }

        [Column("SchoolRating")]
        public double SchoolRating { get; set; }

        //[ForeignKey("KanjiId")]
        //public Kanji KanjiId { get; set; }
    }
}