﻿using Microsoft.AspNetCore.Mvc;
using User.Repos;

namespace User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            return await _userRepository.AddUser(user);
        }
    }
}
