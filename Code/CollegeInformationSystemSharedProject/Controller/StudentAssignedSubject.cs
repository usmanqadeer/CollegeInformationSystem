using System;
using System.Collections;
using System.Collections.Generic;

public class StudentAssignedSubjectController
{
	static StudentAssignedSubject objStudentAssignedSubject = new StudentAssignedSubject();
	public static List<StudentAssignedSubject> StudentAssignedSubjectSelectAll()
	{
		return objStudentAssignedSubject.StudentAssignedSubjectSelectAll();
	}
	
	public static StudentAssignedSubject StudentAssignedSubjectSelectByID(Int32 intStudentSubjectID)
	{
		return objStudentAssignedSubject.StudentAssignedSubjectSelectByID(intStudentSubjectID);
	}
	
	public static Int64 InsertUpdateStudentAssignedSubject(StudentAssignedSubject objIUStudentAssignedSubject)
	{
		Int64 new_id = objIUStudentAssignedSubject.InsertUpdateStudentAssignedSubject();
		return new_id;
	}
	
	public static void DeleteStudentAssignedSubject(Int32 intStudentSubjectID = 0)
	{
		objStudentAssignedSubject.DeleteStudentAssignedSubject(intStudentSubjectID);
	}
	
	public static void Truncate()
	{
		objStudentAssignedSubject.Truncate();
	}
}