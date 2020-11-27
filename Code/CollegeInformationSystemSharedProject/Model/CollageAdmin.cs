using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

public class CollageAdmin
{
    List<CollageAdmin> CollageAdminList = new List<CollageAdmin>();
    //Database Variables///////////////////////////////////////////////////////////////////////
    string connection_string = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    SqlConnection conCollageAdmin;
    SqlCommand comCollageAdmin;
    SqlDataAdapter daCollageAdmin;
    DataSet dsCollageAdmin;
    int intRecords;
    ///////////////////////////////////////////////////////////////////////////////////////////

    public CollageAdmin()
    {
        conCollageAdmin = new SqlConnection(connection_string);
        comCollageAdmin = new SqlCommand();
        daCollageAdmin = new SqlDataAdapter();
        dsCollageAdmin = new DataSet();
    }
    //Private Variables////////////////////////////////////////////////////////////////////////

    Int64 intUserId;
    string strUserName;
    string strUserPassword;
    string strUserEmail;
    string strUserRole;
    string strUserContectNo;
    string strUserCNIC;
    int intAddedById;
    DateTime datAddedByDateTime;
    bool blnUserIsEnabled;
    DateTime datLastEnableDateTime;
    string strRemarks;
    string strUserPic;

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Public Properties////////////////////////////////////////////////////////////////////////
    public Int64 UserId
    {
        get
        {
            return intUserId;
        }
        set
        {
            intUserId = value;
        }
    }
    public string UserName
    {
        get
        {
            return strUserName;
        }
        set
        {
            strUserName = value;
        }
    }
    public string UserPassword
    {
        get
        {
            return strUserPassword;
        }
        set
        {
            strUserPassword = value;
        }
    }
    public string UserEmail
    {
        get
        {
            return strUserEmail;
        }
        set
        {
            strUserEmail = value;
        }
    }
    public string UserRole
    {
        get
        {
            return strUserRole;
        }
        set
        {
            strUserRole = value;
        }
    }
    public string UserContectNo
    {
        get
        {
            return strUserContectNo;
        }
        set
        {
            strUserContectNo = value;
        }
    }
    public string UserCNIC
    {
        get
        {
            return strUserCNIC;
        }
        set
        {
            strUserCNIC = value;
        }
    }
    public int AddedById
    {
        get
        {
            return intAddedById;
        }
        set
        {
            intAddedById = value;
        }
    }
    public DateTime AddedByDateTime
    {
        get
        {
            return datAddedByDateTime;
        }
        set
        {
            datAddedByDateTime = value;
        }
    }
    public bool UserIsEnabled
    {
        get
        {
            return blnUserIsEnabled;
        }
        set
        {
            blnUserIsEnabled = value;
        }
    }
    public DateTime LastEnableDateTime
    {
        get
        {
            return datLastEnableDateTime;
        }
        set
        {
            datLastEnableDateTime = value;
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
    public string UserPic
    {
        get
        {
            return strUserPic;
        }
        set
        {
            strUserPic = value;
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////

    //Private Methods///////////////////////////////////////////////////////////////////////////

    //DB to Model//	
    private void GenerateModelList()
    {
        CollageAdminList.Clear();
        foreach (DataRow drCollageAdmin in dsCollageAdmin.Tables[0].Rows)
        {
            CollageAdmin objCollageAdmin = new CollageAdmin();
            objCollageAdmin.UserId = Convert.ToInt64(drCollageAdmin["UserId"]);
            objCollageAdmin.UserName = Convert.ToString(drCollageAdmin["UserName"]);
            objCollageAdmin.UserPassword = Convert.ToString(drCollageAdmin["UserPassword"]);
            objCollageAdmin.UserEmail = Convert.ToString(drCollageAdmin["UserEmail"]);
            objCollageAdmin.UserRole = Convert.ToString(drCollageAdmin["UserRole"]);
            objCollageAdmin.UserContectNo = Convert.ToString(drCollageAdmin["UserContectNo"]);
            objCollageAdmin.UserCNIC = Convert.ToString(drCollageAdmin["UserCNIC"]);
            objCollageAdmin.AddedById = Convert.ToInt32(drCollageAdmin["AddedById"]);
            objCollageAdmin.AddedByDateTime = Convert.ToDateTime(drCollageAdmin["AddedByDateTime"]);
            objCollageAdmin.UserIsEnabled = Convert.ToBoolean(drCollageAdmin["UserIsEnabled"]);
            objCollageAdmin.LastEnableDateTime = Convert.ToDateTime(drCollageAdmin["LastEnableDateTime"]);
            objCollageAdmin.Remarks = Convert.ToString(drCollageAdmin["Remarks"]);
            objCollageAdmin.UserPic = Convert.ToString(drCollageAdmin["UserPic"]);

            CollageAdminList.Add(objCollageAdmin);
        }
    }

    /// <summary>
    /// This function connect to database and execute the given stored procedure with command object
    /// </summary>
    /// <param name="strCommandText">Stored Procedure name</param>
    private void ConnectAndExecute(string strCommandText)
    {
        dsCollageAdmin.Clear();
        conCollageAdmin.Open();
        comCollageAdmin.Connection = conCollageAdmin;
        comCollageAdmin.CommandText = strCommandText;

        comCollageAdmin.CommandType = CommandType.StoredProcedure;
        daCollageAdmin.SelectCommand = comCollageAdmin;
        daCollageAdmin.Fill(dsCollageAdmin);
        conCollageAdmin.Close();
    }

    /// <summary>
    /// This function will perform "Selection" operation on database. If primary key value provied then it will return specific record else returns all records of table
    /// </summary>
    /// <param name="primary key">Optional primary key for spacific record</param>
    /// <return>Retrived record from database</return>
    public List<CollageAdmin> CollageAdminSelectAll()
    {
        try
        {
            string sp_name = "CollageAdminSelectAll";
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            GenerateModelList();
            return CollageAdminList;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return null;
        }//end try
    }//end function

    public CollageAdmin CollageAdminSelectByID(int intUserId)
    {
        try
        {
            string sp_name = "CollageAdminSelectByID";
            comCollageAdmin.Parameters.AddWithValue("UserId", intUserId);
            ConnectAndExecute(sp_name); //no parameter will send to stored procedure
            if (dsCollageAdmin.Tables[0].Rows.Count == 1)
            {
                DataRow drCollageAdmin = dsCollageAdmin.Tables[0].Rows[0];
                CollageAdmin objCollageAdmin = new CollageAdmin();
                objCollageAdmin.UserId = Convert.ToInt64(drCollageAdmin["UserId"]);
                objCollageAdmin.UserName = Convert.ToString(drCollageAdmin["UserName"]);
                objCollageAdmin.UserPassword = Convert.ToString(drCollageAdmin["UserPassword"]);
                objCollageAdmin.UserEmail = Convert.ToString(drCollageAdmin["UserEmail"]);
                objCollageAdmin.UserRole = Convert.ToString(drCollageAdmin["UserRole"]);
                objCollageAdmin.UserContectNo = Convert.ToString(drCollageAdmin["UserContectNo"]);
                objCollageAdmin.UserCNIC = Convert.ToString(drCollageAdmin["UserCNIC"]);
                objCollageAdmin.AddedById = Convert.ToInt32(drCollageAdmin["AddedById"]);
                objCollageAdmin.AddedByDateTime = Convert.ToDateTime(drCollageAdmin["AddedByDateTime"]);
                objCollageAdmin.UserIsEnabled = Convert.ToBoolean(drCollageAdmin["UserIsEnabled"]);
                objCollageAdmin.LastEnableDateTime = Convert.ToDateTime(drCollageAdmin["LastEnableDateTime"]);
                objCollageAdmin.Remarks = Convert.ToString(drCollageAdmin["Remarks"]);
                objCollageAdmin.UserPic = Convert.ToString(drCollageAdmin["UserPic"]);

                return objCollageAdmin;
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
    public Int64 InsertUpdateCollageAdmin()
    {
        try
        {
            //parameter setting
            comCollageAdmin.Parameters.AddWithValue("UserId", intUserId);
            comCollageAdmin.Parameters.AddWithValue("UserName", strUserName);
            comCollageAdmin.Parameters.AddWithValue("UserPassword", strUserPassword);
            comCollageAdmin.Parameters.AddWithValue("UserEmail", strUserEmail);
            comCollageAdmin.Parameters.AddWithValue("UserRole", strUserRole);
            comCollageAdmin.Parameters.AddWithValue("UserContectNo", strUserContectNo);
            comCollageAdmin.Parameters.AddWithValue("UserCNIC", strUserCNIC);
            comCollageAdmin.Parameters.AddWithValue("AddedById", intAddedById);
            comCollageAdmin.Parameters.AddWithValue("AddedByDateTime", datAddedByDateTime);
            comCollageAdmin.Parameters.AddWithValue("UserIsEnabled", blnUserIsEnabled);
            comCollageAdmin.Parameters.AddWithValue("LastEnableDateTime", datLastEnableDateTime);
            comCollageAdmin.Parameters.AddWithValue("Remarks", strRemarks);
            comCollageAdmin.Parameters.AddWithValue("UserPic", strUserPic);

            //end parameter setting

            ConnectAndExecute("CollageAdminInsertUpdate");
            Int64 record_id = Convert.ToInt64(dsCollageAdmin.Tables[0].Rows[0][0]);
            return record_id;
        }
        catch (Exception ex)
        {
            SetError(ex.Message);
            return 0;
        }
    }

    public void DeleteCollageAdmin(Int64 intUserId = 0)
    {
        try
        {
            string sp_name = "CollageAdminDeleteAll";
            if (intUserId != 0)
            {
                comCollageAdmin.Parameters.AddWithValue("UserId", intUserId);
                sp_name = "CollageAdminDeleteByID";
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
            string sp_name = "CollageAdminTruncate";
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