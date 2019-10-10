using System;

namespace studentexercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 4, or more, exercises.
            
            Exercise chickenMonkey = new Exercise() {
                exercisename = "Chicken Monkey", exerciselanguage = "JavaScript"
            };

            Exercise styleMaster = new Exercise() {
                exercisename = "Style Master", exerciselanguage = "CSS"
            };

            Exercise nutshell = new Exercise() {
                exercisename = "Nutshell", exerciselanguage = "React"
            };

            Exercise urbanPlanner = new Exercise() {
                exercisename = "Urban Planner", exerciselanguage = "C#"
            };
            
            //Create 3, or more, cohorts.
            
            Cohort cohort34 = new Cohort() {
                cohortname = "Cohort 34"
            };

            Cohort cohort35 = new Cohort() {
                cohortname = "Cohort 35"
            };

            Cohort cohort36 = new Cohort() {
                cohortname = "Cohort 36"
            };
            
            //Create 4, or more, students and assign them to one of the cohorts.
            
            Student haroon = new Student() {
                studentfirstname = "Haroon", studentlastname = "Iqbal", studentslackhandle = "haroonsiqbal", studentcohort = 34
            };
            Student ellie = new Student() {
                studentfirstname = "Ellie", studentlastname = "Ash", studentslackhandle = "elliemash", studentcohort = 34
            };
            Student nate = new Student() {
                studentfirstname = "Nate", studentlastname = "Smith", studentslackhandle = "nateisgreat", studentcohort = 35
            };
            Student caroline = new Student() {
                studentfirstname = "Caroline", studentlastname = "Jones", studentslackhandle = "sweetcaroline", studentcohort = 36
            };

            cohort34.cohortstudentlist.Add(haroon);
            cohort34.cohortstudentlist.Add(ellie);
            cohort35.cohortstudentlist.Add(nate);
            cohort36.cohortstudentlist.Add(caroline);
            
            //Create 3, or more, instructors and assign them to one of the cohorts.
            
            Instructor andy = new Instructor() {
                instructorfirstname = "Andy", instructorlastname = "Collins", instructorslackhandle = "tgwtg", instructorspeciality = "jokes"
            };

            Instructor steve = new Instructor() {
                instructorfirstname = "Steve", instructorlastname = "Brown", instructorslackhandle = "coach", instructorspeciality = "ping pong"
            };

            Instructor bryan = new Instructor() {
                instructorfirstname = "Bryan", instructorlastname = "Niels", instructorslackhandle = "rockinbryan", instructorspeciality = "high fives"
            };

            cohort34.cohortinstructorlist.Add(andy);
            cohort35.cohortinstructorlist.Add(steve);
            cohort36.cohortinstructorlist.Add(bryan);
            
            
            //Have each instructor assign 2 exercises to each of the students.

            andy.AssignExerciseStudent(nutshell, haroon);
            andy.AssignExerciseStudent(urbanPlanner, haroon);
            andy.AssignExerciseStudent(nutshell, ellie);
            andy.AssignExerciseStudent(urbanPlanner, ellie);
            steve.AssignExerciseStudent(styleMaster, nate);
            steve.AssignExerciseStudent(nutshell, nate);
            bryan.AssignExerciseStudent(chickenMonkey, caroline);
            bryan.AssignExerciseStudent(styleMaster, caroline);

            //Figure out if any of this worked
            
            foreach (Student student in cohort34.cohortstudentlist)
            {
                Console.WriteLine($"{student.studentfirstname} {student.studentlastname} is a student in cohort {student.studentcohort}");
            }

            foreach (Exercise exercise in haroon.studentexerciselist)
            {
                Console.WriteLine($"Working on exercise called {exercise.exercisename} in the language {exercise.exerciselanguage}");
            }

            foreach (Instructor instructor in cohort34.cohortinstructorlist)
            {
                Console.WriteLine($"{instructor.instructorfirstname} {instructor.instructorlastname} is an instructor in {cohort34.cohortname}");
            }

        }
    }
}
