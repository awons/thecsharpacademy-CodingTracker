using CodingTrackerLib.Modules.TimeTracking.Application.Commands;
using CodingTrackerLib.Modules.TimeTracking.Domain;

namespace CodingTrackerLibTests.Modules.TimeTracking;

[TestClass]
public class CreateTimeTrackingTest
{
    [TestMethod]
    public void WillCreateTimeTrackingWithProvidedStatAndAndTime()
    {
        var command = new AddTrackingCommand(new DateTime(2020, 01, 01, 0, 0, 0, DateTimeKind.Utc),
            new DateTime(2020, 01, 01, 0, 1, 0, DateTimeKind.Utc));

        var handler = new AddTrackingCommandHandler();
        handler.Handle(command);
    }
}