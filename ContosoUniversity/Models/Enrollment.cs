namespace ContosoUniversity.Models
{
  public enum Grade
  {
    A, B, C, D, F
  }
  public class Enrollment
  {
    // this entity is using classnameID as the key
    // in Student we just used ID, typically you choose one and stick to it but this is a tutorial
    public int EnrollmentID { get; set; }
    public int CourseID { get; set; }
    // foreign key
    public int StudentID{ get; set; }
    // foreign key
    public Grade? Grade { get; set; }
    // ? after grade means it is a nullable property
    public Course Course { get; set; }
    public Student Student { get;  set; }
  }
}