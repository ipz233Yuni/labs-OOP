using System;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        public int znoScores {  get; set; }
        public int educationScores { get; set; }
        public string nameOfSchool { get; set; }    

        public Entrant() 
        {

        }

        public Entrant(string FirstName, string LastName, DateTime dateOfBirth, int ZnoScores, int EducationScore, string NameOfSchool)
            : base(FirstName, LastName, dateOfBirth)
        {
            znoScores = ZnoScores;
            educationScores = EducationScore;
            nameOfSchool = NameOfSchool;
        }

        public Entrant(Entrant other) : base(other) 
        {
            znoScores = other.znoScores;
            educationScores = other.educationScores;
            nameOfSchool = other.nameOfSchool;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Бали ЗНО: {znoScores}");
            Console.WriteLine($"Бали документу за освіту: {educationScores}");
            Console.WriteLine($"Назва школи: {nameOfSchool}");
        }
    }
}
