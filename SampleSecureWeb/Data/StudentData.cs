using System;
using System.Reflection.Metadata;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Data;

public class StudentData : IStudent
{
    private readonly ApplicationDbContext _db;

    public StudentData(ApplicationDbContext db)
    {
        _db = db;
    }
    public Student AddStudent(Student student)
    {
        try
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return student;
        }
        catch (System.Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteStudent(string nim)
    {
        throw new NotImplementedException();
    }

    public Student GetStudent(string nim)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetStudents()
    {
        var students = _db.Students.OrderBy(s => s.FullName);
        return students;
    }

    public Student UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}
