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
    
    public partial class tb_Analisis_Microbiologico
    {
        public tb_Analisis_Microbiologico()
        {
            this.tb_Analisis = new HashSet<tb_Analisis>();
        }
    
        public int id_analisis_microbiologico { get; set; }
        public string coloracion_de_graham { get; set; }
        public Nullable<decimal> ziehl_nielsen_baar { get; set; }
        public Nullable<decimal> mggp { get; set; }
        public string cultivo { get; set; }
        public string recuento_de_colonias { get; set; }
        public string antibiograma { get; set; }
        public Nullable<int> estado_id { get; set; }
        public Nullable<int> analisis_id { get; set; }
    
        public virtual ICollection<tb_Analisis> tb_Analisis { get; set; }
        public virtual tb_Estado_Analisis tb_Estado_Analisis { get; set; }
    }
}
