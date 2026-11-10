using Soenneker.Google.Meet.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Google.Meet.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GoogleMeetOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IGoogleMeetOpenApiHttpClient _httpclient;

    public GoogleMeetOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IGoogleMeetOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
