using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bai1_buoi6.genericclass;
using static bai1_buoi6.Program;

namespace bai1_buoi6
{
    internal class Program:checkinput
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GenericList<student> students = new GenericList<student>();
            NhapSV(students);
            Console.WriteLine("nhap lua chon cua ban tu 1-3:");
            Console.WriteLine("1.hien thi danh sach sinh vien.");
            Console.WriteLine("2. tim vi tri sinh vien trong danh sach.");
            Console.WriteLine("3.xoa sinh vien khoi danh sach.");
            int chon = Convert.ToInt32(Console.ReadLine());
            switch(chon)
            {
                case 1:
                    Console.WriteLine("danh sach sinh vien:");
                    for (int i = 0;i < 3; i++) {
                        student student = students.Get(i);
                        Console.WriteLine($"Ten: {student.Name}, Tuoi: {student.Age}");
                    }; break;
                case 2:
                    Console.WriteLine("Nhập tên sinh viên cần tìm :");
                    string TenSvCanTim;
                    bool check;
                    do
                    {
                        TenSvCanTim = Console.ReadLine();
                        if (CheckContainSpecialChar(TenSvCanTim) || CheckIsNullOrWhiteSpace(TenSvCanTim))
                        {
                            check = false;
                        }
                        else check = true;
                    } while (!check);
                    int Dem=0;
                    student sterm = students.Get(0); ;
                    for ( int i = 0; i < TongSV; i++)
                    {
                            sterm = students.Get(i);
                        if (sterm.Name == TenSvCanTim) { Dem++; }
                    }
                   if (Dem == 0) { Console.WriteLine("Không tìm thấy tên sinh viên vừa nhập"); }
                    else {
                        Console.WriteLine($"Vi tri cua sinh vien {sterm.Name} trong danh sach: {students.IndexOf(sterm)}");
                    }
                    break;
                case 3:
                    Student student3 = students.Get(0);
                   
                    students.Remove(student3);
                    Console.WriteLine($"Da xoa sinh vien {student3.Name} khoi danh sach."); break;
                default:
                    Console.WriteLine("Ban nhap khong trong lua chon");
                    break;
            }
            Console.ReadKey();
        }
    }
}
