using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradeJournalManager.Domain.Models
{
    public class Trade : BaseModel
    {
        [Required]
        [MaxLength(20)]
        public string NameOfIndicator { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string NameOfCertificate { get; set; } = string.Empty;
        [Required]
        [Range(1, double.MaxValue)]
        public double Buy { get; set; }
        [Required]
        [MaxLength(400)]
        public string ThinkProcess { get; set; } = string.Empty;
        [Range(0, double.MaxValue)]
        public double Sell { get; set; }

        [NotMapped]
        public string Rendite { get { return Sell == 0 ? "- %" : $"{Math.Round(((Sell - Buy) * 100 / Buy), 2)} %"; } }


        [Required]
        public bool Strategy { get; set; }
        [NotMapped]
        public string StrategyName { get { return Strategy == true ? nameof(StrategyEnum.LONG) : nameof(StrategyEnum.SHORT); } }


        [Required]
        [Range(1577863276, long.MaxValue)]
        public long DateOfTrade { get; set; }
        [NotMapped]
        public DateTime Date { get { return DateTimeOffset.FromUnixTimeSeconds(DateOfTrade).DateTime; } }
    }
}
