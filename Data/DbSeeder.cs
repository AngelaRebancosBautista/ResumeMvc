using ResumeMvc.Models;

namespace ResumeMvc.Data
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext db)
        {
            if (db.Resumes.Any()) return;

            var r = new Resume
            {
                FullName = "Angela Rebancos Bautista",
                Title = "Student",
                Email = "angela@email.com",
                Phone = "09876543213",
                Address = "Bagumbayan Oas, Albay",
                Aboutme = "I’m a motivated and hardworking person who loves improving myself and helping others. I enjoy learning, solving problems, and staying organized in everything I do.",
                PhotoUrl = "/Image/download.jpg" // see note below
            };

            r.Ilike.Add(new Ilike
            {
                Favorite_Food = "Favorite_Food- Seafoods, Sweets, and deserts",
                Favorite_Color = "Favorite_Color- Pinik, Yellow, Blue, Black, Red, White",
                Favorite_Drinks = "Favorite_Drinks- Lipton, C2, Coke, Iced Coffee",
                Favorite_Movie = "Favorite_Movie- I have so many movies i like, like a action movies, kdrama, and hollywood movies."
            });
 

            r.Educations.Add(new Education
            {
                Institution = "St Mary's Academy",
                Year = "2016-2020"
            });
            r.Educations.Add(new Education
            {
                Institution = "Polangui General High School",
                Year = "2020-2022"
            });

            r.My_Skills.Add(new My_Skills
            {
                Time_Management = "Time_Management- I can organize my schedule effectively to balance schoolwork, projects, and extracurricular activities.",
                Communication_Skills = "Communication_Skills- I can express my ideas clearly, both in writing and verbally, and actively listen to others.",
                Problem_Solving = "Problem_Solving- I can analyze problems, think critically, and come up with effective solutions.",
                Teamwork = "Teamwork- I work well with others to achieve common goals.",
                Adaptability = "Adaptability- I can adjust to new situations or learning environments quickly.",
                Self_Motivation = "Self_Motivation- I take initiative in learning and improving without needing constant supervision.",
                Technical = "Technical- I have knowledge and skills in specific subjects or tools."
            });

            db.Resumes.Add(r);
            db.SaveChanges();
        }
    }
}
