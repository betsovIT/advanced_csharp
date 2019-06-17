using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    class Lake : IEnumerable<int>
    {
        private int[] internalArray;

        public Lake(int[] arr)
        {
            this.internalArray = arr;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new LakeIterator(internalArray);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LakeIterator(internalArray);
        }

        private class LakeIterator : IEnumerator<int>
        {
            private int[] intArr;
            private int intIndex = -2;
            private bool hasReachedTheEnd = false;

            public int Current => intArr[intIndex];

            object IEnumerator.Current => intArr[intIndex];

            public LakeIterator(int[] arr)
            {
                this.Reset();
                this.intArr = arr;
            }

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (hasReachedTheEnd == false)
                {
                    if (intIndex + 2 < intArr.Length)
                    {
                        intIndex += 2;
                        return true;
                    }
                    else
                    {
                        hasReachedTheEnd = true;
                        if (intIndex + 1 < intArr.Length)
                        {
                            intIndex += 1;
                            return true;
                        }
                        else
                        {
                            if (intIndex -1 >= 0)
                            {
                                intIndex -= 1;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                            
                        }

                    }
                }
                else
                {
                    if (intIndex - 2 >= 1)
                    {
                        intIndex -= 2;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            public void Reset()
            {
                intIndex = -2;
            }
        }
    }
}
