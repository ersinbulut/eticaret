﻿using Eticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eticaret.Entity
{
    public class Product
    {
        //public Product()
        //{
        //    this.Comments = new HashSet<Comments>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }//marka
        public string Pattern { get; set; }//model
        public string Releasedon { get; set; }//çıkış tarihi
        public string Features { get; set; }//özellikler
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }//ürün anasayfada mı?
        public bool IsApproved { get; set; }//onaylı bir ürün mü?
        public bool IsFeatured { get; set; }//öne çıkan ürünler
        public int CategoryId { get; set; }//bir ürünün bir kategorisi vardır bir kategorinin birden fazla ürünü olabilir.
        public int ParentId { get; internal set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

       


    }
}