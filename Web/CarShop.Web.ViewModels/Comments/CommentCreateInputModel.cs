namespace CarShop.Web.ViewModels.Comments
{
    public class CommentCreateInputModel
    {
        public int CarId { get; set; }

        public string Content { get; set; }

        public int ParentId { get; set; }
    }
}
