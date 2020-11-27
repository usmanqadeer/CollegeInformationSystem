using System;
using System.Collections;
using System.Collections.Generic;

public class StudentGuardianRecordController
{
	static StudentGuardianRecord objStudentGuardianRecord = new StudentGuardianRecord();
	public static List<StudentGuardianRecord> StudentGuardianRecordSelectAll()
	{
		return objStudentGuardianRecord.StudentGuardianRecordSelectAll();
	}
	
	public static StudentGuardianRecord StudentGuardianRecordSelectByID(Int32 intGuardianID)
	{
		return objStudentGuardianRecord.StudentGuardianRecordSelectByID(intGuardianID);
	}
	
	public static Int64 InsertUpdateStudentGuardianRecord(StudentGuardianRecord objIUStudentGuardianRecord)
	{
		Int64 new_id = objIUStudentGuardianRecord.InsertUpdateStudentGuardianRecord();
		return new_id;
	}
	
	public static void DeleteStudentGuardianRecord(Int32 intGuardianID = 0)
	{
		objStudentGuardianRecord.DeleteStudentGuardianRecord(intGuardianID);
	}
	
	public static void Truncate()
	{
		objStudentGuardianRecord.Truncate();
	}
}