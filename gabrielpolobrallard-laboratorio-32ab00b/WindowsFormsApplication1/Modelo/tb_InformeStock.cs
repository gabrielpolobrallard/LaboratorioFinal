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
    
    public partial class tb_InformeStock
    {
        public tb_InformeStock()
        {
            this.tb_NotaPedido = new HashSet<tb_NotaPedido>();
            this.tb_Insumos = new HashSet<tb_Insumos>();
        }
    
        public int id_infome_stock { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string detalles { get; set; }
        public Nullable<int> responsable_id { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tb_Usuarios tb_Usuarios { get; set; }
        public virtual ICollection<tb_NotaPedido> tb_NotaPedido { get; set; }
        public virtual ICollection<tb_Insumos> tb_Insumos { get; set; }
    }
}
