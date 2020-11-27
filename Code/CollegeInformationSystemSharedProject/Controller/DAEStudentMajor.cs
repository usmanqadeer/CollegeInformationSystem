using System;
using System.Collections;
using System.Collections.Generic;

public class DAEStudentMajorController
{
	static DAEStudentMajor objDAEStudentMajor = new DAEStudentMajor();
    public static List<DAEStudentMajor> DAEStudentMajorSelectAll()
    {
		return objDAEStudentMajor.DAEStudentMajorSelectAll();
	}
	
	public static DAEStudentMajor DAEStudentMajorSelectByID(Int32 intDAEMajorID)
	{
		return objDAEStudentMajor.DAEStudentMajorSelectByID(intDAEMajorID);
	}
	
	public static Int64 InsertUpdateDAEStudentMajor(DAEStudentMajor objIUDAEStudentMajor)
	{
		Int64 new_id = objIUDAEStudentMajor.InsertUpdateDAEStudentMajor();
		return new_id;
	}
	
	public static void DeleteDAEStudentMajor(Int32 intDAEMajorID = 0)
	{
		objDAEStudentMajor.DeleteDAEStudentMajor(intDAEMajorID);
	}
	
	public static void Truncate()
	{
		objDAEStudentMajor.Truncate();
	}
}