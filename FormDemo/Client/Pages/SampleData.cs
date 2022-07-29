namespace FormDemo.Client.Pages
{
    public class SampleData
    {
        Data data = new Data();
        List<Data> datas;
        public SampleData()
        {
            datas = new List<Data>();
        }
        public List<Data> GetDatas()
        {
            datas.Add(new Data { id = 1, Names = new List<string> { "A", "B", "C", "D" }, Values = new List<int> { 3423, 1234, 5423, 7234 } });
            return datas;
        }
    }
}
