using System;
using System.Collections;
using System.Collections.Generic;

public class StudentIntermediateRecordController
{
	static StudentIntermediateRecord objStudentIntermediateRecord = new StudentIntermediateRecord();
	public static List<StudentIntermediateRecord> StudentIntermediateRecordSelectAll()
	{
		return objStudentIntermediateRecord.StudentIntermediateRecordSelectAll();
	}
	
	public static StudentIntermediateRecord StudentIntermediateRecordSelectByID(Int32 intIntermediateStudentID)
	{
		return objStudentIntermediateRecord.StudentIntermediateRecordSelectByID(intIntermediateStudentID);
	}
	
	public static Int64 InsertUpdateStudentIntermediateRecord(StudentIntermediateRecord objIUStudentIntermediateRecord)
	{
		Int64 new_id = objIUStudentIntermediateRecord.InsertUpdateStudentIntermediateRecord();
		return new_id;
	}
	
	public static void DeleteStudentIntermediateRecord(Int32 intIntermediateStudentID = 0)
	{
		objStudentIntermediateRecord.DeleteStudentIntermediateRecord(intIntermediateStudentID);
	}
	
	public static void Truncate()
	{
		objStudentIntermediateRecord.Truncate();
	}
}