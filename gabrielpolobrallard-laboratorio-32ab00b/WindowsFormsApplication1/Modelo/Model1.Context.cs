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
    using System.Data.Entity;
    
    public partial class LabDBEntities : DbContext
    {
        public LabDBEntities()
            : base("name=LabDBEntities")
        {
        }
    
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Pedido_Detalle> Pedido_Detalle { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Stock_Detalle> Stock_Detalle { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<tb_Alarmas_Stock> tb_Alarmas_Stock { get; set; }
        public DbSet<tb_Analisis> tb_Analisis { get; set; }
        public DbSet<tb_Analisis_Examen_MateriaFecal> tb_Analisis_Examen_MateriaFecal { get; set; }
        public DbSet<tb_Analisis_Hemograma> tb_Analisis_Hemograma { get; set; }
        public DbSet<tb_Analisis_Hemostacia_Coagulacion> tb_Analisis_Hemostacia_Coagulacion { get; set; }
        public DbSet<tb_Analisis_Hepatograma> tb_Analisis_Hepatograma { get; set; }
        public DbSet<tb_Analisis_Hormonas> tb_Analisis_Hormonas { get; set; }
        public DbSet<tb_Analisis_Inmunoglobulinas> tb_Analisis_Inmunoglobulinas { get; set; }
        public DbSet<tb_Analisis_Inmunologia> tb_Analisis_Inmunologia { get; set; }
        public DbSet<tb_Analisis_LipidoGrama_Electroforetico> tb_Analisis_LipidoGrama_Electroforetico { get; set; }
        public DbSet<tb_Analisis_Microbiologico> tb_Analisis_Microbiologico { get; set; }
        public DbSet<tb_Analisis_Orina_Complementarios> tb_Analisis_Orina_Complementarios { get; set; }
        public DbSet<tb_Analisis_Orina_Completa> tb_Analisis_Orina_Completa { get; set; }
        public DbSet<tb_Analisis_Orina_Examen_Fisico_Quimico> tb_Analisis_Orina_Examen_Fisico_Quimico { get; set; }
        public DbSet<tb_Analisis_Orina_Examen_Sedimento> tb_Analisis_Orina_Examen_Sedimento { get; set; }
        public DbSet<tb_Analisis_Proteinograma_Electroforetico> tb_Analisis_Proteinograma_Electroforetico { get; set; }
        public DbSet<tb_Analisis_Quimica_Hematica> tb_Analisis_Quimica_Hematica { get; set; }
        public DbSet<tb_Barrio> tb_Barrio { get; set; }
        public DbSet<tb_Compra_Detalle> tb_Compra_Detalle { get; set; }
        public DbSet<tb_Compras> tb_Compras { get; set; }
        public DbSet<tb_Contacto_ObraSocial> tb_Contacto_ObraSocial { get; set; }
        public DbSet<tb_Diagnosticos> tb_Diagnosticos { get; set; }
        public DbSet<tb_Direccion_x_Medico> tb_Direccion_x_Medico { get; set; }
        public DbSet<tb_Direccion_x_ObraSocial> tb_Direccion_x_ObraSocial { get; set; }
        public DbSet<tb_Direcciones_x_Donante> tb_Direcciones_x_Donante { get; set; }
        public DbSet<tb_DireccionObraSocial> tb_DireccionObraSocial { get; set; }
        public DbSet<tb_DireccionTodos> tb_DireccionTodos { get; set; }
        public DbSet<tb_Donantes> tb_Donantes { get; set; }
        public DbSet<tb_Email_x_donante> tb_Email_x_donante { get; set; }
        public DbSet<tb_EmailsTodos> tb_EmailsTodos { get; set; }
        public DbSet<tb_Estado_Analisis> tb_Estado_Analisis { get; set; }
        public DbSet<tb_Factura> tb_Factura { get; set; }
        public DbSet<tb_Factura_x_Analisis> tb_Factura_x_Analisis { get; set; }
        public DbSet<tb_GrupoSanguineo> tb_GrupoSanguineo { get; set; }
        public DbSet<tb_InformeStock> tb_InformeStock { get; set; }
        public DbSet<tb_Insumo_Marca> tb_Insumo_Marca { get; set; }
        public DbSet<tb_Insumos> tb_Insumos { get; set; }
        public DbSet<tb_IVA> tb_IVA { get; set; }
        public DbSet<tb_Medico_Tipo> tb_Medico_Tipo { get; set; }
        public DbSet<tb_Medicos> tb_Medicos { get; set; }
        public DbSet<tb_Medida_Insumo> tb_Medida_Insumo { get; set; }
        public DbSet<tb_Muestras> tb_Muestras { get; set; }
        public DbSet<tb_Muestras_Tipo> tb_Muestras_Tipo { get; set; }
        public DbSet<tb_NotaPedido> tb_NotaPedido { get; set; }
        public DbSet<tb_ObraSocial> tb_ObraSocial { get; set; }
        public DbSet<tb_Pacientes> tb_Pacientes { get; set; }
        public DbSet<tb_Sexo> tb_Sexo { get; set; }
        public DbSet<tb_Telefono_x_Donante> tb_Telefono_x_Donante { get; set; }
        public DbSet<tb_Telefonos_x_ObraSocial> tb_Telefonos_x_ObraSocial { get; set; }
        public DbSet<tb_TelefonosTodos> tb_TelefonosTodos { get; set; }
        public DbSet<tb_Tipo_Insumo> tb_Tipo_Insumo { get; set; }
        public DbSet<tb_Usuarios> tb_Usuarios { get; set; }
        public DbSet<Tipo_Pago> Tipo_Pago { get; set; }
        public DbSet<tb_Analisis_Enzimologia> tb_Analisis_Enzimologia { get; set; }
    }
}
