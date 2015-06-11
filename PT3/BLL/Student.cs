using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PT3.LINQ;

namespace PT3.BLL
{
    public class Student : User
    {
        string name;
        int classID;

        public override void register(string password)
        {
            _privelage = 1;
            DataDataContext data = new DataDataContext();

            PT3.LINQ.username user = new username();
            PT3.LINQ.student student = new student();

            user.username1 = username;
            user.password = password;
            user.privilage = privelage;

            student.name = name;

            data.usernames.InsertOnSubmit(user);
            data.students.InsertOnSubmit(student);

            data.SubmitChanges();
        }

        public void registerClass(int classID)
        {
            DataDataContext data = new DataDataContext();

            this.classID = classID;

            LINQ.student student = data.students.Single(q => q.userID == userID);
            student.classID = classID;

            data.SubmitChanges();
        }
    }
}