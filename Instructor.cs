namespace studentexercises {
    public class Instructor {
        public string instructorfirstname {get; set;}
        public string instructorlastname {get; set;}
        public string instructorslackhandle {get; set;}
        public string instructorspeciality {get; set;}
        public void AssignExerciseStudent(Exercise exercise, Student student) {
            student.studentexerciselist.Add(exercise);
        }
    }
}