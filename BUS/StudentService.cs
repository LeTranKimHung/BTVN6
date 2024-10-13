using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            StudentModel context = new StudentModel();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentModel context = new StudentModel();
            return context.Students.Where(p => p.MajorID == null && Convert.ToInt32(p.FacultyID) == facultyID).ToList();
        }

        public Student FindById(string studentId)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }

        public void InsertUpdate(Student s)
        {
            StudentModel context = new StudentModel();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }
        public Student FindById(int studentId)
        {
            StudentModel context = new StudentModel();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId.ToString());
        }

        
        
        public void Delete(int studentID)
        {
            using (StudentModel context = new StudentModel())
            {
                // Tìm sinh viên theo ID
                var student = context.Students.FirstOrDefault(s => s.StudentID == studentID.ToString());

                if (student != null)
                {
                    context.Students.Remove(student);  
                    context.SaveChanges();            
                }
                else
                {
                    throw new Exception("Không tim thấy sinh viên .");
                }
            }
        }
        public void Update(Student updatedStudent)
        {
            using (StudentModel context = new StudentModel())
            {
                // Tìm sinh viên theo StudentID
                var existingStudent = context.Students.FirstOrDefault(s => s.StudentID == updatedStudent.StudentID);
                if (existingStudent == null)
                {
                    throw new Exception("Sinh viên không tồn tại.");
                }

                // Cập nhật thông tin sinh viên
                existingStudent.FullName = updatedStudent.FullName;
                existingStudent.AverageScore = updatedStudent.AverageScore;
                existingStudent.FacultyID = updatedStudent.FacultyID;

                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
        }
    }
}
