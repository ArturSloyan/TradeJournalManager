using System.ComponentModel.DataAnnotations;

namespace TradeJournalManager.Domain.Models
{
    public class Trade : BaseModel
    {
        [Required]
        public bool Strategy { get; set; }
        [Required]
        public string NameOfIndicator { get; set; } = string.Empty;
        [Required]
        public string NameOfCertificate { get; set; } = string.Empty;
        [Required]
        public double Buy { get; set; }
        public double Sell { get; set; }
        public double Rendite { get; set; }
        [Required]
        public string ThinkProzess { get; set; } = string.Empty;
        [Required]
        public long DateOfTrade { get; set; }
    }
}
