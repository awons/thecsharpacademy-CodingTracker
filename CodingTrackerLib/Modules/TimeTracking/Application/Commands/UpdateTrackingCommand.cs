namespace CodingTrackerLib.Modules.TimeTracking.Application.Commands;

public record UpdateTrackingCommand(long Id, DateTime StartDateTime, DateTime EndDateTime);