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
    
    public partial class tb_Factura_x_Analisis
    {
        public int id_factura_x_paciente { get; set; }
        public Nullable<int> factura_id { get; set; }
        public Nullable<int> analisis_id { get; set; }
    
        public virtual tb_Factura tb_Factura { get; set; }
    }
}
