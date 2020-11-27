using System;
using System.Collections.Generic;

public class StudentPersonalInfoController
{
    static StudentPersonalInfo objStudentPersonalInfo = new StudentPersonalInfo();
    public static List<StudentPersonalInfo> StudentPersonalInfoSelectAll()
    {
        return objStudentPersonalInfo.StudentPersonalInfoSelectAll();
    }

    public static StudentPersonalInfo StudentPersonalInfoSelectByID(Int32 intStudentID)
    {
        return objStudentPersonalInfo.StudentPersonalInfoSelectByID(intStudentID);
    }

    public static Int64 InsertUpdateStudentPersonalInfo(StudentPersonalInfo objIUStudentPersonalInfo)
    {
        Int64 new_id = objIUStudentPersonalInfo.InsertUpdateStudentPersonalInfo();
        return new_id;
    }

    public static void DeleteStudentPersonalInfo(Int32 intStudentID = 0)
    {
        objStudentPersonalInfo.DeleteStudentPersonalInfo(intStudentID);
    }

    public static void Truncate()
    {
        objStudentPersonalInfo.Truncate();
    }
}