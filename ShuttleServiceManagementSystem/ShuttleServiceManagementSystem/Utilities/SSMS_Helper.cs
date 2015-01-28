﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShuttleServiceManagementSystem.Utilities
{
    public class SSMS_Helper
    {
        Database_Helper db = new Database_Helper();

        public bool IsValidLogin(string username, string password)
        {
            // Variable Declarations
            string query = "";
            string queryResult = "";

            // Create the database query to determine if the username/password combination exists
            query = "SELECT COUNT(*) FROM [SDSU_School].[Lucas].[USER_ACCOUNT_INFO] WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "'";

            // Run the query
            queryResult = db.ReturnSQLFirstValue(query);

            // Check the query result
            if (queryResult == null || queryResult == "" || queryResult == "0")
            {
                return false;
            }    
            else
            {
                return true;
            }
        }

        public string GetUserAccessLevel(string username)
        {
            // Variable Declarations
            string query = "";
            string queryResult = "";

            // Create the database query to determine if the username/password combination exists
            query = "SELECT ACCESS_LEVEL FROM [SDSU_School].[Lucas].[USER_ACCOUNT_INFO] WHERE USERNAME = '" + username + "'";

            // Run the query
            queryResult = db.ReturnSQLFirstValue(query);

            // Return the query result
            return queryResult;
        }
    }
}