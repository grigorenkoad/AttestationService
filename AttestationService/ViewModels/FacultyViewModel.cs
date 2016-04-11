using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttestationService.ViewModels
{
    public class FacultyViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public byte[] Logo{ get; set; }   

        public FacultyViewModel(string name, string desc)
        {
            Name = name;
            Description = desc;
        }    
    }
}