using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World");
            Bai1 bai1 = new Bai1();
            bai1.loiChaoBatDauChuongTrinh("Phan Gia Huy", "VIP");

            Console.WriteLine("Nhap so thu nhat : ");
            var inputData = Console.ReadLine();
            var isNumberic = int.TryParse(inputData, out int n);
            if (inputData == null || isNumberic == false)
            {
                Console.WriteLine("Vui long nhap so nguyen!");
            }
            else
            {
                var sothunhat = int.Parse(inputData);
                Console.WriteLine("Nhap so thu hai :");
                inputData = Console.ReadLine();
                isNumberic = int.TryParse(inputData, out int m);
                if (inputData == null || isNumberic == false)
                {
                    Console.WriteLine("Vui long nhap so nguyen!");
                }
                else
                {
                    var sothuhai = int.Parse(inputData);
                    bai1.tongCuaHaiSo(sothunhat, sothuhai);
                }

            }

            Console.ReadKey();
        }
    }
}
