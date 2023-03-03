using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace connect_db_checking.Models;

public class Student
{
    private int id;
    private string name { get; set; }
    private DateTime dob { get; set; }
    private string imageProfile { get; set; }

    public Student(int _id, string _name, DateTime _dob, string _imageProfile){
        id = _id;
        name = _name;
        dob = _dob;
        imageProfile = _imageProfile;
    }

    public override string ToString()
    {
        return "{"
         + "'id' : " + id + ","
         + "'name' : " + name + ","
         + "'dateOfBirth' : " + dob.ToShortDateString() + ","
         + "'imageProfileLocation' : " + imageProfile
         + "}\n"
         ;
    }
}
