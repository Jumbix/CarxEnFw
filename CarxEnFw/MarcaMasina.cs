//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarxEnFw
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarcaMasina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarcaMasina()
        {
            this.ModelMasinas = new HashSet<ModelMasina>();
        }
    
        public int Id { get; set; }
        public string NumeMarca { get; set; }
        public Nullable<int> AnulInfintarii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelMasina> ModelMasinas { get; set; }
    }
}