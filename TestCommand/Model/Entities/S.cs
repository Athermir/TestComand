//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestCommand.Model.Entities
{
    using DataAnnotationsExtensions;
    using System;
    using System.Collections.Generic;
    
    public partial class S
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S()
        {
            this.STD = new HashSet<STD>();
        }
    
        public string Snum { get; set; }
        public string Sname { get; set; }
        public Nullable<int> Status { get; set; }
        public string City { get; set; }
        [Email]
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STD> STD { get; set; }
    }
}
