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
    
    public partial class tb_Medida_Insumo
    {
        public tb_Medida_Insumo()
        {
            this.tb_Insumos = new HashSet<tb_Insumos>();
        }
    
        public int id_medida { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<tb_Insumos> tb_Insumos { get; set; }
    }
}