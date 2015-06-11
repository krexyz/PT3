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
        protected string _name;
        protected int _classID;

        protected EPrivelage _privelage;
        #endregion

        #region properties
        public int userID { get { return _userID; } }
        public EPrivelage privelage { get { return _privelage; } }
        
        public string username 
        {
            get { return _username; } 
            set { _username = value; } 
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int classID
        {
            get { return _classID; }
            set { _classID = value; }
        }
        #endregion

        public User()
        {
            _userID = 0;
        }

        public User(string username)
        {
            _username = username;
        }

        #region methods
        public int login(string password)
        {
            DataDataContext data = new DataDataContext();
            var login = from a in data.usernames
                        where (a.username1 == _username && a.password == password)
                        select a;

            if (login.Count() > 0)
            {
                _userID = (int)login.First().userID;
                _privelage = (EPrivelage)login.First().privilage;

                return _userID;
            }
            
            return 0;
        }

        public bool isLoggedIn()
        {
            if (_userID > 0)
                return true;

            return false;
        }

        public virtual User getUser()
        {
            DataDataContext data = new DataDataContext();
            User user = null;

            if (_privelage == EPrivelage.Student)
            {
                user = new Student();
            }
            else if (_privelage == EPrivelage.Teacher)
            {
                user = new Teacher();
            }

            user = user.getUser(_userID);
            
            return user; 
        }

        public virtual User getUser(int userID)
        {
            throw new NotImplementedException();
        }

        public virtual void register(string password)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}