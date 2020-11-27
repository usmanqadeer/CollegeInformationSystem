using System;
using System.Collections;
using System.Collections.Generic;

public class StudentProgramController
{
    static StudentProgram objStudentProgram = new StudentProgram();
    public static List<StudentProgram> StudentProgramSelectAll()
    {
        return objStudentProgram.StudentProgramSelectAll();
    }

    public static StudentProgram StudentProgramSelectByID(Int32 intProgramID)
    {
        return objStudentProgram.StudentProgramSelectByID(intProgramID);
    }

    public static Int64 InsertUpdateStudentProgram(StudentProgram objIUStudentProgram)
    {
        Int64 new_id = objIUStudentProgram.InsertUpdateStudentProgram();
        return new_id;
    }

    public static void DeleteStudentProgram(Int32 intProgramID = 0)
    {
        objStudentProgram.DeleteStudentProgram(intProgramID);
    }

    public static void Truncate()
    {
        objStudentProgram.Truncate();
    }
    public static List<StudentProgram> StudentProgramSelectByDegreeID(Int64 degree_id)
    {
        List<StudentProgram> student_programs = StudentProgramController.StudentProgramSelectAll();
        List<StudentProgram> selected_programs = new List<StudentProgram>();

        foreach (StudentProgram program in student_programs)
            if (program.DegreeID == degree_id)
                selected_programs.Add(program);

        return selected_programs;
    }

}