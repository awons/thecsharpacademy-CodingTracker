namespace CodingTrackerLib.Modules.TimeTracking.Application.Commands;

public record AddTrackingCommand(DateTime StartDateTime, DateTime StopDateTime);