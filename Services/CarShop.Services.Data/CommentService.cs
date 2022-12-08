namespace CarShop.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;

    public class CommentService : ICommentService
    {
        private readonly IDeletableEntityRepository<Comment> commentsRepository;

        public CommentService(IDeletableEntityRepository<Comment> commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }

        public async Task Create(int carId, string userId, string content, int? parentId = null)
        {
            var comment = new Comment
            {
                Content = content,
                CarId = carId,
                UserId = userId,
                ParentId = parentId,
            };
            await this.commentsRepository.AddAsync(comment);
            await this.commentsRepository.SaveChangesAsync();
        }

        public bool IsInCarId(int commentId, int carId)
        {
            var commentCarId = this.commentsRepository.All().Where(x => x.Id == commentId)
                .Select(x => x.CarId).FirstOrDefault();
            return commentCarId == carId;
        }
    }
}
