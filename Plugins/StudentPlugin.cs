using System;
using System.ComponentModel;
using System.Text.Json;
using EfFuncCallSK.Models;
using Microsoft.SemanticKernel;

namespace EfFuncCallSK.Plugins;

public class StudentPlugin
{
  [KernelFunction, Description("Get student details by first name and last name")]
  public static string? GetStudentDetails(
    [Description("student first name, e.g. Kim")]
    string firstName,
    [Description("student last name, e.g. Ash")]
    string lastName
  )
  {
    var db = Utils.GetDbContext();
    var studentDetails = db.Students
      .Where(s => s.FirstName == firstName && s.LastName == lastName).FirstOrDefault();
    if (studentDetails == null)
      return null;
    return studentDetails.ToString();
  }

  [KernelFunction, Description("Get students in a school given the school name")]
  public static string? GetStudentsBySchool(
    [Description("The school name, e.g. Nursing")]
    string school
  )
  {
    var studentsBySchool = Utils.GetDbContext().Students
      .Where(s => s.School == school).ToList();
    if (studentsBySchool.Count == 0)
      return null;
    return JsonSerializer.Serialize(studentsBySchool);
  }


  [KernelFunction, Description("Get the school with most or least students. Takes boolean argument with true for most and false for least.")]
  static public string? GetSchoolWithMostOrLeastStudents(
    [Description("isMost is a boolean argument with true for most and false for least. Default is true.")]
    bool isMost = true
  )
  {
    var students = Utils.GetDbContext().Students.ToList();
    IGrouping<string, Student>? schoolGroup = null;
    if (isMost)
      schoolGroup = students.GroupBy(s => s.School)
          .OrderByDescending(g => g.Count()).FirstOrDefault()!;
    else
      schoolGroup = students.GroupBy(s => s.School)
          .OrderBy(g => g.Count()).FirstOrDefault()!;
    if (schoolGroup != null)
      return $"{schoolGroup.Key} has {schoolGroup.Count()} students";
    else
      return null;
  }

  [KernelFunction, Description("Get students grouped by school.")]
  static public string? GetStudentsInSchool()
  {
    var students = Utils.GetDbContext().Students.ToList().GroupBy(s => s.School)
      .OrderByDescending(g => g.Count());
    if (students == null)
      return null;
    else
      return JsonSerializer.Serialize(students);
  }

  [KernelFunction, Description("Get the older students by a specified limit.")]
  static public string? GetOlderStudents(
    [Description("age is the age limit to filter students by.")]
    int age
  )
  {
    // DateOfBirth is a DateTime object (nullable) — ensure it's present before accessing Value
    var students = Utils.GetDbContext().Students
      .Where(s => s.DateOfBirth.HasValue && DateTime.Now.Year - s.DateOfBirth.Value.Year > age).ToList();

    return JsonSerializer.Serialize(students);
  }

  [KernelFunction, Description("Get the younger students by a specified limit.")]
  static public string? GetYoungerStudents(
    [Description("age is the age limit to filter students by.")]
    int age
  )
  {
    // DateOfBirth is a DateTime object (nullable) — ensure it's present before accessing Value
    var students = Utils.GetDbContext().Students
      .Where(s => s.DateOfBirth.HasValue && DateTime.Now.Year - s.DateOfBirth.Value.Year < age).ToList();

    return JsonSerializer.Serialize(students);
  }

  [KernelFunction, Description("Get students that in the next x months")]
  static public string? GetStudentsBirthdayUpcomingMonths(
    [Description("month is amount of months from the current month to filter students by.")]
    int month
  )
  {
    // DateOfBirth is a DateTime object (nullable) — ensure it's present before accessing Value
    var students = Utils.GetDbContext().Students
      .Where(s => s.DateOfBirth.HasValue &&
        (s.DateOfBirth.Value.Month >= DateTime.Now.Month) &&
        (s.DateOfBirth.Value.Month <= DateTime.Now.Month + month)).ToList();

    return JsonSerializer.Serialize(students);
  }

  [KernelFunction, Description("Get students that in the next x months")]
  static public string? GetStudentsInCertainMonth(
    [Description("month is the month to filter students by.")]
    int month
  )
  {
    // DateOfBirth is a DateTime object (nullable) — ensure it's present before accessing Value
    var students = Utils.GetDbContext().Students
      .Where(s => s.DateOfBirth.HasValue && s.DateOfBirth.Value.Month == month).ToList();

    return JsonSerializer.Serialize(students);
  }
}
