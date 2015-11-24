﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Satrabel.OpenDocument.Components.JPList
{
    public class RequestDTO
    {
        public string statuses { get; set; }
        public string folder { get; set; }

        public List<StatusDTO> StatusLst
        {
            get
            {
                var lst = new List<StatusDTO>();
                if (!String.IsNullOrEmpty(statuses))
                {
                    lst  = JsonConvert.DeserializeObject<List<StatusDTO>>(HttpUtility.UrlDecode(statuses));
                    if (lst != null)
                    {
                        



                    }
                }
                return lst;
            }
        }

    }
}