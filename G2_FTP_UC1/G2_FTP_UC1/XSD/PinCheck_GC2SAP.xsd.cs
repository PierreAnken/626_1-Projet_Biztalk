namespace G2_FTP_UC1.XSD {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://G2_FTP_UC1.XSD.PinCheck_GC2SAP",@"PinCheck")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::G2_FTP_UC1.PropertySchema.PIN), XPath = @"/*[local-name()='PinCheck' and namespace-uri()='http://G2_FTP_UC1.XSD.PinCheck_GC2SAP']/*[local-name()='PIN' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::G2_FTP_UC1.PropertySchema.UID), XPath = @"/*[local-name()='PinCheck' and namespace-uri()='http://G2_FTP_UC1.XSD.PinCheck_GC2SAP']/*[local-name()='UID' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PinCheck"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.PropertySchema.PropertySchema", typeof(global::G2_FTP_UC1.PropertySchema.PropertySchema))]
    public sealed class PinCheck_GC2SAP : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://G2_FTP_UC1.XSD.PinCheck_GC2SAP"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://G2_FTP_UC1.PropertySchema"" targetNamespace=""http://G2_FTP_UC1.XSD.PinCheck_GC2SAP"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://G2_FTP_UC1.PropertySchema"" location=""G2_FTP_UC1.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""PinCheck"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:PIN"" xpath=""/*[local-name()='PinCheck' and namespace-uri()='http://G2_FTP_UC1.XSD.PinCheck_GC2SAP']/*[local-name()='PIN' and namespace-uri()='']"" />
          <b:property name=""ns0:UID"" xpath=""/*[local-name()='PinCheck' and namespace-uri()='http://G2_FTP_UC1.XSD.PinCheck_GC2SAP']/*[local-name()='UID' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PIN"" type=""xs:int"" />
        <xs:element name=""UID"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PinCheck_GC2SAP() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PinCheck";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
