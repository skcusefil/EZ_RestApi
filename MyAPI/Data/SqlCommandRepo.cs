using System;
using System.Collections.Generic;
using System.Linq;
using MyAPI.Models;

namespace MyAPI.Data
{
    public class SqlCommandRepo : IModelRepo
    {
        private readonly DataContext _context;

        public SqlCommandRepo(DataContext context)
        {
            _context = context;
        }

        public void DeleteModel(Model model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.Models.Remove(model);
        }

        public IEnumerable<Model> GetAllModels()
        {
            return _context.Models.ToList();
        }

        public Model GetModelById(int id)
        {
            return _context.Models.FirstOrDefault(x=>x.Id == id);
        }

        public void UpdateModel(Model model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.Models.Update(model);
        }

        public void CreateModel(Model cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Models.Add(cmd);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}