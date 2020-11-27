using System;
using System.Collections;
using System.Collections.Generic;

public class StudentGraduationSubjectController
{
    static StudentGraduationSubject objStudentGraduationSubject = new StudentGraduationSubject();
    public static List<StudentGraduationSubject> StudentGraduationSubjectSelectAll()
    {
        return objStudentGraduationSubject.StudentGraduationSubjectSelectAll();
    }

    public static StudentGraduationSubject StudentGraduationSubjectSelectByID(Int32 intStudentSubjectID)
    {
        return objStudentGraduationSubject.StudentGraduationSubjectSelectByID(intStudentSubjectID);
    }

    public static Int64 InsertUpdateStudentGraduationSubject(StudentGraduationSubject objIUStudentGraduationSubject)
    {
        Int64 new_id = objIUStudentGraduationSubject.InsertUpdateStudentGraduationSubject();
        return new_id;
    }

    public static void DeleteStudentGraduationSubject(Int32 intStudentSubjectID = 0)
    {
        objStudentGraduationSubject.DeleteStudentGraduationSubject(intStudentSubjectID);
    }

    public static void Truncate()
    {
        objStudentGraduationSubject.Truncate();
    }
}