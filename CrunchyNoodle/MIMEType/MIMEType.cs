using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class MIMEGeneralType
    {
        private string value;
        
        static public readonly MIMEGeneralType Application = new MIMEGeneralType("application");
static public readonly MIMEGeneralType Audio = new MIMEGeneralType("audio");
static public readonly MIMEGeneralType Chemical = new MIMEGeneralType("chemical");
static public readonly MIMEGeneralType Image = new MIMEGeneralType("image");
static public readonly MIMEGeneralType Message = new MIMEGeneralType("message");
static public readonly MIMEGeneralType Model = new MIMEGeneralType("model");
static public readonly MIMEGeneralType Text = new MIMEGeneralType("text");
static public readonly MIMEGeneralType Video = new MIMEGeneralType("video");
static public readonly MIMEGeneralType XConference = new MIMEGeneralType("x-conference");
        
        private MIMEGeneralType(string v)
        {
            value = v;
        }
        
        public override string ToString()
        {
            return value;
        }
    }
    
    public class MIMEType
    {
        private MIMEGeneralType general_type;
        private string sub_value;
        
        private List<string> extensions;
        private List<string> unofficial_sub_values;
        
        static public readonly MIMEType ApplicationAndrewInset = new MIMEType(MIMEGeneralType.Application, "andrew-inset", Enumerable.New("ez"), Enumerable.New<string>());
static public readonly MIMEType ApplicationApplixware = new MIMEType(MIMEGeneralType.Application, "applixware", Enumerable.New("aw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationAtomXml = new MIMEType(MIMEGeneralType.Application, "atom+xml", Enumerable.New("atom"), Enumerable.New<string>());
static public readonly MIMEType ApplicationAtomcatXml = new MIMEType(MIMEGeneralType.Application, "atomcat+xml", Enumerable.New("atomcat"), Enumerable.New<string>());
static public readonly MIMEType ApplicationAtomsvcXml = new MIMEType(MIMEGeneralType.Application, "atomsvc+xml", Enumerable.New("atomsvc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCcxmlXml = new MIMEType(MIMEGeneralType.Application, "ccxml+xml", Enumerable.New("ccxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCdmiCapability = new MIMEType(MIMEGeneralType.Application, "cdmi-capability", Enumerable.New("cdmia"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCdmiContainer = new MIMEType(MIMEGeneralType.Application, "cdmi-container", Enumerable.New("cdmic"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCdmiDomain = new MIMEType(MIMEGeneralType.Application, "cdmi-domain", Enumerable.New("cdmid"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCdmiObject = new MIMEType(MIMEGeneralType.Application, "cdmi-object", Enumerable.New("cdmio"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCdmiQueue = new MIMEType(MIMEGeneralType.Application, "cdmi-queue", Enumerable.New("cdmiq"), Enumerable.New<string>());
static public readonly MIMEType ApplicationCuSeeme = new MIMEType(MIMEGeneralType.Application, "cu-seeme", Enumerable.New("cu"), Enumerable.New<string>());
static public readonly MIMEType ApplicationDavmountXml = new MIMEType(MIMEGeneralType.Application, "davmount+xml", Enumerable.New("davmount"), Enumerable.New<string>());
static public readonly MIMEType ApplicationDocbookXml = new MIMEType(MIMEGeneralType.Application, "docbook+xml", Enumerable.New("dbk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationDsscDer = new MIMEType(MIMEGeneralType.Application, "dssc+der", Enumerable.New("dssc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationDsscXml = new MIMEType(MIMEGeneralType.Application, "dssc+xml", Enumerable.New("xdssc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationEcmascript = new MIMEType(MIMEGeneralType.Application, "ecmascript", Enumerable.New("ecma"), Enumerable.New<string>());
static public readonly MIMEType ApplicationEmmaXml = new MIMEType(MIMEGeneralType.Application, "emma+xml", Enumerable.New("emma"), Enumerable.New<string>());
static public readonly MIMEType ApplicationEpubZip = new MIMEType(MIMEGeneralType.Application, "epub+zip", Enumerable.New("epub"), Enumerable.New<string>());
static public readonly MIMEType ApplicationExi = new MIMEType(MIMEGeneralType.Application, "exi", Enumerable.New("exi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationFontTdpfr = new MIMEType(MIMEGeneralType.Application, "font-tdpfr", Enumerable.New("pfr"), Enumerable.New<string>());
static public readonly MIMEType ApplicationGmlXml = new MIMEType(MIMEGeneralType.Application, "gml+xml", Enumerable.New("gml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationGpxXml = new MIMEType(MIMEGeneralType.Application, "gpx+xml", Enumerable.New("gpx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationGxf = new MIMEType(MIMEGeneralType.Application, "gxf", Enumerable.New("gxf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationHyperstudio = new MIMEType(MIMEGeneralType.Application, "hyperstudio", Enumerable.New("stk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationInkmlXml = new MIMEType(MIMEGeneralType.Application, "inkml+xml", Enumerable.New("ink", "inkml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationIpfix = new MIMEType(MIMEGeneralType.Application, "ipfix", Enumerable.New("ipfix"), Enumerable.New<string>());
static public readonly MIMEType ApplicationJavaArchive = new MIMEType(MIMEGeneralType.Application, "java-archive", Enumerable.New("jar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationJavaSerializedObject = new MIMEType(MIMEGeneralType.Application, "java-serialized-object", Enumerable.New("ser"), Enumerable.New<string>());
static public readonly MIMEType ApplicationJavaVm = new MIMEType(MIMEGeneralType.Application, "java-vm", Enumerable.New("class"), Enumerable.New<string>());
static public readonly MIMEType ApplicationJavascript = new MIMEType(MIMEGeneralType.Application, "javascript", Enumerable.New("js"), Enumerable.New<string>());
static public readonly MIMEType ApplicationJson = new MIMEType(MIMEGeneralType.Application, "json", Enumerable.New("json"), Enumerable.New<string>());
static public readonly MIMEType ApplicationJsonmlJson = new MIMEType(MIMEGeneralType.Application, "jsonml+json", Enumerable.New("jsonml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationLostXml = new MIMEType(MIMEGeneralType.Application, "lost+xml", Enumerable.New("lostxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMacBinhex40 = new MIMEType(MIMEGeneralType.Application, "mac-binhex40", Enumerable.New("hqx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMacCompactpro = new MIMEType(MIMEGeneralType.Application, "mac-compactpro", Enumerable.New("cpt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMadsXml = new MIMEType(MIMEGeneralType.Application, "mads+xml", Enumerable.New("mads"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMarc = new MIMEType(MIMEGeneralType.Application, "marc", Enumerable.New("mrc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMarcxmlXml = new MIMEType(MIMEGeneralType.Application, "marcxml+xml", Enumerable.New("mrcx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMathematica = new MIMEType(MIMEGeneralType.Application, "mathematica", Enumerable.New("ma", "nb", "mb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMathmlXml = new MIMEType(MIMEGeneralType.Application, "mathml+xml", Enumerable.New("mathml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMbox = new MIMEType(MIMEGeneralType.Application, "mbox", Enumerable.New("mbox"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMediaservercontrolXml = new MIMEType(MIMEGeneralType.Application, "mediaservercontrol+xml", Enumerable.New("mscml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMetalinkXml = new MIMEType(MIMEGeneralType.Application, "metalink+xml", Enumerable.New("metalink"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMetalink4Xml = new MIMEType(MIMEGeneralType.Application, "metalink4+xml", Enumerable.New("meta4"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMetsXml = new MIMEType(MIMEGeneralType.Application, "mets+xml", Enumerable.New("mets"), Enumerable.New<string>());
static public readonly MIMEType ApplicationModsXml = new MIMEType(MIMEGeneralType.Application, "mods+xml", Enumerable.New("mods"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMp21 = new MIMEType(MIMEGeneralType.Application, "mp21", Enumerable.New("m21", "mp21"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMp4 = new MIMEType(MIMEGeneralType.Application, "mp4", Enumerable.New("mp4s"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMsword = new MIMEType(MIMEGeneralType.Application, "msword", Enumerable.New("doc", "dot"), Enumerable.New<string>());
static public readonly MIMEType ApplicationMxf = new MIMEType(MIMEGeneralType.Application, "mxf", Enumerable.New("mxf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOctetStream = new MIMEType(MIMEGeneralType.Application, "octet-stream", Enumerable.New("bin", "dms", "lrf", "mar", "so", "dist", "distz", "pkg", "bpk", "dump", "elc", "deploy"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOda = new MIMEType(MIMEGeneralType.Application, "oda", Enumerable.New("oda"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOebpsPackageXml = new MIMEType(MIMEGeneralType.Application, "oebps-package+xml", Enumerable.New("opf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOgg = new MIMEType(MIMEGeneralType.Application, "ogg", Enumerable.New("ogx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOmdocXml = new MIMEType(MIMEGeneralType.Application, "omdoc+xml", Enumerable.New("omdoc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOnenote = new MIMEType(MIMEGeneralType.Application, "onenote", Enumerable.New("onetoc", "onetoc2", "onetmp", "onepkg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationOxps = new MIMEType(MIMEGeneralType.Application, "oxps", Enumerable.New("oxps"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPatchOpsErrorXml = new MIMEType(MIMEGeneralType.Application, "patch-ops-error+xml", Enumerable.New("xer"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPdf = new MIMEType(MIMEGeneralType.Application, "pdf", Enumerable.New("pdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPgpEncrypted = new MIMEType(MIMEGeneralType.Application, "pgp-encrypted", Enumerable.New("pgp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPgpSignature = new MIMEType(MIMEGeneralType.Application, "pgp-signature", Enumerable.New("asc", "sig"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPicsRules = new MIMEType(MIMEGeneralType.Application, "pics-rules", Enumerable.New("prf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkcs10 = new MIMEType(MIMEGeneralType.Application, "pkcs10", Enumerable.New("p10"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkcs7Mime = new MIMEType(MIMEGeneralType.Application, "pkcs7-mime", Enumerable.New("p7m", "p7c"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkcs7Signature = new MIMEType(MIMEGeneralType.Application, "pkcs7-signature", Enumerable.New("p7s"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkcs8 = new MIMEType(MIMEGeneralType.Application, "pkcs8", Enumerable.New("p8"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkixAttrCert = new MIMEType(MIMEGeneralType.Application, "pkix-attr-cert", Enumerable.New("ac"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkixCert = new MIMEType(MIMEGeneralType.Application, "pkix-cert", Enumerable.New("cer"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkixCrl = new MIMEType(MIMEGeneralType.Application, "pkix-crl", Enumerable.New("crl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkixPkipath = new MIMEType(MIMEGeneralType.Application, "pkix-pkipath", Enumerable.New("pkipath"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPkixcmp = new MIMEType(MIMEGeneralType.Application, "pkixcmp", Enumerable.New("pki"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPlsXml = new MIMEType(MIMEGeneralType.Application, "pls+xml", Enumerable.New("pls"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPostscript = new MIMEType(MIMEGeneralType.Application, "postscript", Enumerable.New("ai", "eps", "ps"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPrsCww = new MIMEType(MIMEGeneralType.Application, "prs.cww", Enumerable.New("cww"), Enumerable.New<string>());
static public readonly MIMEType ApplicationPskcXml = new MIMEType(MIMEGeneralType.Application, "pskc+xml", Enumerable.New("pskcxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRdfXml = new MIMEType(MIMEGeneralType.Application, "rdf+xml", Enumerable.New("rdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationReginfoXml = new MIMEType(MIMEGeneralType.Application, "reginfo+xml", Enumerable.New("rif"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRelaxNgCompactSyntax = new MIMEType(MIMEGeneralType.Application, "relax-ng-compact-syntax", Enumerable.New("rnc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationResourceListsXml = new MIMEType(MIMEGeneralType.Application, "resource-lists+xml", Enumerable.New("rl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationResourceListsDiffXml = new MIMEType(MIMEGeneralType.Application, "resource-lists-diff+xml", Enumerable.New("rld"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRlsServicesXml = new MIMEType(MIMEGeneralType.Application, "rls-services+xml", Enumerable.New("rs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRpkiGhostbusters = new MIMEType(MIMEGeneralType.Application, "rpki-ghostbusters", Enumerable.New("gbr"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRpkiManifest = new MIMEType(MIMEGeneralType.Application, "rpki-manifest", Enumerable.New("mft"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRpkiRoa = new MIMEType(MIMEGeneralType.Application, "rpki-roa", Enumerable.New("roa"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRsdXml = new MIMEType(MIMEGeneralType.Application, "rsd+xml", Enumerable.New("rsd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRssXml = new MIMEType(MIMEGeneralType.Application, "rss+xml", Enumerable.New("rss"), Enumerable.New<string>());
static public readonly MIMEType ApplicationRtf = new MIMEType(MIMEGeneralType.Application, "rtf", Enumerable.New("rtf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSbmlXml = new MIMEType(MIMEGeneralType.Application, "sbml+xml", Enumerable.New("sbml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationScvpCvRequest = new MIMEType(MIMEGeneralType.Application, "scvp-cv-request", Enumerable.New("scq"), Enumerable.New<string>());
static public readonly MIMEType ApplicationScvpCvResponse = new MIMEType(MIMEGeneralType.Application, "scvp-cv-response", Enumerable.New("scs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationScvpVpRequest = new MIMEType(MIMEGeneralType.Application, "scvp-vp-request", Enumerable.New("spq"), Enumerable.New<string>());
static public readonly MIMEType ApplicationScvpVpResponse = new MIMEType(MIMEGeneralType.Application, "scvp-vp-response", Enumerable.New("spp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSdp = new MIMEType(MIMEGeneralType.Application, "sdp", Enumerable.New("sdp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSetPaymentInitiation = new MIMEType(MIMEGeneralType.Application, "set-payment-initiation", Enumerable.New("setpay"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSetRegistrationInitiation = new MIMEType(MIMEGeneralType.Application, "set-registration-initiation", Enumerable.New("setreg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationShfXml = new MIMEType(MIMEGeneralType.Application, "shf+xml", Enumerable.New("shf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSmilXml = new MIMEType(MIMEGeneralType.Application, "smil+xml", Enumerable.New("smi", "smil"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSparqlQuery = new MIMEType(MIMEGeneralType.Application, "sparql-query", Enumerable.New("rq"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSparqlResultsXml = new MIMEType(MIMEGeneralType.Application, "sparql-results+xml", Enumerable.New("srx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSrgs = new MIMEType(MIMEGeneralType.Application, "srgs", Enumerable.New("gram"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSrgsXml = new MIMEType(MIMEGeneralType.Application, "srgs+xml", Enumerable.New("grxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSruXml = new MIMEType(MIMEGeneralType.Application, "sru+xml", Enumerable.New("sru"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSsdlXml = new MIMEType(MIMEGeneralType.Application, "ssdl+xml", Enumerable.New("ssdl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationSsmlXml = new MIMEType(MIMEGeneralType.Application, "ssml+xml", Enumerable.New("ssml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationTeiXml = new MIMEType(MIMEGeneralType.Application, "tei+xml", Enumerable.New("tei", "teicorpus"), Enumerable.New<string>());
static public readonly MIMEType ApplicationThraudXml = new MIMEType(MIMEGeneralType.Application, "thraud+xml", Enumerable.New("tfi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationTimestampedData = new MIMEType(MIMEGeneralType.Application, "timestamped-data", Enumerable.New("tsd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVnd3gppPicBwLarge = new MIMEType(MIMEGeneralType.Application, "vnd.3gpp.pic-bw-large", Enumerable.New("plb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVnd3gppPicBwSmall = new MIMEType(MIMEGeneralType.Application, "vnd.3gpp.pic-bw-small", Enumerable.New("psb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVnd3gppPicBwVar = new MIMEType(MIMEGeneralType.Application, "vnd.3gpp.pic-bw-var", Enumerable.New("pvb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVnd3gpp2Tcap = new MIMEType(MIMEGeneralType.Application, "vnd.3gpp2.tcap", Enumerable.New("tcap"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVnd3mPostItNotes = new MIMEType(MIMEGeneralType.Application, "vnd.3m.post-it-notes", Enumerable.New("pwn"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAccpacSimplyAso = new MIMEType(MIMEGeneralType.Application, "vnd.accpac.simply.aso", Enumerable.New("aso"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAccpacSimplyImp = new MIMEType(MIMEGeneralType.Application, "vnd.accpac.simply.imp", Enumerable.New("imp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAcucobol = new MIMEType(MIMEGeneralType.Application, "vnd.acucobol", Enumerable.New("acu"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAcucorp = new MIMEType(MIMEGeneralType.Application, "vnd.acucorp", Enumerable.New("atc", "acutc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAdobeAirApplicationInstallerPackageZip = new MIMEType(MIMEGeneralType.Application, "vnd.adobe.air-application-installer-package+zip", Enumerable.New("air"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAdobeFormscentralFcdt = new MIMEType(MIMEGeneralType.Application, "vnd.adobe.formscentral.fcdt", Enumerable.New("fcdt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAdobeFxp = new MIMEType(MIMEGeneralType.Application, "vnd.adobe.fxp", Enumerable.New("fxp", "fxpl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAdobeXdpXml = new MIMEType(MIMEGeneralType.Application, "vnd.adobe.xdp+xml", Enumerable.New("xdp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAdobeXfdf = new MIMEType(MIMEGeneralType.Application, "vnd.adobe.xfdf", Enumerable.New("xfdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAheadSpace = new MIMEType(MIMEGeneralType.Application, "vnd.ahead.space", Enumerable.New("ahead"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAirzipFilesecureAzf = new MIMEType(MIMEGeneralType.Application, "vnd.airzip.filesecure.azf", Enumerable.New("azf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAirzipFilesecureAzs = new MIMEType(MIMEGeneralType.Application, "vnd.airzip.filesecure.azs", Enumerable.New("azs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAmazonEbook = new MIMEType(MIMEGeneralType.Application, "vnd.amazon.ebook", Enumerable.New("azw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAmericandynamicsAcc = new MIMEType(MIMEGeneralType.Application, "vnd.americandynamics.acc", Enumerable.New("acc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAmigaAmi = new MIMEType(MIMEGeneralType.Application, "vnd.amiga.ami", Enumerable.New("ami"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAndroidPackageArchive = new MIMEType(MIMEGeneralType.Application, "vnd.android.package-archive", Enumerable.New("apk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAnserWebCertificateIssueInitiation = new MIMEType(MIMEGeneralType.Application, "vnd.anser-web-certificate-issue-initiation", Enumerable.New("cii"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAnserWebFundsTransferInitiation = new MIMEType(MIMEGeneralType.Application, "vnd.anser-web-funds-transfer-initiation", Enumerable.New("fti"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAntixGameComponent = new MIMEType(MIMEGeneralType.Application, "vnd.antix.game-component", Enumerable.New("atx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAppleInstallerXml = new MIMEType(MIMEGeneralType.Application, "vnd.apple.installer+xml", Enumerable.New("mpkg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAppleMpegurl = new MIMEType(MIMEGeneralType.Application, "vnd.apple.mpegurl", Enumerable.New("m3u8"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAristanetworksSwi = new MIMEType(MIMEGeneralType.Application, "vnd.aristanetworks.swi", Enumerable.New("swi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAstraeaSoftwareIota = new MIMEType(MIMEGeneralType.Application, "vnd.astraea-software.iota", Enumerable.New("iota"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndAudiograph = new MIMEType(MIMEGeneralType.Application, "vnd.audiograph", Enumerable.New("aep"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndBlueiceMultipass = new MIMEType(MIMEGeneralType.Application, "vnd.blueice.multipass", Enumerable.New("mpm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndBmi = new MIMEType(MIMEGeneralType.Application, "vnd.bmi", Enumerable.New("bmi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndBusinessobjects = new MIMEType(MIMEGeneralType.Application, "vnd.businessobjects", Enumerable.New("rep"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndChemdrawXml = new MIMEType(MIMEGeneralType.Application, "vnd.chemdraw+xml", Enumerable.New("cdxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndChipnutsKaraokeMmd = new MIMEType(MIMEGeneralType.Application, "vnd.chipnuts.karaoke-mmd", Enumerable.New("mmd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCinderella = new MIMEType(MIMEGeneralType.Application, "vnd.cinderella", Enumerable.New("cdy"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndClaymore = new MIMEType(MIMEGeneralType.Application, "vnd.claymore", Enumerable.New("cla"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCloantoRp9 = new MIMEType(MIMEGeneralType.Application, "vnd.cloanto.rp9", Enumerable.New("rp9"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndClonkC4group = new MIMEType(MIMEGeneralType.Application, "vnd.clonk.c4group", Enumerable.New("c4g", "c4d", "c4f", "c4p", "c4u"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCluetrustCartomobileConfig = new MIMEType(MIMEGeneralType.Application, "vnd.cluetrust.cartomobile-config", Enumerable.New("c11amc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCluetrustCartomobileConfigPkg = new MIMEType(MIMEGeneralType.Application, "vnd.cluetrust.cartomobile-config-pkg", Enumerable.New("c11amz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCommonspace = new MIMEType(MIMEGeneralType.Application, "vnd.commonspace", Enumerable.New("csp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndContactCmsg = new MIMEType(MIMEGeneralType.Application, "vnd.contact.cmsg", Enumerable.New("cdbcmsg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCosmocaller = new MIMEType(MIMEGeneralType.Application, "vnd.cosmocaller", Enumerable.New("cmc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCrickClicker = new MIMEType(MIMEGeneralType.Application, "vnd.crick.clicker", Enumerable.New("clkx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCrickClickerKeyboard = new MIMEType(MIMEGeneralType.Application, "vnd.crick.clicker.keyboard", Enumerable.New("clkk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCrickClickerPalette = new MIMEType(MIMEGeneralType.Application, "vnd.crick.clicker.palette", Enumerable.New("clkp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCrickClickerTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.crick.clicker.template", Enumerable.New("clkt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCrickClickerWordbank = new MIMEType(MIMEGeneralType.Application, "vnd.crick.clicker.wordbank", Enumerable.New("clkw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCriticaltoolsWbsXml = new MIMEType(MIMEGeneralType.Application, "vnd.criticaltools.wbs+xml", Enumerable.New("wbs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCtcPosml = new MIMEType(MIMEGeneralType.Application, "vnd.ctc-posml", Enumerable.New("pml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCupsPpd = new MIMEType(MIMEGeneralType.Application, "vnd.cups-ppd", Enumerable.New("ppd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCurlCar = new MIMEType(MIMEGeneralType.Application, "vnd.curl.car", Enumerable.New("car"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndCurlPcurl = new MIMEType(MIMEGeneralType.Application, "vnd.curl.pcurl", Enumerable.New("pcurl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDart = new MIMEType(MIMEGeneralType.Application, "vnd.dart", Enumerable.New("dart"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDataVisionRdz = new MIMEType(MIMEGeneralType.Application, "vnd.data-vision.rdz", Enumerable.New("rdz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDeceData = new MIMEType(MIMEGeneralType.Application, "vnd.dece.data", Enumerable.New("uvf", "uvvf", "uvd", "uvvd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDeceTtmlXml = new MIMEType(MIMEGeneralType.Application, "vnd.dece.ttml+xml", Enumerable.New("uvt", "uvvt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDeceUnspecified = new MIMEType(MIMEGeneralType.Application, "vnd.dece.unspecified", Enumerable.New("uvx", "uvvx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDeceZip = new MIMEType(MIMEGeneralType.Application, "vnd.dece.zip", Enumerable.New("uvz", "uvvz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDenovoFcselayoutLink = new MIMEType(MIMEGeneralType.Application, "vnd.denovo.fcselayout-link", Enumerable.New("fe_launch"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDna = new MIMEType(MIMEGeneralType.Application, "vnd.dna", Enumerable.New("dna"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDolbyMlp = new MIMEType(MIMEGeneralType.Application, "vnd.dolby.mlp", Enumerable.New("mlp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDpgraph = new MIMEType(MIMEGeneralType.Application, "vnd.dpgraph", Enumerable.New("dpg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDreamfactory = new MIMEType(MIMEGeneralType.Application, "vnd.dreamfactory", Enumerable.New("dfac"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDsKeypoint = new MIMEType(MIMEGeneralType.Application, "vnd.ds-keypoint", Enumerable.New("kpxx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDvbAit = new MIMEType(MIMEGeneralType.Application, "vnd.dvb.ait", Enumerable.New("ait"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDvbService = new MIMEType(MIMEGeneralType.Application, "vnd.dvb.service", Enumerable.New("svc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndDynageo = new MIMEType(MIMEGeneralType.Application, "vnd.dynageo", Enumerable.New("geo"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEcowinChart = new MIMEType(MIMEGeneralType.Application, "vnd.ecowin.chart", Enumerable.New("mag"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEnliven = new MIMEType(MIMEGeneralType.Application, "vnd.enliven", Enumerable.New("nml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEpsonEsf = new MIMEType(MIMEGeneralType.Application, "vnd.epson.esf", Enumerable.New("esf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEpsonMsf = new MIMEType(MIMEGeneralType.Application, "vnd.epson.msf", Enumerable.New("msf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEpsonQuickanime = new MIMEType(MIMEGeneralType.Application, "vnd.epson.quickanime", Enumerable.New("qam"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEpsonSalt = new MIMEType(MIMEGeneralType.Application, "vnd.epson.salt", Enumerable.New("slt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEpsonSsf = new MIMEType(MIMEGeneralType.Application, "vnd.epson.ssf", Enumerable.New("ssf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEszigno3Xml = new MIMEType(MIMEGeneralType.Application, "vnd.eszigno3+xml", Enumerable.New("es3", "et3"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEzpixAlbum = new MIMEType(MIMEGeneralType.Application, "vnd.ezpix-album", Enumerable.New("ez2"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndEzpixPackage = new MIMEType(MIMEGeneralType.Application, "vnd.ezpix-package", Enumerable.New("ez3"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFdf = new MIMEType(MIMEGeneralType.Application, "vnd.fdf", Enumerable.New("fdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFdsnMseed = new MIMEType(MIMEGeneralType.Application, "vnd.fdsn.mseed", Enumerable.New("mseed"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFdsnSeed = new MIMEType(MIMEGeneralType.Application, "vnd.fdsn.seed", Enumerable.New("seed", "dataless"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFlographit = new MIMEType(MIMEGeneralType.Application, "vnd.flographit", Enumerable.New("gph"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFluxtimeClip = new MIMEType(MIMEGeneralType.Application, "vnd.fluxtime.clip", Enumerable.New("ftc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFramemaker = new MIMEType(MIMEGeneralType.Application, "vnd.framemaker", Enumerable.New("fm", "frame", "maker", "book"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFrogansFnc = new MIMEType(MIMEGeneralType.Application, "vnd.frogans.fnc", Enumerable.New("fnc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFrogansLtf = new MIMEType(MIMEGeneralType.Application, "vnd.frogans.ltf", Enumerable.New("ltf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFscWeblaunch = new MIMEType(MIMEGeneralType.Application, "vnd.fsc.weblaunch", Enumerable.New("fsc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujitsuOasys = new MIMEType(MIMEGeneralType.Application, "vnd.fujitsu.oasys", Enumerable.New("oas"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujitsuOasys2 = new MIMEType(MIMEGeneralType.Application, "vnd.fujitsu.oasys2", Enumerable.New("oa2"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujitsuOasys3 = new MIMEType(MIMEGeneralType.Application, "vnd.fujitsu.oasys3", Enumerable.New("oa3"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujitsuOasysgp = new MIMEType(MIMEGeneralType.Application, "vnd.fujitsu.oasysgp", Enumerable.New("fg5"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujitsuOasysprs = new MIMEType(MIMEGeneralType.Application, "vnd.fujitsu.oasysprs", Enumerable.New("bh2"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujixeroxDdd = new MIMEType(MIMEGeneralType.Application, "vnd.fujixerox.ddd", Enumerable.New("ddd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujixeroxDocuworks = new MIMEType(MIMEGeneralType.Application, "vnd.fujixerox.docuworks", Enumerable.New("xdw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFujixeroxDocuworksBinder = new MIMEType(MIMEGeneralType.Application, "vnd.fujixerox.docuworks.binder", Enumerable.New("xbd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndFuzzysheet = new MIMEType(MIMEGeneralType.Application, "vnd.fuzzysheet", Enumerable.New("fzs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGenomatixTuxedo = new MIMEType(MIMEGeneralType.Application, "vnd.genomatix.tuxedo", Enumerable.New("txd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGeogebraFile = new MIMEType(MIMEGeneralType.Application, "vnd.geogebra.file", Enumerable.New("ggb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGeogebraTool = new MIMEType(MIMEGeneralType.Application, "vnd.geogebra.tool", Enumerable.New("ggt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGeometryExplorer = new MIMEType(MIMEGeneralType.Application, "vnd.geometry-explorer", Enumerable.New("gex", "gre"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGeonext = new MIMEType(MIMEGeneralType.Application, "vnd.geonext", Enumerable.New("gxt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGeoplan = new MIMEType(MIMEGeneralType.Application, "vnd.geoplan", Enumerable.New("g2w"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGeospace = new MIMEType(MIMEGeneralType.Application, "vnd.geospace", Enumerable.New("g3w"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGmx = new MIMEType(MIMEGeneralType.Application, "vnd.gmx", Enumerable.New("gmx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGoogleEarthKmlXml = new MIMEType(MIMEGeneralType.Application, "vnd.google-earth.kml+xml", Enumerable.New("kml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGoogleEarthKmz = new MIMEType(MIMEGeneralType.Application, "vnd.google-earth.kmz", Enumerable.New("kmz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrafeq = new MIMEType(MIMEGeneralType.Application, "vnd.grafeq", Enumerable.New("gqf", "gqs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveAccount = new MIMEType(MIMEGeneralType.Application, "vnd.groove-account", Enumerable.New("gac"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveHelp = new MIMEType(MIMEGeneralType.Application, "vnd.groove-help", Enumerable.New("ghf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveIdentityMessage = new MIMEType(MIMEGeneralType.Application, "vnd.groove-identity-message", Enumerable.New("gim"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveInjector = new MIMEType(MIMEGeneralType.Application, "vnd.groove-injector", Enumerable.New("grv"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveToolMessage = new MIMEType(MIMEGeneralType.Application, "vnd.groove-tool-message", Enumerable.New("gtm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveToolTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.groove-tool-template", Enumerable.New("tpl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndGrooveVcard = new MIMEType(MIMEGeneralType.Application, "vnd.groove-vcard", Enumerable.New("vcg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHalXml = new MIMEType(MIMEGeneralType.Application, "vnd.hal+xml", Enumerable.New("hal"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHandheldEntertainmentXml = new MIMEType(MIMEGeneralType.Application, "vnd.handheld-entertainment+xml", Enumerable.New("zmm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHbci = new MIMEType(MIMEGeneralType.Application, "vnd.hbci", Enumerable.New("hbci"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHheLessonPlayer = new MIMEType(MIMEGeneralType.Application, "vnd.hhe.lesson-player", Enumerable.New("les"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHpHpgl = new MIMEType(MIMEGeneralType.Application, "vnd.hp-hpgl", Enumerable.New("hpgl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHpHpid = new MIMEType(MIMEGeneralType.Application, "vnd.hp-hpid", Enumerable.New("hpid"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHpHps = new MIMEType(MIMEGeneralType.Application, "vnd.hp-hps", Enumerable.New("hps"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHpJlyt = new MIMEType(MIMEGeneralType.Application, "vnd.hp-jlyt", Enumerable.New("jlt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHpPcl = new MIMEType(MIMEGeneralType.Application, "vnd.hp-pcl", Enumerable.New("pcl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHpPclxl = new MIMEType(MIMEGeneralType.Application, "vnd.hp-pclxl", Enumerable.New("pclxl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndHydrostatixSofData = new MIMEType(MIMEGeneralType.Application, "vnd.hydrostatix.sof-data", Enumerable.New("sfd-hdstx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIbmMinipay = new MIMEType(MIMEGeneralType.Application, "vnd.ibm.minipay", Enumerable.New("mpy"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIbmModcap = new MIMEType(MIMEGeneralType.Application, "vnd.ibm.modcap", Enumerable.New("afp", "listafp", "list3820"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIbmRightsManagement = new MIMEType(MIMEGeneralType.Application, "vnd.ibm.rights-management", Enumerable.New("irm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIbmSecureContainer = new MIMEType(MIMEGeneralType.Application, "vnd.ibm.secure-container", Enumerable.New("sc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIccprofile = new MIMEType(MIMEGeneralType.Application, "vnd.iccprofile", Enumerable.New("icc", "icm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIgloader = new MIMEType(MIMEGeneralType.Application, "vnd.igloader", Enumerable.New("igl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndImmervisionIvp = new MIMEType(MIMEGeneralType.Application, "vnd.immervision-ivp", Enumerable.New("ivp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndImmervisionIvu = new MIMEType(MIMEGeneralType.Application, "vnd.immervision-ivu", Enumerable.New("ivu"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndInsorsIgm = new MIMEType(MIMEGeneralType.Application, "vnd.insors.igm", Enumerable.New("igm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndInterconFormnet = new MIMEType(MIMEGeneralType.Application, "vnd.intercon.formnet", Enumerable.New("xpw", "xpx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIntergeo = new MIMEType(MIMEGeneralType.Application, "vnd.intergeo", Enumerable.New("i2g"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIntuQbo = new MIMEType(MIMEGeneralType.Application, "vnd.intu.qbo", Enumerable.New("qbo"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIntuQfx = new MIMEType(MIMEGeneralType.Application, "vnd.intu.qfx", Enumerable.New("qfx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIpunpluggedRcprofile = new MIMEType(MIMEGeneralType.Application, "vnd.ipunplugged.rcprofile", Enumerable.New("rcprofile"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIrepositoryPackageXml = new MIMEType(MIMEGeneralType.Application, "vnd.irepository.package+xml", Enumerable.New("irp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIsXpr = new MIMEType(MIMEGeneralType.Application, "vnd.is-xpr", Enumerable.New("xpr"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndIsacFcs = new MIMEType(MIMEGeneralType.Application, "vnd.isac.fcs", Enumerable.New("fcs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndJam = new MIMEType(MIMEGeneralType.Application, "vnd.jam", Enumerable.New("jam"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndJcpJavameMidletRms = new MIMEType(MIMEGeneralType.Application, "vnd.jcp.javame.midlet-rms", Enumerable.New("rms"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndJisp = new MIMEType(MIMEGeneralType.Application, "vnd.jisp", Enumerable.New("jisp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndJoostJodaArchive = new MIMEType(MIMEGeneralType.Application, "vnd.joost.joda-archive", Enumerable.New("joda"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKahootz = new MIMEType(MIMEGeneralType.Application, "vnd.kahootz", Enumerable.New("ktz", "ktr"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKarbon = new MIMEType(MIMEGeneralType.Application, "vnd.kde.karbon", Enumerable.New("karbon"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKchart = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kchart", Enumerable.New("chrt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKformula = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kformula", Enumerable.New("kfo"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKivio = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kivio", Enumerable.New("flw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKontour = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kontour", Enumerable.New("kon"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKpresenter = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kpresenter", Enumerable.New("kpr", "kpt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKspread = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kspread", Enumerable.New("ksp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKdeKword = new MIMEType(MIMEGeneralType.Application, "vnd.kde.kword", Enumerable.New("kwd", "kwt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKenameaapp = new MIMEType(MIMEGeneralType.Application, "vnd.kenameaapp", Enumerable.New("htke"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKidspiration = new MIMEType(MIMEGeneralType.Application, "vnd.kidspiration", Enumerable.New("kia"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKinar = new MIMEType(MIMEGeneralType.Application, "vnd.kinar", Enumerable.New("kne", "knp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKoan = new MIMEType(MIMEGeneralType.Application, "vnd.koan", Enumerable.New("skp", "skd", "skt", "skm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndKodakDescriptor = new MIMEType(MIMEGeneralType.Application, "vnd.kodak-descriptor", Enumerable.New("sse"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLasLasXml = new MIMEType(MIMEGeneralType.Application, "vnd.las.las+xml", Enumerable.New("lasxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLlamagraphicsLifeBalanceDesktop = new MIMEType(MIMEGeneralType.Application, "vnd.llamagraphics.life-balance.desktop", Enumerable.New("lbd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLlamagraphicsLifeBalanceExchangeXml = new MIMEType(MIMEGeneralType.Application, "vnd.llamagraphics.life-balance.exchange+xml", Enumerable.New("lbe"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotus123 = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-1-2-3", Enumerable.New("123"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotusApproach = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-approach", Enumerable.New("apr"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotusFreelance = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-freelance", Enumerable.New("pre"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotusNotes = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-notes", Enumerable.New("nsf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotusOrganizer = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-organizer", Enumerable.New("org"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotusScreencam = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-screencam", Enumerable.New("scm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndLotusWordpro = new MIMEType(MIMEGeneralType.Application, "vnd.lotus-wordpro", Enumerable.New("lwp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMacportsPortpkg = new MIMEType(MIMEGeneralType.Application, "vnd.macports.portpkg", Enumerable.New("portpkg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMcd = new MIMEType(MIMEGeneralType.Application, "vnd.mcd", Enumerable.New("mcd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMedcalcdata = new MIMEType(MIMEGeneralType.Application, "vnd.medcalcdata", Enumerable.New("mc1"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMediastationCdkey = new MIMEType(MIMEGeneralType.Application, "vnd.mediastation.cdkey", Enumerable.New("cdkey"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMfer = new MIMEType(MIMEGeneralType.Application, "vnd.mfer", Enumerable.New("mwf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMfmp = new MIMEType(MIMEGeneralType.Application, "vnd.mfmp", Enumerable.New("mfm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMicrografxFlo = new MIMEType(MIMEGeneralType.Application, "vnd.micrografx.flo", Enumerable.New("flo"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMicrografxIgx = new MIMEType(MIMEGeneralType.Application, "vnd.micrografx.igx", Enumerable.New("igx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMif = new MIMEType(MIMEGeneralType.Application, "vnd.mif", Enumerable.New("mif"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusDaf = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.daf", Enumerable.New("daf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusDis = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.dis", Enumerable.New("dis"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusMbk = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.mbk", Enumerable.New("mbk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusMqy = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.mqy", Enumerable.New("mqy"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusMsl = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.msl", Enumerable.New("msl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusPlc = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.plc", Enumerable.New("plc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMobiusTxf = new MIMEType(MIMEGeneralType.Application, "vnd.mobius.txf", Enumerable.New("txf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMophunApplication = new MIMEType(MIMEGeneralType.Application, "vnd.mophun.application", Enumerable.New("mpn"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMophunCertificate = new MIMEType(MIMEGeneralType.Application, "vnd.mophun.certificate", Enumerable.New("mpc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMozillaXulXml = new MIMEType(MIMEGeneralType.Application, "vnd.mozilla.xul+xml", Enumerable.New("xul"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsArtgalry = new MIMEType(MIMEGeneralType.Application, "vnd.ms-artgalry", Enumerable.New("cil"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsCabCompressed = new MIMEType(MIMEGeneralType.Application, "vnd.ms-cab-compressed", Enumerable.New("cab"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsExcel = new MIMEType(MIMEGeneralType.Application, "vnd.ms-excel", Enumerable.New("xls", "xlm", "xla", "xlc", "xlt", "xlw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsExcelAddinMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-excel.addin.macroenabled.12", Enumerable.New("xlam"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsExcelSheetBinaryMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-excel.sheet.binary.macroenabled.12", Enumerable.New("xlsb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsExcelSheetMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-excel.sheet.macroenabled.12", Enumerable.New("xlsm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsExcelTemplateMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-excel.template.macroenabled.12", Enumerable.New("xltm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsFontobject = new MIMEType(MIMEGeneralType.Application, "vnd.ms-fontobject", Enumerable.New("eot"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsHtmlhelp = new MIMEType(MIMEGeneralType.Application, "vnd.ms-htmlhelp", Enumerable.New("chm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsIms = new MIMEType(MIMEGeneralType.Application, "vnd.ms-ims", Enumerable.New("ims"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsLrm = new MIMEType(MIMEGeneralType.Application, "vnd.ms-lrm", Enumerable.New("lrm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsOfficetheme = new MIMEType(MIMEGeneralType.Application, "vnd.ms-officetheme", Enumerable.New("thmx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPkiSeccat = new MIMEType(MIMEGeneralType.Application, "vnd.ms-pki.seccat", Enumerable.New("cat"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPkiStl = new MIMEType(MIMEGeneralType.Application, "vnd.ms-pki.stl", Enumerable.New("stl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPowerpoint = new MIMEType(MIMEGeneralType.Application, "vnd.ms-powerpoint", Enumerable.New("ppt", "pps", "pot"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPowerpointAddinMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-powerpoint.addin.macroenabled.12", Enumerable.New("ppam"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPowerpointPresentationMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-powerpoint.presentation.macroenabled.12", Enumerable.New("pptm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPowerpointSlideMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-powerpoint.slide.macroenabled.12", Enumerable.New("sldm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPowerpointSlideshowMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-powerpoint.slideshow.macroenabled.12", Enumerable.New("ppsm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsPowerpointTemplateMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-powerpoint.template.macroenabled.12", Enumerable.New("potm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsProject = new MIMEType(MIMEGeneralType.Application, "vnd.ms-project", Enumerable.New("mpp", "mpt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsWordDocumentMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-word.document.macroenabled.12", Enumerable.New("docm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsWordTemplateMacroenabled12 = new MIMEType(MIMEGeneralType.Application, "vnd.ms-word.template.macroenabled.12", Enumerable.New("dotm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsWorks = new MIMEType(MIMEGeneralType.Application, "vnd.ms-works", Enumerable.New("wps", "wks", "wcm", "wdb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsWpl = new MIMEType(MIMEGeneralType.Application, "vnd.ms-wpl", Enumerable.New("wpl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMsXpsdocument = new MIMEType(MIMEGeneralType.Application, "vnd.ms-xpsdocument", Enumerable.New("xps"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMseq = new MIMEType(MIMEGeneralType.Application, "vnd.mseq", Enumerable.New("mseq"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMusician = new MIMEType(MIMEGeneralType.Application, "vnd.musician", Enumerable.New("mus"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMuveeStyle = new MIMEType(MIMEGeneralType.Application, "vnd.muvee.style", Enumerable.New("msty"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndMynfc = new MIMEType(MIMEGeneralType.Application, "vnd.mynfc", Enumerable.New("taglet"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNeurolanguageNlu = new MIMEType(MIMEGeneralType.Application, "vnd.neurolanguage.nlu", Enumerable.New("nlu"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNitf = new MIMEType(MIMEGeneralType.Application, "vnd.nitf", Enumerable.New("ntf", "nitf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNoblenetDirectory = new MIMEType(MIMEGeneralType.Application, "vnd.noblenet-directory", Enumerable.New("nnd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNoblenetSealer = new MIMEType(MIMEGeneralType.Application, "vnd.noblenet-sealer", Enumerable.New("nns"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNoblenetWeb = new MIMEType(MIMEGeneralType.Application, "vnd.noblenet-web", Enumerable.New("nnw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNokiaNGageData = new MIMEType(MIMEGeneralType.Application, "vnd.nokia.n-gage.data", Enumerable.New("ngdat"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNokiaNGageSymbianInstall = new MIMEType(MIMEGeneralType.Application, "vnd.nokia.n-gage.symbian.install", Enumerable.New("n-gage"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNokiaRadioPreset = new MIMEType(MIMEGeneralType.Application, "vnd.nokia.radio-preset", Enumerable.New("rpst"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNokiaRadioPresets = new MIMEType(MIMEGeneralType.Application, "vnd.nokia.radio-presets", Enumerable.New("rpss"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNovadigmEdm = new MIMEType(MIMEGeneralType.Application, "vnd.novadigm.edm", Enumerable.New("edm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNovadigmEdx = new MIMEType(MIMEGeneralType.Application, "vnd.novadigm.edx", Enumerable.New("edx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndNovadigmExt = new MIMEType(MIMEGeneralType.Application, "vnd.novadigm.ext", Enumerable.New("ext"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentChart = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.chart", Enumerable.New("odc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentChartTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.chart-template", Enumerable.New("otc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentDatabase = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.database", Enumerable.New("odb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentFormula = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.formula", Enumerable.New("odf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentFormulaTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.formula-template", Enumerable.New("odft"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentGraphics = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.graphics", Enumerable.New("odg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentGraphicsTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.graphics-template", Enumerable.New("otg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentImage = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.image", Enumerable.New("odi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentImageTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.image-template", Enumerable.New("oti"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentPresentation = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.presentation", Enumerable.New("odp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentPresentationTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.presentation-template", Enumerable.New("otp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentSpreadsheet = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.spreadsheet", Enumerable.New("ods"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentSpreadsheetTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.spreadsheet-template", Enumerable.New("ots"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentText = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.text", Enumerable.New("odt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentTextMaster = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.text-master", Enumerable.New("odm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentTextTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.text-template", Enumerable.New("ott"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOasisOpendocumentTextWeb = new MIMEType(MIMEGeneralType.Application, "vnd.oasis.opendocument.text-web", Enumerable.New("oth"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOlpcSugar = new MIMEType(MIMEGeneralType.Application, "vnd.olpc-sugar", Enumerable.New("xo"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOmaDd2Xml = new MIMEType(MIMEGeneralType.Application, "vnd.oma.dd2+xml", Enumerable.New("dd2"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenofficeorgExtension = new MIMEType(MIMEGeneralType.Application, "vnd.openofficeorg.extension", Enumerable.New("oxt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.presentationml.presentation", Enumerable.New("pptx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentPresentationmlSlide = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.presentationml.slide", Enumerable.New("sldx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentPresentationmlSlideshow = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.presentationml.slideshow", Enumerable.New("ppsx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentPresentationmlTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.presentationml.template", Enumerable.New("potx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.spreadsheetml.sheet", Enumerable.New("xlsx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.spreadsheetml.template", Enumerable.New("xltx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.wordprocessingml.document", Enumerable.New("docx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.openxmlformats-officedocument.wordprocessingml.template", Enumerable.New("dotx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOsgeoMapguidePackage = new MIMEType(MIMEGeneralType.Application, "vnd.osgeo.mapguide.package", Enumerable.New("mgp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOsgiDp = new MIMEType(MIMEGeneralType.Application, "vnd.osgi.dp", Enumerable.New("dp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndOsgiSubsystem = new MIMEType(MIMEGeneralType.Application, "vnd.osgi.subsystem", Enumerable.New("esa"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPalm = new MIMEType(MIMEGeneralType.Application, "vnd.palm", Enumerable.New("pdb", "pqa", "oprc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPawaafile = new MIMEType(MIMEGeneralType.Application, "vnd.pawaafile", Enumerable.New("paw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPgFormat = new MIMEType(MIMEGeneralType.Application, "vnd.pg.format", Enumerable.New("str"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPgOsasli = new MIMEType(MIMEGeneralType.Application, "vnd.pg.osasli", Enumerable.New("ei6"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPicsel = new MIMEType(MIMEGeneralType.Application, "vnd.picsel", Enumerable.New("efif"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPmiWidget = new MIMEType(MIMEGeneralType.Application, "vnd.pmi.widget", Enumerable.New("wg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPocketlearn = new MIMEType(MIMEGeneralType.Application, "vnd.pocketlearn", Enumerable.New("plf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPowerbuilder6 = new MIMEType(MIMEGeneralType.Application, "vnd.powerbuilder6", Enumerable.New("pbd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPreviewsystemsBox = new MIMEType(MIMEGeneralType.Application, "vnd.previewsystems.box", Enumerable.New("box"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndProteusMagazine = new MIMEType(MIMEGeneralType.Application, "vnd.proteus.magazine", Enumerable.New("mgz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPublishareDeltaTree = new MIMEType(MIMEGeneralType.Application, "vnd.publishare-delta-tree", Enumerable.New("qps"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndPviPtid1 = new MIMEType(MIMEGeneralType.Application, "vnd.pvi.ptid1", Enumerable.New("ptid"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndQuarkQuarkxpress = new MIMEType(MIMEGeneralType.Application, "vnd.quark.quarkxpress", Enumerable.New("qxd", "qxt", "qwd", "qwt", "qxl", "qxb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRealvncBed = new MIMEType(MIMEGeneralType.Application, "vnd.realvnc.bed", Enumerable.New("bed"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRecordareMusicxml = new MIMEType(MIMEGeneralType.Application, "vnd.recordare.musicxml", Enumerable.New("mxl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRecordareMusicxmlXml = new MIMEType(MIMEGeneralType.Application, "vnd.recordare.musicxml+xml", Enumerable.New("musicxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRigCryptonote = new MIMEType(MIMEGeneralType.Application, "vnd.rig.cryptonote", Enumerable.New("cryptonote"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRimCod = new MIMEType(MIMEGeneralType.Application, "vnd.rim.cod", Enumerable.New("cod"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRnRealmedia = new MIMEType(MIMEGeneralType.Application, "vnd.rn-realmedia", Enumerable.New("rm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRnRealmediaVbr = new MIMEType(MIMEGeneralType.Application, "vnd.rn-realmedia-vbr", Enumerable.New("rmvb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndRoute66Link66Xml = new MIMEType(MIMEGeneralType.Application, "vnd.route66.link66+xml", Enumerable.New("link66"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSailingtrackerTrack = new MIMEType(MIMEGeneralType.Application, "vnd.sailingtracker.track", Enumerable.New("st"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSeemail = new MIMEType(MIMEGeneralType.Application, "vnd.seemail", Enumerable.New("see"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSema = new MIMEType(MIMEGeneralType.Application, "vnd.sema", Enumerable.New("sema"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSemd = new MIMEType(MIMEGeneralType.Application, "vnd.semd", Enumerable.New("semd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSemf = new MIMEType(MIMEGeneralType.Application, "vnd.semf", Enumerable.New("semf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndShanaInformedFormdata = new MIMEType(MIMEGeneralType.Application, "vnd.shana.informed.formdata", Enumerable.New("ifm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndShanaInformedFormtemplate = new MIMEType(MIMEGeneralType.Application, "vnd.shana.informed.formtemplate", Enumerable.New("itp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndShanaInformedInterchange = new MIMEType(MIMEGeneralType.Application, "vnd.shana.informed.interchange", Enumerable.New("iif"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndShanaInformedPackage = new MIMEType(MIMEGeneralType.Application, "vnd.shana.informed.package", Enumerable.New("ipk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSimtechMindmapper = new MIMEType(MIMEGeneralType.Application, "vnd.simtech-mindmapper", Enumerable.New("twd", "twds"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSmaf = new MIMEType(MIMEGeneralType.Application, "vnd.smaf", Enumerable.New("mmf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSmartTeacher = new MIMEType(MIMEGeneralType.Application, "vnd.smart.teacher", Enumerable.New("teacher"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSolentSdkmXml = new MIMEType(MIMEGeneralType.Application, "vnd.solent.sdkm+xml", Enumerable.New("sdkm", "sdkd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSpotfireDxp = new MIMEType(MIMEGeneralType.Application, "vnd.spotfire.dxp", Enumerable.New("dxp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSpotfireSfs = new MIMEType(MIMEGeneralType.Application, "vnd.spotfire.sfs", Enumerable.New("sfs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStardivisionCalc = new MIMEType(MIMEGeneralType.Application, "vnd.stardivision.calc", Enumerable.New("sdc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStardivisionDraw = new MIMEType(MIMEGeneralType.Application, "vnd.stardivision.draw", Enumerable.New("sda"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStardivisionImpress = new MIMEType(MIMEGeneralType.Application, "vnd.stardivision.impress", Enumerable.New("sdd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStardivisionMath = new MIMEType(MIMEGeneralType.Application, "vnd.stardivision.math", Enumerable.New("smf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStardivisionWriter = new MIMEType(MIMEGeneralType.Application, "vnd.stardivision.writer", Enumerable.New("sdw", "vor"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStardivisionWriterGlobal = new MIMEType(MIMEGeneralType.Application, "vnd.stardivision.writer-global", Enumerable.New("sgl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStepmaniaPackage = new MIMEType(MIMEGeneralType.Application, "vnd.stepmania.package", Enumerable.New("smzip"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndStepmaniaStepchart = new MIMEType(MIMEGeneralType.Application, "vnd.stepmania.stepchart", Enumerable.New("sm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlCalc = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.calc", Enumerable.New("sxc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlCalcTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.calc.template", Enumerable.New("stc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlDraw = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.draw", Enumerable.New("sxd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlDrawTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.draw.template", Enumerable.New("std"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlImpress = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.impress", Enumerable.New("sxi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlImpressTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.impress.template", Enumerable.New("sti"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlMath = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.math", Enumerable.New("sxm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlWriter = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.writer", Enumerable.New("sxw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlWriterGlobal = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.writer.global", Enumerable.New("sxg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSunXmlWriterTemplate = new MIMEType(MIMEGeneralType.Application, "vnd.sun.xml.writer.template", Enumerable.New("stw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSusCalendar = new MIMEType(MIMEGeneralType.Application, "vnd.sus-calendar", Enumerable.New("sus", "susp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSvd = new MIMEType(MIMEGeneralType.Application, "vnd.svd", Enumerable.New("svd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSymbianInstall = new MIMEType(MIMEGeneralType.Application, "vnd.symbian.install", Enumerable.New("sis", "sisx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSyncmlXml = new MIMEType(MIMEGeneralType.Application, "vnd.syncml+xml", Enumerable.New("xsm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSyncmlDmWbxml = new MIMEType(MIMEGeneralType.Application, "vnd.syncml.dm+wbxml", Enumerable.New("bdm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndSyncmlDmXml = new MIMEType(MIMEGeneralType.Application, "vnd.syncml.dm+xml", Enumerable.New("xdm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndTaoIntentModuleArchive = new MIMEType(MIMEGeneralType.Application, "vnd.tao.intent-module-archive", Enumerable.New("tao"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndTcpdumpPcap = new MIMEType(MIMEGeneralType.Application, "vnd.tcpdump.pcap", Enumerable.New("pcap", "cap", "dmp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndTmobileLivetv = new MIMEType(MIMEGeneralType.Application, "vnd.tmobile-livetv", Enumerable.New("tmo"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndTridTpt = new MIMEType(MIMEGeneralType.Application, "vnd.trid.tpt", Enumerable.New("tpt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndTriscapeMxs = new MIMEType(MIMEGeneralType.Application, "vnd.triscape.mxs", Enumerable.New("mxs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndTrueapp = new MIMEType(MIMEGeneralType.Application, "vnd.trueapp", Enumerable.New("tra"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndUfdl = new MIMEType(MIMEGeneralType.Application, "vnd.ufdl", Enumerable.New("ufd", "ufdl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndUiqTheme = new MIMEType(MIMEGeneralType.Application, "vnd.uiq.theme", Enumerable.New("utz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndUmajin = new MIMEType(MIMEGeneralType.Application, "vnd.umajin", Enumerable.New("umj"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndUnity = new MIMEType(MIMEGeneralType.Application, "vnd.unity", Enumerable.New("unityweb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndUomlXml = new MIMEType(MIMEGeneralType.Application, "vnd.uoml+xml", Enumerable.New("uoml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndVcx = new MIMEType(MIMEGeneralType.Application, "vnd.vcx", Enumerable.New("vcx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndVisio = new MIMEType(MIMEGeneralType.Application, "vnd.visio", Enumerable.New("vsd", "vst", "vss", "vsw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndVisionary = new MIMEType(MIMEGeneralType.Application, "vnd.visionary", Enumerable.New("vis"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndVsf = new MIMEType(MIMEGeneralType.Application, "vnd.vsf", Enumerable.New("vsf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWapWbxml = new MIMEType(MIMEGeneralType.Application, "vnd.wap.wbxml", Enumerable.New("wbxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWapWmlc = new MIMEType(MIMEGeneralType.Application, "vnd.wap.wmlc", Enumerable.New("wmlc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWapWmlscriptc = new MIMEType(MIMEGeneralType.Application, "vnd.wap.wmlscriptc", Enumerable.New("wmlsc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWebturbo = new MIMEType(MIMEGeneralType.Application, "vnd.webturbo", Enumerable.New("wtb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWolframPlayer = new MIMEType(MIMEGeneralType.Application, "vnd.wolfram.player", Enumerable.New("nbp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWordperfect = new MIMEType(MIMEGeneralType.Application, "vnd.wordperfect", Enumerable.New("wpd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWqd = new MIMEType(MIMEGeneralType.Application, "vnd.wqd", Enumerable.New("wqd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndWtStf = new MIMEType(MIMEGeneralType.Application, "vnd.wt.stf", Enumerable.New("stf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndXara = new MIMEType(MIMEGeneralType.Application, "vnd.xara", Enumerable.New("xar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndXfdl = new MIMEType(MIMEGeneralType.Application, "vnd.xfdl", Enumerable.New("xfdl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaHvDic = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.hv-dic", Enumerable.New("hvd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaHvScript = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.hv-script", Enumerable.New("hvs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaHvVoice = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.hv-voice", Enumerable.New("hvp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaOpenscoreformat = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.openscoreformat", Enumerable.New("osf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaOpenscoreformatOsfpvgXml = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.openscoreformat.osfpvg+xml", Enumerable.New("osfpvg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaSmafAudio = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.smaf-audio", Enumerable.New("saf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYamahaSmafPhrase = new MIMEType(MIMEGeneralType.Application, "vnd.yamaha.smaf-phrase", Enumerable.New("spf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndYellowriverCustomMenu = new MIMEType(MIMEGeneralType.Application, "vnd.yellowriver-custom-menu", Enumerable.New("cmp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndZul = new MIMEType(MIMEGeneralType.Application, "vnd.zul", Enumerable.New("zir", "zirz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVndZzazzDeckXml = new MIMEType(MIMEGeneralType.Application, "vnd.zzazz.deck+xml", Enumerable.New("zaz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationVoicexmlXml = new MIMEType(MIMEGeneralType.Application, "voicexml+xml", Enumerable.New("vxml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationWidget = new MIMEType(MIMEGeneralType.Application, "widget", Enumerable.New("wgt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationWinhlp = new MIMEType(MIMEGeneralType.Application, "winhlp", Enumerable.New("hlp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationWsdlXml = new MIMEType(MIMEGeneralType.Application, "wsdl+xml", Enumerable.New("wsdl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationWspolicyXml = new MIMEType(MIMEGeneralType.Application, "wspolicy+xml", Enumerable.New("wspolicy"), Enumerable.New<string>());
static public readonly MIMEType ApplicationX7zCompressed = new MIMEType(MIMEGeneralType.Application, "x-7z-compressed", Enumerable.New("7z"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXAbiword = new MIMEType(MIMEGeneralType.Application, "x-abiword", Enumerable.New("abw"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXAceCompressed = new MIMEType(MIMEGeneralType.Application, "x-ace-compressed", Enumerable.New("ace"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXAppleDiskimage = new MIMEType(MIMEGeneralType.Application, "x-apple-diskimage", Enumerable.New("dmg"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXAuthorwareBin = new MIMEType(MIMEGeneralType.Application, "x-authorware-bin", Enumerable.New("aab", "x32", "u32", "vox"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXAuthorwareMap = new MIMEType(MIMEGeneralType.Application, "x-authorware-map", Enumerable.New("aam"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXAuthorwareSeg = new MIMEType(MIMEGeneralType.Application, "x-authorware-seg", Enumerable.New("aas"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXBcpio = new MIMEType(MIMEGeneralType.Application, "x-bcpio", Enumerable.New("bcpio"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXBittorrent = new MIMEType(MIMEGeneralType.Application, "x-bittorrent", Enumerable.New("torrent"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXBlorb = new MIMEType(MIMEGeneralType.Application, "x-blorb", Enumerable.New("blb", "blorb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXBzip = new MIMEType(MIMEGeneralType.Application, "x-bzip", Enumerable.New("bz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXBzip2 = new MIMEType(MIMEGeneralType.Application, "x-bzip2", Enumerable.New("bz2", "boz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXCbr = new MIMEType(MIMEGeneralType.Application, "x-cbr", Enumerable.New("cbr", "cba", "cbt", "cbz", "cb7"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXCdlink = new MIMEType(MIMEGeneralType.Application, "x-cdlink", Enumerable.New("vcd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXCfsCompressed = new MIMEType(MIMEGeneralType.Application, "x-cfs-compressed", Enumerable.New("cfs"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXChat = new MIMEType(MIMEGeneralType.Application, "x-chat", Enumerable.New("chat"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXChessPgn = new MIMEType(MIMEGeneralType.Application, "x-chess-pgn", Enumerable.New("pgn"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXConference = new MIMEType(MIMEGeneralType.Application, "x-conference", Enumerable.New("nsc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXCpio = new MIMEType(MIMEGeneralType.Application, "x-cpio", Enumerable.New("cpio"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXCsh = new MIMEType(MIMEGeneralType.Application, "x-csh", Enumerable.New("csh"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDebianPackage = new MIMEType(MIMEGeneralType.Application, "x-debian-package", Enumerable.New("deb", "udeb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDgcCompressed = new MIMEType(MIMEGeneralType.Application, "x-dgc-compressed", Enumerable.New("dgc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDirector = new MIMEType(MIMEGeneralType.Application, "x-director", Enumerable.New("dir", "dcr", "dxr", "cst", "cct", "cxt", "w3d", "fgd", "swa"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDoom = new MIMEType(MIMEGeneralType.Application, "x-doom", Enumerable.New("wad"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDtbncxXml = new MIMEType(MIMEGeneralType.Application, "x-dtbncx+xml", Enumerable.New("ncx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDtbookXml = new MIMEType(MIMEGeneralType.Application, "x-dtbook+xml", Enumerable.New("dtb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDtbresourceXml = new MIMEType(MIMEGeneralType.Application, "x-dtbresource+xml", Enumerable.New("res"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXDvi = new MIMEType(MIMEGeneralType.Application, "x-dvi", Enumerable.New("dvi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXEnvoy = new MIMEType(MIMEGeneralType.Application, "x-envoy", Enumerable.New("evy"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXEva = new MIMEType(MIMEGeneralType.Application, "x-eva", Enumerable.New("eva"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontBdf = new MIMEType(MIMEGeneralType.Application, "x-font-bdf", Enumerable.New("bdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontGhostscript = new MIMEType(MIMEGeneralType.Application, "x-font-ghostscript", Enumerable.New("gsf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontLinuxPsf = new MIMEType(MIMEGeneralType.Application, "x-font-linux-psf", Enumerable.New("psf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontOtf = new MIMEType(MIMEGeneralType.Application, "x-font-otf", Enumerable.New("otf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontPcf = new MIMEType(MIMEGeneralType.Application, "x-font-pcf", Enumerable.New("pcf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontSnf = new MIMEType(MIMEGeneralType.Application, "x-font-snf", Enumerable.New("snf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontTtf = new MIMEType(MIMEGeneralType.Application, "x-font-ttf", Enumerable.New("ttf", "ttc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontType1 = new MIMEType(MIMEGeneralType.Application, "x-font-type1", Enumerable.New("pfa", "pfb", "pfm", "afm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFontWoff = new MIMEType(MIMEGeneralType.Application, "x-font-woff", Enumerable.New("woff"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFreearc = new MIMEType(MIMEGeneralType.Application, "x-freearc", Enumerable.New("arc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXFuturesplash = new MIMEType(MIMEGeneralType.Application, "x-futuresplash", Enumerable.New("spl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXGcaCompressed = new MIMEType(MIMEGeneralType.Application, "x-gca-compressed", Enumerable.New("gca"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXGlulx = new MIMEType(MIMEGeneralType.Application, "x-glulx", Enumerable.New("ulx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXGnumeric = new MIMEType(MIMEGeneralType.Application, "x-gnumeric", Enumerable.New("gnumeric"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXGrampsXml = new MIMEType(MIMEGeneralType.Application, "x-gramps-xml", Enumerable.New("gramps"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXGtar = new MIMEType(MIMEGeneralType.Application, "x-gtar", Enumerable.New("gtar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXHdf = new MIMEType(MIMEGeneralType.Application, "x-hdf", Enumerable.New("hdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXInstallInstructions = new MIMEType(MIMEGeneralType.Application, "x-install-instructions", Enumerable.New("install"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXIso9660Image = new MIMEType(MIMEGeneralType.Application, "x-iso9660-image", Enumerable.New("iso"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXJavaJnlpFile = new MIMEType(MIMEGeneralType.Application, "x-java-jnlp-file", Enumerable.New("jnlp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXLatex = new MIMEType(MIMEGeneralType.Application, "x-latex", Enumerable.New("latex"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXLzhCompressed = new MIMEType(MIMEGeneralType.Application, "x-lzh-compressed", Enumerable.New("lzh", "lha"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMie = new MIMEType(MIMEGeneralType.Application, "x-mie", Enumerable.New("mie"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMobipocketEbook = new MIMEType(MIMEGeneralType.Application, "x-mobipocket-ebook", Enumerable.New("prc", "mobi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsApplication = new MIMEType(MIMEGeneralType.Application, "x-ms-application", Enumerable.New("application"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsShortcut = new MIMEType(MIMEGeneralType.Application, "x-ms-shortcut", Enumerable.New("lnk"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsWmd = new MIMEType(MIMEGeneralType.Application, "x-ms-wmd", Enumerable.New("wmd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsWmz = new MIMEType(MIMEGeneralType.Application, "x-ms-wmz", Enumerable.New("wmz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsXbap = new MIMEType(MIMEGeneralType.Application, "x-ms-xbap", Enumerable.New("xbap"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsaccess = new MIMEType(MIMEGeneralType.Application, "x-msaccess", Enumerable.New("mdb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsbinder = new MIMEType(MIMEGeneralType.Application, "x-msbinder", Enumerable.New("obd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMscardfile = new MIMEType(MIMEGeneralType.Application, "x-mscardfile", Enumerable.New("crd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsclip = new MIMEType(MIMEGeneralType.Application, "x-msclip", Enumerable.New("clp"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsdownload = new MIMEType(MIMEGeneralType.Application, "x-msdownload", Enumerable.New("exe", "dll", "com", "bat", "msi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsmediaview = new MIMEType(MIMEGeneralType.Application, "x-msmediaview", Enumerable.New("mvb", "m13", "m14"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsmetafile = new MIMEType(MIMEGeneralType.Application, "x-msmetafile", Enumerable.New("wmf", "wmz", "emf", "emz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsmoney = new MIMEType(MIMEGeneralType.Application, "x-msmoney", Enumerable.New("mny"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMspublisher = new MIMEType(MIMEGeneralType.Application, "x-mspublisher", Enumerable.New("pub"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsschedule = new MIMEType(MIMEGeneralType.Application, "x-msschedule", Enumerable.New("scd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMsterminal = new MIMEType(MIMEGeneralType.Application, "x-msterminal", Enumerable.New("trm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXMswrite = new MIMEType(MIMEGeneralType.Application, "x-mswrite", Enumerable.New("wri"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXNetcdf = new MIMEType(MIMEGeneralType.Application, "x-netcdf", Enumerable.New("nc", "cdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXNzb = new MIMEType(MIMEGeneralType.Application, "x-nzb", Enumerable.New("nzb"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXPkcs12 = new MIMEType(MIMEGeneralType.Application, "x-pkcs12", Enumerable.New("p12", "pfx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXPkcs7Certificates = new MIMEType(MIMEGeneralType.Application, "x-pkcs7-certificates", Enumerable.New("p7b", "spc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXPkcs7Certreqresp = new MIMEType(MIMEGeneralType.Application, "x-pkcs7-certreqresp", Enumerable.New("p7r"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXRarCompressed = new MIMEType(MIMEGeneralType.Application, "x-rar-compressed", Enumerable.New("rar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXResearchInfoSystems = new MIMEType(MIMEGeneralType.Application, "x-research-info-systems", Enumerable.New("ris"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXSh = new MIMEType(MIMEGeneralType.Application, "x-sh", Enumerable.New("sh"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXShar = new MIMEType(MIMEGeneralType.Application, "x-shar", Enumerable.New("shar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXShockwaveFlash = new MIMEType(MIMEGeneralType.Application, "x-shockwave-flash", Enumerable.New("swf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXSilverlightApp = new MIMEType(MIMEGeneralType.Application, "x-silverlight-app", Enumerable.New("xap"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXSql = new MIMEType(MIMEGeneralType.Application, "x-sql", Enumerable.New("sql"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXStuffit = new MIMEType(MIMEGeneralType.Application, "x-stuffit", Enumerable.New("sit"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXStuffitx = new MIMEType(MIMEGeneralType.Application, "x-stuffitx", Enumerable.New("sitx"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXSubrip = new MIMEType(MIMEGeneralType.Application, "x-subrip", Enumerable.New("srt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXSv4cpio = new MIMEType(MIMEGeneralType.Application, "x-sv4cpio", Enumerable.New("sv4cpio"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXSv4crc = new MIMEType(MIMEGeneralType.Application, "x-sv4crc", Enumerable.New("sv4crc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXT3vmImage = new MIMEType(MIMEGeneralType.Application, "x-t3vm-image", Enumerable.New("t3"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTads = new MIMEType(MIMEGeneralType.Application, "x-tads", Enumerable.New("gam"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTar = new MIMEType(MIMEGeneralType.Application, "x-tar", Enumerable.New("tar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTcl = new MIMEType(MIMEGeneralType.Application, "x-tcl", Enumerable.New("tcl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTex = new MIMEType(MIMEGeneralType.Application, "x-tex", Enumerable.New("tex"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTexTfm = new MIMEType(MIMEGeneralType.Application, "x-tex-tfm", Enumerable.New("tfm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTexinfo = new MIMEType(MIMEGeneralType.Application, "x-texinfo", Enumerable.New("texinfo", "texi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXTgif = new MIMEType(MIMEGeneralType.Application, "x-tgif", Enumerable.New("obj"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXUstar = new MIMEType(MIMEGeneralType.Application, "x-ustar", Enumerable.New("ustar"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXWaisSource = new MIMEType(MIMEGeneralType.Application, "x-wais-source", Enumerable.New("src"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXX509CaCert = new MIMEType(MIMEGeneralType.Application, "x-x509-ca-cert", Enumerable.New("der", "crt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXXfig = new MIMEType(MIMEGeneralType.Application, "x-xfig", Enumerable.New("fig"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXXliffXml = new MIMEType(MIMEGeneralType.Application, "x-xliff+xml", Enumerable.New("xlf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXXpinstall = new MIMEType(MIMEGeneralType.Application, "x-xpinstall", Enumerable.New("xpi"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXXz = new MIMEType(MIMEGeneralType.Application, "x-xz", Enumerable.New("xz"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXZmachine = new MIMEType(MIMEGeneralType.Application, "x-zmachine", Enumerable.New("z1", "z2", "z3", "z4", "z5", "z6", "z7", "z8"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXamlXml = new MIMEType(MIMEGeneralType.Application, "xaml+xml", Enumerable.New("xaml"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXcapDiffXml = new MIMEType(MIMEGeneralType.Application, "xcap-diff+xml", Enumerable.New("xdf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXencXml = new MIMEType(MIMEGeneralType.Application, "xenc+xml", Enumerable.New("xenc"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXhtmlXml = new MIMEType(MIMEGeneralType.Application, "xhtml+xml", Enumerable.New("xhtml", "xht"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXml = new MIMEType(MIMEGeneralType.Application, "xml", Enumerable.New("xml", "xsl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXmlDtd = new MIMEType(MIMEGeneralType.Application, "xml-dtd", Enumerable.New("dtd"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXopXml = new MIMEType(MIMEGeneralType.Application, "xop+xml", Enumerable.New("xop"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXprocXml = new MIMEType(MIMEGeneralType.Application, "xproc+xml", Enumerable.New("xpl"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXsltXml = new MIMEType(MIMEGeneralType.Application, "xslt+xml", Enumerable.New("xslt"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXspfXml = new MIMEType(MIMEGeneralType.Application, "xspf+xml", Enumerable.New("xspf"), Enumerable.New<string>());
static public readonly MIMEType ApplicationXvXml = new MIMEType(MIMEGeneralType.Application, "xv+xml", Enumerable.New("mxml", "xhvml", "xvml", "xvm"), Enumerable.New<string>());
static public readonly MIMEType ApplicationYang = new MIMEType(MIMEGeneralType.Application, "yang", Enumerable.New("yang"), Enumerable.New<string>());
static public readonly MIMEType ApplicationYinXml = new MIMEType(MIMEGeneralType.Application, "yin+xml", Enumerable.New("yin"), Enumerable.New<string>());
static public readonly MIMEType ApplicationZip = new MIMEType(MIMEGeneralType.Application, "zip", Enumerable.New("zip"), Enumerable.New<string>());
static public readonly MIMEType AudioAdpcm = new MIMEType(MIMEGeneralType.Audio, "adpcm", Enumerable.New("adp"), Enumerable.New<string>());
static public readonly MIMEType AudioBasic = new MIMEType(MIMEGeneralType.Audio, "basic", Enumerable.New("au", "snd"), Enumerable.New<string>());
static public readonly MIMEType AudioMidi = new MIMEType(MIMEGeneralType.Audio, "midi", Enumerable.New("mid", "midi", "kar", "rmi"), Enumerable.New<string>());
static public readonly MIMEType AudioMp4 = new MIMEType(MIMEGeneralType.Audio, "mp4", Enumerable.New("mp4a"), Enumerable.New<string>());
static public readonly MIMEType AudioMpeg = new MIMEType(MIMEGeneralType.Audio, "mpeg", Enumerable.New("mpga", "mp2", "mp2a", "mp3", "m2a", "m3a"), Enumerable.New<string>());
static public readonly MIMEType AudioOgg = new MIMEType(MIMEGeneralType.Audio, "ogg", Enumerable.New("oga", "ogg", "spx"), Enumerable.New<string>());
static public readonly MIMEType AudioS3m = new MIMEType(MIMEGeneralType.Audio, "s3m", Enumerable.New("s3m"), Enumerable.New<string>());
static public readonly MIMEType AudioSilk = new MIMEType(MIMEGeneralType.Audio, "silk", Enumerable.New("sil"), Enumerable.New<string>());
static public readonly MIMEType AudioVndDeceAudio = new MIMEType(MIMEGeneralType.Audio, "vnd.dece.audio", Enumerable.New("uva", "uvva"), Enumerable.New<string>());
static public readonly MIMEType AudioVndDigitalWinds = new MIMEType(MIMEGeneralType.Audio, "vnd.digital-winds", Enumerable.New("eol"), Enumerable.New<string>());
static public readonly MIMEType AudioVndDra = new MIMEType(MIMEGeneralType.Audio, "vnd.dra", Enumerable.New("dra"), Enumerable.New<string>());
static public readonly MIMEType AudioVndDts = new MIMEType(MIMEGeneralType.Audio, "vnd.dts", Enumerable.New("dts"), Enumerable.New<string>());
static public readonly MIMEType AudioVndDtsHd = new MIMEType(MIMEGeneralType.Audio, "vnd.dts.hd", Enumerable.New("dtshd"), Enumerable.New<string>());
static public readonly MIMEType AudioVndLucentVoice = new MIMEType(MIMEGeneralType.Audio, "vnd.lucent.voice", Enumerable.New("lvp"), Enumerable.New<string>());
static public readonly MIMEType AudioVndMsPlayreadyMediaPya = new MIMEType(MIMEGeneralType.Audio, "vnd.ms-playready.media.pya", Enumerable.New("pya"), Enumerable.New<string>());
static public readonly MIMEType AudioVndNueraEcelp4800 = new MIMEType(MIMEGeneralType.Audio, "vnd.nuera.ecelp4800", Enumerable.New("ecelp4800"), Enumerable.New<string>());
static public readonly MIMEType AudioVndNueraEcelp7470 = new MIMEType(MIMEGeneralType.Audio, "vnd.nuera.ecelp7470", Enumerable.New("ecelp7470"), Enumerable.New<string>());
static public readonly MIMEType AudioVndNueraEcelp9600 = new MIMEType(MIMEGeneralType.Audio, "vnd.nuera.ecelp9600", Enumerable.New("ecelp9600"), Enumerable.New<string>());
static public readonly MIMEType AudioVndRip = new MIMEType(MIMEGeneralType.Audio, "vnd.rip", Enumerable.New("rip"), Enumerable.New<string>());
static public readonly MIMEType AudioWebm = new MIMEType(MIMEGeneralType.Audio, "webm", Enumerable.New("weba"), Enumerable.New<string>());
static public readonly MIMEType AudioXAac = new MIMEType(MIMEGeneralType.Audio, "x-aac", Enumerable.New("aac"), Enumerable.New<string>());
static public readonly MIMEType AudioXAiff = new MIMEType(MIMEGeneralType.Audio, "x-aiff", Enumerable.New("aif", "aiff", "aifc"), Enumerable.New<string>());
static public readonly MIMEType AudioXCaf = new MIMEType(MIMEGeneralType.Audio, "x-caf", Enumerable.New("caf"), Enumerable.New<string>());
static public readonly MIMEType AudioXFlac = new MIMEType(MIMEGeneralType.Audio, "x-flac", Enumerable.New("flac"), Enumerable.New<string>());
static public readonly MIMEType AudioXMatroska = new MIMEType(MIMEGeneralType.Audio, "x-matroska", Enumerable.New("mka"), Enumerable.New<string>());
static public readonly MIMEType AudioXMpegurl = new MIMEType(MIMEGeneralType.Audio, "x-mpegurl", Enumerable.New("m3u"), Enumerable.New<string>());
static public readonly MIMEType AudioXMsWax = new MIMEType(MIMEGeneralType.Audio, "x-ms-wax", Enumerable.New("wax"), Enumerable.New<string>());
static public readonly MIMEType AudioXMsWma = new MIMEType(MIMEGeneralType.Audio, "x-ms-wma", Enumerable.New("wma"), Enumerable.New<string>());
static public readonly MIMEType AudioXPnRealaudio = new MIMEType(MIMEGeneralType.Audio, "x-pn-realaudio", Enumerable.New("ram", "ra"), Enumerable.New<string>());
static public readonly MIMEType AudioXPnRealaudioPlugin = new MIMEType(MIMEGeneralType.Audio, "x-pn-realaudio-plugin", Enumerable.New("rmp"), Enumerable.New<string>());
static public readonly MIMEType AudioXWav = new MIMEType(MIMEGeneralType.Audio, "x-wav", Enumerable.New("wav"), Enumerable.New<string>());
static public readonly MIMEType AudioXm = new MIMEType(MIMEGeneralType.Audio, "xm", Enumerable.New("xm"), Enumerable.New<string>());
static public readonly MIMEType ChemicalXCdx = new MIMEType(MIMEGeneralType.Chemical, "x-cdx", Enumerable.New("cdx"), Enumerable.New<string>());
static public readonly MIMEType ChemicalXCif = new MIMEType(MIMEGeneralType.Chemical, "x-cif", Enumerable.New("cif"), Enumerable.New<string>());
static public readonly MIMEType ChemicalXCmdf = new MIMEType(MIMEGeneralType.Chemical, "x-cmdf", Enumerable.New("cmdf"), Enumerable.New<string>());
static public readonly MIMEType ChemicalXCml = new MIMEType(MIMEGeneralType.Chemical, "x-cml", Enumerable.New("cml"), Enumerable.New<string>());
static public readonly MIMEType ChemicalXCsml = new MIMEType(MIMEGeneralType.Chemical, "x-csml", Enumerable.New("csml"), Enumerable.New<string>());
static public readonly MIMEType ChemicalXXyz = new MIMEType(MIMEGeneralType.Chemical, "x-xyz", Enumerable.New("xyz"), Enumerable.New<string>());
static public readonly MIMEType ImageBmp = new MIMEType(MIMEGeneralType.Image, "bmp", Enumerable.New("bmp"), Enumerable.New<string>());
static public readonly MIMEType ImageCgm = new MIMEType(MIMEGeneralType.Image, "cgm", Enumerable.New("cgm"), Enumerable.New<string>());
static public readonly MIMEType ImageG3fax = new MIMEType(MIMEGeneralType.Image, "g3fax", Enumerable.New("g3"), Enumerable.New<string>());
static public readonly MIMEType ImageGif = new MIMEType(MIMEGeneralType.Image, "gif", Enumerable.New("gif"), Enumerable.New<string>());
static public readonly MIMEType ImageIef = new MIMEType(MIMEGeneralType.Image, "ief", Enumerable.New("ief"), Enumerable.New<string>());
static public readonly MIMEType ImageJpeg = new MIMEType(MIMEGeneralType.Image, "jpeg", Enumerable.New("jpeg", "jpg", "jpe"), Enumerable.New<string>("image/jpg"));
static public readonly MIMEType ImageKtx = new MIMEType(MIMEGeneralType.Image, "ktx", Enumerable.New("ktx"), Enumerable.New<string>());
static public readonly MIMEType ImagePng = new MIMEType(MIMEGeneralType.Image, "png", Enumerable.New("png"), Enumerable.New<string>());
static public readonly MIMEType ImagePrsBtif = new MIMEType(MIMEGeneralType.Image, "prs.btif", Enumerable.New("btif"), Enumerable.New<string>());
static public readonly MIMEType ImageSgi = new MIMEType(MIMEGeneralType.Image, "sgi", Enumerable.New("sgi"), Enumerable.New<string>());
static public readonly MIMEType ImageSvgXml = new MIMEType(MIMEGeneralType.Image, "svg+xml", Enumerable.New("svg", "svgz"), Enumerable.New<string>());
static public readonly MIMEType ImageTiff = new MIMEType(MIMEGeneralType.Image, "tiff", Enumerable.New("tiff", "tif"), Enumerable.New<string>());
static public readonly MIMEType ImageVndAdobePhotoshop = new MIMEType(MIMEGeneralType.Image, "vnd.adobe.photoshop", Enumerable.New("psd"), Enumerable.New<string>());
static public readonly MIMEType ImageVndDeceGraphic = new MIMEType(MIMEGeneralType.Image, "vnd.dece.graphic", Enumerable.New("uvi", "uvvi", "uvg", "uvvg"), Enumerable.New<string>());
static public readonly MIMEType ImageVndDvbSubtitle = new MIMEType(MIMEGeneralType.Image, "vnd.dvb.subtitle", Enumerable.New("sub"), Enumerable.New<string>());
static public readonly MIMEType ImageVndDjvu = new MIMEType(MIMEGeneralType.Image, "vnd.djvu", Enumerable.New("djvu", "djv"), Enumerable.New<string>());
static public readonly MIMEType ImageVndDwg = new MIMEType(MIMEGeneralType.Image, "vnd.dwg", Enumerable.New("dwg"), Enumerable.New<string>());
static public readonly MIMEType ImageVndDxf = new MIMEType(MIMEGeneralType.Image, "vnd.dxf", Enumerable.New("dxf"), Enumerable.New<string>());
static public readonly MIMEType ImageVndFastbidsheet = new MIMEType(MIMEGeneralType.Image, "vnd.fastbidsheet", Enumerable.New("fbs"), Enumerable.New<string>());
static public readonly MIMEType ImageVndFpx = new MIMEType(MIMEGeneralType.Image, "vnd.fpx", Enumerable.New("fpx"), Enumerable.New<string>());
static public readonly MIMEType ImageVndFst = new MIMEType(MIMEGeneralType.Image, "vnd.fst", Enumerable.New("fst"), Enumerable.New<string>());
static public readonly MIMEType ImageVndFujixeroxEdmicsMmr = new MIMEType(MIMEGeneralType.Image, "vnd.fujixerox.edmics-mmr", Enumerable.New("mmr"), Enumerable.New<string>());
static public readonly MIMEType ImageVndFujixeroxEdmicsRlc = new MIMEType(MIMEGeneralType.Image, "vnd.fujixerox.edmics-rlc", Enumerable.New("rlc"), Enumerable.New<string>());
static public readonly MIMEType ImageVndMsModi = new MIMEType(MIMEGeneralType.Image, "vnd.ms-modi", Enumerable.New("mdi"), Enumerable.New<string>());
static public readonly MIMEType ImageVndMsPhoto = new MIMEType(MIMEGeneralType.Image, "vnd.ms-photo", Enumerable.New("wdp"), Enumerable.New<string>());
static public readonly MIMEType ImageVndNetFpx = new MIMEType(MIMEGeneralType.Image, "vnd.net-fpx", Enumerable.New("npx"), Enumerable.New<string>());
static public readonly MIMEType ImageVndWapWbmp = new MIMEType(MIMEGeneralType.Image, "vnd.wap.wbmp", Enumerable.New("wbmp"), Enumerable.New<string>());
static public readonly MIMEType ImageVndXiff = new MIMEType(MIMEGeneralType.Image, "vnd.xiff", Enumerable.New("xif"), Enumerable.New<string>());
static public readonly MIMEType ImageWebp = new MIMEType(MIMEGeneralType.Image, "webp", Enumerable.New("webp"), Enumerable.New<string>());
static public readonly MIMEType ImageX3ds = new MIMEType(MIMEGeneralType.Image, "x-3ds", Enumerable.New("3ds"), Enumerable.New<string>());
static public readonly MIMEType ImageXCmuRaster = new MIMEType(MIMEGeneralType.Image, "x-cmu-raster", Enumerable.New("ras"), Enumerable.New<string>());
static public readonly MIMEType ImageXCmx = new MIMEType(MIMEGeneralType.Image, "x-cmx", Enumerable.New("cmx"), Enumerable.New<string>());
static public readonly MIMEType ImageXFreehand = new MIMEType(MIMEGeneralType.Image, "x-freehand", Enumerable.New("fh", "fhc", "fh4", "fh5", "fh7"), Enumerable.New<string>());
static public readonly MIMEType ImageXIcon = new MIMEType(MIMEGeneralType.Image, "x-icon", Enumerable.New("ico"), Enumerable.New<string>());
static public readonly MIMEType ImageXMrsidImage = new MIMEType(MIMEGeneralType.Image, "x-mrsid-image", Enumerable.New("sid"), Enumerable.New<string>());
static public readonly MIMEType ImageXPcx = new MIMEType(MIMEGeneralType.Image, "x-pcx", Enumerable.New("pcx"), Enumerable.New<string>());
static public readonly MIMEType ImageXPict = new MIMEType(MIMEGeneralType.Image, "x-pict", Enumerable.New("pic", "pct"), Enumerable.New<string>());
static public readonly MIMEType ImageXPortableAnymap = new MIMEType(MIMEGeneralType.Image, "x-portable-anymap", Enumerable.New("pnm"), Enumerable.New<string>());
static public readonly MIMEType ImageXPortableBitmap = new MIMEType(MIMEGeneralType.Image, "x-portable-bitmap", Enumerable.New("pbm"), Enumerable.New<string>());
static public readonly MIMEType ImageXPortableGraymap = new MIMEType(MIMEGeneralType.Image, "x-portable-graymap", Enumerable.New("pgm"), Enumerable.New<string>());
static public readonly MIMEType ImageXPortablePixmap = new MIMEType(MIMEGeneralType.Image, "x-portable-pixmap", Enumerable.New("ppm"), Enumerable.New<string>());
static public readonly MIMEType ImageXRgb = new MIMEType(MIMEGeneralType.Image, "x-rgb", Enumerable.New("rgb"), Enumerable.New<string>());
static public readonly MIMEType ImageXTga = new MIMEType(MIMEGeneralType.Image, "x-tga", Enumerable.New("tga"), Enumerable.New<string>());
static public readonly MIMEType ImageXXbitmap = new MIMEType(MIMEGeneralType.Image, "x-xbitmap", Enumerable.New("xbm"), Enumerable.New<string>());
static public readonly MIMEType ImageXXpixmap = new MIMEType(MIMEGeneralType.Image, "x-xpixmap", Enumerable.New("xpm"), Enumerable.New<string>());
static public readonly MIMEType ImageXXwindowdump = new MIMEType(MIMEGeneralType.Image, "x-xwindowdump", Enumerable.New("xwd"), Enumerable.New<string>());
static public readonly MIMEType MessageRfc822 = new MIMEType(MIMEGeneralType.Message, "rfc822", Enumerable.New("eml", "mime"), Enumerable.New<string>());
static public readonly MIMEType ModelIges = new MIMEType(MIMEGeneralType.Model, "iges", Enumerable.New("igs", "iges"), Enumerable.New<string>());
static public readonly MIMEType ModelMesh = new MIMEType(MIMEGeneralType.Model, "mesh", Enumerable.New("msh", "mesh", "silo"), Enumerable.New<string>());
static public readonly MIMEType ModelVndColladaXml = new MIMEType(MIMEGeneralType.Model, "vnd.collada+xml", Enumerable.New("dae"), Enumerable.New<string>());
static public readonly MIMEType ModelVndDwf = new MIMEType(MIMEGeneralType.Model, "vnd.dwf", Enumerable.New("dwf"), Enumerable.New<string>());
static public readonly MIMEType ModelVndGdl = new MIMEType(MIMEGeneralType.Model, "vnd.gdl", Enumerable.New("gdl"), Enumerable.New<string>());
static public readonly MIMEType ModelVndGtw = new MIMEType(MIMEGeneralType.Model, "vnd.gtw", Enumerable.New("gtw"), Enumerable.New<string>());
static public readonly MIMEType ModelVndMts = new MIMEType(MIMEGeneralType.Model, "vnd.mts", Enumerable.New("mts"), Enumerable.New<string>());
static public readonly MIMEType ModelVndVtu = new MIMEType(MIMEGeneralType.Model, "vnd.vtu", Enumerable.New("vtu"), Enumerable.New<string>());
static public readonly MIMEType ModelVrml = new MIMEType(MIMEGeneralType.Model, "vrml", Enumerable.New("wrl", "vrml"), Enumerable.New<string>());
static public readonly MIMEType ModelX3dBinary = new MIMEType(MIMEGeneralType.Model, "x3d+binary", Enumerable.New("x3db", "x3dbz"), Enumerable.New<string>());
static public readonly MIMEType ModelX3dVrml = new MIMEType(MIMEGeneralType.Model, "x3d+vrml", Enumerable.New("x3dv", "x3dvz"), Enumerable.New<string>());
static public readonly MIMEType ModelX3dXml = new MIMEType(MIMEGeneralType.Model, "x3d+xml", Enumerable.New("x3d", "x3dz"), Enumerable.New<string>());
static public readonly MIMEType TextCacheManifest = new MIMEType(MIMEGeneralType.Text, "cache-manifest", Enumerable.New("appcache"), Enumerable.New<string>());
static public readonly MIMEType TextCalendar = new MIMEType(MIMEGeneralType.Text, "calendar", Enumerable.New("ics", "ifb"), Enumerable.New<string>());
static public readonly MIMEType TextCss = new MIMEType(MIMEGeneralType.Text, "css", Enumerable.New("css"), Enumerable.New<string>());
static public readonly MIMEType TextCsv = new MIMEType(MIMEGeneralType.Text, "csv", Enumerable.New("csv"), Enumerable.New<string>());
static public readonly MIMEType TextHtml = new MIMEType(MIMEGeneralType.Text, "html", Enumerable.New("html", "htm"), Enumerable.New<string>());
static public readonly MIMEType TextN3 = new MIMEType(MIMEGeneralType.Text, "n3", Enumerable.New("n3"), Enumerable.New<string>());
static public readonly MIMEType TextPlain = new MIMEType(MIMEGeneralType.Text, "plain", Enumerable.New("txt", "text", "conf", "def", "list", "log", "in"), Enumerable.New<string>());
static public readonly MIMEType TextPrsLinesTag = new MIMEType(MIMEGeneralType.Text, "prs.lines.tag", Enumerable.New("dsc"), Enumerable.New<string>());
static public readonly MIMEType TextRichtext = new MIMEType(MIMEGeneralType.Text, "richtext", Enumerable.New("rtx"), Enumerable.New<string>());
static public readonly MIMEType TextSgml = new MIMEType(MIMEGeneralType.Text, "sgml", Enumerable.New("sgml", "sgm"), Enumerable.New<string>());
static public readonly MIMEType TextTabSeparatedValues = new MIMEType(MIMEGeneralType.Text, "tab-separated-values", Enumerable.New("tsv"), Enumerable.New<string>());
static public readonly MIMEType TextTroff = new MIMEType(MIMEGeneralType.Text, "troff", Enumerable.New("t", "tr", "roff", "man", "me", "ms"), Enumerable.New<string>());
static public readonly MIMEType TextTurtle = new MIMEType(MIMEGeneralType.Text, "turtle", Enumerable.New("ttl"), Enumerable.New<string>());
static public readonly MIMEType TextUriList = new MIMEType(MIMEGeneralType.Text, "uri-list", Enumerable.New("uri", "uris", "urls"), Enumerable.New<string>());
static public readonly MIMEType TextVcard = new MIMEType(MIMEGeneralType.Text, "vcard", Enumerable.New("vcard"), Enumerable.New<string>());
static public readonly MIMEType TextVndCurl = new MIMEType(MIMEGeneralType.Text, "vnd.curl", Enumerable.New("curl"), Enumerable.New<string>());
static public readonly MIMEType TextVndCurlDcurl = new MIMEType(MIMEGeneralType.Text, "vnd.curl.dcurl", Enumerable.New("dcurl"), Enumerable.New<string>());
static public readonly MIMEType TextVndCurlScurl = new MIMEType(MIMEGeneralType.Text, "vnd.curl.scurl", Enumerable.New("scurl"), Enumerable.New<string>());
static public readonly MIMEType TextVndCurlMcurl = new MIMEType(MIMEGeneralType.Text, "vnd.curl.mcurl", Enumerable.New("mcurl"), Enumerable.New<string>());
static public readonly MIMEType TextVndDvbSubtitle = new MIMEType(MIMEGeneralType.Text, "vnd.dvb.subtitle", Enumerable.New("sub"), Enumerable.New<string>());
static public readonly MIMEType TextVndFly = new MIMEType(MIMEGeneralType.Text, "vnd.fly", Enumerable.New("fly"), Enumerable.New<string>());
static public readonly MIMEType TextVndFmiFlexstor = new MIMEType(MIMEGeneralType.Text, "vnd.fmi.flexstor", Enumerable.New("flx"), Enumerable.New<string>());
static public readonly MIMEType TextVndGraphviz = new MIMEType(MIMEGeneralType.Text, "vnd.graphviz", Enumerable.New("gv"), Enumerable.New<string>());
static public readonly MIMEType TextVndIn3d3dml = new MIMEType(MIMEGeneralType.Text, "vnd.in3d.3dml", Enumerable.New("3dml"), Enumerable.New<string>());
static public readonly MIMEType TextVndIn3dSpot = new MIMEType(MIMEGeneralType.Text, "vnd.in3d.spot", Enumerable.New("spot"), Enumerable.New<string>());
static public readonly MIMEType TextVndSunJ2meAppDescriptor = new MIMEType(MIMEGeneralType.Text, "vnd.sun.j2me.app-descriptor", Enumerable.New("jad"), Enumerable.New<string>());
static public readonly MIMEType TextVndWapWml = new MIMEType(MIMEGeneralType.Text, "vnd.wap.wml", Enumerable.New("wml"), Enumerable.New<string>());
static public readonly MIMEType TextVndWapWmlscript = new MIMEType(MIMEGeneralType.Text, "vnd.wap.wmlscript", Enumerable.New("wmls"), Enumerable.New<string>());
static public readonly MIMEType TextXAsm = new MIMEType(MIMEGeneralType.Text, "x-asm", Enumerable.New("s", "asm"), Enumerable.New<string>());
static public readonly MIMEType TextXC = new MIMEType(MIMEGeneralType.Text, "x-c", Enumerable.New("c", "cc", "cxx", "cpp", "h", "hh", "dic"), Enumerable.New<string>());
static public readonly MIMEType TextXFortran = new MIMEType(MIMEGeneralType.Text, "x-fortran", Enumerable.New("f", "for", "f77", "f90"), Enumerable.New<string>());
static public readonly MIMEType TextXJavaSource = new MIMEType(MIMEGeneralType.Text, "x-java-source", Enumerable.New("java"), Enumerable.New<string>());
static public readonly MIMEType TextXOpml = new MIMEType(MIMEGeneralType.Text, "x-opml", Enumerable.New("opml"), Enumerable.New<string>());
static public readonly MIMEType TextXPascal = new MIMEType(MIMEGeneralType.Text, "x-pascal", Enumerable.New("p", "pas"), Enumerable.New<string>());
static public readonly MIMEType TextXNfo = new MIMEType(MIMEGeneralType.Text, "x-nfo", Enumerable.New("nfo"), Enumerable.New<string>());
static public readonly MIMEType TextXSetext = new MIMEType(MIMEGeneralType.Text, "x-setext", Enumerable.New("etx"), Enumerable.New<string>());
static public readonly MIMEType TextXSfv = new MIMEType(MIMEGeneralType.Text, "x-sfv", Enumerable.New("sfv"), Enumerable.New<string>());
static public readonly MIMEType TextXUuencode = new MIMEType(MIMEGeneralType.Text, "x-uuencode", Enumerable.New("uu"), Enumerable.New<string>());
static public readonly MIMEType TextXVcalendar = new MIMEType(MIMEGeneralType.Text, "x-vcalendar", Enumerable.New("vcs"), Enumerable.New<string>());
static public readonly MIMEType TextXVcard = new MIMEType(MIMEGeneralType.Text, "x-vcard", Enumerable.New("vcf"), Enumerable.New<string>());
static public readonly MIMEType Video3gpp = new MIMEType(MIMEGeneralType.Video, "3gpp", Enumerable.New("3gp"), Enumerable.New<string>());
static public readonly MIMEType Video3gpp2 = new MIMEType(MIMEGeneralType.Video, "3gpp2", Enumerable.New("3g2"), Enumerable.New<string>());
static public readonly MIMEType VideoH261 = new MIMEType(MIMEGeneralType.Video, "h261", Enumerable.New("h261"), Enumerable.New<string>());
static public readonly MIMEType VideoH263 = new MIMEType(MIMEGeneralType.Video, "h263", Enumerable.New("h263"), Enumerable.New<string>());
static public readonly MIMEType VideoH264 = new MIMEType(MIMEGeneralType.Video, "h264", Enumerable.New("h264"), Enumerable.New<string>());
static public readonly MIMEType VideoJpeg = new MIMEType(MIMEGeneralType.Video, "jpeg", Enumerable.New("jpgv"), Enumerable.New<string>());
static public readonly MIMEType VideoJpm = new MIMEType(MIMEGeneralType.Video, "jpm", Enumerable.New("jpm", "jpgm"), Enumerable.New<string>());
static public readonly MIMEType VideoMj2 = new MIMEType(MIMEGeneralType.Video, "mj2", Enumerable.New("mj2", "mjp2"), Enumerable.New<string>());
static public readonly MIMEType VideoMp4 = new MIMEType(MIMEGeneralType.Video, "mp4", Enumerable.New("mp4", "mp4v", "mpg4"), Enumerable.New<string>());
static public readonly MIMEType VideoMpeg = new MIMEType(MIMEGeneralType.Video, "mpeg", Enumerable.New("mpeg", "mpg", "mpe", "m1v", "m2v"), Enumerable.New<string>());
static public readonly MIMEType VideoOgg = new MIMEType(MIMEGeneralType.Video, "ogg", Enumerable.New("ogv"), Enumerable.New<string>());
static public readonly MIMEType VideoQuicktime = new MIMEType(MIMEGeneralType.Video, "quicktime", Enumerable.New("qt", "mov"), Enumerable.New<string>());
static public readonly MIMEType VideoVndDeceHd = new MIMEType(MIMEGeneralType.Video, "vnd.dece.hd", Enumerable.New("uvh", "uvvh"), Enumerable.New<string>());
static public readonly MIMEType VideoVndDeceMobile = new MIMEType(MIMEGeneralType.Video, "vnd.dece.mobile", Enumerable.New("uvm", "uvvm"), Enumerable.New<string>());
static public readonly MIMEType VideoVndDecePd = new MIMEType(MIMEGeneralType.Video, "vnd.dece.pd", Enumerable.New("uvp", "uvvp"), Enumerable.New<string>());
static public readonly MIMEType VideoVndDeceSd = new MIMEType(MIMEGeneralType.Video, "vnd.dece.sd", Enumerable.New("uvs", "uvvs"), Enumerable.New<string>());
static public readonly MIMEType VideoVndDeceVideo = new MIMEType(MIMEGeneralType.Video, "vnd.dece.video", Enumerable.New("uvv", "uvvv"), Enumerable.New<string>());
static public readonly MIMEType VideoVndDvbFile = new MIMEType(MIMEGeneralType.Video, "vnd.dvb.file", Enumerable.New("dvb"), Enumerable.New<string>());
static public readonly MIMEType VideoVndFvt = new MIMEType(MIMEGeneralType.Video, "vnd.fvt", Enumerable.New("fvt"), Enumerable.New<string>());
static public readonly MIMEType VideoVndMpegurl = new MIMEType(MIMEGeneralType.Video, "vnd.mpegurl", Enumerable.New("mxu", "m4u"), Enumerable.New<string>());
static public readonly MIMEType VideoVndMsPlayreadyMediaPyv = new MIMEType(MIMEGeneralType.Video, "vnd.ms-playready.media.pyv", Enumerable.New("pyv"), Enumerable.New<string>());
static public readonly MIMEType VideoVndUvvuMp4 = new MIMEType(MIMEGeneralType.Video, "vnd.uvvu.mp4", Enumerable.New("uvu", "uvvu"), Enumerable.New<string>());
static public readonly MIMEType VideoVndVivo = new MIMEType(MIMEGeneralType.Video, "vnd.vivo", Enumerable.New("viv"), Enumerable.New<string>());
static public readonly MIMEType VideoWebm = new MIMEType(MIMEGeneralType.Video, "webm", Enumerable.New("webm"), Enumerable.New<string>());
static public readonly MIMEType VideoXF4v = new MIMEType(MIMEGeneralType.Video, "x-f4v", Enumerable.New("f4v"), Enumerable.New<string>());
static public readonly MIMEType VideoXFli = new MIMEType(MIMEGeneralType.Video, "x-fli", Enumerable.New("fli"), Enumerable.New<string>());
static public readonly MIMEType VideoXFlv = new MIMEType(MIMEGeneralType.Video, "x-flv", Enumerable.New("flv"), Enumerable.New<string>());
static public readonly MIMEType VideoXM4v = new MIMEType(MIMEGeneralType.Video, "x-m4v", Enumerable.New("m4v"), Enumerable.New<string>());
static public readonly MIMEType VideoXMatroska = new MIMEType(MIMEGeneralType.Video, "x-matroska", Enumerable.New("mkv", "mk3d", "mks"), Enumerable.New<string>());
static public readonly MIMEType VideoXMng = new MIMEType(MIMEGeneralType.Video, "x-mng", Enumerable.New("mng"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsAsf = new MIMEType(MIMEGeneralType.Video, "x-ms-asf", Enumerable.New("asf", "asx"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsVob = new MIMEType(MIMEGeneralType.Video, "x-ms-vob", Enumerable.New("vob"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsWm = new MIMEType(MIMEGeneralType.Video, "x-ms-wm", Enumerable.New("wm"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsWmv = new MIMEType(MIMEGeneralType.Video, "x-ms-wmv", Enumerable.New("wmv"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsWmx = new MIMEType(MIMEGeneralType.Video, "x-ms-wmx", Enumerable.New("wmx"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsWvx = new MIMEType(MIMEGeneralType.Video, "x-ms-wvx", Enumerable.New("wvx"), Enumerable.New<string>());
static public readonly MIMEType VideoXMsvideo = new MIMEType(MIMEGeneralType.Video, "x-msvideo", Enumerable.New("avi"), Enumerable.New<string>());
static public readonly MIMEType VideoXSgiMovie = new MIMEType(MIMEGeneralType.Video, "x-sgi-movie", Enumerable.New("movie"), Enumerable.New<string>());
static public readonly MIMEType VideoXSmv = new MIMEType(MIMEGeneralType.Video, "x-smv", Enumerable.New("smv"), Enumerable.New<string>());
static public readonly MIMEType XConferenceXCooltalk = new MIMEType(MIMEGeneralType.XConference, "x-cooltalk", Enumerable.New("ice"), Enumerable.New<string>());
        
        static public explicit operator MIMEType(string input)
        {
            return ParseFromTypeStrict(input);
        }
        
        static private Dictionary<string, MIMEType> TYPE_LOOKUP_TABLE = Enumerable.New(
            new KeyValuePair<string, MIMEType>("application/andrew-inset", ApplicationAndrewInset),
new KeyValuePair<string, MIMEType>("application/applixware", ApplicationApplixware),
new KeyValuePair<string, MIMEType>("application/atom+xml", ApplicationAtomXml),
new KeyValuePair<string, MIMEType>("application/atomcat+xml", ApplicationAtomcatXml),
new KeyValuePair<string, MIMEType>("application/atomsvc+xml", ApplicationAtomsvcXml),
new KeyValuePair<string, MIMEType>("application/ccxml+xml", ApplicationCcxmlXml),
new KeyValuePair<string, MIMEType>("application/cdmi-capability", ApplicationCdmiCapability),
new KeyValuePair<string, MIMEType>("application/cdmi-container", ApplicationCdmiContainer),
new KeyValuePair<string, MIMEType>("application/cdmi-domain", ApplicationCdmiDomain),
new KeyValuePair<string, MIMEType>("application/cdmi-object", ApplicationCdmiObject),
new KeyValuePair<string, MIMEType>("application/cdmi-queue", ApplicationCdmiQueue),
new KeyValuePair<string, MIMEType>("application/cu-seeme", ApplicationCuSeeme),
new KeyValuePair<string, MIMEType>("application/davmount+xml", ApplicationDavmountXml),
new KeyValuePair<string, MIMEType>("application/docbook+xml", ApplicationDocbookXml),
new KeyValuePair<string, MIMEType>("application/dssc+der", ApplicationDsscDer),
new KeyValuePair<string, MIMEType>("application/dssc+xml", ApplicationDsscXml),
new KeyValuePair<string, MIMEType>("application/ecmascript", ApplicationEcmascript),
new KeyValuePair<string, MIMEType>("application/emma+xml", ApplicationEmmaXml),
new KeyValuePair<string, MIMEType>("application/epub+zip", ApplicationEpubZip),
new KeyValuePair<string, MIMEType>("application/exi", ApplicationExi),
new KeyValuePair<string, MIMEType>("application/font-tdpfr", ApplicationFontTdpfr),
new KeyValuePair<string, MIMEType>("application/gml+xml", ApplicationGmlXml),
new KeyValuePair<string, MIMEType>("application/gpx+xml", ApplicationGpxXml),
new KeyValuePair<string, MIMEType>("application/gxf", ApplicationGxf),
new KeyValuePair<string, MIMEType>("application/hyperstudio", ApplicationHyperstudio),
new KeyValuePair<string, MIMEType>("application/inkml+xml", ApplicationInkmlXml),
new KeyValuePair<string, MIMEType>("application/ipfix", ApplicationIpfix),
new KeyValuePair<string, MIMEType>("application/java-archive", ApplicationJavaArchive),
new KeyValuePair<string, MIMEType>("application/java-serialized-object", ApplicationJavaSerializedObject),
new KeyValuePair<string, MIMEType>("application/java-vm", ApplicationJavaVm),
new KeyValuePair<string, MIMEType>("application/javascript", ApplicationJavascript),
new KeyValuePair<string, MIMEType>("application/json", ApplicationJson),
new KeyValuePair<string, MIMEType>("application/jsonml+json", ApplicationJsonmlJson),
new KeyValuePair<string, MIMEType>("application/lost+xml", ApplicationLostXml),
new KeyValuePair<string, MIMEType>("application/mac-binhex40", ApplicationMacBinhex40),
new KeyValuePair<string, MIMEType>("application/mac-compactpro", ApplicationMacCompactpro),
new KeyValuePair<string, MIMEType>("application/mads+xml", ApplicationMadsXml),
new KeyValuePair<string, MIMEType>("application/marc", ApplicationMarc),
new KeyValuePair<string, MIMEType>("application/marcxml+xml", ApplicationMarcxmlXml),
new KeyValuePair<string, MIMEType>("application/mathematica", ApplicationMathematica),
new KeyValuePair<string, MIMEType>("application/mathml+xml", ApplicationMathmlXml),
new KeyValuePair<string, MIMEType>("application/mbox", ApplicationMbox),
new KeyValuePair<string, MIMEType>("application/mediaservercontrol+xml", ApplicationMediaservercontrolXml),
new KeyValuePair<string, MIMEType>("application/metalink+xml", ApplicationMetalinkXml),
new KeyValuePair<string, MIMEType>("application/metalink4+xml", ApplicationMetalink4Xml),
new KeyValuePair<string, MIMEType>("application/mets+xml", ApplicationMetsXml),
new KeyValuePair<string, MIMEType>("application/mods+xml", ApplicationModsXml),
new KeyValuePair<string, MIMEType>("application/mp21", ApplicationMp21),
new KeyValuePair<string, MIMEType>("application/mp4", ApplicationMp4),
new KeyValuePair<string, MIMEType>("application/msword", ApplicationMsword),
new KeyValuePair<string, MIMEType>("application/mxf", ApplicationMxf),
new KeyValuePair<string, MIMEType>("application/octet-stream", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("application/oda", ApplicationOda),
new KeyValuePair<string, MIMEType>("application/oebps-package+xml", ApplicationOebpsPackageXml),
new KeyValuePair<string, MIMEType>("application/ogg", ApplicationOgg),
new KeyValuePair<string, MIMEType>("application/omdoc+xml", ApplicationOmdocXml),
new KeyValuePair<string, MIMEType>("application/onenote", ApplicationOnenote),
new KeyValuePair<string, MIMEType>("application/oxps", ApplicationOxps),
new KeyValuePair<string, MIMEType>("application/patch-ops-error+xml", ApplicationPatchOpsErrorXml),
new KeyValuePair<string, MIMEType>("application/pdf", ApplicationPdf),
new KeyValuePair<string, MIMEType>("application/pgp-encrypted", ApplicationPgpEncrypted),
new KeyValuePair<string, MIMEType>("application/pgp-signature", ApplicationPgpSignature),
new KeyValuePair<string, MIMEType>("application/pics-rules", ApplicationPicsRules),
new KeyValuePair<string, MIMEType>("application/pkcs10", ApplicationPkcs10),
new KeyValuePair<string, MIMEType>("application/pkcs7-mime", ApplicationPkcs7Mime),
new KeyValuePair<string, MIMEType>("application/pkcs7-signature", ApplicationPkcs7Signature),
new KeyValuePair<string, MIMEType>("application/pkcs8", ApplicationPkcs8),
new KeyValuePair<string, MIMEType>("application/pkix-attr-cert", ApplicationPkixAttrCert),
new KeyValuePair<string, MIMEType>("application/pkix-cert", ApplicationPkixCert),
new KeyValuePair<string, MIMEType>("application/pkix-crl", ApplicationPkixCrl),
new KeyValuePair<string, MIMEType>("application/pkix-pkipath", ApplicationPkixPkipath),
new KeyValuePair<string, MIMEType>("application/pkixcmp", ApplicationPkixcmp),
new KeyValuePair<string, MIMEType>("application/pls+xml", ApplicationPlsXml),
new KeyValuePair<string, MIMEType>("application/postscript", ApplicationPostscript),
new KeyValuePair<string, MIMEType>("application/prs.cww", ApplicationPrsCww),
new KeyValuePair<string, MIMEType>("application/pskc+xml", ApplicationPskcXml),
new KeyValuePair<string, MIMEType>("application/rdf+xml", ApplicationRdfXml),
new KeyValuePair<string, MIMEType>("application/reginfo+xml", ApplicationReginfoXml),
new KeyValuePair<string, MIMEType>("application/relax-ng-compact-syntax", ApplicationRelaxNgCompactSyntax),
new KeyValuePair<string, MIMEType>("application/resource-lists+xml", ApplicationResourceListsXml),
new KeyValuePair<string, MIMEType>("application/resource-lists-diff+xml", ApplicationResourceListsDiffXml),
new KeyValuePair<string, MIMEType>("application/rls-services+xml", ApplicationRlsServicesXml),
new KeyValuePair<string, MIMEType>("application/rpki-ghostbusters", ApplicationRpkiGhostbusters),
new KeyValuePair<string, MIMEType>("application/rpki-manifest", ApplicationRpkiManifest),
new KeyValuePair<string, MIMEType>("application/rpki-roa", ApplicationRpkiRoa),
new KeyValuePair<string, MIMEType>("application/rsd+xml", ApplicationRsdXml),
new KeyValuePair<string, MIMEType>("application/rss+xml", ApplicationRssXml),
new KeyValuePair<string, MIMEType>("application/rtf", ApplicationRtf),
new KeyValuePair<string, MIMEType>("application/sbml+xml", ApplicationSbmlXml),
new KeyValuePair<string, MIMEType>("application/scvp-cv-request", ApplicationScvpCvRequest),
new KeyValuePair<string, MIMEType>("application/scvp-cv-response", ApplicationScvpCvResponse),
new KeyValuePair<string, MIMEType>("application/scvp-vp-request", ApplicationScvpVpRequest),
new KeyValuePair<string, MIMEType>("application/scvp-vp-response", ApplicationScvpVpResponse),
new KeyValuePair<string, MIMEType>("application/sdp", ApplicationSdp),
new KeyValuePair<string, MIMEType>("application/set-payment-initiation", ApplicationSetPaymentInitiation),
new KeyValuePair<string, MIMEType>("application/set-registration-initiation", ApplicationSetRegistrationInitiation),
new KeyValuePair<string, MIMEType>("application/shf+xml", ApplicationShfXml),
new KeyValuePair<string, MIMEType>("application/smil+xml", ApplicationSmilXml),
new KeyValuePair<string, MIMEType>("application/sparql-query", ApplicationSparqlQuery),
new KeyValuePair<string, MIMEType>("application/sparql-results+xml", ApplicationSparqlResultsXml),
new KeyValuePair<string, MIMEType>("application/srgs", ApplicationSrgs),
new KeyValuePair<string, MIMEType>("application/srgs+xml", ApplicationSrgsXml),
new KeyValuePair<string, MIMEType>("application/sru+xml", ApplicationSruXml),
new KeyValuePair<string, MIMEType>("application/ssdl+xml", ApplicationSsdlXml),
new KeyValuePair<string, MIMEType>("application/ssml+xml", ApplicationSsmlXml),
new KeyValuePair<string, MIMEType>("application/tei+xml", ApplicationTeiXml),
new KeyValuePair<string, MIMEType>("application/thraud+xml", ApplicationThraudXml),
new KeyValuePair<string, MIMEType>("application/timestamped-data", ApplicationTimestampedData),
new KeyValuePair<string, MIMEType>("application/vnd.3gpp.pic-bw-large", ApplicationVnd3gppPicBwLarge),
new KeyValuePair<string, MIMEType>("application/vnd.3gpp.pic-bw-small", ApplicationVnd3gppPicBwSmall),
new KeyValuePair<string, MIMEType>("application/vnd.3gpp.pic-bw-var", ApplicationVnd3gppPicBwVar),
new KeyValuePair<string, MIMEType>("application/vnd.3gpp2.tcap", ApplicationVnd3gpp2Tcap),
new KeyValuePair<string, MIMEType>("application/vnd.3m.post-it-notes", ApplicationVnd3mPostItNotes),
new KeyValuePair<string, MIMEType>("application/vnd.accpac.simply.aso", ApplicationVndAccpacSimplyAso),
new KeyValuePair<string, MIMEType>("application/vnd.accpac.simply.imp", ApplicationVndAccpacSimplyImp),
new KeyValuePair<string, MIMEType>("application/vnd.acucobol", ApplicationVndAcucobol),
new KeyValuePair<string, MIMEType>("application/vnd.acucorp", ApplicationVndAcucorp),
new KeyValuePair<string, MIMEType>("application/vnd.adobe.air-application-installer-package+zip", ApplicationVndAdobeAirApplicationInstallerPackageZip),
new KeyValuePair<string, MIMEType>("application/vnd.adobe.formscentral.fcdt", ApplicationVndAdobeFormscentralFcdt),
new KeyValuePair<string, MIMEType>("application/vnd.adobe.fxp", ApplicationVndAdobeFxp),
new KeyValuePair<string, MIMEType>("application/vnd.adobe.xdp+xml", ApplicationVndAdobeXdpXml),
new KeyValuePair<string, MIMEType>("application/vnd.adobe.xfdf", ApplicationVndAdobeXfdf),
new KeyValuePair<string, MIMEType>("application/vnd.ahead.space", ApplicationVndAheadSpace),
new KeyValuePair<string, MIMEType>("application/vnd.airzip.filesecure.azf", ApplicationVndAirzipFilesecureAzf),
new KeyValuePair<string, MIMEType>("application/vnd.airzip.filesecure.azs", ApplicationVndAirzipFilesecureAzs),
new KeyValuePair<string, MIMEType>("application/vnd.amazon.ebook", ApplicationVndAmazonEbook),
new KeyValuePair<string, MIMEType>("application/vnd.americandynamics.acc", ApplicationVndAmericandynamicsAcc),
new KeyValuePair<string, MIMEType>("application/vnd.amiga.ami", ApplicationVndAmigaAmi),
new KeyValuePair<string, MIMEType>("application/vnd.android.package-archive", ApplicationVndAndroidPackageArchive),
new KeyValuePair<string, MIMEType>("application/vnd.anser-web-certificate-issue-initiation", ApplicationVndAnserWebCertificateIssueInitiation),
new KeyValuePair<string, MIMEType>("application/vnd.anser-web-funds-transfer-initiation", ApplicationVndAnserWebFundsTransferInitiation),
new KeyValuePair<string, MIMEType>("application/vnd.antix.game-component", ApplicationVndAntixGameComponent),
new KeyValuePair<string, MIMEType>("application/vnd.apple.installer+xml", ApplicationVndAppleInstallerXml),
new KeyValuePair<string, MIMEType>("application/vnd.apple.mpegurl", ApplicationVndAppleMpegurl),
new KeyValuePair<string, MIMEType>("application/vnd.aristanetworks.swi", ApplicationVndAristanetworksSwi),
new KeyValuePair<string, MIMEType>("application/vnd.astraea-software.iota", ApplicationVndAstraeaSoftwareIota),
new KeyValuePair<string, MIMEType>("application/vnd.audiograph", ApplicationVndAudiograph),
new KeyValuePair<string, MIMEType>("application/vnd.blueice.multipass", ApplicationVndBlueiceMultipass),
new KeyValuePair<string, MIMEType>("application/vnd.bmi", ApplicationVndBmi),
new KeyValuePair<string, MIMEType>("application/vnd.businessobjects", ApplicationVndBusinessobjects),
new KeyValuePair<string, MIMEType>("application/vnd.chemdraw+xml", ApplicationVndChemdrawXml),
new KeyValuePair<string, MIMEType>("application/vnd.chipnuts.karaoke-mmd", ApplicationVndChipnutsKaraokeMmd),
new KeyValuePair<string, MIMEType>("application/vnd.cinderella", ApplicationVndCinderella),
new KeyValuePair<string, MIMEType>("application/vnd.claymore", ApplicationVndClaymore),
new KeyValuePair<string, MIMEType>("application/vnd.cloanto.rp9", ApplicationVndCloantoRp9),
new KeyValuePair<string, MIMEType>("application/vnd.clonk.c4group", ApplicationVndClonkC4group),
new KeyValuePair<string, MIMEType>("application/vnd.cluetrust.cartomobile-config", ApplicationVndCluetrustCartomobileConfig),
new KeyValuePair<string, MIMEType>("application/vnd.cluetrust.cartomobile-config-pkg", ApplicationVndCluetrustCartomobileConfigPkg),
new KeyValuePair<string, MIMEType>("application/vnd.commonspace", ApplicationVndCommonspace),
new KeyValuePair<string, MIMEType>("application/vnd.contact.cmsg", ApplicationVndContactCmsg),
new KeyValuePair<string, MIMEType>("application/vnd.cosmocaller", ApplicationVndCosmocaller),
new KeyValuePair<string, MIMEType>("application/vnd.crick.clicker", ApplicationVndCrickClicker),
new KeyValuePair<string, MIMEType>("application/vnd.crick.clicker.keyboard", ApplicationVndCrickClickerKeyboard),
new KeyValuePair<string, MIMEType>("application/vnd.crick.clicker.palette", ApplicationVndCrickClickerPalette),
new KeyValuePair<string, MIMEType>("application/vnd.crick.clicker.template", ApplicationVndCrickClickerTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.crick.clicker.wordbank", ApplicationVndCrickClickerWordbank),
new KeyValuePair<string, MIMEType>("application/vnd.criticaltools.wbs+xml", ApplicationVndCriticaltoolsWbsXml),
new KeyValuePair<string, MIMEType>("application/vnd.ctc-posml", ApplicationVndCtcPosml),
new KeyValuePair<string, MIMEType>("application/vnd.cups-ppd", ApplicationVndCupsPpd),
new KeyValuePair<string, MIMEType>("application/vnd.curl.car", ApplicationVndCurlCar),
new KeyValuePair<string, MIMEType>("application/vnd.curl.pcurl", ApplicationVndCurlPcurl),
new KeyValuePair<string, MIMEType>("application/vnd.dart", ApplicationVndDart),
new KeyValuePair<string, MIMEType>("application/vnd.data-vision.rdz", ApplicationVndDataVisionRdz),
new KeyValuePair<string, MIMEType>("application/vnd.dece.data", ApplicationVndDeceData),
new KeyValuePair<string, MIMEType>("application/vnd.dece.ttml+xml", ApplicationVndDeceTtmlXml),
new KeyValuePair<string, MIMEType>("application/vnd.dece.unspecified", ApplicationVndDeceUnspecified),
new KeyValuePair<string, MIMEType>("application/vnd.dece.zip", ApplicationVndDeceZip),
new KeyValuePair<string, MIMEType>("application/vnd.denovo.fcselayout-link", ApplicationVndDenovoFcselayoutLink),
new KeyValuePair<string, MIMEType>("application/vnd.dna", ApplicationVndDna),
new KeyValuePair<string, MIMEType>("application/vnd.dolby.mlp", ApplicationVndDolbyMlp),
new KeyValuePair<string, MIMEType>("application/vnd.dpgraph", ApplicationVndDpgraph),
new KeyValuePair<string, MIMEType>("application/vnd.dreamfactory", ApplicationVndDreamfactory),
new KeyValuePair<string, MIMEType>("application/vnd.ds-keypoint", ApplicationVndDsKeypoint),
new KeyValuePair<string, MIMEType>("application/vnd.dvb.ait", ApplicationVndDvbAit),
new KeyValuePair<string, MIMEType>("application/vnd.dvb.service", ApplicationVndDvbService),
new KeyValuePair<string, MIMEType>("application/vnd.dynageo", ApplicationVndDynageo),
new KeyValuePair<string, MIMEType>("application/vnd.ecowin.chart", ApplicationVndEcowinChart),
new KeyValuePair<string, MIMEType>("application/vnd.enliven", ApplicationVndEnliven),
new KeyValuePair<string, MIMEType>("application/vnd.epson.esf", ApplicationVndEpsonEsf),
new KeyValuePair<string, MIMEType>("application/vnd.epson.msf", ApplicationVndEpsonMsf),
new KeyValuePair<string, MIMEType>("application/vnd.epson.quickanime", ApplicationVndEpsonQuickanime),
new KeyValuePair<string, MIMEType>("application/vnd.epson.salt", ApplicationVndEpsonSalt),
new KeyValuePair<string, MIMEType>("application/vnd.epson.ssf", ApplicationVndEpsonSsf),
new KeyValuePair<string, MIMEType>("application/vnd.eszigno3+xml", ApplicationVndEszigno3Xml),
new KeyValuePair<string, MIMEType>("application/vnd.ezpix-album", ApplicationVndEzpixAlbum),
new KeyValuePair<string, MIMEType>("application/vnd.ezpix-package", ApplicationVndEzpixPackage),
new KeyValuePair<string, MIMEType>("application/vnd.fdf", ApplicationVndFdf),
new KeyValuePair<string, MIMEType>("application/vnd.fdsn.mseed", ApplicationVndFdsnMseed),
new KeyValuePair<string, MIMEType>("application/vnd.fdsn.seed", ApplicationVndFdsnSeed),
new KeyValuePair<string, MIMEType>("application/vnd.flographit", ApplicationVndFlographit),
new KeyValuePair<string, MIMEType>("application/vnd.fluxtime.clip", ApplicationVndFluxtimeClip),
new KeyValuePair<string, MIMEType>("application/vnd.framemaker", ApplicationVndFramemaker),
new KeyValuePair<string, MIMEType>("application/vnd.frogans.fnc", ApplicationVndFrogansFnc),
new KeyValuePair<string, MIMEType>("application/vnd.frogans.ltf", ApplicationVndFrogansLtf),
new KeyValuePair<string, MIMEType>("application/vnd.fsc.weblaunch", ApplicationVndFscWeblaunch),
new KeyValuePair<string, MIMEType>("application/vnd.fujitsu.oasys", ApplicationVndFujitsuOasys),
new KeyValuePair<string, MIMEType>("application/vnd.fujitsu.oasys2", ApplicationVndFujitsuOasys2),
new KeyValuePair<string, MIMEType>("application/vnd.fujitsu.oasys3", ApplicationVndFujitsuOasys3),
new KeyValuePair<string, MIMEType>("application/vnd.fujitsu.oasysgp", ApplicationVndFujitsuOasysgp),
new KeyValuePair<string, MIMEType>("application/vnd.fujitsu.oasysprs", ApplicationVndFujitsuOasysprs),
new KeyValuePair<string, MIMEType>("application/vnd.fujixerox.ddd", ApplicationVndFujixeroxDdd),
new KeyValuePair<string, MIMEType>("application/vnd.fujixerox.docuworks", ApplicationVndFujixeroxDocuworks),
new KeyValuePair<string, MIMEType>("application/vnd.fujixerox.docuworks.binder", ApplicationVndFujixeroxDocuworksBinder),
new KeyValuePair<string, MIMEType>("application/vnd.fuzzysheet", ApplicationVndFuzzysheet),
new KeyValuePair<string, MIMEType>("application/vnd.genomatix.tuxedo", ApplicationVndGenomatixTuxedo),
new KeyValuePair<string, MIMEType>("application/vnd.geogebra.file", ApplicationVndGeogebraFile),
new KeyValuePair<string, MIMEType>("application/vnd.geogebra.tool", ApplicationVndGeogebraTool),
new KeyValuePair<string, MIMEType>("application/vnd.geometry-explorer", ApplicationVndGeometryExplorer),
new KeyValuePair<string, MIMEType>("application/vnd.geonext", ApplicationVndGeonext),
new KeyValuePair<string, MIMEType>("application/vnd.geoplan", ApplicationVndGeoplan),
new KeyValuePair<string, MIMEType>("application/vnd.geospace", ApplicationVndGeospace),
new KeyValuePair<string, MIMEType>("application/vnd.gmx", ApplicationVndGmx),
new KeyValuePair<string, MIMEType>("application/vnd.google-earth.kml+xml", ApplicationVndGoogleEarthKmlXml),
new KeyValuePair<string, MIMEType>("application/vnd.google-earth.kmz", ApplicationVndGoogleEarthKmz),
new KeyValuePair<string, MIMEType>("application/vnd.grafeq", ApplicationVndGrafeq),
new KeyValuePair<string, MIMEType>("application/vnd.groove-account", ApplicationVndGrooveAccount),
new KeyValuePair<string, MIMEType>("application/vnd.groove-help", ApplicationVndGrooveHelp),
new KeyValuePair<string, MIMEType>("application/vnd.groove-identity-message", ApplicationVndGrooveIdentityMessage),
new KeyValuePair<string, MIMEType>("application/vnd.groove-injector", ApplicationVndGrooveInjector),
new KeyValuePair<string, MIMEType>("application/vnd.groove-tool-message", ApplicationVndGrooveToolMessage),
new KeyValuePair<string, MIMEType>("application/vnd.groove-tool-template", ApplicationVndGrooveToolTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.groove-vcard", ApplicationVndGrooveVcard),
new KeyValuePair<string, MIMEType>("application/vnd.hal+xml", ApplicationVndHalXml),
new KeyValuePair<string, MIMEType>("application/vnd.handheld-entertainment+xml", ApplicationVndHandheldEntertainmentXml),
new KeyValuePair<string, MIMEType>("application/vnd.hbci", ApplicationVndHbci),
new KeyValuePair<string, MIMEType>("application/vnd.hhe.lesson-player", ApplicationVndHheLessonPlayer),
new KeyValuePair<string, MIMEType>("application/vnd.hp-hpgl", ApplicationVndHpHpgl),
new KeyValuePair<string, MIMEType>("application/vnd.hp-hpid", ApplicationVndHpHpid),
new KeyValuePair<string, MIMEType>("application/vnd.hp-hps", ApplicationVndHpHps),
new KeyValuePair<string, MIMEType>("application/vnd.hp-jlyt", ApplicationVndHpJlyt),
new KeyValuePair<string, MIMEType>("application/vnd.hp-pcl", ApplicationVndHpPcl),
new KeyValuePair<string, MIMEType>("application/vnd.hp-pclxl", ApplicationVndHpPclxl),
new KeyValuePair<string, MIMEType>("application/vnd.hydrostatix.sof-data", ApplicationVndHydrostatixSofData),
new KeyValuePair<string, MIMEType>("application/vnd.ibm.minipay", ApplicationVndIbmMinipay),
new KeyValuePair<string, MIMEType>("application/vnd.ibm.modcap", ApplicationVndIbmModcap),
new KeyValuePair<string, MIMEType>("application/vnd.ibm.rights-management", ApplicationVndIbmRightsManagement),
new KeyValuePair<string, MIMEType>("application/vnd.ibm.secure-container", ApplicationVndIbmSecureContainer),
new KeyValuePair<string, MIMEType>("application/vnd.iccprofile", ApplicationVndIccprofile),
new KeyValuePair<string, MIMEType>("application/vnd.igloader", ApplicationVndIgloader),
new KeyValuePair<string, MIMEType>("application/vnd.immervision-ivp", ApplicationVndImmervisionIvp),
new KeyValuePair<string, MIMEType>("application/vnd.immervision-ivu", ApplicationVndImmervisionIvu),
new KeyValuePair<string, MIMEType>("application/vnd.insors.igm", ApplicationVndInsorsIgm),
new KeyValuePair<string, MIMEType>("application/vnd.intercon.formnet", ApplicationVndInterconFormnet),
new KeyValuePair<string, MIMEType>("application/vnd.intergeo", ApplicationVndIntergeo),
new KeyValuePair<string, MIMEType>("application/vnd.intu.qbo", ApplicationVndIntuQbo),
new KeyValuePair<string, MIMEType>("application/vnd.intu.qfx", ApplicationVndIntuQfx),
new KeyValuePair<string, MIMEType>("application/vnd.ipunplugged.rcprofile", ApplicationVndIpunpluggedRcprofile),
new KeyValuePair<string, MIMEType>("application/vnd.irepository.package+xml", ApplicationVndIrepositoryPackageXml),
new KeyValuePair<string, MIMEType>("application/vnd.is-xpr", ApplicationVndIsXpr),
new KeyValuePair<string, MIMEType>("application/vnd.isac.fcs", ApplicationVndIsacFcs),
new KeyValuePair<string, MIMEType>("application/vnd.jam", ApplicationVndJam),
new KeyValuePair<string, MIMEType>("application/vnd.jcp.javame.midlet-rms", ApplicationVndJcpJavameMidletRms),
new KeyValuePair<string, MIMEType>("application/vnd.jisp", ApplicationVndJisp),
new KeyValuePair<string, MIMEType>("application/vnd.joost.joda-archive", ApplicationVndJoostJodaArchive),
new KeyValuePair<string, MIMEType>("application/vnd.kahootz", ApplicationVndKahootz),
new KeyValuePair<string, MIMEType>("application/vnd.kde.karbon", ApplicationVndKdeKarbon),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kchart", ApplicationVndKdeKchart),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kformula", ApplicationVndKdeKformula),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kivio", ApplicationVndKdeKivio),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kontour", ApplicationVndKdeKontour),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kpresenter", ApplicationVndKdeKpresenter),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kspread", ApplicationVndKdeKspread),
new KeyValuePair<string, MIMEType>("application/vnd.kde.kword", ApplicationVndKdeKword),
new KeyValuePair<string, MIMEType>("application/vnd.kenameaapp", ApplicationVndKenameaapp),
new KeyValuePair<string, MIMEType>("application/vnd.kidspiration", ApplicationVndKidspiration),
new KeyValuePair<string, MIMEType>("application/vnd.kinar", ApplicationVndKinar),
new KeyValuePair<string, MIMEType>("application/vnd.koan", ApplicationVndKoan),
new KeyValuePair<string, MIMEType>("application/vnd.kodak-descriptor", ApplicationVndKodakDescriptor),
new KeyValuePair<string, MIMEType>("application/vnd.las.las+xml", ApplicationVndLasLasXml),
new KeyValuePair<string, MIMEType>("application/vnd.llamagraphics.life-balance.desktop", ApplicationVndLlamagraphicsLifeBalanceDesktop),
new KeyValuePair<string, MIMEType>("application/vnd.llamagraphics.life-balance.exchange+xml", ApplicationVndLlamagraphicsLifeBalanceExchangeXml),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-1-2-3", ApplicationVndLotus123),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-approach", ApplicationVndLotusApproach),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-freelance", ApplicationVndLotusFreelance),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-notes", ApplicationVndLotusNotes),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-organizer", ApplicationVndLotusOrganizer),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-screencam", ApplicationVndLotusScreencam),
new KeyValuePair<string, MIMEType>("application/vnd.lotus-wordpro", ApplicationVndLotusWordpro),
new KeyValuePair<string, MIMEType>("application/vnd.macports.portpkg", ApplicationVndMacportsPortpkg),
new KeyValuePair<string, MIMEType>("application/vnd.mcd", ApplicationVndMcd),
new KeyValuePair<string, MIMEType>("application/vnd.medcalcdata", ApplicationVndMedcalcdata),
new KeyValuePair<string, MIMEType>("application/vnd.mediastation.cdkey", ApplicationVndMediastationCdkey),
new KeyValuePair<string, MIMEType>("application/vnd.mfer", ApplicationVndMfer),
new KeyValuePair<string, MIMEType>("application/vnd.mfmp", ApplicationVndMfmp),
new KeyValuePair<string, MIMEType>("application/vnd.micrografx.flo", ApplicationVndMicrografxFlo),
new KeyValuePair<string, MIMEType>("application/vnd.micrografx.igx", ApplicationVndMicrografxIgx),
new KeyValuePair<string, MIMEType>("application/vnd.mif", ApplicationVndMif),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.daf", ApplicationVndMobiusDaf),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.dis", ApplicationVndMobiusDis),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.mbk", ApplicationVndMobiusMbk),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.mqy", ApplicationVndMobiusMqy),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.msl", ApplicationVndMobiusMsl),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.plc", ApplicationVndMobiusPlc),
new KeyValuePair<string, MIMEType>("application/vnd.mobius.txf", ApplicationVndMobiusTxf),
new KeyValuePair<string, MIMEType>("application/vnd.mophun.application", ApplicationVndMophunApplication),
new KeyValuePair<string, MIMEType>("application/vnd.mophun.certificate", ApplicationVndMophunCertificate),
new KeyValuePair<string, MIMEType>("application/vnd.mozilla.xul+xml", ApplicationVndMozillaXulXml),
new KeyValuePair<string, MIMEType>("application/vnd.ms-artgalry", ApplicationVndMsArtgalry),
new KeyValuePair<string, MIMEType>("application/vnd.ms-cab-compressed", ApplicationVndMsCabCompressed),
new KeyValuePair<string, MIMEType>("application/vnd.ms-excel", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("application/vnd.ms-excel.addin.macroenabled.12", ApplicationVndMsExcelAddinMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-excel.sheet.binary.macroenabled.12", ApplicationVndMsExcelSheetBinaryMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-excel.sheet.macroenabled.12", ApplicationVndMsExcelSheetMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-excel.template.macroenabled.12", ApplicationVndMsExcelTemplateMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-fontobject", ApplicationVndMsFontobject),
new KeyValuePair<string, MIMEType>("application/vnd.ms-htmlhelp", ApplicationVndMsHtmlhelp),
new KeyValuePair<string, MIMEType>("application/vnd.ms-ims", ApplicationVndMsIms),
new KeyValuePair<string, MIMEType>("application/vnd.ms-lrm", ApplicationVndMsLrm),
new KeyValuePair<string, MIMEType>("application/vnd.ms-officetheme", ApplicationVndMsOfficetheme),
new KeyValuePair<string, MIMEType>("application/vnd.ms-pki.seccat", ApplicationVndMsPkiSeccat),
new KeyValuePair<string, MIMEType>("application/vnd.ms-pki.stl", ApplicationVndMsPkiStl),
new KeyValuePair<string, MIMEType>("application/vnd.ms-powerpoint", ApplicationVndMsPowerpoint),
new KeyValuePair<string, MIMEType>("application/vnd.ms-powerpoint.addin.macroenabled.12", ApplicationVndMsPowerpointAddinMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-powerpoint.presentation.macroenabled.12", ApplicationVndMsPowerpointPresentationMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-powerpoint.slide.macroenabled.12", ApplicationVndMsPowerpointSlideMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-powerpoint.slideshow.macroenabled.12", ApplicationVndMsPowerpointSlideshowMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-powerpoint.template.macroenabled.12", ApplicationVndMsPowerpointTemplateMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-project", ApplicationVndMsProject),
new KeyValuePair<string, MIMEType>("application/vnd.ms-word.document.macroenabled.12", ApplicationVndMsWordDocumentMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-word.template.macroenabled.12", ApplicationVndMsWordTemplateMacroenabled12),
new KeyValuePair<string, MIMEType>("application/vnd.ms-works", ApplicationVndMsWorks),
new KeyValuePair<string, MIMEType>("application/vnd.ms-wpl", ApplicationVndMsWpl),
new KeyValuePair<string, MIMEType>("application/vnd.ms-xpsdocument", ApplicationVndMsXpsdocument),
new KeyValuePair<string, MIMEType>("application/vnd.mseq", ApplicationVndMseq),
new KeyValuePair<string, MIMEType>("application/vnd.musician", ApplicationVndMusician),
new KeyValuePair<string, MIMEType>("application/vnd.muvee.style", ApplicationVndMuveeStyle),
new KeyValuePair<string, MIMEType>("application/vnd.mynfc", ApplicationVndMynfc),
new KeyValuePair<string, MIMEType>("application/vnd.neurolanguage.nlu", ApplicationVndNeurolanguageNlu),
new KeyValuePair<string, MIMEType>("application/vnd.nitf", ApplicationVndNitf),
new KeyValuePair<string, MIMEType>("application/vnd.noblenet-directory", ApplicationVndNoblenetDirectory),
new KeyValuePair<string, MIMEType>("application/vnd.noblenet-sealer", ApplicationVndNoblenetSealer),
new KeyValuePair<string, MIMEType>("application/vnd.noblenet-web", ApplicationVndNoblenetWeb),
new KeyValuePair<string, MIMEType>("application/vnd.nokia.n-gage.data", ApplicationVndNokiaNGageData),
new KeyValuePair<string, MIMEType>("application/vnd.nokia.n-gage.symbian.install", ApplicationVndNokiaNGageSymbianInstall),
new KeyValuePair<string, MIMEType>("application/vnd.nokia.radio-preset", ApplicationVndNokiaRadioPreset),
new KeyValuePair<string, MIMEType>("application/vnd.nokia.radio-presets", ApplicationVndNokiaRadioPresets),
new KeyValuePair<string, MIMEType>("application/vnd.novadigm.edm", ApplicationVndNovadigmEdm),
new KeyValuePair<string, MIMEType>("application/vnd.novadigm.edx", ApplicationVndNovadigmEdx),
new KeyValuePair<string, MIMEType>("application/vnd.novadigm.ext", ApplicationVndNovadigmExt),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.chart", ApplicationVndOasisOpendocumentChart),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.chart-template", ApplicationVndOasisOpendocumentChartTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.database", ApplicationVndOasisOpendocumentDatabase),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.formula", ApplicationVndOasisOpendocumentFormula),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.formula-template", ApplicationVndOasisOpendocumentFormulaTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.graphics", ApplicationVndOasisOpendocumentGraphics),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.graphics-template", ApplicationVndOasisOpendocumentGraphicsTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.image", ApplicationVndOasisOpendocumentImage),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.image-template", ApplicationVndOasisOpendocumentImageTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.presentation", ApplicationVndOasisOpendocumentPresentation),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.presentation-template", ApplicationVndOasisOpendocumentPresentationTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.spreadsheet", ApplicationVndOasisOpendocumentSpreadsheet),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.spreadsheet-template", ApplicationVndOasisOpendocumentSpreadsheetTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.text", ApplicationVndOasisOpendocumentText),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.text-master", ApplicationVndOasisOpendocumentTextMaster),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.text-template", ApplicationVndOasisOpendocumentTextTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.oasis.opendocument.text-web", ApplicationVndOasisOpendocumentTextWeb),
new KeyValuePair<string, MIMEType>("application/vnd.olpc-sugar", ApplicationVndOlpcSugar),
new KeyValuePair<string, MIMEType>("application/vnd.oma.dd2+xml", ApplicationVndOmaDd2Xml),
new KeyValuePair<string, MIMEType>("application/vnd.openofficeorg.extension", ApplicationVndOpenofficeorgExtension),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.presentationml.presentation", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.presentationml.slide", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlSlide),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.presentationml.slideshow", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlSlideshow),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.presentationml.template", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.spreadsheetml.template", ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.wordprocessingml.document", ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument),
new KeyValuePair<string, MIMEType>("application/vnd.openxmlformats-officedocument.wordprocessingml.template", ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.osgeo.mapguide.package", ApplicationVndOsgeoMapguidePackage),
new KeyValuePair<string, MIMEType>("application/vnd.osgi.dp", ApplicationVndOsgiDp),
new KeyValuePair<string, MIMEType>("application/vnd.osgi.subsystem", ApplicationVndOsgiSubsystem),
new KeyValuePair<string, MIMEType>("application/vnd.palm", ApplicationVndPalm),
new KeyValuePair<string, MIMEType>("application/vnd.pawaafile", ApplicationVndPawaafile),
new KeyValuePair<string, MIMEType>("application/vnd.pg.format", ApplicationVndPgFormat),
new KeyValuePair<string, MIMEType>("application/vnd.pg.osasli", ApplicationVndPgOsasli),
new KeyValuePair<string, MIMEType>("application/vnd.picsel", ApplicationVndPicsel),
new KeyValuePair<string, MIMEType>("application/vnd.pmi.widget", ApplicationVndPmiWidget),
new KeyValuePair<string, MIMEType>("application/vnd.pocketlearn", ApplicationVndPocketlearn),
new KeyValuePair<string, MIMEType>("application/vnd.powerbuilder6", ApplicationVndPowerbuilder6),
new KeyValuePair<string, MIMEType>("application/vnd.previewsystems.box", ApplicationVndPreviewsystemsBox),
new KeyValuePair<string, MIMEType>("application/vnd.proteus.magazine", ApplicationVndProteusMagazine),
new KeyValuePair<string, MIMEType>("application/vnd.publishare-delta-tree", ApplicationVndPublishareDeltaTree),
new KeyValuePair<string, MIMEType>("application/vnd.pvi.ptid1", ApplicationVndPviPtid1),
new KeyValuePair<string, MIMEType>("application/vnd.quark.quarkxpress", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("application/vnd.realvnc.bed", ApplicationVndRealvncBed),
new KeyValuePair<string, MIMEType>("application/vnd.recordare.musicxml", ApplicationVndRecordareMusicxml),
new KeyValuePair<string, MIMEType>("application/vnd.recordare.musicxml+xml", ApplicationVndRecordareMusicxmlXml),
new KeyValuePair<string, MIMEType>("application/vnd.rig.cryptonote", ApplicationVndRigCryptonote),
new KeyValuePair<string, MIMEType>("application/vnd.rim.cod", ApplicationVndRimCod),
new KeyValuePair<string, MIMEType>("application/vnd.rn-realmedia", ApplicationVndRnRealmedia),
new KeyValuePair<string, MIMEType>("application/vnd.rn-realmedia-vbr", ApplicationVndRnRealmediaVbr),
new KeyValuePair<string, MIMEType>("application/vnd.route66.link66+xml", ApplicationVndRoute66Link66Xml),
new KeyValuePair<string, MIMEType>("application/vnd.sailingtracker.track", ApplicationVndSailingtrackerTrack),
new KeyValuePair<string, MIMEType>("application/vnd.seemail", ApplicationVndSeemail),
new KeyValuePair<string, MIMEType>("application/vnd.sema", ApplicationVndSema),
new KeyValuePair<string, MIMEType>("application/vnd.semd", ApplicationVndSemd),
new KeyValuePair<string, MIMEType>("application/vnd.semf", ApplicationVndSemf),
new KeyValuePair<string, MIMEType>("application/vnd.shana.informed.formdata", ApplicationVndShanaInformedFormdata),
new KeyValuePair<string, MIMEType>("application/vnd.shana.informed.formtemplate", ApplicationVndShanaInformedFormtemplate),
new KeyValuePair<string, MIMEType>("application/vnd.shana.informed.interchange", ApplicationVndShanaInformedInterchange),
new KeyValuePair<string, MIMEType>("application/vnd.shana.informed.package", ApplicationVndShanaInformedPackage),
new KeyValuePair<string, MIMEType>("application/vnd.simtech-mindmapper", ApplicationVndSimtechMindmapper),
new KeyValuePair<string, MIMEType>("application/vnd.smaf", ApplicationVndSmaf),
new KeyValuePair<string, MIMEType>("application/vnd.smart.teacher", ApplicationVndSmartTeacher),
new KeyValuePair<string, MIMEType>("application/vnd.solent.sdkm+xml", ApplicationVndSolentSdkmXml),
new KeyValuePair<string, MIMEType>("application/vnd.spotfire.dxp", ApplicationVndSpotfireDxp),
new KeyValuePair<string, MIMEType>("application/vnd.spotfire.sfs", ApplicationVndSpotfireSfs),
new KeyValuePair<string, MIMEType>("application/vnd.stardivision.calc", ApplicationVndStardivisionCalc),
new KeyValuePair<string, MIMEType>("application/vnd.stardivision.draw", ApplicationVndStardivisionDraw),
new KeyValuePair<string, MIMEType>("application/vnd.stardivision.impress", ApplicationVndStardivisionImpress),
new KeyValuePair<string, MIMEType>("application/vnd.stardivision.math", ApplicationVndStardivisionMath),
new KeyValuePair<string, MIMEType>("application/vnd.stardivision.writer", ApplicationVndStardivisionWriter),
new KeyValuePair<string, MIMEType>("application/vnd.stardivision.writer-global", ApplicationVndStardivisionWriterGlobal),
new KeyValuePair<string, MIMEType>("application/vnd.stepmania.package", ApplicationVndStepmaniaPackage),
new KeyValuePair<string, MIMEType>("application/vnd.stepmania.stepchart", ApplicationVndStepmaniaStepchart),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.calc", ApplicationVndSunXmlCalc),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.calc.template", ApplicationVndSunXmlCalcTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.draw", ApplicationVndSunXmlDraw),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.draw.template", ApplicationVndSunXmlDrawTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.impress", ApplicationVndSunXmlImpress),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.impress.template", ApplicationVndSunXmlImpressTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.math", ApplicationVndSunXmlMath),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.writer", ApplicationVndSunXmlWriter),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.writer.global", ApplicationVndSunXmlWriterGlobal),
new KeyValuePair<string, MIMEType>("application/vnd.sun.xml.writer.template", ApplicationVndSunXmlWriterTemplate),
new KeyValuePair<string, MIMEType>("application/vnd.sus-calendar", ApplicationVndSusCalendar),
new KeyValuePair<string, MIMEType>("application/vnd.svd", ApplicationVndSvd),
new KeyValuePair<string, MIMEType>("application/vnd.symbian.install", ApplicationVndSymbianInstall),
new KeyValuePair<string, MIMEType>("application/vnd.syncml+xml", ApplicationVndSyncmlXml),
new KeyValuePair<string, MIMEType>("application/vnd.syncml.dm+wbxml", ApplicationVndSyncmlDmWbxml),
new KeyValuePair<string, MIMEType>("application/vnd.syncml.dm+xml", ApplicationVndSyncmlDmXml),
new KeyValuePair<string, MIMEType>("application/vnd.tao.intent-module-archive", ApplicationVndTaoIntentModuleArchive),
new KeyValuePair<string, MIMEType>("application/vnd.tcpdump.pcap", ApplicationVndTcpdumpPcap),
new KeyValuePair<string, MIMEType>("application/vnd.tmobile-livetv", ApplicationVndTmobileLivetv),
new KeyValuePair<string, MIMEType>("application/vnd.trid.tpt", ApplicationVndTridTpt),
new KeyValuePair<string, MIMEType>("application/vnd.triscape.mxs", ApplicationVndTriscapeMxs),
new KeyValuePair<string, MIMEType>("application/vnd.trueapp", ApplicationVndTrueapp),
new KeyValuePair<string, MIMEType>("application/vnd.ufdl", ApplicationVndUfdl),
new KeyValuePair<string, MIMEType>("application/vnd.uiq.theme", ApplicationVndUiqTheme),
new KeyValuePair<string, MIMEType>("application/vnd.umajin", ApplicationVndUmajin),
new KeyValuePair<string, MIMEType>("application/vnd.unity", ApplicationVndUnity),
new KeyValuePair<string, MIMEType>("application/vnd.uoml+xml", ApplicationVndUomlXml),
new KeyValuePair<string, MIMEType>("application/vnd.vcx", ApplicationVndVcx),
new KeyValuePair<string, MIMEType>("application/vnd.visio", ApplicationVndVisio),
new KeyValuePair<string, MIMEType>("application/vnd.visionary", ApplicationVndVisionary),
new KeyValuePair<string, MIMEType>("application/vnd.vsf", ApplicationVndVsf),
new KeyValuePair<string, MIMEType>("application/vnd.wap.wbxml", ApplicationVndWapWbxml),
new KeyValuePair<string, MIMEType>("application/vnd.wap.wmlc", ApplicationVndWapWmlc),
new KeyValuePair<string, MIMEType>("application/vnd.wap.wmlscriptc", ApplicationVndWapWmlscriptc),
new KeyValuePair<string, MIMEType>("application/vnd.webturbo", ApplicationVndWebturbo),
new KeyValuePair<string, MIMEType>("application/vnd.wolfram.player", ApplicationVndWolframPlayer),
new KeyValuePair<string, MIMEType>("application/vnd.wordperfect", ApplicationVndWordperfect),
new KeyValuePair<string, MIMEType>("application/vnd.wqd", ApplicationVndWqd),
new KeyValuePair<string, MIMEType>("application/vnd.wt.stf", ApplicationVndWtStf),
new KeyValuePair<string, MIMEType>("application/vnd.xara", ApplicationVndXara),
new KeyValuePair<string, MIMEType>("application/vnd.xfdl", ApplicationVndXfdl),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.hv-dic", ApplicationVndYamahaHvDic),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.hv-script", ApplicationVndYamahaHvScript),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.hv-voice", ApplicationVndYamahaHvVoice),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.openscoreformat", ApplicationVndYamahaOpenscoreformat),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.openscoreformat.osfpvg+xml", ApplicationVndYamahaOpenscoreformatOsfpvgXml),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.smaf-audio", ApplicationVndYamahaSmafAudio),
new KeyValuePair<string, MIMEType>("application/vnd.yamaha.smaf-phrase", ApplicationVndYamahaSmafPhrase),
new KeyValuePair<string, MIMEType>("application/vnd.yellowriver-custom-menu", ApplicationVndYellowriverCustomMenu),
new KeyValuePair<string, MIMEType>("application/vnd.zul", ApplicationVndZul),
new KeyValuePair<string, MIMEType>("application/vnd.zzazz.deck+xml", ApplicationVndZzazzDeckXml),
new KeyValuePair<string, MIMEType>("application/voicexml+xml", ApplicationVoicexmlXml),
new KeyValuePair<string, MIMEType>("application/widget", ApplicationWidget),
new KeyValuePair<string, MIMEType>("application/winhlp", ApplicationWinhlp),
new KeyValuePair<string, MIMEType>("application/wsdl+xml", ApplicationWsdlXml),
new KeyValuePair<string, MIMEType>("application/wspolicy+xml", ApplicationWspolicyXml),
new KeyValuePair<string, MIMEType>("application/x-7z-compressed", ApplicationX7zCompressed),
new KeyValuePair<string, MIMEType>("application/x-abiword", ApplicationXAbiword),
new KeyValuePair<string, MIMEType>("application/x-ace-compressed", ApplicationXAceCompressed),
new KeyValuePair<string, MIMEType>("application/x-apple-diskimage", ApplicationXAppleDiskimage),
new KeyValuePair<string, MIMEType>("application/x-authorware-bin", ApplicationXAuthorwareBin),
new KeyValuePair<string, MIMEType>("application/x-authorware-map", ApplicationXAuthorwareMap),
new KeyValuePair<string, MIMEType>("application/x-authorware-seg", ApplicationXAuthorwareSeg),
new KeyValuePair<string, MIMEType>("application/x-bcpio", ApplicationXBcpio),
new KeyValuePair<string, MIMEType>("application/x-bittorrent", ApplicationXBittorrent),
new KeyValuePair<string, MIMEType>("application/x-blorb", ApplicationXBlorb),
new KeyValuePair<string, MIMEType>("application/x-bzip", ApplicationXBzip),
new KeyValuePair<string, MIMEType>("application/x-bzip2", ApplicationXBzip2),
new KeyValuePair<string, MIMEType>("application/x-cbr", ApplicationXCbr),
new KeyValuePair<string, MIMEType>("application/x-cdlink", ApplicationXCdlink),
new KeyValuePair<string, MIMEType>("application/x-cfs-compressed", ApplicationXCfsCompressed),
new KeyValuePair<string, MIMEType>("application/x-chat", ApplicationXChat),
new KeyValuePair<string, MIMEType>("application/x-chess-pgn", ApplicationXChessPgn),
new KeyValuePair<string, MIMEType>("application/x-conference", ApplicationXConference),
new KeyValuePair<string, MIMEType>("application/x-cpio", ApplicationXCpio),
new KeyValuePair<string, MIMEType>("application/x-csh", ApplicationXCsh),
new KeyValuePair<string, MIMEType>("application/x-debian-package", ApplicationXDebianPackage),
new KeyValuePair<string, MIMEType>("application/x-dgc-compressed", ApplicationXDgcCompressed),
new KeyValuePair<string, MIMEType>("application/x-director", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("application/x-doom", ApplicationXDoom),
new KeyValuePair<string, MIMEType>("application/x-dtbncx+xml", ApplicationXDtbncxXml),
new KeyValuePair<string, MIMEType>("application/x-dtbook+xml", ApplicationXDtbookXml),
new KeyValuePair<string, MIMEType>("application/x-dtbresource+xml", ApplicationXDtbresourceXml),
new KeyValuePair<string, MIMEType>("application/x-dvi", ApplicationXDvi),
new KeyValuePair<string, MIMEType>("application/x-envoy", ApplicationXEnvoy),
new KeyValuePair<string, MIMEType>("application/x-eva", ApplicationXEva),
new KeyValuePair<string, MIMEType>("application/x-font-bdf", ApplicationXFontBdf),
new KeyValuePair<string, MIMEType>("application/x-font-ghostscript", ApplicationXFontGhostscript),
new KeyValuePair<string, MIMEType>("application/x-font-linux-psf", ApplicationXFontLinuxPsf),
new KeyValuePair<string, MIMEType>("application/x-font-otf", ApplicationXFontOtf),
new KeyValuePair<string, MIMEType>("application/x-font-pcf", ApplicationXFontPcf),
new KeyValuePair<string, MIMEType>("application/x-font-snf", ApplicationXFontSnf),
new KeyValuePair<string, MIMEType>("application/x-font-ttf", ApplicationXFontTtf),
new KeyValuePair<string, MIMEType>("application/x-font-type1", ApplicationXFontType1),
new KeyValuePair<string, MIMEType>("application/x-font-woff", ApplicationXFontWoff),
new KeyValuePair<string, MIMEType>("application/x-freearc", ApplicationXFreearc),
new KeyValuePair<string, MIMEType>("application/x-futuresplash", ApplicationXFuturesplash),
new KeyValuePair<string, MIMEType>("application/x-gca-compressed", ApplicationXGcaCompressed),
new KeyValuePair<string, MIMEType>("application/x-glulx", ApplicationXGlulx),
new KeyValuePair<string, MIMEType>("application/x-gnumeric", ApplicationXGnumeric),
new KeyValuePair<string, MIMEType>("application/x-gramps-xml", ApplicationXGrampsXml),
new KeyValuePair<string, MIMEType>("application/x-gtar", ApplicationXGtar),
new KeyValuePair<string, MIMEType>("application/x-hdf", ApplicationXHdf),
new KeyValuePair<string, MIMEType>("application/x-install-instructions", ApplicationXInstallInstructions),
new KeyValuePair<string, MIMEType>("application/x-iso9660-image", ApplicationXIso9660Image),
new KeyValuePair<string, MIMEType>("application/x-java-jnlp-file", ApplicationXJavaJnlpFile),
new KeyValuePair<string, MIMEType>("application/x-latex", ApplicationXLatex),
new KeyValuePair<string, MIMEType>("application/x-lzh-compressed", ApplicationXLzhCompressed),
new KeyValuePair<string, MIMEType>("application/x-mie", ApplicationXMie),
new KeyValuePair<string, MIMEType>("application/x-mobipocket-ebook", ApplicationXMobipocketEbook),
new KeyValuePair<string, MIMEType>("application/x-ms-application", ApplicationXMsApplication),
new KeyValuePair<string, MIMEType>("application/x-ms-shortcut", ApplicationXMsShortcut),
new KeyValuePair<string, MIMEType>("application/x-ms-wmd", ApplicationXMsWmd),
new KeyValuePair<string, MIMEType>("application/x-ms-wmz", ApplicationXMsWmz),
new KeyValuePair<string, MIMEType>("application/x-ms-xbap", ApplicationXMsXbap),
new KeyValuePair<string, MIMEType>("application/x-msaccess", ApplicationXMsaccess),
new KeyValuePair<string, MIMEType>("application/x-msbinder", ApplicationXMsbinder),
new KeyValuePair<string, MIMEType>("application/x-mscardfile", ApplicationXMscardfile),
new KeyValuePair<string, MIMEType>("application/x-msclip", ApplicationXMsclip),
new KeyValuePair<string, MIMEType>("application/x-msdownload", ApplicationXMsdownload),
new KeyValuePair<string, MIMEType>("application/x-msmediaview", ApplicationXMsmediaview),
new KeyValuePair<string, MIMEType>("application/x-msmetafile", ApplicationXMsmetafile),
new KeyValuePair<string, MIMEType>("application/x-msmoney", ApplicationXMsmoney),
new KeyValuePair<string, MIMEType>("application/x-mspublisher", ApplicationXMspublisher),
new KeyValuePair<string, MIMEType>("application/x-msschedule", ApplicationXMsschedule),
new KeyValuePair<string, MIMEType>("application/x-msterminal", ApplicationXMsterminal),
new KeyValuePair<string, MIMEType>("application/x-mswrite", ApplicationXMswrite),
new KeyValuePair<string, MIMEType>("application/x-netcdf", ApplicationXNetcdf),
new KeyValuePair<string, MIMEType>("application/x-nzb", ApplicationXNzb),
new KeyValuePair<string, MIMEType>("application/x-pkcs12", ApplicationXPkcs12),
new KeyValuePair<string, MIMEType>("application/x-pkcs7-certificates", ApplicationXPkcs7Certificates),
new KeyValuePair<string, MIMEType>("application/x-pkcs7-certreqresp", ApplicationXPkcs7Certreqresp),
new KeyValuePair<string, MIMEType>("application/x-rar-compressed", ApplicationXRarCompressed),
new KeyValuePair<string, MIMEType>("application/x-research-info-systems", ApplicationXResearchInfoSystems),
new KeyValuePair<string, MIMEType>("application/x-sh", ApplicationXSh),
new KeyValuePair<string, MIMEType>("application/x-shar", ApplicationXShar),
new KeyValuePair<string, MIMEType>("application/x-shockwave-flash", ApplicationXShockwaveFlash),
new KeyValuePair<string, MIMEType>("application/x-silverlight-app", ApplicationXSilverlightApp),
new KeyValuePair<string, MIMEType>("application/x-sql", ApplicationXSql),
new KeyValuePair<string, MIMEType>("application/x-stuffit", ApplicationXStuffit),
new KeyValuePair<string, MIMEType>("application/x-stuffitx", ApplicationXStuffitx),
new KeyValuePair<string, MIMEType>("application/x-subrip", ApplicationXSubrip),
new KeyValuePair<string, MIMEType>("application/x-sv4cpio", ApplicationXSv4cpio),
new KeyValuePair<string, MIMEType>("application/x-sv4crc", ApplicationXSv4crc),
new KeyValuePair<string, MIMEType>("application/x-t3vm-image", ApplicationXT3vmImage),
new KeyValuePair<string, MIMEType>("application/x-tads", ApplicationXTads),
new KeyValuePair<string, MIMEType>("application/x-tar", ApplicationXTar),
new KeyValuePair<string, MIMEType>("application/x-tcl", ApplicationXTcl),
new KeyValuePair<string, MIMEType>("application/x-tex", ApplicationXTex),
new KeyValuePair<string, MIMEType>("application/x-tex-tfm", ApplicationXTexTfm),
new KeyValuePair<string, MIMEType>("application/x-texinfo", ApplicationXTexinfo),
new KeyValuePair<string, MIMEType>("application/x-tgif", ApplicationXTgif),
new KeyValuePair<string, MIMEType>("application/x-ustar", ApplicationXUstar),
new KeyValuePair<string, MIMEType>("application/x-wais-source", ApplicationXWaisSource),
new KeyValuePair<string, MIMEType>("application/x-x509-ca-cert", ApplicationXX509CaCert),
new KeyValuePair<string, MIMEType>("application/x-xfig", ApplicationXXfig),
new KeyValuePair<string, MIMEType>("application/x-xliff+xml", ApplicationXXliffXml),
new KeyValuePair<string, MIMEType>("application/x-xpinstall", ApplicationXXpinstall),
new KeyValuePair<string, MIMEType>("application/x-xz", ApplicationXXz),
new KeyValuePair<string, MIMEType>("application/x-zmachine", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("application/xaml+xml", ApplicationXamlXml),
new KeyValuePair<string, MIMEType>("application/xcap-diff+xml", ApplicationXcapDiffXml),
new KeyValuePair<string, MIMEType>("application/xenc+xml", ApplicationXencXml),
new KeyValuePair<string, MIMEType>("application/xhtml+xml", ApplicationXhtmlXml),
new KeyValuePair<string, MIMEType>("application/xml", ApplicationXml),
new KeyValuePair<string, MIMEType>("application/xml-dtd", ApplicationXmlDtd),
new KeyValuePair<string, MIMEType>("application/xop+xml", ApplicationXopXml),
new KeyValuePair<string, MIMEType>("application/xproc+xml", ApplicationXprocXml),
new KeyValuePair<string, MIMEType>("application/xslt+xml", ApplicationXsltXml),
new KeyValuePair<string, MIMEType>("application/xspf+xml", ApplicationXspfXml),
new KeyValuePair<string, MIMEType>("application/xv+xml", ApplicationXvXml),
new KeyValuePair<string, MIMEType>("application/yang", ApplicationYang),
new KeyValuePair<string, MIMEType>("application/yin+xml", ApplicationYinXml),
new KeyValuePair<string, MIMEType>("application/zip", ApplicationZip),
new KeyValuePair<string, MIMEType>("audio/adpcm", AudioAdpcm),
new KeyValuePair<string, MIMEType>("audio/basic", AudioBasic),
new KeyValuePair<string, MIMEType>("audio/midi", AudioMidi),
new KeyValuePair<string, MIMEType>("audio/mp4", AudioMp4),
new KeyValuePair<string, MIMEType>("audio/mpeg", AudioMpeg),
new KeyValuePair<string, MIMEType>("audio/ogg", AudioOgg),
new KeyValuePair<string, MIMEType>("audio/s3m", AudioS3m),
new KeyValuePair<string, MIMEType>("audio/silk", AudioSilk),
new KeyValuePair<string, MIMEType>("audio/vnd.dece.audio", AudioVndDeceAudio),
new KeyValuePair<string, MIMEType>("audio/vnd.digital-winds", AudioVndDigitalWinds),
new KeyValuePair<string, MIMEType>("audio/vnd.dra", AudioVndDra),
new KeyValuePair<string, MIMEType>("audio/vnd.dts", AudioVndDts),
new KeyValuePair<string, MIMEType>("audio/vnd.dts.hd", AudioVndDtsHd),
new KeyValuePair<string, MIMEType>("audio/vnd.lucent.voice", AudioVndLucentVoice),
new KeyValuePair<string, MIMEType>("audio/vnd.ms-playready.media.pya", AudioVndMsPlayreadyMediaPya),
new KeyValuePair<string, MIMEType>("audio/vnd.nuera.ecelp4800", AudioVndNueraEcelp4800),
new KeyValuePair<string, MIMEType>("audio/vnd.nuera.ecelp7470", AudioVndNueraEcelp7470),
new KeyValuePair<string, MIMEType>("audio/vnd.nuera.ecelp9600", AudioVndNueraEcelp9600),
new KeyValuePair<string, MIMEType>("audio/vnd.rip", AudioVndRip),
new KeyValuePair<string, MIMEType>("audio/webm", AudioWebm),
new KeyValuePair<string, MIMEType>("audio/x-aac", AudioXAac),
new KeyValuePair<string, MIMEType>("audio/x-aiff", AudioXAiff),
new KeyValuePair<string, MIMEType>("audio/x-caf", AudioXCaf),
new KeyValuePair<string, MIMEType>("audio/x-flac", AudioXFlac),
new KeyValuePair<string, MIMEType>("audio/x-matroska", AudioXMatroska),
new KeyValuePair<string, MIMEType>("audio/x-mpegurl", AudioXMpegurl),
new KeyValuePair<string, MIMEType>("audio/x-ms-wax", AudioXMsWax),
new KeyValuePair<string, MIMEType>("audio/x-ms-wma", AudioXMsWma),
new KeyValuePair<string, MIMEType>("audio/x-pn-realaudio", AudioXPnRealaudio),
new KeyValuePair<string, MIMEType>("audio/x-pn-realaudio-plugin", AudioXPnRealaudioPlugin),
new KeyValuePair<string, MIMEType>("audio/x-wav", AudioXWav),
new KeyValuePair<string, MIMEType>("audio/xm", AudioXm),
new KeyValuePair<string, MIMEType>("chemical/x-cdx", ChemicalXCdx),
new KeyValuePair<string, MIMEType>("chemical/x-cif", ChemicalXCif),
new KeyValuePair<string, MIMEType>("chemical/x-cmdf", ChemicalXCmdf),
new KeyValuePair<string, MIMEType>("chemical/x-cml", ChemicalXCml),
new KeyValuePair<string, MIMEType>("chemical/x-csml", ChemicalXCsml),
new KeyValuePair<string, MIMEType>("chemical/x-xyz", ChemicalXXyz),
new KeyValuePair<string, MIMEType>("image/bmp", ImageBmp),
new KeyValuePair<string, MIMEType>("image/cgm", ImageCgm),
new KeyValuePair<string, MIMEType>("image/g3fax", ImageG3fax),
new KeyValuePair<string, MIMEType>("image/gif", ImageGif),
new KeyValuePair<string, MIMEType>("image/ief", ImageIef),
new KeyValuePair<string, MIMEType>("image/jpeg", ImageJpeg),
new KeyValuePair<string, MIMEType>("image/ktx", ImageKtx),
new KeyValuePair<string, MIMEType>("image/png", ImagePng),
new KeyValuePair<string, MIMEType>("image/prs.btif", ImagePrsBtif),
new KeyValuePair<string, MIMEType>("image/sgi", ImageSgi),
new KeyValuePair<string, MIMEType>("image/svg+xml", ImageSvgXml),
new KeyValuePair<string, MIMEType>("image/tiff", ImageTiff),
new KeyValuePair<string, MIMEType>("image/vnd.adobe.photoshop", ImageVndAdobePhotoshop),
new KeyValuePair<string, MIMEType>("image/vnd.dece.graphic", ImageVndDeceGraphic),
new KeyValuePair<string, MIMEType>("image/vnd.dvb.subtitle", ImageVndDvbSubtitle),
new KeyValuePair<string, MIMEType>("image/vnd.djvu", ImageVndDjvu),
new KeyValuePair<string, MIMEType>("image/vnd.dwg", ImageVndDwg),
new KeyValuePair<string, MIMEType>("image/vnd.dxf", ImageVndDxf),
new KeyValuePair<string, MIMEType>("image/vnd.fastbidsheet", ImageVndFastbidsheet),
new KeyValuePair<string, MIMEType>("image/vnd.fpx", ImageVndFpx),
new KeyValuePair<string, MIMEType>("image/vnd.fst", ImageVndFst),
new KeyValuePair<string, MIMEType>("image/vnd.fujixerox.edmics-mmr", ImageVndFujixeroxEdmicsMmr),
new KeyValuePair<string, MIMEType>("image/vnd.fujixerox.edmics-rlc", ImageVndFujixeroxEdmicsRlc),
new KeyValuePair<string, MIMEType>("image/vnd.ms-modi", ImageVndMsModi),
new KeyValuePair<string, MIMEType>("image/vnd.ms-photo", ImageVndMsPhoto),
new KeyValuePair<string, MIMEType>("image/vnd.net-fpx", ImageVndNetFpx),
new KeyValuePair<string, MIMEType>("image/vnd.wap.wbmp", ImageVndWapWbmp),
new KeyValuePair<string, MIMEType>("image/vnd.xiff", ImageVndXiff),
new KeyValuePair<string, MIMEType>("image/webp", ImageWebp),
new KeyValuePair<string, MIMEType>("image/x-3ds", ImageX3ds),
new KeyValuePair<string, MIMEType>("image/x-cmu-raster", ImageXCmuRaster),
new KeyValuePair<string, MIMEType>("image/x-cmx", ImageXCmx),
new KeyValuePair<string, MIMEType>("image/x-freehand", ImageXFreehand),
new KeyValuePair<string, MIMEType>("image/x-icon", ImageXIcon),
new KeyValuePair<string, MIMEType>("image/x-mrsid-image", ImageXMrsidImage),
new KeyValuePair<string, MIMEType>("image/x-pcx", ImageXPcx),
new KeyValuePair<string, MIMEType>("image/x-pict", ImageXPict),
new KeyValuePair<string, MIMEType>("image/x-portable-anymap", ImageXPortableAnymap),
new KeyValuePair<string, MIMEType>("image/x-portable-bitmap", ImageXPortableBitmap),
new KeyValuePair<string, MIMEType>("image/x-portable-graymap", ImageXPortableGraymap),
new KeyValuePair<string, MIMEType>("image/x-portable-pixmap", ImageXPortablePixmap),
new KeyValuePair<string, MIMEType>("image/x-rgb", ImageXRgb),
new KeyValuePair<string, MIMEType>("image/x-tga", ImageXTga),
new KeyValuePair<string, MIMEType>("image/x-xbitmap", ImageXXbitmap),
new KeyValuePair<string, MIMEType>("image/x-xpixmap", ImageXXpixmap),
new KeyValuePair<string, MIMEType>("image/x-xwindowdump", ImageXXwindowdump),
new KeyValuePair<string, MIMEType>("message/rfc822", MessageRfc822),
new KeyValuePair<string, MIMEType>("model/iges", ModelIges),
new KeyValuePair<string, MIMEType>("model/mesh", ModelMesh),
new KeyValuePair<string, MIMEType>("model/vnd.collada+xml", ModelVndColladaXml),
new KeyValuePair<string, MIMEType>("model/vnd.dwf", ModelVndDwf),
new KeyValuePair<string, MIMEType>("model/vnd.gdl", ModelVndGdl),
new KeyValuePair<string, MIMEType>("model/vnd.gtw", ModelVndGtw),
new KeyValuePair<string, MIMEType>("model/vnd.mts", ModelVndMts),
new KeyValuePair<string, MIMEType>("model/vnd.vtu", ModelVndVtu),
new KeyValuePair<string, MIMEType>("model/vrml", ModelVrml),
new KeyValuePair<string, MIMEType>("model/x3d+binary", ModelX3dBinary),
new KeyValuePair<string, MIMEType>("model/x3d+vrml", ModelX3dVrml),
new KeyValuePair<string, MIMEType>("model/x3d+xml", ModelX3dXml),
new KeyValuePair<string, MIMEType>("text/cache-manifest", TextCacheManifest),
new KeyValuePair<string, MIMEType>("text/calendar", TextCalendar),
new KeyValuePair<string, MIMEType>("text/css", TextCss),
new KeyValuePair<string, MIMEType>("text/csv", TextCsv),
new KeyValuePair<string, MIMEType>("text/html", TextHtml),
new KeyValuePair<string, MIMEType>("text/n3", TextN3),
new KeyValuePair<string, MIMEType>("text/plain", TextPlain),
new KeyValuePair<string, MIMEType>("text/prs.lines.tag", TextPrsLinesTag),
new KeyValuePair<string, MIMEType>("text/richtext", TextRichtext),
new KeyValuePair<string, MIMEType>("text/sgml", TextSgml),
new KeyValuePair<string, MIMEType>("text/tab-separated-values", TextTabSeparatedValues),
new KeyValuePair<string, MIMEType>("text/troff", TextTroff),
new KeyValuePair<string, MIMEType>("text/turtle", TextTurtle),
new KeyValuePair<string, MIMEType>("text/uri-list", TextUriList),
new KeyValuePair<string, MIMEType>("text/vcard", TextVcard),
new KeyValuePair<string, MIMEType>("text/vnd.curl", TextVndCurl),
new KeyValuePair<string, MIMEType>("text/vnd.curl.dcurl", TextVndCurlDcurl),
new KeyValuePair<string, MIMEType>("text/vnd.curl.scurl", TextVndCurlScurl),
new KeyValuePair<string, MIMEType>("text/vnd.curl.mcurl", TextVndCurlMcurl),
new KeyValuePair<string, MIMEType>("text/vnd.dvb.subtitle", TextVndDvbSubtitle),
new KeyValuePair<string, MIMEType>("text/vnd.fly", TextVndFly),
new KeyValuePair<string, MIMEType>("text/vnd.fmi.flexstor", TextVndFmiFlexstor),
new KeyValuePair<string, MIMEType>("text/vnd.graphviz", TextVndGraphviz),
new KeyValuePair<string, MIMEType>("text/vnd.in3d.3dml", TextVndIn3d3dml),
new KeyValuePair<string, MIMEType>("text/vnd.in3d.spot", TextVndIn3dSpot),
new KeyValuePair<string, MIMEType>("text/vnd.sun.j2me.app-descriptor", TextVndSunJ2meAppDescriptor),
new KeyValuePair<string, MIMEType>("text/vnd.wap.wml", TextVndWapWml),
new KeyValuePair<string, MIMEType>("text/vnd.wap.wmlscript", TextVndWapWmlscript),
new KeyValuePair<string, MIMEType>("text/x-asm", TextXAsm),
new KeyValuePair<string, MIMEType>("text/x-c", TextXC),
new KeyValuePair<string, MIMEType>("text/x-fortran", TextXFortran),
new KeyValuePair<string, MIMEType>("text/x-java-source", TextXJavaSource),
new KeyValuePair<string, MIMEType>("text/x-opml", TextXOpml),
new KeyValuePair<string, MIMEType>("text/x-pascal", TextXPascal),
new KeyValuePair<string, MIMEType>("text/x-nfo", TextXNfo),
new KeyValuePair<string, MIMEType>("text/x-setext", TextXSetext),
new KeyValuePair<string, MIMEType>("text/x-sfv", TextXSfv),
new KeyValuePair<string, MIMEType>("text/x-uuencode", TextXUuencode),
new KeyValuePair<string, MIMEType>("text/x-vcalendar", TextXVcalendar),
new KeyValuePair<string, MIMEType>("text/x-vcard", TextXVcard),
new KeyValuePair<string, MIMEType>("video/3gpp", Video3gpp),
new KeyValuePair<string, MIMEType>("video/3gpp2", Video3gpp2),
new KeyValuePair<string, MIMEType>("video/h261", VideoH261),
new KeyValuePair<string, MIMEType>("video/h263", VideoH263),
new KeyValuePair<string, MIMEType>("video/h264", VideoH264),
new KeyValuePair<string, MIMEType>("video/jpeg", VideoJpeg),
new KeyValuePair<string, MIMEType>("video/jpm", VideoJpm),
new KeyValuePair<string, MIMEType>("video/mj2", VideoMj2),
new KeyValuePair<string, MIMEType>("video/mp4", VideoMp4),
new KeyValuePair<string, MIMEType>("video/mpeg", VideoMpeg),
new KeyValuePair<string, MIMEType>("video/ogg", VideoOgg),
new KeyValuePair<string, MIMEType>("video/quicktime", VideoQuicktime),
new KeyValuePair<string, MIMEType>("video/vnd.dece.hd", VideoVndDeceHd),
new KeyValuePair<string, MIMEType>("video/vnd.dece.mobile", VideoVndDeceMobile),
new KeyValuePair<string, MIMEType>("video/vnd.dece.pd", VideoVndDecePd),
new KeyValuePair<string, MIMEType>("video/vnd.dece.sd", VideoVndDeceSd),
new KeyValuePair<string, MIMEType>("video/vnd.dece.video", VideoVndDeceVideo),
new KeyValuePair<string, MIMEType>("video/vnd.dvb.file", VideoVndDvbFile),
new KeyValuePair<string, MIMEType>("video/vnd.fvt", VideoVndFvt),
new KeyValuePair<string, MIMEType>("video/vnd.mpegurl", VideoVndMpegurl),
new KeyValuePair<string, MIMEType>("video/vnd.ms-playready.media.pyv", VideoVndMsPlayreadyMediaPyv),
new KeyValuePair<string, MIMEType>("video/vnd.uvvu.mp4", VideoVndUvvuMp4),
new KeyValuePair<string, MIMEType>("video/vnd.vivo", VideoVndVivo),
new KeyValuePair<string, MIMEType>("video/webm", VideoWebm),
new KeyValuePair<string, MIMEType>("video/x-f4v", VideoXF4v),
new KeyValuePair<string, MIMEType>("video/x-fli", VideoXFli),
new KeyValuePair<string, MIMEType>("video/x-flv", VideoXFlv),
new KeyValuePair<string, MIMEType>("video/x-m4v", VideoXM4v),
new KeyValuePair<string, MIMEType>("video/x-matroska", VideoXMatroska),
new KeyValuePair<string, MIMEType>("video/x-mng", VideoXMng),
new KeyValuePair<string, MIMEType>("video/x-ms-asf", VideoXMsAsf),
new KeyValuePair<string, MIMEType>("video/x-ms-vob", VideoXMsVob),
new KeyValuePair<string, MIMEType>("video/x-ms-wm", VideoXMsWm),
new KeyValuePair<string, MIMEType>("video/x-ms-wmv", VideoXMsWmv),
new KeyValuePair<string, MIMEType>("video/x-ms-wmx", VideoXMsWmx),
new KeyValuePair<string, MIMEType>("video/x-ms-wvx", VideoXMsWvx),
new KeyValuePair<string, MIMEType>("video/x-msvideo", VideoXMsvideo),
new KeyValuePair<string, MIMEType>("video/x-sgi-movie", VideoXSgiMovie),
new KeyValuePair<string, MIMEType>("video/x-smv", VideoXSmv),
new KeyValuePair<string, MIMEType>("x-conference/x-cooltalk", XConferenceXCooltalk)
        ).ToDictionary();
        
        static private Dictionary<string, MIMEType> UNOFFICIAL_TYPE_LOOKUP_TABLE = Enumerable.New(
            new KeyValuePair<string, MIMEType>("image/jpg", ImageJpeg)
        ).ToDictionary();
        
        static public bool TryParseFromTypeStrict(string input, out MIMEType type)
        {
            if(TYPE_LOOKUP_TABLE.TryGetValue(input.ToLower(), out type))
                return true;
                
            type = ApplicationOctetStream;
            return false;
        }
        static public MIMEType ParseFromTypeStrict(string input)
        {
            MIMEType type;
            
            TryParseFromTypeStrict(input, out type);
            return type;
        }
        
        static public bool TryParseFromTypePermissive(string input, out MIMEType type)
        {
            if(TYPE_LOOKUP_TABLE.TryGetValue(input.ToLower(), out type))
                return true;
                
            if(UNOFFICIAL_TYPE_LOOKUP_TABLE.TryGetValue(input.ToLower(), out type))
                return true;
                
            type = ApplicationOctetStream;
            return false;
        }
        static public MIMEType ParseFromTypePermissive(string input)
        {
            MIMEType type;
            
            TryParseFromTypePermissive(input, out type);
            return type;
        }
        
        static private Dictionary<string, MIMEType> EXTENSION_LOOKUP_TABLE = Enumerable.New(
            new KeyValuePair<string, MIMEType>("ez", ApplicationAndrewInset),
new KeyValuePair<string, MIMEType>("aw", ApplicationApplixware),
new KeyValuePair<string, MIMEType>("atom", ApplicationAtomXml),
new KeyValuePair<string, MIMEType>("atomcat", ApplicationAtomcatXml),
new KeyValuePair<string, MIMEType>("atomsvc", ApplicationAtomsvcXml),
new KeyValuePair<string, MIMEType>("ccxml", ApplicationCcxmlXml),
new KeyValuePair<string, MIMEType>("cdmia", ApplicationCdmiCapability),
new KeyValuePair<string, MIMEType>("cdmic", ApplicationCdmiContainer),
new KeyValuePair<string, MIMEType>("cdmid", ApplicationCdmiDomain),
new KeyValuePair<string, MIMEType>("cdmio", ApplicationCdmiObject),
new KeyValuePair<string, MIMEType>("cdmiq", ApplicationCdmiQueue),
new KeyValuePair<string, MIMEType>("cu", ApplicationCuSeeme),
new KeyValuePair<string, MIMEType>("davmount", ApplicationDavmountXml),
new KeyValuePair<string, MIMEType>("dbk", ApplicationDocbookXml),
new KeyValuePair<string, MIMEType>("dssc", ApplicationDsscDer),
new KeyValuePair<string, MIMEType>("xdssc", ApplicationDsscXml),
new KeyValuePair<string, MIMEType>("ecma", ApplicationEcmascript),
new KeyValuePair<string, MIMEType>("emma", ApplicationEmmaXml),
new KeyValuePair<string, MIMEType>("epub", ApplicationEpubZip),
new KeyValuePair<string, MIMEType>("exi", ApplicationExi),
new KeyValuePair<string, MIMEType>("pfr", ApplicationFontTdpfr),
new KeyValuePair<string, MIMEType>("gml", ApplicationGmlXml),
new KeyValuePair<string, MIMEType>("gpx", ApplicationGpxXml),
new KeyValuePair<string, MIMEType>("gxf", ApplicationGxf),
new KeyValuePair<string, MIMEType>("stk", ApplicationHyperstudio),
new KeyValuePair<string, MIMEType>("ink", ApplicationInkmlXml),
new KeyValuePair<string, MIMEType>("inkml", ApplicationInkmlXml),
new KeyValuePair<string, MIMEType>("ipfix", ApplicationIpfix),
new KeyValuePair<string, MIMEType>("jar", ApplicationJavaArchive),
new KeyValuePair<string, MIMEType>("ser", ApplicationJavaSerializedObject),
new KeyValuePair<string, MIMEType>("class", ApplicationJavaVm),
new KeyValuePair<string, MIMEType>("js", ApplicationJavascript),
new KeyValuePair<string, MIMEType>("json", ApplicationJson),
new KeyValuePair<string, MIMEType>("jsonml", ApplicationJsonmlJson),
new KeyValuePair<string, MIMEType>("lostxml", ApplicationLostXml),
new KeyValuePair<string, MIMEType>("hqx", ApplicationMacBinhex40),
new KeyValuePair<string, MIMEType>("cpt", ApplicationMacCompactpro),
new KeyValuePair<string, MIMEType>("mads", ApplicationMadsXml),
new KeyValuePair<string, MIMEType>("mrc", ApplicationMarc),
new KeyValuePair<string, MIMEType>("mrcx", ApplicationMarcxmlXml),
new KeyValuePair<string, MIMEType>("ma", ApplicationMathematica),
new KeyValuePair<string, MIMEType>("nb", ApplicationMathematica),
new KeyValuePair<string, MIMEType>("mb", ApplicationMathematica),
new KeyValuePair<string, MIMEType>("mathml", ApplicationMathmlXml),
new KeyValuePair<string, MIMEType>("mbox", ApplicationMbox),
new KeyValuePair<string, MIMEType>("mscml", ApplicationMediaservercontrolXml),
new KeyValuePair<string, MIMEType>("metalink", ApplicationMetalinkXml),
new KeyValuePair<string, MIMEType>("meta4", ApplicationMetalink4Xml),
new KeyValuePair<string, MIMEType>("mets", ApplicationMetsXml),
new KeyValuePair<string, MIMEType>("mods", ApplicationModsXml),
new KeyValuePair<string, MIMEType>("m21", ApplicationMp21),
new KeyValuePair<string, MIMEType>("mp21", ApplicationMp21),
new KeyValuePair<string, MIMEType>("mp4s", ApplicationMp4),
new KeyValuePair<string, MIMEType>("doc", ApplicationMsword),
new KeyValuePair<string, MIMEType>("dot", ApplicationMsword),
new KeyValuePair<string, MIMEType>("mxf", ApplicationMxf),
new KeyValuePair<string, MIMEType>("bin", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("dms", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("lrf", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("mar", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("so", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("dist", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("distz", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("pkg", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("bpk", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("dump", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("elc", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("deploy", ApplicationOctetStream),
new KeyValuePair<string, MIMEType>("oda", ApplicationOda),
new KeyValuePair<string, MIMEType>("opf", ApplicationOebpsPackageXml),
new KeyValuePair<string, MIMEType>("ogx", ApplicationOgg),
new KeyValuePair<string, MIMEType>("omdoc", ApplicationOmdocXml),
new KeyValuePair<string, MIMEType>("onetoc", ApplicationOnenote),
new KeyValuePair<string, MIMEType>("onetoc2", ApplicationOnenote),
new KeyValuePair<string, MIMEType>("onetmp", ApplicationOnenote),
new KeyValuePair<string, MIMEType>("onepkg", ApplicationOnenote),
new KeyValuePair<string, MIMEType>("oxps", ApplicationOxps),
new KeyValuePair<string, MIMEType>("xer", ApplicationPatchOpsErrorXml),
new KeyValuePair<string, MIMEType>("pdf", ApplicationPdf),
new KeyValuePair<string, MIMEType>("pgp", ApplicationPgpEncrypted),
new KeyValuePair<string, MIMEType>("asc", ApplicationPgpSignature),
new KeyValuePair<string, MIMEType>("sig", ApplicationPgpSignature),
new KeyValuePair<string, MIMEType>("prf", ApplicationPicsRules),
new KeyValuePair<string, MIMEType>("p10", ApplicationPkcs10),
new KeyValuePair<string, MIMEType>("p7m", ApplicationPkcs7Mime),
new KeyValuePair<string, MIMEType>("p7c", ApplicationPkcs7Mime),
new KeyValuePair<string, MIMEType>("p7s", ApplicationPkcs7Signature),
new KeyValuePair<string, MIMEType>("p8", ApplicationPkcs8),
new KeyValuePair<string, MIMEType>("ac", ApplicationPkixAttrCert),
new KeyValuePair<string, MIMEType>("cer", ApplicationPkixCert),
new KeyValuePair<string, MIMEType>("crl", ApplicationPkixCrl),
new KeyValuePair<string, MIMEType>("pkipath", ApplicationPkixPkipath),
new KeyValuePair<string, MIMEType>("pki", ApplicationPkixcmp),
new KeyValuePair<string, MIMEType>("pls", ApplicationPlsXml),
new KeyValuePair<string, MIMEType>("ai", ApplicationPostscript),
new KeyValuePair<string, MIMEType>("eps", ApplicationPostscript),
new KeyValuePair<string, MIMEType>("ps", ApplicationPostscript),
new KeyValuePair<string, MIMEType>("cww", ApplicationPrsCww),
new KeyValuePair<string, MIMEType>("pskcxml", ApplicationPskcXml),
new KeyValuePair<string, MIMEType>("rdf", ApplicationRdfXml),
new KeyValuePair<string, MIMEType>("rif", ApplicationReginfoXml),
new KeyValuePair<string, MIMEType>("rnc", ApplicationRelaxNgCompactSyntax),
new KeyValuePair<string, MIMEType>("rl", ApplicationResourceListsXml),
new KeyValuePair<string, MIMEType>("rld", ApplicationResourceListsDiffXml),
new KeyValuePair<string, MIMEType>("rs", ApplicationRlsServicesXml),
new KeyValuePair<string, MIMEType>("gbr", ApplicationRpkiGhostbusters),
new KeyValuePair<string, MIMEType>("mft", ApplicationRpkiManifest),
new KeyValuePair<string, MIMEType>("roa", ApplicationRpkiRoa),
new KeyValuePair<string, MIMEType>("rsd", ApplicationRsdXml),
new KeyValuePair<string, MIMEType>("rss", ApplicationRssXml),
new KeyValuePair<string, MIMEType>("rtf", ApplicationRtf),
new KeyValuePair<string, MIMEType>("sbml", ApplicationSbmlXml),
new KeyValuePair<string, MIMEType>("scq", ApplicationScvpCvRequest),
new KeyValuePair<string, MIMEType>("scs", ApplicationScvpCvResponse),
new KeyValuePair<string, MIMEType>("spq", ApplicationScvpVpRequest),
new KeyValuePair<string, MIMEType>("spp", ApplicationScvpVpResponse),
new KeyValuePair<string, MIMEType>("sdp", ApplicationSdp),
new KeyValuePair<string, MIMEType>("setpay", ApplicationSetPaymentInitiation),
new KeyValuePair<string, MIMEType>("setreg", ApplicationSetRegistrationInitiation),
new KeyValuePair<string, MIMEType>("shf", ApplicationShfXml),
new KeyValuePair<string, MIMEType>("smi", ApplicationSmilXml),
new KeyValuePair<string, MIMEType>("smil", ApplicationSmilXml),
new KeyValuePair<string, MIMEType>("rq", ApplicationSparqlQuery),
new KeyValuePair<string, MIMEType>("srx", ApplicationSparqlResultsXml),
new KeyValuePair<string, MIMEType>("gram", ApplicationSrgs),
new KeyValuePair<string, MIMEType>("grxml", ApplicationSrgsXml),
new KeyValuePair<string, MIMEType>("sru", ApplicationSruXml),
new KeyValuePair<string, MIMEType>("ssdl", ApplicationSsdlXml),
new KeyValuePair<string, MIMEType>("ssml", ApplicationSsmlXml),
new KeyValuePair<string, MIMEType>("tei", ApplicationTeiXml),
new KeyValuePair<string, MIMEType>("teicorpus", ApplicationTeiXml),
new KeyValuePair<string, MIMEType>("tfi", ApplicationThraudXml),
new KeyValuePair<string, MIMEType>("tsd", ApplicationTimestampedData),
new KeyValuePair<string, MIMEType>("plb", ApplicationVnd3gppPicBwLarge),
new KeyValuePair<string, MIMEType>("psb", ApplicationVnd3gppPicBwSmall),
new KeyValuePair<string, MIMEType>("pvb", ApplicationVnd3gppPicBwVar),
new KeyValuePair<string, MIMEType>("tcap", ApplicationVnd3gpp2Tcap),
new KeyValuePair<string, MIMEType>("pwn", ApplicationVnd3mPostItNotes),
new KeyValuePair<string, MIMEType>("aso", ApplicationVndAccpacSimplyAso),
new KeyValuePair<string, MIMEType>("imp", ApplicationVndAccpacSimplyImp),
new KeyValuePair<string, MIMEType>("acu", ApplicationVndAcucobol),
new KeyValuePair<string, MIMEType>("atc", ApplicationVndAcucorp),
new KeyValuePair<string, MIMEType>("acutc", ApplicationVndAcucorp),
new KeyValuePair<string, MIMEType>("air", ApplicationVndAdobeAirApplicationInstallerPackageZip),
new KeyValuePair<string, MIMEType>("fcdt", ApplicationVndAdobeFormscentralFcdt),
new KeyValuePair<string, MIMEType>("fxp", ApplicationVndAdobeFxp),
new KeyValuePair<string, MIMEType>("fxpl", ApplicationVndAdobeFxp),
new KeyValuePair<string, MIMEType>("xdp", ApplicationVndAdobeXdpXml),
new KeyValuePair<string, MIMEType>("xfdf", ApplicationVndAdobeXfdf),
new KeyValuePair<string, MIMEType>("ahead", ApplicationVndAheadSpace),
new KeyValuePair<string, MIMEType>("azf", ApplicationVndAirzipFilesecureAzf),
new KeyValuePair<string, MIMEType>("azs", ApplicationVndAirzipFilesecureAzs),
new KeyValuePair<string, MIMEType>("azw", ApplicationVndAmazonEbook),
new KeyValuePair<string, MIMEType>("acc", ApplicationVndAmericandynamicsAcc),
new KeyValuePair<string, MIMEType>("ami", ApplicationVndAmigaAmi),
new KeyValuePair<string, MIMEType>("apk", ApplicationVndAndroidPackageArchive),
new KeyValuePair<string, MIMEType>("cii", ApplicationVndAnserWebCertificateIssueInitiation),
new KeyValuePair<string, MIMEType>("fti", ApplicationVndAnserWebFundsTransferInitiation),
new KeyValuePair<string, MIMEType>("atx", ApplicationVndAntixGameComponent),
new KeyValuePair<string, MIMEType>("mpkg", ApplicationVndAppleInstallerXml),
new KeyValuePair<string, MIMEType>("m3u8", ApplicationVndAppleMpegurl),
new KeyValuePair<string, MIMEType>("swi", ApplicationVndAristanetworksSwi),
new KeyValuePair<string, MIMEType>("iota", ApplicationVndAstraeaSoftwareIota),
new KeyValuePair<string, MIMEType>("aep", ApplicationVndAudiograph),
new KeyValuePair<string, MIMEType>("mpm", ApplicationVndBlueiceMultipass),
new KeyValuePair<string, MIMEType>("bmi", ApplicationVndBmi),
new KeyValuePair<string, MIMEType>("rep", ApplicationVndBusinessobjects),
new KeyValuePair<string, MIMEType>("cdxml", ApplicationVndChemdrawXml),
new KeyValuePair<string, MIMEType>("mmd", ApplicationVndChipnutsKaraokeMmd),
new KeyValuePair<string, MIMEType>("cdy", ApplicationVndCinderella),
new KeyValuePair<string, MIMEType>("cla", ApplicationVndClaymore),
new KeyValuePair<string, MIMEType>("rp9", ApplicationVndCloantoRp9),
new KeyValuePair<string, MIMEType>("c4g", ApplicationVndClonkC4group),
new KeyValuePair<string, MIMEType>("c4d", ApplicationVndClonkC4group),
new KeyValuePair<string, MIMEType>("c4f", ApplicationVndClonkC4group),
new KeyValuePair<string, MIMEType>("c4p", ApplicationVndClonkC4group),
new KeyValuePair<string, MIMEType>("c4u", ApplicationVndClonkC4group),
new KeyValuePair<string, MIMEType>("c11amc", ApplicationVndCluetrustCartomobileConfig),
new KeyValuePair<string, MIMEType>("c11amz", ApplicationVndCluetrustCartomobileConfigPkg),
new KeyValuePair<string, MIMEType>("csp", ApplicationVndCommonspace),
new KeyValuePair<string, MIMEType>("cdbcmsg", ApplicationVndContactCmsg),
new KeyValuePair<string, MIMEType>("cmc", ApplicationVndCosmocaller),
new KeyValuePair<string, MIMEType>("clkx", ApplicationVndCrickClicker),
new KeyValuePair<string, MIMEType>("clkk", ApplicationVndCrickClickerKeyboard),
new KeyValuePair<string, MIMEType>("clkp", ApplicationVndCrickClickerPalette),
new KeyValuePair<string, MIMEType>("clkt", ApplicationVndCrickClickerTemplate),
new KeyValuePair<string, MIMEType>("clkw", ApplicationVndCrickClickerWordbank),
new KeyValuePair<string, MIMEType>("wbs", ApplicationVndCriticaltoolsWbsXml),
new KeyValuePair<string, MIMEType>("pml", ApplicationVndCtcPosml),
new KeyValuePair<string, MIMEType>("ppd", ApplicationVndCupsPpd),
new KeyValuePair<string, MIMEType>("car", ApplicationVndCurlCar),
new KeyValuePair<string, MIMEType>("pcurl", ApplicationVndCurlPcurl),
new KeyValuePair<string, MIMEType>("dart", ApplicationVndDart),
new KeyValuePair<string, MIMEType>("rdz", ApplicationVndDataVisionRdz),
new KeyValuePair<string, MIMEType>("uvf", ApplicationVndDeceData),
new KeyValuePair<string, MIMEType>("uvvf", ApplicationVndDeceData),
new KeyValuePair<string, MIMEType>("uvd", ApplicationVndDeceData),
new KeyValuePair<string, MIMEType>("uvvd", ApplicationVndDeceData),
new KeyValuePair<string, MIMEType>("uvt", ApplicationVndDeceTtmlXml),
new KeyValuePair<string, MIMEType>("uvvt", ApplicationVndDeceTtmlXml),
new KeyValuePair<string, MIMEType>("uvx", ApplicationVndDeceUnspecified),
new KeyValuePair<string, MIMEType>("uvvx", ApplicationVndDeceUnspecified),
new KeyValuePair<string, MIMEType>("uvz", ApplicationVndDeceZip),
new KeyValuePair<string, MIMEType>("uvvz", ApplicationVndDeceZip),
new KeyValuePair<string, MIMEType>("fe_launch", ApplicationVndDenovoFcselayoutLink),
new KeyValuePair<string, MIMEType>("dna", ApplicationVndDna),
new KeyValuePair<string, MIMEType>("mlp", ApplicationVndDolbyMlp),
new KeyValuePair<string, MIMEType>("dpg", ApplicationVndDpgraph),
new KeyValuePair<string, MIMEType>("dfac", ApplicationVndDreamfactory),
new KeyValuePair<string, MIMEType>("kpxx", ApplicationVndDsKeypoint),
new KeyValuePair<string, MIMEType>("ait", ApplicationVndDvbAit),
new KeyValuePair<string, MIMEType>("svc", ApplicationVndDvbService),
new KeyValuePair<string, MIMEType>("geo", ApplicationVndDynageo),
new KeyValuePair<string, MIMEType>("mag", ApplicationVndEcowinChart),
new KeyValuePair<string, MIMEType>("nml", ApplicationVndEnliven),
new KeyValuePair<string, MIMEType>("esf", ApplicationVndEpsonEsf),
new KeyValuePair<string, MIMEType>("msf", ApplicationVndEpsonMsf),
new KeyValuePair<string, MIMEType>("qam", ApplicationVndEpsonQuickanime),
new KeyValuePair<string, MIMEType>("slt", ApplicationVndEpsonSalt),
new KeyValuePair<string, MIMEType>("ssf", ApplicationVndEpsonSsf),
new KeyValuePair<string, MIMEType>("es3", ApplicationVndEszigno3Xml),
new KeyValuePair<string, MIMEType>("et3", ApplicationVndEszigno3Xml),
new KeyValuePair<string, MIMEType>("ez2", ApplicationVndEzpixAlbum),
new KeyValuePair<string, MIMEType>("ez3", ApplicationVndEzpixPackage),
new KeyValuePair<string, MIMEType>("fdf", ApplicationVndFdf),
new KeyValuePair<string, MIMEType>("mseed", ApplicationVndFdsnMseed),
new KeyValuePair<string, MIMEType>("seed", ApplicationVndFdsnSeed),
new KeyValuePair<string, MIMEType>("dataless", ApplicationVndFdsnSeed),
new KeyValuePair<string, MIMEType>("gph", ApplicationVndFlographit),
new KeyValuePair<string, MIMEType>("ftc", ApplicationVndFluxtimeClip),
new KeyValuePair<string, MIMEType>("fm", ApplicationVndFramemaker),
new KeyValuePair<string, MIMEType>("frame", ApplicationVndFramemaker),
new KeyValuePair<string, MIMEType>("maker", ApplicationVndFramemaker),
new KeyValuePair<string, MIMEType>("book", ApplicationVndFramemaker),
new KeyValuePair<string, MIMEType>("fnc", ApplicationVndFrogansFnc),
new KeyValuePair<string, MIMEType>("ltf", ApplicationVndFrogansLtf),
new KeyValuePair<string, MIMEType>("fsc", ApplicationVndFscWeblaunch),
new KeyValuePair<string, MIMEType>("oas", ApplicationVndFujitsuOasys),
new KeyValuePair<string, MIMEType>("oa2", ApplicationVndFujitsuOasys2),
new KeyValuePair<string, MIMEType>("oa3", ApplicationVndFujitsuOasys3),
new KeyValuePair<string, MIMEType>("fg5", ApplicationVndFujitsuOasysgp),
new KeyValuePair<string, MIMEType>("bh2", ApplicationVndFujitsuOasysprs),
new KeyValuePair<string, MIMEType>("ddd", ApplicationVndFujixeroxDdd),
new KeyValuePair<string, MIMEType>("xdw", ApplicationVndFujixeroxDocuworks),
new KeyValuePair<string, MIMEType>("xbd", ApplicationVndFujixeroxDocuworksBinder),
new KeyValuePair<string, MIMEType>("fzs", ApplicationVndFuzzysheet),
new KeyValuePair<string, MIMEType>("txd", ApplicationVndGenomatixTuxedo),
new KeyValuePair<string, MIMEType>("ggb", ApplicationVndGeogebraFile),
new KeyValuePair<string, MIMEType>("ggt", ApplicationVndGeogebraTool),
new KeyValuePair<string, MIMEType>("gex", ApplicationVndGeometryExplorer),
new KeyValuePair<string, MIMEType>("gre", ApplicationVndGeometryExplorer),
new KeyValuePair<string, MIMEType>("gxt", ApplicationVndGeonext),
new KeyValuePair<string, MIMEType>("g2w", ApplicationVndGeoplan),
new KeyValuePair<string, MIMEType>("g3w", ApplicationVndGeospace),
new KeyValuePair<string, MIMEType>("gmx", ApplicationVndGmx),
new KeyValuePair<string, MIMEType>("kml", ApplicationVndGoogleEarthKmlXml),
new KeyValuePair<string, MIMEType>("kmz", ApplicationVndGoogleEarthKmz),
new KeyValuePair<string, MIMEType>("gqf", ApplicationVndGrafeq),
new KeyValuePair<string, MIMEType>("gqs", ApplicationVndGrafeq),
new KeyValuePair<string, MIMEType>("gac", ApplicationVndGrooveAccount),
new KeyValuePair<string, MIMEType>("ghf", ApplicationVndGrooveHelp),
new KeyValuePair<string, MIMEType>("gim", ApplicationVndGrooveIdentityMessage),
new KeyValuePair<string, MIMEType>("grv", ApplicationVndGrooveInjector),
new KeyValuePair<string, MIMEType>("gtm", ApplicationVndGrooveToolMessage),
new KeyValuePair<string, MIMEType>("tpl", ApplicationVndGrooveToolTemplate),
new KeyValuePair<string, MIMEType>("vcg", ApplicationVndGrooveVcard),
new KeyValuePair<string, MIMEType>("hal", ApplicationVndHalXml),
new KeyValuePair<string, MIMEType>("zmm", ApplicationVndHandheldEntertainmentXml),
new KeyValuePair<string, MIMEType>("hbci", ApplicationVndHbci),
new KeyValuePair<string, MIMEType>("les", ApplicationVndHheLessonPlayer),
new KeyValuePair<string, MIMEType>("hpgl", ApplicationVndHpHpgl),
new KeyValuePair<string, MIMEType>("hpid", ApplicationVndHpHpid),
new KeyValuePair<string, MIMEType>("hps", ApplicationVndHpHps),
new KeyValuePair<string, MIMEType>("jlt", ApplicationVndHpJlyt),
new KeyValuePair<string, MIMEType>("pcl", ApplicationVndHpPcl),
new KeyValuePair<string, MIMEType>("pclxl", ApplicationVndHpPclxl),
new KeyValuePair<string, MIMEType>("sfd-hdstx", ApplicationVndHydrostatixSofData),
new KeyValuePair<string, MIMEType>("mpy", ApplicationVndIbmMinipay),
new KeyValuePair<string, MIMEType>("afp", ApplicationVndIbmModcap),
new KeyValuePair<string, MIMEType>("listafp", ApplicationVndIbmModcap),
new KeyValuePair<string, MIMEType>("list3820", ApplicationVndIbmModcap),
new KeyValuePair<string, MIMEType>("irm", ApplicationVndIbmRightsManagement),
new KeyValuePair<string, MIMEType>("sc", ApplicationVndIbmSecureContainer),
new KeyValuePair<string, MIMEType>("icc", ApplicationVndIccprofile),
new KeyValuePair<string, MIMEType>("icm", ApplicationVndIccprofile),
new KeyValuePair<string, MIMEType>("igl", ApplicationVndIgloader),
new KeyValuePair<string, MIMEType>("ivp", ApplicationVndImmervisionIvp),
new KeyValuePair<string, MIMEType>("ivu", ApplicationVndImmervisionIvu),
new KeyValuePair<string, MIMEType>("igm", ApplicationVndInsorsIgm),
new KeyValuePair<string, MIMEType>("xpw", ApplicationVndInterconFormnet),
new KeyValuePair<string, MIMEType>("xpx", ApplicationVndInterconFormnet),
new KeyValuePair<string, MIMEType>("i2g", ApplicationVndIntergeo),
new KeyValuePair<string, MIMEType>("qbo", ApplicationVndIntuQbo),
new KeyValuePair<string, MIMEType>("qfx", ApplicationVndIntuQfx),
new KeyValuePair<string, MIMEType>("rcprofile", ApplicationVndIpunpluggedRcprofile),
new KeyValuePair<string, MIMEType>("irp", ApplicationVndIrepositoryPackageXml),
new KeyValuePair<string, MIMEType>("xpr", ApplicationVndIsXpr),
new KeyValuePair<string, MIMEType>("fcs", ApplicationVndIsacFcs),
new KeyValuePair<string, MIMEType>("jam", ApplicationVndJam),
new KeyValuePair<string, MIMEType>("rms", ApplicationVndJcpJavameMidletRms),
new KeyValuePair<string, MIMEType>("jisp", ApplicationVndJisp),
new KeyValuePair<string, MIMEType>("joda", ApplicationVndJoostJodaArchive),
new KeyValuePair<string, MIMEType>("ktz", ApplicationVndKahootz),
new KeyValuePair<string, MIMEType>("ktr", ApplicationVndKahootz),
new KeyValuePair<string, MIMEType>("karbon", ApplicationVndKdeKarbon),
new KeyValuePair<string, MIMEType>("chrt", ApplicationVndKdeKchart),
new KeyValuePair<string, MIMEType>("kfo", ApplicationVndKdeKformula),
new KeyValuePair<string, MIMEType>("flw", ApplicationVndKdeKivio),
new KeyValuePair<string, MIMEType>("kon", ApplicationVndKdeKontour),
new KeyValuePair<string, MIMEType>("kpr", ApplicationVndKdeKpresenter),
new KeyValuePair<string, MIMEType>("kpt", ApplicationVndKdeKpresenter),
new KeyValuePair<string, MIMEType>("ksp", ApplicationVndKdeKspread),
new KeyValuePair<string, MIMEType>("kwd", ApplicationVndKdeKword),
new KeyValuePair<string, MIMEType>("kwt", ApplicationVndKdeKword),
new KeyValuePair<string, MIMEType>("htke", ApplicationVndKenameaapp),
new KeyValuePair<string, MIMEType>("kia", ApplicationVndKidspiration),
new KeyValuePair<string, MIMEType>("kne", ApplicationVndKinar),
new KeyValuePair<string, MIMEType>("knp", ApplicationVndKinar),
new KeyValuePair<string, MIMEType>("skp", ApplicationVndKoan),
new KeyValuePair<string, MIMEType>("skd", ApplicationVndKoan),
new KeyValuePair<string, MIMEType>("skt", ApplicationVndKoan),
new KeyValuePair<string, MIMEType>("skm", ApplicationVndKoan),
new KeyValuePair<string, MIMEType>("sse", ApplicationVndKodakDescriptor),
new KeyValuePair<string, MIMEType>("lasxml", ApplicationVndLasLasXml),
new KeyValuePair<string, MIMEType>("lbd", ApplicationVndLlamagraphicsLifeBalanceDesktop),
new KeyValuePair<string, MIMEType>("lbe", ApplicationVndLlamagraphicsLifeBalanceExchangeXml),
new KeyValuePair<string, MIMEType>("123", ApplicationVndLotus123),
new KeyValuePair<string, MIMEType>("apr", ApplicationVndLotusApproach),
new KeyValuePair<string, MIMEType>("pre", ApplicationVndLotusFreelance),
new KeyValuePair<string, MIMEType>("nsf", ApplicationVndLotusNotes),
new KeyValuePair<string, MIMEType>("org", ApplicationVndLotusOrganizer),
new KeyValuePair<string, MIMEType>("scm", ApplicationVndLotusScreencam),
new KeyValuePair<string, MIMEType>("lwp", ApplicationVndLotusWordpro),
new KeyValuePair<string, MIMEType>("portpkg", ApplicationVndMacportsPortpkg),
new KeyValuePair<string, MIMEType>("mcd", ApplicationVndMcd),
new KeyValuePair<string, MIMEType>("mc1", ApplicationVndMedcalcdata),
new KeyValuePair<string, MIMEType>("cdkey", ApplicationVndMediastationCdkey),
new KeyValuePair<string, MIMEType>("mwf", ApplicationVndMfer),
new KeyValuePair<string, MIMEType>("mfm", ApplicationVndMfmp),
new KeyValuePair<string, MIMEType>("flo", ApplicationVndMicrografxFlo),
new KeyValuePair<string, MIMEType>("igx", ApplicationVndMicrografxIgx),
new KeyValuePair<string, MIMEType>("mif", ApplicationVndMif),
new KeyValuePair<string, MIMEType>("daf", ApplicationVndMobiusDaf),
new KeyValuePair<string, MIMEType>("dis", ApplicationVndMobiusDis),
new KeyValuePair<string, MIMEType>("mbk", ApplicationVndMobiusMbk),
new KeyValuePair<string, MIMEType>("mqy", ApplicationVndMobiusMqy),
new KeyValuePair<string, MIMEType>("msl", ApplicationVndMobiusMsl),
new KeyValuePair<string, MIMEType>("plc", ApplicationVndMobiusPlc),
new KeyValuePair<string, MIMEType>("txf", ApplicationVndMobiusTxf),
new KeyValuePair<string, MIMEType>("mpn", ApplicationVndMophunApplication),
new KeyValuePair<string, MIMEType>("mpc", ApplicationVndMophunCertificate),
new KeyValuePair<string, MIMEType>("xul", ApplicationVndMozillaXulXml),
new KeyValuePair<string, MIMEType>("cil", ApplicationVndMsArtgalry),
new KeyValuePair<string, MIMEType>("cab", ApplicationVndMsCabCompressed),
new KeyValuePair<string, MIMEType>("xls", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("xlm", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("xla", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("xlc", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("xlt", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("xlw", ApplicationVndMsExcel),
new KeyValuePair<string, MIMEType>("xlam", ApplicationVndMsExcelAddinMacroenabled12),
new KeyValuePair<string, MIMEType>("xlsb", ApplicationVndMsExcelSheetBinaryMacroenabled12),
new KeyValuePair<string, MIMEType>("xlsm", ApplicationVndMsExcelSheetMacroenabled12),
new KeyValuePair<string, MIMEType>("xltm", ApplicationVndMsExcelTemplateMacroenabled12),
new KeyValuePair<string, MIMEType>("eot", ApplicationVndMsFontobject),
new KeyValuePair<string, MIMEType>("chm", ApplicationVndMsHtmlhelp),
new KeyValuePair<string, MIMEType>("ims", ApplicationVndMsIms),
new KeyValuePair<string, MIMEType>("lrm", ApplicationVndMsLrm),
new KeyValuePair<string, MIMEType>("thmx", ApplicationVndMsOfficetheme),
new KeyValuePair<string, MIMEType>("cat", ApplicationVndMsPkiSeccat),
new KeyValuePair<string, MIMEType>("stl", ApplicationVndMsPkiStl),
new KeyValuePair<string, MIMEType>("ppt", ApplicationVndMsPowerpoint),
new KeyValuePair<string, MIMEType>("pps", ApplicationVndMsPowerpoint),
new KeyValuePair<string, MIMEType>("pot", ApplicationVndMsPowerpoint),
new KeyValuePair<string, MIMEType>("ppam", ApplicationVndMsPowerpointAddinMacroenabled12),
new KeyValuePair<string, MIMEType>("pptm", ApplicationVndMsPowerpointPresentationMacroenabled12),
new KeyValuePair<string, MIMEType>("sldm", ApplicationVndMsPowerpointSlideMacroenabled12),
new KeyValuePair<string, MIMEType>("ppsm", ApplicationVndMsPowerpointSlideshowMacroenabled12),
new KeyValuePair<string, MIMEType>("potm", ApplicationVndMsPowerpointTemplateMacroenabled12),
new KeyValuePair<string, MIMEType>("mpp", ApplicationVndMsProject),
new KeyValuePair<string, MIMEType>("mpt", ApplicationVndMsProject),
new KeyValuePair<string, MIMEType>("docm", ApplicationVndMsWordDocumentMacroenabled12),
new KeyValuePair<string, MIMEType>("dotm", ApplicationVndMsWordTemplateMacroenabled12),
new KeyValuePair<string, MIMEType>("wps", ApplicationVndMsWorks),
new KeyValuePair<string, MIMEType>("wks", ApplicationVndMsWorks),
new KeyValuePair<string, MIMEType>("wcm", ApplicationVndMsWorks),
new KeyValuePair<string, MIMEType>("wdb", ApplicationVndMsWorks),
new KeyValuePair<string, MIMEType>("wpl", ApplicationVndMsWpl),
new KeyValuePair<string, MIMEType>("xps", ApplicationVndMsXpsdocument),
new KeyValuePair<string, MIMEType>("mseq", ApplicationVndMseq),
new KeyValuePair<string, MIMEType>("mus", ApplicationVndMusician),
new KeyValuePair<string, MIMEType>("msty", ApplicationVndMuveeStyle),
new KeyValuePair<string, MIMEType>("taglet", ApplicationVndMynfc),
new KeyValuePair<string, MIMEType>("nlu", ApplicationVndNeurolanguageNlu),
new KeyValuePair<string, MIMEType>("ntf", ApplicationVndNitf),
new KeyValuePair<string, MIMEType>("nitf", ApplicationVndNitf),
new KeyValuePair<string, MIMEType>("nnd", ApplicationVndNoblenetDirectory),
new KeyValuePair<string, MIMEType>("nns", ApplicationVndNoblenetSealer),
new KeyValuePair<string, MIMEType>("nnw", ApplicationVndNoblenetWeb),
new KeyValuePair<string, MIMEType>("ngdat", ApplicationVndNokiaNGageData),
new KeyValuePair<string, MIMEType>("n-gage", ApplicationVndNokiaNGageSymbianInstall),
new KeyValuePair<string, MIMEType>("rpst", ApplicationVndNokiaRadioPreset),
new KeyValuePair<string, MIMEType>("rpss", ApplicationVndNokiaRadioPresets),
new KeyValuePair<string, MIMEType>("edm", ApplicationVndNovadigmEdm),
new KeyValuePair<string, MIMEType>("edx", ApplicationVndNovadigmEdx),
new KeyValuePair<string, MIMEType>("ext", ApplicationVndNovadigmExt),
new KeyValuePair<string, MIMEType>("odc", ApplicationVndOasisOpendocumentChart),
new KeyValuePair<string, MIMEType>("otc", ApplicationVndOasisOpendocumentChartTemplate),
new KeyValuePair<string, MIMEType>("odb", ApplicationVndOasisOpendocumentDatabase),
new KeyValuePair<string, MIMEType>("odf", ApplicationVndOasisOpendocumentFormula),
new KeyValuePair<string, MIMEType>("odft", ApplicationVndOasisOpendocumentFormulaTemplate),
new KeyValuePair<string, MIMEType>("odg", ApplicationVndOasisOpendocumentGraphics),
new KeyValuePair<string, MIMEType>("otg", ApplicationVndOasisOpendocumentGraphicsTemplate),
new KeyValuePair<string, MIMEType>("odi", ApplicationVndOasisOpendocumentImage),
new KeyValuePair<string, MIMEType>("oti", ApplicationVndOasisOpendocumentImageTemplate),
new KeyValuePair<string, MIMEType>("odp", ApplicationVndOasisOpendocumentPresentation),
new KeyValuePair<string, MIMEType>("otp", ApplicationVndOasisOpendocumentPresentationTemplate),
new KeyValuePair<string, MIMEType>("ods", ApplicationVndOasisOpendocumentSpreadsheet),
new KeyValuePair<string, MIMEType>("ots", ApplicationVndOasisOpendocumentSpreadsheetTemplate),
new KeyValuePair<string, MIMEType>("odt", ApplicationVndOasisOpendocumentText),
new KeyValuePair<string, MIMEType>("odm", ApplicationVndOasisOpendocumentTextMaster),
new KeyValuePair<string, MIMEType>("ott", ApplicationVndOasisOpendocumentTextTemplate),
new KeyValuePair<string, MIMEType>("oth", ApplicationVndOasisOpendocumentTextWeb),
new KeyValuePair<string, MIMEType>("xo", ApplicationVndOlpcSugar),
new KeyValuePair<string, MIMEType>("dd2", ApplicationVndOmaDd2Xml),
new KeyValuePair<string, MIMEType>("oxt", ApplicationVndOpenofficeorgExtension),
new KeyValuePair<string, MIMEType>("pptx", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation),
new KeyValuePair<string, MIMEType>("sldx", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlSlide),
new KeyValuePair<string, MIMEType>("ppsx", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlSlideshow),
new KeyValuePair<string, MIMEType>("potx", ApplicationVndOpenxmlformatsOfficedocumentPresentationmlTemplate),
new KeyValuePair<string, MIMEType>("xlsx", ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet),
new KeyValuePair<string, MIMEType>("xltx", ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlTemplate),
new KeyValuePair<string, MIMEType>("docx", ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument),
new KeyValuePair<string, MIMEType>("dotx", ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlTemplate),
new KeyValuePair<string, MIMEType>("mgp", ApplicationVndOsgeoMapguidePackage),
new KeyValuePair<string, MIMEType>("dp", ApplicationVndOsgiDp),
new KeyValuePair<string, MIMEType>("esa", ApplicationVndOsgiSubsystem),
new KeyValuePair<string, MIMEType>("pdb", ApplicationVndPalm),
new KeyValuePair<string, MIMEType>("pqa", ApplicationVndPalm),
new KeyValuePair<string, MIMEType>("oprc", ApplicationVndPalm),
new KeyValuePair<string, MIMEType>("paw", ApplicationVndPawaafile),
new KeyValuePair<string, MIMEType>("str", ApplicationVndPgFormat),
new KeyValuePair<string, MIMEType>("ei6", ApplicationVndPgOsasli),
new KeyValuePair<string, MIMEType>("efif", ApplicationVndPicsel),
new KeyValuePair<string, MIMEType>("wg", ApplicationVndPmiWidget),
new KeyValuePair<string, MIMEType>("plf", ApplicationVndPocketlearn),
new KeyValuePair<string, MIMEType>("pbd", ApplicationVndPowerbuilder6),
new KeyValuePair<string, MIMEType>("box", ApplicationVndPreviewsystemsBox),
new KeyValuePair<string, MIMEType>("mgz", ApplicationVndProteusMagazine),
new KeyValuePair<string, MIMEType>("qps", ApplicationVndPublishareDeltaTree),
new KeyValuePair<string, MIMEType>("ptid", ApplicationVndPviPtid1),
new KeyValuePair<string, MIMEType>("qxd", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("qxt", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("qwd", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("qwt", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("qxl", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("qxb", ApplicationVndQuarkQuarkxpress),
new KeyValuePair<string, MIMEType>("bed", ApplicationVndRealvncBed),
new KeyValuePair<string, MIMEType>("mxl", ApplicationVndRecordareMusicxml),
new KeyValuePair<string, MIMEType>("musicxml", ApplicationVndRecordareMusicxmlXml),
new KeyValuePair<string, MIMEType>("cryptonote", ApplicationVndRigCryptonote),
new KeyValuePair<string, MIMEType>("cod", ApplicationVndRimCod),
new KeyValuePair<string, MIMEType>("rm", ApplicationVndRnRealmedia),
new KeyValuePair<string, MIMEType>("rmvb", ApplicationVndRnRealmediaVbr),
new KeyValuePair<string, MIMEType>("link66", ApplicationVndRoute66Link66Xml),
new KeyValuePair<string, MIMEType>("st", ApplicationVndSailingtrackerTrack),
new KeyValuePair<string, MIMEType>("see", ApplicationVndSeemail),
new KeyValuePair<string, MIMEType>("sema", ApplicationVndSema),
new KeyValuePair<string, MIMEType>("semd", ApplicationVndSemd),
new KeyValuePair<string, MIMEType>("semf", ApplicationVndSemf),
new KeyValuePair<string, MIMEType>("ifm", ApplicationVndShanaInformedFormdata),
new KeyValuePair<string, MIMEType>("itp", ApplicationVndShanaInformedFormtemplate),
new KeyValuePair<string, MIMEType>("iif", ApplicationVndShanaInformedInterchange),
new KeyValuePair<string, MIMEType>("ipk", ApplicationVndShanaInformedPackage),
new KeyValuePair<string, MIMEType>("twd", ApplicationVndSimtechMindmapper),
new KeyValuePair<string, MIMEType>("twds", ApplicationVndSimtechMindmapper),
new KeyValuePair<string, MIMEType>("mmf", ApplicationVndSmaf),
new KeyValuePair<string, MIMEType>("teacher", ApplicationVndSmartTeacher),
new KeyValuePair<string, MIMEType>("sdkm", ApplicationVndSolentSdkmXml),
new KeyValuePair<string, MIMEType>("sdkd", ApplicationVndSolentSdkmXml),
new KeyValuePair<string, MIMEType>("dxp", ApplicationVndSpotfireDxp),
new KeyValuePair<string, MIMEType>("sfs", ApplicationVndSpotfireSfs),
new KeyValuePair<string, MIMEType>("sdc", ApplicationVndStardivisionCalc),
new KeyValuePair<string, MIMEType>("sda", ApplicationVndStardivisionDraw),
new KeyValuePair<string, MIMEType>("sdd", ApplicationVndStardivisionImpress),
new KeyValuePair<string, MIMEType>("smf", ApplicationVndStardivisionMath),
new KeyValuePair<string, MIMEType>("sdw", ApplicationVndStardivisionWriter),
new KeyValuePair<string, MIMEType>("vor", ApplicationVndStardivisionWriter),
new KeyValuePair<string, MIMEType>("sgl", ApplicationVndStardivisionWriterGlobal),
new KeyValuePair<string, MIMEType>("smzip", ApplicationVndStepmaniaPackage),
new KeyValuePair<string, MIMEType>("sm", ApplicationVndStepmaniaStepchart),
new KeyValuePair<string, MIMEType>("sxc", ApplicationVndSunXmlCalc),
new KeyValuePair<string, MIMEType>("stc", ApplicationVndSunXmlCalcTemplate),
new KeyValuePair<string, MIMEType>("sxd", ApplicationVndSunXmlDraw),
new KeyValuePair<string, MIMEType>("std", ApplicationVndSunXmlDrawTemplate),
new KeyValuePair<string, MIMEType>("sxi", ApplicationVndSunXmlImpress),
new KeyValuePair<string, MIMEType>("sti", ApplicationVndSunXmlImpressTemplate),
new KeyValuePair<string, MIMEType>("sxm", ApplicationVndSunXmlMath),
new KeyValuePair<string, MIMEType>("sxw", ApplicationVndSunXmlWriter),
new KeyValuePair<string, MIMEType>("sxg", ApplicationVndSunXmlWriterGlobal),
new KeyValuePair<string, MIMEType>("stw", ApplicationVndSunXmlWriterTemplate),
new KeyValuePair<string, MIMEType>("sus", ApplicationVndSusCalendar),
new KeyValuePair<string, MIMEType>("susp", ApplicationVndSusCalendar),
new KeyValuePair<string, MIMEType>("svd", ApplicationVndSvd),
new KeyValuePair<string, MIMEType>("sis", ApplicationVndSymbianInstall),
new KeyValuePair<string, MIMEType>("sisx", ApplicationVndSymbianInstall),
new KeyValuePair<string, MIMEType>("xsm", ApplicationVndSyncmlXml),
new KeyValuePair<string, MIMEType>("bdm", ApplicationVndSyncmlDmWbxml),
new KeyValuePair<string, MIMEType>("xdm", ApplicationVndSyncmlDmXml),
new KeyValuePair<string, MIMEType>("tao", ApplicationVndTaoIntentModuleArchive),
new KeyValuePair<string, MIMEType>("pcap", ApplicationVndTcpdumpPcap),
new KeyValuePair<string, MIMEType>("cap", ApplicationVndTcpdumpPcap),
new KeyValuePair<string, MIMEType>("dmp", ApplicationVndTcpdumpPcap),
new KeyValuePair<string, MIMEType>("tmo", ApplicationVndTmobileLivetv),
new KeyValuePair<string, MIMEType>("tpt", ApplicationVndTridTpt),
new KeyValuePair<string, MIMEType>("mxs", ApplicationVndTriscapeMxs),
new KeyValuePair<string, MIMEType>("tra", ApplicationVndTrueapp),
new KeyValuePair<string, MIMEType>("ufd", ApplicationVndUfdl),
new KeyValuePair<string, MIMEType>("ufdl", ApplicationVndUfdl),
new KeyValuePair<string, MIMEType>("utz", ApplicationVndUiqTheme),
new KeyValuePair<string, MIMEType>("umj", ApplicationVndUmajin),
new KeyValuePair<string, MIMEType>("unityweb", ApplicationVndUnity),
new KeyValuePair<string, MIMEType>("uoml", ApplicationVndUomlXml),
new KeyValuePair<string, MIMEType>("vcx", ApplicationVndVcx),
new KeyValuePair<string, MIMEType>("vsd", ApplicationVndVisio),
new KeyValuePair<string, MIMEType>("vst", ApplicationVndVisio),
new KeyValuePair<string, MIMEType>("vss", ApplicationVndVisio),
new KeyValuePair<string, MIMEType>("vsw", ApplicationVndVisio),
new KeyValuePair<string, MIMEType>("vis", ApplicationVndVisionary),
new KeyValuePair<string, MIMEType>("vsf", ApplicationVndVsf),
new KeyValuePair<string, MIMEType>("wbxml", ApplicationVndWapWbxml),
new KeyValuePair<string, MIMEType>("wmlc", ApplicationVndWapWmlc),
new KeyValuePair<string, MIMEType>("wmlsc", ApplicationVndWapWmlscriptc),
new KeyValuePair<string, MIMEType>("wtb", ApplicationVndWebturbo),
new KeyValuePair<string, MIMEType>("nbp", ApplicationVndWolframPlayer),
new KeyValuePair<string, MIMEType>("wpd", ApplicationVndWordperfect),
new KeyValuePair<string, MIMEType>("wqd", ApplicationVndWqd),
new KeyValuePair<string, MIMEType>("stf", ApplicationVndWtStf),
new KeyValuePair<string, MIMEType>("xar", ApplicationVndXara),
new KeyValuePair<string, MIMEType>("xfdl", ApplicationVndXfdl),
new KeyValuePair<string, MIMEType>("hvd", ApplicationVndYamahaHvDic),
new KeyValuePair<string, MIMEType>("hvs", ApplicationVndYamahaHvScript),
new KeyValuePair<string, MIMEType>("hvp", ApplicationVndYamahaHvVoice),
new KeyValuePair<string, MIMEType>("osf", ApplicationVndYamahaOpenscoreformat),
new KeyValuePair<string, MIMEType>("osfpvg", ApplicationVndYamahaOpenscoreformatOsfpvgXml),
new KeyValuePair<string, MIMEType>("saf", ApplicationVndYamahaSmafAudio),
new KeyValuePair<string, MIMEType>("spf", ApplicationVndYamahaSmafPhrase),
new KeyValuePair<string, MIMEType>("cmp", ApplicationVndYellowriverCustomMenu),
new KeyValuePair<string, MIMEType>("zir", ApplicationVndZul),
new KeyValuePair<string, MIMEType>("zirz", ApplicationVndZul),
new KeyValuePair<string, MIMEType>("zaz", ApplicationVndZzazzDeckXml),
new KeyValuePair<string, MIMEType>("vxml", ApplicationVoicexmlXml),
new KeyValuePair<string, MIMEType>("wgt", ApplicationWidget),
new KeyValuePair<string, MIMEType>("hlp", ApplicationWinhlp),
new KeyValuePair<string, MIMEType>("wsdl", ApplicationWsdlXml),
new KeyValuePair<string, MIMEType>("wspolicy", ApplicationWspolicyXml),
new KeyValuePair<string, MIMEType>("7z", ApplicationX7zCompressed),
new KeyValuePair<string, MIMEType>("abw", ApplicationXAbiword),
new KeyValuePair<string, MIMEType>("ace", ApplicationXAceCompressed),
new KeyValuePair<string, MIMEType>("dmg", ApplicationXAppleDiskimage),
new KeyValuePair<string, MIMEType>("aab", ApplicationXAuthorwareBin),
new KeyValuePair<string, MIMEType>("x32", ApplicationXAuthorwareBin),
new KeyValuePair<string, MIMEType>("u32", ApplicationXAuthorwareBin),
new KeyValuePair<string, MIMEType>("vox", ApplicationXAuthorwareBin),
new KeyValuePair<string, MIMEType>("aam", ApplicationXAuthorwareMap),
new KeyValuePair<string, MIMEType>("aas", ApplicationXAuthorwareSeg),
new KeyValuePair<string, MIMEType>("bcpio", ApplicationXBcpio),
new KeyValuePair<string, MIMEType>("torrent", ApplicationXBittorrent),
new KeyValuePair<string, MIMEType>("blb", ApplicationXBlorb),
new KeyValuePair<string, MIMEType>("blorb", ApplicationXBlorb),
new KeyValuePair<string, MIMEType>("bz", ApplicationXBzip),
new KeyValuePair<string, MIMEType>("bz2", ApplicationXBzip2),
new KeyValuePair<string, MIMEType>("boz", ApplicationXBzip2),
new KeyValuePair<string, MIMEType>("cbr", ApplicationXCbr),
new KeyValuePair<string, MIMEType>("cba", ApplicationXCbr),
new KeyValuePair<string, MIMEType>("cbt", ApplicationXCbr),
new KeyValuePair<string, MIMEType>("cbz", ApplicationXCbr),
new KeyValuePair<string, MIMEType>("cb7", ApplicationXCbr),
new KeyValuePair<string, MIMEType>("vcd", ApplicationXCdlink),
new KeyValuePair<string, MIMEType>("cfs", ApplicationXCfsCompressed),
new KeyValuePair<string, MIMEType>("chat", ApplicationXChat),
new KeyValuePair<string, MIMEType>("pgn", ApplicationXChessPgn),
new KeyValuePair<string, MIMEType>("nsc", ApplicationXConference),
new KeyValuePair<string, MIMEType>("cpio", ApplicationXCpio),
new KeyValuePair<string, MIMEType>("csh", ApplicationXCsh),
new KeyValuePair<string, MIMEType>("deb", ApplicationXDebianPackage),
new KeyValuePair<string, MIMEType>("udeb", ApplicationXDebianPackage),
new KeyValuePair<string, MIMEType>("dgc", ApplicationXDgcCompressed),
new KeyValuePair<string, MIMEType>("dir", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("dcr", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("dxr", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("cst", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("cct", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("cxt", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("w3d", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("fgd", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("swa", ApplicationXDirector),
new KeyValuePair<string, MIMEType>("wad", ApplicationXDoom),
new KeyValuePair<string, MIMEType>("ncx", ApplicationXDtbncxXml),
new KeyValuePair<string, MIMEType>("dtb", ApplicationXDtbookXml),
new KeyValuePair<string, MIMEType>("res", ApplicationXDtbresourceXml),
new KeyValuePair<string, MIMEType>("dvi", ApplicationXDvi),
new KeyValuePair<string, MIMEType>("evy", ApplicationXEnvoy),
new KeyValuePair<string, MIMEType>("eva", ApplicationXEva),
new KeyValuePair<string, MIMEType>("bdf", ApplicationXFontBdf),
new KeyValuePair<string, MIMEType>("gsf", ApplicationXFontGhostscript),
new KeyValuePair<string, MIMEType>("psf", ApplicationXFontLinuxPsf),
new KeyValuePair<string, MIMEType>("otf", ApplicationXFontOtf),
new KeyValuePair<string, MIMEType>("pcf", ApplicationXFontPcf),
new KeyValuePair<string, MIMEType>("snf", ApplicationXFontSnf),
new KeyValuePair<string, MIMEType>("ttf", ApplicationXFontTtf),
new KeyValuePair<string, MIMEType>("ttc", ApplicationXFontTtf),
new KeyValuePair<string, MIMEType>("pfa", ApplicationXFontType1),
new KeyValuePair<string, MIMEType>("pfb", ApplicationXFontType1),
new KeyValuePair<string, MIMEType>("pfm", ApplicationXFontType1),
new KeyValuePair<string, MIMEType>("afm", ApplicationXFontType1),
new KeyValuePair<string, MIMEType>("woff", ApplicationXFontWoff),
new KeyValuePair<string, MIMEType>("arc", ApplicationXFreearc),
new KeyValuePair<string, MIMEType>("spl", ApplicationXFuturesplash),
new KeyValuePair<string, MIMEType>("gca", ApplicationXGcaCompressed),
new KeyValuePair<string, MIMEType>("ulx", ApplicationXGlulx),
new KeyValuePair<string, MIMEType>("gnumeric", ApplicationXGnumeric),
new KeyValuePair<string, MIMEType>("gramps", ApplicationXGrampsXml),
new KeyValuePair<string, MIMEType>("gtar", ApplicationXGtar),
new KeyValuePair<string, MIMEType>("hdf", ApplicationXHdf),
new KeyValuePair<string, MIMEType>("install", ApplicationXInstallInstructions),
new KeyValuePair<string, MIMEType>("iso", ApplicationXIso9660Image),
new KeyValuePair<string, MIMEType>("jnlp", ApplicationXJavaJnlpFile),
new KeyValuePair<string, MIMEType>("latex", ApplicationXLatex),
new KeyValuePair<string, MIMEType>("lzh", ApplicationXLzhCompressed),
new KeyValuePair<string, MIMEType>("lha", ApplicationXLzhCompressed),
new KeyValuePair<string, MIMEType>("mie", ApplicationXMie),
new KeyValuePair<string, MIMEType>("prc", ApplicationXMobipocketEbook),
new KeyValuePair<string, MIMEType>("mobi", ApplicationXMobipocketEbook),
new KeyValuePair<string, MIMEType>("application", ApplicationXMsApplication),
new KeyValuePair<string, MIMEType>("lnk", ApplicationXMsShortcut),
new KeyValuePair<string, MIMEType>("wmd", ApplicationXMsWmd),
new KeyValuePair<string, MIMEType>("wmz", ApplicationXMsWmz),
new KeyValuePair<string, MIMEType>("xbap", ApplicationXMsXbap),
new KeyValuePair<string, MIMEType>("mdb", ApplicationXMsaccess),
new KeyValuePair<string, MIMEType>("obd", ApplicationXMsbinder),
new KeyValuePair<string, MIMEType>("crd", ApplicationXMscardfile),
new KeyValuePair<string, MIMEType>("clp", ApplicationXMsclip),
new KeyValuePair<string, MIMEType>("exe", ApplicationXMsdownload),
new KeyValuePair<string, MIMEType>("dll", ApplicationXMsdownload),
new KeyValuePair<string, MIMEType>("com", ApplicationXMsdownload),
new KeyValuePair<string, MIMEType>("bat", ApplicationXMsdownload),
new KeyValuePair<string, MIMEType>("msi", ApplicationXMsdownload),
new KeyValuePair<string, MIMEType>("mvb", ApplicationXMsmediaview),
new KeyValuePair<string, MIMEType>("m13", ApplicationXMsmediaview),
new KeyValuePair<string, MIMEType>("m14", ApplicationXMsmediaview),
new KeyValuePair<string, MIMEType>("wmf", ApplicationXMsmetafile),
new KeyValuePair<string, MIMEType>("wmz", ApplicationXMsmetafile),
new KeyValuePair<string, MIMEType>("emf", ApplicationXMsmetafile),
new KeyValuePair<string, MIMEType>("emz", ApplicationXMsmetafile),
new KeyValuePair<string, MIMEType>("mny", ApplicationXMsmoney),
new KeyValuePair<string, MIMEType>("pub", ApplicationXMspublisher),
new KeyValuePair<string, MIMEType>("scd", ApplicationXMsschedule),
new KeyValuePair<string, MIMEType>("trm", ApplicationXMsterminal),
new KeyValuePair<string, MIMEType>("wri", ApplicationXMswrite),
new KeyValuePair<string, MIMEType>("nc", ApplicationXNetcdf),
new KeyValuePair<string, MIMEType>("cdf", ApplicationXNetcdf),
new KeyValuePair<string, MIMEType>("nzb", ApplicationXNzb),
new KeyValuePair<string, MIMEType>("p12", ApplicationXPkcs12),
new KeyValuePair<string, MIMEType>("pfx", ApplicationXPkcs12),
new KeyValuePair<string, MIMEType>("p7b", ApplicationXPkcs7Certificates),
new KeyValuePair<string, MIMEType>("spc", ApplicationXPkcs7Certificates),
new KeyValuePair<string, MIMEType>("p7r", ApplicationXPkcs7Certreqresp),
new KeyValuePair<string, MIMEType>("rar", ApplicationXRarCompressed),
new KeyValuePair<string, MIMEType>("ris", ApplicationXResearchInfoSystems),
new KeyValuePair<string, MIMEType>("sh", ApplicationXSh),
new KeyValuePair<string, MIMEType>("shar", ApplicationXShar),
new KeyValuePair<string, MIMEType>("swf", ApplicationXShockwaveFlash),
new KeyValuePair<string, MIMEType>("xap", ApplicationXSilverlightApp),
new KeyValuePair<string, MIMEType>("sql", ApplicationXSql),
new KeyValuePair<string, MIMEType>("sit", ApplicationXStuffit),
new KeyValuePair<string, MIMEType>("sitx", ApplicationXStuffitx),
new KeyValuePair<string, MIMEType>("srt", ApplicationXSubrip),
new KeyValuePair<string, MIMEType>("sv4cpio", ApplicationXSv4cpio),
new KeyValuePair<string, MIMEType>("sv4crc", ApplicationXSv4crc),
new KeyValuePair<string, MIMEType>("t3", ApplicationXT3vmImage),
new KeyValuePair<string, MIMEType>("gam", ApplicationXTads),
new KeyValuePair<string, MIMEType>("tar", ApplicationXTar),
new KeyValuePair<string, MIMEType>("tcl", ApplicationXTcl),
new KeyValuePair<string, MIMEType>("tex", ApplicationXTex),
new KeyValuePair<string, MIMEType>("tfm", ApplicationXTexTfm),
new KeyValuePair<string, MIMEType>("texinfo", ApplicationXTexinfo),
new KeyValuePair<string, MIMEType>("texi", ApplicationXTexinfo),
new KeyValuePair<string, MIMEType>("obj", ApplicationXTgif),
new KeyValuePair<string, MIMEType>("ustar", ApplicationXUstar),
new KeyValuePair<string, MIMEType>("src", ApplicationXWaisSource),
new KeyValuePair<string, MIMEType>("der", ApplicationXX509CaCert),
new KeyValuePair<string, MIMEType>("crt", ApplicationXX509CaCert),
new KeyValuePair<string, MIMEType>("fig", ApplicationXXfig),
new KeyValuePair<string, MIMEType>("xlf", ApplicationXXliffXml),
new KeyValuePair<string, MIMEType>("xpi", ApplicationXXpinstall),
new KeyValuePair<string, MIMEType>("xz", ApplicationXXz),
new KeyValuePair<string, MIMEType>("z1", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z2", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z3", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z4", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z5", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z6", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z7", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("z8", ApplicationXZmachine),
new KeyValuePair<string, MIMEType>("xaml", ApplicationXamlXml),
new KeyValuePair<string, MIMEType>("xdf", ApplicationXcapDiffXml),
new KeyValuePair<string, MIMEType>("xenc", ApplicationXencXml),
new KeyValuePair<string, MIMEType>("xhtml", ApplicationXhtmlXml),
new KeyValuePair<string, MIMEType>("xht", ApplicationXhtmlXml),
new KeyValuePair<string, MIMEType>("xml", ApplicationXml),
new KeyValuePair<string, MIMEType>("xsl", ApplicationXml),
new KeyValuePair<string, MIMEType>("dtd", ApplicationXmlDtd),
new KeyValuePair<string, MIMEType>("xop", ApplicationXopXml),
new KeyValuePair<string, MIMEType>("xpl", ApplicationXprocXml),
new KeyValuePair<string, MIMEType>("xslt", ApplicationXsltXml),
new KeyValuePair<string, MIMEType>("xspf", ApplicationXspfXml),
new KeyValuePair<string, MIMEType>("mxml", ApplicationXvXml),
new KeyValuePair<string, MIMEType>("xhvml", ApplicationXvXml),
new KeyValuePair<string, MIMEType>("xvml", ApplicationXvXml),
new KeyValuePair<string, MIMEType>("xvm", ApplicationXvXml),
new KeyValuePair<string, MIMEType>("yang", ApplicationYang),
new KeyValuePair<string, MIMEType>("yin", ApplicationYinXml),
new KeyValuePair<string, MIMEType>("zip", ApplicationZip),
new KeyValuePair<string, MIMEType>("adp", AudioAdpcm),
new KeyValuePair<string, MIMEType>("au", AudioBasic),
new KeyValuePair<string, MIMEType>("snd", AudioBasic),
new KeyValuePair<string, MIMEType>("mid", AudioMidi),
new KeyValuePair<string, MIMEType>("midi", AudioMidi),
new KeyValuePair<string, MIMEType>("kar", AudioMidi),
new KeyValuePair<string, MIMEType>("rmi", AudioMidi),
new KeyValuePair<string, MIMEType>("mp4a", AudioMp4),
new KeyValuePair<string, MIMEType>("mpga", AudioMpeg),
new KeyValuePair<string, MIMEType>("mp2", AudioMpeg),
new KeyValuePair<string, MIMEType>("mp2a", AudioMpeg),
new KeyValuePair<string, MIMEType>("mp3", AudioMpeg),
new KeyValuePair<string, MIMEType>("m2a", AudioMpeg),
new KeyValuePair<string, MIMEType>("m3a", AudioMpeg),
new KeyValuePair<string, MIMEType>("oga", AudioOgg),
new KeyValuePair<string, MIMEType>("ogg", AudioOgg),
new KeyValuePair<string, MIMEType>("spx", AudioOgg),
new KeyValuePair<string, MIMEType>("s3m", AudioS3m),
new KeyValuePair<string, MIMEType>("sil", AudioSilk),
new KeyValuePair<string, MIMEType>("uva", AudioVndDeceAudio),
new KeyValuePair<string, MIMEType>("uvva", AudioVndDeceAudio),
new KeyValuePair<string, MIMEType>("eol", AudioVndDigitalWinds),
new KeyValuePair<string, MIMEType>("dra", AudioVndDra),
new KeyValuePair<string, MIMEType>("dts", AudioVndDts),
new KeyValuePair<string, MIMEType>("dtshd", AudioVndDtsHd),
new KeyValuePair<string, MIMEType>("lvp", AudioVndLucentVoice),
new KeyValuePair<string, MIMEType>("pya", AudioVndMsPlayreadyMediaPya),
new KeyValuePair<string, MIMEType>("ecelp4800", AudioVndNueraEcelp4800),
new KeyValuePair<string, MIMEType>("ecelp7470", AudioVndNueraEcelp7470),
new KeyValuePair<string, MIMEType>("ecelp9600", AudioVndNueraEcelp9600),
new KeyValuePair<string, MIMEType>("rip", AudioVndRip),
new KeyValuePair<string, MIMEType>("weba", AudioWebm),
new KeyValuePair<string, MIMEType>("aac", AudioXAac),
new KeyValuePair<string, MIMEType>("aif", AudioXAiff),
new KeyValuePair<string, MIMEType>("aiff", AudioXAiff),
new KeyValuePair<string, MIMEType>("aifc", AudioXAiff),
new KeyValuePair<string, MIMEType>("caf", AudioXCaf),
new KeyValuePair<string, MIMEType>("flac", AudioXFlac),
new KeyValuePair<string, MIMEType>("mka", AudioXMatroska),
new KeyValuePair<string, MIMEType>("m3u", AudioXMpegurl),
new KeyValuePair<string, MIMEType>("wax", AudioXMsWax),
new KeyValuePair<string, MIMEType>("wma", AudioXMsWma),
new KeyValuePair<string, MIMEType>("ram", AudioXPnRealaudio),
new KeyValuePair<string, MIMEType>("ra", AudioXPnRealaudio),
new KeyValuePair<string, MIMEType>("rmp", AudioXPnRealaudioPlugin),
new KeyValuePair<string, MIMEType>("wav", AudioXWav),
new KeyValuePair<string, MIMEType>("xm", AudioXm),
new KeyValuePair<string, MIMEType>("cdx", ChemicalXCdx),
new KeyValuePair<string, MIMEType>("cif", ChemicalXCif),
new KeyValuePair<string, MIMEType>("cmdf", ChemicalXCmdf),
new KeyValuePair<string, MIMEType>("cml", ChemicalXCml),
new KeyValuePair<string, MIMEType>("csml", ChemicalXCsml),
new KeyValuePair<string, MIMEType>("xyz", ChemicalXXyz),
new KeyValuePair<string, MIMEType>("bmp", ImageBmp),
new KeyValuePair<string, MIMEType>("cgm", ImageCgm),
new KeyValuePair<string, MIMEType>("g3", ImageG3fax),
new KeyValuePair<string, MIMEType>("gif", ImageGif),
new KeyValuePair<string, MIMEType>("ief", ImageIef),
new KeyValuePair<string, MIMEType>("jpeg", ImageJpeg),
new KeyValuePair<string, MIMEType>("jpg", ImageJpeg),
new KeyValuePair<string, MIMEType>("jpe", ImageJpeg),
new KeyValuePair<string, MIMEType>("ktx", ImageKtx),
new KeyValuePair<string, MIMEType>("png", ImagePng),
new KeyValuePair<string, MIMEType>("btif", ImagePrsBtif),
new KeyValuePair<string, MIMEType>("sgi", ImageSgi),
new KeyValuePair<string, MIMEType>("svg", ImageSvgXml),
new KeyValuePair<string, MIMEType>("svgz", ImageSvgXml),
new KeyValuePair<string, MIMEType>("tiff", ImageTiff),
new KeyValuePair<string, MIMEType>("tif", ImageTiff),
new KeyValuePair<string, MIMEType>("psd", ImageVndAdobePhotoshop),
new KeyValuePair<string, MIMEType>("uvi", ImageVndDeceGraphic),
new KeyValuePair<string, MIMEType>("uvvi", ImageVndDeceGraphic),
new KeyValuePair<string, MIMEType>("uvg", ImageVndDeceGraphic),
new KeyValuePair<string, MIMEType>("uvvg", ImageVndDeceGraphic),
new KeyValuePair<string, MIMEType>("sub", ImageVndDvbSubtitle),
new KeyValuePair<string, MIMEType>("djvu", ImageVndDjvu),
new KeyValuePair<string, MIMEType>("djv", ImageVndDjvu),
new KeyValuePair<string, MIMEType>("dwg", ImageVndDwg),
new KeyValuePair<string, MIMEType>("dxf", ImageVndDxf),
new KeyValuePair<string, MIMEType>("fbs", ImageVndFastbidsheet),
new KeyValuePair<string, MIMEType>("fpx", ImageVndFpx),
new KeyValuePair<string, MIMEType>("fst", ImageVndFst),
new KeyValuePair<string, MIMEType>("mmr", ImageVndFujixeroxEdmicsMmr),
new KeyValuePair<string, MIMEType>("rlc", ImageVndFujixeroxEdmicsRlc),
new KeyValuePair<string, MIMEType>("mdi", ImageVndMsModi),
new KeyValuePair<string, MIMEType>("wdp", ImageVndMsPhoto),
new KeyValuePair<string, MIMEType>("npx", ImageVndNetFpx),
new KeyValuePair<string, MIMEType>("wbmp", ImageVndWapWbmp),
new KeyValuePair<string, MIMEType>("xif", ImageVndXiff),
new KeyValuePair<string, MIMEType>("webp", ImageWebp),
new KeyValuePair<string, MIMEType>("3ds", ImageX3ds),
new KeyValuePair<string, MIMEType>("ras", ImageXCmuRaster),
new KeyValuePair<string, MIMEType>("cmx", ImageXCmx),
new KeyValuePair<string, MIMEType>("fh", ImageXFreehand),
new KeyValuePair<string, MIMEType>("fhc", ImageXFreehand),
new KeyValuePair<string, MIMEType>("fh4", ImageXFreehand),
new KeyValuePair<string, MIMEType>("fh5", ImageXFreehand),
new KeyValuePair<string, MIMEType>("fh7", ImageXFreehand),
new KeyValuePair<string, MIMEType>("ico", ImageXIcon),
new KeyValuePair<string, MIMEType>("sid", ImageXMrsidImage),
new KeyValuePair<string, MIMEType>("pcx", ImageXPcx),
new KeyValuePair<string, MIMEType>("pic", ImageXPict),
new KeyValuePair<string, MIMEType>("pct", ImageXPict),
new KeyValuePair<string, MIMEType>("pnm", ImageXPortableAnymap),
new KeyValuePair<string, MIMEType>("pbm", ImageXPortableBitmap),
new KeyValuePair<string, MIMEType>("pgm", ImageXPortableGraymap),
new KeyValuePair<string, MIMEType>("ppm", ImageXPortablePixmap),
new KeyValuePair<string, MIMEType>("rgb", ImageXRgb),
new KeyValuePair<string, MIMEType>("tga", ImageXTga),
new KeyValuePair<string, MIMEType>("xbm", ImageXXbitmap),
new KeyValuePair<string, MIMEType>("xpm", ImageXXpixmap),
new KeyValuePair<string, MIMEType>("xwd", ImageXXwindowdump),
new KeyValuePair<string, MIMEType>("eml", MessageRfc822),
new KeyValuePair<string, MIMEType>("mime", MessageRfc822),
new KeyValuePair<string, MIMEType>("igs", ModelIges),
new KeyValuePair<string, MIMEType>("iges", ModelIges),
new KeyValuePair<string, MIMEType>("msh", ModelMesh),
new KeyValuePair<string, MIMEType>("mesh", ModelMesh),
new KeyValuePair<string, MIMEType>("silo", ModelMesh),
new KeyValuePair<string, MIMEType>("dae", ModelVndColladaXml),
new KeyValuePair<string, MIMEType>("dwf", ModelVndDwf),
new KeyValuePair<string, MIMEType>("gdl", ModelVndGdl),
new KeyValuePair<string, MIMEType>("gtw", ModelVndGtw),
new KeyValuePair<string, MIMEType>("mts", ModelVndMts),
new KeyValuePair<string, MIMEType>("vtu", ModelVndVtu),
new KeyValuePair<string, MIMEType>("wrl", ModelVrml),
new KeyValuePair<string, MIMEType>("vrml", ModelVrml),
new KeyValuePair<string, MIMEType>("x3db", ModelX3dBinary),
new KeyValuePair<string, MIMEType>("x3dbz", ModelX3dBinary),
new KeyValuePair<string, MIMEType>("x3dv", ModelX3dVrml),
new KeyValuePair<string, MIMEType>("x3dvz", ModelX3dVrml),
new KeyValuePair<string, MIMEType>("x3d", ModelX3dXml),
new KeyValuePair<string, MIMEType>("x3dz", ModelX3dXml),
new KeyValuePair<string, MIMEType>("appcache", TextCacheManifest),
new KeyValuePair<string, MIMEType>("ics", TextCalendar),
new KeyValuePair<string, MIMEType>("ifb", TextCalendar),
new KeyValuePair<string, MIMEType>("css", TextCss),
new KeyValuePair<string, MIMEType>("csv", TextCsv),
new KeyValuePair<string, MIMEType>("html", TextHtml),
new KeyValuePair<string, MIMEType>("htm", TextHtml),
new KeyValuePair<string, MIMEType>("n3", TextN3),
new KeyValuePair<string, MIMEType>("txt", TextPlain),
new KeyValuePair<string, MIMEType>("text", TextPlain),
new KeyValuePair<string, MIMEType>("conf", TextPlain),
new KeyValuePair<string, MIMEType>("def", TextPlain),
new KeyValuePair<string, MIMEType>("list", TextPlain),
new KeyValuePair<string, MIMEType>("log", TextPlain),
new KeyValuePair<string, MIMEType>("in", TextPlain),
new KeyValuePair<string, MIMEType>("dsc", TextPrsLinesTag),
new KeyValuePair<string, MIMEType>("rtx", TextRichtext),
new KeyValuePair<string, MIMEType>("sgml", TextSgml),
new KeyValuePair<string, MIMEType>("sgm", TextSgml),
new KeyValuePair<string, MIMEType>("tsv", TextTabSeparatedValues),
new KeyValuePair<string, MIMEType>("t", TextTroff),
new KeyValuePair<string, MIMEType>("tr", TextTroff),
new KeyValuePair<string, MIMEType>("roff", TextTroff),
new KeyValuePair<string, MIMEType>("man", TextTroff),
new KeyValuePair<string, MIMEType>("me", TextTroff),
new KeyValuePair<string, MIMEType>("ms", TextTroff),
new KeyValuePair<string, MIMEType>("ttl", TextTurtle),
new KeyValuePair<string, MIMEType>("uri", TextUriList),
new KeyValuePair<string, MIMEType>("uris", TextUriList),
new KeyValuePair<string, MIMEType>("urls", TextUriList),
new KeyValuePair<string, MIMEType>("vcard", TextVcard),
new KeyValuePair<string, MIMEType>("curl", TextVndCurl),
new KeyValuePair<string, MIMEType>("dcurl", TextVndCurlDcurl),
new KeyValuePair<string, MIMEType>("scurl", TextVndCurlScurl),
new KeyValuePair<string, MIMEType>("mcurl", TextVndCurlMcurl),
new KeyValuePair<string, MIMEType>("sub", TextVndDvbSubtitle),
new KeyValuePair<string, MIMEType>("fly", TextVndFly),
new KeyValuePair<string, MIMEType>("flx", TextVndFmiFlexstor),
new KeyValuePair<string, MIMEType>("gv", TextVndGraphviz),
new KeyValuePair<string, MIMEType>("3dml", TextVndIn3d3dml),
new KeyValuePair<string, MIMEType>("spot", TextVndIn3dSpot),
new KeyValuePair<string, MIMEType>("jad", TextVndSunJ2meAppDescriptor),
new KeyValuePair<string, MIMEType>("wml", TextVndWapWml),
new KeyValuePair<string, MIMEType>("wmls", TextVndWapWmlscript),
new KeyValuePair<string, MIMEType>("s", TextXAsm),
new KeyValuePair<string, MIMEType>("asm", TextXAsm),
new KeyValuePair<string, MIMEType>("c", TextXC),
new KeyValuePair<string, MIMEType>("cc", TextXC),
new KeyValuePair<string, MIMEType>("cxx", TextXC),
new KeyValuePair<string, MIMEType>("cpp", TextXC),
new KeyValuePair<string, MIMEType>("h", TextXC),
new KeyValuePair<string, MIMEType>("hh", TextXC),
new KeyValuePair<string, MIMEType>("dic", TextXC),
new KeyValuePair<string, MIMEType>("f", TextXFortran),
new KeyValuePair<string, MIMEType>("for", TextXFortran),
new KeyValuePair<string, MIMEType>("f77", TextXFortran),
new KeyValuePair<string, MIMEType>("f90", TextXFortran),
new KeyValuePair<string, MIMEType>("java", TextXJavaSource),
new KeyValuePair<string, MIMEType>("opml", TextXOpml),
new KeyValuePair<string, MIMEType>("p", TextXPascal),
new KeyValuePair<string, MIMEType>("pas", TextXPascal),
new KeyValuePair<string, MIMEType>("nfo", TextXNfo),
new KeyValuePair<string, MIMEType>("etx", TextXSetext),
new KeyValuePair<string, MIMEType>("sfv", TextXSfv),
new KeyValuePair<string, MIMEType>("uu", TextXUuencode),
new KeyValuePair<string, MIMEType>("vcs", TextXVcalendar),
new KeyValuePair<string, MIMEType>("vcf", TextXVcard),
new KeyValuePair<string, MIMEType>("3gp", Video3gpp),
new KeyValuePair<string, MIMEType>("3g2", Video3gpp2),
new KeyValuePair<string, MIMEType>("h261", VideoH261),
new KeyValuePair<string, MIMEType>("h263", VideoH263),
new KeyValuePair<string, MIMEType>("h264", VideoH264),
new KeyValuePair<string, MIMEType>("jpgv", VideoJpeg),
new KeyValuePair<string, MIMEType>("jpm", VideoJpm),
new KeyValuePair<string, MIMEType>("jpgm", VideoJpm),
new KeyValuePair<string, MIMEType>("mj2", VideoMj2),
new KeyValuePair<string, MIMEType>("mjp2", VideoMj2),
new KeyValuePair<string, MIMEType>("mp4", VideoMp4),
new KeyValuePair<string, MIMEType>("mp4v", VideoMp4),
new KeyValuePair<string, MIMEType>("mpg4", VideoMp4),
new KeyValuePair<string, MIMEType>("mpeg", VideoMpeg),
new KeyValuePair<string, MIMEType>("mpg", VideoMpeg),
new KeyValuePair<string, MIMEType>("mpe", VideoMpeg),
new KeyValuePair<string, MIMEType>("m1v", VideoMpeg),
new KeyValuePair<string, MIMEType>("m2v", VideoMpeg),
new KeyValuePair<string, MIMEType>("ogv", VideoOgg),
new KeyValuePair<string, MIMEType>("qt", VideoQuicktime),
new KeyValuePair<string, MIMEType>("mov", VideoQuicktime),
new KeyValuePair<string, MIMEType>("uvh", VideoVndDeceHd),
new KeyValuePair<string, MIMEType>("uvvh", VideoVndDeceHd),
new KeyValuePair<string, MIMEType>("uvm", VideoVndDeceMobile),
new KeyValuePair<string, MIMEType>("uvvm", VideoVndDeceMobile),
new KeyValuePair<string, MIMEType>("uvp", VideoVndDecePd),
new KeyValuePair<string, MIMEType>("uvvp", VideoVndDecePd),
new KeyValuePair<string, MIMEType>("uvs", VideoVndDeceSd),
new KeyValuePair<string, MIMEType>("uvvs", VideoVndDeceSd),
new KeyValuePair<string, MIMEType>("uvv", VideoVndDeceVideo),
new KeyValuePair<string, MIMEType>("uvvv", VideoVndDeceVideo),
new KeyValuePair<string, MIMEType>("dvb", VideoVndDvbFile),
new KeyValuePair<string, MIMEType>("fvt", VideoVndFvt),
new KeyValuePair<string, MIMEType>("mxu", VideoVndMpegurl),
new KeyValuePair<string, MIMEType>("m4u", VideoVndMpegurl),
new KeyValuePair<string, MIMEType>("pyv", VideoVndMsPlayreadyMediaPyv),
new KeyValuePair<string, MIMEType>("uvu", VideoVndUvvuMp4),
new KeyValuePair<string, MIMEType>("uvvu", VideoVndUvvuMp4),
new KeyValuePair<string, MIMEType>("viv", VideoVndVivo),
new KeyValuePair<string, MIMEType>("webm", VideoWebm),
new KeyValuePair<string, MIMEType>("f4v", VideoXF4v),
new KeyValuePair<string, MIMEType>("fli", VideoXFli),
new KeyValuePair<string, MIMEType>("flv", VideoXFlv),
new KeyValuePair<string, MIMEType>("m4v", VideoXM4v),
new KeyValuePair<string, MIMEType>("mkv", VideoXMatroska),
new KeyValuePair<string, MIMEType>("mk3d", VideoXMatroska),
new KeyValuePair<string, MIMEType>("mks", VideoXMatroska),
new KeyValuePair<string, MIMEType>("mng", VideoXMng),
new KeyValuePair<string, MIMEType>("asf", VideoXMsAsf),
new KeyValuePair<string, MIMEType>("asx", VideoXMsAsf),
new KeyValuePair<string, MIMEType>("vob", VideoXMsVob),
new KeyValuePair<string, MIMEType>("wm", VideoXMsWm),
new KeyValuePair<string, MIMEType>("wmv", VideoXMsWmv),
new KeyValuePair<string, MIMEType>("wmx", VideoXMsWmx),
new KeyValuePair<string, MIMEType>("wvx", VideoXMsWvx),
new KeyValuePair<string, MIMEType>("avi", VideoXMsvideo),
new KeyValuePair<string, MIMEType>("movie", VideoXSgiMovie),
new KeyValuePair<string, MIMEType>("smv", VideoXSmv),
new KeyValuePair<string, MIMEType>("ice", XConferenceXCooltalk)
        ).ToDictionaryOverwrite();
        
        static public bool TryParseFromExtension(string input, out MIMEType type)
        {
            if(EXTENSION_LOOKUP_TABLE.TryGetValue(input.ToLower(), out type))
                return true;
                
            type = ApplicationOctetStream;
            return false;
        }
        static public MIMEType ParseFromExtension(string input)
        {
            MIMEType type;
            
            TryParseFromExtension(input, out type);
            return type;
        }
        
        static public bool TryParseFromFilename(string input, out MIMEType type)
        {
            return TryParseFromExtension(Filename.GetExtension(input), out type);
        }
        static public MIMEType ParseFromFilename(string input)
        {
            MIMEType type;
            
            TryParseFromFilename(input, out type);
            return type;
        }
        
        private MIMEType(MIMEGeneralType g, string v, IEnumerable<string> e, IEnumerable<string> uv)
        {
            general_type = g;
            sub_value = v;
            
            extensions = e.ToList();
            unofficial_sub_values = uv.ToList();
        }
        
        public MIMEGeneralType GetGeneralType()
        {
            return general_type;
        }
        
        public IEnumerable<string> GetExtensions()
        {
            return extensions;
        }
        
        public override string ToString()
        {
            return general_type + "/" + sub_value;
        }
    }
}
