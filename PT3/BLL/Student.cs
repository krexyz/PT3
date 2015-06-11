using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;

namespace PT3.BLL
{
    public class Student : User
    {
        

        public override void register(string password)
        {
            _privelage = EPrivelage.Student;
            DataDataContext data = new DataDataContext();

            PT3.LINQ.username user = new username();
            PT3.LINQ.student student = new student();

            user.username1 = username;
            user.password = password;
            user.privilage = (int)privelage;

            student.name = _name;

            data.usernames.InsertOnSubmit(user);
            data.students.InsertOnSubmit(student);

            data.SubmitChanges();

            _userID = user.userID;
        }

        public void registerClass(int classID)
        {
            DataDataContext data = new DataDataContext();

            _classID = classID;

            LINQ.student student = data.students.Single(q => q.userID == _userID);
            student.classID = classID;

            data.SubmitChanges();
        }

        public override User getUser(int userID)
        {
            DataDataContext data = new DataDataContext();

            var ab = (from a in data.students
                     join b in data.usernames
                     on a.userID equals b.userID
                     where a.userID == userID
                     select new { a, b }).First();

            _userID = userID;
            _username = ab.b.username1;
            _privelage = (EPrivelage)ab.b.privilage;
            _name = ab.a.name;
            _classID = ab.a.classID;

            return this;
        }
    }
}