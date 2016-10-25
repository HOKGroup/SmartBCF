using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOK.SmartBCF.BCFDBWriter
{
    /// <summary>
    /// SQLite specific ConflictMode
    /// </summary>
    public enum ConflictMode
    {
        ROLLBACK, ABORT, FAIL, IGNORE, REPLACE
    }
}
