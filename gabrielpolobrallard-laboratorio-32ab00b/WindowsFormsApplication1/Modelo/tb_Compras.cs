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
    
    public partial class tb_Compras
    {
        public tb_Compras()
        {
            this.tb_Compra_Detalle = new HashSet<tb_Compra_Detalle>();
        }
    
        // Primitive properties
    
        public int id_compra { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> notapedido_id { get; set; }
        public Nullable<int> pago { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<double> descuento { get; set; }
        public Nullable<int> usuario { get; set; }
        public string descripcion { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<tb_Compra_Detalle> tb_Compra_Detalle { get; set; }
        public virtual tb_NotaPedido tb_NotaPedido { get; set; }
    
    }
}
