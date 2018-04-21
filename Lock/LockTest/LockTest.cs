using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockTest
{
    public class LockTest<T>
    {
        private IList<T> list;
        /// <summary>
        /// 构建锁
        /// </summary>
        private Object locker = new Object();
        public LockTest()
        {
            this.list = new List<T>();


        }
        public void Add(T t)
        {

            lock (locker)
            {

                list.Add(t);
            }
        }

        public int Remove(T t)
        {
            if (list.Contains<T>(t))
            {
                lock (locker)
                {
                    list.Remove(t);
                }
                return 1;
            }
            else
            {
                return -1;
            }

        }

    }
}
