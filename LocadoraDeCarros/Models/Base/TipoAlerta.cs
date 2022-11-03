using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LocadoraDeCarros.Models.Base
{
    public enum TipoAlerta
    {
        sucesso,
        erro
    }

    public static class TipoAlertaExtension
    {
        public static string GetName(this TipoAlerta tipo)
        {
            switch (tipo)
            {
                case TipoAlerta.sucesso:
                    return "alert-primary";
                case TipoAlerta.erro:
                    return "alert-danger";
                default:
                    return "alert-primary";
            }
        }
    }
}
