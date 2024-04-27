namespace VovaPractics.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenuHours
    {
        public int ID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
