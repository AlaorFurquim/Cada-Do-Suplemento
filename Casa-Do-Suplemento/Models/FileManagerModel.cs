namespace Casa_Do_Suplemento.Models
{
    public class FileManagerModel
    {
        public FileInfo[] Files { get; set; }


        public IFormFile IFomerFile { get; set; }


        public List<IFormFile> IFormFiles { get; set; }


        public string PathImagesProduto { get; set; }
    }
}
