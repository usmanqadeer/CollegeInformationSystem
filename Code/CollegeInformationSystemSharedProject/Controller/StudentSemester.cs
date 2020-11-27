using System;
using System.Collections;
using System.Collections.Generic;

public class StudentSemesterController
{
	static StudentSemester objStudentSemester = new StudentSemester();
	public static List<StudentSemester> StudentSemesterSelectAll()
	{
		return objStudentSemester.StudentSemesterSelectAll();
	}
	
	public static StudentSemester StudentSemesterSelectByID(Int32 intSemesterID)
	{
		return objStudentSemester.StudentSemesterSelectByID(intSemesterID);
	}
	
	public static Int64 InsertUpdateStudentSemester(StudentSemester objIUStudentSemester)
	{
		Int64 new_id = objIUStudentSemester.InsertUpdateStudentSemester();
		return new_id;
	}
	
	public static void DeleteStudentSemester(Int32 intSemesterID = 0)
	{
		objStudentSemester.DeleteStudentSemester(intSemesterID);
	}
	
	public static void Truncate()
	{
		objStudentSemester.Truncate();
	}
}