using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class YamsController : ControllerBase
    {
        private readonly IYamRepository _yamRepository;

        public YamsController(IYamRepository yamRepository)
        {
            _yamRepository = yamRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllConferences()
        {
            var conferences = await _yamRepository.GetAllConferencesAsync();
            return Ok(conferences);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConferenceById([FromRoute] int id)
        {
            var conference = await _yamRepository.GetConferenceByIdAsync(id);
            if (conference == null)
            {
                return NotFound();
            }

            return Ok(conference);
        }

        [HttpPost]
        public async Task<IActionResult> AddConference([FromBody] ConferencesModel conferencesModel)
        {
            var id = await _yamRepository.AddConferenceAsync(conferencesModel);
            return CreatedAtAction(nameof(GetConferenceById), new { id = id, Controller = "Yams" }, id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateConference([FromBody] ConferencesModel conferencesModel, [FromRoute] int id)
        {
             await _yamRepository.UpdateConferenceAsync(id,conferencesModel);
            return Ok();
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateConferencePatch([FromBody] JsonPatchDocument conferencesModel, [FromRoute] int id)
        {
            await _yamRepository.UpdateConferencePatchAsync( conferencesModel,id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConference([FromRoute]int id)
        {
            await _yamRepository.DeleteConferenceAsync(id);
            return Ok();
        }
    }
}
