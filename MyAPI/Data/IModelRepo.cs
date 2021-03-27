using System.Collections.Generic;
using MyAPI.Models;

namespace MyAPI.Data
{
    public interface IModelRepo
    {
        IEnumerable<Model> GetAllModels();
        Model GetModelById(int id);
        void CreateModel(Model cmd);
        void DeleteModel(Model model);
        void UpdateModel(Model model);
        bool SaveChanges();
    }
}