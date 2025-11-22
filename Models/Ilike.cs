using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeMvc.Models
{
    public class Ilike
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        [ForeignKey(nameof(ResumeId))] public Resume Resume { get; set; }

        public string Favorite_Food { get; set; }
        public string Favorite_Color { get; set; }
        public string Favorite_Drinks { get; set; }
        public string Favorite_Movie { get; set; }
    }
}
