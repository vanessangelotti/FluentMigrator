using FluentMigrator;

namespace POCFluentMigrator
{
    [Migration(20200329140000)]
    public class AlterLogTableAddNumber : Migration
    {
        public override void Up()
        {
            Alter.Table("Log")
                .AddColumn("Number").AsInt32();
        }

        public override void Down()
        {
            Delete.Column("Number").FromTable("Log");
        }
    }
}
