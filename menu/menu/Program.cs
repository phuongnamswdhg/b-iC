using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();

              

            }
            Console.WriteLine("Exit!");
            Console.ReadLine();
        }
        private static void menu()
        {
            Console.WriteLine("\t\t\t\t\tTra cứu từ điển ");
            Console.WriteLine("\t\t\t---------------------------------------------\n\n");
            Console.WriteLine("1:thêm hồ sơ sản phẩm ");
            Console.WriteLine("2: hiện thì hồ sơ sản phẩm ");
            Console.WriteLine("3: Xóa sản phẩm theo ID");
            Console.WriteLine("4: end");

            try
            
                {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        TraCuu();
                        break;
                    case 3:
                        XoaTu();
                        break;
                    case 4: Environment.Exit(0);
                            break;
                }
            }

            
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi gì đó : " + ex.Message);
            }
        }
        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập sản phẩm muốn xóa:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công sản phẩm [{0}]", ta);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm [{0}] để xóa", ta);
            }

        }
        private static void TraCuu()
        {
            Console.WriteLine("Mời bạn nhập tên sản phẩm :");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))

            {
                string tv = dic[ta];
                Console.WriteLine("sản phẩm [{0}] số lượng [{1}]", ta, tv);
            }
            else
            {
                Console.WriteLine("menu chưa có cập nhật [{0}]", ta);
            }
        }
       
        private static void TaoTuMoi()
        {
            Console.WriteLine("Mời bạn nhập tên sản phẩm:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("sản phẩm [{0}] đã có trong menu", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập sô lượng:");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }

        }
    }
}









   