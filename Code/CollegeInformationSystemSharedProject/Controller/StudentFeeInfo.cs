using System;
using System.Collections;
using System.Collections.Generic;

public class StudentFeeInfoController
{
	static StudentFeeInfo objStudentFeeInfo = new StudentFeeInfo();
	public static List<StudentFeeInfo> StudentFeeInfoSelectAll()
	{
		return objStudentFeeInfo.StudentFeeInfoSelectAll();
	}
	
	public static StudentFeeInfo StudentFeeInfoSelectByID(Int32 intStudentFeeInfoID)
	{
		return objStudentFeeInfo.StudentFeeInfoSelectByID(intStudentFeeInfoID);
	}
	
	public static Int64 InsertUpdateStudentFeeInfo(StudentFeeInfo objIUStudentFeeInfo)
	{
		Int64 new_id = objIUStudentFeeInfo.InsertUpdateStudentFeeInfo();
		return new_id;
	}
	
	public static void DeleteStudentFeeInfo(Int32 intStudentFeeInfoID = 0)
	{
		objStudentFeeInfo.DeleteStudentFeeInfo(intStudentFeeInfoID);
	}
	
	public static void Truncate()
	{
		objStudentFeeInfo.Truncate();
	}
}