using System;

namespace Task3
{
    class Array
    {
        private int count;
        private int[] _array;


        public Array() { }


        public Array(int count)
        {
            this.count = count;
            _array = new int[count];
        }

        public int GetCount
        {
            get
            {
                return count;
            }
            set
            {
                if (count > 0)
                {
                    count = value;
                }
                else
                {
                    count = 0;
                }
            }
        }

        public int this[int i]
        {
            get
            {
                if (i < count && i >= 0)
                {
                    return _array[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (i < count && i >= 0)
                {
                    _array[i] = value;
                }
                else
                {
                    _array[i] = 0;
                }
            }
        }

        public void DisplayArray()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(_array[i] + " ");
            }
        }

        public static Array operator +(Array A, Array B)
        {
            if (A.count == B.count)
            {
                Array C = new Array(A.count);
                for (int i = 0; i < A.count; i++)
                {
                    C[i] = A[i] + B[i];
                }

                return C;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static Array operator -(Array A, Array B)
        {
            if (A.count == B.count)
            {
                Array C = new Array(A.count);
                for (int i = 0; i < A.count; i++)
                {
                    C[i] = A[i] - B[i];
                }

                return C;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static Array operator *(Array A, int scalar)
        {
            Array C = new Array(A.GetCount);
            for (int i = 0; i < A.GetCount; i++)
            {
                C[i] = A[i] * scalar;
            }
            return C;
        }

        public static bool Equal(Array A, Array B)
        {
            if (A.GetCount != B.GetCount)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < A.GetCount; i++)
                {
                    if (A[i] != B[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
