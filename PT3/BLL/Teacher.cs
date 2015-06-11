using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;

namespace PT3.BLL
{
    public class Teacher : User
    {

        public override User getUser(int userID)
        {
            DataDataContext data = new DataDataContext();

            var ab = (from a in data.teachers
                     join b in data.usernames
                     on a.userID equals b.userID
                     where a.userID == _userID
                     select new { a, b }).First();

            _userID = userID;
            _username = ab.b.username1;
            _privelage = (EPrivelage)ab.b.privilage;
            _name = ab.a.name;

            return this;
        }
    }
}