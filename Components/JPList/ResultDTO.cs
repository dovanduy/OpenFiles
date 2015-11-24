﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Satrabel.OpenDocument.Components.JPList
{
    class ResultDTO<TResultDTO>
    {
        public IEnumerable<TResultDTO> data { get; set; }

        public int count { get; set; }
    }
}
