using System;
using System.Collections;
using System.Collections.Generic;

public class StudentMatricRecordController
{
	static StudentMatricRecord objStudentMatricRecord = new StudentMatricRecord();
	public static List<StudentMatricRecord> StudentMatricRecordSelectAll()
	{
		return objStudentMatricRecord.StudentMatricRecordSelectAll();
	}
	
	public static StudentMatricRecord StudentMatricRecordSelectByID(Int32 intMatricStudentID)
	{
		return objStudentMatricRecord.StudentMatricRecordSelectByID(intMatricStudentID);
	}
	
	public static Int64 InsertUpdateStudentMatricRecord(StudentMatricRecord objIUStudentMatricRecord)
	{
		Int64 new_id = objIUStudentMatricRecord.InsertUpdateStudentMatricRecord();
		return new_id;
	}
	
	public static void DeleteStudentMatricRecord(Int32 intMatricStudentID = 0)
	{
		objStudentMatricRecord.DeleteStudentMatricRecord(intMatricStudentID);
	}
	
	public static void Truncate()
	{
		objStudentMatricRecord.Truncate();
	}
}