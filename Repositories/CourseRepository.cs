using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using InzynierkaApi.Context;
using InzynierkaApi.Models;

namespace InzynierkaApi.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AttendanceContext context;

    public CourseRepository(AttendanceContext context)
    {
        this.context = context;
    }

    public ICollection<CourseModel> GetCourses()
    {
        return context.Courses.ToList();
    }

    public CourseModel GetCourseById(int id)
    {
        return context.Courses.Find(id);
    }

    public ICollection<CourseModel> GetByDate(DateTime date)
    {
        return context.Courses.Where(course => course.DateOfClass == date).ToList();
    }

    public void InsertCourse(CourseModel course)
    {
        context.Courses.Add(course);
    }

    public void UpdateCourse(CourseModel course)
    {
        context.Courses.Update(course);
    }

    public void DeleteCourse(int id)
    {
        CourseModel course = context.Courses.Find(id);
        context.Courses.Remove(course);
    }

    public void Save()
    {
        context.SaveChanges();
    }
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }


}