//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class LICHTAP
    {
        public int MATHETAP { get; set; }
        public string THUHAI { get; set; }
        public string THUBA { get; set; }
        public string THUTU { get; set; }
        public string THUNAM { get; set; }
        public string THUSAU { get; set; }
        public string THUBAY { get; set; }
        public string CHUNHAT { get; set; }
        public bool XOA { get; set; }
    
        public virtual THETAP THETAP { get; set; }
    }
}
