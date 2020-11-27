using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentPersonalInfo
{
    List<StudentPersonalInfo> StudentPersonalInfoList = new List<StudentPersonalInfo>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentPersonalInfo;
    SqlCommand comStudentPersonalInfo;
    SqlDataAdapter daStudentPersonalInfo;
    DataSet dsStudentPersonalInfo;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentPersonalInfo()
    {
        conStudentPersonalInfo = new SqlConnection(connection_string);
        comStudentPersonalInfo = new SqlCommand();
        daStudentPersonalInfo = new SqlDataAdapter();
        dsStudentPersonalInfo = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intStudentID;
    string strSudentName;
    string strStudentCNIC;
    DateTime datStudentDateOfBrith;
    string strStudentEmail;
    string strStudentContactNo;
    Int64 intStudentReligionID;
    string strStudentAddress;
    bool blnIsEnabled;
    string strStudentPicture;
    string strRemarks;
    Int64 intAddByID;
    DateTime datAddByDateTime;
    Int64 intLastUpdateID;
    DateTime datLastUpdateDateTime;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
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
    public string SudentName
    {
        get
        {
            return strSudentName;
        }
        set
        {
            strSudentName = value;
        }
    }
    public string StudentCNIC
    {
        get
        {
            return strStudentCNIC;
        }
        set
        {
            strStudentCNIC = value;
        }
    }
    public DateTime StudentDateOfBrith
    {
        get
        {
            return datStudentDateOfBrith;
        }
        set
        {
            datStudentDateOfBrith = value;
        }
    }
    public string StudentEmail
    {
        get
        {
            return strStudentEmail;
        }
        set
        {
            strStudentEmail = value;
        }
    }
    public string StudentContactNo
    {
        get
        {
            return strStudentContactNo;
        }
        set
        {
            strStudentContactNo = value;
        }
    }
    public Int64 StudentReligionID
    {
        get
        {
            return intStudentReligionID;
        }
        set
        {
            intStudentReligionID = value;
        }
    }
    public string StudentAddress
    {
        get
        {
            return strStudentAddress;
        }
        set
        {
            strStudentAddress = value;
        }
    }
    public bool IsEnabled
    {
        get
        {
            return blnIsEnabled;
        }
        set
        {
            blnIsEnabled = value;
        }
    }
    public string StudentPicture
    {
        get
        {
            return strStudentPicture;
        }
        set
        {
            strStudentPicture = value;
        }
    }
    public string Remarks
    {
        get
        {
            return strRemarks;
        }
        set
        {
            strRemarks = value;
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
    public DateTime AddByDateTime
    {
        get
        {
            return datAddByDateTime;
        }
        set
        {
            datAddByDateTime = value;
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
        StudentPersonalInfoList.Clear();
        foreach (DataRow drStudentPersonalInfo in dsStudentPersonalInfo.Tables[0].Rows)
        {
            StudentPersonalInfo objStudentPersonalInfo = new StudentPersonalInfo();
            objStudentPersonalInfo.StudentID = Convert.ToInt64(drStudentPersonalInfo["StudentID"]);
            objStudentPersonalInfo.SudentName = Convert.ToString(drStudentPersonalInfo["SudentName"]);
            objStudentPersonalInfo.StudentCNIC = Convert.ToString(drStudentPersonalInfo["StudentCNIC"]);
            objStudentPersonalInfo.StudentDateOfBrith = Convert.ToDateTime(drStudentPersonalInfo["StudentDateOfBrith"]);
            objStudentPersonalInfo.StudentEmail = Convert.ToString(drStudentPersonalInfo["StudentEmail"]);
            objStudentPersonalInfo.StudentContactNo = Convert.ToString(drStudentPersonalInfo["StudentContactNo"]);
            objStudentPersonalInfo.StudentReligionID = Convert.ToInt64(drStudentPersonalInfo["StudentReligionID"]);
            objStudentPersonalInfo.StudentAddress = Convert.ToString(drStudentPersonalInfo["StudentAddress"]);
            objStudentPersonalInfo.IsEnabled = Convert.ToBoolean(drStudentPersonalInfo["IsEnabled"]);
            objStudentPersonalInfo.StudentPicture = Convert.ToString(drStudentPersonalInfo["StudentPicture"]);
            objStudentPersonalInfo.Remarks = Convert.ToString(drStudentPersonalInfo["Remarks"]);
            objStudentPersonalInfo.AddByID = Convert.ToInt64(drStudentPersonalInfo["AddByID"]);
            objStudentPersonalInfo.AddByDateTime = Convert.ToDateTime(drStudentPersonalInfo["AddByDateTime"]);
            objStudentPersonalInfo.LastUpdateID = Convert.ToInt64(drStudentPersonalInfo["LastUpdateID"]);
            objStudentPersonalInfo.LastUpdateDateTime = Convert.ToDateTime(drStudentPersonalInfo["LastUpdateDateTime"]);

            StudentPersonalInfoList.Add(objStudentPersonalInfo);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentPersonalInfo.Clear();
        conStudentPersonalInfo.Open();
        comStudentPersonalInfo.Connection = conStudentPersonalInfo;
        comStudentPersonalInfo.CommandText = strCommandText;

        comStudentPersonalInfo.CommandType = CommandType.StoredProcedure;
        daStudentPersonalInfo.SelectCommand = comStudentPersonalInfo;
        daStudentPersonalInfo.Fill(dsStudentPersonalInfo);
        conStudentPersonalInfo.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentPersonalInfo> StudentPersonalInfoSelectAll()
    {
        try
        {
            string sp_name = "StudentPersonalInfoSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentPersonalInfoList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentPersonalInfo StudentPersonalInfoSelectByID(int intStudentID)
    {
        try
        {
            string sp_name = "StudentPersonalInfoSelectByID";
            comStudentPersonalInfo.Parameters.AddWithValue("StudentID", intStudentID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentPersonalInfo.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentPersonalInfo = dsStudentPersonalInfo.Tables[0].Rows[0];
                StudentPersonalInfo objStudentPersonalInfo = new StudentPersonalInfo();
                objStudentPersonalInfo.StudentID = Convert.ToInt64(drStudentPersonalInfo["StudentID"]);
                objStudentPersonalInfo.SudentName = Convert.ToString(drStudentPersonalInfo["SudentName"]);
                objStudentPersonalInfo.StudentCNIC = Convert.ToString(drStudentPersonalInfo["StudentCNIC"]);
                objStudentPersonalInfo.StudentDateOfBrith = Convert.ToDateTime(drStudentPersonalInfo["StudentDateOfBrith"]);
                objStudentPersonalInfo.StudentEmail = Convert.ToString(drStudentPersonalInfo["StudentEmail"]);
                objStudentPersonalInfo.StudentContactNo = Convert.ToString(drStudentPersonalInfo["StudentContactNo"]);
                objStudentPersonalInfo.StudentReligionID = Convert.ToInt64(drStudentPersonalInfo["StudentReligionID"]);
                objStudentPersonalInfo.StudentAddress = Convert.ToString(drStudentPersonalInfo["StudentAddress"]);
                objStudentPersonalInfo.IsEnabled = Convert.ToBoolean(drStudentPersonalInfo["IsEnabled"]);
                objStudentPersonalInfo.StudentPicture = Convert.ToString(drStudentPersonalInfo["StudentPicture"]);
                objStudentPersonalInfo.Remarks = Convert.ToString(drStudentPersonalInfo["Remarks"]);
                objStudentPersonalInfo.AddByID = Convert.ToInt64(drStudentPersonalInfo["AddByID"]);
                objStudentPersonalInfo.AddByDateTime = Convert.ToDateTime(drStudentPersonalInfo["AddByDateTime"]);
                objStudentPersonalInfo.LastUpdateID = Convert.ToInt64(drStudentPersonalInfo["LastUpdateID"]);
                objStudentPersonalInfo.LastUpdateDateTime = Convert.ToDateTime(drStudentPersonalInfo["LastUpdateDateTime"]);

                return objStudentPersonalInfo;
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
    public Int64 InsertUpdateStudentPersonalInfo()
    {
        try
        {
            //parameter setting
            comStudentPersonalInfo.Parameters.AddWithValue("StudentID", intStudentID);
            comStudentPersonalInfo.Parameters.AddWithValue("SudentName", strSudentName);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentCNIC", strStudentCNIC);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentDateOfBrith", datStudentDateOfBrith);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentEmail", strStudentEmail);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentContactNo", strStudentContactNo);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentReligionID", intStudentReligionID);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentAddress", strStudentAddress);
            comStudentPersonalInfo.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
            comStudentPersonalInfo.Parameters.AddWithValue("StudentPicture", strStudentPicture);
            comStudentPersonalInfo.Parameters.AddWithValue("Remarks", strRemarks);
            comStudentPersonalInfo.Parameters.AddWithValue("AddByID", intAddByID);
            comStudentPersonalInfo.Parameters.AddWithValue("AddByDateTime", datAddByDateTime);
            comStudentPersonalInfo.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comStudentPersonalInfo.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);

            //end parameter setting

            ConnectAndExecute("StudentPersonalInfoInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentPersonalInfo.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentPersonalInfo(Int64 intStudentID = 0)
    {
        try
        {
            string sp_name = "StudentPersonalInfoDeleteAll";
            if (intStudentID != 0)
            {
                comStudentPersonalInfo.Parameters.AddWithValue("StudentID", intStudentID);
                sp_name = "StudentPersonalInfoDeleteByID";
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
            string sp_name = "StudentPersonalInfoTruncate";
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