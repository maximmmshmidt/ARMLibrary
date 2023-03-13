//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARMLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.AccountingBook = new HashSet<AccountingBook>();
        }
    
        public int idBook { get; set; }
        public string NameBook { get; set; }
        public int idGenre { get; set; }
        public int idAuthor { get; set; }
        public string PublishingHouse { get; set; }
        public string PlacePublication { get; set; }
        public string YearPublication { get; set; }
        public int NumberPages { get; set; }
        public int ISBN { get; set; }
        public int BBK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingBook> AccountingBook { get; set; }
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
}