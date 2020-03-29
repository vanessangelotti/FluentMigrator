using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCFluentMigrator
{
    [Migration(20200329143000)]
    public class AlterLogTableAddBithDate: Migration
    {
        public override void Up()
        {
            Alter.Table("Log")
                .AddColumn("BithDate").AsDate();
        }

        public override void Down()
        {
            Delete.Column("BithDate").FromTable("Log");
        }
    }
}
