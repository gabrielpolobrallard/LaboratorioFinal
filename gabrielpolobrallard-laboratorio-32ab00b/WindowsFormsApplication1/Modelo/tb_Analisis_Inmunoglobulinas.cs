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
    
    public partial class tb_Analisis_Inmunoglobulinas
    {
        public tb_Analisis_Inmunoglobulinas()
        {
            this.tb_Analisis = new HashSet<tb_Analisis>();
        }
    
        public int id_inmunoglobulinas { get; set; }
        public Nullable<decimal> globulina_gamma_g { get; set; }
        public Nullable<decimal> globulina_gamma_a { get; set; }
        public Nullable<decimal> globulina_gamma_m { get; set; }
        public Nullable<decimal> globulina_gamma_d { get; set; }
        public Nullable<decimal> globulina_gamma_e { get; set; }
        public Nullable<int> estado_id { get; set; }
        public Nullable<int> analisis_id { get; set; }
    
        public virtual ICollection<tb_Analisis> tb_Analisis { get; set; }
        public virtual tb_Estado_Analisis tb_Estado_Analisis { get; set; }
    }
}
