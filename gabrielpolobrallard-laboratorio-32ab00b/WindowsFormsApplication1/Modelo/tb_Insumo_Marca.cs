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
    
    public partial class tb_Insumo_Marca
    {
        public tb_Insumo_Marca()
        {
            this.tb_Insumos = new HashSet<tb_Insumos>();
        }
    
        // Primitive properties
    
        public int id_marca { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> borrado { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<tb_Insumos> tb_Insumos { get; set; }
    
    }
}
