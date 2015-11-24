﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Satrabel.OpenDocument.Components.JPList
{
    public class JpListQueryDTO
    {
        public JpListQueryDTO()
        {
            Pagination = new PaginationDTO();
            Filters = new List<FilterDTO>();
            Sorts = new List<SortDTO>();
        }
        public PaginationDTO Pagination { get; set; }

        public List<FilterDTO> Filters { get; set; }

        public List<SortDTO> Sorts { get; set; }
    }
}
