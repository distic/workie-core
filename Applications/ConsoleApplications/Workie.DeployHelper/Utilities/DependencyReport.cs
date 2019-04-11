﻿using Workie.DeployHelper.Enums;

namespace Workie.DeployHelper.Utilities
{
    internal class DependencyReport
    {
        #region --- Private Properties ---

        private bool gIsCompleted { get; set; }

        private ExecutionResult gExecutionResult { get; set; }

        #endregion

        #region --- Public Properties ---

        public bool IsCompleted { get { return gIsCompleted; } }

        public ExecutionResult ExecutionResult { get { return gExecutionResult; } }

        #endregion

        internal DependencyReport(ExecutionResult executionResult = ExecutionResult.Unknown, bool isCompleted = true)
        {
            gExecutionResult = executionResult;
            gIsCompleted = isCompleted;
        }
    }
}