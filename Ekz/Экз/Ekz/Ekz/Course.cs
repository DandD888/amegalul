using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz
{
    class Course
    {
        public int id;
        public string Name;
        public int kkal;
        public int prise;
        public Course()
        {

        }
        public Course(int id)
        {
            string st = WorkFile.ReadLine(id);
            string[] ss = st.Split(';');
            id = Convert.ToInt32(ss[0]);
            Name = ss[1];
            kkal = Convert.ToInt32(ss[2]);
            prise = Convert.ToInt32(ss[3]);
        }
        public void Save()
        {
            WorkFile.AddUpdate(id, Name, kkal, prise);
        }

    }
}
