//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReCheck.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Mensaje = new HashSet<Mensaje>();
            this.Mensaje1 = new HashSet<Mensaje>();
        }
    
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public string Imagen { get; set; }
        public int IDStatus { get; set; }
        public int IDEmpresa { get; set; }
    
        public virtual Cat_Status Cat_Status { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual ICollection<Mensaje> Mensaje { get; set; }
        public virtual ICollection<Mensaje> Mensaje1 { get; set; }
    }
}