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
    
    public partial class tb_Factura
    {
        public tb_Factura()
        {
            this.tb_Factura_x_Analisis = new HashSet<tb_Factura_x_Analisis>();
        }
    
        public int id_factura { get; set; }
        public Nullable<int> tipo { get; set; }
        public Nullable<int> paciente_id { get; set; }
        public Nullable<decimal> subtotal { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> iva_id { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual tb_IVA tb_IVA { get; set; }
        public virtual tb_Pacientes tb_Pacientes { get; set; }
        public virtual ICollection<tb_Factura_x_Analisis> tb_Factura_x_Analisis { get; set; }
    }
}
