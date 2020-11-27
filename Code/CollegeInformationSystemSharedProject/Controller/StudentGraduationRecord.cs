using System;
using System.Collections;
using System.Collections.Generic;

public class StudentGraduationRecordController
{
	static StudentGraduationRecord objStudentGraduationRecord = new StudentGraduationRecord();
	public static List<StudentGraduationRecord> StudentGraduationRecordSelectAll()
	{
		return objStudentGraduationRecord.StudentGraduationRecordSelectAll();
	}
	
	public static StudentGraduationRecord StudentGraduationRecordSelectByID(Int32 intGraduationStudentID)
	{
		return objStudentGraduationRecord.StudentGraduationRecordSelectByID(intGraduationStudentID);
	}
	
	public static Int64 InsertUpdateStudentGraduationRecord(StudentGraduationRecord objIUStudentGraduationRecord)
	{
		Int64 new_id = objIUStudentGraduationRecord.InsertUpdateStudentGraduationRecord();
		return new_id;
	}
	
	public static void DeleteStudentGraduationRecord(Int32 intGraduationStudentID = 0)
	{
		objStudentGraduationRecord.DeleteStudentGraduationRecord(intGraduationStudentID);
	}
	
	public static void Truncate()
	{
		objStudentGraduationRecord.Truncate();
	}
}