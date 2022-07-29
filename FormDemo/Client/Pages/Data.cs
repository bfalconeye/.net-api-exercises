namespace FormDemo.Client.Pages
{
    public class Data
    {
        public int id { get; set; }
        public List<string> Names { get; set; }
        public List<int> Values { get; set; }
        public List<Data> datas = new List<Data>() { };
        public List<Data> GetDatas()
        {

            datas.Add(new Data { id = 1, Names = { "A", "B" }, Values = { 3423, 1234 } });
            datas.Add(new Data { id = 2, Names = { "C", "D" }, Values = { 5423, 7234 } });
            return datas;
        }
    }
}
