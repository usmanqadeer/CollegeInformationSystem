using System;
using System.Collections.Generic;

public class CollageAdminController
{
    static CollageAdmin objCollageAdmin = new CollageAdmin();
    public static List<CollageAdmin> CollageAdminSelectAll()
    {
        return objCollageAdmin.CollageAdminSelectAll();
    }

    public static CollageAdmin CollageAdminSelectByID(Int32 intUserId)
    {
        return objCollageAdmin.CollageAdminSelectByID(intUserId);
    }

    public static Int64 InsertUpdateCollageAdmin(CollageAdmin objIUCollageAdmin)
    {
        Int64 new_id = objIUCollageAdmin.InsertUpdateCollageAdmin();
        return new_id;
    }

    public static void DeleteCollageAdmin(Int32 intUserId = 0)
    {
        objCollageAdmin.DeleteCollageAdmin(intUserId);
    }

    public static void Truncate()
    {
        objCollageAdmin.Truncate();
    }
    public static Int64 UserLogIn(string userName, string userPassword)
    {
        List<CollageAdmin> collageAdmins = CollageAdminController.CollageAdminSelectAll();
        foreach(CollageAdmin admin in collageAdmins)
        {
            if (admin.UserName == userName && admin.UserPassword == userPassword)
                return admin.UserId;
        }
        return 0;
    }
    public static string ActiveUserLogInInfo(int userID)
    {
        List<CollageAdmin> collageAdmins = CollageAdminController.CollageAdminSelectAll();
        foreach (CollageAdmin admin in collageAdmins)
        {
            if (admin.UserId == userID)
                return admin.UserPic;
        }
        return null;
    }

}