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
    
    public partial class tb_TelefonosTodos
    {
        public tb_TelefonosTodos()
        {
            this.tb_Telefonos_x_ObraSocial = new HashSet<tb_Telefonos_x_ObraSocial>();
            this.tb_Pacientes = new HashSet<tb_Pacientes>();
            this.tb_Donantes = new HashSet<tb_Donantes>();
        }
    
        // Primitive properties
    
        public int id_telefono { get; set; }
        public string telefono { get; set; }
        public string descripcion { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<tb_Telefonos_x_ObraSocial> tb_Telefonos_x_ObraSocial { get; set; }
        public virtual ICollection<tb_Pacientes> tb_Pacientes { get; set; }
        public virtual ICollection<tb_Donantes> tb_Donantes { get; set; }
    
    }
}
