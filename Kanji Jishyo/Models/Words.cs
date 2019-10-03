using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kanji_Jishyo.Models
{
    [Table("Words")]
    public partial class Words : Kanji
    {
        [Key, Column("WordId")]
        public int WordId { get; set; }

        [ForeignKey("KanjiId")]
        public Kanji Kanji { get; set; }

        [Column("Kanji1Id")]
        public int Kanji1Id { get; set; }

        [Column("Kanji2Id")]
        public int Kanji2Id { get; set; }

        [Column("Kanji3Id")]
        public int Kanji3Id { get; set; }

        [Column("Kanji4Id")]
        public int Kanji4Id { get; set; }

        [MaxLength(50), Column("Translate")]
        public string Translate { get; set; }
    }
}