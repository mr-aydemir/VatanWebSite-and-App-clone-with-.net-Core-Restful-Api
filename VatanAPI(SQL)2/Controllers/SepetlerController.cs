﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VatanAPI.Domain.Models;
using VatanAPI.Domain.Services;
using VatanAPI.Extensions;
using VatanAPI.Persistence.Contexts;
using VatanAPI.Resources;

namespace VatanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetlerController : Controller
    {
        private readonly ISepetService _sepetService;
        private readonly IMapper _mapper;

        public SepetlerController(ISepetService sepetService, IMapper mapper)
        {
            _sepetService = sepetService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<SepetResource>> ListAsync()//GetAllSync ile aynı kodlar.
        {
            var sepets = await _sepetService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Sepet>, IEnumerable<SepetResource>>(sepets);
            return resources;
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveSepetResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            var sepet = _mapper.Map<SaveSepetResource, Sepet>(resource);
            var result = await _sepetService.SaveAsync(sepet);

            if (!result.Success)
                return BadRequest(result.Message);

            var sepetResource = _mapper.Map<Sepet, SepetResource>(result.Sepet);
            return Ok(sepetResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveSepetResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var sepet = _mapper.Map<SaveSepetResource, Sepet>(resource);
            var result = await _sepetService.UpdateAsync(id, sepet);

            if (!result.Success)
                return BadRequest(result.Message);

            var sepetResource = _mapper.Map<Sepet, SaveSepetResource>(result.Sepet);
            return Ok(sepetResource);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)//parametrede verilmiş olan id numarasına sahip veriyi siler.
        {
            var result = await _sepetService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var sepetResource = _mapper.Map<Sepet, SepetResource>(result.Sepet);
            return Ok(sepetResource);
        }
    }
}