//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resort_Forest_Park.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Servicee
    {
        public int id_services { get; set; }
        public Nullable<int> id_order { get; set; }
        public Nullable<int> id_service { get; set; }
    
        public virtual orderr orderr { get; set; }
        public virtual Service Service { get; set; }
    }
}
