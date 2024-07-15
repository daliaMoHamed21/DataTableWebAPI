using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableWebAPI.Models
{
    public class DataTable
    {
        public string Title { get; set; }
        public List<DataItem> Items { get; set; }
    }
}