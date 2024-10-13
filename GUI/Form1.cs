
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try

            {
                setGridViewStyle(dgvqlsv);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List< Faculty> listFacultys)
        { 
            listFacultys.Insert(0, new Faculty());
            this.comboBox1.DataSource = listFacultys;
            this.comboBox1.DisplayMember = "FacultyName";
            this.comboBox1.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvqlsv.Rows.Clear();
            foreach (var item in listStudent)
            {
            int index = dgvqlsv.Rows.Add();
                dgvqlsv.Rows[index].Cells[0].Value = item.StudentID;
                dgvqlsv.Rows[index].Cells[1].Value = item.FullName;
            if(item.Faculty!= null)
                dgvqlsv.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvqlsv.Rows[index].Cells[3].Value = item.AverageScore + "";
            if (item.MajorID != null)
                dgvqlsv.Rows[index].Cells[4].Value = item.Major.MajorName + "";

            }
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newStudent = new Student
                {
                    StudentID = textBox1.Text,
                    FullName = textBox2.Text,
                    AverageScore = float.Parse(textBox3.Text),
                    FacultyID = comboBox1.SelectedValue.ToString(),
                   
                };
                studentService.InsertUpdate(newStudent);
                MessageBox.Show("Thêm sinh viên thành công!");
                BindGrid(studentService.GetAll()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm sinh viên: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvqlsv.SelectedRows.Count > 0)
                {
                    
                    int studentID = int.Parse(dgvqlsv.SelectedRows[0].Cells[0].Value.ToString());

                    
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        studentService.Delete(studentID);

                        
                        MessageBox.Show("Xóa sinh viên thành công.");

                        
                        var listStudents = studentService.GetAll();
                        BindGrid(listStudents);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvqlsv.CurrentRow != null)
                {
                    var studentID = dgvqlsv.CurrentRow.Cells[0].Value.ToString();
                    var updatedStudent = new Student
                    {
                        StudentID = studentID,
                        FullName = textBox2.Text,
                        AverageScore = float.Parse(textBox3.Text),
                        FacultyID = comboBox1.SelectedValue.ToString(),

                    };
                    studentService.Update(updatedStudent);
                    MessageBox.Show("Cập nhật sinh viên thành công!");
                    BindGrid(studentService.GetAll()); 
                }
                else
                {
                    MessageBox.Show("Chọn sinh viên để sửa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi cập nhật sinh viên: " + ex.Message);
            }
        }

        private void dgvqlsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvqlsv.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
            }
        }

        private void cbdangki_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.cbdangki.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }
    }

}

