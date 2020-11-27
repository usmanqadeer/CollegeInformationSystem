using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

public class StudentSections
{
    List<StudentSections> StudentSectionsList = new List<StudentSections>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conStudentSections;
    SqlCommand comStudentSections;
    SqlDataAdapter daStudentSections;
    DataSet dsStudentSections;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public StudentSections()
    {
        conStudentSections = new SqlConnection(connection_string);
        comStudentSections = new SqlCommand();
        daStudentSections = new SqlDataAdapter();
        dsStudentSections = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intSectionID;
    string strSectionName;
    Int64 intSessionID;
    Int64 intCreatedByID;
    DateTime datCreatedDateTime;
    DateTime datLastUpdateDateTime;
    Int64 intLastUpdateByID;
    bool blnIsEnabled;
    string strRemarks;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 SectionID
    {
        get
        {
            return intSectionID;
        }
        set
        {
            intSectionID = value;
        }
    }
    public string SectionName
    {
        get
        {
            return strSectionName;
        }
        set
        {
            strSectionName = value;
        }
    }
    public Int64 SessionID
    {
        get
        {
            return intSessionID;
        }
        set
        {
            intSessionID = value;
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
        StudentSectionsList.Clear();
        foreach (DataRow drStudentSections in dsStudentSections.Tables[0].Rows)
        {
            StudentSections objStudentSections = new StudentSections();
            objStudentSections.SectionID = Convert.ToInt64(drStudentSections["SectionID"]);
            objStudentSections.SectionName = Convert.ToString(drStudentSections["SectionName"]);
            objStudentSections.SessionID = Convert.ToInt64(drStudentSections["SessionID"]);
            objStudentSections.CreatedByID = Convert.ToInt64(drStudentSections["CreatedByID"]);
            objStudentSections.CreatedDateTime = Convert.ToDateTime(drStudentSections["CreatedDateTime"]);
            objStudentSections.LastUpdateDateTime = Convert.ToDateTime(drStudentSections["LastUpdateDateTime"]);
            objStudentSections.LastUpdateByID = Convert.ToInt64(drStudentSections["LastUpdateByID"]);
            objStudentSections.IsEnabled = Convert.ToBoolean(drStudentSections["IsEnabled"]);
            objStudentSections.Remarks = Convert.ToString(drStudentSections["Remarks"]);

            StudentSectionsList.Add(objStudentSections);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsStudentSections.Clear();
        conStudentSections.Open();
        comStudentSections.Connection = conStudentSections;
        comStudentSections.CommandText = strCommandText;

        comStudentSections.CommandType = CommandType.StoredProcedure;
        daStudentSections.SelectCommand = comStudentSections;
        daStudentSections.Fill(dsStudentSections);
        conStudentSections.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<StudentSections> StudentSectionsSelectAll()
    {
        try
        {
            string sp_name = "StudentSectionsSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return StudentSectionsList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public StudentSections StudentSectionsSelectByID(int intSectionID)
    {
        try
        {
            string sp_name = "StudentSectionsSelectByID";
            comStudentSections.Parameters.AddWithValue("SectionID", intSectionID);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsStudentSections.Tables[0].Rows.Count == 1)
            {
                DataRow drStudentSections = dsStudentSections.Tables[0].Rows[0];
                StudentSections objStudentSections = new StudentSections();
                objStudentSections.SectionID = Convert.ToInt64(drStudentSections["SectionID"]);
                objStudentSections.SectionName = Convert.ToString(drStudentSections["SectionName"]);
                objStudentSections.SessionID = Convert.ToInt64(drStudentSections["SessionID"]);
                objStudentSections.CreatedByID = Convert.ToInt64(drStudentSections["CreatedByID"]);
                objStudentSections.CreatedDateTime = Convert.ToDateTime(drStudentSections["CreatedDateTime"]);
                objStudentSections.LastUpdateDateTime = Convert.ToDateTime(drStudentSections["LastUpdateDateTime"]);
                objStudentSections.LastUpdateByID = Convert.ToInt64(drStudentSections["LastUpdateByID"]);
                objStudentSections.IsEnabled = Convert.ToBoolean(drStudentSections["IsEnabled"]);
                objStudentSections.Remarks = Convert.ToString(drStudentSections["Remarks"]);

                return objStudentSections;
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
    public Int64 InsertUpdateStudentSections()
    {
        try
        {
            //parameter setting
            comStudentSections.Parameters.AddWithValue("SectionID", intSectionID);
            comStudentSections.Parameters.AddWithValue("SectionName", strSectionName);
            comStudentSections.Parameters.AddWithValue("SessionID", intSessionID);
            comStudentSections.Parameters.AddWithValue("CreatedByID", intCreatedByID);
            comStudentSections.Parameters.AddWithValue("CreatedDateTime", datCreatedDateTime);
            comStudentSections.Parameters.AddWithValue("LastUpdateDateTime", datLastUpdateDateTime);
            comStudentSections.Parameters.AddWithValue("LastUpdateByID", intLastUpdateByID);
            comStudentSections.Parameters.AddWithValue("IsEnabled", blnIsEnabled);
            comStudentSections.Parameters.AddWithValue("Remarks", strRemarks);

            //end parameter setting

            ConnectAndExecute("StudentSectionsInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsStudentSections.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteStudentSections(Int64 intSectionID = 0)
    {
        try
        {
            string sp_name = "StudentSectionsDeleteAll";
            if (intSectionID != 0)
            {
                comStudentSections.Parameters.AddWithValue("SectionID", intSectionID);
                sp_name = "StudentSectionsDeleteByID";
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
            string sp_name = "StudentSectionsTruncate";
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