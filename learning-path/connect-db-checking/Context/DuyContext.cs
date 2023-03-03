using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using connect_db_checking.Models;
using MySql.Data.MySqlClient;

namespace connect_db_checking.Context;

public class DuyContext
{
    public string? ConnectionString { get; set; }
    List<Student> list = new List<Student>();
    public DuyContext(string ConnectionString ){
        this.ConnectionString = ConnectionString;
    }

    private MySqlConnection GetConnection(){
        return new MySqlConnection(ConnectionString);
    }

    public MySqlDataReader GET_Reader(string query){
        MySqlConnection conn = GetConnection();
        MySqlCommand cmd = new MySqlCommand(query, conn);
        MySqlParameter param = cmd.CreateParameter();
        conn.Open();
        return cmd.ExecuteReader();
    }

    public List<Student> GetStudents(){
            MySqlDataReader reader = GET_Reader("SELECT * FROM student");
            while (reader.Read())
            {
                list.Add(new Student(
                    (int) reader.GetValue(0),
                reader.GetString("studentName"),
                    reader.GetDateTime("dob"),
                    reader.GetString("imageProfile")
                ));
            }
            return list;
        }

    public Student GetStudent(long id){
        MySqlDataReader reader = GET_Reader("SELECT * FROM student WHERE id = ?");
        return null;
    }
}
