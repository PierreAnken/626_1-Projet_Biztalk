namespace G2_FTP_UC1.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP", typeof(global::G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G2_FTP_UC1.XSD.FF_PinCheckResponse_SAP2GC", typeof(global::G2_FTP_UC1.XSD.FF_PinCheckResponse_SAP2GC))]
    public sealed class PinCheck2Response : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""http://G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP"" xmlns:ns0=""http://G2_FTP_UC1.XSD.FF_PinCheckResponse_SAP2GC"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PinCheck"" />
  </xsl:template>
  <xsl:template match=""/s0:PinCheck"">
    <ns0:PinCheckResponse>
      <UID>
        <xsl:value-of select=""UID/text()"" />
      </UID>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:DBLookup(0 , string(UID/text()) , &quot;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist SecurityInfo=False; Initial Catalog=G2FTPUC1;Data Source=(local)&quot; , &quot;SAP_HR&quot; , &quot;UID&quot;)"" />
      <xsl:variable name=""var:v2"" select=""ScriptNS0:DBValueExtract(string($var:v1) , &quot;PIN&quot;)"" />
      <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq(string(PIN/text()) , string($var:v2))"" />
      <xsl:if test=""string($var:v3)='true'"">
        <xsl:variable name=""var:v4"" select=""&quot;1&quot;"" />
        <IsValide>
          <xsl:value-of select=""$var:v4"" />
        </IsValide>
      </xsl:if>
      <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNot(string($var:v3))"" />
      <xsl:if test=""string($var:v5)='true'"">
        <xsl:variable name=""var:v6"" select=""&quot;0&quot;"" />
        <IsValide>
          <xsl:value-of select=""$var:v6"" />
        </IsValide>
      </xsl:if>
    </ns0:PinCheckResponse>
    <xsl:variable name=""var:v7"" select=""ScriptNS0:DBLookupShutdown()"" />
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Microsoft.BizTalk.BaseFunctoids, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" ClassName=""Microsoft.BizTalk.BaseFunctoids.FunctoidScripts"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP";
        
        private const global::G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G2_FTP_UC1.XSD.FF_PinCheckResponse_SAP2GC";
        
        private const global::G2_FTP_UC1.XSD.FF_PinCheckResponse_SAP2GC _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"G2_FTP_UC1.XSD.FF_PinCheck_GC2SAP";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G2_FTP_UC1.XSD.FF_PinCheckResponse_SAP2GC";
                return _TrgSchemas;
            }
        }
    }
}
