using FIQ.Interview.Api.Models;

namespace FIQ.Interview.Api.Service;

public interface IProjectService
{
    Project GetProjectWithWorkItems(int projectId);
}
