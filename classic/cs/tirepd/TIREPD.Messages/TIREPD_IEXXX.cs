namespace TIREPD.Messages
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD004
    {
        
        /// <remarks/>
        public EPD004HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD004HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime AmendmentDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmendmentDateSpecified;
        
        /// <remarks/>
        public string AmdDatHEA599;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime AmendmentAcceptanceDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmendmentAcceptanceDateSpecified;
        
        /// <remarks/>
        public string AmdAccDatHEA602;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CUSOFFDEPEPTType
    {
        
        /// <remarks/>
        public string CouRefNumEPT1;
        
        /// <remarks/>
        public string RefNumEPT1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TAXType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string purpose;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRAPRIPC1Type
    {
        
        /// <remarks/>
        public string NamPC17;
        
        /// <remarks/>
        public string StrAndNumPC122;
        
        /// <remarks/>
        public string PosCodPC123;
        
        /// <remarks/>
        public string CitPC124;
        
        /// <remarks/>
        public string CouPC125;
        
        /// <remarks/>
        public string NADLNGPC;
        
        /// <remarks/>
        public string TINPC159;
        
        /// <remarks/>
        public string HITPC126;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXPC159")]
        public System.Collections.Generic.List<TAXType> TAXPC159;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TypOfDecHEA24EnumType
    {
        
        /// <remarks/>
        TIR,
        
        /// <remarks/>
        ETIR,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class IdDRVType
    {
        
        /// <remarks/>
        public string IdNumDRV;
        
        /// <remarks/>
        public string IdTypDRV;
        
        /// <remarks/>
        public string IssAuthDRV;
        
        /// <remarks/>
        public string IssCtryDRV;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime IssDatDRV;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IssDatDRVSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ExpDatDRV;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpDatDRVSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TraVehicleType
    {
        
        /// <remarks/>
        public string VehicleTypeCode;
        
        /// <remarks/>
        public string VehicleRegistrationNumber;
        
        /// <remarks/>
        public string VehicleRegistrationLanguage;
        
        /// <remarks/>
        public string VehicleNationality;
        
        /// <remarks/>
        public string VehicleVIN;
        
        /// <remarks/>
        public string VehicleMark;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRADRVType
    {
        
        /// <remarks/>
        public string NamDRV;
        
        /// <remarks/>
        public string SurNameDRV;
        
        /// <remarks/>
        public string NatDRV;
        
        /// <remarks/>
        public string RolDRV;
        
        /// <remarks/>
        public string PlaceOfBrtDRV;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DatOfBrtDRV;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatOfBrtDRVSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdDRV")]
        public System.Collections.Generic.List<IdDRVType> IdDRV;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACONCO1Type
    {
        
        /// <remarks/>
        public string NamCO17;
        
        /// <remarks/>
        public string StrAndNumCO122;
        
        /// <remarks/>
        public string PosCodCO123;
        
        /// <remarks/>
        public string CitCO124;
        
        /// <remarks/>
        public string CouCO125;
        
        /// <remarks/>
        public string NADLNGCO;
        
        /// <remarks/>
        public string TINCO159;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCO159")]
        public System.Collections.Generic.List<TAXType> TAXCO159;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACONCE1Type
    {
        
        /// <remarks/>
        public string NamCE17;
        
        /// <remarks/>
        public string StrAndNumCE122;
        
        /// <remarks/>
        public string PosCodCE123;
        
        /// <remarks/>
        public string CitCE124;
        
        /// <remarks/>
        public string CouCE125;
        
        /// <remarks/>
        public string NADLNGCE;
        
        /// <remarks/>
        public string TINCE159;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCE159")]
        public System.Collections.Generic.List<TAXType> TAXCE159;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CUSOFFTRARNSType
    {
        
        /// <remarks/>
        public string CouRefNumRNS1;
        
        /// <remarks/>
        public string RefNumRNS1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string ArrTimTRACUS085;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CUSOFFDESESTType
    {
        
        /// <remarks/>
        public string CouRefNumEST1;
        
        /// <remarks/>
        public string RefNumEST1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CUSOFFCOMAUTType
    {
        
        /// <remarks/>
        public string CouRefNumAUT1;
        
        /// <remarks/>
        public string RefNumAUT1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CUSOFFPREOFFRESType
    {
        
        /// <remarks/>
        public string CouRefNumRES1;
        
        /// <remarks/>
        public string RefNumRES1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class GUAGUAType
    {
        
        /// <remarks/>
        public GUAGUATypeGuaTypGUA1 GuaTypGUA1;
        
        /// <remarks/>
        public GUAGUATypeGUAREFREF GUAREFREF;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum GUAGUATypeGuaTypGUA1
    {
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class GUAGUATypeGUAREFREF
    {
        
        /// <remarks/>
        public string OthGuaRefREF4;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GOOITEGDSWithRESOFCONROCType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GOOITEGDSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public abstract partial class GOOITEGDSUpperPartType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string IteNumGDS7;
        
        /// <remarks/>
        public string ComCodTarCodGDS10;
        
        /// <remarks/>
        public string GooDesGDS23;
        
        /// <remarks/>
        public string GooDesGDS23LNG;
        
        /// <remarks/>
        public decimal GroMasGDS46;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroMasGDS46Specified;
        
        /// <remarks/>
        public decimal NetMasGDS48;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetMasGDS48Specified;
        
        /// <remarks/>
        public string CouOfDisGDS58;
        
        /// <remarks/>
        public string CouOfDesGDS59;
        
        /// <remarks/>
        public string MetOfPayGDI12;
        
        /// <remarks/>
        public string ComRefNumGIM1;
        
        /// <remarks/>
        public string UNDanGooCodGDI1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PREADMREFAR2")]
        public System.Collections.Generic.List<PREADMREFAR2Type> PREADMREFAR2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRODOCDC2")]
        public System.Collections.Generic.List<PRODOCDC2Type> PRODOCDC2;
        
        /// <remarks/>
        public SPEMENMT2Type SPEMENMT2;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PREADMREFAR2Type
    {
        
        /// <remarks/>
        public string PreDocTypAR21;
        
        /// <remarks/>
        public string PreDocRefAR26;
        
        /// <remarks/>
        public string PreDocRefLNG;
        
        /// <remarks/>
        public string ComOfInfAR29;
        
        /// <remarks/>
        public string ComOfInfAR29LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime PreDocRefDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreDocRefDateSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PRODOCDC2Type
    {
        
        /// <remarks/>
        public string DocTypDC21;
        
        /// <remarks/>
        public string DocRefDC23;
        
        /// <remarks/>
        public string DocRefDCLNG;
        
        /// <remarks/>
        public string ComOfInfDC25;
        
        /// <remarks/>
        public string ComOfInfDC25LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DocRefDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocRefDateSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class SPEMENMT2Type
    {
        
        /// <remarks/>
        public string AddInfMT21;
        
        /// <remarks/>
        public string AddInfMT21LNG;
        
        /// <remarks/>
        public string AddInfCodMT23;
        
        /// <remarks/>
        public string ExpFroECMT24;
        
        /// <remarks/>
        public string ExpFroCouMT25;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class GOOITEGDSWithRESOFCONROCType : GOOITEGDSUpperPartType
    {
        
        /// <remarks/>
        public RESOFCONROCType RESOFCONROC;
        
        /// <remarks/>
        public TRACONCO2Type TRACONCO2;
        
        /// <remarks/>
        public TRACONCE2Type TRACONCE2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONNR2")]
        public System.Collections.Generic.List<CONNR2Type> CONNR2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACGS2")]
        public System.Collections.Generic.List<PACGS2Type> PACGS2;
        
        /// <remarks/>
        public AdditionalGoodsMeasurementType AdditionalGoodsMeasurement;
        
        /// <remarks/>
        public CostType InvoicedCost;
        
        /// <remarks/>
        public SGICODSD2Type SGICODSD2;
        
        /// <remarks/>
        public TRACORSECGOO021Type TRACORSECGOO021;
        
        /// <remarks/>
        public TRACONSECGOO013Type TRACONSECGOO013;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class RESOFCONROCType
    {
        
        /// <remarks/>
        public string DesROC2;
        
        /// <remarks/>
        public string DesROC2LNG;
        
        /// <remarks/>
        public string ConIndROC1;
        
        /// <remarks/>
        public string PoiToTheAttROC51;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACONCO2Type
    {
        
        /// <remarks/>
        public string NamCO27;
        
        /// <remarks/>
        public string StrAndNumCO222;
        
        /// <remarks/>
        public string PosCodCO223;
        
        /// <remarks/>
        public string CitCO224;
        
        /// <remarks/>
        public string CouCO225;
        
        /// <remarks/>
        public string NADLNGGTCO;
        
        /// <remarks/>
        public string TINCO259;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCO259")]
        public System.Collections.Generic.List<TAXType> TAXCO259;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACONCE2Type
    {
        
        /// <remarks/>
        public string NamCE27;
        
        /// <remarks/>
        public string StrAndNumCE222;
        
        /// <remarks/>
        public string PosCodCE223;
        
        /// <remarks/>
        public string CitCE224;
        
        /// <remarks/>
        public string CouCE225;
        
        /// <remarks/>
        public string NADLNGGICE;
        
        /// <remarks/>
        public string TINCE259;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCE259")]
        public System.Collections.Generic.List<TAXType> TAXCE259;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CONNR2Type
    {
        
        /// <remarks/>
        public string ConNumNR21;
        
        /// <remarks/>
        public string NationalityOfContainerCode;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class PACGS2Type
    {
        
        /// <remarks/>
        public string MarNumOfPacGS21;
        
        /// <remarks/>
        public string MarNumOfPacGS21LNG;
        
        /// <remarks/>
        public string KinOfPacGS23;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string NumOfPacGS24;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string NumOfPieGS25;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class AdditionalGoodsMeasurementType
    {
        
        /// <remarks/>
        public string MeasureUnitCode;
        
        /// <remarks/>
        public decimal GoodsQuantity;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CostType
    {
        
        /// <remarks/>
        public decimal CostQuantity;
        
        /// <remarks/>
        public string CostCurrencyCode;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class SGICODSD2Type
    {
        
        /// <remarks/>
        public SGICODSD2TypeSenGooCodSD22 SenGooCodSD22;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SenGooCodSD22Specified;
        
        /// <remarks/>
        public decimal SenQuaSD23;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SGICODSD2TypeSenGooCodSD22
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACORSECGOO021Type
    {
        
        /// <remarks/>
        public string NamTRACORSECGOO025;
        
        /// <remarks/>
        public string StrNumTRACORSECGOO027;
        
        /// <remarks/>
        public string PosCodTRACORSECGOO026;
        
        /// <remarks/>
        public string CitTRACORSECGOO022;
        
        /// <remarks/>
        public string CouCodTRACORSECGOO023;
        
        /// <remarks/>
        public string TRACORSECGOO021LNG;
        
        /// <remarks/>
        public string TINTRACORSECGOO028;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACORSECGOO029")]
        public System.Collections.Generic.List<TAXType> TAXTRACORSECGOO029;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACONSECGOO013Type
    {
        
        /// <remarks/>
        public string NamTRACONSECGOO017;
        
        /// <remarks/>
        public string StrNumTRACONSECGOO019;
        
        /// <remarks/>
        public string PosCodTRACONSECGOO018;
        
        /// <remarks/>
        public string CityTRACONSECGOO014;
        
        /// <remarks/>
        public string CouCodTRACONSECGOO015;
        
        /// <remarks/>
        public string TRACONSECGOO013LNG;
        
        /// <remarks/>
        public string TINTRACONSECGOO020;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACONSECGOO021")]
        public System.Collections.Generic.List<TAXType> TAXTRACONSECGOO021;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class GOOITEGDSType : GOOITEGDSUpperPartType
    {
        
        /// <remarks/>
        public TRACONCO2Type TRACONCO2;
        
        /// <remarks/>
        public TRACONCE2Type TRACONCE2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONNR2")]
        public System.Collections.Generic.List<CONNR2Type> CONNR2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACGS2")]
        public System.Collections.Generic.List<PACGS2Type> PACGS2;
        
        /// <remarks/>
        public AdditionalGoodsMeasurementType AdditionalGoodsMeasurement;
        
        /// <remarks/>
        public CostType InvoicedCost;
        
        /// <remarks/>
        public SGICODSD2Type SGICODSD2;
        
        /// <remarks/>
        public TRACORSECGOO021Type TRACORSECGOO021;
        
        /// <remarks/>
        public TRACONSECGOO013Type TRACONSECGOO013;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public abstract partial class GOOITEGDSLowerPartType
    {
        
        /// <remarks/>
        public TRACONCO2Type TRACONCO2;
        
        /// <remarks/>
        public TRACONCE2Type TRACONCE2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONNR2")]
        public System.Collections.Generic.List<CONNR2Type> CONNR2;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACGS2")]
        public System.Collections.Generic.List<PACGS2Type> PACGS2;
        
        /// <remarks/>
        public AdditionalGoodsMeasurementType AdditionalGoodsMeasurement;
        
        /// <remarks/>
        public CostType InvoicedCost;
        
        /// <remarks/>
        public SGICODSD2Type SGICODSD2;
        
        /// <remarks/>
        public TRACORSECGOO021Type TRACORSECGOO021;
        
        /// <remarks/>
        public TRACONSECGOO013Type TRACONSECGOO013;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ITIType
    {
        
        /// <remarks/>
        public string CouOfRouCodITI1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACORSEC037Type
    {
        
        /// <remarks/>
        public string NamTRACORSEC041;
        
        /// <remarks/>
        public string StrNumTRACORSEC043;
        
        /// <remarks/>
        public string PosCodTRACORSEC042;
        
        /// <remarks/>
        public string CitTRACORSEC038;
        
        /// <remarks/>
        public string CouCodTRACORSEC039;
        
        /// <remarks/>
        public string TRACORSEC037LNG;
        
        /// <remarks/>
        public string TINTRACORSEC044;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACORSEC045")]
        public System.Collections.Generic.List<TAXType> TAXTRACORSEC045;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class TRACONSEC029Type
    {
        
        /// <remarks/>
        public string NameTRACONSEC033;
        
        /// <remarks/>
        public string StrNumTRACONSEC035;
        
        /// <remarks/>
        public string PosCodTRACONSEC034;
        
        /// <remarks/>
        public string CitTRACONSEC030;
        
        /// <remarks/>
        public string CouCodTRACONSEC031;
        
        /// <remarks/>
        public string TRACONSEC029LNG;
        
        /// <remarks/>
        public string TINTRACONSEC036;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACONSEC037")]
        public System.Collections.Generic.List<TAXType> TAXTRACONSEC037;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class FUNERRER1Type
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string ErrTypER11;
        
        /// <remarks/>
        public string ErrPoiER12;
        
        /// <remarks/>
        public string ErrReaER13;
        
        /// <remarks/>
        public string OriAttValER14;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class SEAINFSLIType
    {
        
        /// <remarks/>
        public SEAINFSLITypeSealsIntact SealsIntact;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SealsIntactSpecified;
        
        /// <remarks/>
        public string SeaNumber;
        
        /// <remarks/>
        public string SEAIDSID;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SEAINFSLITypeSealsIntact
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CONTRESULTSType
    {
        
        /// <remarks/>
        public string ConResCode;
        
        /// <remarks/>
        public string ComConRes;
        
        /// <remarks/>
        public string ComConResLNG;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ADDITIONALINFORMATIONType
    {
        
        /// <remarks/>
        public string CustomsRemarks;
        
        /// <remarks/>
        public ADDITIONALINFORMATIONTypeHeavyBulkyGoodsInd HeavyBulkyGoodsInd;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeavyBulkyGoodsIndSpecified;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ADDITIONALINFORMATIONTypeHeavyBulkyGoodsInd
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class CNECNEType
    {
        
        /// <remarks/>
        public string NamCNE17;
        
        /// <remarks/>
        public string StrAndNumCNE122;
        
        /// <remarks/>
        public string PosCodCNE123;
        
        /// <remarks/>
        public string CitCNE124;
        
        /// <remarks/>
        public string CouCNE125;
        
        /// <remarks/>
        public string NADLNGACT;
        
        /// <remarks/>
        public string TINCNE59;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCNE59")]
        public System.Collections.Generic.List<TAXType> TAXCNE59;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD928
    {
        
        /// <remarks/>
        public EPD928HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD928HEAHEA
    {
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string GuaranteeNumber;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD005
    {
        
        /// <remarks/>
        public EPD005HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FUNERRER1")]
        public System.Collections.Generic.List<FUNERRER1Type> FUNERRER1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD005HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime AmendmentDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmendmentDateSpecified;
        
        /// <remarks/>
        public string AmdDatHEA599;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime AmendmentRejectionDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmendmentRejectionDateSpecified;
        
        /// <remarks/>
        public string AmeRejDatHEA603;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string AmeRejMotCodHEA604;
        
        /// <remarks/>
        public string AmeRejMotTexHEA605;
        
        /// <remarks/>
        public string AmeRejMotTexHEA605LNG;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD009
    {
        
        /// <remarks/>
        public EPD009HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD009HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        public EPD009HEAHEACanDecHEA93 CanDecHEA93;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanDecHEA93Specified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime CancellationRequestDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancellationRequestDateSpecified;
        
        /// <remarks/>
        public string DatOfCanReqHEA147;
        
        /// <remarks/>
        public EPD009HEAHEACanIniByCusHEA94 CanIniByCusHEA94;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanIniByCusHEA94Specified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime CancellationDecisionDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancellationDecisionDateSpecified;
        
        /// <remarks/>
        public string DatOfCanDecHEA146;
        
        /// <remarks/>
        public string CanJusHEA248;
        
        /// <remarks/>
        public string CanJusHEA248LNG;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD009HEAHEACanDecHEA93
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD009HEAHEACanIniByCusHEA94
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD013
    {
        
        /// <remarks/>
        public EPD013HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public TRACONCO1Type TRACONCO1;
        
        /// <remarks/>
        public TRACONCE1Type TRACONCE1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public System.Collections.Generic.List<TraVehicleType> TRAMEANS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TRADRV")]
        public System.Collections.Generic.List<TRADRVType> TRADRV;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CUSOFFTRARNS")]
        public System.Collections.Generic.List<CUSOFFTRARNSType> CUSOFFTRARNS;
        
        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST;
        
        /// <remarks/>
        public EPD013CTLCL1 CTLCL1;
        
        /// <remarks/>
        public GUAGUAType GUAGUA;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GOOITEGDS")]
        public System.Collections.Generic.List<GOOITEGDSType> GOOITEGDS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITI")]
        public System.Collections.Generic.List<ITIType> ITI;
        
        /// <remarks/>
        public TRACORSEC037Type TRACORSEC037;
        
        /// <remarks/>
        public TRACONSEC029Type TRACONSEC029;
        
        public virtual bool ShouldSerializeTRAMEANS()
        {
            return ((this.TRAMEANS != null) 
                        && (this.TRAMEANS.Count > 0));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD013HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        public TypOfDecHEA24EnumType TypOfDecHEA24;
        
        /// <remarks/>
        public string CouOfDesCodHEA30;
        
        /// <remarks/>
        public string AgrLocOfGooCodHEA38;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39LNG;
        
        /// <remarks/>
        public string PlaOfLoaCodHEA46;
        
        /// <remarks/>
        public string CouOfDisCodHEA55;
        
        /// <remarks/>
        public EPD013HEAHEAInlTraModHEA75 InlTraModHEA75;
        
        /// <remarks/>
        public EPD013HEAHEATraModAtBorHEA76 TraModAtBorHEA76;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraAtDHEA80;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraCroHEA87;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string TypOfMeaOfTraCroHEA88;
        
        /// <remarks/>
        public EPD013HEAHEAConIndHEA96 ConIndHEA96;
        
        /// <remarks/>
        public string NCTSAccDocHEA601LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfIteHEA305;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfPacHEA306;
        
        /// <remarks/>
        public decimal TotGroMasHEA307;
        
        /// <remarks/>
        public string AmdPlaHEA598;
        
        /// <remarks/>
        public string AmdPlaHEA598LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime AmendmentDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmendmentDateSpecified;
        
        /// <remarks/>
        public string AmdDatHEA599;
        
        /// <remarks/>
        public string SpeCirIndHEA1;
        
        /// <remarks/>
        public string TraChaMetOfPayHEA1;
        
        /// <remarks/>
        public EPD013HEAHEASecHEA358 SecHEA358;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecHEA358Specified;
        
        /// <remarks/>
        public string CodPlUnHEA357;
        
        /// <remarks/>
        public string CodPlUnHEA357LNG;
        
        /// <remarks/>
        public string VehicleMakeName;
        
        /// <remarks/>
        public string VehicleModelName;
        
        /// <remarks/>
        public string VehicleVIN;
        
        /// <remarks/>
        public string TypeOfMvt;
        
        /// <remarks/>
        public CostType TotalInvoicedCost;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD013HEAHEAInlTraModHEA75
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD013HEAHEATraModAtBorHEA76
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD013HEAHEAConIndHEA96
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD013HEAHEASecHEA358
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD013CTLCL1
    {
        
        /// <remarks/>
        public EPD013CTLCL1AmeTypFlaCL628 AmeTypFlaCL628;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD013CTLCL1AmeTypFlaCL628
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD014
    {
        
        /// <remarks/>
        public EPD014HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public TRACONCO1Type TRACONCO1;
        
        /// <remarks/>
        public TRACONCE1Type TRACONCE1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD014HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime CancellationRequestDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancellationRequestDateSpecified;
        
        /// <remarks/>
        public string DatOfCanReqHEA147;
        
        /// <remarks/>
        public string CanReaHEA250;
        
        /// <remarks/>
        public string CanReaHEA250LNG;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD015
    {
        
        /// <remarks/>
        public EPD015HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public TRACONCO1Type TRACONCO1;
        
        /// <remarks/>
        public TRACONCE1Type TRACONCE1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public System.Collections.Generic.List<TraVehicleType> TRAMEANS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TRADRV")]
        public System.Collections.Generic.List<TRADRVType> TRADRV;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CUSOFFTRARNS")]
        public System.Collections.Generic.List<CUSOFFTRARNSType> CUSOFFTRARNS;
        
        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST;
        
        /// <remarks/>
        public GUAGUAType GUAGUA;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GOOITEGDS")]
        public System.Collections.Generic.List<GOOITEGDSType> GOOITEGDS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITI")]
        public System.Collections.Generic.List<ITIType> ITI;
        
        /// <remarks/>
        public TRACORSEC037Type TRACORSEC037;
        
        /// <remarks/>
        public TRACONSEC029Type TRACONSEC029;
        
        public virtual bool ShouldSerializeTRAMEANS()
        {
            return ((this.TRAMEANS != null) 
                        && (this.TRAMEANS.Count > 0));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD015HEAHEA
    {
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string PreviousRefNumHEA4;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        public TypOfDecHEA24EnumType TypOfDecHEA24;
        
        /// <remarks/>
        public string CouOfDesCodHEA30;
        
        /// <remarks/>
        public string AgrLocOfGooCodHEA38;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39LNG;
        
        /// <remarks/>
        public string PlaOfLoaCodHEA46;
        
        /// <remarks/>
        public string CouOfDisCodHEA55;
        
        /// <remarks/>
        public EPD015HEAHEAInlTraModHEA75 InlTraModHEA75;
        
        /// <remarks/>
        public EPD015HEAHEATraModAtBorHEA76 TraModAtBorHEA76;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraAtDHEA80;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraCroHEA87;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string TypOfMeaOfTraCroHEA88;
        
        /// <remarks/>
        public EPD015HEAHEAConIndHEA96 ConIndHEA96;
        
        /// <remarks/>
        public string NCTSAccDocHEA601LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfIteHEA305;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfPacHEA306;
        
        /// <remarks/>
        public decimal TotGroMasHEA307;
        
        /// <remarks/>
        public string DecDatHEA383;
        
        /// <remarks/>
        public string DecPlaHEA394;
        
        /// <remarks/>
        public string DecPlaHEA394LNG;
        
        /// <remarks/>
        public string SpeCirIndHEA1;
        
        /// <remarks/>
        public string TraChaMetOfPayHEA1;
        
        /// <remarks/>
        public EPD015HEAHEASecHEA358 SecHEA358;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecHEA358Specified;
        
        /// <remarks/>
        public string CodPlUnHEA357;
        
        /// <remarks/>
        public string CodPlUnHEA357LNG;
        
        /// <remarks/>
        public string VehicleMakeName;
        
        /// <remarks/>
        public string VehicleModelName;
        
        /// <remarks/>
        public string VehicleVIN;
        
        /// <remarks/>
        public string TypeOfMvt;
        
        /// <remarks/>
        public CostType TotalInvoicedCost;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD015HEAHEAInlTraModHEA75
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD015HEAHEATraModAtBorHEA76
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD015HEAHEAConIndHEA96
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD015HEAHEASecHEA358
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD016
    {
        
        /// <remarks/>
        public EPD016HEAHEA HEAHEA;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FUNERRER1")]
        public System.Collections.Generic.List<FUNERRER1Type> FUNERRER1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD016HEAHEA
    {
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        public TypOfDecHEA24EnumType TypOfDecHEA24;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DeclarationRejectionDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationRejectionDateSpecified;
        
        /// <remarks/>
        public string DecRejDatHEA159;
        
        /// <remarks/>
        public string DecRejReaHEA252;
        
        /// <remarks/>
        public string DecRejReaHEA252LNG;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD025
    {
        
        /// <remarks/>
        public EPD025HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SEAINFSLI")]
        public System.Collections.Generic.List<SEAINFSLIType> SEAINFSLI;
        
        /// <remarks/>
        public CONTRESULTSType CONTRESULTS;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD025HEAHEA
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeNumber", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TIRCarnet", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExitDate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MessageDate", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public string Item1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <remarks/>
        GuaranteeNumber,
        
        /// <remarks/>
        TIRCarnet,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum Item1ChoiceType
    {
        
        /// <remarks/>
        ExitDate,
        
        /// <remarks/>
        MessageDate,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD028
    {
        
        /// <remarks/>
        public EPD028HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD028HEAHEA
    {
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DeclarationAcceptanceDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationAcceptanceDateSpecified;
        
        /// <remarks/>
        public string AccDatHEA158;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD029
    {
        
        /// <remarks/>
        public EPD029HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public TRACONCO1Type TRACONCO1;
        
        /// <remarks/>
        public TRACONCE1Type TRACONCE1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public System.Collections.Generic.List<TraVehicleType> TRAMEANS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TRADRV")]
        public System.Collections.Generic.List<TRADRVType> TRADRV;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CUSOFFTRARNS")]
        public System.Collections.Generic.List<CUSOFFTRARNSType> CUSOFFTRARNS;
        
        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SEAINFSLI")]
        public System.Collections.Generic.List<SEAINFSLIType> SEAINFSLI;
        
        /// <remarks/>
        public GUAGUAType GUAGUA;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GOOITEGDS")]
        public System.Collections.Generic.List<GOOITEGDSType> GOOITEGDS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITI")]
        public System.Collections.Generic.List<ITIType> ITI;
        
        /// <remarks/>
        public TRACORSEC037Type TRACORSEC037;
        
        /// <remarks/>
        public TRACONSEC029Type TRACONSEC029;
        
        public virtual bool ShouldSerializeTRAMEANS()
        {
            return ((this.TRAMEANS != null) 
                        && (this.TRAMEANS.Count > 0));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD029HEAHEA
    {
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        public TypOfDecHEA24EnumType TypOfDecHEA24;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypOfDecHEA24Specified;
        
        /// <remarks/>
        public string CouOfDesCodHEA30;
        
        /// <remarks/>
        public string AgrLocOfGooCodHEA38;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39LNG;
        
        /// <remarks/>
        public string PlaOfLoaCodHEA46;
        
        /// <remarks/>
        public string CouOfDisCodHEA55;
        
        /// <remarks/>
        public EPD029HEAHEAInlTraModHEA75 InlTraModHEA75;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InlTraModHEA75Specified;
        
        /// <remarks/>
        public EPD029HEAHEATraModAtBorHEA76 TraModAtBorHEA76;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TraModAtBorHEA76Specified;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraAtDHEA80;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraCroHEA87;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string TypOfMeaOfTraCroHEA88;
        
        /// <remarks/>
        public EPD029HEAHEAConIndHEA96 ConIndHEA96;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConIndHEA96Specified;
        
        /// <remarks/>
        public EPD029HEAHEANCTRetCopHEA104 NCTRetCopHEA104;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NCTRetCopHEA104Specified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DeclarationAcceptanceDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationAcceptanceDateSpecified;
        
        /// <remarks/>
        public string AccDatHEA158;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DeclarationReleasedDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationReleasedDateSpecified;
        
        /// <remarks/>
        public string IssDatHEA186;
        
        /// <remarks/>
        public string NCTSAccDocHEA601LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfIteHEA305;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfPacHEA306;
        
        /// <remarks/>
        public decimal TotGroMasHEA307;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotGroMasHEA307Specified;
        
        /// <remarks/>
        public EPD029HEAHEABinItiHEA246 BinItiHEA246;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BinItiHEA246Specified;
        
        /// <remarks/>
        public ADDITIONALINFORMATIONType ADDITIONALINFORMATION;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DeclarationDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationDateSpecified;
        
        /// <remarks/>
        public string DecDatHEA383;
        
        /// <remarks/>
        public string DecPlaHEA394;
        
        /// <remarks/>
        public string DecPlaHEA394LNG;
        
        /// <remarks/>
        public string SpeCirIndHEA1;
        
        /// <remarks/>
        public string TraChaMetOfPayHEA1;
        
        /// <remarks/>
        public EPD029HEAHEASecHEA358 SecHEA358;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecHEA358Specified;
        
        /// <remarks/>
        public string CodPlUnHEA357;
        
        /// <remarks/>
        public string CodPlUnHEA357LNG;
        
        /// <remarks/>
        public string VehicleMakeName;
        
        /// <remarks/>
        public string VehicleModelName;
        
        /// <remarks/>
        public string VehicleVIN;
        
        /// <remarks/>
        public string TypeOfMvt;
        
        /// <remarks/>
        public CostType TotalInvoicedCost;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD029HEAHEAInlTraModHEA75
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD029HEAHEATraModAtBorHEA76
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD029HEAHEAConIndHEA96
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD029HEAHEANCTRetCopHEA104
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD029HEAHEABinItiHEA246
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD029HEAHEASecHEA358
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD045
    {
        
        /// <remarks/>
        public EPD045HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SEAINFSLI")]
        public System.Collections.Generic.List<SEAINFSLIType> SEAINFSLI;
        
        /// <remarks/>
        public CONTRESULTSType CONTRESULTS;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD045HEAHEA
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeNumber", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TIRCarnet", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string WriteOffDate;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <remarks/>
        GuaranteeNumber,
        
        /// <remarks/>
        TIRCarnet,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD051
    {
        
        /// <remarks/>
        public EPD051HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public TRACONCO1Type TRACONCO1;
        
        /// <remarks/>
        public TRACONCE1Type TRACONCE1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public System.Collections.Generic.List<TraVehicleType> TRAMEANS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TRADRV")]
        public System.Collections.Generic.List<TRADRVType> TRADRV;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CUSOFFTRARNS")]
        public System.Collections.Generic.List<CUSOFFTRARNSType> CUSOFFTRARNS;
        
        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST;
        
        /// <remarks/>
        public EPD051CONRESERS CONRESERS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RESOFCON534")]
        public System.Collections.Generic.List<EPD051RESOFCON534> RESOFCON534;
        
        /// <remarks/>
        public GUAGUAType GUAGUA;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GOOITEGDS")]
        public System.Collections.Generic.List<GOOITEGDSWithRESOFCONROCType> GOOITEGDS;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITI")]
        public System.Collections.Generic.List<ITIType> ITI;
        
        /// <remarks/>
        public TRACORSEC037Type TRACORSEC037;
        
        /// <remarks/>
        public TRACONSEC029Type TRACONSEC029;
        
        public virtual bool ShouldSerializeTRAMEANS()
        {
            return ((this.TRAMEANS != null) 
                        && (this.TRAMEANS.Count > 0));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD051HEAHEA
    {
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        public TypOfDecHEA24EnumType TypOfDecHEA24;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypOfDecHEA24Specified;
        
        /// <remarks/>
        public string CouOfDesCodHEA30;
        
        /// <remarks/>
        public string AgrLocOfGooCodHEA38;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39;
        
        /// <remarks/>
        public string AgrLocOfGooHEA39LNG;
        
        /// <remarks/>
        public string PlaOfLoaCodHEA46;
        
        /// <remarks/>
        public string CouOfDisCodHEA55;
        
        /// <remarks/>
        public EPD051HEAHEAInlTraModHEA75 InlTraModHEA75;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InlTraModHEA75Specified;
        
        /// <remarks/>
        public EPD051HEAHEATraModAtBorHEA76 TraModAtBorHEA76;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TraModAtBorHEA76Specified;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78;
        
        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraAtDHEA80;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85;
        
        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85LNG;
        
        /// <remarks/>
        public string NatOfMeaOfTraCroHEA87;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
        public string TypOfMeaOfTraCroHEA88;
        
        /// <remarks/>
        public EPD051HEAHEAConIndHEA96 ConIndHEA96;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConIndHEA96Specified;
        
        /// <remarks/>
        public string NCTSAccDocHEA601LNG;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfIteHEA305;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TotNumOfPacHEA306;
        
        /// <remarks/>
        public decimal TotGroMasHEA307;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotGroMasHEA307Specified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DeclarationDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationDateSpecified;
        
        /// <remarks/>
        public string DecDatHEA383;
        
        /// <remarks/>
        public string DecPlaHEA394;
        
        /// <remarks/>
        public string DecPlaHEA394LNG;
        
        /// <remarks/>
        public string NoRelMotHEA272;
        
        /// <remarks/>
        public string NoRelMotHEA272LNG;
        
        /// <remarks/>
        public string SpeCirIndHEA1;
        
        /// <remarks/>
        public string TraChaMetOfPayHEA1;
        
        /// <remarks/>
        public EPD051HEAHEASecHEA358 SecHEA358;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecHEA358Specified;
        
        /// <remarks/>
        public string CodPlUnHEA357;
        
        /// <remarks/>
        public string CodPlUnHEA357LNG;
        
        /// <remarks/>
        public string VehicleMakeName;
        
        /// <remarks/>
        public string VehicleModelName;
        
        /// <remarks/>
        public string VehicleVIN;
        
        /// <remarks/>
        public string TypeOfMvt;
        
        /// <remarks/>
        public CostType TotalInvoicedCost;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD051HEAHEAInlTraModHEA75
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD051HEAHEATraModAtBorHEA76
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD051HEAHEAConIndHEA96
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD051HEAHEASecHEA358
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD051CONRESERS
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ControlDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ControlDateSpecified;
        
        /// <remarks/>
        public string ConDatERS14;
        
        /// <remarks/>
        public string ConResCodERS16;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD051RESOFCON534
    {
        
        /// <remarks/>
        public string DesTOC2;
        
        /// <remarks/>
        public string DesTOC2LNG;
        
        /// <remarks/>
        public string ConInd424;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD055
    {
        
        /// <remarks/>
        public EPD055HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        public EPD055GUAREF2 GUAREF2;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD055HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD055GUAREF2
    {
        
        /// <remarks/>
        public string GuaRefNumGRNREF21;
        
        /// <remarks/>
        public EPD055GUAREF2INVGUARNS INVGUARNS;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD055GUAREF2INVGUARNS
    {
        
        /// <remarks/>
        public string InvGuaReaCodRNS11;
        
        /// <remarks/>
        public string InvGuaReaRNS12;
        
        /// <remarks/>
        public string InvGuaReaRNS12LNG;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD060
    {
        
        /// <remarks/>
        public EPD060HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD060HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string GuaranteeNumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ControlNotificationDate;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ControlNotificationDateSpecified;
        
        /// <remarks/>
        public string DatOfConNotHEA148;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD140
    {
        
        /// <remarks/>
        public EPD140HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT;
        
        /// <remarks/>
        public CUSOFFCOMAUTType CUSOFFCOMAUT;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD140HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string DatLimResHEA144;
        
        /// <remarks/>
        public string DatReqNonArrMovHEA149;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD141
    {
        
        /// <remarks/>
        public EPD141HEAHEA HEAHEA;
        
        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1;
        
        /// <remarks/>
        public CUSOFFCOMAUTType CUSOFFCOMAUT;
        
        /// <remarks/>
        public CUSOFFPREOFFRESType CUSOFFPREOFFRES;
        
        /// <remarks/>
        public EPD141ENQENQ ENQENQ;
        
        /// <remarks/>
        public CNECNEType CNECNE;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD141HEAHEA
    {
        
        /// <remarks/>
        public string DocNumHEA5;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD141ENQENQ
    {
        
        /// <remarks/>
        public EPD141ENQENQTC11DelENQ155 TC11DelENQ155;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TC11DelENQ155Specified;
        
        /// <remarks/>
        public string TC11DelDatENQ143;
        
        /// <remarks/>
        public string InfoEnq148;
        
        /// <remarks/>
        public string InfoEnq148LNG;
        
        /// <remarks/>
        public EPD141ENQENQInfOnPapAvaENQ790 InfOnPapAvaENQ790;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD141ENQENQTC11DelENQ155
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum EPD141ENQENQInfOnPapAvaENQ790
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EPD917
    {
        
        /// <remarks/>
        public EPD917HEAHEA HEAHEA;
        
        /// <remarks/>
        public FUNERRER1Type FUNERRER1;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5494")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class EPD917HEAHEA
    {
        
        /// <remarks/>
        public string OriMesIdeMES22;
        
        /// <remarks/>
        public string DocNumHEA5;
        
        /// <remarks/>
        public string RefNumHEA4;
        
        /// <remarks/>
        public string GuaranteeNumber;
    }
}
