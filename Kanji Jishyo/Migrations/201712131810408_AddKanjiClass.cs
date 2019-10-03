namespace Kanji_Jishyo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKanjiClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Examples",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    KanjiId = c.Int(nullable: false),
                    KanjiExample = c.String(maxLength: 50),
                    ExampleTranslation = c.String(maxLength: 50),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kanji", t => t.KanjiId, cascadeDelete: true);


            CreateTable(
                "dbo.Kanji",
                c => new
                    {
                        KanjiId = c.Int(nullable: false),
                        KanjiMean = c.String(nullable: false, maxLength: 30),
                        KanjiStrokes = c.Int(nullable: false),
                        KanjiImage = c.String(nullable: false, maxLength: 1),
                        KanjiDraw = c.Binary(storeType: "image", nullable: true),
                        KanjiKey = c.String(nullable: false),
                        KanjiRatingId = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.KanjiId)
                .ForeignKey("dbo.KanjiRating", t => t.KanjiRatingId, cascadeDelete: true)
                .Index(t => t.KanjiRatingId);
            
            CreateTable(
                "dbo.KanjiRating",
                c => new
                    {
                        KanjiRatingId = c.Int(nullable: false, identity: true),
                        PopularityRating = c.Double(nullable: false),
                        JLPTRating = c.Double(nullable: false),
                        SchoolRating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.KanjiRatingId);
            
            CreateTable(
                "dbo.KanjiReadings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KanjiId = c.Int(nullable: false),
                        On = c.String(maxLength: 30),
                        Kun = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kanji", t => t.KanjiId, cascadeDelete: true)
                .Index(t => t.KanjiId);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        KanjiId = c.Int(nullable: false),
                        WordId = c.Int(nullable: false),
                        Kanji1Id = c.Int(nullable: false),
                        Kanji2Id = c.Int(nullable: true),
                        Kanji3Id = c.Int(nullable: true),
                        Kanji4Id = c.Int(nullable: true),
                        Translate = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.KanjiId)
                .ForeignKey("dbo.Kanji", t => t.KanjiId)
                .Index(t => t.KanjiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "KanjiId", "dbo.Kanji");
            DropForeignKey("dbo.KanjiReadings", "KanjiId", "dbo.Kanji");
            DropForeignKey("dbo.Kanji", "KanjiRatingId", "dbo.KanjiRating");
            DropIndex("dbo.Words", new[] { "KanjiId" });
            DropIndex("dbo.KanjiReadings", new[] { "KanjiId" });
            DropIndex("dbo.Kanji", new[] { "KanjiRatingId" });
            DropTable("dbo.Words");
            DropTable("dbo.KanjiReadings");
            DropTable("dbo.KanjiRating");
            DropTable("dbo.Kanji");
            DropTable("dbo.Examples");
        }
    }
}
