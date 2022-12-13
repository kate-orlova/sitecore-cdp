using System;
using FullStackExperience.Models;

namespace FullStackExperience.Services
{
    public interface IFlowExecutionService
    {
        FlowExecutionResult ExecuteFlow();
    }

    public class FlowExecutionService : IFlowExecutionService
    {
        public FlowExecutionResult ExecuteFlow()
        {
            throw new NotImplementedException();
        }
    }
}