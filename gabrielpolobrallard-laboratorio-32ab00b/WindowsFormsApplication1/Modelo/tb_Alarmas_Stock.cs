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
    
    public partial class tb_Alarmas_Stock
    {
        public tb_Alarmas_Stock()
        {
            this.tb_Insumos = new HashSet<tb_Insumos>();
        }
    
        public int id_alarma { get; set; }
        public Nullable<int> estado { get; set; }
        public string detalle { get; set; }
    
        public virtual ICollection<tb_Insumos> tb_Insumos { get; set; }
    }
}
