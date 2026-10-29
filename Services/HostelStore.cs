using HostelManagementMVC.Models;
namespace HostelManagementMVC.Services;
public class HostelStore
{
    private readonly List<Student> _students = new();
    private int _nextId = 1;
    public List<Room> Rooms { get; } = new()
    {
        new Room { Number="101", Capacity=2, Type="Double Sharing", MonthlyFee=4500 },
        new Room { Number="102", Capacity=3, Type="Triple Sharing", MonthlyFee=3500 },
        new Room { Number="201", Capacity=2, Type="Double Sharing", MonthlyFee=4500 },
        new Room { Number="202", Capacity=1, Type="Single", MonthlyFee=6500 },
        new Room { Number="203", Capacity=3, Type="Triple Sharing", MonthlyFee=3500 }
    };
    public List<Student> Students => _students;
    public int Add(Student student) { student.Id = _nextId++; _students.Add(student); return student.Id; }
    public Student? Find(int id) => _students.FirstOrDefault(s => s.Id == id);
    public void Update(Student student) { var old = Find(student.Id); if (old == null) return; old.FullName=student.FullName; old.EnrollmentNo=student.EnrollmentNo; old.Email=student.Email; old.Phone=student.Phone; old.RoomNumber=student.RoomNumber; old.Semester=student.Semester; old.AdmissionDate=student.AdmissionDate; }
    public void Delete(int id) { var student = Find(id); if (student != null) _students.Remove(student); }
    public int Occupied(string room) => _students.Count(s => s.RoomNumber == room);
}
