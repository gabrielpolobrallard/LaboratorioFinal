//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Barrio
    {
        public int id_barrio { get; set; }
        public Nullable<int> localidad_id { get; set; }
        public string descripcion { get; set; }
    
        public virtual Localidad Localidad { get; set; }
    }
}
