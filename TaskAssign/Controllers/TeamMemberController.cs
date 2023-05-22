using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAssign.Models;
using TaskAssign.Service.Interfaces;

namespace TaskAssign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMemberController : ControllerBase
    {
        private readonly ITeamMemberService _teamMemberService;
        public TeamMemberController(ITeamMemberService teamMemberService)
        {
            _teamMemberService = teamMemberService;
        }

        [HttpGet("GetTeamMembers")]
        public async Task<IActionResult> GetTeamMembers()
        {
            try
            {
                return Ok(await _teamMemberService.GetTeamMembers());

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetTeamMemberById")]
        public async Task<IActionResult> GetTeamMemberById(int teamMemberId)
        {
            try
            {
                return Ok(await _teamMemberService.GetTeamMemberById(teamMemberId));

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateTeamMember")]
        public async Task<IActionResult> CreateTeamMember([FromBody] TeamMember teamMember)
        {
            try
            {
                return Ok(await _teamMemberService.CreateTeamMember(teamMember));

            }
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
        }

        [HttpPut("UpdateTeamMember")]
        public async Task<IActionResult> UpdateTeamMember([FromBody] TeamMember teamMember)
        {
            try
            {
                return Ok(await _teamMemberService.UpdateTeamMember(teamMember));
            }catch (Exception ex)
            {
				return BadRequest(ex.Message);
			}
        }

        [HttpDelete("DeleteTeamMember")]
        public async Task<IActionResult> DeleteTeamMember(int teamMemberId)
        {
            try
            {
                return Ok(await _teamMemberService.DeleteTeamMember(teamMemberId));
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

	}
}
