using System;
using System.Data.Entity;

namespace org.ahren.manager.api.ef.entities
{
    class Initializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            //context.oficinaEntity.AddRange(new[]{});
        }

    }
}