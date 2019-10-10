using System.Collections.Generic;

namespace studentexercises {
    public class Cohort {
        public Cohort() {
            cohortstudentlist = new List<Student>();
            cohortinstructorlist = new List<Instructor>();
        }
        public string cohortname {get; set;}
        public List<Student> cohortstudentlist {get; set;}
        public List<Instructor> cohortinstructorlist {get; set;}
    }
}