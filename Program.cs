using System;
namespace SelfIntroduction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("WELCOME...!!!");
            Console.WriteLine("PLEASE ENTER YOUR DETAILS TO FILL THE SELFINTRODUCTION FORM...");
            Console.ResetColor();
            string Name;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR NAME ");
                Name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Name));

            string college;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR University/College");
                college = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(college));

            string degree;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR degree ");
                degree = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(degree));

            string relevantcourse;
            do
            {
                Console.WriteLine("PLEASE MENTION YOUR RELEVANT COURSE ");
                relevantcourse = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(relevantcourse));

            string skills;
            do
            {
                Console.WriteLine("PLEASE MENTION KEY SKILLS RELEVANT ");
                skills = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(skills));

            string input;
            int month;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR EXPERIENCE IN MONTHS ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out month));

            string companyname;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR LAST COMPANY NAME");
                companyname = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(companyname));

            string experienceField;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR EXPERIENCE FIELD IN YOUR LAST COMPANY");
                experienceField = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(experienceField));
            string jobTitle;
            do
            {
                Console.WriteLine("PLEASE ENTER YOUR JOB TITLE");
                jobTitle = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(jobTitle));

            string hobbies;
            do
            {
                Console.WriteLine("PLEASE MENTION YOUR HOBBIES OR INTERESTS THAT SHOW YOUR PERSONALITY OR ARE RELEVANT TO THE JOB");
                hobbies = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(hobbies));

            string aboutcompany;
            do
            {
                Console.WriteLine("TELL SOMETHING ABOUT YOUR LAST COMPANY YOU WORKED AT");
                aboutcompany = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(aboutcompany));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello! My name is {Name.ToUpper()}, and I’m excited to be here today.\n I graduated from {college} with a degree in {degree}.");
            Console.WriteLine($"During my time there, I focused on {relevantcourse} and developed a strong foundation in {skills}.");
            Console.WriteLine($"Professionally, I have {month} months of experience in {experienceField}.\n My most recent position was at {companyname}, where I worked as a {jobTitle}.");
            Console.WriteLine($"I have a strong passion for {experienceField}, and I’m particularly skilled in {skills}.\n I pride myself on being a good problem solver.");
            Console.WriteLine($"Outside of work, I enjoy {hobbies}. These activities help me stay balanced and bring fresh perspectives to my professional life.");
            Console.WriteLine($"I’m very excited about the opportunity at {companyname} because {aboutcompany}. \nI believe my background and skills align well with the requirements of this position, and I am eager to contribute to your team.");
            Console.WriteLine("Thank you for considering my application. I’m looking forward to discussing how I can contribute to your team.");
            Console.ResetColor();
        }
    }
}
