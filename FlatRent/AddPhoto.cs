//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlatRent
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddPhoto
    {
        public int Id { get; set; }
        public int Id_Apartment { get; set; }
        public byte[] AdPhoto { get; set; }
    
        public virtual Apartment Apartment { get; set; }
    }
}
