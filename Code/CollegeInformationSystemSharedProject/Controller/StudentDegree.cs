using System;
using System.Collections;
using System.Collections.Generic;

public class StudentDegreeController
{
	static StudentDegree objStudentDegree = new StudentDegree();
	public static List<StudentDegree> StudentDegreeSelectAll()
	{
		return objStudentDegree.StudentDegreeSelectAll();
	}
	
	public static StudentDegree StudentDegreeSelectByID(Int32 intDegreeID)
	{
		return objStudentDegree.StudentDegreeSelectByID(intDegreeID);
	}
	
	public static Int64 InsertUpdateStudentDegree(StudentDegree objIUStudentDegree)
	{
		Int64 new_id = objIUStudentDegree.InsertUpdateStudentDegree();
		return new_id;
	}
	
	public static void DeleteStudentDegree(Int32 intDegreeID = 0)
	{
		objStudentDegree.DeleteStudentDegree(intDegreeID);
	}
	
	public static void Truncate()
	{
		objStudentDegree.Truncate();
	}
}