using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Data;
using MyAPI.DTOs;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    // URL api/models
    [Route("api/models")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelRepo _repository;
        private readonly IMapper _mapper;

        public ModelController(IModelRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get api/models
        [HttpGet]
        public ActionResult<IEnumerable<Model>> GetAllModels()
        {
            var item = _repository.GetAllModels();
                
            return Ok(_mapper.Map<IEnumerable<ReadModelDto>>(item));
        }


        //Get api/models/{id}
        [HttpGet("{id}", Name = "GetModelById")]
        public ActionResult<Model> GetModelById(int id)
        {
            var item = _repository.GetModelById(id);
            if (item != null) return Ok(_mapper.Map<ReadModelDto>(item));

            return NotFound();
        }

        //Get api/models
        [HttpPost]
        public ActionResult<Model> CreateModel(CreateModelDtos create)
        {
            var item = _mapper.Map<Model>(create);
            _repository.CreateModel(item);
            _repository.SaveChanges();

            var readDto = _mapper.Map<ReadModelDto>(item);

            return CreatedAtRoute(nameof(GetModelById), new { Id = readDto.Id }, readDto);
        }
    }
}