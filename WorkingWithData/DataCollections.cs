using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithData
{
    class DataCollections : IComparable
    {

        public int Info = 0;

        // methods to teest for collectionss

        protected internal ArrayList ArrLists()
        {
            // get some randome object add it 
            ArrayList arrList = new ArrayList();

            arrList.Add(new DataCollections() { Info = 6});
            arrList.Add(new Person() { FirstName = "Chuck" });
            arrList.Add(new DataCollections() { Info = 2 });
            return arrList;
        }

        protected internal Hashtable Htable() 
        {
            Hashtable htable = new Hashtable();
            htable.Add(1, "Chuck");
            htable.Add("kang", 1234);
            htable.Add(5, "SOME VALUE");
            
            return htable;
        }

        protected internal Queue QTable()
        {
            Queue qtable = new Queue();

            return qtable;
        }


        public int CompareTo(object obj)
        {
            
            DataCollections objData = obj as DataCollections;
            return this.Info.CompareTo(objData.Info);
        }
        

    }
}
