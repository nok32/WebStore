namespace Ivailowgrad.Data.Contracts
{
    public class Img : IImage
    {
        public int Id { get; set; }

        public string ImgPath { get; set; }

        public string ImgNameWithExtencion { get; set; }

        public string ImgOnlyExtencion { get; set; }
    }
}
