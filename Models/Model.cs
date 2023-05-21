
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CommercialFirm.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Model
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Model()
    {

        this.Order = new HashSet<Order>();

        this.PriceList = new HashSet<PriceList>();

    }


    public int id { get; set; }

    public string Name { get; set; }

    public string Color { get; set; }

    public int idUpholstery { get; set; }

    public string EnginePower { get; set; }

    public int idTrasmission { get; set; }

    public int idSupplier { get; set; }

    public int idFuel { get; set; }



    public virtual Fuel Fuel { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual Transmission Transmission { get; set; }

    public virtual Upholstery Upholstery { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Order> Order { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PriceList> PriceList { get; set; }

}

}
