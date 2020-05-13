namespace G2_FTP_UC1 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://G2_FTP_UC1.Schema1",@"CardCreation")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CardCreation"})]
    public sealed class Card : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://G2_FTP_UC1.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://G2_FTP_UC1.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CardCreation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""UID"" type=""xs:int"" />
        <xs:element name=""CardId"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Card() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CardCreation";
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
