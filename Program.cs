using System;
using System.Collections.Generic;
using System.Linq;

namespace studentexercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 4, or more, exercises.

            Exercise chickenMonkey = new Exercise()
            {
                exercisename = "Chicken Monkey",
                exerciselanguage = "JavaScript"
            };

            Exercise styleMaster = new Exercise()
            {
                exercisename = "Style Master",
                exerciselanguage = "CSS"
            };

            Exercise nutshell = new Exercise()
            {
                exercisename = "Nutshell",
                exerciselanguage = "React"
            };

            Exercise urbanPlanner = new Exercise()
            {
                exercisename = "Urban Planner",
                exerciselanguage = "C#"
            };

            //Create 3, or more, cohorts.

            Cohort cohort34 = new Cohort()
            {
                cohortname = "Cohort 34"
            };

            Cohort cohort35 = new Cohort()
            {
                cohortname = "Cohort 35"
            };

            Cohort cohort36 = new Cohort()
            {
                cohortname = "Cohort 36"
            };

            //Create 4, or more, students and assign them to one of the cohorts.

            Student haroon = new Student()
            {
                studentfirstname = "Haroon",
                studentlastname = "Iqbal",
                studentslackhandle = "haroonsiqbal",
                studentcohort = 34
            };
            Student ellie = new Student()
            {
                studentfirstname = "Ellie",
                studentlastname = "Ash",
                studentslackhandle = "elliemash",
                studentcohort = 34
            };
            Student nate = new Student()
            {
                studentfirstname = "Nate",
                studentlastname = "Smith",
                studentslackhandle = "nateisgreat",
                studentcohort = 35
            };
            Student caroline = new Student()
            {
                studentfirstname = "Caroline",
                studentlastname = "Jones",
                studentslackhandle = "sweetcaroline",
                studentcohort = 36
            };
            Student barry = new Student() {
                studentfirstname = "Barry",
                studentlastname = "Sanders",
                studentslackhandle = "barrychristmas",
                studentcohort = 36
            };

            cohort34.cohortstudentlist.Add(haroon);
            cohort34.cohortstudentlist.Add(ellie);
            cohort35.cohortstudentlist.Add(nate);
            cohort36.cohortstudentlist.Add(caroline);

            //Create 3, or more, instructors and assign them to one of the cohorts.

            Instructor andy = new Instructor()
            {
                instructorfirstname = "Andy",
                instructorlastname = "Collins",
                instructorslackhandle = "tgwtg",
                instructorspeciality = "jokes"
            };

            Instructor steve = new Instructor()
            {
                instructorfirstname = "Steve",
                instructorlastname = "Brown",
                instructorslackhandle = "coach",
                instructorspeciality = "ping pong"
            };

            Instructor bryan = new Instructor()
            {
                instructorfirstname = "Bryan",
                instructorlastname = "Niels",
                instructorslackhandle = "rockinbryan",
                instructorspeciality = "high fives"
            };

            cohort34.cohortinstructorlist.Add(andy);
            cohort35.cohortinstructorlist.Add(steve);
            cohort36.cohortinstructorlist.Add(bryan);


            //Have each instructor assign 2 exercises to each of the students.

            andy.AssignExerciseStudent(nutshell, haroon);
            andy.AssignExerciseStudent(urbanPlanner, haroon);
            andy.AssignExerciseStudent(chickenMonkey, haroon);
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

            List<Student> students = new List<Student>() {
                haroon,
                ellie,
                nate,
                caroline,
                barry
            };

            List<Exercise> exercises = new List<Exercise>() {
                nutshell,
                urbanPlanner,
                styleMaster,
                chickenMonkey
            };

            List<Instructor> instructors = new List<Instructor>() {
                andy,
                steve,
                bryan
            };

            List<Cohort> cohorts = new List<Cohort>() {
                cohort34,
                cohort35,
                cohort36
            };

            List<Exercise> javascript = exercises.Where(exercise => exercise.exerciselanguage == "JavaScript").ToList();
            foreach (Exercise item in javascript)
            {
                Console.WriteLine(item.exercisename);
            }

            List<Cohort> co34 = cohorts.Where(co => co.cohortname == "Cohort 34").ToList();
            foreach (Cohort item in co34)
            {
                var studs = item.cohortstudentlist;
                foreach (studentexercises.Student stud in studs)
                {
                    Console.WriteLine($"{stud.studentfirstname} {stud.studentlastname}");
                }

                var insts = item.cohortinstructorlist;
                foreach (var inst in insts)
                {
                    Console.WriteLine($"{inst.instructorfirstname} {inst.instructorlastname}");
                }
            }

            List<Student> ordered = students.Where(name => name.studentlastname != "").OrderBy(name => name.studentlastname).ToList();
            foreach (var orderstud in ordered)
            {
                Console.WriteLine(orderstud.studentlastname);
            }

            List<Student> noexercise = students.Where(name => name.studentexerciselist.Count == 0).ToList();
            foreach (var person in noexercise)
            {
                Console.WriteLine($"{person.studentfirstname} {person.studentlastname}");
            }

            //within list of student, count number of exercises within studentexercises list and display the max of that number
            List<int> numbers = new List<int>();
            foreach (var item in students)
            {
                numbers.Add(item.studentexerciselist.Count());
            }
                Console.WriteLine($"Most number of exercises: {numbers.Max()}");

            //how many students in each cohort?
            List<Cohort> numbercohorts = cohorts.Where(n => n.cohortname != "").ToList();
            foreach (var item in numbercohorts)
            {
                int count = item.cohortstudentlist.Count();
                Console.WriteLine($"{item.cohortname}: {count} student(s)");
            };



        }
    }
}
