using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace starWars54.Models
{
    public class HomeVM
    {
        public Character Character { get; set; }
        public string Quote { get; set; }
        public List<Character> CharList { get; set; }
    }
}