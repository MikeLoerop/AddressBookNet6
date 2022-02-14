namespace AddressBookNet6.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string CovertByteArrayToFile(byte[] fileData, string extension);
    }
}
