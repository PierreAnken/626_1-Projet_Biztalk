namespace G2_FTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.XSD.FF_CardCreation_BM2SAP", typeof(global::G2_FTP_UC1.XSD.FF_CardCreation_BM2SAP))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.XSD.FF_CardCreationPIN_SAP2SAP", typeof(global::G2_FTP_UC1.XSD.FF_CardCreationPIN_SAP2SAP))]
    public sealed class CardCreation2CardCreationPIN : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://G2_FTP_UC1.XSD.FF_CardCreationPIN_SAP2SAP"" xmlns:s0=""http://G2_FTP_UC1.XSD.FF_CardCreation_BM2SAP"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CardCreations"" />
  </xsl:template>
  <xsl:template match=""/s0:CardCreations"">
    <ns0:CardCreationsPIN>
      <xsl:for-each select=""CardCreation"">
        <CardCreationsPIN>
          <UID>
            <xsl:value-of select=""UID/text()"" />
          </UID>
          <CardId>
            <xsl:value-of select=""CardId/text()"" />
          </CardId>
          <xsl:variable name=""var:v1"" select=""userCSharp:generatePIN(string(CardId/text()))"" />
          <PIN>
            <xsl:value-of select=""$var:v1"" />
          </PIN>
        </CardCreationsPIN>
      </xsl:for-each>
    </ns0:CardCreationsPIN>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[


public int generatePIN(int CardId)
{
    int rest = (CardId%1000)/2;
    Random random = new Random();
    int randomValue = random.Next(1000, 5000);
    return randomValue+ rest;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"G2_FTP_UC1.XSD.FF_CardCreation_BM2SAP";
        
        private const global::G2_FTP_UC1.XSD.FF_CardCreation_BM2SAP _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G2_FTP_UC1.XSD.FF_CardCreationPIN_SAP2SAP";
        
        private const global::G2_FTP_UC1.XSD.FF_CardCreationPIN_SAP2SAP _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"G2_FTP_UC1.XSD.FF_CardCreation_BM2SAP";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G2_FTP_UC1.XSD.FF_CardCreationPIN_SAP2SAP";
                return _TrgSchemas;
            }
        }
    }
}
