//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Venta
    {
        public Tipo_Venta()
        {
            this.Remito = new HashSet<Remito>();
        }
    
        // Primitive properties
    
        public int id_tipoventa { get; set; }
        public string descripcion { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<Remito> Remito { get; set; }
    
    }
}
