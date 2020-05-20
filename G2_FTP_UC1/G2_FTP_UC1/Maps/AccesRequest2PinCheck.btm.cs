namespace G2_FTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.XSD.FF_AccessRequest_D2GC", typeof(global::G2_FTP_UC1.XSD.FF_AccessRequest_D2GC))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP", typeof(global::G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP))]
    public sealed class AccesRequest2PinCheck : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0"" version=""1.0"" xmlns:ns0=""http://G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP"" xmlns:s0=""http://G2_FTP_UC1.XSD.FF_AccessRequest_D2GC"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AccessRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:AccessRequest"">
    <ns0:PinCheck>
      <PIN>
        <xsl:value-of select=""PIN/text()"" />
      </PIN>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:DBLookup(0 , string(CardId/text()) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist SecurityInfo=False; Initial Catalog=G2FTPUC1;Data Source=(local)&quot; , &quot;SAP_HR&quot; , &quot;CardId&quot;)"" />
      <xsl:variable name=""var:v2"" select=""ScriptNS0:DBValueExtract(string($var:v1) , &quot;UID&quot;)"" />
      <UID>
        <xsl:value-of select=""$var:v2"" />
      </UID>
    </ns0:PinCheck>
    <xsl:variable name=""var:v3"" select=""ScriptNS0:DBLookupShutdown()"" />
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"G2_FTP_UC1.XSD.FF_AccessRequest_D2GC";
        
        private const global::G2_FTP_UC1.XSD.FF_AccessRequest_D2GC _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP";
        
        private const global::G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"G2_FTP_UC1.XSD.FF_AccessRequest_D2GC";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP";
                return _TrgSchemas;
            }
        }
    }
}
