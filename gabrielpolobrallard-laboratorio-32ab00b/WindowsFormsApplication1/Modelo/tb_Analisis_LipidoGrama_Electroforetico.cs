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
    
    public partial class tb_Analisis_LipidoGrama_Electroforetico
    {
        public tb_Analisis_LipidoGrama_Electroforetico()
        {
            this.tb_Analisis = new HashSet<tb_Analisis>();
        }
    
        public int id_lipidograma_electrof { get; set; }
        public Nullable<decimal> alfa_lipoproteinas { get; set; }
        public Nullable<decimal> probeta_lipoproteinas { get; set; }
        public Nullable<decimal> beta_lipoproteinas { get; set; }
        public Nullable<decimal> quilomicrones { get; set; }
        public Nullable<int> estado_id { get; set; }
        public Nullable<int> analisis_id { get; set; }
    
        public virtual ICollection<tb_Analisis> tb_Analisis { get; set; }
        public virtual tb_Estado_Analisis tb_Estado_Analisis { get; set; }
    }
}