//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicatie_medicala.Data_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mod_Administarea
    {
        public Mod_Administarea()
        {
            this.Tratament = new HashSet<Tratament>();
        }
    
        public int IDMod { get; set; }
        public string Mod { get; set; }
    
        public virtual ICollection<Tratament> Tratament { get; set; }
    }
}