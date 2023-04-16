using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    [Serializable]
    public class PersonModel : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EmailModel>  Emails { get; set; }
        public List<Address> Addresses { get; set; }
        public bool Active { get; set; }
        public PersonModel Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return (PersonModel)formatter.Deserialize(ms);
            }            
        }

        public PersonModel CloneWithNewton()
        {
            return JsonConvert.DeserializeObject<PersonModel>(JsonConvert.SerializeObject(this));
        }
    }

    [Serializable]
    public class EmailModel
    {
        public string Email { get; set; }
    }

    [Serializable]
    public class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
