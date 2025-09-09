namespace ApiConnect
{
    class Proxy
    {
        private IAdapter adapter { get; set; }


        public string ConvertToString(string word)
        {
            return "Zostalo: " + adapter.getLength(word);
        }
    }
}
