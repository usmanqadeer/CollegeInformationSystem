using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentProgram
{
    List<StudentProgram> StudentProgramList = new List<StudentProgram>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentProgram;
    SqlCommand comStudentProgram;
    SqlDataAdapter daStudentProgram;
    DataSet dsStudentProgram;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentProgram()
    {
        conStudentProgram = new SqlConnection(connection_string);
        comStudentProgram = new SqlCommand();
        daStudentProgram = new SqlDataAdapter();
        dsStudentProgram = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intProgramID;
    string strProgramName;
    Int64 intDegreeID;
    Int64 intCreatedByID;
    DateTime datCreatedDateTime;
    Int64 intLastUpdateID;
    DateTime datLastUpdateDateTime;
    bool blnIsEnabled;
    string strRemarks;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 ProgramID
    {
        get
        {
            return intProgramID;
        }
        set
        {
            intProgramID = value;
        }
    }
    public string ProgramName
    {
        get
        {
            return strProgramName;
        }
        set
        {
            strProgramName = value;
        }
    }
    public Int64 DegreeID
    {
        get
        {
            return intDegreeID;
        }
        set
        {
            intDegreeID = value;
        }
    }
    public Int64 CreatedByID
    {
        get
        {
            return intCreatedByID;
        }
        set
        {
            intCreatedByID = value;
        }
    }
    public DateTime CreatedDateTime
    {
        get
        {
            return datCreatedDateTime;
        }
        set
        {
            datCreatedDateTime = value;
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

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Private Methods///////////////////////////////////////////////////////////////////////////

    //DB to Model//	
    private void GenerateModelList()
    {
        StudentProgramList.Clear();
        foreach (DataRow drStudentProgram in dsStudentProgram.Tables[0].Rows)
        {
            StudentProgram objStudentProgram = new StudentProgram();
            objStudentProgram.ProgramID = Convert.ToInt64(drStudentProgram["ProgramID"]);
            objStudentProgram.ProgramName = Convert.ToString(drStudentProgram["ProgramName"]);
            objStudentProgram.DegreeID = Convert.ToInt64(drStudentProgram["DegreeID"]);
            objStudentProgram.CreatedByID = Convert.ToInt64(drStudentProgram["CreatedByID"]);
            objStudentProgram.CreatedDateTime = Convert.ToDateTime(drStudentProgram["CreatedDateTime"]);
            objStudentProgram.LastUpdateID = Convert.ToInt64(drStudentProgram["LastUpdateID"]);
            objStudentProgram.LastUpdateDateTime = Convert.ToDateTime(drStudentProgram["LastUpdateDateTime"]);
            objStudentProgram.IsEnabled = Convert.ToBoolean(drStudentProgram["IsEnabled"]);
            objStudentProgram.Remarks = Convert.ToString(drStudentProgram["Remarks"]);

            StudentProgramList.Add(objStudentProgram);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentProgram.Clear();
        conStudentProgram.Open();
        comStudentProgram.Connection = conStudentProgram;
        comStudentProgram.CommandText = strCommandText;

        comStudentProgram.CommandType = CommandType.StoredProcedure;
        daStudentProgram.SelectCommand = comStudentProgram;
        daStudentProgram.Fill(dsStudentProgram);
        conStudentProgram.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentProgram> StudentProgramSelectAll()
    {
        try
        {
            string sp_name = "StudentProgramSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentProgramList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentProgram StudentProgramSelectByID(int intProgramID)
    {
        try
        {
            string sp_name = "StudentProgramSelectByID";
            comStudentProgram.Parameters.AddWithValue("ProgramID", intProgramID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentProgram.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentProgram = dsStudentProgram.Tables[0].Rows[0];
                StudentProgram objStudentProgram = new StudentProgram();
                objStudentProgram.ProgramID = Convert.ToInt64(drStudentProgram["ProgramID"]);
                objStudentProgram.ProgramName = Convert.ToString(drStudentProgram["ProgramName"]);
                objStudentProgram.DegreeID = Convert.ToInt64(drStudentProgram["DegreeID"]);
                objStudentProgram.CreatedByID = Convert.ToInt64(drStudentProgram["CreatedByID"]);
                objStudentProgram.CreatedDateTime = Convert.ToDateTime(drStudentProgram["CreatedDateTime"]);
                objStudentProgram.LastUpdateID = Convert.ToInt64(drStudentProgram["LastUpdateID"]);
                objStudentProgram.LastUpdateDateTime = Convert.ToDateTime(drStudentProgram["LastUpdateDateTime"]);
                objStudentProgram.IsEnabled = Convert.ToBoolean(drStudentProgram["IsEnabled"]);
                objStudentProgram.Remarks = Convert.ToString(drStudentProgram["Remarks"]);

                return objStudentProgram;
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
    public Int64 InsertUpdateStudentProgram()
    {
        try
        {
            //parameter setting
            comStudentProgram.Parameters.AddWithValue("ProgramID", intProgramID);
            comStudentProgram.Parameters.AddWithValue("ProgramName", strProgramName);
            comStudentProgram.Parameters.AddWithValue("DegreeID", intDegreeID);
            comStudentProgram.Parameters.AddWithValue("CreatedByID", intCreatedByID);
            comStudentProgram.Parameters.AddWithValue("CreatedDateTime", datCreatedDateTime);
            comStudentProgram.Parameters.AddWithValue("LastUpdateID", intLastUpdateID);
            comStudentProgram.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);
            comStudentProgram.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
            comStudentProgram.Parameters.AddWithValue("Remarks", strRemarks);

            //end parameter setting

            ConnectAndExecute("StudentProgramInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentProgram.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentProgram(Int64 intProgramID = 0)
    {
        try
        {
            string sp_name = "StudentProgramDeleteAll";
            if (intProgramID != 0)
            {
                comStudentProgram.Parameters.AddWithValue("ProgramID", intProgramID);
                sp_name = "StudentProgramDeleteByID";
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
            string sp_name = "StudentProgramTruncate";
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