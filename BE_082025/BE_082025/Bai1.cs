using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_082025
{
    public class Bai1
    {
        /// <summary>
        /// Hàm này để chào user khi chương trình bắt đầu
        /// </summary>
        /// <param name="tenUser">Lấy userName của user</param>
        /// <param name="rankUser">lấy rank của user</param>
        public void loiChaoBatDauChuongTrinh(string tenUser, string rankUser)
        {
            Console.WriteLine("Xin chao [{0}] {1}!", rankUser, tenUser);
        }

        public void tongCuaHaiSo(int sothu1, int sothu2)
        {
            Console.Write($"Tong cua 2 so la {sothu1 + sothu2} ");
        }
    }
}
