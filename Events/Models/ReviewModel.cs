using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Models
{
    public class ReviewModel
    {
        [ForeignKey("City")]
        public int UserID { get; set; }

        public DateTime ReviewDate { get; set; }

        [ForeignKey("CityID")]
        public int EventID { get; set; }

        public int Grade { get; set; }

        public string Text { get; set; }
    }
}
