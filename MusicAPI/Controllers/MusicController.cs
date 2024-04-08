using Business.Abstract;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusic _music;

        public MusicController(IMusic music)
        {
            _music = music;
        }
        [HttpGet]
        public IActionResult GetMusicList()
        {
            var values = _music.GetAll();
            return Ok(values);
        }
        [HttpGet("id")]
        public IActionResult GetMusicByID(int id)
        {
            var values= _music.GetByID(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult MusicInsert(MusicDTO dto)
        {
            var answer = "Succesfully Added";
            _music.Insert(dto);
            return Ok(answer);
        }
        [HttpPut]
        public IActionResult UpdateMusic(MusicDTO dto)
        {
            var values = "Succesfully Updated";
            _music.Update(dto);
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteMusic(int id)
        {
            var answer = "Succesfully Deleted";
            _music.Delete(id);
            return Ok(answer);
        }
    }
}
