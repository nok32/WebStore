namespace Ivailowgrad.Data.Contracts
{
    public interface IImage
    {
        string ImgPath { get; set; }

        string ImgNameWithExtencion { get; set; }

        string ImgOnlyExtencion { get; set; }
    }
}
