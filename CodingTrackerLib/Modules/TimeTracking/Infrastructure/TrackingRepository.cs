using System.Data;
using CodingTrackerLib.Modules.TimeTracking.Domain;

namespace CodingTrackerLib.Modules.TimeTracking.Infrastructure;

internal class TrackingRepository(IDbConnection connection) : ITrackingRepository
{
    public void AddTracking(TrackingDto tracking)
    {
        throw new NotImplementedException();
    }

    public void UpdateTracking(Tracking tracking)
    {
        throw new NotImplementedException();
    }

    public void DeleteTracking(long id)
    {
        throw new NotImplementedException();
    }

    public Tracking GetTrackingById(long id)
    {
        throw new NotImplementedException();
    }
}