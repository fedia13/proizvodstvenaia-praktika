
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Praktika
{

using System;
    using System.Collections.Generic;
    
public partial class ServiceCenter
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ServiceCenter()
    {

        this.ClientService = new HashSet<ClientService>();

    }


    public int ID { get; set; }

    public string Title { get; set; }

    public decimal Cost { get; set; }

    public string DurationInSeconds { get; set; }

    public string Description { get; set; }

    public Nullable<double> Discount { get; set; }

    public Nullable<int> MainImagePath { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ClientService> ClientService { get; set; }

    public virtual Photo Photo { get; set; }

}

}