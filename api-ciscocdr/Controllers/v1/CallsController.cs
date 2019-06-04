using api_ciscocdr.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

[ApiController]
[Produces("application/json")]
[Route("api/v1/[controller]")]
public class CallsController : ControllerBase
{
    private readonly CallAnalyzerContext _context;

    public CallsController(CallAnalyzerContext context)
    {
        _context = context;
    }

    public IActionResult Get(DateTime? Start = null, DateTime? End = null, string Number = null, string Device = null, string Cause = null, int take = 10, int skip = 0)
    {
        if(Start == null)
        {
            Start = DateTime.Now.Date;
        }

        if (End == null)
        {
            End = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        var calls = _context.Calls
            .Where(c => c.DateTimeDisconnect >= Start && c.DateTimeDisconnect <= End);

        if (Number != null)
        {
            calls = calls
                .Where(c => c.CallingPartyNumber.Contains(Number) || c.OriginalCalledPartyNumber.Contains(Number) || c.FinalCalledPartyNumber.Contains(Number));
        }

        if (Device != null)
        {
            calls = calls
                .Where(c => c.OrigDeviceName.Contains(Device) || c.DestDeviceName.Contains(Device));
        }

        if (Cause != null)
        {
            calls = calls
                .Where(c => c.OrigCauseValue == Cause || c.DestCauseValue == Cause);
        }

        var results = calls
            .Take(take)
            .Skip(skip)
            .OrderByDescending(c => c.DateTimeDisconnect);

        return Ok(results);
    }
}
