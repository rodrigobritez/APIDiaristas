using Npgsql;

namespace APIDiaristas.Data.Repositories;

public class NpgsqlEnumTranslator : INpgsqlNameTranslator
{
  public string TranslateMemberName(string clrName)
  {
    return clrName.ToUpper();
  }

  public string TranslateTypeName(string clrName)
  {
    return clrName;
  }
}