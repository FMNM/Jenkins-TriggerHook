﻿using Jenkins_TriggerHook.TriggerHookUp;
using Jenkins_TriggerHook.TriggerHookUp.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Jenkins_TriggerHook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildController : Controller
    {
        [HttpGet]
        //[Route("trigger")]
        public async Task<IActionResult> TriggerJenkins()
        {
            try
            {
                return Ok("Jenkins build started");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await Hook.Trigger();
            }
        }
    }
}