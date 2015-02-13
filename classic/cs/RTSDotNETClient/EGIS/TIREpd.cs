using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Generic;

namespace RTSDotNETClient.EGIS
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CONTRESULTSType
    {

        private string conResCodeField;

        private string comConResField;

        private string comConResLNGField;

        /// <remarks/>
        public string ConResCode
        {
            get
            {
                return this.conResCodeField;
            }
            set
            {
                this.conResCodeField = value;
            }
        }

        /// <remarks/>
        public string ComConRes
        {
            get
            {
                return this.comConResField;
            }
            set
            {
                this.comConResField = value;
            }
        }

        /// <remarks/>
        public string ComConResLNG
        {
            get
            {
                return this.comConResLNGField;
            }
            set
            {
                this.comConResLNGField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACONSEC029Type
    {

        private string nameTRACONSEC033Field;

        private string strNumTRACONSEC035Field;

        private string posCodTRACONSEC034Field;

        private string citTRACONSEC030Field;

        private string couCodTRACONSEC031Field;

        private string tRACONSEC029LNGField;

        private string tINTRACONSEC036Field;

        private List<TAXType> tAXTRACONSEC037Field;

        /// <remarks/>
        public string NameTRACONSEC033
        {
            get
            {
                return this.nameTRACONSEC033Field;
            }
            set
            {
                this.nameTRACONSEC033Field = value;
            }
        }

        /// <remarks/>
        public string StrNumTRACONSEC035
        {
            get
            {
                return this.strNumTRACONSEC035Field;
            }
            set
            {
                this.strNumTRACONSEC035Field = value;
            }
        }

        /// <remarks/>
        public string PosCodTRACONSEC034
        {
            get
            {
                return this.posCodTRACONSEC034Field;
            }
            set
            {
                this.posCodTRACONSEC034Field = value;
            }
        }

        /// <remarks/>
        public string CitTRACONSEC030
        {
            get
            {
                return this.citTRACONSEC030Field;
            }
            set
            {
                this.citTRACONSEC030Field = value;
            }
        }

        /// <remarks/>
        public string CouCodTRACONSEC031
        {
            get
            {
                return this.couCodTRACONSEC031Field;
            }
            set
            {
                this.couCodTRACONSEC031Field = value;
            }
        }

        /// <remarks/>
        public string TRACONSEC029LNG
        {
            get
            {
                return this.tRACONSEC029LNGField;
            }
            set
            {
                this.tRACONSEC029LNGField = value;
            }
        }

        /// <remarks/>
        public string TINTRACONSEC036
        {
            get
            {
                return this.tINTRACONSEC036Field;
            }
            set
            {
                this.tINTRACONSEC036Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXTRACONSEC037Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACONSEC037")]
        public List<TAXType> TAXTRACONSEC037
        {
            get
            {
                return this.tAXTRACONSEC037Field;
            }
            set
            {
                this.tAXTRACONSEC037Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TAXType
    {

        private string purposeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACORSEC037Type
    {

        private string namTRACORSEC041Field;

        private string strNumTRACORSEC043Field;

        private string posCodTRACORSEC042Field;

        private string citTRACORSEC038Field;

        private string couCodTRACORSEC039Field;

        private string tRACORSEC037LNGField;

        private string tINTRACORSEC044Field;

        private List<TAXType> tAXTRACORSEC045Field;

        /// <remarks/>
        public string NamTRACORSEC041
        {
            get
            {
                return this.namTRACORSEC041Field;
            }
            set
            {
                this.namTRACORSEC041Field = value;
            }
        }

        /// <remarks/>
        public string StrNumTRACORSEC043
        {
            get
            {
                return this.strNumTRACORSEC043Field;
            }
            set
            {
                this.strNumTRACORSEC043Field = value;
            }
        }

        /// <remarks/>
        public string PosCodTRACORSEC042
        {
            get
            {
                return this.posCodTRACORSEC042Field;
            }
            set
            {
                this.posCodTRACORSEC042Field = value;
            }
        }

        /// <remarks/>
        public string CitTRACORSEC038
        {
            get
            {
                return this.citTRACORSEC038Field;
            }
            set
            {
                this.citTRACORSEC038Field = value;
            }
        }

        /// <remarks/>
        public string CouCodTRACORSEC039
        {
            get
            {
                return this.couCodTRACORSEC039Field;
            }
            set
            {
                this.couCodTRACORSEC039Field = value;
            }
        }

        /// <remarks/>
        public string TRACORSEC037LNG
        {
            get
            {
                return this.tRACORSEC037LNGField;
            }
            set
            {
                this.tRACORSEC037LNGField = value;
            }
        }

        /// <remarks/>
        public string TINTRACORSEC044
        {
            get
            {
                return this.tINTRACORSEC044Field;
            }
            set
            {
                this.tINTRACORSEC044Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXTRACORSEC045Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACORSEC045")]
        public List<TAXType> TAXTRACORSEC045
        {
            get
            {
                return this.tAXTRACORSEC045Field;
            }
            set
            {
                this.tAXTRACORSEC045Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ITIType
    {

        private string couOfRouCodITI1Field;

        /// <remarks/>
        public string CouOfRouCodITI1
        {
            get
            {
                return this.couOfRouCodITI1Field;
            }
            set
            {
                this.couOfRouCodITI1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RESOFCONROCType
    {

        private string desROC2Field;

        private string desROC2LNGField;

        private string conIndROC1Field;

        private string poiToTheAttROC51Field;

        /// <remarks/>
        public string DesROC2
        {
            get
            {
                return this.desROC2Field;
            }
            set
            {
                this.desROC2Field = value;
            }
        }

        /// <remarks/>
        public string DesROC2LNG
        {
            get
            {
                return this.desROC2LNGField;
            }
            set
            {
                this.desROC2LNGField = value;
            }
        }

        /// <remarks/>
        public string ConIndROC1
        {
            get
            {
                return this.conIndROC1Field;
            }
            set
            {
                this.conIndROC1Field = value;
            }
        }

        /// <remarks/>
        public string PoiToTheAttROC51
        {
            get
            {
                return this.poiToTheAttROC51Field;
            }
            set
            {
                this.poiToTheAttROC51Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACONSECGOO013Type
    {

        private string namTRACONSECGOO017Field;

        private string strNumTRACONSECGOO019Field;

        private string posCodTRACONSECGOO018Field;

        private string cityTRACONSECGOO014Field;

        private string couCodTRACONSECGOO015Field;

        private string tRACONSECGOO013LNGField;

        private string tINTRACONSECGOO020Field;

        private List<TAXType> tAXTRACONSECGOO021Field;

        /// <remarks/>
        public string NamTRACONSECGOO017
        {
            get
            {
                return this.namTRACONSECGOO017Field;
            }
            set
            {
                this.namTRACONSECGOO017Field = value;
            }
        }

        /// <remarks/>
        public string StrNumTRACONSECGOO019
        {
            get
            {
                return this.strNumTRACONSECGOO019Field;
            }
            set
            {
                this.strNumTRACONSECGOO019Field = value;
            }
        }

        /// <remarks/>
        public string PosCodTRACONSECGOO018
        {
            get
            {
                return this.posCodTRACONSECGOO018Field;
            }
            set
            {
                this.posCodTRACONSECGOO018Field = value;
            }
        }

        /// <remarks/>
        public string CityTRACONSECGOO014
        {
            get
            {
                return this.cityTRACONSECGOO014Field;
            }
            set
            {
                this.cityTRACONSECGOO014Field = value;
            }
        }

        /// <remarks/>
        public string CouCodTRACONSECGOO015
        {
            get
            {
                return this.couCodTRACONSECGOO015Field;
            }
            set
            {
                this.couCodTRACONSECGOO015Field = value;
            }
        }

        /// <remarks/>
        public string TRACONSECGOO013LNG
        {
            get
            {
                return this.tRACONSECGOO013LNGField;
            }
            set
            {
                this.tRACONSECGOO013LNGField = value;
            }
        }

        /// <remarks/>
        public string TINTRACONSECGOO020
        {
            get
            {
                return this.tINTRACONSECGOO020Field;
            }
            set
            {
                this.tINTRACONSECGOO020Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXTRACONSECGOO021Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACONSECGOO021")]
        public List<TAXType> TAXTRACONSECGOO021
        {
            get
            {
                return this.tAXTRACONSECGOO021Field;
            }
            set
            {
                this.tAXTRACONSECGOO021Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACORSECGOO021Type
    {

        private string namTRACORSECGOO025Field;

        private string strNumTRACORSECGOO027Field;

        private string posCodTRACORSECGOO026Field;

        private string citTRACORSECGOO022Field;

        private string couCodTRACORSECGOO023Field;

        private string tRACORSECGOO021LNGField;

        private string tINTRACORSECGOO028Field;

        private List<TAXType> tAXTRACORSECGOO029Field;

        /// <remarks/>
        public string NamTRACORSECGOO025
        {
            get
            {
                return this.namTRACORSECGOO025Field;
            }
            set
            {
                this.namTRACORSECGOO025Field = value;
            }
        }

        /// <remarks/>
        public string StrNumTRACORSECGOO027
        {
            get
            {
                return this.strNumTRACORSECGOO027Field;
            }
            set
            {
                this.strNumTRACORSECGOO027Field = value;
            }
        }

        /// <remarks/>
        public string PosCodTRACORSECGOO026
        {
            get
            {
                return this.posCodTRACORSECGOO026Field;
            }
            set
            {
                this.posCodTRACORSECGOO026Field = value;
            }
        }

        /// <remarks/>
        public string CitTRACORSECGOO022
        {
            get
            {
                return this.citTRACORSECGOO022Field;
            }
            set
            {
                this.citTRACORSECGOO022Field = value;
            }
        }

        /// <remarks/>
        public string CouCodTRACORSECGOO023
        {
            get
            {
                return this.couCodTRACORSECGOO023Field;
            }
            set
            {
                this.couCodTRACORSECGOO023Field = value;
            }
        }

        /// <remarks/>
        public string TRACORSECGOO021LNG
        {
            get
            {
                return this.tRACORSECGOO021LNGField;
            }
            set
            {
                this.tRACORSECGOO021LNGField = value;
            }
        }

        /// <remarks/>
        public string TINTRACORSECGOO028
        {
            get
            {
                return this.tINTRACORSECGOO028Field;
            }
            set
            {
                this.tINTRACORSECGOO028Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXTRACORSECGOO029Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXTRACORSECGOO029")]
        public List<TAXType> TAXTRACORSECGOO029
        {
            get
            {
                return this.tAXTRACORSECGOO029Field;
            }
            set
            {
                this.tAXTRACORSECGOO029Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SGICODSD2Type
    {

        private SGICODSD2TypeSenGooCodSD22 senGooCodSD22Field;

        private bool senGooCodSD22FieldSpecified;

        private decimal senQuaSD23Field;

        /// <remarks/>
        public SGICODSD2TypeSenGooCodSD22 SenGooCodSD22
        {
            get
            {
                return this.senGooCodSD22Field;
            }
            set
            {
                this.senGooCodSD22Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SenGooCodSD22Specified
        {
            get
            {
                return this.senGooCodSD22FieldSpecified;
            }
            set
            {
                this.senGooCodSD22FieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SenQuaSD23
        {
            get
            {
                return this.senQuaSD23Field;
            }
            set
            {
                this.senQuaSD23Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum SGICODSD2TypeSenGooCodSD22
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AdditionalGoodsMeasurementType
    {

        private string measureUnitCodeField;

        private decimal goodsQuantityField;

        /// <remarks/>
        public string MeasureUnitCode
        {
            get
            {
                return this.measureUnitCodeField;
            }
            set
            {
                this.measureUnitCodeField = value;
            }
        }

        /// <remarks/>
        public decimal GoodsQuantity
        {
            get
            {
                return this.goodsQuantityField;
            }
            set
            {
                this.goodsQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PACGS2Type
    {

        private string marNumOfPacGS21Field;

        private string marNumOfPacGS21LNGField;

        private string kinOfPacGS23Field;

        private string numOfPacGS24Field;

        private string numOfPieGS25Field;

        /// <remarks/>
        public string MarNumOfPacGS21
        {
            get
            {
                return this.marNumOfPacGS21Field;
            }
            set
            {
                this.marNumOfPacGS21Field = value;
            }
        }

        /// <remarks/>
        public string MarNumOfPacGS21LNG
        {
            get
            {
                return this.marNumOfPacGS21LNGField;
            }
            set
            {
                this.marNumOfPacGS21LNGField = value;
            }
        }

        /// <remarks/>
        public string KinOfPacGS23
        {
            get
            {
                return this.kinOfPacGS23Field;
            }
            set
            {
                this.kinOfPacGS23Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NumOfPacGS24
        {
            get
            {
                return this.numOfPacGS24Field;
            }
            set
            {
                this.numOfPacGS24Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NumOfPieGS25
        {
            get
            {
                return this.numOfPieGS25Field;
            }
            set
            {
                this.numOfPieGS25Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CONNR2Type
    {

        private string conNumNR21Field;

        private string nationalityOfContainerCodeField;

        /// <remarks/>
        public string ConNumNR21
        {
            get
            {
                return this.conNumNR21Field;
            }
            set
            {
                this.conNumNR21Field = value;
            }
        }

        /// <remarks/>
        public string NationalityOfContainerCode
        {
            get
            {
                return this.nationalityOfContainerCodeField;
            }
            set
            {
                this.nationalityOfContainerCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACONCE2Type
    {

        private string namCE27Field;

        private string strAndNumCE222Field;

        private string posCodCE223Field;

        private string citCE224Field;

        private string couCE225Field;

        private string nADLNGGICEField;

        private string tINCE259Field;

        private List<TAXType> tAXCE259Field;

        /// <remarks/>
        public string NamCE27
        {
            get
            {
                return this.namCE27Field;
            }
            set
            {
                this.namCE27Field = value;
            }
        }

        /// <remarks/>
        public string StrAndNumCE222
        {
            get
            {
                return this.strAndNumCE222Field;
            }
            set
            {
                this.strAndNumCE222Field = value;
            }
        }

        /// <remarks/>
        public string PosCodCE223
        {
            get
            {
                return this.posCodCE223Field;
            }
            set
            {
                this.posCodCE223Field = value;
            }
        }

        /// <remarks/>
        public string CitCE224
        {
            get
            {
                return this.citCE224Field;
            }
            set
            {
                this.citCE224Field = value;
            }
        }

        /// <remarks/>
        public string CouCE225
        {
            get
            {
                return this.couCE225Field;
            }
            set
            {
                this.couCE225Field = value;
            }
        }

        /// <remarks/>
        public string NADLNGGICE
        {
            get
            {
                return this.nADLNGGICEField;
            }
            set
            {
                this.nADLNGGICEField = value;
            }
        }

        /// <remarks/>
        public string TINCE259
        {
            get
            {
                return this.tINCE259Field;
            }
            set
            {
                this.tINCE259Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXCE259Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCE259")]
        public List<TAXType> TAXCE259
        {
            get
            {
                return this.tAXCE259Field;
            }
            set
            {
                this.tAXCE259Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACONCO2Type
    {

        private string namCO27Field;

        private string strAndNumCO222Field;

        private string posCodCO223Field;

        private string citCO224Field;

        private string couCO225Field;

        private string nADLNGGTCOField;

        private string tINCO259Field;

        private List<TAXType> tAXCO259Field;

        /// <remarks/>
        public string NamCO27
        {
            get
            {
                return this.namCO27Field;
            }
            set
            {
                this.namCO27Field = value;
            }
        }

        /// <remarks/>
        public string StrAndNumCO222
        {
            get
            {
                return this.strAndNumCO222Field;
            }
            set
            {
                this.strAndNumCO222Field = value;
            }
        }

        /// <remarks/>
        public string PosCodCO223
        {
            get
            {
                return this.posCodCO223Field;
            }
            set
            {
                this.posCodCO223Field = value;
            }
        }

        /// <remarks/>
        public string CitCO224
        {
            get
            {
                return this.citCO224Field;
            }
            set
            {
                this.citCO224Field = value;
            }
        }

        /// <remarks/>
        public string CouCO225
        {
            get
            {
                return this.couCO225Field;
            }
            set
            {
                this.couCO225Field = value;
            }
        }

        /// <remarks/>
        public string NADLNGGTCO
        {
            get
            {
                return this.nADLNGGTCOField;
            }
            set
            {
                this.nADLNGGTCOField = value;
            }
        }

        /// <remarks/>
        public string TINCO259
        {
            get
            {
                return this.tINCO259Field;
            }
            set
            {
                this.tINCO259Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXCO259Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCO259")]
        public List<TAXType> TAXCO259
        {
            get
            {
                return this.tAXCO259Field;
            }
            set
            {
                this.tAXCO259Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SPEMENMT2Type
    {

        private string addInfMT21Field;

        private string addInfMT21LNGField;

        private string addInfCodMT23Field;

        private string expFroECMT24Field;

        private string expFroCouMT25Field;

        /// <remarks/>
        public string AddInfMT21
        {
            get
            {
                return this.addInfMT21Field;
            }
            set
            {
                this.addInfMT21Field = value;
            }
        }

        /// <remarks/>
        public string AddInfMT21LNG
        {
            get
            {
                return this.addInfMT21LNGField;
            }
            set
            {
                this.addInfMT21LNGField = value;
            }
        }

        /// <remarks/>
        public string AddInfCodMT23
        {
            get
            {
                return this.addInfCodMT23Field;
            }
            set
            {
                this.addInfCodMT23Field = value;
            }
        }

        /// <remarks/>
        public string ExpFroECMT24
        {
            get
            {
                return this.expFroECMT24Field;
            }
            set
            {
                this.expFroECMT24Field = value;
            }
        }

        /// <remarks/>
        public string ExpFroCouMT25
        {
            get
            {
                return this.expFroCouMT25Field;
            }
            set
            {
                this.expFroCouMT25Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRODOCDC2Type
    {

        private string docTypDC21Field;

        private string docRefDC23Field;

        private string docRefDCLNGField;

        private string comOfInfDC25Field;

        private string comOfInfDC25LNGField;

        private System.DateTime docRefDateField;

        private bool docRefDateFieldSpecified;

        /// <remarks/>
        public string DocTypDC21
        {
            get
            {
                return this.docTypDC21Field;
            }
            set
            {
                this.docTypDC21Field = value;
            }
        }

        /// <remarks/>
        public string DocRefDC23
        {
            get
            {
                return this.docRefDC23Field;
            }
            set
            {
                this.docRefDC23Field = value;
            }
        }

        /// <remarks/>
        public string DocRefDCLNG
        {
            get
            {
                return this.docRefDCLNGField;
            }
            set
            {
                this.docRefDCLNGField = value;
            }
        }

        /// <remarks/>
        public string ComOfInfDC25
        {
            get
            {
                return this.comOfInfDC25Field;
            }
            set
            {
                this.comOfInfDC25Field = value;
            }
        }

        /// <remarks/>
        public string ComOfInfDC25LNG
        {
            get
            {
                return this.comOfInfDC25LNGField;
            }
            set
            {
                this.comOfInfDC25LNGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DocRefDate
        {
            get
            {
                return this.docRefDateField;
            }
            set
            {
                this.docRefDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DocRefDateSpecified
        {
            get
            {
                return this.docRefDateFieldSpecified;
            }
            set
            {
                this.docRefDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PREADMREFAR2Type
    {

        private string preDocTypAR21Field;

        private string preDocRefAR26Field;

        private string preDocRefLNGField;

        private string comOfInfAR29Field;

        private string comOfInfAR29LNGField;

        private System.DateTime preDocRefDateField;

        private bool preDocRefDateFieldSpecified;

        /// <remarks/>
        public string PreDocTypAR21
        {
            get
            {
                return this.preDocTypAR21Field;
            }
            set
            {
                this.preDocTypAR21Field = value;
            }
        }

        /// <remarks/>
        public string PreDocRefAR26
        {
            get
            {
                return this.preDocRefAR26Field;
            }
            set
            {
                this.preDocRefAR26Field = value;
            }
        }

        /// <remarks/>
        public string PreDocRefLNG
        {
            get
            {
                return this.preDocRefLNGField;
            }
            set
            {
                this.preDocRefLNGField = value;
            }
        }

        /// <remarks/>
        public string ComOfInfAR29
        {
            get
            {
                return this.comOfInfAR29Field;
            }
            set
            {
                this.comOfInfAR29Field = value;
            }
        }

        /// <remarks/>
        public string ComOfInfAR29LNG
        {
            get
            {
                return this.comOfInfAR29LNGField;
            }
            set
            {
                this.comOfInfAR29LNGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime PreDocRefDate
        {
            get
            {
                return this.preDocRefDateField;
            }
            set
            {
                this.preDocRefDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreDocRefDateSpecified
        {
            get
            {
                return this.preDocRefDateFieldSpecified;
            }
            set
            {
                this.preDocRefDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GOOITEGDSWithRESOFCONROCType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GOOITEGDSType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class GOOITEGDSUpperPartType
    {

        private string iteNumGDS7Field;

        private string comCodTarCodGDS10Field;

        private string gooDesGDS23Field;

        private string gooDesGDS23LNGField;

        private decimal groMasGDS46Field;

        private bool groMasGDS46FieldSpecified;

        private decimal netMasGDS48Field;

        private bool netMasGDS48FieldSpecified;

        private string couOfDisGDS58Field;

        private string couOfDesGDS59Field;

        private string metOfPayGDI12Field;

        private string comRefNumGIM1Field;

        private string uNDanGooCodGDI1Field;

        private List<PREADMREFAR2Type> pREADMREFAR2Field;

        private List<PRODOCDC2Type> pRODOCDC2Field;

        private SPEMENMT2Type sPEMENMT2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string IteNumGDS7
        {
            get
            {
                return this.iteNumGDS7Field;
            }
            set
            {
                this.iteNumGDS7Field = value;
            }
        }

        /// <remarks/>
        public string ComCodTarCodGDS10
        {
            get
            {
                return this.comCodTarCodGDS10Field;
            }
            set
            {
                this.comCodTarCodGDS10Field = value;
            }
        }

        /// <remarks/>
        public string GooDesGDS23
        {
            get
            {
                return this.gooDesGDS23Field;
            }
            set
            {
                this.gooDesGDS23Field = value;
            }
        }

        /// <remarks/>
        public string GooDesGDS23LNG
        {
            get
            {
                return this.gooDesGDS23LNGField;
            }
            set
            {
                this.gooDesGDS23LNGField = value;
            }
        }

        /// <remarks/>
        public decimal GroMasGDS46
        {
            get
            {
                return this.groMasGDS46Field;
            }
            set
            {
                this.groMasGDS46Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroMasGDS46Specified
        {
            get
            {
                return this.groMasGDS46FieldSpecified;
            }
            set
            {
                this.groMasGDS46FieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal NetMasGDS48
        {
            get
            {
                return this.netMasGDS48Field;
            }
            set
            {
                this.netMasGDS48Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetMasGDS48Specified
        {
            get
            {
                return this.netMasGDS48FieldSpecified;
            }
            set
            {
                this.netMasGDS48FieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CouOfDisGDS58
        {
            get
            {
                return this.couOfDisGDS58Field;
            }
            set
            {
                this.couOfDisGDS58Field = value;
            }
        }

        /// <remarks/>
        public string CouOfDesGDS59
        {
            get
            {
                return this.couOfDesGDS59Field;
            }
            set
            {
                this.couOfDesGDS59Field = value;
            }
        }

        /// <remarks/>
        public string MetOfPayGDI12
        {
            get
            {
                return this.metOfPayGDI12Field;
            }
            set
            {
                this.metOfPayGDI12Field = value;
            }
        }

        /// <remarks/>
        public string ComRefNumGIM1
        {
            get
            {
                return this.comRefNumGIM1Field;
            }
            set
            {
                this.comRefNumGIM1Field = value;
            }
        }

        /// <remarks/>
        public string UNDanGooCodGDI1
        {
            get
            {
                return this.uNDanGooCodGDI1Field;
            }
            set
            {
                this.uNDanGooCodGDI1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PREADMREFAR2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PREADMREFAR2")]
        public List<PREADMREFAR2Type> PREADMREFAR2
        {
            get
            {
                return this.pREADMREFAR2Field;
            }
            set
            {
                this.pREADMREFAR2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PRODOCDC2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRODOCDC2")]
        public List<PRODOCDC2Type> PRODOCDC2
        {
            get
            {
                return this.pRODOCDC2Field;
            }
            set
            {
                this.pRODOCDC2Field = value;
            }
        }

        /// <remarks/>
        public SPEMENMT2Type SPEMENMT2
        {
            get
            {
                return this.sPEMENMT2Field;
            }
            set
            {
                this.sPEMENMT2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GOOITEGDSWithRESOFCONROCType : GOOITEGDSUpperPartType
    {

        private RESOFCONROCType rESOFCONROCField;

        private TRACONCO2Type tRACONCO2Field;

        private TRACONCE2Type tRACONCE2Field;

        private List<CONNR2Type> cONNR2Field;

        private List<PACGS2Type> pACGS2Field;

        private AdditionalGoodsMeasurementType additionalGoodsMeasurementField;

        private SGICODSD2Type sGICODSD2Field;

        private TRACORSECGOO021Type tRACORSECGOO021Field;

        private TRACONSECGOO013Type tRACONSECGOO013Field;

        /// <remarks/>
        public RESOFCONROCType RESOFCONROC
        {
            get
            {
                return this.rESOFCONROCField;
            }
            set
            {
                this.rESOFCONROCField = value;
            }
        }

        /// <remarks/>
        public TRACONCO2Type TRACONCO2
        {
            get
            {
                return this.tRACONCO2Field;
            }
            set
            {
                this.tRACONCO2Field = value;
            }
        }

        /// <remarks/>
        public TRACONCE2Type TRACONCE2
        {
            get
            {
                return this.tRACONCE2Field;
            }
            set
            {
                this.tRACONCE2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CONNR2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONNR2")]
        public List<CONNR2Type> CONNR2
        {
            get
            {
                return this.cONNR2Field;
            }
            set
            {
                this.cONNR2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PACGS2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACGS2")]
        public List<PACGS2Type> PACGS2
        {
            get
            {
                return this.pACGS2Field;
            }
            set
            {
                this.pACGS2Field = value;
            }
        }

        /// <remarks/>
        public AdditionalGoodsMeasurementType AdditionalGoodsMeasurement
        {
            get
            {
                return this.additionalGoodsMeasurementField;
            }
            set
            {
                this.additionalGoodsMeasurementField = value;
            }
        }

        /// <remarks/>
        public SGICODSD2Type SGICODSD2
        {
            get
            {
                return this.sGICODSD2Field;
            }
            set
            {
                this.sGICODSD2Field = value;
            }
        }

        /// <remarks/>
        public TRACORSECGOO021Type TRACORSECGOO021
        {
            get
            {
                return this.tRACORSECGOO021Field;
            }
            set
            {
                this.tRACORSECGOO021Field = value;
            }
        }

        /// <remarks/>
        public TRACONSECGOO013Type TRACONSECGOO013
        {
            get
            {
                return this.tRACONSECGOO013Field;
            }
            set
            {
                this.tRACONSECGOO013Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GOOITEGDSType : GOOITEGDSUpperPartType
    {

        private TRACONCO2Type tRACONCO2Field;

        private TRACONCE2Type tRACONCE2Field;

        private List<CONNR2Type> cONNR2Field;

        private List<PACGS2Type> pACGS2Field;

        private AdditionalGoodsMeasurementType additionalGoodsMeasurementField;

        private SGICODSD2Type sGICODSD2Field;

        private TRACORSECGOO021Type tRACORSECGOO021Field;

        private TRACONSECGOO013Type tRACONSECGOO013Field;

        /// <remarks/>
        public TRACONCO2Type TRACONCO2
        {
            get
            {
                return this.tRACONCO2Field;
            }
            set
            {
                this.tRACONCO2Field = value;
            }
        }

        /// <remarks/>
        public TRACONCE2Type TRACONCE2
        {
            get
            {
                return this.tRACONCE2Field;
            }
            set
            {
                this.tRACONCE2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CONNR2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONNR2")]
        public List<CONNR2Type> CONNR2
        {
            get
            {
                return this.cONNR2Field;
            }
            set
            {
                this.cONNR2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PACGS2Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACGS2")]
        public List<PACGS2Type> PACGS2
        {
            get
            {
                return this.pACGS2Field;
            }
            set
            {
                this.pACGS2Field = value;
            }
        }

        /// <remarks/>
        public AdditionalGoodsMeasurementType AdditionalGoodsMeasurement
        {
            get
            {
                return this.additionalGoodsMeasurementField;
            }
            set
            {
                this.additionalGoodsMeasurementField = value;
            }
        }

        /// <remarks/>
        public SGICODSD2Type SGICODSD2
        {
            get
            {
                return this.sGICODSD2Field;
            }
            set
            {
                this.sGICODSD2Field = value;
            }
        }

        /// <remarks/>
        public TRACORSECGOO021Type TRACORSECGOO021
        {
            get
            {
                return this.tRACORSECGOO021Field;
            }
            set
            {
                this.tRACORSECGOO021Field = value;
            }
        }

        /// <remarks/>
        public TRACONSECGOO013Type TRACONSECGOO013
        {
            get
            {
                return this.tRACONSECGOO013Field;
            }
            set
            {
                this.tRACONSECGOO013Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GUAGUAType
    {

        private GUAGUATypeGuaTypGUA1 guaTypGUA1Field;

        private GUAGUATypeGUAREFREF gUAREFREFField;

        /// <remarks/>
        public GUAGUATypeGuaTypGUA1 GuaTypGUA1
        {
            get
            {
                return this.guaTypGUA1Field;
            }
            set
            {
                this.guaTypGUA1Field = value;
            }
        }

        /// <remarks/>
        public GUAGUATypeGUAREFREF GUAREFREF
        {
            get
            {
                return this.gUAREFREFField;
            }
            set
            {
                this.gUAREFREFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum GUAGUATypeGuaTypGUA1
    {

        /// <remarks/>
        B,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GUAGUATypeGUAREFREF
    {

        private string othGuaRefREF4Field;

        /// <remarks/>
        public string OthGuaRefREF4
        {
            get
            {
                return this.othGuaRefREF4Field;
            }
            set
            {
                this.othGuaRefREF4Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SEAINFSLIType
    {

        private SEAINFSLITypeSealsIntact sealsIntactField;

        private bool sealsIntactFieldSpecified;

        private string seaNumberField;

        private string sEAIDSIDField;

        /// <remarks/>
        public SEAINFSLITypeSealsIntact SealsIntact
        {
            get
            {
                return this.sealsIntactField;
            }
            set
            {
                this.sealsIntactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SealsIntactSpecified
        {
            get
            {
                return this.sealsIntactFieldSpecified;
            }
            set
            {
                this.sealsIntactFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string SeaNumber
        {
            get
            {
                return this.seaNumberField;
            }
            set
            {
                this.seaNumberField = value;
            }
        }

        /// <remarks/>
        public string SEAIDSID
        {
            get
            {
                return this.sEAIDSIDField;
            }
            set
            {
                this.sEAIDSIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CUSOFFDESESTType
    {

        private string couRefNumEST1Field;

        private string refNumEST1Field;

        /// <remarks/>
        public string CouRefNumEST1
        {
            get
            {
                return this.couRefNumEST1Field;
            }
            set
            {
                this.couRefNumEST1Field = value;
            }
        }

        /// <remarks/>
        public string RefNumEST1
        {
            get
            {
                return this.refNumEST1Field;
            }
            set
            {
                this.refNumEST1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CUSOFFTRARNSType
    {

        private string couRefNumRNS1Field;

        private string refNumRNS1Field;

        private string arrTimTRACUS085Field;

        /// <remarks/>
        public string CouRefNumRNS1
        {
            get
            {
                return this.couRefNumRNS1Field;
            }
            set
            {
                this.couRefNumRNS1Field = value;
            }
        }

        /// <remarks/>
        public string RefNumRNS1
        {
            get
            {
                return this.refNumRNS1Field;
            }
            set
            {
                this.refNumRNS1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ArrTimTRACUS085
        {
            get
            {
                return this.arrTimTRACUS085Field;
            }
            set
            {
                this.arrTimTRACUS085Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CUSOFFDEPEPTType
    {

        private string couRefNumEPT1Field;

        private string refNumEPT1Field;

        /// <remarks/>
        public string CouRefNumEPT1
        {
            get
            {
                return this.couRefNumEPT1Field;
            }
            set
            {
                this.couRefNumEPT1Field = value;
            }
        }

        /// <remarks/>
        public string RefNumEPT1
        {
            get
            {
                return this.refNumEPT1Field;
            }
            set
            {
                this.refNumEPT1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IdDRVType
    {

        private string idNumDRVField;

        private string idTypDRVField;

        private string issAuthDRVField;

        private string issCtryDRVField;

        private System.DateTime issDatDRVField;

        private bool issDatDRVFieldSpecified;

        private System.DateTime expDatDRVField;

        private bool expDatDRVFieldSpecified;

        /// <remarks/>
        public string IdNumDRV
        {
            get
            {
                return this.idNumDRVField;
            }
            set
            {
                this.idNumDRVField = value;
            }
        }

        /// <remarks/>
        public string IdTypDRV
        {
            get
            {
                return this.idTypDRVField;
            }
            set
            {
                this.idTypDRVField = value;
            }
        }

        /// <remarks/>
        public string IssAuthDRV
        {
            get
            {
                return this.issAuthDRVField;
            }
            set
            {
                this.issAuthDRVField = value;
            }
        }

        /// <remarks/>
        public string IssCtryDRV
        {
            get
            {
                return this.issCtryDRVField;
            }
            set
            {
                this.issCtryDRVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime IssDatDRV
        {
            get
            {
                return this.issDatDRVField;
            }
            set
            {
                this.issDatDRVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IssDatDRVSpecified
        {
            get
            {
                return this.issDatDRVFieldSpecified;
            }
            set
            {
                this.issDatDRVFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ExpDatDRV
        {
            get
            {
                return this.expDatDRVField;
            }
            set
            {
                this.expDatDRVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpDatDRVSpecified
        {
            get
            {
                return this.expDatDRVFieldSpecified;
            }
            set
            {
                this.expDatDRVFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRADRVType
    {

        private string namDRVField;

        private string surNameDRVField;

        private string natDRVField;

        private string rolDRVField;

        private string placeOfBrtDRVField;

        private System.DateTime datOfBrtDRVField;

        private bool datOfBrtDRVFieldSpecified;

        private List<IdDRVType> idDRVField;

        /// <remarks/>
        public string NamDRV
        {
            get
            {
                return this.namDRVField;
            }
            set
            {
                this.namDRVField = value;
            }
        }

        /// <remarks/>
        public string SurNameDRV
        {
            get
            {
                return this.surNameDRVField;
            }
            set
            {
                this.surNameDRVField = value;
            }
        }

        /// <remarks/>
        public string NatDRV
        {
            get
            {
                return this.natDRVField;
            }
            set
            {
                this.natDRVField = value;
            }
        }

        /// <remarks/>
        public string RolDRV
        {
            get
            {
                return this.rolDRVField;
            }
            set
            {
                this.rolDRVField = value;
            }
        }

        /// <remarks/>
        public string PlaceOfBrtDRV
        {
            get
            {
                return this.placeOfBrtDRVField;
            }
            set
            {
                this.placeOfBrtDRVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DatOfBrtDRV
        {
            get
            {
                return this.datOfBrtDRVField;
            }
            set
            {
                this.datOfBrtDRVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatOfBrtDRVSpecified
        {
            get
            {
                return this.datOfBrtDRVFieldSpecified;
            }
            set
            {
                this.datOfBrtDRVFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdDRVSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdDRV")]
        public List<IdDRVType> IdDRV
        {
            get
            {
                return this.idDRVField;
            }
            set
            {
                this.idDRVField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TraVehicleType
    {

        private string vehicleTypeCodeField;

        private string vehicleRegistrationNumberField;

        private string vehicleRegistrationLanguageField;

        private string vehicleNationalityField;

        private string vehicleVINField;

        private string vehicleMarkField;

        /// <remarks/>
        public string VehicleTypeCode
        {
            get
            {
                return this.vehicleTypeCodeField;
            }
            set
            {
                this.vehicleTypeCodeField = value;
            }
        }

        /// <remarks/>
        public string VehicleRegistrationNumber
        {
            get
            {
                return this.vehicleRegistrationNumberField;
            }
            set
            {
                this.vehicleRegistrationNumberField = value;
            }
        }

        /// <remarks/>
        public string VehicleRegistrationLanguage
        {
            get
            {
                return this.vehicleRegistrationLanguageField;
            }
            set
            {
                this.vehicleRegistrationLanguageField = value;
            }
        }

        /// <remarks/>
        public string VehicleNationality
        {
            get
            {
                return this.vehicleNationalityField;
            }
            set
            {
                this.vehicleNationalityField = value;
            }
        }

        /// <remarks/>
        public string VehicleVIN
        {
            get
            {
                return this.vehicleVINField;
            }
            set
            {
                this.vehicleVINField = value;
            }
        }

        /// <remarks/>
        public string VehicleMark
        {
            get
            {
                return this.vehicleMarkField;
            }
            set
            {
                this.vehicleMarkField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACONCE1Type
    {

        private string namCE17Field;

        private string strAndNumCE122Field;

        private string posCodCE123Field;

        private string citCE124Field;

        private string couCE125Field;

        private string nADLNGCEField;

        private string tINCE159Field;

        private List<TAXType> tAXCE159Field;

        /// <remarks/>
        public string NamCE17
        {
            get
            {
                return this.namCE17Field;
            }
            set
            {
                this.namCE17Field = value;
            }
        }

        /// <remarks/>
        public string StrAndNumCE122
        {
            get
            {
                return this.strAndNumCE122Field;
            }
            set
            {
                this.strAndNumCE122Field = value;
            }
        }

        /// <remarks/>
        public string PosCodCE123
        {
            get
            {
                return this.posCodCE123Field;
            }
            set
            {
                this.posCodCE123Field = value;
            }
        }

        /// <remarks/>
        public string CitCE124
        {
            get
            {
                return this.citCE124Field;
            }
            set
            {
                this.citCE124Field = value;
            }
        }

        /// <remarks/>
        public string CouCE125
        {
            get
            {
                return this.couCE125Field;
            }
            set
            {
                this.couCE125Field = value;
            }
        }

        /// <remarks/>
        public string NADLNGCE
        {
            get
            {
                return this.nADLNGCEField;
            }
            set
            {
                this.nADLNGCEField = value;
            }
        }

        /// <remarks/>
        public string TINCE159
        {
            get
            {
                return this.tINCE159Field;
            }
            set
            {
                this.tINCE159Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXCE159Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCE159")]
        public List<TAXType> TAXCE159
        {
            get
            {
                return this.tAXCE159Field;
            }
            set
            {
                this.tAXCE159Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRACONCO1Type
    {

        private string namCO17Field;

        private string strAndNumCO122Field;

        private string posCodCO123Field;

        private string citCO124Field;

        private string couCO125Field;

        private string nADLNGCOField;

        private string tINCO159Field;

        private List<TAXType> tAXCO159Field;

        /// <remarks/>
        public string NamCO17
        {
            get
            {
                return this.namCO17Field;
            }
            set
            {
                this.namCO17Field = value;
            }
        }

        /// <remarks/>
        public string StrAndNumCO122
        {
            get
            {
                return this.strAndNumCO122Field;
            }
            set
            {
                this.strAndNumCO122Field = value;
            }
        }

        /// <remarks/>
        public string PosCodCO123
        {
            get
            {
                return this.posCodCO123Field;
            }
            set
            {
                this.posCodCO123Field = value;
            }
        }

        /// <remarks/>
        public string CitCO124
        {
            get
            {
                return this.citCO124Field;
            }
            set
            {
                this.citCO124Field = value;
            }
        }

        /// <remarks/>
        public string CouCO125
        {
            get
            {
                return this.couCO125Field;
            }
            set
            {
                this.couCO125Field = value;
            }
        }

        /// <remarks/>
        public string NADLNGCO
        {
            get
            {
                return this.nADLNGCOField;
            }
            set
            {
                this.nADLNGCOField = value;
            }
        }

        /// <remarks/>
        public string TINCO159
        {
            get
            {
                return this.tINCO159Field;
            }
            set
            {
                this.tINCO159Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXCO159Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXCO159")]
        public List<TAXType> TAXCO159
        {
            get
            {
                return this.tAXCO159Field;
            }
            set
            {
                this.tAXCO159Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TRAPRIPC1Type
    {

        private string namPC17Field;

        private string strAndNumPC122Field;

        private string posCodPC123Field;

        private string citPC124Field;

        private string couPC125Field;

        private string nADLNGPCField;

        private string tINPC159Field;

        private string hITPC126Field;

        private List<TAXType> tAXPC159Field;

        /// <remarks/>
        public string NamPC17
        {
            get
            {
                return this.namPC17Field;
            }
            set
            {
                this.namPC17Field = value;
            }
        }

        /// <remarks/>
        public string StrAndNumPC122
        {
            get
            {
                return this.strAndNumPC122Field;
            }
            set
            {
                this.strAndNumPC122Field = value;
            }
        }

        /// <remarks/>
        public string PosCodPC123
        {
            get
            {
                return this.posCodPC123Field;
            }
            set
            {
                this.posCodPC123Field = value;
            }
        }

        /// <remarks/>
        public string CitPC124
        {
            get
            {
                return this.citPC124Field;
            }
            set
            {
                this.citPC124Field = value;
            }
        }

        /// <remarks/>
        public string CouPC125
        {
            get
            {
                return this.couPC125Field;
            }
            set
            {
                this.couPC125Field = value;
            }
        }

        /// <remarks/>
        public string NADLNGPC
        {
            get
            {
                return this.nADLNGPCField;
            }
            set
            {
                this.nADLNGPCField = value;
            }
        }

        /// <remarks/>
        public string TINPC159
        {
            get
            {
                return this.tINPC159Field;
            }
            set
            {
                this.tINPC159Field = value;
            }
        }

        /// <remarks/>
        public string HITPC126
        {
            get
            {
                return this.hITPC126Field;
            }
            set
            {
                this.hITPC126Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TAXPC159Specified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXPC159")]
        public List<TAXType> TAXPC159
        {
            get
            {
                return this.tAXPC159Field;
            }
            set
            {
                this.tAXPC159Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ADDITIONALINFORMATIONType
    {

        private string customsRemarksField;

        private ADDITIONALINFORMATIONTypeHeavyBulkyGoodsInd heavyBulkyGoodsIndField;

        private bool heavyBulkyGoodsIndFieldSpecified;

        /// <remarks/>
        public string CustomsRemarks
        {
            get
            {
                return this.customsRemarksField;
            }
            set
            {
                this.customsRemarksField = value;
            }
        }

        /// <remarks/>
        public ADDITIONALINFORMATIONTypeHeavyBulkyGoodsInd HeavyBulkyGoodsInd
        {
            get
            {
                return this.heavyBulkyGoodsIndField;
            }
            set
            {
                this.heavyBulkyGoodsIndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeavyBulkyGoodsIndSpecified
        {
            get
            {
                return this.heavyBulkyGoodsIndFieldSpecified;
            }
            set
            {
                this.heavyBulkyGoodsIndFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EPD029
    {

        private EPD029HEAHEA hEAHEAField;

        private TRAPRIPC1Type tRAPRIPC1Field;

        private TRACONCO1Type tRACONCO1Field;

        private TRACONCE1Type tRACONCE1Field;

        private List<TraVehicleType> tRAMEANSField;

        private List<TRADRVType> tRADRVField;

        private CUSOFFDEPEPTType cUSOFFDEPEPTField;

        private List<CUSOFFTRARNSType> cUSOFFTRARNSField;

        private CUSOFFDESESTType cUSOFFDESESTField;

        private List<SEAINFSLIType> sEAINFSLIField;

        private GUAGUAType gUAGUAField;

        private List<GOOITEGDSType> gOOITEGDSField;

        private List<ITIType> iTIField;

        private TRACORSEC037Type tRACORSEC037Field;

        private TRACONSEC029Type tRACONSEC029Field;

        /// <remarks/>
        public EPD029HEAHEA HEAHEA
        {
            get
            {
                return this.hEAHEAField;
            }
            set
            {
                this.hEAHEAField = value;
            }
        }

        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1
        {
            get
            {
                return this.tRAPRIPC1Field;
            }
            set
            {
                this.tRAPRIPC1Field = value;
            }
        }

        /// <remarks/>
        public TRACONCO1Type TRACONCO1
        {
            get
            {
                return this.tRACONCO1Field;
            }
            set
            {
                this.tRACONCO1Field = value;
            }
        }

        /// <remarks/>
        public TRACONCE1Type TRACONCE1
        {
            get
            {
                return this.tRACONCE1Field;
            }
            set
            {
                this.tRACONCE1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TRAMEANSSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable = false)]
        public List<TraVehicleType> TRAMEANS
        {
            get
            {
                return this.tRAMEANSField;
            }
            set
            {
                this.tRAMEANSField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TRADRVSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TRADRV")]
        public List<TRADRVType> TRADRV
        {
            get
            {
                return this.tRADRVField;
            }
            set
            {
                this.tRADRVField = value;
            }
        }

        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT
        {
            get
            {
                return this.cUSOFFDEPEPTField;
            }
            set
            {
                this.cUSOFFDEPEPTField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CUSOFFTRARNSSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CUSOFFTRARNS")]
        public List<CUSOFFTRARNSType> CUSOFFTRARNS
        {
            get
            {
                return this.cUSOFFTRARNSField;
            }
            set
            {
                this.cUSOFFTRARNSField = value;
            }
        }

        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST
        {
            get
            {
                return this.cUSOFFDESESTField;
            }
            set
            {
                this.cUSOFFDESESTField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SEAINFSLISpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SEAINFSLI")]
        public List<SEAINFSLIType> SEAINFSLI
        {
            get
            {
                return this.sEAINFSLIField;
            }
            set
            {
                this.sEAINFSLIField = value;
            }
        }

        /// <remarks/>
        public GUAGUAType GUAGUA
        {
            get
            {
                return this.gUAGUAField;
            }
            set
            {
                this.gUAGUAField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GOOITEGDSSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GOOITEGDS")]
        public List<GOOITEGDSType> GOOITEGDS
        {
            get
            {
                return this.gOOITEGDSField;
            }
            set
            {
                this.gOOITEGDSField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ITISpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITI")]
        public List<ITIType> ITI
        {
            get
            {
                return this.iTIField;
            }
            set
            {
                this.iTIField = value;
            }
        }

        /// <remarks/>
        public TRACORSEC037Type TRACORSEC037
        {
            get
            {
                return this.tRACORSEC037Field;
            }
            set
            {
                this.tRACORSEC037Field = value;
            }
        }

        /// <remarks/>
        public TRACONSEC029Type TRACONSEC029
        {
            get
            {
                return this.tRACONSEC029Field;
            }
            set
            {
                this.tRACONSEC029Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EPD029HEAHEA
    {

        private string refNumHEA4Field;

        private string docNumHEA5Field;

        private string guaranteeNumberField;

        private TypOfDecHEA24EnumType typOfDecHEA24Field;

        private bool typOfDecHEA24FieldSpecified;

        private string couOfDesCodHEA30Field;

        private string agrLocOfGooCodHEA38Field;

        private string agrLocOfGooHEA39Field;

        private string agrLocOfGooHEA39LNGField;

        private string plaOfLoaCodHEA46Field;

        private string couOfDisCodHEA55Field;

        private EPD029HEAHEAInlTraModHEA75 inlTraModHEA75Field;

        private bool inlTraModHEA75FieldSpecified;

        private EPD029HEAHEATraModAtBorHEA76 traModAtBorHEA76Field;

        private bool traModAtBorHEA76FieldSpecified;

        private string ideOfMeaOfTraAtDHEA78Field;

        private string ideOfMeaOfTraAtDHEA78LNGField;

        private string natOfMeaOfTraAtDHEA80Field;

        private string ideOfMeaOfTraCroHEA85Field;

        private string ideOfMeaOfTraCroHEA85LNGField;

        private string natOfMeaOfTraCroHEA87Field;

        private string typOfMeaOfTraCroHEA88Field;

        private EPD029HEAHEAConIndHEA96 conIndHEA96Field;

        private bool conIndHEA96FieldSpecified;

        private EPD029HEAHEANCTRetCopHEA104 nCTRetCopHEA104Field;

        private bool nCTRetCopHEA104FieldSpecified;

        private System.DateTime declarationAcceptanceDateField;

        private bool declarationAcceptanceDateFieldSpecified;

        private string accDatHEA158Field;

        private System.DateTime declarationReleasedDateField;

        private bool declarationReleasedDateFieldSpecified;

        private string issDatHEA186Field;

        private string nCTSAccDocHEA601LNGField;

        private string totNumOfIteHEA305Field;

        private string totNumOfPacHEA306Field;

        private decimal totGroMasHEA307Field;

        private bool totGroMasHEA307FieldSpecified;

        private EPD029HEAHEABinItiHEA246 binItiHEA246Field;

        private bool binItiHEA246FieldSpecified;

        private ADDITIONALINFORMATIONType aDDITIONALINFORMATIONField;

        private System.DateTime declarationDateField;

        private bool declarationDateFieldSpecified;

        private string decDatHEA383Field;

        private string decPlaHEA394Field;

        private string decPlaHEA394LNGField;

        private string speCirIndHEA1Field;

        private string traChaMetOfPayHEA1Field;

        private EPD029HEAHEASecHEA358 secHEA358Field;

        private bool secHEA358FieldSpecified;

        private string codPlUnHEA357Field;

        private string codPlUnHEA357LNGField;

        private string vehicleMakeNameField;

        private string vehicleModelNameField;

        private string vehicleVINField;

        private string typeOfMvtField;

        /// <remarks/>
        public string RefNumHEA4
        {
            get
            {
                return this.refNumHEA4Field;
            }
            set
            {
                this.refNumHEA4Field = value;
            }
        }

        /// <remarks/>
        public string DocNumHEA5
        {
            get
            {
                return this.docNumHEA5Field;
            }
            set
            {
                this.docNumHEA5Field = value;
            }
        }

        /// <remarks/>
        public string GuaranteeNumber
        {
            get
            {
                return this.guaranteeNumberField;
            }
            set
            {
                this.guaranteeNumberField = value;
            }
        }

        /// <remarks/>
        public TypOfDecHEA24EnumType TypOfDecHEA24
        {
            get
            {
                return this.typOfDecHEA24Field;
            }
            set
            {
                this.typOfDecHEA24Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypOfDecHEA24Specified
        {
            get
            {
                return this.typOfDecHEA24FieldSpecified;
            }
            set
            {
                this.typOfDecHEA24FieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CouOfDesCodHEA30
        {
            get
            {
                return this.couOfDesCodHEA30Field;
            }
            set
            {
                this.couOfDesCodHEA30Field = value;
            }
        }

        /// <remarks/>
        public string AgrLocOfGooCodHEA38
        {
            get
            {
                return this.agrLocOfGooCodHEA38Field;
            }
            set
            {
                this.agrLocOfGooCodHEA38Field = value;
            }
        }

        /// <remarks/>
        public string AgrLocOfGooHEA39
        {
            get
            {
                return this.agrLocOfGooHEA39Field;
            }
            set
            {
                this.agrLocOfGooHEA39Field = value;
            }
        }

        /// <remarks/>
        public string AgrLocOfGooHEA39LNG
        {
            get
            {
                return this.agrLocOfGooHEA39LNGField;
            }
            set
            {
                this.agrLocOfGooHEA39LNGField = value;
            }
        }

        /// <remarks/>
        public string PlaOfLoaCodHEA46
        {
            get
            {
                return this.plaOfLoaCodHEA46Field;
            }
            set
            {
                this.plaOfLoaCodHEA46Field = value;
            }
        }

        /// <remarks/>
        public string CouOfDisCodHEA55
        {
            get
            {
                return this.couOfDisCodHEA55Field;
            }
            set
            {
                this.couOfDisCodHEA55Field = value;
            }
        }

        /// <remarks/>
        public EPD029HEAHEAInlTraModHEA75 InlTraModHEA75
        {
            get
            {
                return this.inlTraModHEA75Field;
            }
            set
            {
                this.inlTraModHEA75Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InlTraModHEA75Specified
        {
            get
            {
                return this.inlTraModHEA75FieldSpecified;
            }
            set
            {
                this.inlTraModHEA75FieldSpecified = value;
            }
        }

        /// <remarks/>
        public EPD029HEAHEATraModAtBorHEA76 TraModAtBorHEA76
        {
            get
            {
                return this.traModAtBorHEA76Field;
            }
            set
            {
                this.traModAtBorHEA76Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TraModAtBorHEA76Specified
        {
            get
            {
                return this.traModAtBorHEA76FieldSpecified;
            }
            set
            {
                this.traModAtBorHEA76FieldSpecified = value;
            }
        }

        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78
        {
            get
            {
                return this.ideOfMeaOfTraAtDHEA78Field;
            }
            set
            {
                this.ideOfMeaOfTraAtDHEA78Field = value;
            }
        }

        /// <remarks/>
        public string IdeOfMeaOfTraAtDHEA78LNG
        {
            get
            {
                return this.ideOfMeaOfTraAtDHEA78LNGField;
            }
            set
            {
                this.ideOfMeaOfTraAtDHEA78LNGField = value;
            }
        }

        /// <remarks/>
        public string NatOfMeaOfTraAtDHEA80
        {
            get
            {
                return this.natOfMeaOfTraAtDHEA80Field;
            }
            set
            {
                this.natOfMeaOfTraAtDHEA80Field = value;
            }
        }

        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85
        {
            get
            {
                return this.ideOfMeaOfTraCroHEA85Field;
            }
            set
            {
                this.ideOfMeaOfTraCroHEA85Field = value;
            }
        }

        /// <remarks/>
        public string IdeOfMeaOfTraCroHEA85LNG
        {
            get
            {
                return this.ideOfMeaOfTraCroHEA85LNGField;
            }
            set
            {
                this.ideOfMeaOfTraCroHEA85LNGField = value;
            }
        }

        /// <remarks/>
        public string NatOfMeaOfTraCroHEA87
        {
            get
            {
                return this.natOfMeaOfTraCroHEA87Field;
            }
            set
            {
                this.natOfMeaOfTraCroHEA87Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string TypOfMeaOfTraCroHEA88
        {
            get
            {
                return this.typOfMeaOfTraCroHEA88Field;
            }
            set
            {
                this.typOfMeaOfTraCroHEA88Field = value;
            }
        }

        /// <remarks/>
        public EPD029HEAHEAConIndHEA96 ConIndHEA96
        {
            get
            {
                return this.conIndHEA96Field;
            }
            set
            {
                this.conIndHEA96Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConIndHEA96Specified
        {
            get
            {
                return this.conIndHEA96FieldSpecified;
            }
            set
            {
                this.conIndHEA96FieldSpecified = value;
            }
        }

        /// <remarks/>
        public EPD029HEAHEANCTRetCopHEA104 NCTRetCopHEA104
        {
            get
            {
                return this.nCTRetCopHEA104Field;
            }
            set
            {
                this.nCTRetCopHEA104Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NCTRetCopHEA104Specified
        {
            get
            {
                return this.nCTRetCopHEA104FieldSpecified;
            }
            set
            {
                this.nCTRetCopHEA104FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeclarationAcceptanceDate
        {
            get
            {
                return this.declarationAcceptanceDateField;
            }
            set
            {
                this.declarationAcceptanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationAcceptanceDateSpecified
        {
            get
            {
                return this.declarationAcceptanceDateFieldSpecified;
            }
            set
            {
                this.declarationAcceptanceDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string AccDatHEA158
        {
            get
            {
                return this.accDatHEA158Field;
            }
            set
            {
                this.accDatHEA158Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeclarationReleasedDate
        {
            get
            {
                return this.declarationReleasedDateField;
            }
            set
            {
                this.declarationReleasedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationReleasedDateSpecified
        {
            get
            {
                return this.declarationReleasedDateFieldSpecified;
            }
            set
            {
                this.declarationReleasedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string IssDatHEA186
        {
            get
            {
                return this.issDatHEA186Field;
            }
            set
            {
                this.issDatHEA186Field = value;
            }
        }

        /// <remarks/>
        public string NCTSAccDocHEA601LNG
        {
            get
            {
                return this.nCTSAccDocHEA601LNGField;
            }
            set
            {
                this.nCTSAccDocHEA601LNGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string TotNumOfIteHEA305
        {
            get
            {
                return this.totNumOfIteHEA305Field;
            }
            set
            {
                this.totNumOfIteHEA305Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string TotNumOfPacHEA306
        {
            get
            {
                return this.totNumOfPacHEA306Field;
            }
            set
            {
                this.totNumOfPacHEA306Field = value;
            }
        }

        /// <remarks/>
        public decimal TotGroMasHEA307
        {
            get
            {
                return this.totGroMasHEA307Field;
            }
            set
            {
                this.totGroMasHEA307Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotGroMasHEA307Specified
        {
            get
            {
                return this.totGroMasHEA307FieldSpecified;
            }
            set
            {
                this.totGroMasHEA307FieldSpecified = value;
            }
        }

        /// <remarks/>
        public EPD029HEAHEABinItiHEA246 BinItiHEA246
        {
            get
            {
                return this.binItiHEA246Field;
            }
            set
            {
                this.binItiHEA246Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BinItiHEA246Specified
        {
            get
            {
                return this.binItiHEA246FieldSpecified;
            }
            set
            {
                this.binItiHEA246FieldSpecified = value;
            }
        }

        /// <remarks/>
        public ADDITIONALINFORMATIONType ADDITIONALINFORMATION
        {
            get
            {
                return this.aDDITIONALINFORMATIONField;
            }
            set
            {
                this.aDDITIONALINFORMATIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DeclarationDate
        {
            get
            {
                return this.declarationDateField;
            }
            set
            {
                this.declarationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeclarationDateSpecified
        {
            get
            {
                return this.declarationDateFieldSpecified;
            }
            set
            {
                this.declarationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DecDatHEA383
        {
            get
            {
                return this.decDatHEA383Field;
            }
            set
            {
                this.decDatHEA383Field = value;
            }
        }

        /// <remarks/>
        public string DecPlaHEA394
        {
            get
            {
                return this.decPlaHEA394Field;
            }
            set
            {
                this.decPlaHEA394Field = value;
            }
        }

        /// <remarks/>
        public string DecPlaHEA394LNG
        {
            get
            {
                return this.decPlaHEA394LNGField;
            }
            set
            {
                this.decPlaHEA394LNGField = value;
            }
        }

        /// <remarks/>
        public string SpeCirIndHEA1
        {
            get
            {
                return this.speCirIndHEA1Field;
            }
            set
            {
                this.speCirIndHEA1Field = value;
            }
        }

        /// <remarks/>
        public string TraChaMetOfPayHEA1
        {
            get
            {
                return this.traChaMetOfPayHEA1Field;
            }
            set
            {
                this.traChaMetOfPayHEA1Field = value;
            }
        }

        /// <remarks/>
        public EPD029HEAHEASecHEA358 SecHEA358
        {
            get
            {
                return this.secHEA358Field;
            }
            set
            {
                this.secHEA358Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecHEA358Specified
        {
            get
            {
                return this.secHEA358FieldSpecified;
            }
            set
            {
                this.secHEA358FieldSpecified = value;
            }
        }

        /// <remarks/>
        public string CodPlUnHEA357
        {
            get
            {
                return this.codPlUnHEA357Field;
            }
            set
            {
                this.codPlUnHEA357Field = value;
            }
        }

        /// <remarks/>
        public string CodPlUnHEA357LNG
        {
            get
            {
                return this.codPlUnHEA357LNGField;
            }
            set
            {
                this.codPlUnHEA357LNGField = value;
            }
        }

        /// <remarks/>
        public string VehicleMakeName
        {
            get
            {
                return this.vehicleMakeNameField;
            }
            set
            {
                this.vehicleMakeNameField = value;
            }
        }

        /// <remarks/>
        public string VehicleModelName
        {
            get
            {
                return this.vehicleModelNameField;
            }
            set
            {
                this.vehicleModelNameField = value;
            }
        }

        /// <remarks/>
        public string VehicleVIN
        {
            get
            {
                return this.vehicleVINField;
            }
            set
            {
                this.vehicleVINField = value;
            }
        }

        /// <remarks/>
        public string TypeOfMvt
        {
            get
            {
                return this.typeOfMvtField;
            }
            set
            {
                this.typeOfMvtField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    public enum TypOfDecHEA24EnumType
    {

        /// <remarks/>
        TIR,

        /// <remarks/>
        ETIR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum EPD029HEAHEAInlTraModHEA75
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum EPD029HEAHEATraModAtBorHEA76
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EPD045
    {

        private EPD045HEAHEA hEAHEAField;

        private TRAPRIPC1Type tRAPRIPC1Field;

        private CUSOFFDEPEPTType cUSOFFDEPEPTField;

        private CUSOFFDESESTType cUSOFFDESESTField;

        private List<SEAINFSLIType> sEAINFSLIField;

        private CONTRESULTSType cONTRESULTSField;

        /// <remarks/>
        public EPD045HEAHEA HEAHEA
        {
            get
            {
                return this.hEAHEAField;
            }
            set
            {
                this.hEAHEAField = value;
            }
        }

        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1
        {
            get
            {
                return this.tRAPRIPC1Field;
            }
            set
            {
                this.tRAPRIPC1Field = value;
            }
        }

        /// <remarks/>
        public CUSOFFDEPEPTType CUSOFFDEPEPT
        {
            get
            {
                return this.cUSOFFDEPEPTField;
            }
            set
            {
                this.cUSOFFDEPEPTField = value;
            }
        }

        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST
        {
            get
            {
                return this.cUSOFFDESESTField;
            }
            set
            {
                this.cUSOFFDESESTField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SEAINFSLISpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SEAINFSLI")]
        public List<SEAINFSLIType> SEAINFSLI
        {
            get
            {
                return this.sEAINFSLIField;
            }
            set
            {
                this.sEAINFSLIField = value;
            }
        }

        /// <remarks/>
        public CONTRESULTSType CONTRESULTS
        {
            get
            {
                return this.cONTRESULTSField;
            }
            set
            {
                this.cONTRESULTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EPD045HEAHEA
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string docNumHEA5Field;

        private string writeOffDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeNumber", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TIRCarnet", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string DocNumHEA5
        {
            get
            {
                return this.docNumHEA5Field;
            }
            set
            {
                this.docNumHEA5Field = value;
            }
        }

        /// <remarks/>
        public string WriteOffDate
        {
            get
            {
                return this.writeOffDateField;
            }
            set
            {
                this.writeOffDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        GuaranteeNumber,

        /// <remarks/>
        TIRCarnet,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EPD025
    {

        private EPD025HEAHEA hEAHEAField;

        private TRAPRIPC1Type tRAPRIPC1Field;

        private CUSOFFDESESTType cUSOFFDESESTField;

        private List<SEAINFSLIType> sEAINFSLIField;

        private CONTRESULTSType cONTRESULTSField;

        /// <remarks/>
        public EPD025HEAHEA HEAHEA
        {
            get
            {
                return this.hEAHEAField;
            }
            set
            {
                this.hEAHEAField = value;
            }
        }

        /// <remarks/>
        public TRAPRIPC1Type TRAPRIPC1
        {
            get
            {
                return this.tRAPRIPC1Field;
            }
            set
            {
                this.tRAPRIPC1Field = value;
            }
        }

        /// <remarks/>
        public CUSOFFDESESTType CUSOFFDESEST
        {
            get
            {
                return this.cUSOFFDESESTField;
            }
            set
            {
                this.cUSOFFDESESTField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SEAINFSLISpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SEAINFSLI")]
        public List<SEAINFSLIType> SEAINFSLI
        {
            get
            {
                return this.sEAINFSLIField;
            }
            set
            {
                this.sEAINFSLIField = value;
            }
        }

        /// <remarks/>
        public CONTRESULTSType CONTRESULTS
        {
            get
            {
                return this.cONTRESULTSField;
            }
            set
            {
                this.cONTRESULTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EPD025HEAHEA
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

        private string docNumHEA5Field;

        private string item1Field;

        private Item1ChoiceType item1ElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeNumber", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TIRCarnet", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string DocNumHEA5
        {
            get
            {
                return this.docNumHEA5Field;
            }
            set
            {
                this.docNumHEA5Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExitDate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("MessageDate", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("Item1ElementName")]
        public string Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public Item1ChoiceType Item1ElementName
        {
            get
            {
                return this.item1ElementNameField;
            }
            set
            {
                this.item1ElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        GuaranteeNumber,

        /// <remarks/>
        TIRCarnet,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum Item1ChoiceType
    {

        /// <remarks/>
        ExitDate,

        /// <remarks/>
        MessageDate,
    }

}
