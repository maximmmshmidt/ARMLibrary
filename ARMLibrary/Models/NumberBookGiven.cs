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
    
    public partial class NumberBookGiven
    {
        public int IdBookGiven { get; set; }
        public int AccountingBook { get; set; }
        public int idUser { get; set; }
        public System.DateTime DateIssue { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public bool ReturnedBook { get; set; }
        public bool BuyBook { get; set; }
        public int idBook { get; set; }
    
        public virtual AccountingBook AccountingBook1 { get; set; }
        public virtual User User { get; set; }
    }
}
