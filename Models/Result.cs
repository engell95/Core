using System;
using Core.Models;
using System.Collections.Generic;

namespace Core.Models{
    public class Result{
        public int count{get;set;}
        public string next {get;set;}
        public string previous {get;set;}
        public List<NamedAPIResource> results {get;set;}
    }
}