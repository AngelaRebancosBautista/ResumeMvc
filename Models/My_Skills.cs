using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeMvc.Models
{
    public class My_Skills
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        [ForeignKey(nameof(ResumeId))] public Resume Resume { get; set; }

        public string Time_Management { get; set; }
        public string Communication_Skills { get; set; }
        public string Problem_Solving { get; set; }
        public string Teamwork { get; set; }

        public string Adaptability { get; set; }
        public string Self_Motivation { get; set; }
        public string Technical { get; set; }
        
    }
}
