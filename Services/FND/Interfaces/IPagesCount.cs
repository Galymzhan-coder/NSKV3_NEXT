﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FND.Interfaces
{
    public interface IPagesCount
    {
        int GetPagesCount(int rowCount, string whereCond = "");
    }
}
