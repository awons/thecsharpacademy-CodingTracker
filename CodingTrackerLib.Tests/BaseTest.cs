using CodingTrackerLib.Modules.TimeTracking.Infrastructure;

namespace CodingTrackerLibTests;

public abstract class BaseTest
{
    internal ITrackingRepository TrackingRepository;

    [TestInitialize]
    public static void TestInitialize(TestContext testContext)
    {
    }
}