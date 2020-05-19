﻿using System;
using VatanAPI.Controllers.Resources;

namespace VatanAPI.Resources
{
    public class SepetResource
    {
        public int SepetId { get; set; }
        //public DateTime SepeteKonulmaTarihi { get; set; }
        public int UserId { get; set; }
        public int ProductID { get; set; }
        public UserResource User { get; set; }
        public ProductResource Product { get; set; }
    }
}
