namespace CarShop.Web.ViewModels.Search
{
    public class SearchListInputModel
    {
        public uint EngineId { get; set; }

        public string MarkName { get; set; }

        public int MaxPrice { get; set; }

        public int MinPrice { get; set; }
    }
}
