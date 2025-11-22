using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeMvc.Models
{
    public class Education
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        [ForeignKey(nameof(ResumeId))] public Resume Resume { get; set; }

        public string Institution { get; set; }
        public string Year { get; set; }
    }
}
