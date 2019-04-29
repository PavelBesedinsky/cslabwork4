using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LINQ
{
    class LINQsys
    {
        int[] _arr;
        public int Length { get; set; }
        public LINQsys(int lenD, Action<int[]> dOp)
        {
            Length = lenD;
            _arr = new int[lenD];
            dOp(_arr);
        }

        public int this[int indx]
        {
            get
            {
                return _arr[indx];
            }
            set
            {
                _arr[indx] = value;
            }
        }

        public IEnumerable<int> findEven()
        {
            return _arr.Where(p => p % 2 == 0).ToArray().OrderBy(i => i); ;
        }

        public IEnumerable<int> findOdd()
        {
            return _arr.Where(p => p % 2 != 0).ToArray().OrderBy(i => i); ;
        }

        public IEnumerable<int> findSumFLEqSix()
        {
            return _arr.Where(p =>
            {
                int n = Math.Abs(p);
                int first = default(int);
                int last = n % 10;
                while(n != 0)
                {
                    first = n % 10;
                    n /= 10;
                }
                return (first + last == 6)?true:false;
            }).ToArray().OrderBy(i => i); ;
        }

        public IEnumerable<int> findSixSix()
        {
            return _arr.Where(p =>
            {
                string str = p.ToString();
                return (str.Contains("666")) ? true : false;
            }).ToArray().OrderBy(i => i);
        }

        public ParallelQuery<int> findEvenAsParallel()
        {
            return _arr.AsParallel().Where(p => p % 2 == 0).OrderBy(i => i);
        }

        public ParallelQuery<int> findOddAsParallel()
        {
            return _arr.AsParallel().Where(p => p % 2 != 0).OrderBy(i => i);
        }

        public ParallelQuery<int> findSumFLEqSixAsParallel()
        {
            return _arr.AsParallel().Where(p =>
            {
                int n = Math.Abs(p);
                int first = default(int);
                int last = n % 10;
                while (n != 0)
                {
                    first = n % 10;
                    n /= 10;
                }
                return (first + last == 6) ? true : false;
            }).OrderBy(i => i); ;
        }

        public ParallelQuery<int> findSixSixAsParallel()
        {
            return _arr.AsParallel().Where(p =>
            {
                string str = p.ToString();
                return (str.Contains("666")) ? true : false;
            }).OrderBy(i => i); ;
        }
    }
}
