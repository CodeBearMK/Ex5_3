using System.Collections;

namespace Ex5_3
{
    class Program
    {

        public struct Phonebook
        {
            public string Name;
            public bool Sex;
            public string Tel;
        }

        static void Main(string[] args)
        {
            ArrayList aryList = new ArrayList();
            Phonebook pb;

            pb.Name = "陳榮元";
            pb.Sex = true;
            pb.Tel = "0928001090";
            aryList.Add(pb);

            pb.Name = "丁茂山";
            pb.Sex = true;
            pb.Tel = "0945191002";
            aryList.Add(pb);

            pb.Name = "何莉莉";
            pb.Sex = false;
            pb.Tel = "0911550911";
            aryList.Add(pb);

            Console.WriteLine("      === 通訊錄 ===      ");
            Console.WriteLine("\n");
            Console.WriteLine("姓名\t性別\t電話");
            Console.WriteLine("----\t----\t----");
            foreach (Phonebook p in aryList)
            {
                if (p.Sex == true)
                {
                    Console.Write("{0}\t男\t{1}", p.Name, p.Tel);
                }
                else
                {
                    Console.Write("{0}\t女\t{1}", p.Name, p.Tel);
                }
                Console.WriteLine("\n");
            }
            Console.Read();
        }
    }
}