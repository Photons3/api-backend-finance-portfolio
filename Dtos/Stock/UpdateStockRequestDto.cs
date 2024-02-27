using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "10 Characters Max")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(10, ErrorMessage = "Company 10 Characters Max")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1, 10000000000000)]
        public decimal Purchase { get; set; }
        [Range(0.000000001, 10000)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Industry 10 Characters Max")]
        public string Industry { get; set; } = string.Empty;
        [Required]
        [Range(1, 10000000000000)]
        public long MarketCap { get; set; }
    }
}