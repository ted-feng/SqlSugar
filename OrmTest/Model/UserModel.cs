using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Test.Model
{
    class UserModel
    {
        #region 字段
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private int archivedUserID;

        public int ArchivedUserID
        {
            get { return archivedUserID; }
            set { archivedUserID = value; }
        }
        private int createdUserID;

        public int CreatedUserID
        {
            get { return createdUserID; }
            set { createdUserID = value; }
        }
        private string userGroupID;

        public string UserGroupID
        {
            get { return userGroupID; }
            set { userGroupID = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string externalID;

        public string ExternalID
        {
            get { return externalID; }
            set { externalID = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime created;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }
        private string iSExpired;

        public string ISExpired
        {
            get { return iSExpired; }
            set { iSExpired = value; }
        }
        private string isLockedOut;

        public string IsLockedOut
        {
            get { return isLockedOut; }
            set { isLockedOut = value; }
        }
        private string isOnline;

        public string IsOnline
        {
            get { return isOnline; }
            set { isOnline = value; }
        }
        private DateTime? lastActivity;

        public DateTime? LastActivity
        {
            get { return lastActivity; }
            set { lastActivity = value; }
        }
        private DateTime? lastLogin;

        public DateTime? LastLogin
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        private string accountCode;

        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private string permissionID;

        public string PermissionID
        {
            get { return permissionID; }
            set { permissionID = value; }
        }

        private int userCategory;

        public int UserCategory
        {
            get { return userCategory; }
            set { userCategory = value; }
        }
        private string userBarCode;

        public string UserBarCode
        {
            get { return userBarCode; }
            set { userBarCode = value; }
        }
        private int isEnabled;

        public int IsEnabled
        {
            get { return isEnabled; }
            set { isEnabled = value; }
        }
        #endregion
    }
}
