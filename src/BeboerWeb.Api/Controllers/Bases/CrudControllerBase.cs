using AutoMapper;
using BeboerWeb.Api.Application.Services.Bases;
using BeboerWeb.Shared.Application.Services.Models;
using BeboerWeb.Shared.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeboerWeb.Api.Controllers.Bases
{
    public abstract class CrudControllerBase<TDTO, TDomain, TRepository, TService> : ControllerBase
        where TDTO : class
        where TDomain : class
        where TRepository : IRepository, ICrudRepository<TDomain>
        where TService : ICrudServiceBase<TDomain, TRepository>
    {
        private readonly TService service;
        private readonly IMapper mapper;

        protected CrudControllerBase(TService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        // GET: api/<CrudControllerBase>
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TDTO>>> GetAll()
        {
            var serviceResponse = await service.GetAll();
            return CreateResponse<IEnumerable<TDomain>, IEnumerable<TDTO>>(serviceResponse);
        }

        // GET api/<CrudControllerBase>/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TDTO>> Get(int id)
        {
            var serviceResponse = await service.GetById(id);
            return CreateResponse<TDomain, TDTO>(serviceResponse);
        }

        // POST api/<CrudControllerBase>
        [HttpPost]
        public virtual async Task<ActionResult> Add([FromBody] TDTO value)
        {
            var mappedObject = mapper.Map<TDomain>(value);
            var serviceResponse = await service.Add(mappedObject);
            return CreateResponse<TDomain, TDTO>(serviceResponse);
        }

        // PUT api/<CrudControllerBase>/5
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update(int id, [FromBody] TDTO value)
        {
            var mappedObject = mapper.Map<TDomain>(value);
            var serviceResponse = await service.Update(mappedObject);
            return CreateResponse<TDomain, TDTO>(serviceResponse);
        }

        // DELETE api/<CrudControllerBase>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var serviceResponse = await service.DeleteById(id);
            return CreateResponse<TDomain, TDTO>(serviceResponse);
        }

        /// <summary>
        /// Creates a response from a <see cref="IServiceResponse{T}"/> type
        /// </summary>
        /// <typeparam name="TInputFormat"></typeparam>
        /// <typeparam name="TOutputFormat"></typeparam>
        /// <param name="serviceResponse"></param>
        /// <returns></returns>
        private ActionResult CreateResponse<TInputFormat, TOutputFormat>(IServiceResponse<TInputFormat> serviceResponse)
            where TInputFormat : class
            where TOutputFormat : class
        {
            var content = MapResponse<TInputFormat, TOutputFormat>(serviceResponse.ReponseValue);

            return serviceResponse.StatusCode switch {
                Shared.Application.Enums.StatusCode.Success => Ok(content),
                Shared.Application.Enums.StatusCode.Created => Ok(content),
                Shared.Application.Enums.StatusCode.NoContent => NoContent(),
                Shared.Application.Enums.StatusCode.BadRequest => BadRequest(),
                Shared.Application.Enums.StatusCode.NotFound => NotFound(),
                Shared.Application.Enums.StatusCode.Error => StatusCode(500),
                _ => StatusCode((int)serviceResponse.StatusCode),
            };
        }

        /// <summary>
        /// Maps a input type to an output type
        /// </summary>
        /// <typeparam name="TInputFormat"></typeparam>
        /// <typeparam name="TOutputFormat"></typeparam>
        /// <param name="sourceValue"></param>
        /// <returns></returns>
        private TOutputFormat MapResponse<TInputFormat, TOutputFormat>(TInputFormat sourceValue)
        {
            return mapper.Map<TInputFormat, TOutputFormat>(sourceValue);
        }
    }
}
