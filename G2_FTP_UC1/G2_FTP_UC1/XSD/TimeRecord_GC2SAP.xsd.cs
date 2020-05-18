namespace G2_FTP_UC1.XSD {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://G2_FTP_UC1.XSD.TimeRecord_GC2SAP",@"TimeRecord")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TimeRecord"})]
    public sealed class TimeRecord_GC2SAP : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://G2_FTP_UC1.XSD.TimeRecord_GC2SAP"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://G2_FTP_UC1.XSD.TimeRecord_GC2SAP"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TimeRecord"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""UID"" type=""xs:string"" />
        <xs:element name=""WorkTime"" type=""xs:duration"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TimeRecord_GC2SAP() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TimeRecord";
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
