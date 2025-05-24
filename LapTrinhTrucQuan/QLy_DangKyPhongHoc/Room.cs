using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLy_DangKyPhongHoc
{
    internal class Room
    {
        DateTime NgaySD;
        string CaSD;
        string MucDich;
        string NguoiDKi;
        long Ma;
        long SDT;

        public Room(DateTime ngaySD, string caSD, string mucDich, string nguoiDKi, long ma, long sDT)
        {
            NgaySD = ngaySD;
            CaSD = caSD;
            MucDich = mucDich;
            NguoiDKi = nguoiDKi;
            Ma = ma;
            SDT = sDT;
        }

        public DateTime NgaySD1 { get => NgaySD; set => NgaySD = value; }
        public string CaSD1 { get => CaSD; set => CaSD = value; }
        public string MucDich1 { get => MucDich; set => MucDich = value; }
        public string NguoiDKi1 { get => NguoiDKi; set => NguoiDKi = value; }
        public long Ma1 { get => Ma; set => Ma = value; }
        public long SDT1 { get => SDT; set => SDT = value; }
    }
}
