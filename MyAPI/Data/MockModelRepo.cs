using System.Collections.Generic;
using MyAPI.Models;

namespace MyAPI.Data
{
    public class MockModelRepo : IModelRepo
    {
        private readonly DataContext _context;

        public MockModelRepo(DataContext context)
        {
            _context = context;
        }

        public void CreateModel(Model cmd)
        {
        }

        public void DeleteModel(Model model)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Model> GetAllModels()
        {
            return new List<Model>{
                new Model{Id=0,Question="Q 0", Answer="A 0"},
                new Model{Id=1,Question="Q 1", Answer="A 1"},
                new Model{Id=2,Question="Q 2", Answer="A 2"}
            };
        }

        public Model GetModelById(int id)
        {
            return new Model{Id=0,Question="Q 0", Answer="A 0"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateModel(Model model)
        {
            throw new System.NotImplementedException();
        }
    }
}