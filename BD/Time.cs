namespace VovaPractics.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Time")]
    public partial class Time
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column("Time", Order = 1)]
        public TimeSpan Time1 { get; set; }

        public virtual Codes Codes { get; set; }
    }
}
