namespace G2_FTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.CardCreation", typeof(global::G2_FTP_UC1.CardCreation))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.CardCreation", typeof(global::G2_FTP_UC1.CardCreation))]
    public sealed class CardCreationSAP2SQL : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""G2_FTP_UC1.CardCreation"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:CardCreation"" />
  </xsl:template>
  <xsl:template match=""/ns0:CardCreation"">
    <ns0:CardCreation>
      <UID>
        <xsl:value-of select=""UID/text()"" />
      </UID>
      <CardId>
        <xsl:value-of select=""CardId/text()"" />
      </CardId>
    </ns0:CardCreation>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"G2_FTP_UC1.CardCreation";
        
        private const global::G2_FTP_UC1.CardCreation _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G2_FTP_UC1.CardCreation";
        
        private const global::G2_FTP_UC1.CardCreation _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"G2_FTP_UC1.CardCreation";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G2_FTP_UC1.CardCreation";
                return _TrgSchemas;
            }
        }
    }
}
