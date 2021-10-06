using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07.Models
{
    public class Student
    {
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string Anh { get; set; }
    }

    public class StudentManager
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();

            students.Add(new Student { HoTen = "Nguyễn Tiến Nhật", Anh = "Assets/male-01.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Phạm Đức Duy", Anh = "Assets/male-02.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Nguyễn Văn Hùng", Anh = "Assets/male-03.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Trần Anh Đức", Anh = "Assets/female-01.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Đào Duy Thắng", Anh = "Assets/female-02.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Trần Mạnh Cường", Anh = "Assets/female-03.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Phùng Việt Hưng", Anh = "Assets/male-01.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Phùng Mạnh Quân", Anh = "Assets/male-02.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Nguyễn Đức Tiến", Anh = "Assets/male-03.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Nguyễn Minh Tú", Anh = "Assets/female-01.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Điều Huy Phúc", Anh = "Assets/female-02.png", NamSinh = "2002" });
            students.Add(new Student { HoTen = "Nguyễn Ngọc Thạch", Anh = "Assets/female-03.png", NamSinh = "2002" });
            
            return students;
        }
    }
}
