using System;
using System.Collections.Generic;

public class StudentSubjectController
{
    static StudentSubject objStudentSubject = new StudentSubject();
    public static List<StudentSubject> StudentSubjectSelectAll()
    {
        return objStudentSubject.StudentSubjectSelectAll();
    }

    public static StudentSubject StudentSubjectSelectByID(Int32 intSubjectID)
    {
        return objStudentSubject.StudentSubjectSelectByID(intSubjectID);
    }

    public static Int64 InsertUpdateStudentSubject(StudentSubject objIUStudentSubject)
    {
        Int64 new_id = objIUStudentSubject.InsertUpdateStudentSubject();
        return new_id;
    }

    public static void DeleteStudentSubject(Int32 intSubjectID = 0)
    {
        objStudentSubject.DeleteStudentSubject(intSubjectID);
    }

    public static void Truncate()
    {
        objStudentSubject.Truncate();
    }
}