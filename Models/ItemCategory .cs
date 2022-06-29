using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.Models {

    public class ItemCategory{

        public int Id {get;set;}

        public string name {get;set;}

        public List<NamedAPIResource> items {get;set;}

        public List<Name> names {get;set;}

        public List<NamedAPIResource> pocket {get;set;}
    }

}