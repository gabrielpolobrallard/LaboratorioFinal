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
    
    public partial class tb_Sexo
    {
        public tb_Sexo()
        {
            this.tb_Pacientes = new HashSet<tb_Pacientes>();
        }
    
        public int id_sexo { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<tb_Pacientes> tb_Pacientes { get; set; }
    }
}