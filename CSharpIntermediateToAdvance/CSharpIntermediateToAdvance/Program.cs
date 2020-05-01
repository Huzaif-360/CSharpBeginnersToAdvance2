using System;
using System.Collections.Generic;

namespace CSharpIntermediateToAdvance
{
    partial class Program
    {

        static void Main(string[] args)
        {
            //Section 6 Exercise

            //...................1
            var workflow = new Workflow();

            //...................2
            workflow.AddActivity(new Upload());

            //...................3
            //workflow.AddActivity(new VideoEncoder());

            //...................4
            workflow.AddActivity(new MailService());

            //...................5
            workflow.AddActivity(new StatusChanger());
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }

     
    }
    public class WorkflowEngine
    {
        public void Run(Workflow _workflow)
        {
            if (_workflow == null)
            {
                throw new ArgumentNullException("_workflow");
            }
            else if (_workflow.GetActivities().Count == 0)
            {
                throw new ArgumentNullException("ActivityList", "Empty Activity list not allowed");
            }

            foreach (var activity in _workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }

    //............................................
    public class Workflow
    {
        private readonly IList<IWorkflow> _workflow;

        public Workflow()
        {
            _workflow = new List<IWorkflow>();
        }

        public void AddActivity(IWorkflow activity)
        {
            _workflow.Add(activity);
        }

        public IList<IWorkflow> GetActivities()
        {
            return _workflow;
        }
    }
    //.............................................
    public class Upload : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video is uploading...");
        }
    }
    //.......................................
    public class StatusChanger : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video is in processing state");
        }
    }

    public interface IWorkflow
    {
        void Execute();
    }
    //.......End...............
}




