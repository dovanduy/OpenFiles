﻿using Newtonsoft.Json;
using Satrabel.OpenContent.Components.JPList;
using System;
using System.Collections.Generic;
using System.Web;

namespace Satrabel.OpenFiles.Components.JPList
{
    public class RequestDTO
    {
        public string statuses { get; set; }

        public string folder { get; set; }
        public bool withSubFolder { get; set; }
        public string imageRatio { get; set; }

        public List<StatusDTO> StatusLst
        {
            get
            {
                var lst = new List<StatusDTO>();
                if (!String.IsNullOrEmpty(statuses))
                {
                    lst = JsonConvert.DeserializeObject<List<StatusDTO>>(HttpUtility.UrlDecode(statuses));
                    if (lst != null)
                    {

                    }
                }
                return lst;
            }
        }

    }
}
