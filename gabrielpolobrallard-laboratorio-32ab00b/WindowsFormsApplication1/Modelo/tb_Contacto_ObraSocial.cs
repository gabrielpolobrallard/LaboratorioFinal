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
    
    public partial class tb_Contacto_ObraSocial
    {
        public int id_contacto { get; set; }
        public int obra_social_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string celular { get; set; }
    
        public virtual tb_ObraSocial tb_ObraSocial { get; set; }
    }
}