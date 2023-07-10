using FIQ.Interview.Api.Models;

namespace FIQ.Interview.Api.Service;

public interface IProjectService
{
    Project GetProjectWithTasks(int projectId);
}
