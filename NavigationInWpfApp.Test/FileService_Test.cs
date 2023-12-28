namespace NavigationInWpfApp.Test;

public class FileService_Tests
{
    [Fact]
    public void SaveToFileShould_ReturnTrue_IfFilePathExists()
    {
        IFileService fileService = new FileService();
        string filePath = @"c:\Projects\ConsoleApp\test.txt";
        string content = "test content Simon 3152342342342343";

        bool result = fileService.SaveToFile(filePath, content);

        Assert.True(result);
    }

    [Fact]
    public void SaveToFileShould_ReturnFalse_IfFilePathDoNotExist()
    {
        IFileService fileService = new FileService();
        string filePath = @$"c:\{Guid.NewGuid()}\test.txt";
        string content = "test content Simon 1111111123522333333331";

        bool result = fileService.SaveToFile(filePath, content);

        Assert.False(result);
    }
}