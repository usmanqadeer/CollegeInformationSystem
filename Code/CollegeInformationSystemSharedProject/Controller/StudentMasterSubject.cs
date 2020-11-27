using System;
using System.Collections;
using System.Collections.Generic;

public class StudentMasterSubjectController
{
	static StudentMasterSubject objStudentMasterSubject = new StudentMasterSubject();
	public static List<StudentMasterSubject> StudentMasterSubjectSelectAll()
	{
		return objStudentMasterSubject.StudentMasterSubjectSelectAll();
	}
	
	public static StudentMasterSubject StudentMasterSubjectSelectByID(Int32 intStudentSubjectID)
	{
		return objStudentMasterSubject.StudentMasterSubjectSelectByID(intStudentSubjectID);
	}
	
	public static Int64 InsertUpdateStudentMasterSubject(StudentMasterSubject objIUStudentMasterSubject)
	{
		Int64 new_id = objIUStudentMasterSubject.InsertUpdateStudentMasterSubject();
		return new_id;
	}
	
	public static void DeleteStudentMasterSubject(Int32 intStudentSubjectID = 0)
	{
		objStudentMasterSubject.DeleteStudentMasterSubject(intStudentSubjectID);
	}
	
	public static void Truncate()
	{
		objStudentMasterSubject.Truncate();
	}
}