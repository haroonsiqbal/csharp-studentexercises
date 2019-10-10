using System;
using System.Collections.Generic;

namespace studentexercises {
public class Student {
    public Student() {
        studentexerciselist = new List<Exercise>();
    }
    public string studentfirstname {get; set;}

    public string studentlastname {get; set;}

    public string studentslackhandle {get; set;}
    public int studentcohort {get; set;}
    public List<Exercise> studentexerciselist {get; set;}
    public void Print() {
        Console.WriteLine(studentfirstname);
    }
}

}