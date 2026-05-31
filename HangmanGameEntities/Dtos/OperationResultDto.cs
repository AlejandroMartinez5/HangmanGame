using System.Runtime.Serialization;

namespace HangmanGameEntities.Dtos
{
    [DataContract]
    public class OperationResultDto
    {
        [DataMember]
        public bool Sucess { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public UserDto User { get; set; }
    }
}