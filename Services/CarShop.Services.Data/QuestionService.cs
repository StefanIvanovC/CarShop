namespace CarShop.Services.Data
{
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using CarShop.Web.ViewModels.Contacts;

    public class QuestionService : IQuestionService
    {
        private readonly IDeletableEntityRepository<Question> questionRepository;

        public QuestionService(IDeletableEntityRepository<Question> questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public async Task CreateAsynk(ContactInputFormModel input, string user)
        {
            var question = new Question
            {
                Name = input.Name,
                Email = input.Email,
                TelephoneNumber = input.TelephoneNumber,
                Message = input.Message,
                CreatedByUserId = user,
            };

            await this.questionRepository.AddAsync(question);
            await this.questionRepository.SaveChangesAsync();
        }
    }
}
