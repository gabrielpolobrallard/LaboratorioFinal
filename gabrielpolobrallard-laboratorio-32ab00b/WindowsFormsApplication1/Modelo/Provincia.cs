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
    
    public partial class Provincia
    {
        public Provincia()
        {
            this.Departamento = new HashSet<Departamento>();
        }
    
        // Primitive properties
    
        public int ID { get; set; }
        public string Nombre { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<Departamento> Departamento { get; set; }
    
    }
}
