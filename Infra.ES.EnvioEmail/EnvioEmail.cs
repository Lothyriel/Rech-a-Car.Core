using System.IO;

namespace EmailAluguelPDF
{
    public abstract class EnvioEmail
    {
        public EnvioEmail(MemoryStream attachment)
        {
            StreamAttachment = attachment;
        }
        public MemoryStream StreamAttachment { get; }
        public int Id { get; set; }
    }
}