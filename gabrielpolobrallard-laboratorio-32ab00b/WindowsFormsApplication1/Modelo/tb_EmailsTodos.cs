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
    
    public partial class tb_EmailsTodos
    {
        public tb_EmailsTodos()
        {
            this.tb_Donantes = new HashSet<tb_Donantes>();
            this.tb_Pacientes = new HashSet<tb_Pacientes>();
        }
    
        // Primitive properties
    
        public int id_email { get; set; }
        public Nullable<int> borrado { get; set; }
        public string email { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<tb_Donantes> tb_Donantes { get; set; }
        public virtual ICollection<tb_Pacientes> tb_Pacientes { get; set; }
    
    }
}
