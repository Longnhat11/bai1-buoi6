using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai1_buoi6
{
    public class student
    {
        string name { set; get; }
        int Age { set; get; }
    }
    public class checkinput:genericclass
    {
        
        public static bool ContainsNumber(string input)
            {
                if (input.Any(char.IsDigit))
                {
                    Console.WriteLine("Không được chứa chữ số!");
                    return true;
                }
                else
                    return false;
            }
            public static bool CheckContainSpecialChar(string input)
            {
                Regex specialCharRegex = new Regex(@"[~`!@#$%^&*()+=|\\{}':;,.<>?/""-]");
                if (specialCharRegex.IsMatch(input))
                {
                    Console.WriteLine("Không được chứa kí tự đặc biệt!");
                    return true;
                }
                else
                    return false;
            }
            public static bool CheckIsNullOrWhiteSpace(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Không được để trống hay chỉ chứa khoảng trắng!");
                    return true;
                }
                else
                    return false;
            }
            public static bool CheckDateTime(string input)
            {
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    DateTime now = DateTime.Now;
                    TimeSpan interval = now - date;
                    if (interval.Days > 0)
                        return true;
                    else
                    {
                        Console.WriteLine("Ngày phát hành hóa đơn không được lớn hơn thời gian hiện tại!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Định dạng ngày không hợp lệ!");
                    return false;
                }
            }
            public static bool CheckAge(string input, out int money)
            {
                if (int.TryParse(input, out money))
                {
                    if (money <= 0)
                    {
                        Console.WriteLine("Số tiền không được bằng 0 hoặc là số âm!");
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    Console.WriteLine("Số tiền không được quá lớn, không được là kí tự, không để trống hay chứa khoảng trắng!");
                    return false;
                }
            }
        static GenericList<student> NhapSV( GenericList<student> students)
        {
            Console.WriteLine("nhap tong so sinh vien");
            student student1 = new student();
            int TongSV = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < TongSV; i++)
            {
                Console.WriteLine("Nhập thông tin sinh vien " + (i + 1));
                bool check;
                string TenSv;
                do
                {
                    Console.Write("Tên SV :");
                    TenSv = Console.ReadLine();
                    if (CheckContainSpecialChar(TenSv) || CheckIsNullOrWhiteSpace(TenSv))
                    {
                        check = false;
                    }
                    else check = true;
                } while (!check);
                student1.Name = TenSv;
                int TuoiSV;
                string Tuoi;
                do
                {
                    Console.Write("Tuổi của SV:");
                    Tuoi = Console.ReadLine();
                    if (CheckAge(Tuoi, out TuoiSV))
                        check = true;
                    else check = false;
                } while (!check);
                student1.Age = TuoiSV;
                students.Add(student1);
            }
            return students;
        }

    }
}

