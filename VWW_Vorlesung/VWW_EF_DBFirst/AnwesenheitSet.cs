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
    
    public partial class AnwesenheitSet
    {
        public int Id { get; set; }
        public int LabEventsId { get; set; }
        public int UserId { get; set; }
        public int UserId1 { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual LabEvents LabEvents { get; set; }
    }
}