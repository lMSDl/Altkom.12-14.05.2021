using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Facade.III
{
    public class ConverterFacade : IJsonCoverter, IByteArrayConveter, IXmlConverter
    {
        private IByteArrayConveter byteArrayConveter;
        private IJsonCoverter jsonCoverter;
        private IXmlConverter xmlConverter;

        public ConverterFacade(IByteArrayConveter byteArrayConveter, IJsonCoverter jsonCoverter, IXmlConverter xmlConverter)
        {
            this.byteArrayConveter = byteArrayConveter;
            this.jsonCoverter = jsonCoverter;
            this.xmlConverter = xmlConverter;
        }

        public byte[] ToByteArray()
        {
            return byteArrayConveter.ToByteArray();
        }

        public string ToJson()
        {
            return jsonCoverter.ToJson();
        }

        public string ToXml()
        {
            return xmlConverter.ToXml();
        }
    }
}
