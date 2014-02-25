﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biggy;

namespace Tests {


  public class Film {
    public int Film_ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseYear { get; set; }
    public int Length { get; set; }

    [PGFullText("fulltext")]
    public string FullText { get; set; }
  }

  public class Actor {
    public int Actor_ID { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string FullName {
      get {
        return this.First_Name + " " + this.Last_Name;
      }
    }

    public override bool Equals(object obj) {
      var p1 = (Actor)obj;
      return this.Actor_ID == p1.Actor_ID;
    }

  }

  public class Product {
    public String Sku { get; set; }
    public String Name { get; set; }
    public Decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }

    public Product() {
      this.CreatedAt = DateTime.Now;
    }

    public override bool Equals(object obj) {
      var p1 = (Product)obj;
      return this.Sku == p1.Sku;
    }

  }
}
