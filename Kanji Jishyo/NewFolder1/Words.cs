//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kanji_Jishyo.NewFolder1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Words
    {
        public int KanjiId { get; set; }
        public int WordId { get; set; }
        public int Kanji1Id { get; set; }
        public Nullable<int> Kanji2Id { get; set; }
        public Nullable<int> Kanji3Id { get; set; }
        public Nullable<int> Kanji4Id { get; set; }
        public string Translate { get; set; }
    
        public virtual Kanji Kanji { get; set; }
    }
}
