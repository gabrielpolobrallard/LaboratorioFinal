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
    
    public partial class tb_Analisis_Orina_Examen_Fisico_Quimico
    {
        public tb_Analisis_Orina_Examen_Fisico_Quimico()
        {
            this.tb_Analisis = new HashSet<tb_Analisis>();
        }
    
        // Primitive properties
    
        public int id_examen_fisico_quimico { get; set; }
        public string color { get; set; }
        public string aspecto { get; set; }
        public string densidad { get; set; }
        public string sed_macroscopico { get; set; }
        public string reaccion { get; set; }
        public string ph { get; set; }
        public string espuma { get; set; }
        public string proteina { get; set; }
        public string glucosa { get; set; }
        public string acetona { get; set; }
        public string pigmentos_biliares { get; set; }
        public string sales_biliares { get; set; }
        public string urobilina { get; set; }
        public string hemoglobina { get; set; }
        public Nullable<int> examen_orina_id { get; set; }
        public Nullable<int> estado_id { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<tb_Analisis> tb_Analisis { get; set; }
        public virtual tb_Analisis_Orina_Completa tb_Analisis_Orina_Completa { get; set; }
        public virtual tb_Estado_Analisis tb_Estado_Analisis { get; set; }
    
    }
}
