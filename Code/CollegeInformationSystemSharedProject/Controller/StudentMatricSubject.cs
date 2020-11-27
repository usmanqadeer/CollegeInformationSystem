using System;
using System.Collections;
using System.Collections.Generic;

public class StudentMatricSubjectController
{
	static StudentMatricSubject objStudentMatricSubject = new StudentMatricSubject();
	public static List<StudentMatricSubject> StudentMatricSubjectSelectAll()
	{
		return objStudentMatricSubject.StudentMatricSubjectSelectAll();
	}
	
	public static StudentMatricSubject StudentMatricSubjectSelectByID(Int32 intStudentSubjectID)
	{
		return objStudentMatricSubject.StudentMatricSubjectSelectByID(intStudentSubjectID);
	}
	
	public static Int64 InsertUpdateStudentMatricSubject(StudentMatricSubject objIUStudentMatricSubject)
	{
		Int64 new_id = objIUStudentMatricSubject.InsertUpdateStudentMatricSubject();
		return new_id;
	}
	
	public static void DeleteStudentMatricSubject(Int32 intStudentSubjectID = 0)
	{
		objStudentMatricSubject.DeleteStudentMatricSubject(intStudentSubjectID);
	}
	
	public static void Truncate()
	{
		objStudentMatricSubject.Truncate();
	}
}