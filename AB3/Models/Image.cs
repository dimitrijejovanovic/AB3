using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABPort.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public bool IsCover { get; set; }
        public string Src { get; set; }
        //public Project Project { get; set; }

    }
}