using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;

namespace PT3.BLL
{
    public class User
    {
        #region declaration
        protected int _userID;
        protected string _username;
        protected int _privelage;
        #endregion

        #region properties
        public int userID { get { return _userID; } }
        public int privelage { get { return _privelage; } }
        public string username 
        { 
            get { return _username; } 
            set { _username = value; } 
        }
        #endregion

        public User()
        {

        }

        public User(string username)
        {
            _username = username;
        }

        #region methods
        public bool login(string password)
        {
            DataDataContext data = new DataDataContext();
            var login = from a in data.usernames
                        where (a.username1 == _username && a.password == password)
                        select a;

            if (login.Count() > 0)
            {
                _userID = (int)login.First().userID;
                _privelage = (int)login.First().privilage;
                return true;
            }
            
            return false;
        }

        public void register(string password)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}