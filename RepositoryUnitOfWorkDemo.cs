using System;
using System.Collections.Generic;
using System.Linq;

// ==========================================
// IRepository<T>
// ==========================================

public interface IRepository<T>
{
    IEnumerable<T> GetAll();
    T? GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}


// ==========================================
// Student
// ==========================================

public class RepositoryStudent
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}


// ==========================================
// Course
// ==========================================

public class RepositoryCourse
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}


// ==========================================
// StudentRepository
// ==========================================

public class StudentRepository : IRepository<RepositoryStudent>
{
    private readonly List<RepositoryStudent> students =
        new List<RepositoryStudent>();

    public IEnumerable<RepositoryStudent> GetAll()
    {
        return students;
    }

    public RepositoryStudent? GetById(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public void Add(RepositoryStudent student)
    {
        students.Add(student);
    }

    public void Update(RepositoryStudent student)
    {
        RepositoryStudent? existing =
            GetById(student.Id);

        if (existing != null)
        {
            existing.Name = student.Name;
        }
    }

    public void Delete(int id)
    {
        RepositoryStudent? student = GetById(id);

        if (student != null)
        {
            students.Remove(student);
        }
    }
}


// ==========================================
// CourseRepository
// ==========================================

public class CourseRepository : IRepository<RepositoryCourse>
{
    private readonly List<RepositoryCourse> courses =
        new List<RepositoryCourse>();

    public IEnumerable<RepositoryCourse> GetAll()
    {
        return courses;
    }

    public RepositoryCourse? GetById(int id)
    {
        return courses.FirstOrDefault(c => c.Id == id);
    }

    public void Add(RepositoryCourse course)
    {
        courses.Add(course);
    }

    public void Update(RepositoryCourse course)
    {
        RepositoryCourse? existing =
            GetById(course.Id);

        if (existing != null)
        {
            existing.Name = course.Name;
        }
    }

    public void Delete(int id)
    {
        RepositoryCourse? course = GetById(id);

        if (course != null)
        {
            courses.Remove(course);
        }
    }
}


// ==========================================
// IUnitOfWork
// ==========================================

public interface IUnitOfWork
{
    IRepository<RepositoryStudent> Students { get; }
    IRepository<RepositoryCourse> Courses { get; }

    void Save();
}


// ==========================================
// UnitOfWork
// ==========================================

public class UnitOfWork : IUnitOfWork
{
    public IRepository<RepositoryStudent> Students { get; }

    public IRepository<RepositoryCourse> Courses { get; }

    public UnitOfWork()
    {
        Students = new StudentRepository();
        Courses = new CourseRepository();
    }

    public void Save()
    {
        Console.WriteLine("Changes saved successfully.");
    }
}