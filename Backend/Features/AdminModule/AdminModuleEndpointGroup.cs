using FastEndpoints;

namespace PureTCOWebApp.Features.AdminModule;

public class AdminModuleEndpointGroup : Group
{
    public AdminModuleEndpointGroup()
    {
        Configure("api/admin", ep =>
        {
            ep.Roles("Admin");
            ep.Description(x => x.WithTags("Admin Module"));
            ep.Tags("Admin Module");
        });
    }
}
