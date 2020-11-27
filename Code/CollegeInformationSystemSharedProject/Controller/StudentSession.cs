using System;
using System.Collections;
using System.Collections.Generic;

public class StudentSessionController
{
	static StudentSession objStudentSession = new StudentSession();
	public static List<StudentSession> StudentSessionSelectAll()
	{
		return objStudentSession.StudentSessionSelectAll();
	}
	
	public static StudentSession StudentSessionSelectByID(Int32 intSessionID)
	{
		return objStudentSession.StudentSessionSelectByID(intSessionID);
	}
	
	public static Int64 InsertUpdateStudentSession(StudentSession objIUStudentSession)
	{
		Int64 new_id = objIUStudentSession.InsertUpdateStudentSession();
		return new_id;
	}
	
	public static void DeleteStudentSession(Int32 intSessionID = 0)
	{
		objStudentSession.DeleteStudentSession(intSessionID);
	}
	
	public static void Truncate()
	{
		objStudentSession.Truncate();
	}
}