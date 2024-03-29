﻿namespace CarShop.Services.Data
{
    using System.Threading.Tasks;

    public interface ICommentService
    {
        Task Create(int postId, string userId, string content, int? parentId = null);

        bool IsInCarId(int commentId, int carId);
    }
}
