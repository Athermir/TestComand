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
    using System;
    using System.Collections.Generic;
    
    public partial class D
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public D()
        {
            this.STD = new HashSet<STD>();
        }

        public D(string dnum, string dname, string city)
        {
            Dnum = dnum;
            Dname = dname;
            City = city;
        }
    
        public string Dnum { get; set; }
        public string Dname { get; set; }
        public string City { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STD> STD { get; set; }
    }
}