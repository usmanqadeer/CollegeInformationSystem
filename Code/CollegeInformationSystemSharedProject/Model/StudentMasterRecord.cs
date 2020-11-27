using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentMasterRecord
{
    List<StudentMasterRecord> StudentMasterRecordList = new List<StudentMasterRecord>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentMasterRecord;
    SqlCommand comStudentMasterRecord;
    SqlDataAdapter daStudentMasterRecord;
    DataSet dsStudentMasterRecord;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentMasterRecord()
    {
        conStudentMasterRecord = new SqlConnection(connection_string);
        comStudentMasterRecord = new SqlCommand();
        daStudentMasterRecord = new SqlDataAdapter();
        dsStudentMasterRecord = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intMasterStudentID;
    Int64 intStudentID;
    string strUniversityInstitute;
    string strCollegeInstitute;
    string strEducationSystem;
    Int64 intMajor;
    int intTotalMarks;
    int intObtainedMarks;
    Double douCGPA;
    int intYearPassed;
    Int64 intAddByID;
    DateTime datAddDateTime;
    Int64 intLastUpdateID;
    DateTime datLastUpdateDateTime;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 MasterStudentID
    {
        get
        {
            return intMasterStudentID;
        }
        set
        {
            intMasterStudentID = value;
        }
    }
    public Int64 StudentID
    {
        get
        {
            return intStudentID;
        }
        set
        {
            intStudentID = value;
        }
    }
    public string UniversityInstitute
    {
        get
        {
            return strUniversityInstitute;
        }
        set
        {
            strUniversityInstitute = value;
        }
    }
    public string CollegeInstitute
    {
        get
        {
            return strCollegeInstitute;
        }
        set
        {
            strCollegeInstitute = value;
        }
    }
    public string EducationSystem
    {
        get
        {
            return strEducationSystem;
        }
        set
        {
            strEducationSystem = value;
        }
    }
    public Int64 Major
    {
        get
        {
            return intMajor;
        }
        set
        {
            intMajor = value;
        }
    }
    public int TotalMarks
    {
        get
        {
            return intTotalMarks;
        }
        set
        {
            intTotalMarks = value;
        }
    }
    public int ObtainedMarks
    {
        get
        {
            return intObtainedMarks;
        }
        set
        {
            intObtainedMarks = value;
        }
    }
    public Double CGPA
    {
        get
        {
            return douCGPA;
        }
        set
        {
            douCGPA = value;
        }
    }
    public int YearPassed
    {
        get
        {
            return intYearPassed;
        }
        set
        {
            intYearPassed = value;
        }
    }
    public Int64 AddByID
    {
        get
        {
            return intAddByID;
        }
        set
        {
            intAddByID = value;
        }
    }
    public DateTime AddDateTime
    {
        get
        {
            return datAddDateTime;
        }
        set
        {
            datAddDateTime = value;
        }
    }
    public Int64 LastUpdateID
    {
        get
        {
            return intLastUpdateID;
        }
        set
        {
            intLastUpdateID = value;
        }
    }
    public DateTime LastUpdateDateTime
    {
        get
        {
            return datLastUpdateDateTime;
        }
        set
        {
            datLastUpdateDateTime = value;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Private Methods///////////////////////////////////////////////////////////////////////////

    //DB to Model//	
    private void GenerateModelList()
    {
        StudentMasterRecordList.Clear();
        foreach (DataRow drStudentMasterRecord in dsStudentMasterRecord.Tables[0].Rows)
        {
            StudentMasterRecord objStudentMasterRecord = new StudentMasterRecord();
            objStudentMasterRecord.MasterStudentID = Convert.ToInt64(drStudentMasterRecord["MasterStudentID"]);
            objStudentMasterRecord.StudentID = Convert.ToInt64(drStudentMasterRecord["StudentID"]);
            objStudentMasterRecord.UniversityInstitute = Convert.ToString(drStudentMasterRecord["UniversityInstitute"]);
            objStudentMasterRecord.CollegeInstitute = Convert.ToString(drStudentMasterRecord["CollegeInstitute"]);
            objStudentMasterRecord.EducationSystem = Convert.ToString(drStudentMasterRecord["EducationSystem"]);
            objStudentMasterRecord.Major = Convert.ToInt64(drStudentMasterRecord["Major"]);
            objStudentMasterRecord.TotalMarks = Convert.ToInt32(drStudentMasterRecord["TotalMarks"]);
            objStudentMasterRecord.ObtainedMarks = Convert.ToInt32(drStudentMasterRecord["ObtainedMarks"]);
            objStudentMasterRecord.CGPA = Convert.ToInt64(drStudentMasterRecord["CGPA"]);
            objStudentMasterRecord.YearPassed = Convert.ToInt32(drStudentMasterRecord["YearPassed"]);
            objStudentMasterRecord.AddByID = Convert.ToInt64(drStudentMasterRecord["AddByID"]);
            objStudentMasterRecord.AddDateTime = Convert.ToDateTime(drStudentMasterRecord["AddDateTime"]);
            objStudentMasterRecord.LastUpdateID = Convert.ToInt64(drStudentMasterRecord["LastUpdateID"]);
            objStudentMasterRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentMasterRecord["LastUpdateDateTime"]);

            StudentMasterRecordList.Add(objStudentMasterRecord);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentMasterRecord.Clear();
        conStudentMasterRecord.Open();
        comStudentMasterRecord.Connection = conStudentMasterRecord;
        comStudentMasterRecord.CommandText = strCommandText;

        comStudentMasterRecord.CommandType = CommandType.StoredProcedure;
        daStudentMasterRecord.SelectCommand = comStudentMasterRecord;
        daStudentMasterRecord.Fill(dsStudentMasterRecord);
        conStudentMasterRecord.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentMasterRecord> StudentMasterRecordSelectAll()
    {
        try
        {
            string sp_name = "StudentMasterRecordSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentMasterRecordList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentMasterRecord StudentMasterRecordSelectByID(int intMasterStudentID)
    {
        try
        {
            string sp_name = "StudentMasterRecordSelectByID";
            comStudentMasterRecord.Parameters.AddWithValue("MasterStudentID", intMasterStudentID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentMasterRecord.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentMasterRecord = dsStudentMasterRecord.Tables[0].Rows[0];
                StudentMasterRecord objStudentMasterRecord = new StudentMasterRecord();
                objStudentMasterRecord.MasterStudentID = Convert.ToInt64(drStudentMasterRecord["MasterStudentID"]);
                objStudentMasterRecord.StudentID = Convert.ToInt64(drStudentMasterRecord["StudentID"]);
                objStudentMasterRecord.UniversityInstitute = Convert.ToString(drStudentMasterRecord["UniversityInstitute"]);
                objStudentMasterRecord.CollegeInstitute = Convert.ToString(drStudentMasterRecord["CollegeInstitute"]);
                objStudentMasterRecord.EducationSystem = Convert.ToString(drStudentMasterRecord["EducationSystem"]);
                objStudentMasterRecord.Major = Convert.ToInt64(drStudentMasterRecord["Major"]);
                objStudentMasterRecord.TotalMarks = Convert.ToInt32(drStudentMasterRecord["TotalMarks"]);
                objStudentMasterRecord.ObtainedMarks = Convert.ToInt32(drStudentMasterRecord["ObtainedMarks"]);
                objStudentMasterRecord.CGPA = Convert.ToInt64(drStudentMasterRecord["CGPA"]);
                objStudentMasterRecord.YearPassed = Convert.ToInt32(drStudentMasterRecord["YearPassed"]);
                objStudentMasterRecord.AddByID = Convert.ToInt64(drStudentMasterRecord["AddByID"]);
                objStudentMasterRecord.AddDateTime = Convert.ToDateTime(drStudentMasterRecord["AddDateTime"]);
                objStudentMasterRecord.LastUpdateID = Convert.ToInt64(drStudentMasterRecord["LastUpdateID"]);
                objStudentMasterRecord.LastUpdateDateTime = Convert.ToDateTime(drStudentMasterRecord["LastUpdateDateTime"]);

                return objStudentMasterRecord;
            }
            return null;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    /// <summary>
    ///  To insert or update record in database. If primary key value is not given then Insert operation will be execute
    /// </summary>
    /// <params></params>
    /// <return>Retrived record from database</return>
    public Int64 InsertUpdateStudentMasterRecord()
    {
        try
        {
            //parameter setting
            comStudentMasterRecord.Parameters.AddWithValue("MasterStudentID", intMasterStudentID);
            comStudentMasterRecord.Parameters.AddWithValue("StudentID", intStudentID);
            comStudentMasterRecord.Parameters.AddWithValue("UniversityInstitute", strUniversityInstitute);
            comStudentMasterRecord.Parameters.AddWithValue("CollegeInstitute", strCollegeInstitute);
            comStudentMasterRecord.Parameters.AddWithValue("EducationSystem", strEducationSystem);
            comStudentMasterRecord.Parameters.AddWithValue("Major", intMajor);
            comStudentMasterRecord.Parameters.AddWithValue("TotalMarks", intTotalMarks);
            comStudentMasterRecord.Parameters.AddWithValue("ObtainedMarks", intObtainedMarks);
            comStudentMasterRecord.Parameters.AddWithValue("CGPA", douCGPA);
            comStudentMasterRecord.Parameters.AddWithValue("YearPassed", intYearPassed);
            comStudentMasterRecord.Parameters.AddWithValue("AddByID", intAddByID);
            comStudentMasterRecord.Parameters.AddWithValue("AddDateTime", datAddDateTime);
            comStudentMasterRecord.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comStudentMasterRecord.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

            //end parameter setting

            ConnectAndExecute("StudentMasterRecordInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentMasterRecord.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }
    public void DeleteStudentMasterRecord(Int64 intMasterStudentID = 0)
    {
        try
        {
            string sp_name = "StudentMasterRecordDeleteAll";
            if (intMasterStudentID != 0)
            {
                comStudentMasterRecord.Parameters.AddWithValue("MasterStudentID", intMasterStudentID);
                sp_name = "StudentMasterRecordDeleteByID";
            }

            ConnectAndExecute(sp_name);
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
        }
    }

    public void Truncate()
    {
        try
        {
            string sp_name = "StudentMasterRecordTruncate";
            ConnectAndExecute(sp_name);
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
        }
    }
    private void SetError(string message)
    { }


}