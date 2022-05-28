//파일 입출력 연습


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//stream
//파일 네트워크등에서 데이터를 바이트 단위로 읽고 쓰는 클래스
//using System.IO를 선언해 줘야 한다
using System.IO;

//파일 입출력을 다루는 기본 클래스: FileStream
//byte[]로 데이터를 읽거나 저장함 ->형변환 요구됨

namespace day09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 23;
            float val2 = 16.06f;
            string str1 = "high low";
            //파일 쓰기(생성) 1
            var fs = new FileStream("test.txt", FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.WriteLine(val1);
            sw.WriteLine(val2);
            sw.WriteLine(str1);
            sw.Close();

            //파일 쓰기(생성) 2
            using (var sw2 = new StreamWriter(new FileStream("test2.txt", FileMode.Create)))
            {
                sw2.WriteLine(val1);
                sw2.WriteLine(val2);
                sw2.WriteLine(str1);
            }

            //파일 읽기
            var fs3 = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            var swrd = new StreamReader(fs3);
            int tempval = int.Parse(swrd.ReadLine());
            float tempval2 = float.Parse(swrd.ReadLine());
            string tempst = swrd.ReadLine();
            swrd.Close();
            Console.WriteLine("{0} {1} {2}", tempval, tempval2, tempst);
        }
    }
}
