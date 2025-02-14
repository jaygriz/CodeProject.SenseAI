﻿namespace CodeProject.SenseAI.API.Server.Backend
{
#pragma warning disable IDE1006 // Naming Styles
    public class BackendResponseBase
    {
        /// <summary>
        /// Gets or sets a value indicating success of the call
        /// </summary>
        public bool success { get; set; }
    }

    /// <summary>
    /// An error response for a Queued Request.
    /// </summary>
    public class BackendErrorResponse : BackendResponseBase
    {
        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        public int code { get; set; } = 0;

        /// <summary>
        /// Gets or sets the error message;
        /// </summary>
        public string? error { get; set; } = null;

        /// <summary>
        /// Instantiates a new instance of the cref="QueuedErrorResponse" class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessage">The error message.</param>
        public BackendErrorResponse(int errorCode, string errorMessage)
        {
            success = false;
            code    = errorCode;
            error   = errorMessage;
        }
    }

    /// <summary>
    /// General success base class.
    /// </summary>
    public class BackendSuccessResponse : BackendResponseBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public BackendSuccessResponse()
        {
            success = true;
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
