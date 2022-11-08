namespace Übung_13_Valeria;

public class Person
{
   public string Vorname
   {
      get;
      set;
   }

   public string Nachname
   {
      get;
      set;
   }

   public string Adresse
   {
      get;
      set;
   }

   public Dictionary<string, string> Kontakte = new Dictionary<string, string>();

   public Person(string vorname, string nachname, string adresse, Dictionary<string, string> kontakte)
   
   {
      Vorname = vorname;
      Nachname = nachname;
      Adresse = adresse;
      Kontakte = kontakte;
   }

   public override string ToString()
   {
      return $"Kontakte: {Kontakte}, Vorname: {Vorname}, Nachname: {Nachname}, Adresse: {Adresse}";
   }
}