﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KanjiJishyo1Entities : DbContext
    {
        public KanjiJishyo1Entities()
            : base("name=KanjiJishyo1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Examples> Examples { get; set; }
        public virtual DbSet<Kanji> Kanji { get; set; }
        public virtual DbSet<KanjiRating> KanjiRating { get; set; }
        public virtual DbSet<KanjiReadings> KanjiReadings { get; set; }
        public virtual DbSet<Words> Words { get; set; }
    
        public virtual ObjectResult<PopularityKanji_Result> PopularityKanji()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PopularityKanji_Result>("PopularityKanji");
        }
    
        public virtual ObjectResult<SchoolKanji_Result> SchoolKanji()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SchoolKanji_Result>("SchoolKanji");
        }
    
        public virtual ObjectResult<JLPTKanji_Result> JLPTKanji()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JLPTKanji_Result>("JLPTKanji");
        }
    
        public virtual ObjectResult<KanjiSearch_Result> KanjiSearch(string kanjiOrReadings, Nullable<int> kanjiStrokes)
        {
            var kanjiOrReadingsParameter = kanjiOrReadings != null ?
                new ObjectParameter("KanjiOrReadings", kanjiOrReadings) :
                new ObjectParameter("KanjiOrReadings", typeof(string));
    
            var kanjiStrokesParameter = kanjiStrokes.HasValue ?
                new ObjectParameter("KanjiStrokes", kanjiStrokes) :
                new ObjectParameter("KanjiStrokes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KanjiSearch_Result>("KanjiSearch", kanjiOrReadingsParameter, kanjiStrokesParameter);
        }
    
        public virtual ObjectResult<JLPTKanji_Result> JLPTKanji_List()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<JLPTKanji_Result>("JLPTKanji_List");
        }
    
        public virtual ObjectResult<KanjiSearch_Result> KanjiSearch_List(string kanjiOrReadings, Nullable<int> kanjiStrokes)
        {
            var kanjiOrReadingsParameter = kanjiOrReadings != null ?
                new ObjectParameter("KanjiOrReadings", kanjiOrReadings) :
                new ObjectParameter("KanjiOrReadings", typeof(string));
    
            var kanjiStrokesParameter = kanjiStrokes.HasValue ?
                new ObjectParameter("KanjiStrokes", kanjiStrokes) :
                new ObjectParameter("KanjiStrokes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KanjiSearch_Result>("KanjiSearch_List", kanjiOrReadingsParameter, kanjiStrokesParameter);
        }
    }
}
