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
    
    public partial class tb_DireccionTodos
    {
        public tb_DireccionTodos()
        {
            this.tb_Direccion_x_Medico = new HashSet<tb_Direccion_x_Medico>();
            this.tb_Direcciones_x_Donante = new HashSet<tb_Direcciones_x_Donante>();
            this.tb_Pacientes = new HashSet<tb_Pacientes>();
        }
    
        // Primitive properties
    
        public int id_dir { get; set; }
        public string calle { get; set; }
        public Nullable<int> numero { get; set; }
        public Nullable<int> barrio { get; set; }
        public Nullable<int> localidad_id { get; set; }
        public string desc_dep { get; set; }
        public string numero_dep { get; set; }
        public Nullable<int> borrado { get; set; }
    
        // Navigation properties
    
        public virtual Localidad Localidad { get; set; }
        public virtual ICollection<tb_Direccion_x_Medico> tb_Direccion_x_Medico { get; set; }
        public virtual ICollection<tb_Direcciones_x_Donante> tb_Direcciones_x_Donante { get; set; }
        public virtual ICollection<tb_Pacientes> tb_Pacientes { get; set; }
    
    }
}
