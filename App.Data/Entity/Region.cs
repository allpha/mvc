namespace App.Data.Entity
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    public class Region
    {
        public Region()
        {

        }

        public int Id { get; set; }
        [Display(Name="დასახელება")]
        public string Name { get; set;}

        public virtual ICollection<Landfill> Landfills { get; set; }
    }
}
