using System;
using System.Collections;
using System.Collections.Generic;

public class StudentIntermediateSubjectController
{
	static StudentIntermediateSubject objStudentIntermediateSubject = new StudentIntermediateSubject();
	public static List<StudentIntermediateSubject> StudentIntermediateSubjectSelectAll()
	{
		return objStudentIntermediateSubject.StudentIntermediateSubjectSelectAll();
	}
	
	public static StudentIntermediateSubject StudentIntermediateSubjectSelectByID(Int32 intStudentSubjectID)
	{
		return objStudentIntermediateSubject.StudentIntermediateSubjectSelectByID(intStudentSubjectID);
	}
	
	public static Int64 InsertUpdateStudentIntermediateSubject(StudentIntermediateSubject objIUStudentIntermediateSubject)
	{
		Int64 new_id = objIUStudentIntermediateSubject.InsertUpdateStudentIntermediateSubject();
		return new_id;
	}
	
	public static void DeleteStudentIntermediateSubject(Int32 intStudentSubjectID = 0)
	{
		objStudentIntermediateSubject.DeleteStudentIntermediateSubject(intStudentSubjectID);
	}
	
	public static void Truncate()
	{
		objStudentIntermediateSubject.Truncate();
	}
}