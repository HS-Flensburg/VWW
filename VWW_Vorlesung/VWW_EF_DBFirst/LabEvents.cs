//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VWW_EF_DBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class LabEvents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LabEvents()
        {
            this.AnwesenheitSet = new HashSet<AnwesenheitSet>();
            this.ExerciseResults = new HashSet<ExerciseResults>();
            this.Testats = new HashSet<Testats>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> LabDate { get; set; }
        public int Lab_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnwesenheitSet> AnwesenheitSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExerciseResults> ExerciseResults { get; set; }
        public virtual Labs Labs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Testats> Testats { get; set; }
    }
}
