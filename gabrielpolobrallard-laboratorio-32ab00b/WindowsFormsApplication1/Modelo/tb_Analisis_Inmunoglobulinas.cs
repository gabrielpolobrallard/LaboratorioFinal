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
    
    public partial class tb_Analisis_Inmunoglobulinas
    {
        public tb_Analisis_Inmunoglobulinas()
        {
            this.tb_Analisis = new HashSet<tb_Analisis>();
        }
    
        // Primitive properties
    
        public int id_inmunoglobulinas { get; set; }
        public Nullable<decimal> globulina_gamma_g { get; set; }
        public Nullable<decimal> globulina_gamma_a { get; set; }
        public Nullable<decimal> globulina_gamma_m { get; set; }
        public Nullable<decimal> globulina_gamma_d { get; set; }
        public Nullable<decimal> globulina_gamma_e { get; set; }
        public Nullable<int> estado_id { get; set; }
        public Nullable<int> analisis_id { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<tb_Analisis> tb_Analisis { get; set; }
        public virtual tb_Estado_Analisis tb_Estado_Analisis { get; set; }
    
    }
}
