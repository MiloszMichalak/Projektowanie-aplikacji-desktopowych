namespace ApiConnect
{
    class Dao: IDao
    {
        public int getLength(string word)
        {
            return word.Length;
        }
    }
}
