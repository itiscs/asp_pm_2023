using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MVCwithEF.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Введите наименование")]
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Range(0,1000000)]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        [MaxLength(370)]
        [Display(Name = "Изображение")]
        public string Image { get; set; }

        [MaxLength(20)]
        [Display(Name = "Категория")]
        public string Category { get; set; }
    }
}
