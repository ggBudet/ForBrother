//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UchenikUP07
{
    using System;
    using System.Collections.Generic;
    
    public partial class School_Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School_Subject()
        {
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int ID_Subject { get; set; }
        public string Name { get; set; }
        public int ID_Students { get; set; }
        public int ID_Teachers { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual Students Students { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
