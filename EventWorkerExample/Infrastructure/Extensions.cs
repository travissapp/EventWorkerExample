using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EventWorkerExample.Infrastructure {
    public static class Extensions {

        public static T ExtXmlDeSerialize<T>(this T objectToDeSerialize, string xml) {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T cr;
            using (StringReader sr = new StringReader(xml)) {
                using (TextReader tr = sr) {
                    using (XmlReader reader = XmlReader.Create(tr)) {
                        cr = (T)ser.Deserialize(reader);
                    }
                    return cr;
                }
            }
        }

        public static string ExtXmlSerialize<T>(this T objectToSerialize) {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            StringBuilder sb = new StringBuilder();
            using (StringWriter sr = new StringWriter(sb)) {
                using (TextWriter tw = sr) {
                    xmlSerializer.Serialize(tw, objectToSerialize);
                }
            }

            return sb.ToString();
        }
    }
}
