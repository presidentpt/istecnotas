//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace istecnotas
{
    using System;
    using System.Collections.Generic;
    
    public partial class aluno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aluno()
        {
            this.notas = new HashSet<nota>();
        }
    
        public int num { get; set; }
        public string nome { get; set; }
        public string curso { get; set; }
        public Nullable<System.DateTime> datanasc { get; set; }
        public Nullable<int> idade { get; set; }
        public byte[] fotobin { get; set; }
        public string fotopath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nota> notas { get; set; }
    }
}
