using AutoMapper;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Controllers.Bases
{
    public abstract class CrudControllerBase<DTO, Domain, Repository, Service> : ControllerBase 
        where DTO : class
        where Domain : class
        where Repository : IRepository, ICrudRepository<Domain>
        where Service : ICrudServiceBase<Domain, Repository>
    {
        private readonly Service _service;
        private readonly IMapper mapper;

        public CrudControllerBase(Service service, IMapper mapper)
        {
            _service = service;
            this.mapper = mapper;
        }

        // GET: api/<CrudControllerBase>
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<DTO>>> Get()
        {
            var response = await _service.GetAll();
            return ResponseFromStatusCode(response);
        }

        // GET api/<CrudControllerBase>/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<DTO>> Get(int id)
        {
            var response = await _service.GetById(id);
            return ResponseFromStatusCode(response);
        }

        // POST api/<CrudControllerBase>
        [HttpPost]
        public virtual async Task<ActionResult> Post([FromBody] DTO value)
        {
            var mappedObject = mapper.Map<Domain>(value);
            var response = await _service.Add(mappedObject);
            return ResponseFromStatusCode(response);
        }

        // PUT api/<CrudControllerBase>/5
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Put(int id, [FromBody] DTO value)
        {
            var mappedObject = mapper.Map<Domain>(value);
            var response = await _service.Update(mappedObject);
            return ResponseFromStatusCode(response);
        }

        // DELETE api/<CrudControllerBase>/5
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var response = await _service.DeleteById(id);
            return ResponseFromStatusCode(response);
        }

        private ActionResult ResponseFromStatusCode<TResponse>(IServiceResponse<TResponse> response) //TODO: Add automapper to DTO
            where TResponse : class
        {
            return response.StatusCode switch {
                Shared.Application.Enums.StatusCode.Success => Ok(response.Reponse),
                Shared.Application.Enums.StatusCode.Created => CreatedAtAction(nameof(this.Get), response.Reponse),
                Shared.Application.Enums.StatusCode.NoContent => NoContent(),
                Shared.Application.Enums.StatusCode.BadRequest => BadRequest(),
                Shared.Application.Enums.StatusCode.NotFound => NotFound(),
                Shared.Application.Enums.StatusCode.Error => StatusCode(500),
                _ => StatusCode((int)response.StatusCode),
            };
        }
    }
}
