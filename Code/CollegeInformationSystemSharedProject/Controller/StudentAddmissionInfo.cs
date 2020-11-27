using System;
using System.Collections;
using System.Collections.Generic;

public class StudentAddmissionInfoController
{
	static StudentAddmissionInfo objStudentAddmissionInfo = new StudentAddmissionInfo();
	public static List<StudentAddmissionInfo> StudentAddmissionInfoSelectAll()
	{
		return objStudentAddmissionInfo.StudentAddmissionInfoSelectAll();
	}
	
	public static StudentAddmissionInfo StudentAddmissionInfoSelectByID(Int32 intStudentAddmissionID)
	{
		return objStudentAddmissionInfo.StudentAddmissionInfoSelectByID(intStudentAddmissionID);
	}
	
	public static Int64 InsertUpdateStudentAddmissionInfo(StudentAddmissionInfo objIUStudentAddmissionInfo)
	{
		Int64 new_id = objIUStudentAddmissionInfo.InsertUpdateStudentAddmissionInfo();
		return new_id;
	}
	
	public static void DeleteStudentAddmissionInfo(Int32 intStudentAddmissionID = 0)
	{
		objStudentAddmissionInfo.DeleteStudentAddmissionInfo(intStudentAddmissionID);
	}
	
	public static void Truncate()
	{
		objStudentAddmissionInfo.Truncate();
	}
}