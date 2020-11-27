using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentDegree
{
    List<StudentDegree> StudentDegreeList = new List<StudentDegree>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentDegree;
    SqlCommand comStudentDegree;
    SqlDataAdapter daStudentDegree;
    DataSet dsStudentDegree;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentDegree()
    {
        conStudentDegree = new SqlConnection(connection_string);
        comStudentDegree = new SqlCommand();
        daStudentDegree = new SqlDataAdapter();
        dsStudentDegree = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intDegreeID;
    string strDegreeName;
    Int64 intCreatedByID;
    DateTime datCreatedDateTime;
    bool blnIsEnabled;
    Int64 intLastUpdateByID;
    DateTime datLastUpdateTime;
    string strRemarks;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
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
    public string DegreeName
    {
        get
        {
            return strDegreeName;
        }
        set
        {
            strDegreeName = value;
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
    public Int64 LastUpdateByID
    {
        get
        {
            return intLastUpdateByID;
        }
        set
        {
            intLastUpdateByID = value;
        }
    }
    public DateTime LastUpdateTime
    {
        get
        {
            return datLastUpdateTime;
        }
        set
        {
            datLastUpdateTime = value;
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
        StudentDegreeList.Clear();
        foreach (DataRow drStudentDegree in dsStudentDegree.Tables[0].Rows)
        {
            StudentDegree objStudentDegree = new StudentDegree();
            objStudentDegree.DegreeID = Convert.ToInt64(drStudentDegree["DegreeID"]);
            objStudentDegree.DegreeName = Convert.ToString(drStudentDegree["DegreeName"]);
            objStudentDegree.CreatedByID = Convert.ToInt64(drStudentDegree["CreatedByID"]);
            objStudentDegree.CreatedDateTime = Convert.ToDateTime(drStudentDegree["CreatedDateTime"]);
            objStudentDegree.IsEnabled = Convert.ToBoolean(drStudentDegree["IsEnabled"]);
            objStudentDegree.LastUpdateByID = Convert.ToInt64(drStudentDegree["LastUpdateByID"]);
            objStudentDegree.LastUpdateTime = Convert.ToDateTime(drStudentDegree["LastUpdateTime"]);
            objStudentDegree.Remarks = Convert.ToString(drStudentDegree["Remarks"]);

            StudentDegreeList.Add(objStudentDegree);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentDegree.Clear();
        conStudentDegree.Open();
        comStudentDegree.Connection = conStudentDegree;
        comStudentDegree.CommandText = strCommandText;

        comStudentDegree.CommandType = CommandType.StoredProcedure;
        daStudentDegree.SelectCommand = comStudentDegree;
        daStudentDegree.Fill(dsStudentDegree);
        conStudentDegree.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentDegree> StudentDegreeSelectAll()
    {
        try
        {
            string sp_name = "StudentDegreeSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentDegreeList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentDegree StudentDegreeSelectByID(int intDegreeID)
    {
        try
        {
            string sp_name = "StudentDegreeSelectByID";
            comStudentDegree.Parameters.AddWithValue("DegreeID", intDegreeID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentDegree.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentDegree = dsStudentDegree.Tables[0].Rows[0];
                StudentDegree objStudentDegree = new StudentDegree();
                objStudentDegree.DegreeID = Convert.ToInt64(drStudentDegree["DegreeID"]);
                objStudentDegree.DegreeName = Convert.ToString(drStudentDegree["DegreeName"]);
                objStudentDegree.CreatedByID = Convert.ToInt64(drStudentDegree["CreatedByID"]);
                objStudentDegree.CreatedDateTime = Convert.ToDateTime(drStudentDegree["CreatedDateTime"]);
                objStudentDegree.IsEnabled = Convert.ToBoolean(drStudentDegree["IsEnabled"]);
                objStudentDegree.LastUpdateByID = Convert.ToInt64(drStudentDegree["LastUpdateByID"]);
                objStudentDegree.LastUpdateTime = Convert.ToDateTime(drStudentDegree["LastUpdateTime"]);
                objStudentDegree.Remarks = Convert.ToString(drStudentDegree["Remarks"]);

                return objStudentDegree;
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
    public Int64 InsertUpdateStudentDegree()
    {
        try
        {
            //parameter setting
            comStudentDegree.Parameters.AddWithValue("DegreeID", intDegreeID);
            comStudentDegree.Parameters.AddWithValue("DegreeName", strDegreeName);
            comStudentDegree.Parameters.AddWithValue("CreatedByID", intCreatedByID);
            comStudentDegree.Parameters.AddWithValue("CreatedDateTime", datCreatedDateTime);
            comStudentDegree.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
            comStudentDegree.Parameters.AddWithValue("LastUpdateByID", intLastUpdateByID);
            comStudentDegree.Parameters.AddWithValue("LastUpdateTime", datLastUpdateTime);
            comStudentDegree.Parameters.AddWithValue("Remarks", strRemarks);

            //end parameter setting

            ConnectAndExecute("StudentDegreeInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentDegree.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentDegree(Int64 intDegreeID = 0)
    {
        try
        {
            string sp_name = "StudentDegreeDeleteAll";
            if (intDegreeID != 0)
            {
                comStudentDegree.Parameters.AddWithValue("DegreeID", intDegreeID);
                sp_name = "StudentDegreeDeleteByID";
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
            string sp_name = "StudentDegreeTruncate";
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