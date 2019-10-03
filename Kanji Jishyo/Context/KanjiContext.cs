using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Kanji_Jishyo.Models;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Kanji_Jishyo.Context
{
    public class KanjiContext : DbContext
    {
        public KanjiContext() : base("name=KanjiContext")
        {
            //Database.SetInitializer<KanjiContext>(null);
            Database.SetInitializer(new KanjiVocabluaryInitializer());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        
        public DbSet<Kanji> _Kanji { get; set; }
        public DbSet<Examples> _Examples { get; set; }
        public DbSet<KanjiRating> _Ratings { get; set; }
        public DbSet<KanjiReadings> _Readings { get; set; }
        public DbSet<Words> _Words { get; set; }

        /*public ObjectResult<PopularityKanji> PopularityKanji_List()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PopularityKanji>("PopularityKanji");
        }

        public virtual ObjectResult<SchoolKanji> SchoolKanji_List()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SchoolKanji>("SchoolKanji");
        }*/

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kanji>().ToTable("Kanji");
            modelBuilder.Entity<Examples>().ToTable("Examples");
            modelBuilder.Entity<KanjiReadings>().ToTable("KanjiReadings");
            modelBuilder.Entity<KanjiRating>().ToTable("KanjiRating");
            modelBuilder.Entity<Words>().ToTable("Words");
        }*/
    }
    public class KanjiVocabluaryInitializer : DropCreateDatabaseIfModelChanges<KanjiContext>
    {
    }
}