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
    
    public partial class Pedido_Detalle
    {
        // Primitive properties
    
        public int id_notapedido_detalle { get; set; }
        public Nullable<int> insumo_id { get; set; }
        public Nullable<int> pedido_id { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string unidad_medida { get; set; }
        public Nullable<double> descuento { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<decimal> subtotal { get; set; }
    
        // Navigation properties
    
        public virtual tb_Insumos tb_Insumos { get; set; }
        public virtual tb_NotaPedido tb_NotaPedido { get; set; }
    
    }
}
