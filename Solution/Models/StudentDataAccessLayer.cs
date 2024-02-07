using System;
using System.Data.SqlClient;
using MVC.Models;
using System.Data;
public class StudentDataAccessLayer
{


    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentRecordSystem;Integrated Security=True;";

    public IEnumerable<Student> GetAllStudent()
    {

        List <Student> students= new List<Student>();

        SqlConnection conn = new SqlConnection(connectionString);
        
        SqlCommand cmd = new SqlCommand(" SELECT * FROM StudentRecord ", conn);
        conn.Open();
        cmd.CommandType = CommandType.Text;

        SqlDataReader rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            Student student = new Student();

            student.Id = Convert.ToInt32(rdr["Id"]);
            student.FirstName = rdr["FirstName"].ToString();
            student.LastName = rdr["LastName"].ToString();
            student.Email = rdr["Email"].ToString();
            student.Address = rdr["Address"].ToString();
            students.Add(student);

        }
        conn.Close();

      


        return students;


    }

    public void AddStudent(Student student)
    {
        using(SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_AddStudent",con)
                cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("")
        }
    }
}
