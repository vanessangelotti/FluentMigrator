using System;
using System.Collections.Generic;
using System.Text;

namespace POCFluentMigrator
{
    public static class ContextMigration
    {

        public static System.Reflection.Assembly[] getAssemblies()
        {
            System.Reflection.Assembly[] types = {
                 typeof(AddLogTable).Assembly,
                   typeof(AlterLogTableAddNumber).Assembly,
                   typeof(AlterLogTableAddBithDate).Assembly,
                    typeof(AlterLogTableAddFullName).Assembly
            };

            return types;
        }
    }
}
