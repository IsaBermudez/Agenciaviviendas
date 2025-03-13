//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_AgenciaViviendas.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class VIVienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VIVienda()
        {
            this.VENtas = new HashSet<VENta>();
        }
    
        public int Id { get; set; }
        public int NumCuartos { get; set; }
        public int NumBaños { get; set; }
        public decimal Tamaño { get; set; }
        public int NumPisos { get; set; }
        public string Accesorios { get; set; }
        public decimal Valor { get; set; }
        public int TipoViviendaId { get; set; }
        [JsonIgnore]

        public virtual TIPoVivienda TIPoVivienda { get; set; }
        [JsonIgnore]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENta> VENtas { get; set; }
    }
}
