namespace G2_FTP_UC1 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CardCreation", @"CardCreationResponse"})]
    public sealed class InsertSAP_HRService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""G2_FTP_UC1.CardCreation"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""G2_FTP_UC1.CardCreation"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""CardCreation"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:updategram=""urn:schemas-microsoft-com:xml-updategram"" updategram:Prefix=""updg"" minOccurs=""1"" maxOccurs=""unbounded"" name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element updategram:Prefix=""updg"" minOccurs=""0"" maxOccurs=""unbounded"" name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAP_HR"">
                      <xs:complexType>
                        <xs:attribute name=""UID"" type=""xs:string"" />
                        <xs:attribute name=""CardId"" type=""xs:int"" />
                        <xs:attribute name=""PIN"" type=""xs:int"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CardCreationResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InsertSAP_HRService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "CardCreation";
                _RootElements[1] = "CardCreationResponse";
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
        
        [Schema(@"G2_FTP_UC1.CardCreation",@"CardCreation")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CardCreation"})]
        public sealed class CardCreation : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CardCreation() {
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
        
        [Schema(@"G2_FTP_UC1.CardCreation",@"CardCreationResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CardCreationResponse"})]
        public sealed class CardCreationResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CardCreationResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CardCreationResponse";
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
}
