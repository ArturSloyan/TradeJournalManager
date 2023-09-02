using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeJournalManager.Domain.Models
{
    public class Trade : BaseModel
    {
        [Required]
        public bool Strategy { get; set; }
        [Required]
        [MaxLength(20)]
        public string NameOfIndicator { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string NameOfCertificate { get; set; } = string.Empty;
        [Required]
        public double Buy { get; set; }
        [Required]
        [MaxLength(400)]
        public string ThinkProzess { get; set; } = string.Empty;
        [Required]
        public long DateOfTrade { get; set; }

        public double Sell { get; set; }

        [NotMapped]
        public double Rendite { get { return Math.Round(((Sell - Buy) * 100 / Buy), 2); } }
        [NotMapped]
        public string RenditeView { get { return $"{Rendite} %"; } }
        [NotMapped]
        public string StrategyName { get { return Strategy == true ? nameof(StrategyEnum.LONG) : nameof(StrategyEnum.SHORT); } }
        [NotMapped]
        public DateTime Date { get { return DateTimeOffset.FromUnixTimeSeconds(DateOfTrade).DateTime; } }
    }
}
