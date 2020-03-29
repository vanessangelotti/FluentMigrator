using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCFluentMigrator
{
    [Migration(20200329143900)]
    public class AlterLogTableAddFullName: Migration
    {
        public override void Up()
        {
            Alter.Table("Log")
                .AddColumn("FullName").AsString(100);
        }

        public override void Down()
        {
           Delete.Column("FullName").FromTable("Log");
        }
    }
}
