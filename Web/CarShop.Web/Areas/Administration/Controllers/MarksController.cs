namespace CarShop.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using CarShop.Data.Common.Repositories;
    using CarShop.Data.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [Area("Administration")]
    public class MarksController : AdministrationController
    {
        private readonly IDeletableEntityRepository<Mark> marksRepository;

        public MarksController(IDeletableEntityRepository<Mark> marksRepository)
        {
            this.marksRepository = marksRepository;
        }

        // GET: Administration/Marks
        public async Task<IActionResult> Index()
        {
              return this.View(await this.marksRepository.AllWithDeleted().ToListAsync());
        }

        // GET: Administration/Marks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || this.marksRepository.All() == null)
            {
                return this.NotFound();
            }

            var mark = await this.marksRepository.All()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mark == null)
            {
                return this.NotFound();
            }

            return this.View(mark);
        }

        // GET: Administration/Marks/Create
        public IActionResult Create()
        {
            return this.View();
        }

        // POST: Administration/Marks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Mark mark)
        {
            if (this.ModelState.IsValid)
            {
                await this.marksRepository.AddAsync(mark);
                await this.marksRepository.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(mark);
        }

        // GET: Administration/Marks/Edit/5
       

        // POST: Administration/Marks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,IsDeleted,DeletedOn,Id,CreatedOn,ModifiedOn")] Mark mark)
        {
            if (id != mark.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this.marksRepository.Update(mark);
                    await this.marksRepository.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.MarkExists(mark.Id))
                    {
                        return this.NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(mark);
        }

        // GET: Administration/Marks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || this.marksRepository.All() == null)
            {
                return this.NotFound();
            }

            var mark = await this.marksRepository.All()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mark == null)
            {
                return this.NotFound();
            }

            return this.View(mark);
        }

        // POST: Administration/Marks/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (this.marksRepository.All() == null)
            {
                return this.Problem("Entity set 'ApplicationDbContext.Marks'  is null.");
            }

            var mark = this.marksRepository.All().FirstOrDefault(m => m.Id == id);
            if (mark != null)
            {
                this.marksRepository.Delete(mark);
            }

            await this.marksRepository.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool MarkExists(int id)
        {
          return this.marksRepository.All().Any(e => e.Id == id);
        }
    }
}
