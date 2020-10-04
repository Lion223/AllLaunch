namespace AllLaunchCore
{
    /// <summary>
    /// Represents every state of an application in the launch list
    /// </summary>
    public enum ApplicationState
    {
        // Inactivity (not launched, no option errors)
        Inactive = 0,
        // The application is running (process exists) 
        Running = 1,
        // The application has option errors
        Error = 2
    }
}
