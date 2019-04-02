//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresas()
        {
            this.Compras = new HashSet<Compras>();
            this.Productos_Empresas = new HashSet<Productos_Empresas>();
            this.Usuarios = new HashSet<Usuarios>();
        }
    
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Moneda { get; set; }
        public Nullable<int> ZonaHoraria_Id { get; set; }
        public string Logo { get; set; }
        public string Direccion { get; set; }
        public int Tipo_Id { get; set; }
    
        public virtual Catalogos Catalogos { get; set; }
        public virtual Catalogos Catalogos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras> Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Empresas> Productos_Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
