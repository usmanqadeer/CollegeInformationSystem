using System;
using System.Collections;
using System.Collections.Generic;

public class StudentMasterRecordController
{
	static StudentMasterRecord objStudentMasterRecord = new StudentMasterRecord();
	public static List<StudentMasterRecord> StudentMasterRecordSelectAll()
	{
		return objStudentMasterRecord.StudentMasterRecordSelectAll();
	}
	
	public static StudentMasterRecord StudentMasterRecordSelectByID(Int32 intMasterStudentID)
	{
		return objStudentMasterRecord.StudentMasterRecordSelectByID(intMasterStudentID);
	}
	
	public static Int64 InsertUpdateStudentMasterRecord(StudentMasterRecord objIUStudentMasterRecord)
	{
		Int64 new_id = objIUStudentMasterRecord.InsertUpdateStudentMasterRecord();
		return new_id;
	}
	
	public static void DeleteStudentMasterRecord(Int32 intMasterStudentID = 0)
	{
		objStudentMasterRecord.DeleteStudentMasterRecord(intMasterStudentID);
	}
	
	public static void Truncate()
	{
		objStudentMasterRecord.Truncate();
	}
}