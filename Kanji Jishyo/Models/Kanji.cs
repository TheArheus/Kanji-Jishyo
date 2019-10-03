using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kanji_Jishyo.Models
{
    [Table("Kanji")]
    public class Kanji
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("KanjiId")]
        public int KanjiId { get; set; }

        [Required,MaxLength(30), Column("KanjiMean")]
        public string KanjiMean { get; set; }

        [Required, Column("KanjiStrokes")]
        public int KanjiStrokes { get; set; }

        //[Column(TypeName = "Image")]
        [Required, MaxLength(1), Column("KanjiImage")]
        public string KanjiImage { get; set; }

        [Column("KanjiDraw",TypeName = "image")]
        public byte[] KanjiDraw { get; set; }

        [Required, Column("KanjiKey")]
        public string KanjiKey { get; set; }

        [ForeignKey("KanjiRatingId")]
        public KanjiRating KanjiRating { get; set; }

        public int KanjiRatingId { get; set; }
    }
}