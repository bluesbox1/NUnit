// See https://aka.ms/new-console-template for more information
// Get the current directory where the application is running
string currentDirectory = Directory.GetCurrentDirectory();

// Traverse up the directory tree until the project root directory is found
// Assuming the project root directory contains a specific file or directory (e.g., .csproj file or a known folder)
string projectRootDirectory = GetProjectRootDirectory(currentDirectory, ".csproj");

Console.WriteLine(projectRootDirectory);

static string GetProjectRootDirectory(string currentDirectory, string marker)
{
    DirectoryInfo directory = new DirectoryInfo(currentDirectory);

    while (directory != null && !DirectoryContains(directory, marker))
    {
        directory = directory.Parent;
    }

    return directory?.FullName;
}

Console.WriteLine("Hello, World!");

