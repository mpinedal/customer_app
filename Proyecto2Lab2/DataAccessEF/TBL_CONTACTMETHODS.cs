//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CONTACTMETHODS
    {
        public string OWNER_ID { get; set; }
        public string TYPE { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public string INDPUBLICIDAD { get; set; }
        public int ID { get; set; }
    
        public virtual TBL_CUSTOMERS TBL_CUSTOMERS { get; set; }
    }
}