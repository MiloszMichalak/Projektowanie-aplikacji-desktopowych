using System;

namespace ApiConnect
{
    class Adapter: IAdapter, IDao
    {
        const byte AllowedLength = 10;

        public int getLength(string word)
        {
            if (word.Length > AllowedLength)
            {
                throw new ArgumentException();
            }
            return AllowedLength - word.Length;
        }

    }
}
