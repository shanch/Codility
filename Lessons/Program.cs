using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(",", solution(null, 0)));
            Console.WriteLine(string.Join(",", solution(new int[] { }, 0)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 0)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 1)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 2)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 3)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 4)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 5)));
            Console.WriteLine(string.Join(",", solution(new int[] { 3, 8, 9, 7, 6 }, 6)));
            Console.WriteLine(string.Join(",", solution(new int[] { 0, 0, 0 }, 1)));
            Console.WriteLine(string.Join(",", solution(new int[] { 1, 2, 3, 4 }, 4)));
            //Divide(@"E:\MAT_Project\権利者関連\Result\2017\EnhancedChangedApplicantData.csv", 3, true);
        }

        static int[] solution(int[] A, int K)
        {
            if (A == null || A.Length == 0) return A;

            var result = new int[A.Length];

            int startIndex = A.Length - K % A.Length;

            for(int i=0; i<result.Length; i++)
            {
                result[i] = A[(startIndex + i) % A.Length];
            }

            return result;
        }

        private static void AddDoubleQuatations()
        {
            TextFieldParser parser = new TextFieldParser(@"C:\Users\U0124917\Desktop\JP2001289149A\エンハンス前\A1019_ENG_8_01289149_10_par_00_000_00_BB_0.csv", System.Text.Encoding.GetEncoding("shift_jis"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            string[] column = null;

            using (var writer = new StreamWriter(@"C:\Users\U0124917\Desktop\JP2001289149A\エンハンス前\A1019_ENG_8_01289149_10_par_00_000_00_BB_0new.csv", false, System.Text.Encoding.GetEncoding("shift_jis")))
            {
                while (parser.EndOfData == false)
                {
                    column = parser.ReadFields();

                    writer.WriteLine("\"{0}\",\"{1}\"", column[0], column[1]);
                }
            }
        }

        private static void Divide(string orgFile, int numberOfDivision, bool addHeaderEachFile)
        {
            string[] lines = File.ReadAllLines(orgFile, Encoding.GetEncoding("utf-8"));

            int maxLine = (int)Math.Ceiling((double)lines.Length / numberOfDivision);

            int fileCnt = 0;
            int lineCnt = 0;
            StreamWriter sw = null;

            foreach (string line in lines)
            {
                if (sw == null || lineCnt >= maxLine)
                {
                    fileCnt++;

                    if (sw != null)
                    {
                        sw.Close();
                    }

                    string fileName = Path.GetFileNameWithoutExtension(orgFile) + "_" + fileCnt + Path.GetExtension(orgFile);

                    string newFile = Path.Combine(Path.GetDirectoryName(orgFile), fileName);

                    sw = new StreamWriter(newFile, false, Encoding.GetEncoding("utf-8"));

                    if (addHeaderEachFile)
                    {
                        sw.WriteLine(lines[0]);
                    }

                    lineCnt = 0;
                }

                sw.WriteLine(line);

                lineCnt++;
            }

            if (sw != null)
            {
                sw.Close();
            }

        }

    }
}
