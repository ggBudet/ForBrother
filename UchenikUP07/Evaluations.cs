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
    
    public partial class Evaluations
    {
        public int ID_Evaluations { get; set; }
        public int ID_Teachers { get; set; }
        public int Evaluations1 { get; set; }
    
        public virtual Teachers Teachers { get; set; }
        public virtual Teachers Teachers1 { get; set; }
    }
}
