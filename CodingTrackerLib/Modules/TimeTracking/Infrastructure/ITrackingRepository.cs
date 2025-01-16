using CodingTrackerLib.Modules.TimeTracking.Domain;

namespace CodingTrackerLib.Modules.TimeTracking.Infrastructure;

internal interface ITrackingRepository
{
    public void AddTracking(TrackingDto tracking);

    public void UpdateTracking(TrackingDto tracking);

    public void DeleteTracking(long id);

    public Tracking GetTrackingById(long id);
}