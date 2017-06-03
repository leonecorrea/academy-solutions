namespace AcademySolution
{
    public interface ICategoria
    {
        string GetDescricao();
        int GetId();
        string GetNome();
        void SetDescricao(string value);
        void SetId(int value);
        void SetNome(string value);
    }
}