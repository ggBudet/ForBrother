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
    
    public partial class Schedule
    {
        public int ID_Schedule { get; set; }
        public int ID_Subject { get; set; }
        public int ID_Teacher { get; set; }
        public int ID_Class { get; set; }
        public string Week_day { get; set; }
        public int Number_of_lesson { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual School_Subject School_Subject { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
