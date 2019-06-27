using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wssModValoresLibres.Models
{
    public partial class Esuite52Context : DbContext
    {
        public Esuite52Context()
        {
        }

        public Esuite52Context(DbContextOptions<Esuite52Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaGeog> AreaGeog { get; set; }
        public virtual DbSet<BelAsigFoli> BelAsigFoli { get; set; }
        public virtual DbSet<BelConsCara> BelConsCara { get; set; }
        public virtual DbSet<BelConsRang> BelConsRang { get; set; }
        public virtual DbSet<BelConsResu> BelConsResu { get; set; }
        public virtual DbSet<BelDatoRefe> BelDatoRefe { get; set; }
        public virtual DbSet<BelDescReca> BelDescReca { get; set; }
        public virtual DbSet<BelDetaCodi> BelDetaCodi { get; set; }
        public virtual DbSet<BelDetaPrse> BelDetaPrse { get; set; }
        public virtual DbSet<BelDetaSubt> BelDetaSubt { get; set; }
        public virtual DbSet<BelEncaDocu> BelEncaDocu { get; set; }
        public virtual DbSet<BelEnviDocu> BelEnviDocu { get; set; }
        public virtual DbSet<BelEnviPdf> BelEnviPdf { get; set; }
        public virtual DbSet<BelFoliAnul> BelFoliAnul { get; set; }
        public virtual DbSet<BelInfoTick> BelInfoTick { get; set; }
        public virtual DbSet<BelSubtInfo> BelSubtInfo { get; set; }
        public virtual DbSet<BelTidoEnvi> BelTidoEnvi { get; set; }
        public virtual DbSet<BelUnidCont> BelUnidCont { get; set; }
        public virtual DbSet<BelXml> BelXml { get; set; }
        public virtual DbSet<CambMone> CambMone { get; set; }
        public virtual DbSet<CaraGene> CaraGene { get; set; }
        public virtual DbSet<CaraPeem> CaraPeem { get; set; }
        public virtual DbSet<CaraPers> CaraPers { get; set; }
        public virtual DbSet<CentCost> CentCost { get; set; }
        public virtual DbSet<DbnCtrlArch> DbnCtrlArch { get; set; }
        public virtual DbSet<DbnListBoto> DbnListBoto { get; set; }
        public virtual DbSet<DbnListColu> DbnListColu { get; set; }
        public virtual DbSet<DbnListRepo> DbnListRepo { get; set; }
        public virtual DbSet<DbnMensErro> DbnMensErro { get; set; }
        public virtual DbSet<DbnMoniProc> DbnMoniProc { get; set; }
        public virtual DbSet<DbnMoniStat> DbnMoniStat { get; set; }
        public virtual DbSet<DbnProcesos> DbnProcesos { get; set; }
        public virtual DbSet<DbnRepoRous> DbnRepoRous { get; set; }
        public virtual DbSet<DbnServSrvd> DbnServSrvd { get; set; }
        public virtual DbSet<DbnServicio> DbnServicio { get; set; }
        public virtual DbSet<DbnServidor> DbnServidor { get; set; }
        public virtual DbSet<DbnSesrRangOper> DbnSesrRangOper { get; set; }
        public virtual DbSet<DbqArch> DbqArch { get; set; }
        public virtual DbSet<DbqArchClob> DbqArchClob { get; set; }
        public virtual DbSet<DbqGrpo> DbqGrpo { get; set; }
        public virtual DbSet<Dbsr> Dbsr { get; set; }
        public virtual DbSet<DteAcciDocu> DteAcciDocu { get; set; }
        public virtual DbSet<DteAcecEmpr> DteAcecEmpr { get; set; }
        public virtual DbSet<DteActiEcon> DteActiEcon { get; set; }
        public virtual DbSet<DteAnoto> DteAnoto { get; set; }
        public virtual DbSet<DteArchAdju> DteArchAdju { get; set; }
        public virtual DbSet<DteAutoPers> DteAutoPers { get; set; }
        public virtual DbSet<DteCertPers> DteCertPers { get; set; }
        public virtual DbSet<DteCesiAuto> DteCesiAuto { get; set; }
        public virtual DbSet<DteCesiDocu> DteCesiDocu { get; set; }
        public virtual DbSet<DteComiCarg> DteComiCarg { get; set; }
        public virtual DbSet<DteConfOrig> DteConfOrig { get; set; }
        public virtual DbSet<DteDelCesion> DteDelCesion { get; set; }
        public virtual DbSet<DteDescItem> DteDescItem { get; set; }
        public virtual DbSet<DteDescItemH> DteDescItemH { get; set; }
        public virtual DbSet<DteDescItemP> DteDescItemP { get; set; }
        public virtual DbSet<DteDescReca> DteDescReca { get; set; }
        public virtual DbSet<DteDescRecaH> DteDescRecaH { get; set; }
        public virtual DbSet<DteDescRecaP> DteDescRecaP { get; set; }
        public virtual DbSet<DteDetaAcec> DteDetaAcec { get; set; }
        public virtual DbSet<DteDetaAcecH> DteDetaAcecH { get; set; }
        public virtual DbSet<DteDetaAcecP> DteDetaAcecP { get; set; }
        public virtual DbSet<DteDetaCodi> DteDetaCodi { get; set; }
        public virtual DbSet<DteDetaCodiH> DteDetaCodiH { get; set; }
        public virtual DbSet<DteDetaCodiP> DteDetaCodiP { get; set; }
        public virtual DbSet<DteDetaPrse> DteDetaPrse { get; set; }
        public virtual DbSet<DteDetaPrseH> DteDetaPrseH { get; set; }
        public virtual DbSet<DteDetaPrseP> DteDetaPrseP { get; set; }
        public virtual DbSet<DteDocuLob> DteDocuLob { get; set; }
        public virtual DbSet<DteDocuLobH> DteDocuLobH { get; set; }
        public virtual DbSet<DteDocuRefe> DteDocuRefe { get; set; }
        public virtual DbSet<DteDocuRefeH> DteDocuRefeH { get; set; }
        public virtual DbSet<DteDocuRefeP> DteDocuRefeP { get; set; }
        public virtual DbSet<DteEncaDocu> DteEncaDocu { get; set; }
        public virtual DbSet<DteEncaDocuH> DteEncaDocuH { get; set; }
        public virtual DbSet<DteEncaDocuP> DteEncaDocuP { get; set; }
        public virtual DbSet<DteEnviDocu> DteEnviDocu { get; set; }
        public virtual DbSet<DteEnviDocuH> DteEnviDocuH { get; set; }
        public virtual DbSet<DteEnviLob> DteEnviLob { get; set; }
        public virtual DbSet<DteEnviLobH> DteEnviLobH { get; set; }
        public virtual DbSet<DteEnviPdf> DteEnviPdf { get; set; }
        public virtual DbSet<DteEnviTrace> DteEnviTrace { get; set; }
        public virtual DbSet<DteEstaApro> DteEstaApro { get; set; }
        public virtual DbSet<DteEstaCesi> DteEstaCesi { get; set; }
        public virtual DbSet<DteEstaDocu> DteEstaDocu { get; set; }
        public virtual DbSet<DteEstaEnvi> DteEstaEnvi { get; set; }
        public virtual DbSet<DteEstaRecl> DteEstaRecl { get; set; }
        public virtual DbSet<DteFase> DteFase { get; set; }
        public virtual DbSet<DteFoliClie> DteFoliClie { get; set; }
        public virtual DbSet<DteFormatos> DteFormatos { get; set; }
        public virtual DbSet<DteOrgaCert> DteOrgaCert { get; set; }
        public virtual DbSet<DteProcEvnt> DteProcEvnt { get; set; }
        public virtual DbSet<DteRangFoli> DteRangFoli { get; set; }
        public virtual DbSet<DteRecaItem> DteRecaItem { get; set; }
        public virtual DbSet<DteRecaItemH> DteRecaItemH { get; set; }
        public virtual DbSet<DteRecaItemP> DteRecaItemP { get; set; }
        public virtual DbSet<DteSucaItem> DteSucaItem { get; set; }
        public virtual DbSet<DteSucaItemH> DteSucaItemH { get; set; }
        public virtual DbSet<DteSucaItemP> DteSucaItemP { get; set; }
        public virtual DbSet<DteSucuEmis> DteSucuEmis { get; set; }
        public virtual DbSet<DteSumaImom> DteSumaImom { get; set; }
        public virtual DbSet<DteSumaImpu> DteSumaImpu { get; set; }
        public virtual DbSet<DteSumaImpuH> DteSumaImpuH { get; set; }
        public virtual DbSet<DteSumaImpuP> DteSumaImpuP { get; set; }
        public virtual DbSet<DteTidoEnvi> DteTidoEnvi { get; set; }
        public virtual DbSet<DteTidoEnviH> DteTidoEnviH { get; set; }
        public virtual DbSet<DteTipoBult> DteTipoBult { get; set; }
        public virtual DbSet<DteTipoDocu> DteTipoDocu { get; set; }
        public virtual DbSet<DteTipoImpu> DteTipoImpu { get; set; }
        public virtual DbSet<DteTipoOrig> DteTipoOrig { get; set; }
        public virtual DbSet<DteTrace> DteTrace { get; set; }
        public virtual DbSet<DteUsuaDocu> DteUsuaDocu { get; set; }
        public virtual DbSet<DteValiErro> DteValiErro { get; set; }
        public virtual DbSet<DtecAddress> DtecAddress { get; set; }
        public virtual DbSet<DtecEmprAuth> DtecEmprAuth { get; set; }
        public virtual DbSet<DtecMessage> DtecMessage { get; set; }
        public virtual DbSet<DtecQueueMsge> DtecQueueMsge { get; set; }
        public virtual DbSet<DtoDescItem> DtoDescItem { get; set; }
        public virtual DbSet<DtoDescItemP> DtoDescItemP { get; set; }
        public virtual DbSet<DtoDescReca> DtoDescReca { get; set; }
        public virtual DbSet<DtoDescRecaH> DtoDescRecaH { get; set; }
        public virtual DbSet<DtoDescRecaP> DtoDescRecaP { get; set; }
        public virtual DbSet<DtoDetaAcec> DtoDetaAcec { get; set; }
        public virtual DbSet<DtoDetaAcecH> DtoDetaAcecH { get; set; }
        public virtual DbSet<DtoDetaAcecP> DtoDetaAcecP { get; set; }
        public virtual DbSet<DtoDetaCodi> DtoDetaCodi { get; set; }
        public virtual DbSet<DtoDetaCodiH> DtoDetaCodiH { get; set; }
        public virtual DbSet<DtoDetaCodiP> DtoDetaCodiP { get; set; }
        public virtual DbSet<DtoDetaPrse> DtoDetaPrse { get; set; }
        public virtual DbSet<DtoDetaPrseH> DtoDetaPrseH { get; set; }
        public virtual DbSet<DtoDetaPrseP> DtoDetaPrseP { get; set; }
        public virtual DbSet<DtoDocuLob> DtoDocuLob { get; set; }
        public virtual DbSet<DtoDocuLobH> DtoDocuLobH { get; set; }
        public virtual DbSet<DtoDocuRefe> DtoDocuRefe { get; set; }
        public virtual DbSet<DtoDocuRefeH> DtoDocuRefeH { get; set; }
        public virtual DbSet<DtoDocuRefeP> DtoDocuRefeP { get; set; }
        public virtual DbSet<DtoEncaDocu> DtoEncaDocu { get; set; }
        public virtual DbSet<DtoEncaDocuH> DtoEncaDocuH { get; set; }
        public virtual DbSet<DtoEncaDocuP> DtoEncaDocuP { get; set; }
        public virtual DbSet<DtoExtrDocu> DtoExtrDocu { get; set; }
        public virtual DbSet<DtoFase> DtoFase { get; set; }
        public virtual DbSet<DtoRecaItem> DtoRecaItem { get; set; }
        public virtual DbSet<DtoRecaItemP> DtoRecaItemP { get; set; }
        public virtual DbSet<DtoReceDocu> DtoReceDocu { get; set; }
        public virtual DbSet<DtoReceDocuH> DtoReceDocuH { get; set; }
        public virtual DbSet<DtoReceLob> DtoReceLob { get; set; }
        public virtual DbSet<DtoReceLobH> DtoReceLobH { get; set; }
        public virtual DbSet<DtoSucaItem> DtoSucaItem { get; set; }
        public virtual DbSet<DtoSucaItemP> DtoSucaItemP { get; set; }
        public virtual DbSet<DtoSuceEsap> DtoSuceEsap { get; set; }
        public virtual DbSet<DtoSumaImpu> DtoSumaImpu { get; set; }
        public virtual DbSet<DtoSumaImpuH> DtoSumaImpuH { get; set; }
        public virtual DbSet<DtoSumaImpuP> DtoSumaImpuP { get; set; }
        public virtual DbSet<DtoTidoRece> DtoTidoRece { get; set; }
        public virtual DbSet<DtoTidoReceH> DtoTidoReceH { get; set; }
        public virtual DbSet<DtoTrace> DtoTrace { get; set; }
        public virtual DbSet<Empr> Empr { get; set; }
        public virtual DbSet<EmprExte> EmprExte { get; set; }
        public virtual DbSet<FoliAnul> FoliAnul { get; set; }
        public virtual DbSet<LbeCaraLibr> LbeCaraLibr { get; set; }
        public virtual DbSet<LbeDetaDocu> LbeDetaDocu { get; set; }
        public virtual DbSet<LbeDetaLibr> LbeDetaLibr { get; set; }
        public virtual DbSet<LbeEncaLibr> LbeEncaLibr { get; set; }
        public virtual DbSet<LbeNotiLibr> LbeNotiLibr { get; set; }
        public virtual DbSet<LbePeriTise> LbePeriTise { get; set; }
        public virtual DbSet<LbeResuPeri> LbeResuPeri { get; set; }
        public virtual DbSet<LbeResuSegm> LbeResuSegm { get; set; }
        public virtual DbSet<LbeSegmTise> LbeSegmTise { get; set; }
        public virtual DbSet<LbeServPeri> LbeServPeri { get; set; }
        public virtual DbSet<LbeServSegm> LbeServSegm { get; set; }
        public virtual DbSet<LbeSoliLibr> LbeSoliLibr { get; set; }
        public virtual DbSet<LbeTotaPeri> LbeTotaPeri { get; set; }
        public virtual DbSet<LbeTotaSegm> LbeTotaSegm { get; set; }
        public virtual DbSet<LcvDetaComi> LcvDetaComi { get; set; }
        public virtual DbSet<LcvDetaDocu> LcvDetaDocu { get; set; }
        public virtual DbSet<LcvDetaDocuP> LcvDetaDocuP { get; set; }
        public virtual DbSet<LcvDetaNoreP> LcvDetaNoreP { get; set; }
        public virtual DbSet<LcvDetaTemp> LcvDetaTemp { get; set; }
        public virtual DbSet<LcvDigiDocu> LcvDigiDocu { get; set; }
        public virtual DbSet<LcvDigiImpu> LcvDigiImpu { get; set; }
        public virtual DbSet<LcvDocuServ> LcvDocuServ { get; set; }
        public virtual DbSet<LcvNoreTemp> LcvNoreTemp { get; set; }
        public virtual DbSet<LcvResuLibr> LcvResuLibr { get; set; }
        public virtual DbSet<LcvResuLibrP> LcvResuLibrP { get; set; }
        public virtual DbSet<LcvSegmImpu> LcvSegmImpu { get; set; }
        public virtual DbSet<LcvSegmImpuP> LcvSegmImpuP { get; set; }
        public virtual DbSet<LcvSegmNore> LcvSegmNore { get; set; }
        public virtual DbSet<LcvSegmNoreP> LcvSegmNoreP { get; set; }
        public virtual DbSet<LcvTotaComi> LcvTotaComi { get; set; }
        public virtual DbSet<LcvTotaDocu> LcvTotaDocu { get; set; }
        public virtual DbSet<LcvTotaDocuP> LcvTotaDocuP { get; set; }
        public virtual DbSet<LcvTotaImpu> LcvTotaImpu { get; set; }
        public virtual DbSet<LcvTotaImpuP> LcvTotaImpuP { get; set; }
        public virtual DbSet<LcvTotaLibr> LcvTotaLibr { get; set; }
        public virtual DbSet<LcvTotaLibrP> LcvTotaLibrP { get; set; }
        public virtual DbSet<LcvTotaNore> LcvTotaNore { get; set; }
        public virtual DbSet<LcvTotaNoreP> LcvTotaNoreP { get; set; }
        public virtual DbSet<LcvTotaSegm> LcvTotaSegm { get; set; }
        public virtual DbSet<LcvTotaSegmP> LcvTotaSegmP { get; set; }
        public virtual DbSet<LcvTotaTemp> LcvTotaTemp { get; set; }
        public virtual DbSet<LgdDetaDocu> LgdDetaDocu { get; set; }
        public virtual DbSet<LgdDetaDocuP> LgdDetaDocuP { get; set; }
        public virtual DbSet<LgdEncaLigd> LgdEncaLigd { get; set; }
        public virtual DbSet<LgdEncaLigdP> LgdEncaLigdP { get; set; }
        public virtual DbSet<LgdTotaPeri> LgdTotaPeri { get; set; }
        public virtual DbSet<LgdTotaPeriP> LgdTotaPeriP { get; set; }
        public virtual DbSet<LgdTotaSegm> LgdTotaSegm { get; set; }
        public virtual DbSet<LgdTotaSegmP> LgdTotaSegmP { get; set; }
        public virtual DbSet<LgdTrasPeri> LgdTrasPeri { get; set; }
        public virtual DbSet<LgdTrasPeriP> LgdTrasPeriP { get; set; }
        public virtual DbSet<LgdTrasSegm> LgdTrasSegm { get; set; }
        public virtual DbSet<LgdTrasSegmP> LgdTrasSegmP { get; set; }
        public virtual DbSet<LogErro> LogErro { get; set; }
        public virtual DbSet<LogUsuario> LogUsuario { get; set; }
        public virtual DbSet<MantProd> MantProd { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Mtod> Mtod { get; set; }
        public virtual DbSet<OficEmpr> OficEmpr { get; set; }
        public virtual DbSet<ParaEmpr> ParaEmpr { get; set; }
        public virtual DbSet<ParaPers> ParaPers { get; set; }
        public virtual DbSet<PersPaide> PersPaide { get; set; }
        public virtual DbSet<PersPubl> PersPubl { get; set; }
        public virtual DbSet<PersPublTemp> PersPublTemp { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<ProcLogs> ProcLogs { get; set; }
        public virtual DbSet<QseDocuServ> QseDocuServ { get; set; }
        public virtual DbSet<Ramo> Ramo { get; set; }
        public virtual DbSet<RepDtoEnca> RepDtoEnca { get; set; }
        public virtual DbSet<SePipe> SePipe { get; set; }
        public virtual DbSet<SysAlar> SysAlar { get; set; }
        public virtual DbSet<SysAlarEmex> SysAlarEmex { get; set; }
        public virtual DbSet<SysAlarEmpr> SysAlarEmpr { get; set; }
        public virtual DbSet<SysAlin> SysAlin { get; set; }
        public virtual DbSet<SysAlri> SysAlri { get; set; }
        public virtual DbSet<SysAlro> SysAlro { get; set; }
        public virtual DbSet<SysAlus> SysAlus { get; set; }
        public virtual DbSet<SysAttrCult> SysAttrCult { get; set; }
        public virtual DbSet<SysAttribute> SysAttribute { get; set; }
        public virtual DbSet<SysCode> SysCode { get; set; }
        public virtual DbSet<SysCodi> SysCodi { get; set; }
        public virtual DbSet<SysComment> SysComment { get; set; }
        public virtual DbSet<SysConnection> SysConnection { get; set; }
        public virtual DbSet<SysDefp> SysDefp { get; set; }
        public virtual DbSet<SysDomaCult> SysDomaCult { get; set; }
        public virtual DbSet<SysDomain> SysDomain { get; set; }
        public virtual DbSet<SysFupr> SysFupr { get; set; }
        public virtual DbSet<SysFuro> SysFuro { get; set; }
        public virtual DbSet<SysInst> SysInst { get; set; }
        public virtual DbSet<SysKey> SysKey { get; set; }
        public virtual DbSet<SysKeyAttr> SysKeyAttr { get; set; }
        public virtual DbSet<SysMessCult> SysMessCult { get; set; }
        public virtual DbSet<SysMessage> SysMessage { get; set; }
        public virtual DbSet<SysModuObje> SysModuObje { get; set; }
        public virtual DbSet<SysObac> SysObac { get; set; }
        public virtual DbSet<SysObjeCult> SysObjeCult { get; set; }
        public virtual DbSet<SysObject> SysObject { get; set; }
        public virtual DbSet<SysRelation> SysRelation { get; set; }
        public virtual DbSet<SysSession> SysSession { get; set; }
        public virtual DbSet<SysUserObjects> SysUserObjects { get; set; }
        public virtual DbSet<SysUsfa> SysUsfa { get; set; }
        public virtual DbSet<SysUsro> SysUsro { get; set; }
        public virtual DbSet<UsemExte> UsemExte { get; set; }
        public virtual DbSet<UsuaEmpr> UsuaEmpr { get; set; }
        public virtual DbSet<UsuaExte> UsuaExte { get; set; }
        public virtual DbSet<UsuaSist> UsuaSist { get; set; }
        public virtual DbSet<ValoCage> ValoCage { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<WebEstaProc> WebEstaProc { get; set; }

        // Unable to generate entity type for table 'dbo.seq_corr_cesi'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_x'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bel_usua_pos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dte_audi_tran'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lcv_resu_lob'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dte_audi_foli'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_PARA_OPER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dbnet_server'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_PARA_SERV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dto_reca_item_h'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dto_suca_item_h'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_LOG_50'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_asig_foli'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dte_fase_esta'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dto_desc_item_h'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_envi_boel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_PROC_SERV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_libr_boel'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_unid_cons'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.qse_docu_serv_err'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dual'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lcv_deta_nore'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBQ_GRPO_ERRO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dbq_cana'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dbq_erro'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_TRAZA_DOCU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.log_egate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.obj_ds2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rep_dto_sii'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_rep_dto_sii'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dto_fase_esta'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_corr_docu'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_dte_lcv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_sys_alin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_sys_defp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_sys_fupr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_LIMP_GRPO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_LIMP_ARCH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DBN_LIMP_LOGG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_extrae'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seq_boel_resu'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.dte_extr_docu'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.p_corr_envi'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=facture;Trusted_Connection=True;User Id=sa;Password=passw0rd!;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<AreaGeog>(entity =>
            {
                entity.HasKey(e => new { e.CodiArge, e.TipoArge })
                    .HasName("arge_pk");

                entity.ToTable("area_geog");

                entity.Property(e => e.CodiArge)
                    .HasColumnName("codi_arge")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArge)
                    .HasColumnName("tipo_arge")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodiArge1)
                    .HasColumnName("codi_arge1")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DescPeriArge)
                    .HasColumnName("desc_peri_arge")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GenfArge)
                    .HasColumnName("genf_arge")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GenmArge)
                    .HasColumnName("genm_arge")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MarcArge)
                    .HasColumnName("marc_arge")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombArge)
                    .HasColumnName("nomb_arge")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostArge)
                    .HasColumnName("post_arge")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<BelAsigFoli>(entity =>
            {
                entity.HasKey(e => e.CorrAsig)
                    .HasName("BEASFO_PK");

                entity.ToTable("bel_asig_foli");

                entity.Property(e => e.CorrAsig)
                    .HasColumnName("CORR_ASIG")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.CantReen)
                    .HasColumnName("CANT_REEN")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiCeco)
                    .IsRequired()
                    .HasColumnName("CODI_CECO")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiUnid)
                    .IsRequired()
                    .HasColumnName("CODI_UNID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("CORR_RAFO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EstaAsig)
                    .IsRequired()
                    .HasColumnName("ESTA_ASIG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechAsig)
                    .HasColumnName("FECH_ASIG")
                    .HasColumnType("datetime");

                entity.Property(e => e.FoliDesd)
                    .HasColumnName("FOLI_DESD")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FoliHast)
                    .HasColumnName("FOLI_HAST")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.StrrAsig)
                    .HasColumnName("STRR_ASIG")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StrrCaff)
                    .HasColumnName("STRR_CAFF")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOrig)
                    .HasColumnName("TIPO_ORIG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltiUsad)
                    .HasColumnName("ULTI_USAD")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.CorrRafoNavigation)
                    .WithMany(p => p.BelAsigFoli)
                    .HasForeignKey(d => d.CorrRafo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beasfo_fk_rafo");

                entity.HasOne(d => d.BelUnidCont)
                    .WithMany(p => p.BelAsigFoli)
                    .HasForeignKey(d => new { d.CodiUnid, d.CodiEmpr, d.CodiCeco, d.TipoOrig })
                    .HasConstraintName("beasfo_fk_unid");
            });

            modelBuilder.Entity<BelConsCara>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrCons })
                    .HasName("BECOCA_PK");

                entity.ToTable("bel_cons_cara");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrCons)
                    .HasColumnName("CORR_CONS")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.ArchResp)
                    .HasColumnName("arch_resp")
                    .HasColumnType("text");

                entity.Property(e => e.DigiEmis)
                    .IsRequired()
                    .HasColumnName("DIGI_EMIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .IsRequired()
                    .HasColumnName("DIGI_ENVI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("ESTA_ENVI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstaSsii)
                    .HasColumnName("esta_ssii")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechFina)
                    .IsRequired()
                    .HasColumnName("FECH_FINA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechInic)
                    .IsRequired()
                    .HasColumnName("FECH_INIC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .IsRequired()
                    .HasColumnName("FECH_RESO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoEnvi)
                    .IsRequired()
                    .HasColumnName("FEHO_ENVI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("MENS_ENVI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensSsii)
                    .HasColumnName("mens_ssii")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeAten)
                    .HasColumnName("NUME_ATEN")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("NUME_ENVI")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeResu)
                    .HasColumnName("NUME_RESU")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("RUTT_EMIS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("RUTT_ENVI")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SecuEnvi)
                    .HasColumnName("SECU_ENVI")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TmstRpta)
                    .HasColumnName("tmst_rpta")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.BelConsCara)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("becoca_fk_empr");

                entity.HasOne(d => d.EstaEnviNavigation)
                    .WithMany(p => p.BelConsCara)
                    .HasForeignKey(d => d.EstaEnvi)
                    .HasConstraintName("becoca_fk_envi");
            });

            modelBuilder.Entity<BelConsRang>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.CorrCons, e.TipoRang, e.FoliInic })
                    .HasName("BECORA_PK");

                entity.ToTable("bel_cons_rang");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CorrCons)
                    .HasColumnName("CORR_CONS")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoRang)
                    .HasColumnName("TIPO_RANG")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FoliInic)
                    .HasColumnName("FOLI_INIC")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FoliFina)
                    .HasColumnName("FOLI_FINA")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.BelConsResu)
                    .WithMany(p => p.BelConsRang)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrCons, d.TipoDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("becora_fk_empr");
            });

            modelBuilder.Entity<BelConsResu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrCons, e.TipoDocu })
                    .HasName("BECORE_PK");

                entity.ToTable("bel_cons_resu");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrCons)
                    .HasColumnName("CORR_CONS")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantAnul)
                    .HasColumnName("CANT_ANUL")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CantEmit)
                    .HasColumnName("CANT_EMIT")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CantUtil)
                    .HasColumnName("CANT_UTIL")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("MONT_TOTA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaIvag)
                    .HasColumnName("TASA_IVAG")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.TotaExen)
                    .HasColumnName("TOTA_EXEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaIvag)
                    .HasColumnName("TOTA_IVAG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNeto)
                    .HasColumnName("TOTA_NETO")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.BelConsResu)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("becore_fk_docu");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.BelConsResu)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrCons })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("becore_fk_empr");
            });

            modelBuilder.Entity<BelDatoRefe>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("BEDARE_PK");

                entity.ToTable("bel_dato_refe");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("NUME_LINE")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiCaja)
                    .HasColumnName("CODI_CAJA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("CODI_REFE")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("CODI_VEND")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("RAZO_REFE")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.HasOne(d => d.BelEncaDocu)
                    .WithMany(p => p.BelDatoRefe)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bedare_fk_empr");
            });

            modelBuilder.Entity<BelDescReca>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("BEDERE_PK");

                entity.ToTable("bel_desc_reca");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("NUME_LINE")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GlosMovi)
                    .HasColumnName("GLOS_MOVI")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("INDI_EXEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipoMov)
                    .HasColumnName("TIPO_MOV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("TIPO_VALO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoMovi)
                    .HasColumnName("VALO_MOVI")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.BelEncaDocu)
                    .WithMany(p => p.BelDescReca)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bedere_fk_empr");
            });

            modelBuilder.Entity<BelDetaCodi>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.TipoCodi })
                    .HasName("BEDECO_PK");

                entity.ToTable("bel_deta_codi");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("NUME_LINE")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("TIPO_CODI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .IsRequired()
                    .HasColumnName("CODI_ITEM")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.HasOne(d => d.BelDetaPrse)
                    .WithMany(p => p.BelDetaCodi)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bedeco_fk_empr");
            });

            modelBuilder.Entity<BelDetaPrse>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("BEDEPR_PK");

                entity.ToTable("bel_deta_prse");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("NUME_LINE")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("CANT_ITEM")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.DescAdic)
                    .HasColumnName("DESC_ADIC")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("INDI_EXEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.ItemEspe)
                    .HasColumnName("ITEM_ESPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MontDesc)
                    .HasColumnName("MONT_DESC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontReca)
                    .HasColumnName("MONT_RECA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombItem)
                    .IsRequired()
                    .HasColumnName("NOMB_ITEM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PorcDesc)
                    .HasColumnName("PORC_DESC")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PorcReca)
                    .HasColumnName("PORC_RECA")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrecUnic)
                    .HasColumnName("PREC_UNIC")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RuttMand)
                    .HasColumnName("RUTT_MAND")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMed)
                    .HasColumnName("UNID_MED")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ValoLine)
                    .HasColumnName("VALO_LINE")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.BelEncaDocu)
                    .WithMany(p => p.BelDetaPrse)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bedepr_fk_empr");
            });

            modelBuilder.Entity<BelDetaSubt>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.LineDeta })
                    .HasName("BEDESU_PK");

                entity.ToTable("bel_deta_subt");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("NUME_LINE")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.LineDeta)
                    .HasColumnName("LINE_DETA")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.BelSubtInfo)
                    .WithMany(p => p.BelDetaSubt)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bedesu_fk_empr");
            });

            modelBuilder.Entity<BelEncaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("BEENCDO_PK");

                entity.ToTable("bel_enca_docu");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("CIUD_ORIG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("CIUD_POST")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("CIUD_RECE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiInte)
                    .HasColumnName("CODI_INTE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("CODI_SUCU")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ColaProc)
                    .HasColumnName("cola_proc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("COMU_ORIG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("COMU_POST")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("COMU_RECE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("CONT_RECE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("CORR_ENVI")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("CORR_RAFO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DigiRece)
                    .HasColumnName("DIGI_RECE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiVeri)
                    .IsRequired()
                    .HasColumnName("DIGI_VERI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("DIRE_ORIG")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("DIRE_POST")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("DIRE_RECE")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("ESTA_DOCU")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechEmis)
                    .HasColumnName("FECH_EMIS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVenc)
                    .HasColumnName("FECH_VENC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliClie)
                    .HasColumnName("foli_clie")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("GIRO_EMIS")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ImprDest)
                    .HasColumnName("impr_dest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndiMone)
                    .HasColumnName("INDI_MONE")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiServ)
                    .HasColumnName("INDI_SERV")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("MONT_EXEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("MONT_NETO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("MONT_NOFA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("MONT_TOTA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombEmis)
                    .HasColumnName("NOMB_EMIS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("NOMB_RECE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PediDesd)
                    .HasColumnName("PEDI_DESD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("PERI_HAST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("RUTT_EMIS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("RUTT_RECE")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("SALD_ANTE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("TASA_VAAG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TmstTimb)
                    .HasColumnName("TMST_TIMB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotaPeri)
                    .HasColumnName("TOTA_PERI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("VAAG_TERC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Val1)
                    .HasColumnName("VAL1")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val10)
                    .HasColumnName("VAL10")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("VAL2")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("VAL3")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("VAL4")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("VAL5")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("VAL6")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val7)
                    .HasColumnName("VAL7")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val8)
                    .HasColumnName("VAL8")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val9)
                    .HasColumnName("VAL9")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("VALO_PAGA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VersEnca)
                    .IsRequired()
                    .HasColumnName("VERS_ENCA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.BelEncaDocu)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beendo_fk_empr");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.BelEncaDocu)
                    .HasForeignKey(d => d.CorrEnvi)
                    .HasConstraintName("beendo_fk_envi");

                entity.HasOne(d => d.CorrRafoNavigation)
                    .WithMany(p => p.BelEncaDocu)
                    .HasForeignKey(d => d.CorrRafo)
                    .HasConstraintName("beendo_fk_rafo");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.BelEncaDocu)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beendo_fk_docu");
            });

            modelBuilder.Entity<BelEnviDocu>(entity =>
            {
                entity.HasKey(e => e.CorrEnvi)
                    .HasName("BEENVDO_PK");

                entity.ToTable("bel_envi_docu");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("CORR_ENVI")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DigiEmis)
                    .IsRequired()
                    .HasColumnName("DIGI_EMIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .IsRequired()
                    .HasColumnName("DIGI_ENVI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .IsRequired()
                    .HasColumnName("DIGI_RECE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .IsRequired()
                    .HasColumnName("ESTA_ENVI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .IsRequired()
                    .HasColumnName("FECH_RESO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoEnvi)
                    .HasColumnName("FEHO_ENVI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("MENS_ENVI")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .HasColumnName("NOMB_ARCH")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeAten)
                    .HasColumnName("NUME_ATEN")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.NumeReso)
                    .HasColumnName("NUME_RESO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("RUTT_EMIS")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("RUTT_ENVI")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("RUTT_RECE")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.VersEnvi)
                    .IsRequired()
                    .HasColumnName("VERS_ENVI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.BelEnviDocu)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beenvdo_fk_empr");
            });

            modelBuilder.Entity<BelEnviPdf>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.PosicionEmail })
                    .HasName("bel_envi_pdf_PK");

                entity.ToTable("bel_envi_pdf");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PosicionEmail)
                    .HasColumnName("posicion_email")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.EmailEnvi)
                    .HasColumnName("email_envi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HacerEnvi)
                    .HasColumnName("hacer_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");
            });

            modelBuilder.Entity<BelFoliAnul>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliAnul })
                    .HasName("BEFOAN_PK");

                entity.ToTable("bel_foli_anul");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliAnul)
                    .HasColumnName("FOLI_ANUL")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FechAnul)
                    .IsRequired()
                    .HasColumnName("FECH_ANUL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.BelFoliAnul)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("befoan_fk_empr");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.BelFoliAnul)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("befoan_fk_docu");
            });

            modelBuilder.Entity<BelInfoTick>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.FoliTick })
                    .HasName("BEINTI_PK");

                entity.ToTable("bel_info_tick");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FoliTick)
                    .HasColumnName("FOLI_TICK")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.AsieUbic)
                    .HasColumnName("ASIE_UBIC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEven)
                    .IsRequired()
                    .HasColumnName("CODI_EVEN")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FechEven)
                    .IsRequired()
                    .HasColumnName("FECH_EVEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechTick)
                    .IsRequired()
                    .HasColumnName("FECH_TICK")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FilaUbic)
                    .HasColumnName("FILA_UBIC")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LugaEven)
                    .IsRequired()
                    .HasColumnName("LUGA_EVEN")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombEven)
                    .IsRequired()
                    .HasColumnName("NOMB_EVEN")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTick)
                    .IsRequired()
                    .HasColumnName("TIPO_TICK")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UbicEven)
                    .IsRequired()
                    .HasColumnName("UBIC_EVEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BelEncaDocu)
                    .WithMany(p => p.BelInfoTick)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beinti_fk_empr");
            });

            modelBuilder.Entity<BelSubtInfo>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("BESUIN_PK");

                entity.ToTable("bel_subt_info");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("NUME_LINE")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GlosSubt)
                    .HasColumnName("GLOS_SUBT")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LineDeta)
                    .HasColumnName("LINE_DETA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrdeImpr)
                    .HasColumnName("ORDE_IMPR")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ValoExen)
                    .HasColumnName("VALO_EXEN")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ValoImad)
                    .HasColumnName("VALO_IMAD")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ValoIvag)
                    .HasColumnName("VALO_IVAG")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ValoNeto)
                    .HasColumnName("VALO_NETO")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ValoSubt)
                    .HasColumnName("VALO_SUBT")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.BelEncaDocu)
                    .WithMany(p => p.BelSubtInfo)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("besuin_fk_empr");
            });

            modelBuilder.Entity<BelTidoEnvi>(entity =>
            {
                entity.HasKey(e => new { e.CorrEnvi, e.TipoDocu })
                    .HasName("BETIEN_PK");

                entity.ToTable("bel_tido_envi");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("CORR_ENVI")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("CANT_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.BelTidoEnvi)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("betien_fk_empr");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.BelTidoEnvi)
                    .HasForeignKey(d => d.CorrEnvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("betien_fk_envi");
            });

            modelBuilder.Entity<BelUnidCont>(entity =>
            {
                entity.HasKey(e => new { e.CodiUnid, e.CodiEmpr, e.CodiCeco, e.TipoOrig })
                    .HasName("BEUNCO_PK");

                entity.ToTable("bel_unid_cont");

                entity.Property(e => e.CodiUnid)
                    .HasColumnName("CODI_UNID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("CODI_CECO")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOrig)
                    .HasColumnName("TIPO_ORIG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CantFoli)
                    .HasColumnName("CANT_FOLI")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.EstaUnid)
                    .HasColumnName("ESTA_UNID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IndiAlta)
                    .IsRequired()
                    .HasColumnName("INDI_ALTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombUnid)
                    .IsRequired()
                    .HasColumnName("NOMB_UNID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PorcRepo)
                    .HasColumnName("PORC_REPO")
                    .HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.BelUnidCont)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beunco_fk_empr");
            });

            modelBuilder.Entity<BelXml>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("BEXM_PK");

                entity.ToTable("bel_xml");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ClobDocu)
                    .HasColumnName("CLOB_DOCU")
                    .HasColumnType("text");

                entity.HasOne(d => d.BelEncaDocu)
                    .WithOne(p => p.BelXml)
                    .HasForeignKey<BelXml>(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("bexm_fk_empr");
            });

            modelBuilder.Entity<CambMone>(entity =>
            {
                entity.HasKey(e => new { e.TipoMone, e.FechCamb })
                    .HasName("camb_pk");

                entity.ToTable("camb_mone");

                entity.Property(e => e.TipoMone)
                    .HasColumnName("tipo_mone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechCamb)
                    .HasColumnName("fech_camb")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValoCamb)
                    .HasColumnName("valo_camb")
                    .HasColumnType("numeric(22, 4)");
            });

            modelBuilder.Entity<CaraGene>(entity =>
            {
                entity.HasKey(e => e.CodiCage)
                    .HasName("cage_pk");

                entity.ToTable("cara_gene");

                entity.Property(e => e.CodiCage)
                    .HasColumnName("codi_cage")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescCage)
                    .HasColumnName("desc_cage")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiClie)
                    .HasColumnName("indi_clie")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiEmpl)
                    .HasColumnName("indi_empl")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiEmpr)
                    .HasColumnName("indi_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiProv)
                    .HasColumnName("indi_prov")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCage)
                    .HasColumnName("tipo_cage")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaraPeem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiPers, e.FeinCape, e.CodiCage, e.CodiVacg })
                    .HasName("CPEM_PK");

                entity.ToTable("CARA_PEEM");

                entity.HasIndex(e => e.FeinCape)
                    .HasName("IA_CPEM_FEIN");

                entity.HasIndex(e => e.FeteCape)
                    .HasName("IA_CPEM_FETE");

                entity.HasIndex(e => new { e.CodiEmpr, e.CodiCage, e.CodiVacg })
                    .HasName("IA_CPEM_VACG");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("CODI_PERS")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FeinCape)
                    .HasColumnName("FEIN_CAPE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodiCage)
                    .HasColumnName("CODI_CAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVacg)
                    .HasColumnName("CODI_VACG")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.ComeCape)
                    .HasColumnName("COME_CAPE")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FeteCape)
                    .HasColumnName("FETE_CAPE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValoCape)
                    .HasColumnName("VALO_CAPE")
                    .HasColumnType("numeric(22, 4)");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.CaraPeem)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("CPEM_FK_EMPR_1");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.CaraPeem)
                    .HasForeignKey(d => d.CodiPers)
                    .HasConstraintName("CPEM_FK_PERS_1");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.CaraPeem)
                    .HasForeignKey(d => new { d.CodiCage, d.CodiVacg })
                    .HasConstraintName("CPEM_FK_VACG_1");
            });

            modelBuilder.Entity<CaraPers>(entity =>
            {
                entity.HasKey(e => new { e.CodiPers, e.FeinCape, e.CodiCage, e.CodiVacg })
                    .HasName("cape_pk");

                entity.ToTable("cara_pers");

                entity.HasIndex(e => e.FeinCape)
                    .HasName("ia_cape_fein");

                entity.HasIndex(e => e.FeteCape)
                    .HasName("ia_cape_fete");

                entity.HasIndex(e => new { e.CodiCage, e.CodiVacg })
                    .HasName("ia_cape_vacg");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FeinCape)
                    .HasColumnName("fein_cape")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodiCage)
                    .HasColumnName("codi_cage")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVacg)
                    .HasColumnName("codi_vacg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.ComeCape)
                    .HasColumnName("come_cape")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FeteCape)
                    .HasColumnName("fete_cape")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValoCape)
                    .HasColumnName("valo_cape")
                    .HasColumnType("numeric(22, 4)");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.CaraPers)
                    .HasForeignKey(d => d.CodiPers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cape_fk_pers_1");
            });

            modelBuilder.Entity<CentCost>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiCeco })
                    .HasName("ceco_pk");

                entity.ToTable("cent_cost");

                entity.HasIndex(e => e.TipoCeco)
                    .HasName("id_ceco_tipo_ceco");

                entity.HasIndex(e => new { e.CodiEmpr, e.CodiCeco1 })
                    .HasName("if_ceco1");

                entity.HasIndex(e => new { e.CodiEmpr, e.NombCeco })
                    .HasName("ceco_uk_ceco_2");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ActiCeco)
                    .HasColumnName("acti_ceco")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco1)
                    .HasColumnName("codi_ceco1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCiud)
                    .HasColumnName("codi_ciud")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiExen)
                    .HasColumnName("codi_exen")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOfic)
                    .HasColumnName("codi_ofic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUbic)
                    .HasColumnName("codi_ubic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiZona)
                    .HasColumnName("codi_zona")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.FeinCeco)
                    .HasColumnName("fein_ceco")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeteCeco)
                    .HasColumnName("fete_ceco")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlagRamo)
                    .HasColumnName("flag_ramo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LeveCeco)
                    .HasColumnName("leve_ceco")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NombCeco)
                    .HasColumnName("nomb_ceco")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NumeCeco)
                    .HasColumnName("nume_ceco")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.NumeCeco1)
                    .HasColumnName("nume_ceco1")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.OperCuco)
                    .HasColumnName("oper_cuco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResuCeco)
                    .HasColumnName("resu_ceco")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ResuCeco1)
                    .HasColumnName("resu_ceco1")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TiarCeco)
                    .HasColumnName("tiar_ceco")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCeco)
                    .HasColumnName("tipo_ceco")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.CentCost)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ceco_fk_empr");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.CentCost)
                    .HasForeignKey(d => d.CodiPers)
                    .HasConstraintName("ceco_fk_pers");
            });

            modelBuilder.Entity<DbnCtrlArch>(entity =>
            {
                entity.HasKey(e => new { e.OrigGrpo, e.NombArch, e.ExteArch, e.TmstRegiArch })
                    .HasName("pk_ctrl_arch");

                entity.ToTable("DBN_CTRL_ARCH");

                entity.Property(e => e.OrigGrpo)
                    .HasColumnName("ORIG_GRPO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .HasColumnName("NOMB_ARCH")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExteArch)
                    .HasColumnName("EXTE_ARCH")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TmstRegiArch)
                    .HasColumnName("TMST_REGI_ARCH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pk01Tabl)
                    .HasColumnName("PK01_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk02Tabl)
                    .HasColumnName("PK02_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk03Tabl)
                    .HasColumnName("PK03_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk04Tabl)
                    .HasColumnName("PK04_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk05Tabl)
                    .HasColumnName("PK05_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk06Tabl)
                    .HasColumnName("PK06_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubtArch)
                    .HasColumnName("SUBT_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TablRela)
                    .HasColumnName("TABL_RELA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArch)
                    .HasColumnName("TIPO_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbnListBoto>(entity =>
            {
                entity.HasKey(e => new { e.CodiRepo, e.CodiBoto })
                    .HasName("PK_DBNLISTBOTO_CODIBOTO_CODIREPO");

                entity.ToTable("dbn_list_boto");

                entity.Property(e => e.CodiRepo)
                    .HasColumnName("CODI_REPO")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiBoto)
                    .HasColumnName("CODI_BOTO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClasCss)
                    .HasColumnName("CLAS_CSS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPar1)
                    .HasColumnName("CODI_PAR1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPar2)
                    .HasColumnName("CODI_PAR2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPar3)
                    .HasColumnName("CODI_PAR3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPar4)
                    .HasColumnName("CODI_PAR4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPar5)
                    .HasColumnName("CODI_PAR5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiResx)
                    .HasColumnName("CODI_RESX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescBoto)
                    .HasColumnName("DESC_BOTO")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ImagBoto)
                    .HasColumnName("IMAG_BOTO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IndiVisi)
                    .HasColumnName("INDI_VISI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ListDeta)
                    .HasColumnName("LIST_DETA")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModoBoto)
                    .HasColumnName("MODO_BOTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombBoto)
                    .HasColumnName("NOMB_BOTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrdeBoto).HasColumnName("ORDE_BOTO");

                entity.Property(e => e.PageBoto)
                    .HasColumnName("PAGE_BOTO")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProcBoto)
                    .HasColumnName("PROC_BOTO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoBoto)
                    .HasColumnName("TIPO_BOTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiRepoNavigation)
                    .WithMany(p => p.DbnListBoto)
                    .HasForeignKey(d => d.CodiRepo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DBNLISTBOTO_DBNLISTREPO");
            });

            modelBuilder.Entity<DbnListColu>(entity =>
            {
                entity.HasKey(e => new { e.CodiRepo, e.CodiColu })
                    .HasName("DBN_LIST_COLU_PK")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("dbn_list_colu");

                entity.Property(e => e.CodiRepo)
                    .HasColumnName("CODI_REPO")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiColu)
                    .HasColumnName("CODI_COLU")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AlinColu)
                    .HasColumnName("ALIN_COLU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AnchColu)
                    .HasColumnName("ANCH_COLU")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClasCss)
                    .HasColumnName("CLAS_CSS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiLiva)
                    .HasColumnName("CODI_LIVA")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodiResx)
                    .HasColumnName("CODI_RESX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ColuBusq)
                    .HasColumnName("COLU_BUSQ")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DescColu)
                    .HasColumnName("DESC_COLU")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FalsBusq)
                    .HasColumnName("FALS_BUSQ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormColu)
                    .HasColumnName("FORM_COLU")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImagColu)
                    .HasColumnName("IMAG_COLU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiBusq)
                    .HasColumnName("INDI_BUSQ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiVisi)
                    .HasColumnName("INDI_VISI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JqryColu)
                    .HasColumnName("JQRY_COLU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombColu)
                    .HasColumnName("NOMB_COLU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrdeColu).HasColumnName("ORDE_COLU");

                entity.Property(e => e.TipoBusq)
                    .HasColumnName("TIPO_BUSQ")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColu)
                    .HasColumnName("TIPO_COLU")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VerdBusq)
                    .HasColumnName("VERD_BUSQ")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiRepoNavigation)
                    .WithMany(p => p.DbnListColu)
                    .HasForeignKey(d => d.CodiRepo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DBNLISTCOLU_DBNLISTCOLU");
            });

            modelBuilder.Entity<DbnListRepo>(entity =>
            {
                entity.HasKey(e => e.CodiRepo)
                    .HasName("PK_DBNLISTREPO_CODIREPO");

                entity.ToTable("dbn_list_repo");

                entity.Property(e => e.CodiRepo)
                    .HasColumnName("CODI_REPO")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CateList)
                    .HasColumnName("CATE_LIST")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("CODI_MODU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiResx)
                    .HasColumnName("CODI_RESX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescRepo)
                    .HasColumnName("DESC_REPO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FiltCkbb)
                    .HasColumnName("FILT_CKBB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MensErro)
                    .HasColumnName("MENS_ERRO")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Modo)
                    .HasColumnName("MODO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PageRepo)
                    .HasColumnName("PAGE_REPO")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProcRepo)
                    .HasColumnName("PROC_REPO")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ScrpSqlo)
                    .HasColumnName("SCRP_SQLO")
                    .HasColumnType("text");

                entity.Property(e => e.ScrpSqls)
                    .HasColumnName("SCRP_SQLS")
                    .HasColumnType("text");

                entity.Property(e => e.SubtCntx)
                    .HasColumnName("SUBT_CNTX")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRepo)
                    .HasColumnName("TIPO_REPO")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TituRepo)
                    .HasColumnName("TITU_REPO")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbnMensErro>(entity =>
            {
                entity.HasKey(e => e.CorrErro)
                    .HasName("corr_erro_pk");

                entity.ToTable("dbn_mens_erro");

                entity.Property(e => e.CorrErro).HasColumnName("corr_erro");

                entity.Property(e => e.CodiErro).HasColumnName("codi_erro");

                entity.Property(e => e.CorrSess).HasColumnName("corr_sess");

                entity.Property(e => e.LineErro)
                    .HasColumnName("line_erro")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.MensErro)
                    .IsRequired()
                    .HasColumnName("mens_erro")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PrccErro)
                    .HasColumnName("prcc_erro")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbnMoniProc>(entity =>
            {
                entity.HasKey(e => new { e.ServServ, e.CodiServ, e.MoprPid, e.MoprInicPk })
                    .HasName("DBN_MONI_PROC_PK");

                entity.ToTable("DBN_MONI_PROC");

                entity.HasIndex(e => new { e.MoprEstaInst, e.MoprFechRepo })
                    .HasName("DBN_MONI_PROC_LIMPIA");

                entity.Property(e => e.ServServ)
                    .HasColumnName("SERV_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MoprPid)
                    .HasColumnName("MOPR_PID")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MoprInicPk)
                    .HasColumnName("MOPR_INIC_PK")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(CONVERT([varchar](20),getdate(),(120)))");

                entity.Property(e => e.MoprEstaInst)
                    .HasColumnName("MOPR_ESTA_INST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MoprFechRepo)
                    .HasColumnName("MOPR_FECH_REPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoprInicOper)
                    .HasColumnName("MOPR_INIC_OPER")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoprNumeErro)
                    .HasColumnName("MOPR_NUME_ERRO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MoprNumeOper)
                    .HasColumnName("MOPR_NUME_OPER")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MoprNumeSlee)
                    .HasColumnName("MOPR_NUME_SLEE")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MoprSemaEsta)
                    .IsRequired()
                    .HasColumnName("MOPR_SEMA_ESTA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ON')");

                entity.HasOne(d => d.DbnServSrvd)
                    .WithMany(p => p.DbnMoniProc)
                    .HasForeignKey(d => new { d.ServServ, d.CodiServ })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DBN_MONI_PROC_DBN_SERV_SRVD");
            });

            modelBuilder.Entity<DbnMoniStat>(entity =>
            {
                entity.HasKey(e => new { e.CodiSrvd, e.CodiServ, e.MoprPid, e.MostPeriOper })
                    .HasName("DBN_MONI_STAT_PK");

                entity.ToTable("DBN_MONI_STAT");

                entity.Property(e => e.CodiSrvd)
                    .HasColumnName("CODI_SRVD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MoprPid)
                    .HasColumnName("MOPR_PID")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MostPeriOper)
                    .HasColumnName("MOST_PERI_OPER")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.MostNumeInst)
                    .HasColumnName("MOST_NUME_INST")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MostSumaErro)
                    .HasColumnName("MOST_SUMA_ERRO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MostSumaOper)
                    .HasColumnName("MOST_SUMA_OPER")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MostSumaSlee)
                    .HasColumnName("MOST_SUMA_SLEE")
                    .HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<DbnProcesos>(entity =>
            {
                entity.HasKey(e => e.CodiProc)
                    .HasName("DBN_PROCESOS_PK");

                entity.ToTable("DBN_PROCESOS");

                entity.Property(e => e.CodiProc)
                    .HasColumnName("CODI_PROC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescProc)
                    .IsRequired()
                    .HasColumnName("DESC_PROC")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbnRepoRous>(entity =>
            {
                entity.HasKey(e => new { e.CodiRepo, e.CodiRous })
                    .HasName("PK_DBNREPOROUS_CODIREPO_CODIROUS");

                entity.ToTable("dbn_repo_rous");

                entity.Property(e => e.CodiRepo)
                    .HasColumnName("CODI_REPO")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("CODI_ROUS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("CODI_MODU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExptExls)
                    .HasColumnName("EXPT_EXLS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiRepoNavigation)
                    .WithMany(p => p.DbnRepoRous)
                    .HasForeignKey(d => d.CodiRepo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DBNREPOCOLU");
            });

            modelBuilder.Entity<DbnServSrvd>(entity =>
            {
                entity.HasKey(e => new { e.ServServ, e.CodiServ })
                    .HasName("DBN_SERV_SRVD_PK");

                entity.ToTable("DBN_SERV_SRVD");

                entity.Property(e => e.ServServ)
                    .HasColumnName("SERV_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ComaServ)
                    .IsRequired()
                    .HasColumnName("COMA_SERV")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DebuServ)
                    .IsRequired()
                    .HasColumnName("DEBU_SERV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EstaServ)
                    .IsRequired()
                    .HasColumnName("ESTA_SERV")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('OFF')");

                entity.Property(e => e.HvidServ)
                    .HasColumnName("HVID_SERV")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((48))");

                entity.Property(e => e.ModoServ)
                    .IsRequired()
                    .HasColumnName("MODO_SERV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.QcanProc)
                    .HasColumnName("QCAN_PROC")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.SleeServ)
                    .HasColumnName("SLEE_SERV")
                    .HasColumnType("numeric(6, 0)")
                    .HasDefaultValueSql("((10))");

                entity.HasOne(d => d.CodiServNavigation)
                    .WithMany(p => p.DbnServSrvd)
                    .HasForeignKey(d => d.CodiServ)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DBN_SERV_SRVD_DBN_SERVICIO");

                entity.HasOne(d => d.ServServNavigation)
                    .WithMany(p => p.DbnServSrvd)
                    .HasForeignKey(d => d.ServServ)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DBN_SERV_SRVD_DBN_SERVIDOR");
            });

            modelBuilder.Entity<DbnServicio>(entity =>
            {
                entity.HasKey(e => e.CodiServ)
                    .HasName("DBN_SERVICIO_PK");

                entity.ToTable("DBN_SERVICIO");

                entity.Property(e => e.CodiServ)
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoServ)
                    .HasColumnName("AUTO_SERV")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CodiDesp)
                    .HasColumnName("CODI_DESP")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ComaServ)
                    .IsRequired()
                    .HasColumnName("COMA_SERV")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DelaServ)
                    .HasColumnName("DELA_SERV")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.DescServ)
                    .IsRequired()
                    .HasColumnName("DESC_SERV")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DestServ)
                    .HasColumnName("DEST_SERV")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetaServ)
                    .HasColumnName("DETA_SERV")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstaOrig)
                    .HasColumnName("ESTA_ORIG")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MtryServ)
                    .HasColumnName("MTRY_SERV")
                    .HasColumnType("numeric(2, 0)")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.NombBrie)
                    .HasColumnName("NOMB_BRIE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrigServ)
                    .HasColumnName("ORIG_SERV")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServEnab)
                    .HasColumnName("SERV_ENAB")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ServIco1)
                    .HasColumnName("SERV_ICO1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServIco2)
                    .HasColumnName("SERV_ICO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServIco3)
                    .HasColumnName("SERV_ICO3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServOrde)
                    .HasColumnName("SERV_ORDE")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<DbnServidor>(entity =>
            {
                entity.HasKey(e => e.ServServ)
                    .HasName("DBN_SERVIDOR_PK");

                entity.ToTable("DBN_SERVIDOR");

                entity.Property(e => e.ServServ)
                    .HasColumnName("SERV_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ServDesc)
                    .IsRequired()
                    .HasColumnName("SERV_DESC")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbnSesrRangOper>(entity =>
            {
                entity.HasKey(e => new { e.CodiSrvd, e.CodiServ, e.DesdSero, e.HastSero })
                    .HasName("DBN_SESR_RANG_OPER_PK");

                entity.ToTable("DBN_SESR_RANG_OPER");

                entity.Property(e => e.CodiSrvd)
                    .HasColumnName("CODI_SRVD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DesdSero)
                    .HasColumnName("DESD_SERO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.HastSero)
                    .HasColumnName("HAST_SERO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaxiSero)
                    .HasColumnName("MAXI_SERO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MiniSero)
                    .HasColumnName("MINI_SERO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PctiSero)
                    .HasColumnName("PCTI_SERO")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.QsizSero)
                    .HasColumnName("QSIZ_SERO")
                    .HasColumnType("numeric(6, 0)");

                entity.HasOne(d => d.CodiS)
                    .WithMany(p => p.DbnSesrRangOper)
                    .HasForeignKey(d => new { d.CodiSrvd, d.CodiServ })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DBN_RANG_OPER_DBN_SERV_SRVD");
            });

            modelBuilder.Entity<DbqArch>(entity =>
            {
                entity.HasKey(e => e.CodiArch)
                    .HasName("DBQ_ARCH_PK");

                entity.ToTable("DBQ_ARCH");

                entity.HasIndex(e => e.CodiGrpo)
                    .HasName("dbq_arch_codi_grpo");

                entity.HasIndex(e => e.CodiServ)
                    .HasName("codi_serv");

                entity.HasIndex(e => new { e.EstaArch, e.CodiServ })
                    .HasName("dbq_arch_esta_serv_idx");

                entity.HasIndex(e => new { e.ExteArch, e.NombArch })
                    .HasName("DBQ_ARCH_TED");

                entity.HasIndex(e => new { e.TmstRegiArch, e.EstaArch, e.CodiServ })
                    .HasName("DBQ_ARCH_LIMPIA");

                entity.HasIndex(e => new { e.TmstRegiArch, e.EstaArch, e.NombArch, e.CodiGrpo })
                    .HasName("DBQ_ARCH_LIMPIA1");

                entity.HasIndex(e => new { e.CodiArch, e.EstaArch, e.TmstRegiArch, e.TmstProcArch, e.CodiServ, e.ContProcArch })
                    .HasName("DBQ_ARCH_PROCESOS");

                entity.HasIndex(e => new { e.CodiArch, e.NombArch, e.EstaArch, e.CodiServ, e.CodiServOrig, e.TmstRegiArch })
                    .HasName("DBQ_ARCH_LIMPIA2");

                entity.Property(e => e.CodiArch)
                    .HasColumnName("CODI_ARCH")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiGrpo)
                    .HasColumnName("CODI_GRPO")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.CodiServ)
                    .IsRequired()
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServOrig)
                    .HasColumnName("CODI_SERV_ORIG")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContProcArch)
                    .HasColumnName("CONT_PROC_ARCH")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CtrlArch)
                    .IsRequired()
                    .HasColumnName("CTRL_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EstaArch)
                    .IsRequired()
                    .HasColumnName("ESTA_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExteArch)
                    .IsRequired()
                    .HasColumnName("EXTE_ARCH")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .IsRequired()
                    .HasColumnName("NOMB_ARCH")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pk01Tabl)
                    .HasColumnName("PK01_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk02Tabl)
                    .HasColumnName("PK02_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk03Tabl)
                    .HasColumnName("PK03_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk04Tabl)
                    .HasColumnName("PK04_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk05Tabl)
                    .HasColumnName("PK05_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk06Tabl)
                    .HasColumnName("PK06_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubtArch)
                    .HasColumnName("SUBT_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TablEsta)
                    .HasColumnName("TABL_ESTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TablRela)
                    .HasColumnName("TABL_RELA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArch)
                    .HasColumnName("TIPO_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRegi)
                    .IsRequired()
                    .HasColumnName("TIPO_REGI")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('T')");

                entity.Property(e => e.TmstProcArch)
                    .HasColumnName("TMST_PROC_ARCH")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmstRegiArch)
                    .HasColumnName("TMST_REGI_ARCH")
                    .HasColumnType("datetime");

                entity.Property(e => e.UltiErro)
                    .HasColumnName("ULTI_ERRO")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbqArchClob>(entity =>
            {
                entity.HasKey(e => e.CodiArch)
                    .HasName("DBQ_ARCHLOB_PK");

                entity.ToTable("DBQ_ARCH_CLOB");

                entity.Property(e => e.CodiArch)
                    .HasColumnName("CODI_ARCH")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ClobArch)
                    .HasColumnName("CLOB_ARCH")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<DbqGrpo>(entity =>
            {
                entity.HasKey(e => e.CodiGrpo)
                    .HasName("DBQ_GRPO_PK");

                entity.ToTable("DBQ_GRPO");

                entity.HasIndex(e => new { e.EstaGrpo, e.CodiServ })
                    .HasName("dbq_grpo_esta_serv_idx");

                entity.HasIndex(e => new { e.TrptGrpo, e.ModoGrpo, e.NombCana, e.EstaGrpo })
                    .HasName("dbq_grpo_send_idx");

                entity.Property(e => e.CodiGrpo)
                    .HasColumnName("CODI_GRPO")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BodyGrpo)
                    .HasColumnName("BODY_GRPO")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .IsRequired()
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServOrig)
                    .HasColumnName("CODI_SERV_ORIG")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ContProcGrpo)
                    .HasColumnName("CONT_PROC_GRPO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CopiGrpo)
                    .HasColumnName("COPI_GRPO")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.DestGrpo)
                    .IsRequired()
                    .HasColumnName("DEST_GRPO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstaGrpo)
                    .IsRequired()
                    .HasColumnName("ESTA_GRPO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModoGrpo)
                    .IsRequired()
                    .HasColumnName("MODO_GRPO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NombCana)
                    .IsRequired()
                    .HasColumnName("NOMB_CANA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('GRAL')");

                entity.Property(e => e.OculGrpo)
                    .HasColumnName("OCUL_GRPO")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.OrigGrpo)
                    .IsRequired()
                    .HasColumnName("ORIG_GRPO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pk01Tabl)
                    .HasColumnName("PK01_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk02Tabl)
                    .HasColumnName("PK02_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk03Tabl)
                    .HasColumnName("PK03_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk04Tabl)
                    .HasColumnName("PK04_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk05Tabl)
                    .HasColumnName("PK05_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pk06Tabl)
                    .HasColumnName("PK06_TABL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RefeGrpo)
                    .HasColumnName("REFE_GRPO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SgntGrpo)
                    .HasColumnName("SGNT_GRPO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TablEsta)
                    .HasColumnName("TABL_ESTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TablRela)
                    .HasColumnName("TABL_RELA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TmstProcGrpo)
                    .HasColumnName("TMST_PROC_GRPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmstRegiGrpo)
                    .HasColumnName("TMST_REGI_GRPO")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrptGrpo)
                    .IsRequired()
                    .HasColumnName("TRPT_GRPO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UltiErro)
                    .HasColumnName("ULTI_ERRO")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dbsr>(entity =>
            {
                entity.HasKey(e => e.DbsrNmb)
                    .HasName("dbsr_pk");

                entity.ToTable("dbsr");

                entity.Property(e => e.DbsrNmb)
                    .HasColumnName("dbsr_nmb")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DbsrPath)
                    .HasColumnName("dbsr_path")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DbsrPipe)
                    .HasColumnName("dbsr_pipe")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteAcciDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiAced })
                    .HasName("DTE_ACCI_DOCU_PK");

                entity.ToTable("DTE_ACCI_DOCU");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiAced)
                    .HasColumnName("CODI_ACED")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.LogoPubl)
                    .HasColumnName("LOGO_PUBL")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NuimSoli)
                    .HasColumnName("NUIM_SOLI")
                    .HasColumnType("numeric(3, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.NuimTerm)
                    .HasColumnName("NUIM_TERM")
                    .HasColumnType("numeric(3, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.PlanDocu)
                    .HasColumnName("PLAN_DOCU")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteAcciDocu)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_ACCI_DOCU_FK_ENCA_DOCU");
            });

            modelBuilder.Entity<DteAcecEmpr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiAcec })
                    .HasName("dte_aemp_pk");

                entity.ToTable("dte_acec_empr");

                entity.HasIndex(e => e.CodiAcec)
                    .HasName("xif26dte_acec_empr");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.HasOne(d => d.CodiAcecNavigation)
                    .WithMany(p => p.DteAcecEmpr)
                    .HasForeignKey(d => d.CodiAcec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_aemp_fk_acti");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteAcecEmpr)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_aemp_fk_empr");
            });

            modelBuilder.Entity<DteActiEcon>(entity =>
            {
                entity.HasKey(e => e.CodiAcec)
                    .HasName("dte_acti_pk");

                entity.ToTable("dte_acti_econ");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiAcecSup)
                    .HasColumnName("codi_acec_sup")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DescAcec)
                    .HasColumnName("desc_acec")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.NombAcec)
                    .HasColumnName("nomb_acec")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteAnoto>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.FoliDocu, e.NumeTram, e.TipoDocu })
                    .HasName("DTE_ANOTO_PK");

                entity.ToTable("dte_anoto");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeTram)
                    .HasColumnName("nume_tram")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.EstaTram)
                    .HasColumnName("ESTA_TRAM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechRece)
                    .HasColumnName("fech_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechTram)
                    .HasColumnName("FECH_TRAM")
                    .HasColumnType("datetime");

                entity.Property(e => e.IndiAcep)
                    .HasColumnName("indi_acep")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRepa)
                    .HasColumnName("indi_repa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LugaRece)
                    .HasColumnName("luga_rece")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteArchAdju>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.PosiAdju })
                    .HasName("PK_DTE_ARCHADJU");

                entity.ToTable("DTE_ARCH_ADJU");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PosiAdju)
                    .HasColumnName("POSI_ADJU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("CODI_EMEX")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.NmbfAdju)
                    .HasColumnName("NMBF_ADJU")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAdju)
                    .HasColumnName("TIPO_ADJU")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteArchAdju)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_ARCH_ADJU_FK_DTE_ENCA_DOCU");
            });

            modelBuilder.Entity<DteAutoPers>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiPers, e.TipoAuto, e.FeinAuto })
                    .HasName("DTE_AUPE_PK");

                entity.ToTable("dte_auto_pers");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAuto)
                    .HasColumnName("tipo_auto")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FeinAuto)
                    .HasColumnName("fein_auto")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DefeAuto)
                    .HasColumnName("defe_auto")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EstaAuto)
                    .HasColumnName("esta_auto")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FeteAuto)
                    .HasColumnName("fete_auto")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.DteAutoPers)
                    .HasForeignKey(d => d.CodiPers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_aupe_fk_pers");
            });

            modelBuilder.Entity<DteCertPers>(entity =>
            {
                entity.HasKey(e => new { e.CodiPers, e.CodiOrce, e.FeinCert })
                    .HasName("dte_cepe_pk");

                entity.ToTable("dte_cert_pers");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOrce)
                    .HasColumnName("codi_orce")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FeinCert)
                    .HasColumnName("fein_cert")
                    .HasColumnType("datetime");

                entity.Property(e => e.ArchCert)
                    .HasColumnName("arch_cert")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClobCert)
                    .HasColumnName("clob_cert")
                    .HasColumnType("text");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CorrCert)
                    .HasColumnName("corr_cert")
                    .HasColumnType("numeric(22, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EstaCert)
                    .HasColumnName("esta_cert")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FeteCert)
                    .HasColumnName("fete_cert")
                    .HasColumnType("datetime");

                entity.Property(e => e.LlavPriv)
                    .HasColumnName("llav_priv")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.LlavPubl)
                    .HasColumnName("llav_publ")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiOrceNavigation)
                    .WithMany(p => p.DteCertPers)
                    .HasForeignKey(d => d.CodiOrce)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cepe_fk_orce");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.DteCertPers)
                    .HasForeignKey(d => d.CodiPers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_cepe_fk_pers");
            });

            modelBuilder.Entity<DteCesiAuto>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrCesi, e.NumeAuto })
                    .HasName("pk_dte_cesi_auto");

                entity.ToTable("dte_cesi_auto");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CorrCesi)
                    .HasColumnName("corr_cesi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeAuto)
                    .HasColumnName("nume_auto")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DigiAuto)
                    .HasColumnName("digi_auto")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirmAuto)
                    .HasColumnName("firm_auto")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.NombAuto)
                    .HasColumnName("nomb_auto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAuto)
                    .HasColumnName("rutt_auto")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.DteCesiAuto)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrCesi })
                    .HasConstraintName("fk_dte_cesi_auto");
            });

            modelBuilder.Entity<DteCesiDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrCesi })
                    .HasName("pk_dte_cesi_docu");

                entity.ToTable("dte_cesi_docu");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("ix_dte_cesi_docu");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CorrCesi)
                    .HasColumnName("corr_cesi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ArchCesi)
                    .HasColumnName("arch_cesi")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DeclJura)
                    .HasColumnName("decl_jura")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.DigiCede)
                    .HasColumnName("digi_cede")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiCesi)
                    .HasColumnName("digi_cesi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .HasColumnName("digi_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireCede)
                    .HasColumnName("dire_cede")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireCesi)
                    .HasColumnName("dire_cesi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechUpld)
                    .HasColumnName("FECH_UPLD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MailCede)
                    .HasColumnName("mail_cede")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailCesi)
                    .HasColumnName("mail_cesi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailDeud)
                    .HasColumnName("mail_deud")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MontCesi)
                    .HasColumnName("mont_cesi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombCede)
                    .HasColumnName("nomb_cede")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombCesi)
                    .HasColumnName("nomb_cesi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumeAten)
                    .HasColumnName("nume_aten")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeCesi)
                    .HasColumnName("nume_cesi")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("nume_envi")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.OtraCond)
                    .HasColumnName("otra_cond")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.RuttCede)
                    .HasColumnName("rutt_cede")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttCesi)
                    .HasColumnName("rutt_cesi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("rutt_envi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TimeEnvi)
                    .HasColumnName("time_envi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.EstaDocuNavigation)
                    .WithMany(p => p.DteCesiDocu)
                    .HasForeignKey(d => d.EstaDocu)
                    .HasConstraintName("fk2_dte_cesi_docu");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteCesiDocu)
                    .HasForeignKey(d => d.TipoDocu)
                    .HasConstraintName("fk1_dte_cesi_docu");
            });

            modelBuilder.Entity<DteComiCarg>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeCoca });

                entity.ToTable("DTE_COMI_CARG");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeCoca)
                    .HasColumnName("nume_coca")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.GlosCoca)
                    .HasColumnName("glos_coca")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TasaCoca)
                    .HasColumnName("tasa_coca")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.TipoCoca)
                    .HasColumnName("tipo_coca")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoExenCoca)
                    .HasColumnName("valo_exen_coca")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoIvaCoca)
                    .HasColumnName("valo_iva_coca")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoNetoCoca)
                    .HasColumnName("valo_neto_coca")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteComiCarg)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DTE_COMI_CARG");
            });

            modelBuilder.Entity<DteConfOrig>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoOrig, e.TipoDocu })
                    .HasName("DTCOOR_PK");

                entity.ToTable("dte_conf_orig");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TipoOrig)
                    .HasColumnName("TIPO_ORIG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AsigAuto)
                    .IsRequired()
                    .HasColumnName("ASIG_AUTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CantFoli)
                    .HasColumnName("CANT_FOLI")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.PorcRepo)
                    .HasColumnName("PORC_REPO")
                    .HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteConfOrig)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("btcoor_fk_docu");

                entity.HasOne(d => d.TipoOrigNavigation)
                    .WithMany(p => p.DteConfOrig)
                    .HasForeignKey(d => d.TipoOrig)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("btcoor_fk_orig");
            });

            modelBuilder.Entity<DteDelCesion>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrCesi })
                    .HasName("pk_dte_del_cesion");

                entity.ToTable("dte_del_cesion");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrCesi)
                    .HasColumnName("corr_cesi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ArchCesiDel)
                    .HasColumnName("arch_cesi_del")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers)
                    .IsRequired()
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FechDel)
                    .HasColumnName("fech_del")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NumeCesi)
                    .HasColumnName("nume_cesi")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteDelCesion)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_dte_del_cesion");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteDelCesion)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1_dte_del_cesion");
            });

            modelBuilder.Entity<DteDescItem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrDeit })
                    .HasName("dte_deit_pk");

                entity.ToTable("dte_desc_item");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrDeit)
                    .HasColumnName("corr_deit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("tipo_desc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDesc)
                    .HasColumnName("valo_desc")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.DteDetaPrse)
                    .WithMany(p => p.DteDescItem)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deit_fk_dtpr");
            });

            modelBuilder.Entity<DteDescItemH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrDeit })
                    .HasName("DTE_DEIT_H_PK");

                entity.ToTable("dte_desc_item_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrDeit })
                    .HasName("DTE_DEIT_UK_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrDeit)
                    .HasColumnName("corr_deit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("tipo_desc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDesc)
                    .HasColumnName("valo_desc")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DteDetaPrseH)
                    .WithMany(p => p.DteDescItemH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .HasConstraintName("DTE_DEIT_H_FK_DTPR");
            });

            modelBuilder.Entity<DteDescItemP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrDeit })
                    .HasName("dte_deit_p_pk");

                entity.ToTable("dte_desc_item_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrDeit)
                    .HasColumnName("corr_deit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("tipo_desc")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDesc)
                    .HasColumnName("valo_desc")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrseP)
                    .WithMany(p => p.DteDescItemP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deit_fk_dtpr_p");
            });

            modelBuilder.Entity<DteDescReca>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeDere })
                    .HasName("dte_dere_pk");

                entity.ToTable("dte_desc_reca");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeDere)
                    .HasColumnName("nume_dere")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.GlosDere)
                    .HasColumnName("glos_dere")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoDere)
                    .HasColumnName("tipo_dere")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("tipo_valo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDere)
                    .HasColumnName("valo_dere")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VomoDere)
                    .HasColumnName("vomo_dere")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteDescReca)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("dte_dere_fk_endo");
            });

            modelBuilder.Entity<DteDescRecaH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeDere })
                    .HasName("DTE_DERE_H_PK");

                entity.ToTable("dte_desc_reca_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeDere })
                    .HasName("DTE_DERE_UK_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeDere)
                    .HasColumnName("nume_dere")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GlosDere)
                    .HasColumnName("glos_dere")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDere)
                    .HasColumnName("tipo_dere")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("tipo_valo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDere)
                    .HasColumnName("valo_dere")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VomoDere)
                    .HasColumnName("vomo_dere")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DteEncaDocuH)
                    .WithMany(p => p.DteDescRecaH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("DTE_DERE_H_FK_ENDO");
            });

            modelBuilder.Entity<DteDescRecaP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeDere })
                    .HasName("dte_dere_p_pk");

                entity.ToTable("dte_desc_reca_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeDere)
                    .HasColumnName("nume_dere")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GlosDere)
                    .HasColumnName("glos_dere")
                    .HasMaxLength(135)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDere)
                    .HasColumnName("tipo_dere")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("tipo_valo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDere)
                    .HasColumnName("valo_dere")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.VomoDere)
                    .HasColumnName("vomo_dere")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DteEncaDocuP)
                    .WithMany(p => p.DteDescRecaP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_dere_fk_endo_p");
            });

            modelBuilder.Entity<DteDetaAcec>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CorrAcec })
                    .HasName("dte_acec_pk");

                entity.ToTable("dte_deta_acec");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiAcec })
                    .HasName("dte_acec_uk")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CorrAcec)
                    .HasColumnName("corr_acec")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.DteDetaAcec)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiAcec })
                    .HasConstraintName("dte_acec_fk_aemp");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteDetaAcec)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deac_fk_endo");
            });

            modelBuilder.Entity<DteDetaAcecH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CorrAcec })
                    .HasName("DTE_ACEC_H_PK");

                entity.ToTable("dte_deta_acec_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiAcec })
                    .HasName("DTE_ACEC_UK_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CorrAcec)
                    .HasColumnName("corr_acec")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.DteDetaAcecH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiAcec })
                    .HasConstraintName("DTE_ACEC_H_FK_AEMP");

                entity.HasOne(d => d.DteEncaDocuH)
                    .WithMany(p => p.DteDetaAcecH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("DTE_DEAC_H_FK_ENDO");
            });

            modelBuilder.Entity<DteDetaAcecP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CorrAcec })
                    .HasName("DTE_ACEC_P_PK");

                entity.ToTable("dte_deta_acec_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorrAcec)
                    .HasColumnName("corr_acec")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocuP)
                    .WithMany(p => p.DteDetaAcecP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deac_fk_endo_p");
            });

            modelBuilder.Entity<DteDetaCodi>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrCodi })
                    .HasName("dte_deco_pk");

                entity.ToTable("dte_deta_codi");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.TipoCodi })
                    .HasName("dte_deco_uk")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrCodi)
                    .HasColumnName("corr_codi")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrse)
                    .WithMany(p => p.DteDetaCodi)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deco_fk_deps");
            });

            modelBuilder.Entity<DteDetaCodiH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrCodi })
                    .HasName("DTE_DECO_H_PK");

                entity.ToTable("dte_deta_codi_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.TipoCodi })
                    .HasName("DTE_DECO_UK_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrCodi)
                    .HasColumnName("corr_codi")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrseH)
                    .WithMany(p => p.DteDetaCodiH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .HasConstraintName("DTE_DECO_H_FK_DEPS");
            });

            modelBuilder.Entity<DteDetaCodiP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrCodi })
                    .HasName("dte_deco_p_pk");

                entity.ToTable("dte_deta_codi_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrCodi)
                    .HasColumnName("corr_codi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrseP)
                    .WithMany(p => p.DteDetaCodiP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deco_fk_deps_p");
            });

            modelBuilder.Entity<DteDetaPrse>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("dte_dtpr_pk");

                entity.ToTable("dte_deta_prse");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.BaseFaen)
                    .HasColumnName("base_faen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CantRefe)
                    .HasColumnName("cant_refe")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DctoItem)
                    .HasColumnName("dcto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DescMone)
                    .HasColumnName("desc_mone")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DescPorc)
                    .HasColumnName("desc_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.FactConv)
                    .HasColumnName("fact_conv")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.FechElab)
                    .HasColumnName("fech_elab")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVepr)
                    .HasColumnName("fech_vepr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiAgen)
                    .HasColumnName("indi_agen")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MargComer)
                    .HasColumnName("marg_comer")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NetoItem)
                    .HasColumnName("neto_item")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.NombItem)
                    .HasColumnName("nomb_item")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.PrecItem)
                    .HasColumnName("prec_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecMono)
                    .HasColumnName("prec_mono")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecRefe)
                    .HasColumnName("prec_refe")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrneCofi)
                    .HasColumnName("prne_cofi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecaItem)
                    .HasColumnName("reca_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecaMone)
                    .HasColumnName("reca_mone")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.RecaPorc)
                    .HasColumnName("reca_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMedi)
                    .HasColumnName("unid_medi")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UnidRefe)
                    .HasColumnName("unid_refe")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ValoMone)
                    .HasColumnName("valo_mone")
                    .HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.CodiImpuNavigation)
                    .WithMany(p => p.DteDetaPrse)
                    .HasForeignKey(d => d.CodiImpu)
                    .HasConstraintName("dte_deps_fk_tiim");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteDetaPrse)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deps_fk_endo");
            });

            modelBuilder.Entity<DteDetaPrseH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("DTE_DTPR_H_PK");

                entity.ToTable("dte_deta_prse_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("DTE_DTPR_UK_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CantRefe)
                    .HasColumnName("cant_refe")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DctoItem)
                    .HasColumnName("dcto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DescPorc)
                    .HasColumnName("desc_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.FactConv)
                    .HasColumnName("fact_conv")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.FechElab)
                    .HasColumnName("fech_elab")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVepr)
                    .HasColumnName("fech_vepr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NetoItem)
                    .HasColumnName("neto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombItem)
                    .HasColumnName("nomb_item")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PrecItem)
                    .HasColumnName("prec_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecMono)
                    .HasColumnName("prec_mono")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecRefe)
                    .HasColumnName("prec_refe")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RecaItem)
                    .HasColumnName("reca_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecaPorc)
                    .HasColumnName("reca_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMedi)
                    .HasColumnName("unid_medi")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UnidRefe)
                    .HasColumnName("unid_refe")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiImpuNavigation)
                    .WithMany(p => p.DteDetaPrseH)
                    .HasForeignKey(d => d.CodiImpu)
                    .HasConstraintName("DTE_DEPS_H_FK_TIIM");

                entity.HasOne(d => d.DteEncaDocuH)
                    .WithMany(p => p.DteDetaPrseH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("DTE_DEPS_H_FK_ENDO");
            });

            modelBuilder.Entity<DteDetaPrseP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("dte_dtpr_p_pk");

                entity.ToTable("dte_deta_prse_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CantRefe)
                    .HasColumnName("cant_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DctoItem)
                    .HasColumnName("dcto_item")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.DescPorc)
                    .HasColumnName("desc_porc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FactConv)
                    .HasColumnName("fact_conv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechElab)
                    .HasColumnName("fech_elab")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechVepr)
                    .HasColumnName("fech_vepr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NetoItem)
                    .HasColumnName("neto_item")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombItem)
                    .HasColumnName("nomb_item")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrecItem)
                    .HasColumnName("prec_item")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.PrecMono)
                    .HasColumnName("prec_mono")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrecRefe)
                    .HasColumnName("prec_refe")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.RecaItem)
                    .HasColumnName("reca_item")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecaPorc)
                    .HasColumnName("reca_porc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMedi)
                    .HasColumnName("unid_medi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnidRefe)
                    .HasColumnName("unid_refe")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocuP)
                    .WithMany(p => p.DteDetaPrseP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_deps_fk_endo_p");
            });

            modelBuilder.Entity<DteDocuLob>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.TipoArch })
                    .HasName("DTE_DOCU_LOB_PK");

                entity.ToTable("DTE_DOCU_LOB");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("TIPO_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .HasColumnName("CLOB_DOCU")
                    .HasColumnType("text");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteDocuLob)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_docu_lob_fk_empr");
            });

            modelBuilder.Entity<DteDocuLobH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.TipoArch })
                    .HasName("DTE_DOCU_LOB_H_PK");

                entity.ToTable("DTE_DOCU_LOB_H");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("TIPO_ARCH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .HasColumnName("CLOB_DOCU")
                    .HasColumnType("text");

                entity.HasOne(d => d.DteEncaDocuH)
                    .WithMany(p => p.DteDocuLobH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_DOCLOBH_FK_ENDO");
            });

            modelBuilder.Entity<DteDocuRefe>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeRefe })
                    .HasName("dte_dore_pk");

                entity.ToTable("dte_docu_refe");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeRefe)
                    .HasColumnName("nume_refe")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("codi_refe")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiOtro)
                    .HasColumnName("digi_otro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliClie)
                    .HasColumnName("foli_clie")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRegl)
                    .HasColumnName("indi_regl")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("razo_refe")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOtro)
                    .HasColumnName("rutt_otro")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteDocuRefe)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_dore_fk_endo");
            });

            modelBuilder.Entity<DteDocuRefeH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeRefe })
                    .HasName("DTE_DORE_H_PK");

                entity.ToTable("dte_docu_refe_h");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeRefe)
                    .HasColumnName("nume_refe")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("codi_refe")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DigiOtro)
                    .HasColumnName("digi_otro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRegl)
                    .HasColumnName("indi_regl")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("razo_refe")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOtro)
                    .HasColumnName("rutt_otro")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocuH)
                    .WithMany(p => p.DteDocuRefeH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("DTE_DORE_H_FK_ENDO");
            });

            modelBuilder.Entity<DteDocuRefeP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeRefe })
                    .HasName("dte_dore_p_pk");

                entity.ToTable("dte_docu_refe_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeRefe)
                    .HasColumnName("nume_refe")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("codi_refe")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DigiOtro)
                    .HasColumnName("digi_otro")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRegl)
                    .HasColumnName("indi_regl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("razo_refe")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOtro)
                    .HasColumnName("rutt_otro")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocuP)
                    .WithMany(p => p.DteDocuRefeP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_dore_fk_endo_p");
            });

            modelBuilder.Entity<DteEncaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("dte_endo_pk");

                entity.ToTable("dte_enca_docu");

                entity.HasIndex(e => e.ColaProc)
                    .HasName("dte_cola_proc_idx");

                entity.HasIndex(e => e.CorrEnvi)
                    .HasName("IA_ENDO_CORR_ENVI");

                entity.HasIndex(e => e.CorrEnvi1)
                    .HasName("IA_ENDO_CORR_ENVI1");

                entity.HasIndex(e => e.EstaDocu)
                    .HasName("dte_enca_UK_esta");

                entity.HasIndex(e => new { e.CodiEmpr, e.FechEmis })
                    .HasName("IA_ENCA_DOCU1");

                entity.HasIndex(e => new { e.CodiEmpr, e.HaceEnvi })
                    .HasName("IA_ENVI_CONT");

                entity.HasIndex(e => new { e.CorrEnvi, e.TipoDocu })
                    .HasName("I3_DTE_ENCA");

                entity.HasIndex(e => new { e.RuttEmis, e.TipoDocu, e.FoliDocu })
                    .HasName("dte_endo_uk1")
                    .IsUnique();

                entity.HasIndex(e => new { e.EstaDocu, e.CodiEmpr, e.CorrEnvi, e.ColaProc })
                    .HasName("I2_DTE_ENCA");

                entity.HasIndex(e => new { e.CodiEmex, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.RuttRece })
                    .HasName("monitorESP");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ArchResp)
                    .HasColumnName("arch_resp")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BancPago)
                    .HasColumnName("banc_pago")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CantTara)
                    .HasColumnName("cant_tara")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.CiudDest)
                    .HasColumnName("ciud_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("ciud_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("ciud_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("ciud_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClauExpo)
                    .HasColumnName("clau_expo")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmtr)
                    .HasColumnName("codi_emtr")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiForm)
                    .HasColumnName("codi_form")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPude)
                    .HasColumnName("codi_pude")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiPuem)
                    .HasColumnName("codi_puem")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiRece)
                    .HasColumnName("codi_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .HasColumnName("codi_serv")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSuad)
                    .HasColumnName("codi_suad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiTepa)
                    .HasColumnName("codi_tepa")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("codi_vend")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColaProc)
                    .HasColumnName("cola_proc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComiExen)
                    .HasColumnName("comi_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComiIvaa)
                    .HasColumnName("comi_ivaa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComiNeto)
                    .HasColumnName("comi_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComuDest)
                    .HasColumnName("comu_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("comu_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("comu_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("comu_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("cont_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CorrCertFirm)
                    .HasColumnName("corr_cert_Firm")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrEnvi1)
                    .HasColumnName("corr_envi1")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrExtr)
                    .HasColumnName("corr_extr")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CredEs65)
                    .HasColumnName("cred_es65")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CuenPago)
                    .HasColumnName("cuen_pago")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DiasTepa)
                    .HasColumnName("dias_tepa")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DigiChof)
                    .HasColumnName("digi_chof")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiCitr)
                    .HasColumnName("digi_citr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiMand)
                    .HasColumnName("digi_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiSofa)
                    .HasColumnName("digi_sofa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiTran)
                    .HasColumnName("digi_tran")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireDest)
                    .HasColumnName("dire_dest")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("dire_orig")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("dire_post")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("dire_rece")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DocuEscd)
                    .HasColumnName("docu_escd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntrBien)
                    .HasColumnName("entr_bien")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu1)
                    .HasColumnName("esta_docu1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstaReme)
                    .HasColumnName("esta_reme")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EvenRecl)
                    .HasColumnName("even_recl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FacaOtmo)
                    .HasColumnName("faca_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FechAuto)
                    .HasColumnName("fech_auto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCanc)
                    .HasColumnName("fech_canc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCarg)
                    .HasColumnName("fech_carg")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechImpr)
                    .HasColumnName("fech_impr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FehoTed)
                    .HasColumnName("feho_ted")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmTed)
                    .HasColumnName("firm_ted")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FoliAuto)
                    .HasColumnName("foli_auto")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.FoliClie)
                    .HasColumnName("foli_clie")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FormPago)
                    .HasColumnName("form_pago")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FromPaex)
                    .HasColumnName("from_paex")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GaraEnva)
                    .HasColumnName("gara_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("giro_emis")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GiroRece)
                    .HasColumnName("giro_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GlosPago)
                    .HasColumnName("glos_pago")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaceEnvi)
                    .HasColumnName("hace_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.IdenAdem)
                    .HasColumnName("iden_adem")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenAdre)
                    .HasColumnName("iden_adre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenCitr)
                    .HasColumnName("iden_citr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenPude)
                    .HasColumnName("iden_pude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenPuem)
                    .HasColumnName("iden_puem")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenReex)
                    .HasColumnName("iden_reex")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImprDest)
                    .HasColumnName("impr_dest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVaag)
                    .HasColumnName("impu_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpuVanr)
                    .HasColumnName("impu_vanr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IndiNore)
                    .HasColumnName("indi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiVegd)
                    .HasColumnName("indi_vegd")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InfoTran)
                    .HasColumnName("info_tran")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IvaagCore)
                    .HasColumnName("ivaag_core")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagOtmo)
                    .HasColumnName("ivag_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.IvagProp)
                    .HasColumnName("ivag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagTerc)
                    .HasColumnName("ivag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvnoOtmo)
                    .HasColumnName("ivno_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.LoteDocu)
                    .HasColumnName("lote_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(CONVERT([varchar](7),getdate(),(120)))");

                entity.Property(e => e.MacoOtmo)
                    .HasColumnName("maco_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MailRece)
                    .HasColumnName("mail_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsta)
                    .HasColumnName("mens_esta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModaPago)
                    .HasColumnName("moda_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModaVent)
                    .HasColumnName("moda_vent")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MontBaco)
                    .HasColumnName("mont_baco")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBase)
                    .HasColumnName("mont_base")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBrut)
                    .HasColumnName("mont_brut")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MontCanc)
                    .HasColumnName("mont_canc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.MontFlet)
                    .HasColumnName("mont_flet")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontOtmo)
                    .HasColumnName("mont_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontSegu)
                    .HasColumnName("mont_segu")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.NaciExt)
                    .HasColumnName("naci_ext")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NetoOtmo)
                    .HasColumnName("neto_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NoafOtmo)
                    .HasColumnName("noaf_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombChof)
                    .HasColumnName("nomb_chof")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombCitr)
                    .HasColumnName("nomb_citr")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombTran)
                    .HasColumnName("nomb_tran")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeBook)
                    .HasColumnName("nume_book")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImme)
                    .HasColumnName("nume_imme")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaisDest)
                    .HasColumnName("pais_dest")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisRece)
                    .HasColumnName("pais_rece")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.RuttChof)
                    .HasColumnName("rutt_chof")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttCitr)
                    .HasColumnName("rutt_citr")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttMand)
                    .HasColumnName("rutt_mand")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttSofa)
                    .HasColumnName("rutt_sofa")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttTran)
                    .HasColumnName("rutt_tran")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("sald_ante")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaldInso)
                    .HasColumnName("sald_inso")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubtVese)
                    .HasColumnName("subt_vese")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoCamb)
                    .HasColumnName("tipo_camb")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.TipoCupa)
                    .HasColumnName("tipo_cupa")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TipoImpr)
                    .HasColumnName("tipo_impr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMone)
                    .HasColumnName("tipo_mone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMoom)
                    .HasColumnName("tipo_moom")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotaBrut)
                    .HasColumnName("tota_brut")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.TotaBult)
                    .HasColumnName("tota_bult")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaClex)
                    .HasColumnName("tota_clex")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotaItem)
                    .HasColumnName("tota_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNeto)
                    .HasColumnName("tota_neto")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.TranComp)
                    .HasColumnName("tran_comp")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TranVent)
                    .HasColumnName("tran_vent")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.UmedTara)
                    .HasColumnName("umed_tara")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidBrut)
                    .HasColumnName("unid_brut")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidNeto)
                    .HasColumnName("unid_neto")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UsuaImpr)
                    .HasColumnName("usua_impr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val7)
                    .HasColumnName("val7")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val8)
                    .HasColumnName("val8")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Val9)
                    .HasColumnName("val9")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ValoCoex)
                    .HasColumnName("valo_coex")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoCone)
                    .HasColumnName("valo_cone")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("valo_paga")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VersEnca)
                    .HasColumnName("vers_enca")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ViaaTran)
                    .HasColumnName("viaa_tran")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteEncaDocu)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_endo_fk_empr");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.DteEncaDocuCorrEnviNavigation)
                    .HasForeignKey(d => d.CorrEnvi)
                    .HasConstraintName("dte_endo_fk_envi");

                entity.HasOne(d => d.CorrEnvi1Navigation)
                    .WithMany(p => p.DteEncaDocuCorrEnvi1Navigation)
                    .HasForeignKey(d => d.CorrEnvi1)
                    .HasConstraintName("dte_endo_fk_envi1");

                entity.HasOne(d => d.CorrRafoNavigation)
                    .WithMany(p => p.DteEncaDocu)
                    .HasForeignKey(d => d.CorrRafo)
                    .HasConstraintName("dte_endo_fk_rafo");

                entity.HasOne(d => d.EstaDocuNavigation)
                    .WithMany(p => p.DteEncaDocu)
                    .HasForeignKey(d => d.EstaDocu)
                    .HasConstraintName("dte_endo_fk_esdo");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteEncaDocu)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_endo_fk_tido");
            });

            modelBuilder.Entity<DteEncaDocuH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("DTE_ENDO_H_PK");

                entity.ToTable("dte_enca_docu_h");

                entity.HasIndex(e => new { e.RuttEmis, e.TipoDocu, e.FoliDocu })
                    .HasName("DTE_ENDO_UK1_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ArchResp)
                    .HasColumnName("arch_resp")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BancPago)
                    .HasColumnName("banc_pago")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CantTara)
                    .HasColumnName("cant_tara")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.CiudDest)
                    .HasColumnName("ciud_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("ciud_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("ciud_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("ciud_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClauExpo)
                    .HasColumnName("clau_expo")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmtr)
                    .HasColumnName("codi_emtr")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPude)
                    .HasColumnName("codi_pude")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiPuem)
                    .HasColumnName("codi_puem")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiRece)
                    .HasColumnName("codi_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSuad)
                    .HasColumnName("codi_suad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiTepa)
                    .HasColumnName("codi_tepa")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("codi_vend")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ColaProc)
                    .HasColumnName("cola_proc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComuDest)
                    .HasColumnName("comu_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("comu_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("comu_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("comu_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("cont_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrEnvi1)
                    .HasColumnName("corr_envi1")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrExtr)
                    .HasColumnName("CORR_EXTR")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CredEs65)
                    .HasColumnName("cred_es65")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CuenPago)
                    .HasColumnName("cuen_pago")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DiasTepa)
                    .HasColumnName("dias_tepa")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DigiChof)
                    .HasColumnName("digi_chof")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiCitr)
                    .HasColumnName("digi_citr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiMand)
                    .HasColumnName("digi_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiSofa)
                    .HasColumnName("digi_sofa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiTran)
                    .HasColumnName("digi_tran")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireDest)
                    .HasColumnName("dire_dest")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("dire_orig")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("dire_post")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("dire_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntrBien)
                    .HasColumnName("entr_bien")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu1)
                    .HasColumnName("esta_docu1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FacaOtmo)
                    .HasColumnName("faca_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FechAuto)
                    .HasColumnName("fech_auto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCanc)
                    .HasColumnName("fech_canc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCarg)
                    .HasColumnName("fech_carg")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechImpr)
                    .HasColumnName("fech_impr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FehoTed)
                    .HasColumnName("feho_ted")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmTed)
                    .HasColumnName("firm_ted")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FoliAuto)
                    .HasColumnName("foli_auto")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.FoliClie)
                    .HasColumnName("FOLI_CLIE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FormPago)
                    .HasColumnName("form_pago")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FromPaex)
                    .HasColumnName("from_paex")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GaraEnva)
                    .HasColumnName("gara_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("giro_emis")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GiroRece)
                    .HasColumnName("giro_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GlosPago)
                    .HasColumnName("glos_pago")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaceEnvi)
                    .HasColumnName("hace_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.IdenAdem)
                    .HasColumnName("iden_adem")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenAdre)
                    .HasColumnName("iden_adre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenCitr)
                    .HasColumnName("iden_citr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenPude)
                    .HasColumnName("iden_pude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenPuem)
                    .HasColumnName("iden_puem")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenReex)
                    .HasColumnName("iden_reex")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImprDest)
                    .HasColumnName("impr_dest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVaag)
                    .HasColumnName("impu_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpuVanr)
                    .HasColumnName("impu_vanr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IndiNore)
                    .HasColumnName("indi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiVegd)
                    .HasColumnName("indi_vegd")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InfoTran)
                    .HasColumnName("info_tran")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IvaagCore)
                    .HasColumnName("ivaag_core")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagOtmo)
                    .HasColumnName("ivag_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.IvagProp)
                    .HasColumnName("ivag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagTerc)
                    .HasColumnName("ivag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvnoOtmo)
                    .HasColumnName("ivno_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MacoOtmo)
                    .HasColumnName("maco_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MailRece)
                    .HasColumnName("mail_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsta)
                    .HasColumnName("mens_esta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModaPago)
                    .HasColumnName("moda_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModaVent)
                    .HasColumnName("moda_vent")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MontBaco)
                    .HasColumnName("mont_baco")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBase)
                    .HasColumnName("mont_base")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBrut)
                    .HasColumnName("mont_brut")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MontCanc)
                    .HasColumnName("mont_canc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.MontFlet)
                    .HasColumnName("mont_flet")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontOtmo)
                    .HasColumnName("mont_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontSegu)
                    .HasColumnName("mont_segu")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.NaciExt)
                    .HasColumnName("naci_ext")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NetoOtmo)
                    .HasColumnName("neto_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NoafOtmo)
                    .HasColumnName("noaf_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombChof)
                    .HasColumnName("nomb_chof")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombCitr)
                    .HasColumnName("nomb_citr")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombTran)
                    .HasColumnName("nomb_tran")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeBook)
                    .HasColumnName("nume_book")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImme)
                    .HasColumnName("nume_imme")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaisDest)
                    .HasColumnName("pais_dest")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisRece)
                    .HasColumnName("pais_rece")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuttChof)
                    .HasColumnName("rutt_chof")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttCitr)
                    .HasColumnName("rutt_citr")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttMand)
                    .HasColumnName("rutt_mand")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttSofa)
                    .HasColumnName("rutt_sofa")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttTran)
                    .HasColumnName("rutt_tran")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("sald_ante")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaldInso)
                    .HasColumnName("sald_inso")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubtVese)
                    .HasColumnName("subt_vese")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoCamb)
                    .HasColumnName("tipo_camb")
                    .HasColumnType("numeric(6, 4)");

                entity.Property(e => e.TipoCupa)
                    .HasColumnName("tipo_cupa")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TipoImpr)
                    .HasColumnName("tipo_impr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMone)
                    .HasColumnName("tipo_mone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMoom)
                    .HasColumnName("tipo_moom")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMoto)
                    .HasColumnName("TIPO_MOTO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotaBrut)
                    .HasColumnName("tota_brut")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.TotaBult)
                    .HasColumnName("tota_bult")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaClex)
                    .HasColumnName("tota_clex")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotaItem)
                    .HasColumnName("tota_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNeto)
                    .HasColumnName("tota_neto")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.UmedTara)
                    .HasColumnName("umed_tara")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidBrut)
                    .HasColumnName("unid_brut")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidNeto)
                    .HasColumnName("unid_neto")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UsuaImpr)
                    .HasColumnName("usua_impr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val7)
                    .HasColumnName("val7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val8)
                    .HasColumnName("val8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val9)
                    .HasColumnName("val9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValoCoex)
                    .HasColumnName("valo_coex")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoCone)
                    .HasColumnName("valo_cone")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("valo_paga")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VersEnca)
                    .HasColumnName("vers_enca")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ViaaTran)
                    .HasColumnName("viaa_tran")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteEncaDocuH)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_ENDO_H_FK_EMPR");

                entity.HasOne(d => d.CorrEnvi1Navigation)
                    .WithMany(p => p.DteEncaDocuH)
                    .HasForeignKey(d => d.CorrEnvi1)
                    .HasConstraintName("DTE_ENDO_H_FK_ENVI1");

                entity.HasOne(d => d.CorrRafoNavigation)
                    .WithMany(p => p.DteEncaDocuH)
                    .HasForeignKey(d => d.CorrRafo)
                    .HasConstraintName("DTE_ENDO_H_FK_RAFO");

                entity.HasOne(d => d.EstaDocuNavigation)
                    .WithMany(p => p.DteEncaDocuH)
                    .HasForeignKey(d => d.EstaDocu)
                    .HasConstraintName("DTE_ENDO_H_FK_ESDO");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteEncaDocuH)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_ENDO_H_FK_TIDO");
            });

            modelBuilder.Entity<DteEncaDocuP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("dte_endo_p_pk");

                entity.ToTable("dte_enca_docu_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BancPago)
                    .HasColumnName("banc_pago")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CantTara)
                    .HasColumnName("cant_tara")
                    .HasColumnType("numeric(7, 0)");

                entity.Property(e => e.CiudDest)
                    .HasColumnName("ciud_dest")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("ciud_orig")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("ciud_post")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("ciud_rece")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ClauExpo)
                    .HasColumnName("clau_expo")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmtr)
                    .HasColumnName("codi_emtr")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPude)
                    .HasColumnName("codi_pude")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiPuem)
                    .HasColumnName("codi_puem")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiRece)
                    .HasColumnName("codi_rece")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSuad)
                    .HasColumnName("codi_suad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiTepa)
                    .HasColumnName("codi_tepa")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("codi_vend")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ComiExen)
                    .HasColumnName("comi_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComiIvaa)
                    .HasColumnName("comi_ivaa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComiNeto)
                    .HasColumnName("comi_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ComuDest)
                    .HasColumnName("comu_dest")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("comu_orig")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("comu_post")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("comu_rece")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("cont_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasMaxLength(66)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi1)
                    .HasColumnName("corr_envi1")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrExtr)
                    .HasColumnName("corr_extr")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CredEs65)
                    .HasColumnName("cred_es65")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CuenPago)
                    .HasColumnName("cuen_pago")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.DiasTepa)
                    .HasColumnName("dias_tepa")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DigiChof)
                    .HasColumnName("digi_chof")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiCitr)
                    .HasColumnName("digi_citr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiMand)
                    .HasColumnName("digi_mand")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiSofa)
                    .HasColumnName("digi_sofa")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiTran)
                    .HasColumnName("digi_tran")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireDest)
                    .HasColumnName("dire_dest")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("dire_orig")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("dire_post")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("dire_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EntrBien)
                    .HasColumnName("entr_bien")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu1)
                    .HasColumnName("esta_docu1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FacaOtmo)
                    .HasColumnName("faca_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.FechAuto)
                    .HasColumnName("fech_auto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCanc)
                    .HasColumnName("fech_canc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechCarg)
                    .HasColumnName("fech_carg")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FehoTed)
                    .HasColumnName("feho_ted")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirmTed)
                    .HasColumnName("firm_ted")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FoliAuto)
                    .HasColumnName("foli_auto")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.FoliClie)
                    .HasColumnName("foli_clie")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FormPago)
                    .HasColumnName("form_pago")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromPaex)
                    .HasColumnName("from_paex")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GaraEnva)
                    .HasColumnName("gara_enva")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("giro_emis")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.GiroRece)
                    .HasColumnName("giro_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.GlosPago)
                    .HasColumnName("glos_pago")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdenAdem)
                    .HasColumnName("iden_adem")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenAdre)
                    .HasColumnName("iden_adre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenCitr)
                    .HasColumnName("iden_citr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenPude)
                    .HasColumnName("iden_pude")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenPuem)
                    .HasColumnName("iden_puem")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdenReex)
                    .HasColumnName("iden_reex")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImprDest)
                    .HasColumnName("impr_dest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVaag)
                    .HasColumnName("impu_vaag")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVanr)
                    .HasColumnName("impu_vanr")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.IndiNore)
                    .HasColumnName("indi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiVegd)
                    .HasColumnName("indi_vegd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfoTran)
                    .HasColumnName("info_tran")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IvaagCore)
                    .HasColumnName("ivaag_core")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagOtmo)
                    .HasColumnName("ivag_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.IvagProp)
                    .HasColumnName("ivag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagTerc)
                    .HasColumnName("ivag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvnoOtmo)
                    .HasColumnName("ivno_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MacoOtmo)
                    .HasColumnName("maco_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MailRece)
                    .HasColumnName("mail_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsta)
                    .HasColumnName("mens_esta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModaPago)
                    .HasColumnName("moda_pago")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModaVent)
                    .HasColumnName("moda_vent")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MontBaco)
                    .HasColumnName("mont_baco")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBase)
                    .HasColumnName("mont_base")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontBrut)
                    .HasColumnName("mont_brut")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.MontCanc)
                    .HasColumnName("mont_canc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.MontFlet)
                    .HasColumnName("mont_flet")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontOtmo)
                    .HasColumnName("mont_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontSegu)
                    .HasColumnName("mont_segu")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(22, 4)");

                entity.Property(e => e.NaciExt)
                    .HasColumnName("naci_ext")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NetoOtmo)
                    .HasColumnName("neto_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NoafOtmo)
                    .HasColumnName("noaf_otmo")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NombChof)
                    .HasColumnName("nomb_chof")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombCitr)
                    .HasColumnName("nomb_citr")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombTran)
                    .HasColumnName("nomb_tran")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NumeBook)
                    .HasColumnName("nume_book")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaisDest)
                    .HasColumnName("pais_dest")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisRece)
                    .HasColumnName("pais_rece")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttChof)
                    .HasColumnName("rutt_chof")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttCitr)
                    .HasColumnName("rutt_citr")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.RuttMand)
                    .HasColumnName("rutt_mand")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttSofa)
                    .HasColumnName("rutt_sofa")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.RuttTran)
                    .HasColumnName("rutt_tran")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("sald_ante")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SaldInso)
                    .HasColumnName("sald_inso")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubtVese)
                    .HasColumnName("subt_vese")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCamb)
                    .HasColumnName("tipo_camb")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.TipoCupa)
                    .HasColumnName("tipo_cupa")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TipoImpr)
                    .HasColumnName("tipo_impr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMone)
                    .HasColumnName("tipo_mone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMoom)
                    .HasColumnName("tipo_moom")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TotaBrut)
                    .HasColumnName("tota_brut")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.TotaBult)
                    .HasColumnName("tota_bult")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaClex)
                    .HasColumnName("tota_clex")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotaItem)
                    .HasColumnName("tota_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNeto)
                    .HasColumnName("tota_neto")
                    .HasColumnType("numeric(12, 2)");

                entity.Property(e => e.UmedTara)
                    .HasColumnName("umed_tara")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidBrut)
                    .HasColumnName("unid_brut")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UnidNeto)
                    .HasColumnName("unid_neto")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val7)
                    .HasColumnName("val7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val8)
                    .HasColumnName("val8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val9)
                    .HasColumnName("val9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValoCoex)
                    .HasColumnName("valo_coex")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoCone)
                    .HasColumnName("valo_cone")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("valo_paga")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersEnca)
                    .HasColumnName("vers_enca")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ViaaTran)
                    .HasColumnName("viaa_tran")
                    .HasColumnType("numeric(2, 0)");
            });

            modelBuilder.Entity<DteEnviDocu>(entity =>
            {
                entity.HasKey(e => e.CorrEnvi)
                    .HasName("dte_envi_pk");

                entity.ToTable("dte_envi_docu");

                entity.HasIndex(e => e.EstaEnvi)
                    .HasName("dte_envi_UK_esta");

                entity.HasIndex(e => e.FehoEnvi)
                    .HasName("dte_envi_docu_feho");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BlocEnvi)
                    .HasColumnName("bloc_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BoleElec)
                    .HasColumnName("bole_elec")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ColaProc)
                    .HasColumnName("cola_proc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .HasColumnName("digi_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiPers)
                    .HasColumnName("digi_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("esta_envi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .HasColumnName("fech_reso")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechUpld)
                    .HasColumnName("FECH_UPLD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FehoEnvi)
                    .HasColumnName("feho_envi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .HasColumnName("nomb_arch")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeAten)
                    .HasColumnName("nume_aten")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("nume_envi")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeReso)
                    .HasColumnName("nume_reso")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.PosiEnvi)
                    .HasColumnName("posi_envi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("rutt_envi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttPers)
                    .HasColumnName("rutt_pers")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.VersEnvi)
                    .HasColumnName("vers_envi")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteEnviDocu)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("dte_envi_fk_empr");

                entity.HasOne(d => d.EstaEnviNavigation)
                    .WithMany(p => p.DteEnviDocu)
                    .HasForeignKey(d => d.EstaEnvi)
                    .HasConstraintName("dte_envi_fk_esen");
            });

            modelBuilder.Entity<DteEnviDocuH>(entity =>
            {
                entity.HasKey(e => e.CorrEnvi)
                    .HasName("dte_envi_h_pk");

                entity.ToTable("dte_envi_docu_h");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.BlocEnvi)
                    .HasColumnName("bloc_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BoleElec)
                    .HasColumnName("bole_elec")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ColaProc)
                    .HasColumnName("cola_proc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .HasColumnName("digi_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiPers)
                    .HasColumnName("digi_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("esta_envi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .HasColumnName("fech_reso")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechUpld)
                    .HasColumnName("FECH_UPLD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FehoEnvi)
                    .HasColumnName("feho_envi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .HasColumnName("nomb_arch")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeAten)
                    .HasColumnName("nume_aten")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("nume_envi")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeReso)
                    .HasColumnName("nume_reso")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PosiEnvi)
                    .HasColumnName("posi_envi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("rutt_envi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttPers)
                    .HasColumnName("rutt_pers")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.VersEnvi)
                    .HasColumnName("vers_envi")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteEnviDocuH)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("dte_envi_h_fk_empr");

                entity.HasOne(d => d.EstaEnviNavigation)
                    .WithMany(p => p.DteEnviDocuH)
                    .HasForeignKey(d => d.EstaEnvi)
                    .HasConstraintName("dte_envi_h_fk_esen");
            });

            modelBuilder.Entity<DteEnviLob>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrEnvi, e.TipoArch })
                    .HasName("dte_envi_lob_pk");

                entity.ToTable("dte_envi_lob");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("tipo_arch")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .IsRequired()
                    .HasColumnName("clob_docu")
                    .HasColumnType("text");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteEnviLob)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_envi_lob_fk_empr");
            });

            modelBuilder.Entity<DteEnviLobH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrEnvi, e.TipoArch })
                    .HasName("dte_envi_lob_h_pk");

                entity.ToTable("dte_envi_lob_h");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("tipo_arch")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .IsRequired()
                    .HasColumnName("clob_docu")
                    .HasColumnType("text");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteEnviLobH)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_envi_lob_hfk_empr");
            });

            modelBuilder.Entity<DteEnviPdf>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.PosiMail })
                    .HasName("dte_envi_pdf_PK");

                entity.ToTable("dte_envi_pdf");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PosiMail)
                    .HasColumnName("posi_mail")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.EstaMlpr)
                    .IsRequired()
                    .HasColumnName("ESTA_MLPR")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ING')");

                entity.Property(e => e.HaceEnvi)
                    .HasColumnName("hace_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.MailCc)
                    .HasColumnName("mail_cc")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MailCco)
                    .HasColumnName("mail_cco")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MailEnvi)
                    .HasColumnName("mail_envi")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MailText)
                    .HasColumnName("mail_text")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MapeFrom)
                    .HasColumnName("MAPE_FROM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MapeRef)
                    .HasColumnName("MAPE_REF")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteEnviPdf)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_endo_enpdf");
            });

            modelBuilder.Entity<DteEnviTrace>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrEnvi, e.FehoTrac, e.EstaTrac })
                    .HasName("dte_entr_pk");

                entity.ToTable("dte_envi_trace");

                entity.HasIndex(e => new { e.CodiEmpr, e.CorrEnvi })
                    .HasName("ia_dte_entra");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FehoTrac)
                    .HasColumnName("feho_trac")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstaTrac)
                    .HasColumnName("esta_trac")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteEstaApro>(entity =>
            {
                entity.HasKey(e => e.CodiEsap)
                    .HasName("dte_esap_pk");

                entity.ToTable("dte_esta_apro");

                entity.HasIndex(e => e.CodiEsap)
                    .HasName("dte_esap_idx");

                entity.Property(e => e.CodiEsap)
                    .HasColumnName("codi_esap")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescEsap)
                    .HasColumnName("desc_esap")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteEstaCesi>(entity =>
            {
                entity.HasKey(e => e.EstaCesi)
                    .HasName("dte_esci_pk");

                entity.ToTable("dte_esta_cesi");

                entity.Property(e => e.EstaCesi)
                    .HasColumnName("esta_cesi")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DescCesi)
                    .IsRequired()
                    .HasColumnName("desc_cesi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MailEsci)
                    .HasColumnName("mail_esci")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsci)
                    .HasColumnName("mens_esci")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("nume_envi")
                    .HasColumnType("numeric(10, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoEsta)
                    .IsRequired()
                    .HasColumnName("tipo_esta")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteEstaDocu>(entity =>
            {
                entity.HasKey(e => e.EstaDocu)
                    .HasName("dte_esdo_pk");

                entity.ToTable("dte_esta_docu");

                entity.HasIndex(e => e.DescEsdo)
                    .HasName("dte_esdo_uk")
                    .IsUnique();

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DescEsdo)
                    .HasColumnName("desc_esdo")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EnviCont)
                    .HasColumnName("envi_cont")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HelpEsdo)
                    .HasColumnName("help_esdo")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IndiCesi)
                    .HasColumnName("indi_cesi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiClie)
                    .HasColumnName("indi_clie")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IndiImpr)
                    .HasColumnName("indi_impr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiLibr)
                    .HasColumnName("INDI_LIBR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MailEsdo)
                    .HasColumnName("mail_esdo")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsdo)
                    .HasColumnName("mens_esdo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteEstaEnvi>(entity =>
            {
                entity.HasKey(e => e.EstaEnvi)
                    .HasName("dte_esen_pk");

                entity.ToTable("dte_esta_envi");

                entity.HasIndex(e => e.DescEsen)
                    .HasName("dte_esen_uk")
                    .IsUnique();

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("esta_envi")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DescEsen)
                    .HasColumnName("desc_esen")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EnviCont)
                    .HasColumnName("envi_cont")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HelpEsen)
                    .HasColumnName("help_esen")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MailEsen)
                    .HasColumnName("mail_esen")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsen)
                    .HasColumnName("mens_esen")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("nume_envi")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ReviDocu)
                    .HasColumnName("revi_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReviEnvi)
                    .HasColumnName("revi_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteEstaRecl>(entity =>
            {
                entity.HasKey(e => new { e.CodiRecl, e.TipoRecl });

                entity.ToTable("dte_esta_recl");

                entity.Property(e => e.CodiRecl)
                    .HasColumnName("codi_recl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRecl)
                    .HasColumnName("tipo_recl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescRecl)
                    .IsRequired()
                    .HasColumnName("desc_recl")
                    .HasMaxLength(90)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteFase>(entity =>
            {
                entity.HasKey(e => e.FaseEsdo)
                    .HasName("dte_fase_pk");

                entity.ToTable("dte_fase");

                entity.Property(e => e.FaseEsdo)
                    .HasColumnName("fase_esdo")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FaseDesc)
                    .HasColumnName("fase_desc")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteFoliClie>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("dtfocl_pk");

                entity.ToTable("dte_foli_clie");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.EstaTras)
                    .HasColumnName("esta_tras")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.FoliClie)
                    .IsRequired()
                    .HasColumnName("foli_clie")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");
            });

            modelBuilder.Entity<DteFormatos>(entity =>
            {
                entity.HasKey(e => e.CodiForm)
                    .HasName("PK_CODI_FORM");

                entity.ToTable("DTE_FORMATOS");

                entity.Property(e => e.CodiForm)
                    .HasColumnName("CODI_FORM")
                    .HasColumnType("numeric(30, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("CODI_EMEX")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPlan)
                    .IsRequired()
                    .HasColumnName("CODI_PLAN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NombPlan)
                    .IsRequired()
                    .HasColumnName("NOMB_PLAN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TipoPlan)
                    .IsRequired()
                    .HasColumnName("TIPO_PLAN")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('XSLT')");
            });

            modelBuilder.Entity<DteOrgaCert>(entity =>
            {
                entity.HasKey(e => e.CodiOrce)
                    .HasName("dte_orce_pk");

                entity.ToTable("dte_orga_cert");

                entity.Property(e => e.CodiOrce)
                    .HasColumnName("codi_orce")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DigiOrce)
                    .HasColumnName("digi_orce")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombOrce)
                    .HasColumnName("nomb_orce")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOrce)
                    .HasColumnName("rutt_orce")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<DteProcEvnt>(entity =>
            {
                entity.HasKey(e => e.CorrEvnt)
                    .HasName("dte_proc_evnt_pk");

                entity.ToTable("dte_proc_evnt");

                entity.HasIndex(e => new { e.EstaEvnt, e.FechProcEvnt, e.ContProcEvnt })
                    .HasName("dte_proc_evnt_idx");

                entity.Property(e => e.CorrEvnt)
                    .HasColumnName("corr_evnt")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .IsRequired()
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiRtrn)
                    .HasColumnName("codi_rtrn")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ContProcEvnt)
                    .HasColumnName("cont_proc_evnt")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CurlPara)
                    .HasColumnName("curl_para")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .IsRequired()
                    .HasColumnName("digi_emis")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .IsRequired()
                    .HasColumnName("digi_rece")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEvnt)
                    .IsRequired()
                    .HasColumnName("esta_evnt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EvntSii)
                    .IsRequired()
                    .HasColumnName("evnt_sii")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechEvnt)
                    .HasColumnName("fech_evnt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechProcEvnt)
                    .HasColumnName("fech_proc_evnt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FoliDocu)
                    .IsRequired()
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MensErroEvnt)
                    .HasColumnName("mens_erro_evnt")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RespSii)
                    .HasColumnName("resp_sii")
                    .HasColumnType("text");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoDocu)
                    .IsRequired()
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteRangFoli>(entity =>
            {
                entity.HasKey(e => e.CorrRafo)
                    .HasName("dte_rafo_pk");

                entity.ToTable("dte_rang_foli");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDora, e.FoliDesd })
                    .HasName("dte_rafo_uk")
                    .IsUnique();

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArchCaf)
                    .HasColumnName("arch_caf")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CafIngr)
                    .HasColumnName("caf_ingr")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiOfic)
                    .HasColumnName("codi_ofic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmpr)
                    .HasColumnName("digi_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstaRafo)
                    .HasColumnName("esta_rafo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechAuto)
                    .HasColumnName("fech_auto")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechSoli)
                    .HasColumnName("fech_soli")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirmSii)
                    .HasColumnName("firm_sii")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDesd)
                    .HasColumnName("foli_desd")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FoliHast)
                    .HasColumnName("foli_hast")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.LlavPrivRafo)
                    .HasColumnName("llav_priv_rafo")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LlavPublRafo)
                    .HasColumnName("llav_publ_rafo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LlavPucoExpo)
                    .HasColumnName("llav_puco_expo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LlavPucoModu)
                    .HasColumnName("llav_puco_modu")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LlavPusiIden)
                    .HasColumnName("llav_pusi_iden")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RazoSoci)
                    .HasColumnName("razo_soci")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmpr)
                    .HasColumnName("rutt_empr")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoDora)
                    .HasColumnName("tipo_dora")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.UltiAsig)
                    .HasColumnName("ulti_asig")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.UltiFoli)
                    .HasColumnName("ulti_foli")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DteRangFoli)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("dte_rafo_fk_empr");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.DteRangFoli)
                    .HasForeignKey(d => d.CodiPers)
                    .HasConstraintName("dte_rafo_fk_pers");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.DteRangFoli)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .HasConstraintName("dte_rafo_fk_ceco");

                entity.HasOne(d => d.CodiNavigation)
                    .WithMany(p => p.DteRangFoli)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiOfic })
                    .HasConstraintName("dte_rafo_fk_ofic");
            });

            modelBuilder.Entity<DteRecaItem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrReit })
                    .HasName("dte_reit_pk");

                entity.ToTable("dte_reca_item");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrReit)
                    .HasColumnName("corr_reit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoReca)
                    .HasColumnName("tipo_reca")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoReca)
                    .HasColumnName("valo_reca")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DteDetaPrse)
                    .WithMany(p => p.DteRecaItem)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_reit_fk_dtpr");
            });

            modelBuilder.Entity<DteRecaItemH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrReit })
                    .HasName("DTE_REIT_H_PK");

                entity.ToTable("dte_reca_item_h");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrReit)
                    .HasColumnName("corr_reit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReca)
                    .HasColumnName("tipo_reca")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoReca)
                    .HasColumnName("valo_reca")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DteDetaPrseH)
                    .WithMany(p => p.DteRecaItemH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .HasConstraintName("DTE_REIT_H_FK_DTPR");
            });

            modelBuilder.Entity<DteRecaItemP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrReit })
                    .HasName("dte_reit_p_pk");

                entity.ToTable("dte_reca_item_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrReit)
                    .HasColumnName("corr_reit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReca)
                    .HasColumnName("tipo_reca")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValoReca)
                    .HasColumnName("valo_reca")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrseP)
                    .WithMany(p => p.DteRecaItemP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_reit_fk_dtpr_p");
            });

            modelBuilder.Entity<DteSucaItem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrSuca })
                    .HasName("dte_scit_pk");

                entity.ToTable("dte_suca_item");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CodiSuca })
                    .HasName("dte_scit_uk")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrSuca)
                    .HasColumnName("corr_suca")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiSuca)
                    .HasColumnName("codi_suca")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.SucaDist)
                    .HasColumnName("suca_dist")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.TipoSuca)
                    .HasColumnName("tipo_suca")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrse)
                    .WithMany(p => p.DteSucaItem)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_suit_fk_dtpr");
            });

            modelBuilder.Entity<DteSucaItemH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrSuca })
                    .HasName("DTE_SCIT_H_PK");

                entity.ToTable("dte_suca_item_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CodiSuca })
                    .HasName("DTE_SCIT_H_UK")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrSuca)
                    .HasColumnName("corr_suca")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiSuca)
                    .HasColumnName("codi_suca")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SucaDist)
                    .HasColumnName("suca_dist")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DteDetaPrseH)
                    .WithMany(p => p.DteSucaItemH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .HasConstraintName("DTE_SUIT_H_FK_DTPR");
            });

            modelBuilder.Entity<DteSucaItemP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrSuca })
                    .HasName("dte_scit_p_pk");

                entity.ToTable("dte_suca_item_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrSuca)
                    .HasColumnName("corr_suca")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiSuca)
                    .HasColumnName("codi_suca")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SucaDist)
                    .HasColumnName("suca_dist")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteDetaPrseP)
                    .WithMany(p => p.DteSucaItemP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_suit_fk_dtpr_p");
            });

            modelBuilder.Entity<DteSucuEmis>(entity =>
            {
                entity.HasKey(e => e.CodiSucu)
                    .HasName("dte_sucemis_pk");

                entity.ToTable("dte_sucu_emis");

                entity.HasIndex(e => e.DiipSucu)
                    .HasName("dte_sucemis_uk")
                    .IsUnique();

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiipSucu)
                    .HasColumnName("diip_sucu")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MailEsen)
                    .HasColumnName("mail_esen")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsen)
                    .HasColumnName("mens_esen")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteSumaImom>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("PK__DTE_SUMA_IMOM__7E6372D6");

                entity.ToTable("DTE_SUMA_IMOM");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("CODI_IMPU")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("TASA_IMPU")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ValoImre)
                    .HasColumnName("valo_imre")
                    .HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteSumaImom)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DTE_SUMA_IMOM__7F57970F");
            });

            modelBuilder.Entity<DteSumaImpu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("dte_suim_pk");

                entity.ToTable("dte_suma_impu");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CodiImpuNavigation)
                    .WithMany(p => p.DteSumaImpu)
                    .HasForeignKey(d => d.CodiImpu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_suim_fk_tiim");

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteSumaImpu)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_suim_fk_endo");
            });

            modelBuilder.Entity<DteSumaImpuH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("DTE_SUIM_H_PK");

                entity.ToTable("dte_suma_impu_h");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("DTE_SUIM_PK_H")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CodiImpuNavigation)
                    .WithMany(p => p.DteSumaImpuH)
                    .HasForeignKey(d => d.CodiImpu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_SUIM_H_FK_TIIM");

                entity.HasOne(d => d.DteEncaDocuH)
                    .WithMany(p => p.DteSumaImpuH)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .HasConstraintName("DTE_SUIM_H_FK_ENDO");
            });

            modelBuilder.Entity<DteSumaImpuP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("dte_suim_p_pk");

                entity.ToTable("dte_suma_impu_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocuP)
                    .WithMany(p => p.DteSumaImpuP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_suim_fk_endo_p");
            });

            modelBuilder.Entity<DteTidoEnvi>(entity =>
            {
                entity.HasKey(e => new { e.CorrEnvi, e.TipoDocu })
                    .HasName("dte_tdev_pk");

                entity.ToTable("dte_tido_envi");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.DteTidoEnvi)
                    .HasForeignKey(d => d.CorrEnvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_tien_fk_envi");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteTidoEnvi)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_tien_fk_tido");
            });

            modelBuilder.Entity<DteTidoEnviH>(entity =>
            {
                entity.HasKey(e => new { e.CorrEnvi, e.TipoDocu })
                    .HasName("dte_tdev_h_pk");

                entity.ToTable("dte_tido_envi_h");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.DteTidoEnviH)
                    .HasForeignKey(d => d.CorrEnvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_tien_h_fk_envi");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DteTidoEnviH)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dte_tien_h_fk_tido");
            });

            modelBuilder.Entity<DteTipoBult>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiTibu })
                    .HasName("PK__dte_tipo_bult__032827F3");

                entity.ToTable("dte_tipo_bult");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiTibu)
                    .HasColumnName("codi_tibu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantBult)
                    .HasColumnName("cant_bult")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.IdenCont)
                    .HasColumnName("iden_cont")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdenMarc)
                    .HasColumnName("iden_marc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.SelloCont)
                    .HasColumnName("sello_cont")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.DteEncaDocu)
                    .WithMany(p => p.DteTipoBult)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dte_tipo_bult__041C4C2C");
            });

            modelBuilder.Entity<DteTipoDocu>(entity =>
            {
                entity.HasKey(e => e.TipoDocu)
                    .HasName("dte_tido_pk");

                entity.ToTable("dte_tipo_docu");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.BoleElec)
                    .HasColumnName("bole_elec")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClasDocu)
                    .HasColumnName("clas_docu")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DescTido)
                    .HasColumnName("desc_tido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DocuElec)
                    .HasColumnName("docu_elec")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DocuRefe)
                    .HasColumnName("docu_refe")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IndiCesi)
                    .HasColumnName("indi_cesi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiDigi)
                    .HasColumnName("indi_digi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiDnte)
                    .HasColumnName("indi_dnte")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiLibr)
                    .HasColumnName("indi_libr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IndiReci)
                    .HasColumnName("INDI_RECI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImme)
                    .HasColumnName("nume_imme")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.OrdeEnvi)
                    .HasColumnName("orde_envi")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RepoAuto)
                    .HasColumnName("repo_auto")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComo)
                    .HasColumnName("tipo_como")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TramImme)
                    .HasColumnName("tram_imme")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TramImpr)
                    .HasColumnName("tram_impr")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteTipoImpu>(entity =>
            {
                entity.HasKey(e => e.CodiImpu)
                    .HasName("dte_tiim_pk");

                entity.ToTable("dte_tipo_impu");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescImpu)
                    .HasColumnName("desc_impu")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombImpu)
                    .HasColumnName("nomb_impu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PorcImpu)
                    .HasColumnName("porc_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteTipoOrig>(entity =>
            {
                entity.HasKey(e => e.TipoOrig)
                    .HasName("DTTIOR_PK");

                entity.ToTable("dte_tipo_orig");

                entity.Property(e => e.TipoOrig)
                    .HasColumnName("TIPO_ORIG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DescOrig)
                    .IsRequired()
                    .HasColumnName("DESC_ORIG")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteTrace>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.FehoTrac, e.EstaTrac })
                    .HasName("dte_trace_pk");

                entity.ToTable("dte_trace");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("ia_dte_trace");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FehoTrac)
                    .HasColumnName("feho_trac")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstaTrac)
                    .HasColumnName("esta_trac")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DteUsuaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiUsua, e.TipoDocu })
                    .HasName("DTCODITIP");

                entity.ToTable("dte_usua_docu");

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<DteValiErro>(entity =>
            {
                entity.HasKey(e => e.CodiErro)
                    .HasName("dte_vaer_pk");

                entity.ToTable("dte_vali_erro");

                entity.HasIndex(e => e.CodiSqls)
                    .HasName("dte_vaer_uk")
                    .IsUnique();

                entity.Property(e => e.CodiErro)
                    .HasColumnName("codi_erro")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiSqls)
                    .HasColumnName("codi_sqls")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DescErro)
                    .HasColumnName("desc_erro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndiDnte)
                    .HasColumnName("indi_dnte")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoErro)
                    .HasColumnName("tipo_erro")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtecAddress>(entity =>
            {
                entity.HasKey(e => e.CorrAddr)
                    .HasName("PK_address");

                entity.ToTable("dtec_address");

                entity.HasIndex(e => e.NameAddr)
                    .HasName("idx_addr_name")
                    .IsUnique();

                entity.Property(e => e.CorrAddr)
                    .HasColumnName("corr_addr")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MethAddr)
                    .HasColumnName("meth_addr")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NameAddr)
                    .IsRequired()
                    .HasColumnName("name_addr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PswdMail)
                    .HasColumnName("pswd_mail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PswdPrxy)
                    .HasColumnName("pswd_prxy")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UrllAddr)
                    .IsRequired()
                    .HasColumnName("urll_addr")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.UserMail)
                    .HasColumnName("user_mail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UserPrxy)
                    .HasColumnName("user_prxy")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtecEmprAuth>(entity =>
            {
                entity.HasKey(e => e.CorrEmpr)
                    .HasName("PK_empr_auth");

                entity.ToTable("dtec_empr_auth");

                entity.HasIndex(e => new { e.HoldEmpr, e.RuttEmpr, e.DigiEmpr })
                    .HasName("idx_empr_auth")
                    .IsUnique();

                entity.Property(e => e.CorrEmpr)
                    .HasColumnName("corr_empr")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CertEmpr)
                    .HasColumnName("cert_empr")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ChngSsii)
                    .HasColumnName("chng_ssii")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ClavAcsi)
                    .HasColumnName("clav_acsi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmpr)
                    .IsRequired()
                    .HasColumnName("digi_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HoldEmpr)
                    .HasColumnName("hold_empr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmpr)
                    .IsRequired()
                    .HasColumnName("nomb_empr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmpr)
                    .HasColumnName("rutt_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ToknEmpr)
                    .HasColumnName("tokn_empr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToknTmst)
                    .HasColumnName("tokn_tmst")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DtecMessage>(entity =>
            {
                entity.HasKey(e => e.CorrMsge)
                    .HasName("PK_message");

                entity.ToTable("dtec_message");

                entity.HasIndex(e => e.NameMsge)
                    .HasName("idx_msge_name")
                    .IsUnique();

                entity.Property(e => e.CorrMsge)
                    .HasColumnName("corr_msge")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NameMsge)
                    .IsRequired()
                    .HasColumnName("name_msge")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMsge)
                    .IsRequired()
                    .HasColumnName("tipo_msge")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TmplMsge)
                    .IsRequired()
                    .HasColumnName("tmpl_msge")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ToknUsed)
                    .IsRequired()
                    .HasColumnName("tokn_used")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtecQueueMsge>(entity =>
            {
                entity.HasKey(e => e.CorrQmsg)
                    .HasName("PK_qmsg");

                entity.ToTable("dtec_queue_msge");

                entity.Property(e => e.CorrQmsg)
                    .HasColumnName("corr_qmsg")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApplName)
                    .IsRequired()
                    .HasColumnName("appl_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurlPara)
                    .IsRequired()
                    .HasColumnName("curl_para")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmpr)
                    .IsRequired()
                    .HasColumnName("digi_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstaQmsg)
                    .IsRequired()
                    .HasColumnName("esta_qmsg")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdenDocu)
                    .HasColumnName("iden_docu")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.IdenEvnt)
                    .HasColumnName("iden_evnt")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.NameAddr)
                    .IsRequired()
                    .HasColumnName("name_addr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NameMsge)
                    .IsRequired()
                    .HasColumnName("name_msge")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RespQmsg)
                    .HasColumnName("resp_qmsg")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmpr)
                    .HasColumnName("rutt_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TmstProc)
                    .HasColumnName("tmst_proc")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmstRegi)
                    .HasColumnName("tmst_regi")
                    .HasColumnType("datetime");

                entity.Property(e => e.TmstResp)
                    .HasColumnName("tmst_resp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DtoDescItem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrDeit })
                    .HasName("DTO_DEIT_PK");

                entity.ToTable("dto_desc_item");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrDeit)
                    .HasColumnName("corr_deit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("tipo_desc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDesc)
                    .HasColumnName("valo_desc")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DtoDetaPrse)
                    .WithMany(p => p.DtoDescItem)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deit_fk_dtpr");
            });

            modelBuilder.Entity<DtoDescItemP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeLine, e.CorrDeit })
                    .HasName("DTO_DEIT_P_PK");

                entity.ToTable("dto_desc_item_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrDeit)
                    .HasColumnName("corr_deit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("tipo_desc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDesc)
                    .HasColumnName("valo_desc")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoDetaPrseP)
                    .WithMany(p => p.DtoDescItemP)
                    .HasForeignKey(d => new { d.CorrDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deit_fk_dtpr_p");
            });

            modelBuilder.Entity<DtoDescReca>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeDere })
                    .HasName("dto_dere_pk");

                entity.ToTable("dto_desc_reca");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeDere)
                    .HasColumnName("nume_dere")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GlosDere)
                    .HasColumnName("glos_dere")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipoDere)
                    .HasColumnName("tipo_dere")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("tipo_valo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDere)
                    .HasColumnName("valo_dere")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DtoEncaDocu)
                    .WithMany(p => p.DtoDescReca)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_dere_fk_endo");
            });

            modelBuilder.Entity<DtoDescRecaH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeDere })
                    .HasName("dto_dere_h_pk");

                entity.ToTable("dto_desc_reca_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeDere)
                    .HasColumnName("nume_dere")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GlosDere)
                    .HasColumnName("glos_dere")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDere)
                    .HasColumnName("tipo_dere")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("tipo_valo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDere)
                    .HasColumnName("valo_dere")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<DtoDescRecaP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeDere })
                    .HasName("dto_dere_p_pk");

                entity.ToTable("dto_desc_reca_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeDere)
                    .HasColumnName("nume_dere")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GlosDere)
                    .HasColumnName("glos_dere")
                    .HasMaxLength(135)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoDere)
                    .HasColumnName("tipo_dere")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.TipoValo)
                    .HasColumnName("tipo_valo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValoDere)
                    .HasColumnName("valo_dere")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.CorrDocuNavigation)
                    .WithMany(p => p.DtoDescRecaP)
                    .HasForeignKey(d => d.CorrDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_dere_fk_endo_p");
            });

            modelBuilder.Entity<DtoDetaAcec>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CorrAcec })
                    .HasName("dto_acec_pk");

                entity.ToTable("dto_deta_acec");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiAcec })
                    .HasName("dto_acec_uk")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CorrAcec)
                    .HasColumnName("corr_acec")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoEncaDocu)
                    .WithMany(p => p.DtoDetaAcec)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deac_fk_endo");
            });

            modelBuilder.Entity<DtoDetaAcecH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CorrAcec })
                    .HasName("dto_acec_h_pk");

                entity.ToTable("dto_deta_acec_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CorrAcec)
                    .HasColumnName("corr_acec")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoDetaAcecP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CorrAcec })
                    .HasName("dto_acec_p_pk");

                entity.ToTable("dto_deta_acec_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CorrAcec)
                    .HasColumnName("corr_acec")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiAcec)
                    .HasColumnName("codi_acec")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.CorrDocuNavigation)
                    .WithMany(p => p.DtoDetaAcecP)
                    .HasForeignKey(d => d.CorrDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deac_fk_endo_p");
            });

            modelBuilder.Entity<DtoDetaCodi>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrCodi })
                    .HasName("dto_deco_pk");

                entity.ToTable("dto_deta_codi");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrCodi)
                    .HasColumnName("corr_codi")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoDetaPrse)
                    .WithMany(p => p.DtoDetaCodi)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deco_fk_deps");
            });

            modelBuilder.Entity<DtoDetaCodiH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrCodi })
                    .HasName("dto_deco_h_pk");

                entity.ToTable("dto_deta_codi_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrCodi)
                    .HasColumnName("corr_codi")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoDetaCodiP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeLine, e.CorrCodi })
                    .HasName("dto_deco_p_pk");

                entity.ToTable("dto_deta_codi_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrCodi)
                    .HasColumnName("corr_codi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoDetaPrseP)
                    .WithMany(p => p.DtoDetaCodiP)
                    .HasForeignKey(d => new { d.CorrDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deco_fk_deps_p");
            });

            modelBuilder.Entity<DtoDetaPrse>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("dto_dtpr_pk");

                entity.ToTable("dto_deta_prse");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CantRefe)
                    .HasColumnName("cant_refe")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DctoItem)
                    .HasColumnName("dcto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DescPorc)
                    .HasColumnName("desc_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.FactConv)
                    .HasColumnName("fact_conv")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.FechElab)
                    .HasColumnName("fech_elab")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVepr)
                    .HasColumnName("fech_vepr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NetoItem)
                    .HasColumnName("neto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombItem)
                    .HasColumnName("nomb_item")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PrecItem)
                    .HasColumnName("prec_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecMono)
                    .HasColumnName("prec_mono")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecRefe)
                    .HasColumnName("prec_refe")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RecaItem)
                    .HasColumnName("reca_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecaPorc)
                    .HasColumnName("reca_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMedi)
                    .HasColumnName("unid_medi")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UnidRefe)
                    .HasColumnName("unid_refe")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiImpuNavigation)
                    .WithMany(p => p.DtoDetaPrse)
                    .HasForeignKey(d => d.CodiImpu)
                    .HasConstraintName("dto_deps_fk_tiim");

                entity.HasOne(d => d.DtoEncaDocu)
                    .WithMany(p => p.DtoDetaPrse)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deps_fk_endo");
            });

            modelBuilder.Entity<DtoDetaPrseH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine })
                    .HasName("dto_dtpr_h_pk");

                entity.ToTable("dto_deta_prse_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.CantRefe)
                    .HasColumnName("cant_refe")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DctoItem)
                    .HasColumnName("dcto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DescPorc)
                    .HasColumnName("desc_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.FactConv)
                    .HasColumnName("fact_conv")
                    .HasColumnType("numeric(10, 4)");

                entity.Property(e => e.FechElab)
                    .HasColumnName("fech_elab")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVepr)
                    .HasColumnName("fech_vepr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NetoItem)
                    .HasColumnName("neto_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombItem)
                    .HasColumnName("nomb_item")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PrecItem)
                    .HasColumnName("prec_item")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecMono)
                    .HasColumnName("prec_mono")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PrecRefe)
                    .HasColumnName("prec_refe")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.RecaItem)
                    .HasColumnName("reca_item")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RecaPorc)
                    .HasColumnName("reca_porc")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMedi)
                    .HasColumnName("unid_medi")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UnidRefe)
                    .HasColumnName("unid_refe")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoDetaPrseP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeLine })
                    .HasName("dto_dtpr_p_pk");

                entity.ToTable("dto_deta_prse_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CantItem)
                    .HasColumnName("cant_item")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.CantRefe)
                    .HasColumnName("cant_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiItem)
                    .HasColumnName("codi_item")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DctoItem)
                    .HasColumnName("dcto_item")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescItem)
                    .HasColumnName("desc_item")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.DescPorc)
                    .HasColumnName("desc_porc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FactConv)
                    .HasColumnName("fact_conv")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechElab)
                    .HasColumnName("fech_elab")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechVepr)
                    .HasColumnName("fech_vepr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiExen)
                    .HasColumnName("indi_exen")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.NetoItem)
                    .HasColumnName("neto_item")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombItem)
                    .HasColumnName("nomb_item")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.PrecItem)
                    .HasColumnName("prec_item")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.PrecMono)
                    .HasColumnName("prec_mono")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PrecRefe)
                    .HasColumnName("prec_refe")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.RecaItem)
                    .HasColumnName("reca_item")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecaPorc)
                    .HasColumnName("reca_porc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCodi)
                    .HasColumnName("tipo_codi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.UnidMedi)
                    .HasColumnName("unid_medi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnidRefe)
                    .HasColumnName("unid_refe")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.CorrDocuNavigation)
                    .WithMany(p => p.DtoDetaPrseP)
                    .HasForeignKey(d => d.CorrDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_deps_fk_endo_p");
            });

            modelBuilder.Entity<DtoDocuLob>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrDocu, e.TipoArch })
                    .HasName("dto_docu_lob_pk");

                entity.ToTable("dto_docu_lob");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("tipo_arch")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .IsRequired()
                    .HasColumnName("clob_docu")
                    .HasColumnType("text");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DtoDocuLob)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_docu_lob_fk_empr");
            });

            modelBuilder.Entity<DtoDocuLobH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrDocu, e.TipoArch })
                    .HasName("dto_docu_lob_h_pk");

                entity.ToTable("dto_docu_lob_h");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("tipo_arch")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .IsRequired()
                    .HasColumnName("clob_docu")
                    .HasColumnType("text");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DtoDocuLobH)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_docu_lob_h_fk_empr");
            });

            modelBuilder.Entity<DtoDocuRefe>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeRefe })
                    .HasName("dto_dore_pk");

                entity.ToTable("dto_docu_refe");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeRefe)
                    .HasColumnName("nume_refe")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("codi_refe")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DigiOtro)
                    .HasColumnName("digi_otro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRegl)
                    .HasColumnName("indi_regl")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("razo_refe")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOtro)
                    .HasColumnName("rutt_otro")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoEncaDocu)
                    .WithMany(p => p.DtoDocuRefe)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_dore_fk_endo");
            });

            modelBuilder.Entity<DtoDocuRefeH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeRefe })
                    .HasName("dto_dore_h_pk");

                entity.ToTable("dto_docu_refe_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeRefe)
                    .HasColumnName("nume_refe")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("codi_refe")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.DigiOtro)
                    .HasColumnName("digi_otro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRegl)
                    .HasColumnName("indi_regl")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("razo_refe")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOtro)
                    .HasColumnName("rutt_otro")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoDocuRefeP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeRefe })
                    .HasName("dto_dore_p_pk");

                entity.ToTable("dto_docu_refe_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeRefe)
                    .HasColumnName("nume_refe")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiRefe)
                    .HasColumnName("codi_refe")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DigiOtro)
                    .HasColumnName("digi_otro")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiRegl)
                    .HasColumnName("indi_regl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.RazoRefe)
                    .HasColumnName("razo_refe")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.RuttOtro)
                    .HasColumnName("rutt_otro")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.CorrDocuNavigation)
                    .WithMany(p => p.DtoDocuRefeP)
                    .HasForeignKey(d => d.CorrDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_dore_fk_endo_p");
            });

            modelBuilder.Entity<DtoEncaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("dto_endo_pk");

                entity.ToTable("dto_enca_docu");

                entity.HasIndex(e => new { e.RuttEmis, e.TipoDocu, e.FoliDocu })
                    .HasName("dto_endo_uk1")
                    .IsUnique();

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CiudDest)
                    .HasColumnName("ciud_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("ciud_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("ciud_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("ciud_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEsap)
                    .HasColumnName("codi_esap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRece)
                    .HasColumnName("codi_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiTepa)
                    .HasColumnName("codi_tepa")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("codi_vend")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ComuDest)
                    .HasColumnName("comu_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("comu_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("comu_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("comu_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("cont_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CredEs65)
                    .HasColumnName("cred_es65")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasTepa)
                    .HasColumnName("dias_tepa")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiMand)
                    .HasColumnName("digi_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiSofa)
                    .HasColumnName("digi_sofa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiTran)
                    .HasColumnName("digi_tran")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireDest)
                    .HasColumnName("dire_dest")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("dire_orig")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("dire_post")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("dire_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntrBien)
                    .HasColumnName("entr_bien")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechCanc)
                    .HasColumnName("fech_canc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCarg)
                    .HasColumnName("fech_carg")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechEsap)
                    .HasColumnName("fech_esap")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechImpr)
                    .HasColumnName("fech_impr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FehoTed)
                    .HasColumnName("feho_ted")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmTed)
                    .HasColumnName("firm_ted")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormPago)
                    .HasColumnName("form_pago")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.GaraEnva)
                    .HasColumnName("gara_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("giro_emis")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GiroRece)
                    .HasColumnName("giro_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVaag)
                    .HasColumnName("impu_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpuVanr)
                    .HasColumnName("impu_vanr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IndiNore)
                    .HasColumnName("indi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiVegd)
                    .HasColumnName("indi_vegd")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InfoTran)
                    .HasColumnName("info_tran")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsta)
                    .HasColumnName("mens_esta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModaPago)
                    .HasColumnName("moda_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MontBase)
                    .HasColumnName("mont_base")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBrut)
                    .HasColumnName("mont_brut")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazoEsap)
                    .HasColumnName("razo_esap")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttMand)
                    .HasColumnName("rutt_mand")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttSofa)
                    .HasColumnName("rutt_sofa")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttTran)
                    .HasColumnName("rutt_tran")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("sald_ante")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubtVese)
                    .HasColumnName("subt_vese")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.UsuaEsap)
                    .HasColumnName("usua_esap")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaImpr)
                    .HasColumnName("usua_impr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("valo_paga")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VersEnca)
                    .HasColumnName("vers_enca")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DtoEncaDocu)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_endo_fk_empr");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.DtoEncaDocu)
                    .HasForeignKey(d => d.CorrEnvi)
                    .HasConstraintName("dto_endo_fk_envi");

                entity.HasOne(d => d.EstaDocuNavigation)
                    .WithMany(p => p.DtoEncaDocu)
                    .HasForeignKey(d => d.EstaDocu)
                    .HasConstraintName("dto_endo_fk_esdo");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DtoEncaDocu)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_endo_fk_tido");
            });

            modelBuilder.Entity<DtoEncaDocuH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("dto_endo_h_pk");

                entity.ToTable("dto_enca_docu_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CiudDest)
                    .HasColumnName("ciud_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("ciud_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("ciud_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("ciud_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEsap)
                    .HasColumnName("codi_esap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRece)
                    .HasColumnName("codi_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiTepa)
                    .HasColumnName("codi_tepa")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsuaApro)
                    .HasColumnName("CODI_USUA_APRO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("codi_vend")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ComuDest)
                    .HasColumnName("comu_dest")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("comu_orig")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("comu_post")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("comu_rece")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("cont_rece")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CredEs65)
                    .HasColumnName("cred_es65")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DiasTepa)
                    .HasColumnName("dias_tepa")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiMand)
                    .HasColumnName("digi_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiSofa)
                    .HasColumnName("digi_sofa")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiTran)
                    .HasColumnName("digi_tran")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireDest)
                    .HasColumnName("dire_dest")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("dire_orig")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("dire_post")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("dire_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntrBien)
                    .HasColumnName("entr_bien")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstaTras)
                    .HasColumnName("esta_tras")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechCanc)
                    .HasColumnName("fech_canc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCarg)
                    .HasColumnName("fech_carg")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechEsap)
                    .HasColumnName("fech_esap")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FehoTed)
                    .HasColumnName("feho_ted")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmTed)
                    .HasColumnName("firm_ted")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormPago)
                    .HasColumnName("form_pago")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.GaraEnva)
                    .HasColumnName("gara_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("giro_emis")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GiroRece)
                    .HasColumnName("giro_rece")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVaag)
                    .HasColumnName("impu_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImpuVanr)
                    .HasColumnName("impu_vanr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IndiCont)
                    .HasColumnName("indi_cont")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiNore)
                    .HasColumnName("indi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiVegd)
                    .HasColumnName("indi_vegd")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.InfoTran)
                    .HasColumnName("info_tran")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MailUsuaApro)
                    .HasColumnName("MAIL_USUA_APRO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsta)
                    .HasColumnName("mens_esta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModaPago)
                    .HasColumnName("moda_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MontBase)
                    .HasColumnName("mont_base")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontBrut)
                    .HasColumnName("mont_brut")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RazoEsap)
                    .HasColumnName("razo_esap")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReciRece)
                    .HasColumnName("RECI_RECE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttMand)
                    .HasColumnName("rutt_mand")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttSofa)
                    .HasColumnName("rutt_sofa")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttTran)
                    .HasColumnName("rutt_tran")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("sald_ante")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubtVese)
                    .HasColumnName("subt_vese")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.UsuaEsap)
                    .HasColumnName("usua_esap")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("valo_paga")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VersEnca)
                    .HasColumnName("vers_enca")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoEncaDocuP>(entity =>
            {
                entity.HasKey(e => e.CorrDocu)
                    .HasName("dto_endo_p_pk");

                entity.ToTable("dto_enca_docu_p");

                entity.HasIndex(e => e.EstaDocu)
                    .HasName("dto_enca_UK_esta");

                entity.HasIndex(e => e.EstaTras)
                    .HasName("dto_endo_p_indx1");

                entity.HasIndex(e => new { e.CodiEmpr, e.CorrEnvi })
                    .HasName("IDX_DTO_ENCA_DOCU_MONI");

                entity.HasIndex(e => new { e.RuttRece, e.RuttEmis, e.TipoDocu, e.FoliDocu, e.EstaDocu })
                    .HasName("IDX_DTO_ENCA_DOCU");

                entity.HasIndex(e => new { e.RuttRece, e.RuttEmis, e.TipoDocu, e.FoliNume, e.EstaDocu })
                    .HasName("IDX_DTO_ENCA_DOCU_NUME");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CiudDest)
                    .HasColumnName("ciud_dest")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CiudOrig)
                    .HasColumnName("ciud_orig")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CiudPost)
                    .HasColumnName("ciud_post")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CiudRece)
                    .HasColumnName("ciud_rece")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiEsap)
                    .HasColumnName("codi_esap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRece)
                    .HasColumnName("codi_rece")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CodiReme)
                    .HasColumnName("codi_reme")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiServ)
                    .HasColumnName("codi_serv")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiTepa)
                    .HasColumnName("codi_tepa")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsuaApro)
                    .HasColumnName("codi_usua_apro")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVend)
                    .HasColumnName("codi_vend")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ComuDest)
                    .HasColumnName("comu_dest")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ComuOrig)
                    .HasColumnName("comu_orig")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ComuPost)
                    .HasColumnName("comu_post")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ComuRece)
                    .HasColumnName("comu_rece")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ContRece)
                    .HasColumnName("cont_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrRafo)
                    .HasColumnName("corr_rafo")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CredEs65)
                    .HasColumnName("cred_es65")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CsiiRecl)
                    .HasColumnName("csii_recl")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DiasTepa)
                    .HasColumnName("dias_tepa")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiMand)
                    .HasColumnName("digi_mand")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiSofa)
                    .HasColumnName("digi_sofa")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DigiTran)
                    .HasColumnName("digi_tran")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DireDest)
                    .HasColumnName("dire_dest")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DireOrig)
                    .HasColumnName("dire_orig")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DirePost)
                    .HasColumnName("dire_post")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DireRece)
                    .HasColumnName("dire_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EntrBien)
                    .HasColumnName("entr_bien")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstaTras)
                    .HasColumnName("esta_tras")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EvenRecl)
                    .HasColumnName("even_recl")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechCanc)
                    .HasColumnName("fech_canc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechCarg)
                    .HasColumnName("fech_carg")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechEsap)
                    .HasColumnName("fech_esap")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechReceSii)
                    .HasColumnName("fech_rece_sii")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechRecl)
                    .HasColumnName("fech_recl")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechReme)
                    .HasColumnName("fech_reme")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FehoTed)
                    .HasColumnName("feho_ted")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirmTed)
                    .HasColumnName("firm_ted")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNume)
                    .HasColumnName("foli_nume")
                    .HasColumnType("numeric(30, 0)");

                entity.Property(e => e.FormPago)
                    .HasColumnName("form_pago")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GaraEnva)
                    .HasColumnName("gara_enva")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.GiroEmis)
                    .HasColumnName("giro_emis")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.GiroRece)
                    .HasColumnName("giro_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVaag)
                    .HasColumnName("impu_vaag")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuVanr)
                    .HasColumnName("impu_vanr")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.IndiCont)
                    .HasColumnName("indi_cont")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiConta)
                    .HasColumnName("INDI_CONTA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.IndiNore)
                    .HasColumnName("indi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IndiVegd)
                    .HasColumnName("indi_vegd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfoTran)
                    .HasColumnName("info_tran")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.MailUsuaApro)
                    .HasColumnName("mail_usua_apro")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MensEsta)
                    .HasColumnName("mens_esta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModaPago)
                    .HasColumnName("moda_pago")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MontBase)
                    .HasColumnName("mont_base")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontBrut)
                    .HasColumnName("mont_brut")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmis)
                    .HasColumnName("nomb_emis")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombRece)
                    .HasColumnName("nomb_rece")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombSucu)
                    .HasColumnName("nomb_sucu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeImpr)
                    .HasColumnName("nume_impr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.RazoEsap)
                    .HasColumnName("razo_esap")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ReciRece)
                    .HasColumnName("RECI_RECE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.RuttMand)
                    .HasColumnName("rutt_mand")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttSofa)
                    .HasColumnName("rutt_sofa")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.RuttTran)
                    .HasColumnName("rutt_tran")
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("sald_ante")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SubtVese)
                    .HasColumnName("subt_vese")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaEsap)
                    .HasColumnName("usua_esap")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaRecl)
                    .HasColumnName("usua_recl")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaReme)
                    .HasColumnName("usua_reme")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("valo_paga")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersEnca)
                    .HasColumnName("vers_enca")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.DtoEncaDocuP)
                    .HasForeignKey(d => d.CorrEnvi)
                    .HasConstraintName("dto_endo_fk_envi_p");
            });

            modelBuilder.Entity<DtoExtrDocu>(entity =>
            {
                entity.HasKey(e => new { e.CorrExtr, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CorrDocu, e.NombArch });

                entity.ToTable("dto_extr_docu");

                entity.Property(e => e.CorrExtr)
                    .HasColumnName("corr_extr")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.NombArch)
                    .HasColumnName("nomb_arch")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoFase>(entity =>
            {
                entity.HasKey(e => e.FaseEsdo)
                    .HasName("dto_fase_pk");

                entity.ToTable("dto_fase");

                entity.Property(e => e.FaseEsdo)
                    .HasColumnName("fase_esdo")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FaseDesc)
                    .HasColumnName("fase_desc")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoRecaItem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrReit })
                    .HasName("DTO_REIT_PK");

                entity.ToTable("dto_reca_item");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrReit)
                    .HasColumnName("corr_reit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReca)
                    .HasColumnName("tipo_reca")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoReca)
                    .HasColumnName("valo_reca")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DtoDetaPrse)
                    .WithMany(p => p.DtoRecaItem)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_reit_fk_dtpr");
            });

            modelBuilder.Entity<DtoRecaItemP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeLine, e.CorrReit })
                    .HasName("DTO_REIT_P_PK");

                entity.ToTable("dto_reca_item_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrReit)
                    .HasColumnName("corr_reit")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReca)
                    .HasColumnName("tipo_reca")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ValoReca)
                    .HasColumnName("valo_reca")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoDetaPrseP)
                    .WithMany(p => p.DtoRecaItemP)
                    .HasForeignKey(d => new { d.CorrDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_reit_fk_dtpr_p");
            });

            modelBuilder.Entity<DtoReceDocu>(entity =>
            {
                entity.HasKey(e => e.CorrEnvi)
                    .HasName("dtp_redo_pk");

                entity.ToTable("dto_rece_docu");

                entity.HasIndex(e => e.EstaEnvi)
                    .HasName("dto_rece_UK_esta");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BlocEnvi)
                    .HasColumnName("bloc_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiServ)
                    .HasColumnName("codi_serv")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .HasColumnName("digi_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiValu)
                    .HasColumnName("DIGI_VALU")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("esta_envi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechRece)
                    .HasColumnName("FECH_RECE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .HasColumnName("fech_reso")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoEnvi)
                    .HasColumnName("feho_envi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmEnvi)
                    .HasColumnName("firm_envi")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.IndeEnvi)
                    .HasColumnName("inde_envi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .HasColumnName("nomb_arch")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombOrig)
                    .HasColumnName("NOMB_ORIG")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeReso)
                    .HasColumnName("nume_reso")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.PosiEnvi)
                    .HasColumnName("posi_envi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("rutt_envi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.VersEnvi)
                    .HasColumnName("vers_envi")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.EstaEnviNavigation)
                    .WithMany(p => p.DtoReceDocu)
                    .HasForeignKey(d => d.EstaEnvi)
                    .HasConstraintName("dto_envi_fk_esen");
            });

            modelBuilder.Entity<DtoReceDocuH>(entity =>
            {
                entity.HasKey(e => e.CorrEnvi)
                    .HasName("dto_redo_h_pk");

                entity.ToTable("dto_rece_docu_h");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.BlocEnvi)
                    .HasColumnName("bloc_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .HasColumnName("digi_envi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiValu)
                    .HasColumnName("digi_valu")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.DireArch)
                    .HasColumnName("dire_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("esta_envi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechRece)
                    .HasColumnName("fech_rece")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .HasColumnName("fech_reso")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoEnvi)
                    .HasColumnName("feho_envi")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmEnvi)
                    .HasColumnName("firm_envi")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.IndeEnvi)
                    .HasColumnName("inde_envi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombArch)
                    .HasColumnName("nomb_arch")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeReso)
                    .HasColumnName("nume_reso")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PosiEnvi)
                    .HasColumnName("posi_envi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("rutt_envi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.VersEnvi)
                    .HasColumnName("vers_envi")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoReceLob>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrRece, e.TipoArch })
                    .HasName("dto_rece_lob_pk");

                entity.ToTable("dto_rece_lob");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrRece)
                    .HasColumnName("corr_rece")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("tipo_arch")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .IsRequired()
                    .HasColumnName("clob_docu")
                    .HasColumnType("text");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DtoReceLob)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_rece_lob_fk_empr");
            });

            modelBuilder.Entity<DtoReceLobH>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrRece, e.TipoArch })
                    .HasName("dto_rece_lob_h_pk");

                entity.ToTable("dto_rece_lob_h");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrRece)
                    .HasColumnName("corr_rece")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoArch)
                    .HasColumnName("tipo_arch")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ClobDocu)
                    .IsRequired()
                    .HasColumnName("clob_docu")
                    .HasColumnType("text");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.DtoReceLobH)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_rece_lob_h_fk_empr");
            });

            modelBuilder.Entity<DtoSucaItem>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.NumeLine, e.CorrSuca })
                    .HasName("DTO_SUIT_PK");

                entity.ToTable("dto_suca_item");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrSuca)
                    .HasColumnName("corr_suca")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiSuca)
                    .HasColumnName("codi_suca")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SucaDist)
                    .HasColumnName("suca_dist")
                    .HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.DtoDetaPrse)
                    .WithMany(p => p.DtoSucaItem)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_suit_fk_prse");
            });

            modelBuilder.Entity<DtoSucaItemP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.NumeLine, e.CorrSuca })
                    .HasName("DTO_SUIT_P_PK");

                entity.ToTable("dto_suca_item_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeLine)
                    .HasColumnName("nume_line")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CorrSuca)
                    .HasColumnName("corr_suca")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiSuca)
                    .HasColumnName("codi_suca")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.SucaDist)
                    .HasColumnName("suca_dist")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.DtoDetaPrseP)
                    .WithMany(p => p.DtoSucaItemP)
                    .HasForeignKey(d => new { d.CorrDocu, d.NumeLine })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_suit_fk_dtpr_p");
            });

            modelBuilder.Entity<DtoSuceEsap>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrDocu, e.CorrSuce })
                    .HasName("dto_suce_pk");

                entity.ToTable("dto_suce_esap");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CorrSuce)
                    .HasColumnName("corr_suce")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEsap)
                    .HasColumnName("codi_esap")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechEsap)
                    .HasColumnName("fech_esap")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.RazoEsap)
                    .HasColumnName("razo_esap")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaEsap)
                    .HasColumnName("usua_esap")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DtoSumaImpu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("dto_suim_pk");

                entity.ToTable("dto_suma_impu");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CodiImpuNavigation)
                    .WithMany(p => p.DtoSumaImpu)
                    .HasForeignKey(d => d.CodiImpu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_suim_fk_tiim");

                entity.HasOne(d => d.DtoEncaDocu)
                    .WithMany(p => p.DtoSumaImpu)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_suim_fk_endo");
            });

            modelBuilder.Entity<DtoSumaImpuH>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.CodiImpu })
                    .HasName("dto_suim_h_pk");

                entity.ToTable("dto_suma_impu_h");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<DtoSumaImpuP>(entity =>
            {
                entity.HasKey(e => new { e.CorrDocu, e.CodiImpu })
                    .HasName("dto_suim_p_pk");

                entity.ToTable("dto_suma_impu_p");

                entity.Property(e => e.CorrDocu)
                    .HasColumnName("corr_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MnsgErro)
                    .HasColumnName("mnsg_erro")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.HasOne(d => d.CorrDocuNavigation)
                    .WithMany(p => p.DtoSumaImpuP)
                    .HasForeignKey(d => d.CorrDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_suim_fk_endo_p");
            });

            modelBuilder.Entity<DtoTidoRece>(entity =>
            {
                entity.HasKey(e => new { e.CorrEnvi, e.TipoDocu })
                    .HasName("dto_tdev_pk");

                entity.ToTable("dto_tido_rece");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CantInfo)
                    .HasColumnName("cant_info")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.PeriPart)
                    .HasColumnName("peri_part")
                    .HasDefaultValueSql("(CONVERT([int],CONVERT([varchar](6),getdate(),(112)),0))");

                entity.HasOne(d => d.CorrEnviNavigation)
                    .WithMany(p => p.DtoTidoRece)
                    .HasForeignKey(d => d.CorrEnvi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_tien_fk_envi");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.DtoTidoRece)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dto_tien_fk_tido");
            });

            modelBuilder.Entity<DtoTidoReceH>(entity =>
            {
                entity.HasKey(e => new { e.CorrEnvi, e.TipoDocu })
                    .HasName("dto_tdev_h_pk");

                entity.ToTable("dto_tido_rece_h");

                entity.Property(e => e.CorrEnvi)
                    .HasColumnName("corr_envi")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CantInfo)
                    .HasColumnName("cant_info")
                    .HasColumnType("numeric(10, 0)");
            });

            modelBuilder.Entity<DtoTrace>(entity =>
            {
                entity.HasKey(e => new { e.RuttEmis, e.TipoDocu, e.FoliDocu, e.FehoTrac, e.EstaTrac })
                    .HasName("DTO_TRACE_PK");

                entity.ToTable("dto_trace");

                entity.HasIndex(e => new { e.TipoDocu, e.FoliDocu })
                    .HasName("ia_dto_trace");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.FehoTrac)
                    .HasColumnName("feho_trac")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstaTrac)
                    .HasColumnName("esta_trac")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empr>(entity =>
            {
                entity.HasKey(e => e.CodiEmpr)
                    .HasName("empp_pk_empp_1");

                entity.ToTable("empr");

                entity.HasIndex(e => e.CodiComu)
                    .HasName("id_empp_codi_comu");

                entity.HasIndex(e => e.NombEmpr)
                    .HasName("ia_empp_2");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.AsunFactEmpr)
                    .HasColumnName("asun_fact_empr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CacaEmpr)
                    .HasColumnName("caca_empr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CajaEmpr)
                    .HasColumnName("caja_empr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CineEmpr)
                    .HasColumnName("cine_empr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClavEncr)
                    .HasColumnName("clav_encr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCiud)
                    .HasColumnName("codi_ciud")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiComu)
                    .HasColumnName("codi_comu")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRamo)
                    .HasColumnName("codi_ramo")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ColorEmpr)
                    .HasColumnName("color_empr")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CuenEmpr)
                    .HasColumnName("cuen_empr")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DgtoRepl)
                    .HasColumnName("dgto_repl")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmpr)
                    .HasColumnName("digi_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DireEmpr)
                    .HasColumnName("dire_empr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmprCodg)
                    .HasColumnName("empr_codg")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.EmprNomb)
                    .HasColumnName("empr_nomb")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FecaEmpr)
                    .HasColumnName("feca_empr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FemuEmpr)
                    .HasColumnName("femu_empr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FonoEmpr)
                    .HasColumnName("fono_empr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GiroEmpr)
                    .HasColumnName("giro_empr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LogoEmpr)
                    .HasColumnName("logo_empr")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MutuEmpr)
                    .HasColumnName("mutu_empr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NfanEmpr)
                    .HasColumnName("nfan_empr")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmpr)
                    .HasColumnName("nomb_empr")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombRepl)
                    .HasColumnName("nomb_repl")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PocaEmpr)
                    .HasColumnName("poca_empr")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.PomuEmpr)
                    .HasColumnName("pomu_empr")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.RuttEmpr)
                    .HasColumnName("rutt_empr")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.RuttRepl)
                    .HasColumnName("rutt_repl")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.TextFactEmpr)
                    .HasColumnName("text_fact_empr")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.Empr)
                    .HasForeignKey(d => d.CodiPers)
                    .HasConstraintName("empr_fk_pers");
            });

            modelBuilder.Entity<EmprExte>(entity =>
            {
                entity.HasKey(e => e.CodiEmex)
                    .HasName("emex_pk_emex_1");

                entity.ToTable("empr_exte");

                entity.HasIndex(e => e.NombEmex)
                    .HasName("emex_uk_emex_2")
                    .IsUnique();

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BackEmex)
                    .HasColumnName("back_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BannEmex)
                    .HasColumnName("bann_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ColoEmex)
                    .HasColumnName("colo_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ComeEmex)
                    .HasColumnName("come_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmexBody)
                    .HasColumnName("EMEX_BODY")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EmexFrom)
                    .HasColumnName("EMEX_FROM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmexRef)
                    .HasColumnName("EMEX_REF")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FeinEmex)
                    .HasColumnName("fein_emex")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeteEmex)
                    .HasColumnName("fete_emex")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormEmex)
                    .HasColumnName("form_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GintEmex)
                    .HasColumnName("gint_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.HabiSiti)
                    .HasColumnName("habi_siti")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeadEmex)
                    .HasColumnName("head_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IntrEmex)
                    .HasColumnName("intr_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IpwsEmex)
                    .HasColumnName("ipws_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LogoEmex)
                    .HasColumnName("logo_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NombEmex)
                    .HasColumnName("nomb_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OwneEmex)
                    .HasColumnName("owne_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagiInic)
                    .HasColumnName("pagi_inic")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PassEmex)
                    .HasColumnName("pass_emex")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PassUsuaEul)
                    .HasColumnName("pass_usua_eul")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PassUsuaWeb)
                    .HasColumnName("pass_usua_web")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PathEmex)
                    .HasColumnName("path_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PtwsEmex)
                    .HasColumnName("ptws_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RepoEmex)
                    .HasColumnName("REPO_EMEX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServScgi)
                    .HasColumnName("serv_scgi")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ServSrep)
                    .HasColumnName("serv_srep")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ServSweb)
                    .HasColumnName("serv_sweb")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SideEmex)
                    .HasColumnName("side_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SplaEmex)
                    .HasColumnName("spla_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StatEmex)
                    .HasColumnName("stat_emex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StriConn)
                    .HasColumnName("stri_conn")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SwebEmex)
                    .HasColumnName("sweb_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UrbaEmex)
                    .HasColumnName("urba_emex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaDbss)
                    .HasColumnName("usua_dbss")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaEul)
                    .HasColumnName("usua_eul")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaWeb)
                    .HasColumnName("usua_web")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.EmprExte)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("emex_fk_empr");
            });

            modelBuilder.Entity<FoliAnul>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiZona, e.CodiOfic, e.TipoComo, e.FoliFoan })
                    .HasName("foan_pk");

                entity.ToTable("foli_anul");

                entity.HasIndex(e => new { e.CodiEmpr, e.TipoComo, e.FoliFoan })
                    .HasName("ip_foan");

                entity.HasIndex(e => new { e.CodiEmpr, e.CodiZona, e.CodiOfic, e.FechFoan })
                    .HasName("ia_foan");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiZona)
                    .HasColumnName("codi_zona")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiOfic)
                    .HasColumnName("codi_ofic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComo)
                    .HasColumnName("tipo_como")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FoliFoan)
                    .HasColumnName("foli_foan")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiConf)
                    .HasColumnName("codi_conf")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpl)
                    .HasColumnName("codi_empl")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FechFoan)
                    .HasColumnName("fech_foan")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.FoliAnul)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("foan_fk_empr");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.FoliAnul)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .HasConstraintName("foan_fk_ceco");
            });

            modelBuilder.Entity<LbeCaraLibr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLibe })
                    .HasName("LBCALI_PK");

                entity.ToTable("lbe_cara_libr");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("CORR_LIBE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("DIGI_EMIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEnvi)
                    .HasColumnName("DIGI_ENVI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechCrea)
                    .HasColumnName("FECH_CREA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechEnvi)
                    .HasColumnName("FECH_ENVI")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechFina)
                    .HasColumnName("FECH_FINA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechInic)
                    .HasColumnName("FECH_INIC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .HasColumnName("FECH_RESO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("FOLI_NOTI")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeReso)
                    .HasColumnName("NUME_RESO")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.NumeSegm)
                    .HasColumnName("NUME_SEGM")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.PeriTrib)
                    .HasColumnName("PERI_TRIB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("RUTT_EMIS")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.RuttEnvi)
                    .HasColumnName("RUTT_ENVI")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoEnvi)
                    .HasColumnName("TIPO_ENVI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("TIPO_LIBR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.LbeNotiLibr)
                    .WithMany(p => p.LbeCaraLibr)
                    .HasForeignKey(d => new { d.CodiEmpr, d.FoliNoti })
                    .HasConstraintName("lbcali_fk_empr");
            });

            modelBuilder.Entity<LbeDetaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiSoli, e.CorrLibe, e.TipoDocu, e.FoliDocu })
                    .HasName("lbe_deta_docu_pk");

                entity.ToTable("lbe_deta_docu");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("XAK2lbe_deta_docu_empr");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("corr_libe")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiIncl)
                    .HasColumnName("codi_incl")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.DigiAsoc)
                    .HasColumnName("digi_asoc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechEmis)
                    .HasColumnName("fech_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVenc)
                    .HasColumnName("fech_venc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliAnul)
                    .HasColumnName("foli_anul")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoServ)
                    .HasColumnName("tipo_serv")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TotaSaan)
                    .HasColumnName("tota_saan")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaVapa)
                    .HasColumnName("tota_vapa")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LbeDetaDocu)
                    .HasForeignKey(d => new { d.CodiSoli, d.CorrLibe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LBE_DETA_FK_ENCA");
            });

            modelBuilder.Entity<LbeDetaLibr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLibe, e.TipoDocu, e.FoliDocu })
                    .HasName("LBDELI_PK");

                entity.ToTable("lbe_deta_libr");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("CORR_LIBE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiInte)
                    .HasColumnName("CODI_INTE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("CODI_SUCU")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DigiRece)
                    .HasColumnName("DIGI_RECE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechEmis)
                    .HasColumnName("FECH_EMIS")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechVenc)
                    .HasColumnName("FECH_VENC")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliAnul)
                    .HasColumnName("FOLI_ANUL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("FOLI_NOTI")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("MONT_EXEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("MONT_NETO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("MONT_NOFA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("MONT_TOTA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("PERI_DESD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("PERI_HAST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuttRece)
                    .HasColumnName("RUTT_RECE")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("SALD_ANTE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("TASA_VAAG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TipoServ)
                    .HasColumnName("TIPO_SERV")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TotaPeri)
                    .HasColumnName("TOTA_PERI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("VALO_PAGA")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LbeDetaLibr)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLibe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbdeli_fk_empr");
            });

            modelBuilder.Entity<LbeEncaLibr>(entity =>
            {
                entity.HasKey(e => new { e.CodiSoli, e.CorrLibe })
                    .HasName("lbe_enca_libr_pk");

                entity.ToTable("lbe_enca_libr");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("XAK1lbe_enca_libr_empr");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("corr_libe")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("foli_noti")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeSegm)
                    .HasColumnName("nume_segm")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoEnvi)
                    .HasColumnName("tipo_envi")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiSoliNavigation)
                    .WithMany(p => p.LbeEncaLibr)
                    .HasForeignKey(d => d.CodiSoli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbe_soli_fk_enca");
            });

            modelBuilder.Entity<LbeNotiLibr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.FoliNoti })
                    .HasName("LBNOLI_PK");

                entity.ToTable("lbe_noti_libr");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("FOLI_NOTI")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DescLibr)
                    .HasColumnName("DESC_LIBR")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechNoti)
                    .HasColumnName("FECH_NOTI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("PERI_DESD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("PERI_HAST")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.LbeNotiLibr)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbnoli_fk_empr");
            });

            modelBuilder.Entity<LbePeriTise>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLibe, e.TipoDocu, e.IndiServ, e.PeriDeve })
                    .HasName("LBPETI_PK");

                entity.ToTable("lbe_peri_tise");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("CORR_LIBE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.IndiServ)
                    .HasColumnName("INDI_SERV")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeriDeve)
                    .HasColumnName("PERI_DEVE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MontIvaa)
                    .HasColumnName("MONT_IVAA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("MONT_NOFA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("MONT_TOTA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("SALD_ANTE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaIvaa)
                    .HasColumnName("TASA_IVAA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaDocu)
                    .HasColumnName("TOTA_DOCU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaExen)
                    .HasColumnName("TOTA_EXEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNeto)
                    .HasColumnName("TOTA_NETO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaPeri)
                    .HasColumnName("TOTA_PERI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("VALO_PAGA")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.LbeResuPeri)
                    .WithMany(p => p.LbePeriTise)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLibe, d.TipoDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbpeti_fk_empr");
            });

            modelBuilder.Entity<LbeResuPeri>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLibe, e.TipoDocu })
                    .HasName("LBREPE_PK");

                entity.ToTable("lbe_resu_peri");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("CORR_LIBE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantAnul)
                    .HasColumnName("CANT_ANUL")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LbeResuPeri)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLibe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbrepe_fk_empr");
            });

            modelBuilder.Entity<LbeResuSegm>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLibe, e.TipoDocu })
                    .HasName("LBRESE_PK");

                entity.ToTable("lbe_resu_segm");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("CORR_LIBE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantAnul)
                    .HasColumnName("CANT_ANUL")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LbeResuSegm)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLibe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbrese_fk_empr");
            });

            modelBuilder.Entity<LbeSegmTise>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLibe, e.TipoDocu, e.IndiServ, e.PeriDeve })
                    .HasName("LBSETI_PK");

                entity.ToTable("lbe_segm_tise");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("CORR_LIBE")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.IndiServ)
                    .HasColumnName("INDI_SERV")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeriDeve)
                    .HasColumnName("PERI_DEVE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MontNeto)
                    .HasColumnName("MONT_NETO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("MONT_NOFA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("MONT_PERI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("MONT_TOTA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SaldAnte)
                    .HasColumnName("SALD_ANTE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("TASA_VAAG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaDocu)
                    .HasColumnName("TOTA_DOCU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaExen)
                    .HasColumnName("TOTA_EXEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaVaag)
                    .HasColumnName("TOTA_VAAG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoPaga)
                    .HasColumnName("VALO_PAGA")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.LbeResuSegm)
                    .WithMany(p => p.LbeSegmTise)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLibe, d.TipoDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lbseti_fk_empr");
            });

            modelBuilder.Entity<LbeServPeri>(entity =>
            {
                entity.HasKey(e => new { e.CodiSoli, e.TipoDocu, e.CorrLibe, e.CodiServ })
                    .HasName("lbe_serv_peri_pk");

                entity.ToTable("lbe_serv_peri");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("XAK2lbe_serv_peri_empr");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("corr_libe")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiServ)
                    .HasColumnName("codi_serv")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PeriDeve)
                    .HasColumnName("peri_deve")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoServ)
                    .HasColumnName("tipo_serv")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TotaDocu)
                    .HasColumnName("tota_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TotaExen)
                    .HasColumnName("tota_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNofa)
                    .HasColumnName("tota_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaPeri)
                    .HasColumnName("tota_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaSaan)
                    .HasColumnName("tota_saan")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaVapa)
                    .HasColumnName("tota_vapa")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.LbeTotaPeri)
                    .WithMany(p => p.LbeServPeri)
                    .HasForeignKey(d => new { d.CodiSoli, d.CorrLibe, d.TipoDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LBE_SERV_FK_TOPE");
            });

            modelBuilder.Entity<LbeServSegm>(entity =>
            {
                entity.HasKey(e => new { e.CodiSoli, e.TipoDocu, e.CorrLibe, e.CodiServ })
                    .HasName("lbe_serv_segm_pk");

                entity.ToTable("lbe_serv_segm");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("XAK2lbe_serv_segm_empr");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("corr_libe")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiServ)
                    .HasColumnName("codi_serv")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PeriDeve)
                    .HasColumnName("peri_deve")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoServ)
                    .HasColumnName("tipo_serv")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TotaDocu)
                    .HasColumnName("tota_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TotaExen)
                    .HasColumnName("tota_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaNofa)
                    .HasColumnName("tota_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaPeri)
                    .HasColumnName("tota_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaSaan)
                    .HasColumnName("tota_saan")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TotaVapa)
                    .HasColumnName("tota_vapa")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.LbeTotaSegm)
                    .WithMany(p => p.LbeServSegm)
                    .HasForeignKey(d => new { d.CodiSoli, d.CorrLibe, d.TipoDocu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LBE_SERV_FK_TOSE");
            });

            modelBuilder.Entity<LbeSoliLibr>(entity =>
            {
                entity.HasKey(e => e.CodiSoli)
                    .HasName("lbe_soli_libr_pk");

                entity.ToTable("lbe_soli_libr");

                entity.HasIndex(e => new { e.CodiSoli, e.PeriDesd, e.RuttRece, e.DigiRece, e.MontMini, e.NumeDtes, e.PeriHast, e.CodiEmpr })
                    .HasName("XIE1lbe_soli_libr");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("foli_noti")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MontMini)
                    .HasColumnName("mont_mini")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeDtes)
                    .HasColumnName("nume_dtes")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PeriDesd)
                    .HasColumnName("peri_desd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriHast)
                    .HasColumnName("peri_hast")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasColumnType("numeric(9, 0)");
            });

            modelBuilder.Entity<LbeTotaPeri>(entity =>
            {
                entity.HasKey(e => new { e.CodiSoli, e.CorrLibe, e.TipoDocu })
                    .HasName("lbe_tota_peri_pk");

                entity.ToTable("lbe_tota_peri");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("XAK1lbe_tota_peri_empr");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("corr_libe")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CantFoan)
                    .HasColumnName("cant_foan")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LbeTotaPeri)
                    .HasForeignKey(d => new { d.CodiSoli, d.CorrLibe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LBE_TOPE_FK_ENCA");
            });

            modelBuilder.Entity<LbeTotaSegm>(entity =>
            {
                entity.HasKey(e => new { e.CodiSoli, e.CorrLibe, e.TipoDocu })
                    .HasName("lbe_tota_segm_pk");

                entity.ToTable("lbe_tota_segm");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("XAK1lbe_tota_segm_empr");

                entity.HasIndex(e => e.CorrLibe)
                    .HasName("lbe_tota_k_lbe");

                entity.Property(e => e.CodiSoli)
                    .HasColumnName("codi_soli")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CorrLibe)
                    .HasColumnName("corr_libe")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CantFoan)
                    .HasColumnName("cant_foan")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LbeTotaSegm)
                    .HasForeignKey(d => new { d.CodiSoli, d.CorrLibe })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LBE_TOSE_FK_ENCA");
            });

            modelBuilder.Entity<LcvDetaComi>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu, e.RuttAsoc, e.CodiOper })
                    .HasName("lcv_deco_pk");

                entity.ToTable("lcv_deta_comi");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RutEmis)
                    .HasColumnName("rut_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValoExen)
                    .HasColumnName("valo_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoIva)
                    .HasColumnName("valo_iva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoNeto)
                    .HasColumnName("valo_neto")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<LcvDetaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu, e.RuttAsoc })
                    .HasName("lcv_dedo_pk");

                entity.ToTable("lcv_deta_docu");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr })
                    .HasName("lcv_reli_k_dedo");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.DigiAsoc)
                    .HasColumnName("digi_asoc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmisDocu)
                    .HasColumnName("emis_docu")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.EstaDocu)
                    .HasColumnName("esta_docu")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.FechDocu)
                    .HasColumnName("fech_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.IndiSico)
                    .HasColumnName("indi_sico")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IvaRtpa)
                    .HasColumnName("iva_rtpa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaRtto)
                    .HasColumnName("iva_rtto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontCred)
                    .HasColumnName("mont_cred")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFupl)
                    .HasColumnName("mont_fupl")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontSicr)
                    .HasColumnName("mont_sicr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontUsco)
                    .HasColumnName("mont_usco")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVehi)
                    .HasColumnName("mont_vehi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombAsoc)
                    .HasColumnName("nomb_asoc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeInte)
                    .HasColumnName("nume_inte")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvDetaDocuP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu, e.RuttAsoc })
                    .HasName("lcv_dedo_p_pk");

                entity.ToTable("lcv_deta_docu_p");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr })
                    .HasName("lcv_reli_k_dedo_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigiAsoc)
                    .HasColumnName("digi_asoc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmisDocu)
                    .HasColumnName("emis_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechDocu)
                    .HasColumnName("fech_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndiSico)
                    .HasColumnName("indi_sico")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IvaRtpa)
                    .HasColumnName("iva_rtpa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IvaRtto)
                    .HasColumnName("iva_rtto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontCred)
                    .HasColumnName("mont_cred")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontFupl)
                    .HasColumnName("mont_fupl")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontSicr)
                    .HasColumnName("mont_sicr")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontUsco)
                    .HasColumnName("mont_usco")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontVehi)
                    .HasColumnName("mont_vehi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombAsoc)
                    .HasColumnName("nomb_asoc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeInte)
                    .HasColumnName("nume_inte")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvDetaNoreP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLicv, e.CodiEmpr, e.CodiNore, e.TipoDocu, e.RuttAsoc })
                    .HasName("lcv_denr_p_pk");

                entity.ToTable("lcv_deta_nore_p");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiNore)
                    .HasColumnName("codi_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontNore)
                    .HasColumnName("mont_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvDetaTemp>(entity =>
            {
                entity.HasKey(e => new { e.TipoOper, e.TipoLibr, e.RuttAsoc, e.PeriTrib, e.TipoDocu, e.FoliDocu, e.RuttCont })
                    .HasName("lcv_temp_pk");

                entity.ToTable("lcv_deta_temp");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriTrib)
                    .HasColumnName("peri_trib")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttCont)
                    .HasColumnName("rutt_cont")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("codi_sucu")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.DigiAsoc)
                    .IsRequired()
                    .HasColumnName("digi_asoc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DigiCont)
                    .IsRequired()
                    .HasColumnName("digi_cont")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmisDocu)
                    .HasColumnName("emis_docu")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FechDocu)
                    .IsRequired()
                    .HasColumnName("fech_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.IndiSico)
                    .HasColumnName("indi_sico")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IvagRtpa)
                    .HasColumnName("ivag_rtpa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagRtto)
                    .HasColumnName("ivag_rtto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontCred)
                    .HasColumnName("mont_cred")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFupl)
                    .HasColumnName("mont_fupl")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontSicr)
                    .HasColumnName("mont_sicr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontUsco)
                    .HasColumnName("mont_usco")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVehi)
                    .HasColumnName("mont_vehi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombAsoc)
                    .HasColumnName("nomb_asoc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeInte)
                    .HasColumnName("nume_inte")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("vent_serv")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvDigiDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.TipoOper, e.RuttAsoc })
                    .HasName("LCVDIGI_PK");

                entity.ToTable("LCV_DIGI_DOCU");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("TIPO_OPER")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("RUTT_ASOC")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiSucu)
                    .HasColumnName("CODI_SUCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DigiAsoc)
                    .IsRequired()
                    .HasColumnName("DIGI_ASOC")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechDocu)
                    .HasColumnName("FECH_DOCU")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("FOLI_REFE")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.IndiSico)
                    .HasColumnName("INDI_SICO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.IvagRtpa)
                    .HasColumnName("IVAG_RTPA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvagRtto)
                    .HasColumnName("IVAG_RTTO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontCred)
                    .HasColumnName("MONT_CRED")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontEnva)
                    .HasColumnName("MONT_ENVA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("MONT_EXEN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFupo)
                    .HasColumnName("MONT_FUPO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontLe18)
                    .HasColumnName("MONT_LE18")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("MONT_NETO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("MONT_NOFA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNret)
                    .HasColumnName("MONT_NRET")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPain)
                    .HasColumnName("MONT_PAIN")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPana)
                    .HasColumnName("MONT_PANA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("MONT_PERI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontSicr)
                    .HasColumnName("MONT_SICR")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("MONT_TOTA")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontUsco)
                    .HasColumnName("MONT_USCO")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("MONT_VAAG")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVafi)
                    .HasColumnName("MONT_VAFI")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombAsoc)
                    .HasColumnName("NOMB_ASOC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeInte)
                    .HasColumnName("NUME_INTE")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("TASA_IMPU")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("TIPO_REFE")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.VaagProp)
                    .HasColumnName("VAAG_PROP")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("VAAG_TERC")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VentServ)
                    .HasColumnName("VENT_SERV")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("VIGE_DOCU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.LcvDigiDocu)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lcvdigi_fk_empr");

                entity.HasOne(d => d.TipoDocuNavigation)
                    .WithMany(p => p.LcvDigiDocu)
                    .HasForeignKey(d => d.TipoDocu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lcvdigi_fk_docu");
            });

            modelBuilder.Entity<LcvDigiImpu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu, e.TipoOper, e.RuttAsoc, e.CodiImpu })
                    .HasName("LCVIMPU_PK");

                entity.ToTable("LCV_DIGI_IMPU");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("TIPO_OPER")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("RUTT_ASOC")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("CODI_IMPU")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("MONT_IMPU")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("TASA_IMPU")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.LcvDigiDocu)
                    .WithMany(p => p.LcvDigiImpu)
                    .HasForeignKey(d => new { d.CodiEmpr, d.TipoDocu, d.FoliDocu, d.TipoOper, d.RuttAsoc })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lcvdigi_fk_impu");
            });

            modelBuilder.Entity<LcvDocuServ>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoDocu, e.FoliDocu })
                    .HasName("lcv_Docu_serv_pk");

                entity.ToTable("lcv_docu_serv");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FechAnul)
                    .HasColumnName("fech_anul")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvNoreTemp>(entity =>
            {
                entity.HasKey(e => new { e.TipoOper, e.TipoLibr, e.RuttAsoc, e.PeriTrib, e.TipoDocu, e.FoliDocu, e.RuttCont, e.CodiNore })
                    .HasName("lcv_tmp3_pk");

                entity.ToTable("lcv_nore_temp");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriTrib)
                    .HasColumnName("peri_trib")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttCont)
                    .HasColumnName("rutt_cont")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiNore)
                    .HasColumnName("codi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MontNore)
                    .HasColumnName("mont_nore")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.LcvDetaTemp)
                    .WithMany(p => p.LcvNoreTemp)
                    .HasForeignKey(d => new { d.TipoOper, d.TipoLibr, d.RuttAsoc, d.PeriTrib, d.TipoDocu, d.FoliDocu, d.RuttCont })
                    .HasConstraintName("lcv_tmp3_fk_temp");
            });

            modelBuilder.Entity<LcvResuLibr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv })
                    .HasName("lcv_reli_pk");

                entity.ToTable("lcv_resu_libr");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRect)
                    .HasColumnName("CODI_RECT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstaEnvi)
                    .HasColumnName("esta_envi")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MensEnvi)
                    .HasColumnName("mens_envi")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeAten)
                    .HasColumnName("nume_aten")
                    .HasColumnType("numeric(12, 0)");

                entity.Property(e => e.NumeEnvi)
                    .HasColumnName("nume_envi")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NumeNoti)
                    .HasColumnName("nume_noti")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeSegm)
                    .HasColumnName("nume_segm")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSegm)
                    .HasColumnName("tipo_segm")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersLicv)
                    .HasColumnName("vers_licv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.EstaEnviNavigation)
                    .WithMany(p => p.LcvResuLibr)
                    .HasForeignKey(d => d.EstaEnvi)
                    .HasConstraintName("fk_esta_envi");
            });

            modelBuilder.Entity<LcvResuLibrP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv })
                    .HasName("lcv_reli_p_pk");

                entity.ToTable("lcv_resu_libr_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumeNoti)
                    .HasColumnName("nume_noti")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeSegm)
                    .HasColumnName("nume_segm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSegm)
                    .HasColumnName("tipo_segm")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersLicv)
                    .HasColumnName("vers_licv")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvSegmImpu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.CodiImpu })
                    .HasName("lcv_seim_pk");

                entity.ToTable("lcv_segm_impu");

                entity.HasIndex(e => e.CodiImpu)
                    .HasName("lcv_impu_k_seim");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr, e.TipoDocu })
                    .HasName("lcv_tose_k_seim");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<LcvSegmImpuP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.CodiImpu })
                    .HasName("lcv_seim_p_pk");

                entity.ToTable("lcv_segm_impu_p");

                entity.HasIndex(e => e.CodiImpu)
                    .HasName("lcv_impu_k_seim_p");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr, e.TipoDocu })
                    .HasName("lcv_tose_k_seim_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvSegmNore>(entity =>
            {
                entity.HasKey(e => new { e.CorrLicv, e.CodiEmpr, e.CodiNore, e.TipoDocu })
                    .HasName("lcv_senr_pk");

                entity.ToTable("lcv_segm_nore");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiNore)
                    .HasColumnName("codi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontNore)
                    .HasColumnName("mont_nore")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OperNore)
                    .HasColumnName("oper_nore")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.LcvTotaSegm)
                    .WithMany(p => p.LcvSegmNore)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv, d.TipoDocu })
                    .HasConstraintName("lcv_seim_fk_nore");
            });

            modelBuilder.Entity<LcvSegmNoreP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLicv, e.CodiEmpr, e.CodiNore, e.TipoDocu })
                    .HasName("lcv_senr_p_pk");

                entity.ToTable("lcv_segm_nore_p");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiNore)
                    .HasColumnName("codi_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontNore)
                    .HasColumnName("mont_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OperNore)
                    .HasColumnName("oper_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.LcvTotaSegmP)
                    .WithMany(p => p.LcvSegmNoreP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv, d.TipoDocu })
                    .HasConstraintName("lcv_seim_fk_nore_p");
            });

            modelBuilder.Entity<LcvTotaComi>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu })
                    .HasName("lcv_toco_pk");

                entity.ToTable("lcv_tota_comi");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ValoExen)
                    .HasColumnName("valo_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoIva)
                    .HasColumnName("valo_iva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ValoNeto)
                    .HasColumnName("valo_neto")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<LcvTotaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu, e.RuttAsoc, e.CodiImpu })
                    .HasName("lcv_todo_pk");

                entity.ToTable("lcv_tota_docu");

                entity.HasIndex(e => e.CodiImpu)
                    .HasName("lcv_impu_k_todo");

                entity.HasIndex(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu, e.RuttAsoc })
                    .HasName("lcv_dedo_k_todo");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOper)
                    .HasColumnName("codi_oper")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasImpu)
                    .HasColumnName("tas_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.LcvDetaDocu)
                    .WithMany(p => p.LcvTotaDocu)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv, d.TipoDocu, d.FoliDocu, d.RuttAsoc })
                    .HasConstraintName("lcv_todo_fk_dedo");
            });

            modelBuilder.Entity<LcvTotaDocuP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu, e.CodiImpu, e.RuttAsoc })
                    .HasName("lcv_todo_p_pk");

                entity.ToTable("lcv_tota_docu_p");

                entity.HasIndex(e => e.CodiImpu)
                    .HasName("lcv_impu_k_todo_p");

                entity.HasIndex(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.FoliDocu })
                    .HasName("lcv_dedo_k_todo_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TasImpu)
                    .HasColumnName("tas_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.LcvDetaDocuP)
                    .WithMany(p => p.LcvTotaDocuP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv, d.TipoDocu, d.FoliDocu, d.RuttAsoc })
                    .HasConstraintName("lcv_todo_fk_dedo_p");
            });

            modelBuilder.Entity<LcvTotaImpu>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.CodiImpu })
                    .HasName("lcv_toim_pk");

                entity.ToTable("lcv_tota_impu");

                entity.HasIndex(e => e.CodiImpu)
                    .HasName("lcv_impu_k_toim");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr, e.TipoDocu })
                    .HasName("lcv_toli_k_toim");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FactAdic)
                    .HasColumnName("fact_adic")
                    .HasColumnType("numeric(6, 4)");

                entity.Property(e => e.MontCila)
                    .HasColumnName("mont_cila")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<LcvTotaImpuP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu, e.CodiImpu })
                    .HasName("lcv_toim_p_pk");

                entity.ToTable("lcv_tota_impu_p");

                entity.HasIndex(e => e.CodiImpu)
                    .HasName("lcv_impu_k_toim_p");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr, e.TipoDocu })
                    .HasName("lcv_toli_k_toim_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FactAdic)
                    .HasColumnName("fact_adic")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontCila)
                    .HasColumnName("mont_cila")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvTotaLibr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu })
                    .HasName("lcv_toli_pk");

                entity.ToTable("lcv_tota_libr");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr })
                    .HasName("lcv_reli_k_toli");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FactProp)
                    .HasColumnName("fact_prop")
                    .HasColumnType("numeric(10, 6)");

                entity.Property(e => e.ImpuSicr)
                    .HasColumnName("impu_sicr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaFupl)
                    .HasColumnName("iva_fupl")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaRtpa)
                    .HasColumnName("iva_rtpa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaRtto)
                    .HasColumnName("iva_rtto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontCrco)
                    .HasColumnName("mont_crco")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontCrec)
                    .HasColumnName("mont_crec")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontIvac)
                    .HasColumnName("mont_ivac")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVehi)
                    .HasColumnName("mont_vehi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OperExen)
                    .HasColumnName("oper_exen")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperFijo)
                    .HasColumnName("oper_fijo")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperIvac)
                    .HasColumnName("oper_ivac")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperNret)
                    .HasColumnName("oper_nret")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperRepa)
                    .HasColumnName("oper_repa")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperReto)
                    .HasColumnName("oper_reto")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperVaag)
                    .HasColumnName("oper_vaag")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperVafi)
                    .HasColumnName("oper_vafi")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TotaAnul)
                    .HasColumnName("tota_anul")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LcvTotaLibr)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv })
                    .HasConstraintName("lcv_toli_fk_reli");
            });

            modelBuilder.Entity<LcvTotaLibrP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu })
                    .HasName("lcv_toli_p_pk");

                entity.ToTable("lcv_tota_libr_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FactImpu)
                    .HasColumnName("fact_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FactProp)
                    .HasColumnName("fact_prop")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuSicr)
                    .HasColumnName("impu_sicr")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IvaFupl)
                    .HasColumnName("iva_fupl")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IvaRtpa)
                    .HasColumnName("iva_rtpa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IvaRtto)
                    .HasColumnName("iva_rtto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontCila)
                    .HasColumnName("mont_cila")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontCrco)
                    .HasColumnName("mont_crco")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontCrec)
                    .HasColumnName("mont_crec")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontIvac)
                    .HasColumnName("mont_ivac")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontVehi)
                    .HasColumnName("mont_vehi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperExen)
                    .HasColumnName("oper_exen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OperFijo)
                    .HasColumnName("oper_fijo")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperIvac)
                    .HasColumnName("oper_ivac")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperNret)
                    .HasColumnName("oper_nret")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperRepa)
                    .HasColumnName("oper_repa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperReto)
                    .HasColumnName("oper_reto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperVaag)
                    .HasColumnName("oper_vaag")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperVafi)
                    .HasColumnName("oper_vafi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotaAnul)
                    .HasColumnName("tota_anul")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvTotaNore>(entity =>
            {
                entity.HasKey(e => new { e.CorrLicv, e.CodiEmpr, e.CodiNore, e.TipoDocu })
                    .HasName("lcv_tonr_pk");

                entity.ToTable("lcv_tota_nore");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiNore)
                    .HasColumnName("codi_nore")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontNore)
                    .HasColumnName("mont_nore")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OperNore)
                    .HasColumnName("oper_nore")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.LcvTotaLibr)
                    .WithMany(p => p.LcvTotaNore)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv, d.TipoDocu })
                    .HasConstraintName("lcv_tota_fk_nore");
            });

            modelBuilder.Entity<LcvTotaNoreP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLicv, e.CodiEmpr, e.CodiNore, e.TipoDocu })
                    .HasName("lcv_tonr_p_pk");

                entity.ToTable("lcv_tota_nore_p");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiNore)
                    .HasColumnName("codi_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontNore)
                    .HasColumnName("mont_nore")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OperNore)
                    .HasColumnName("oper_nore")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LcvTotaSegm>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu })
                    .HasName("lcv_tose_pk");

                entity.ToTable("lcv_tota_segm");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr })
                    .HasName("lcv_reli_k_seli");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuSicr)
                    .HasColumnName("impu_sicr")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaFupl)
                    .HasColumnName("iva_fupl")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaRtpa)
                    .HasColumnName("iva_rtpa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.IvaRtto)
                    .HasColumnName("iva_rtto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontCred)
                    .HasColumnName("mont_cred")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontIvac)
                    .HasColumnName("mont_ivac")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OperExen)
                    .HasColumnName("oper_exen")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperFijo)
                    .HasColumnName("oper_fijo")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperIvac)
                    .HasColumnName("oper_ivac")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperNret)
                    .HasColumnName("oper_nret")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperRepa)
                    .HasColumnName("oper_repa")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperReto)
                    .HasColumnName("oper_reto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OperVaag)
                    .HasColumnName("oper_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TotaAnul)
                    .HasColumnName("tota_anul")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LcvTotaSegm)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv })
                    .HasConstraintName("lcv_tose_fk_reli");
            });

            modelBuilder.Entity<LcvTotaSegmP>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CorrLicv, e.TipoDocu })
                    .HasName("lcv_tose_p_pk");

                entity.ToTable("lcv_tota_segm_p");

                entity.HasIndex(e => new { e.CorrLicv, e.CodiEmpr })
                    .HasName("lcv_reli_k_seli_p");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CorrLicv)
                    .HasColumnName("corr_licv")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CantDocu)
                    .HasColumnName("cant_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImpuSicr)
                    .HasColumnName("impu_sicr")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IvaFupl)
                    .HasColumnName("iva_fupl")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IvaRtpa)
                    .HasColumnName("iva_rtpa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IvaRtto)
                    .HasColumnName("iva_rtto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontCred)
                    .HasColumnName("mont_cred")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontEnva)
                    .HasColumnName("mont_enva")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontExen)
                    .HasColumnName("mont_exen")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontFijo)
                    .HasColumnName("mont_fijo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontIvac)
                    .HasColumnName("mont_ivac")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontLe18)
                    .HasColumnName("mont_le18")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNofa)
                    .HasColumnName("mont_nofa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontNret)
                    .HasColumnName("mont_nret")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPain)
                    .HasColumnName("mont_pain")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPana)
                    .HasColumnName("mont_pana")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontPeri)
                    .HasColumnName("mont_peri")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTaci)
                    .HasColumnName("mont_taci")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTael)
                    .HasColumnName("mont_tael")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTapu)
                    .HasColumnName("mont_tapu")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MontVafi)
                    .HasColumnName("mont_vafi")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperExen)
                    .HasColumnName("oper_exen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OperFijo)
                    .HasColumnName("oper_fijo")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperIvac)
                    .HasColumnName("oper_ivac")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperNret)
                    .HasColumnName("oper_nret")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.OperReto)
                    .HasColumnName("oper_reto")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperRtpa)
                    .HasColumnName("oper_rtpa")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OperVaag)
                    .HasColumnName("oper_vaag")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TipoImpu)
                    .HasColumnName("tipo_impu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotaAnul)
                    .HasColumnName("tota_anul")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaagProp)
                    .HasColumnName("vaag_prop")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaagTerc)
                    .HasColumnName("vaag_terc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LcvTotaSegmP)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CorrLicv })
                    .HasConstraintName("lcv_tose_fk_reli_p");
            });

            modelBuilder.Entity<LcvTotaTemp>(entity =>
            {
                entity.HasKey(e => new { e.TipoOper, e.TipoLibr, e.RuttAsoc, e.PeriTrib, e.TipoDocu, e.FoliDocu, e.RuttCont, e.CodiImpu })
                    .HasName("lcv_tmp2_pk");

                entity.ToTable("lcv_tota_temp");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PeriTrib)
                    .HasColumnName("peri_trib")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.RuttCont)
                    .HasColumnName("rutt_cont")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiImpu)
                    .HasColumnName("codi_impu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MontImpu)
                    .HasColumnName("mont_impu")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TasaImpu)
                    .HasColumnName("tasa_impu")
                    .HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.LcvDetaTemp)
                    .WithMany(p => p.LcvTotaTemp)
                    .HasForeignKey(d => new { d.TipoOper, d.TipoLibr, d.RuttAsoc, d.PeriTrib, d.TipoDocu, d.FoliDocu, d.RuttCont })
                    .HasConstraintName("lcv_tmp2_fk_temp");
            });

            modelBuilder.Entity<LgdDetaDocu>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr, e.FoliDocu, e.TipoOper, e.RuttAsoc })
                    .HasName("lgd_deta_pk");

                entity.ToTable("lgd_deta_docu");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_enli_k_dedo");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigiAsoc)
                    .HasColumnName("digi_asoc")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechDocu)
                    .HasColumnName("fech_docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MontModi)
                    .HasColumnName("mont_modi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NombAsoc)
                    .HasColumnName("nomb_asoc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LgdDetaDocu)
                    .HasForeignKey(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_dedo_fk_enli");
            });

            modelBuilder.Entity<LgdDetaDocuP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr, e.TipoOper, e.RuttAsoc, e.FoliDocu })
                    .HasName("lgd_deta_p_pk");

                entity.ToTable("lgd_deta_docu_p");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_enli_k_dedo_p");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.TipoOper)
                    .HasColumnName("tipo_oper")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttAsoc)
                    .HasColumnName("rutt_asoc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigiAsoc)
                    .HasColumnName("digi_asoc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechDocu)
                    .HasColumnName("fech_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechRefe)
                    .HasColumnName("fech_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliRefe)
                    .HasColumnName("foli_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontModi)
                    .HasColumnName("mont_modi")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontNeto)
                    .HasColumnName("mont_neto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontTota)
                    .HasColumnName("mont_tota")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontVaag)
                    .HasColumnName("mont_vaag")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombAsoc)
                    .HasColumnName("nomb_asoc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TasaVaag)
                    .HasColumnName("tasa_vaag")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRefe)
                    .HasColumnName("tipo_refe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VigeDocu)
                    .HasColumnName("vige_docu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LgdDetaDocuP)
                    .HasForeignKey(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_dedo_fk_enli_p");
            });

            modelBuilder.Entity<LgdEncaLigd>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_enca_pk");

                entity.ToTable("lgd_enca_ligd");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("foli_noti")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeSegm)
                    .HasColumnName("nume_segm")
                    .HasColumnType("numeric(6, 0)");

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSegm)
                    .HasColumnName("tipo_segm")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LgdEncaLigdP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_enca_p_pk");

                entity.ToTable("lgd_enca_ligd_p");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigiEmis)
                    .HasColumnName("digi_emis")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FehoFirm)
                    .HasColumnName("feho_firm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FoliNoti)
                    .HasColumnName("foli_noti")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeSegm)
                    .HasColumnName("nume_segm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RuttEmis)
                    .HasColumnName("rutt_emis")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibr)
                    .HasColumnName("tipo_libr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSegm)
                    .HasColumnName("tipo_segm")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LgdTotaPeri>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tope_pk");

                entity.ToTable("lgd_tota_peri");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tope_k_enli");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGvta)
                    .HasColumnName("mont_gvta")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontModi)
                    .HasColumnName("mont_modi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeFoan)
                    .HasColumnName("nume_foan")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeGanu)
                    .HasColumnName("nume_ganu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TotaGvta)
                    .HasColumnName("tota_gvta")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Co)
                    .WithOne(p => p.LgdTotaPeri)
                    .HasForeignKey<LgdTotaPeri>(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_tope_fk_enli");
            });

            modelBuilder.Entity<LgdTotaPeriP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tope_p_pk");

                entity.ToTable("lgd_tota_peri_p");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tope_k_enli_p");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGvta)
                    .HasColumnName("mont_gvta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontModi)
                    .HasColumnName("mont_modi")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeFoan)
                    .HasColumnName("nume_foan")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeGanu)
                    .HasColumnName("nume_ganu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotaGvta)
                    .HasColumnName("tota_gvta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Co)
                    .WithOne(p => p.LgdTotaPeriP)
                    .HasForeignKey<LgdTotaPeriP>(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_tope_fk_enli_p");
            });

            modelBuilder.Entity<LgdTotaSegm>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tose_pk");

                entity.ToTable("lgd_tota_segm");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_enli_k_tose");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGvta)
                    .HasColumnName("mont_gvta")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MontModi)
                    .HasColumnName("mont_modi")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NumeFoan)
                    .HasColumnName("nume_foan")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.NumeGanu)
                    .HasColumnName("nume_ganu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TotaGvta)
                    .HasColumnName("tota_gvta")
                    .HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Co)
                    .WithOne(p => p.LgdTotaSegm)
                    .HasForeignKey<LgdTotaSegm>(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_tose_fk_enli");
            });

            modelBuilder.Entity<LgdTotaSegmP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tose_p_pk");

                entity.ToTable("lgd_tota_segm_p");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_enli_k_tose_p");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGvta)
                    .HasColumnName("mont_gvta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontModi)
                    .HasColumnName("mont_modi")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeFoan)
                    .HasColumnName("nume_foan")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumeGanu)
                    .HasColumnName("nume_ganu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotaGvta)
                    .HasColumnName("tota_gvta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Co)
                    .WithOne(p => p.LgdTotaSegmP)
                    .HasForeignKey<LgdTotaSegmP>(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_tose_fk_enli_p");
            });

            modelBuilder.Entity<LgdTrasPeri>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr, e.CodiTras })
                    .HasName("lgd_trpe_pk");

                entity.ToTable("lgd_tras_peri");

                entity.HasIndex(e => e.CodiTras)
                    .HasName("lgd_trpe_k_tras");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_trpe_k_tope");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiTras)
                    .HasColumnName("codi_tras")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CantGuia)
                    .HasColumnName("cant_guia")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGuia)
                    .HasColumnName("mont_guia")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TipoTras)
                    .HasColumnName("tipo_tras")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LgdTrasPeri)
                    .HasForeignKey(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_trpe_fk_tope");
            });

            modelBuilder.Entity<LgdTrasPeriP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr, e.CodiTras })
                    .HasName("lgd_trpe_p_pk");

                entity.ToTable("lgd_tras_peri_p");

                entity.HasIndex(e => e.CodiTras)
                    .HasName("lgd_trpe_k_tras_p");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_trpe_k_tope_p");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiTras)
                    .HasColumnName("codi_tras")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CantGuia)
                    .HasColumnName("cant_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGuia)
                    .HasColumnName("mont_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTras)
                    .HasColumnName("tipo_tras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LgdTrasPeriP)
                    .HasForeignKey(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_trpe_fk_tope_p");
            });

            modelBuilder.Entity<LgdTrasSegm>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr, e.CodiTras })
                    .HasName("lgd_trse_pk");

                entity.ToTable("lgd_tras_segm");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tose_k_trse");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiTras)
                    .HasColumnName("codi_tras")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CantGuia)
                    .HasColumnName("cant_guia")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGuia)
                    .HasColumnName("mont_guia")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TipoTras)
                    .HasColumnName("tipo_tras")
                    .HasColumnType("numeric(1, 0)");

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LgdTrasSegm)
                    .HasForeignKey(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_trse_fk_tose");
            });

            modelBuilder.Entity<LgdTrasSegmP>(entity =>
            {
                entity.HasKey(e => new { e.CorrLigd, e.CodiEmpr, e.CodiTras })
                    .HasName("lgd_trse_p_pk");

                entity.ToTable("lgd_tras_segm_p");

                entity.HasIndex(e => new { e.CorrLigd, e.CodiEmpr })
                    .HasName("lgd_tose_k_trse_p");

                entity.Property(e => e.CorrLigd)
                    .HasColumnName("corr_ligd")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CodiTras)
                    .HasColumnName("codi_tras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CantGuia)
                    .HasColumnName("cant_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MontGuia)
                    .HasColumnName("mont_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTras)
                    .HasColumnName("tipo_tras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Co)
                    .WithMany(p => p.LgdTrasSegmP)
                    .HasForeignKey(d => new { d.CorrLigd, d.CodiEmpr })
                    .HasConstraintName("lgd_trse_fk_tose_p");
            });

            modelBuilder.Entity<LogErro>(entity =>
            {
                entity.HasKey(e => e.CorrLogg);

                entity.ToTable("log_erro");

                entity.Property(e => e.CorrLogg)
                    .HasColumnName("corr_logg")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.ArchErro)
                    .IsRequired()
                    .HasColumnName("arch_erro")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BinnErro)
                    .IsRequired()
                    .HasColumnName("binn_erro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.FechErro)
                    .IsRequired()
                    .HasColumnName("fech_erro")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("foli_docu")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.HoraErro)
                    .IsRequired()
                    .HasColumnName("hora_erro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsajErro)
                    .IsRequired()
                    .HasColumnName("msaj_erro")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProcErro)
                    .IsRequired()
                    .HasColumnName("proc_erro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("tipo_docu")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<LogUsuario>(entity =>
            {
                entity.HasKey(e => new { e.LogFecha, e.LogUsuario1, e.LogCodiEmpr });

                entity.ToTable("log_usuario");

                entity.Property(e => e.LogFecha)
                    .HasColumnName("log_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogUsuario1)
                    .HasColumnName("log_usuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogCodiEmpr)
                    .HasColumnName("log_codi_empr")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.LogAccion)
                    .HasColumnName("log_accion")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MantProd>(entity =>
            {
                entity.HasKey(e => e.ProdCodi);

                entity.ToTable("mant_prod");

                entity.Property(e => e.ProdCodi)
                    .HasColumnName("prod_codi")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ProdDesc)
                    .HasColumnName("prod_desc")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProdValu)
                    .HasColumnName("prod_valu")
                    .HasColumnType("numeric(22, 4)");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.CodiMone)
                    .HasName("mone_pk_mone_1");

                entity.ToTable("moneda");

                entity.HasIndex(e => new { e.NombMone, e.RounMone })
                    .HasName("ia_mone_2");

                entity.Property(e => e.CodiMone)
                    .HasColumnName("codi_mone")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiMoneAnte)
                    .HasColumnName("codi_mone_ante")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPais)
                    .HasColumnName("codi_pais")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FisoMone)
                    .HasColumnName("fiso_mone")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MndaCdg)
                    .HasColumnName("mnda_cdg")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MndaNmb)
                    .HasColumnName("mnda_nmb")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombMone)
                    .HasColumnName("nomb_mone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeMone)
                    .HasColumnName("nume_mone")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RounMone)
                    .HasColumnName("roun_mone")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.UmoRound)
                    .HasColumnName("umo_round")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<Mtod>(entity =>
            {
                entity.HasKey(e => new { e.MtodId, e.MtodStat })
                    .HasName("mtod_pk");

                entity.ToTable("mtod");

                entity.Property(e => e.MtodId)
                    .HasColumnName("mtod_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MtodStat)
                    .HasColumnName("mtod_stat")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MtodCc)
                    .HasColumnName("mtod_cc")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.MtodEnvio)
                    .HasColumnName("mtod_envio")
                    .HasColumnType("datetime");

                entity.Property(e => e.MtodErrno)
                    .HasColumnName("mtod_errno")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MtodErrtxt)
                    .HasColumnName("mtod_errtxt")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MtodFrom)
                    .HasColumnName("mtod_from")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.MtodSubject)
                    .HasColumnName("mtod_subject")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MtodText)
                    .HasColumnName("mtod_text")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MtodTo)
                    .HasColumnName("mtod_to")
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OficEmpr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiOfic })
                    .HasName("ofic_pk");

                entity.ToTable("ofic_empr");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("if_ofic_1");

                entity.HasIndex(e => e.DescOfic)
                    .HasName("ia_ofic_2");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiOfic)
                    .HasColumnName("codi_ofic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCiud)
                    .HasColumnName("codi_ciud")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiComu)
                    .HasColumnName("codi_comu")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiPais)
                    .HasColumnName("CODI_PAIS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSii)
                    .HasColumnName("codi_sii")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescOfic)
                    .HasColumnName("desc_ofic")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DireOfic)
                    .HasColumnName("dire_ofic")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FaxxOfic)
                    .HasColumnName("FAXX_OFIC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FonoOfic)
                    .HasColumnName("FONO_OFIC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelxOfic)
                    .HasColumnName("TELX_OFIC")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.OficEmpr)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ofem_fk_empr");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.OficEmpr)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .HasConstraintName("ofem_fk_ceco");
            });

            modelBuilder.Entity<ParaEmpr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.TipoComo, e.CodiPaem })
                    .HasName("paem_pk");

                entity.ToTable("para_empr");

                entity.HasIndex(e => new { e.DescPaem, e.CodiEmpr })
                    .HasName("paem_ia_desc");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoComo)
                    .HasColumnName("tipo_como")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPaem)
                    .HasColumnName("codi_paem")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DescPaem)
                    .HasColumnName("desc_paem")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObliPaem)
                    .HasColumnName("obli_paem")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPaem)
                    .HasColumnName("valo_paem")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParaPers>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiPers, e.TipoComo, e.CodiPape })
                    .HasName("PAPE_PK_EMPR");

                entity.ToTable("para_pers");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("CODI_PERS")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComo)
                    .HasColumnName("TIPO_COMO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPape)
                    .HasColumnName("CODI_PAPE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.DescPape)
                    .IsRequired()
                    .HasColumnName("DESC_PAPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPape)
                    .HasColumnName("VALO_PAPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.ParaPers)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAPE_FK_EMPR");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.ParaPers)
                    .HasForeignKey(d => d.CodiPers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PAPE_FK_PERS");
            });

            modelBuilder.Entity<PersPaide>(entity =>
            {
                entity.HasKey(e => e.ContRutt)
                    .HasName("PERS_PAIDE_PK");

                entity.ToTable("PERS_PAIDE");

                entity.Property(e => e.ContRutt)
                    .HasColumnName("CONT_RUTT")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ContDigi)
                    .IsRequired()
                    .HasColumnName("CONT_DIGI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContUrllSii)
                    .HasColumnName("CONT_URLL_SII")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContRuttNavigation)
                    .WithOne(p => p.PersPaide)
                    .HasForeignKey<PersPaide>(d => d.ContRutt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DTE_ENDO_H_FK_PAIDE");
            });

            modelBuilder.Entity<PersPubl>(entity =>
            {
                entity.HasKey(e => e.ContRutt)
                    .HasName("PERS_PUBL_PK");

                entity.ToTable("PERS_PUBL");

                entity.Property(e => e.ContRutt)
                    .HasColumnName("CONT_RUTT")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ContCasiSii)
                    .IsRequired()
                    .HasColumnName("CONT_CASI_SII")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContDigi)
                    .IsRequired()
                    .HasColumnName("CONT_DIGI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContRazo)
                    .IsRequired()
                    .HasColumnName("CONT_RAZO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContUrllSii)
                    .HasColumnName("CONT_URLL_SII")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechConf)
                    .HasColumnName("FECH_CONF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .HasColumnName("FECH_RESO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersPais)
                    .HasColumnName("PERS_PAIS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CL')");
            });

            modelBuilder.Entity<PersPublTemp>(entity =>
            {
                entity.HasKey(e => e.ContRutt)
                    .HasName("PERS_PUBL_TEMP_PK");

                entity.ToTable("PERS_PUBL_TEMP");

                entity.Property(e => e.ContRutt)
                    .HasColumnName("CONT_RUTT")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.ContCasiSii)
                    .IsRequired()
                    .HasColumnName("CONT_CASI_SII")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContDigi)
                    .IsRequired()
                    .HasColumnName("CONT_DIGI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContRazo)
                    .IsRequired()
                    .HasColumnName("CONT_RAZO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ContUrllSii)
                    .HasColumnName("CONT_URLL_SII")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FechConf)
                    .HasColumnName("FECH_CONF")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechReso)
                    .IsRequired()
                    .HasColumnName("FECH_RESO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersPais)
                    .HasColumnName("PERS_PAIS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CL')");
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.CodiPers)
                    .HasName("pers_pk");

                entity.ToTable("personas");

                entity.HasIndex(e => e.CliePers)
                    .HasName("id_pers_clie_pers");

                entity.HasIndex(e => e.CodiComu)
                    .HasName("id_pers_codi_comu");

                entity.HasIndex(e => e.CodiPais)
                    .HasName("if_pers_3");

                entity.HasIndex(e => e.CodiPers1)
                    .HasName("if_pers_1");

                entity.HasIndex(e => e.CodiRamo)
                    .HasName("if_pers_2");

                entity.HasIndex(e => e.CompPers)
                    .HasName("id_pers_comp_pers");

                entity.HasIndex(e => e.EmplPers)
                    .HasName("id_pers_empl_pers");

                entity.HasIndex(e => e.FuncPers)
                    .HasName("id_pers_func_pers");

                entity.HasIndex(e => e.NombPers)
                    .HasName("ia_pers_2");

                entity.HasIndex(e => e.PersSele)
                    .HasName("id_pers_pers_sele");

                entity.HasIndex(e => e.ProvPers)
                    .HasName("id_pers_prov_pers");

                entity.HasIndex(e => e.RuttPers)
                    .HasName("ia_pers_4");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AcciPers)
                    .HasColumnName("acci_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AsunFactPers)
                    .HasColumnName("asun_fact_pers")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AutoCesi)
                    .HasColumnName("auto_cesi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CliePers)
                    .HasColumnName("clie_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiComu)
                    .HasColumnName("codi_comu")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEciv)
                    .HasColumnName("codi_eciv")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiMail)
                    .HasColumnName("codi_mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMail1)
                    .HasColumnName("CODI_MAIL1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMail2)
                    .HasColumnName("CODI_MAIL2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMail3)
                    .HasColumnName("CODI_MAIL3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMail4)
                    .HasColumnName("CODI_MAIL4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPais)
                    .HasColumnName("codi_pais")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers1)
                    .HasColumnName("codi_pers1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiProf)
                    .HasColumnName("codi_prof")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRamo)
                    .HasColumnName("codi_ramo")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ComePers)
                    .HasColumnName("come_pers")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CompPers)
                    .HasColumnName("comp_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DgtoPers)
                    .HasColumnName("dgto_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DirePers)
                    .HasColumnName("dire_pers")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmplPers)
                    .HasColumnName("empl_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmprPers)
                    .HasColumnName("empr_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechPers)
                    .HasColumnName("fech_pers")
                    .HasColumnType("datetime");

                entity.Property(e => e.FonoPers)
                    .HasColumnName("fono_pers")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FuncPers)
                    .HasColumnName("func_pers")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModiDocu)
                    .HasColumnName("modi_docu")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NfanPers)
                    .HasColumnName("nfan_pers")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NombPers)
                    .HasColumnName("nomb_pers")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrigPers)
                    .HasColumnName("orig_pers")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PersSele)
                    .HasColumnName("pers_sele")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrefPers)
                    .HasColumnName("pref_pers")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ProvPers)
                    .HasColumnName("prov_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RuttPers)
                    .HasColumnName("rutt_pers")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.SexoPers)
                    .HasColumnName("sexo_pers")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TextFactPers)
                    .HasColumnName("text_fact_pers")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDesc)
                    .HasColumnName("tipo_desc")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("pers_fk_empr");

                entity.HasOne(d => d.CodiPers1Navigation)
                    .WithMany(p => p.InverseCodiPers1Navigation)
                    .HasForeignKey(d => d.CodiPers1)
                    .HasConstraintName("pers1_fk_pers");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .HasConstraintName("pers_fk_ceco");
            });

            modelBuilder.Entity<ProcLogs>(entity =>
            {
                entity.HasKey(e => e.Proceso);

                entity.ToTable("PROC_LOGS");

                entity.Property(e => e.Proceso)
                    .HasColumnName("proceso")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasColumnName("archivo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");
            });

            modelBuilder.Entity<QseDocuServ>(entity =>
            {
                entity.HasKey(e => e.CodiDopr)
                    .HasName("qse_docu_serv_pk");

                entity.ToTable("qse_docu_serv");

                entity.HasIndex(e => new { e.EstaProc, e.CodiServ })
                    .HasName("qse_docu_serv_idx");

                entity.HasIndex(e => new { e.EstaProc, e.TimeProc })
                    .HasName("QSE_DOCU_SERV_LIMPIA");

                entity.Property(e => e.CodiDopr)
                    .HasColumnName("CODI_DOPR")
                    .HasColumnType("numeric(20, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CantProc)
                    .HasColumnName("CANT_PROC")
                    .HasColumnType("numeric(9, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodiDocu)
                    .IsRequired()
                    .HasColumnName("CODI_DOCU")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .IsRequired()
                    .HasColumnName("CODI_EMEX")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiServ)
                    .IsRequired()
                    .HasColumnName("CODI_SERV")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSrvd)
                    .HasColumnName("CODI_SRVD")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.CorrRefe)
                    .HasColumnName("CORR_REFE")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EstaProc)
                    .IsRequired()
                    .HasColumnName("ESTA_PROC")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ING')");

                entity.Property(e => e.FlagDocu)
                    .HasColumnName("FLAG_DOCU")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FoliDocu)
                    .HasColumnName("FOLI_DOCU")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.TablEsta)
                    .HasColumnName("TABL_ESTA")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TablOrig)
                    .HasColumnName("TABL_ORIG")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TimeProc)
                    .HasColumnName("TIME_PROC")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoDocu)
                    .HasColumnName("TIPO_DOCU")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.UltiErro)
                    .HasColumnName("ULTI_ERRO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPk1)
                    .HasColumnName("VALO_PK1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPk2)
                    .HasColumnName("VALO_PK2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPk3)
                    .HasColumnName("VALO_PK3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPk4)
                    .HasColumnName("VALO_PK4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValoPk5)
                    .HasColumnName("VALO_PK5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmexNavigation)
                    .WithMany(p => p.QseDocuServ)
                    .HasForeignKey(d => d.CodiEmex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("qse_docu_serv_fk_emex");
            });

            modelBuilder.Entity<Ramo>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiRamo })
                    .HasName("RAMO_PK_RAMO_1");

                entity.ToTable("ramo");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("CODI_EMPR")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiRamo)
                    .HasColumnName("CODI_RAMO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("CODI_CECO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRamoSup)
                    .HasColumnName("CODI_RAMO_SUP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiSii)
                    .HasColumnName("CODI_SII")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DescRamo)
                    .HasColumnName("DESC_RAMO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IndiClie)
                    .HasColumnName("INDI_CLIE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiEmpl)
                    .HasColumnName("INDI_EMPL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiEmpr)
                    .HasColumnName("INDI_EMPR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiProv)
                    .HasColumnName("INDI_PROV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NombRamo)
                    .HasColumnName("NOMB_RAMO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrdeGefi)
                    .HasColumnName("ORDE_GEFI")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.OrdeRamo)
                    .HasColumnName("ORDE_RAMO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.Ramo)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RAMO_FK_EMPR");
            });

            modelBuilder.Entity<RepDtoEnca>(entity =>
            {
                entity.HasKey(e => e.CorrId)
                    .HasName("PK_RDTO_ENCA");

                entity.ToTable("rep_dto_enca");

                entity.Property(e => e.CorrId)
                    .HasColumnName("corr_id")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.DigiRece)
                    .HasColumnName("digi_rece")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PeriDocu)
                    .HasColumnName("peri_docu")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RuttRece)
                    .HasColumnName("rutt_rece")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SePipe>(entity =>
            {
                entity.HasKey(e => e.PipeId)
                    .HasName("PK__se_pipe__2F3AE904");

                entity.ToTable("se_pipe");

                entity.HasIndex(e => e.PipeStat)
                    .HasName("se_pipe_idx1");

                entity.Property(e => e.PipeId)
                    .HasColumnName("pipe_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PipeCmd)
                    .IsRequired()
                    .HasColumnName("pipe_cmd")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PipeCodiUsua)
                    .HasColumnName("pipe_codi_usua")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PipeFechCrea)
                    .HasColumnName("pipe_fech_crea")
                    .HasColumnType("datetime");

                entity.Property(e => e.PipeFechEjec)
                    .HasColumnName("pipe_fech_ejec")
                    .HasColumnType("datetime");

                entity.Property(e => e.PipeStat)
                    .IsRequired()
                    .HasColumnName("pipe_stat")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysAlar>(entity =>
            {
                entity.HasKey(e => e.CodiAlar)
                    .HasName("sys_alar_pk");

                entity.ToTable("sys_alar");

                entity.HasIndex(e => e.DescAlar)
                    .HasName("alar_uk")
                    .IsUnique();

                entity.Property(e => e.CodiAlar)
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AcciAlar)
                    .HasColumnName("acci_alar")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompAlar)
                    .HasColumnName("comp_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Des1)
                    .HasColumnName("des1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Des2)
                    .HasColumnName("des2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Des3)
                    .HasColumnName("des3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Des4)
                    .HasColumnName("des4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Des5)
                    .HasColumnName("des5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Des6)
                    .HasColumnName("des6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescAlar)
                    .HasColumnName("desc_alar")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DiavAlar)
                    .HasColumnName("diav_alar")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ErroAlar)
                    .HasColumnName("erro_alar")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EstaAlar)
                    .HasColumnName("esta_alar")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FeasAlar)
                    .HasColumnName("feas_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeavAlar)
                    .HasColumnName("feav_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechAlar)
                    .HasColumnName("fech_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FesiAlar)
                    .HasColumnName("fesi_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrecAlar)
                    .HasColumnName("frec_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiAlar)
                    .HasColumnName("indi_alar")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.MailInfo)
                    .HasColumnName("MAIL_INFO")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName1)
                    .HasColumnName("object_name1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par1)
                    .HasColumnName("par1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par2)
                    .HasColumnName("par2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par3)
                    .HasColumnName("par3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par4)
                    .HasColumnName("par4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par5)
                    .HasColumnName("par5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par6)
                    .HasColumnName("par6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PrioAlar)
                    .HasColumnName("prio_alar")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Sql2Alar)
                    .HasColumnName("sql2_alar")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SqlcAlar)
                    .HasColumnName("sqlc_alar")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SqldAlar)
                    .IsRequired()
                    .HasColumnName("sqld_alar")
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('delete from sys_alin where codi_alar = ''alarma'' and codi_usua=''usuario'' and codi_emex=''holding'' and codi_empr=1010')");

                entity.Property(e => e.SqliAlar)
                    .HasColumnName("sqli_alar")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatAlar)
                    .HasColumnName("stat_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAlar)
                    .HasColumnName("tipo_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValoAlar)
                    .HasColumnName("valo_alar")
                    .HasColumnType("numeric(22, 0)");
            });

            modelBuilder.Entity<SysAlarEmex>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmex, e.CodiAlar })
                    .HasName("sys_alar_emex_pk");

                entity.ToTable("sys_alar_emex");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiAlar)
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompAlar)
                    .IsRequired()
                    .HasColumnName("comp_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiavAlar)
                    .HasColumnName("diav_alar")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ErroAlar)
                    .HasColumnName("erro_alar")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EstaAlar)
                    .HasColumnName("esta_alar")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FeasAlar)
                    .HasColumnName("feas_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeavAlar)
                    .HasColumnName("feav_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechAlar)
                    .HasColumnName("fech_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FesiAlar)
                    .HasColumnName("fesi_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrecAlar)
                    .IsRequired()
                    .HasColumnName("frec_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiAlar)
                    .HasColumnName("indi_alar")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.MailCccc)
                    .IsRequired()
                    .HasColumnName("mail_cccc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MailInfo)
                    .IsRequired()
                    .HasColumnName("mail_info")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrioAlar)
                    .HasColumnName("prio_alar")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Sql2Alar)
                    .IsRequired()
                    .HasColumnName("sql2_alar")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatAlar)
                    .HasColumnName("stat_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAlar)
                    .HasColumnName("tipo_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValoAlar)
                    .HasColumnName("valo_alar")
                    .HasColumnType("numeric(22, 0)");

                entity.HasOne(d => d.CodiAlarNavigation)
                    .WithMany(p => p.SysAlarEmex)
                    .HasForeignKey(d => d.CodiAlar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alar_emex_fk_coal");
            });

            modelBuilder.Entity<SysAlarEmpr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmex, e.CodiEmpr, e.CodiAlar })
                    .HasName("sys_alar_empr_pk");

                entity.ToTable("sys_alar_empr");

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiAlar)
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompAlar)
                    .IsRequired()
                    .HasColumnName("comp_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiavAlar)
                    .HasColumnName("diav_alar")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ErroAlar)
                    .HasColumnName("erro_alar")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EstaAlar)
                    .HasColumnName("esta_alar")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FeasAlar)
                    .HasColumnName("feas_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeavAlar)
                    .HasColumnName("feav_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechAlar)
                    .HasColumnName("fech_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FesiAlar)
                    .HasColumnName("fesi_alar")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrecAlar)
                    .IsRequired()
                    .HasColumnName("frec_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiAlar)
                    .HasColumnName("indi_alar")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.MailCccc)
                    .IsRequired()
                    .HasColumnName("mail_cccc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MailInfo)
                    .IsRequired()
                    .HasColumnName("mail_info")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrioAlar)
                    .HasColumnName("prio_alar")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Sql2Alar)
                    .IsRequired()
                    .HasColumnName("sql2_alar")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatAlar)
                    .HasColumnName("stat_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAlar)
                    .HasColumnName("tipo_alar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValoAlar)
                    .HasColumnName("valo_alar")
                    .HasColumnType("numeric(22, 0)");

                entity.HasOne(d => d.CodiAlarNavigation)
                    .WithMany(p => p.SysAlarEmpr)
                    .HasForeignKey(d => d.CodiAlar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alar_empr_fk_coal");
            });

            modelBuilder.Entity<SysAlin>(entity =>
            {
                entity.HasKey(e => e.CodiAlin)
                    .HasName("sys_alin_pk");

                entity.ToTable("sys_alin");

                entity.HasIndex(e => new { e.CodiAlar, e.CodiUsua })
                    .HasName("alin_ak");

                entity.Property(e => e.CodiAlin)
                    .HasColumnName("codi_alin")
                    .HasColumnType("numeric(22, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiAlar)
                    .IsRequired()
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiUsua)
                    .IsRequired()
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiAlarNavigation)
                    .WithMany(p => p.SysAlin)
                    .HasForeignKey(d => d.CodiAlar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alin_fk_alar");
            });

            modelBuilder.Entity<SysAlri>(entity =>
            {
                entity.HasKey(e => new { e.CodiAlar, e.CodiRous })
                    .HasName("sys_alri_pk");

                entity.ToTable("sys_alri");

                entity.Property(e => e.CodiAlar)
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiAlarNavigation)
                    .WithMany(p => p.SysAlri)
                    .HasForeignKey(d => d.CodiAlar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alri_fk_alar");
            });

            modelBuilder.Entity<SysAlro>(entity =>
            {
                entity.HasKey(e => new { e.CodiAlar, e.CodiRous })
                    .HasName("sys_alro_pk");

                entity.ToTable("sys_alro");

                entity.Property(e => e.CodiAlar)
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailAlro)
                    .HasColumnName("mail_alro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiAlarNavigation)
                    .WithMany(p => p.SysAlro)
                    .HasForeignKey(d => d.CodiAlar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alro_fk_alar");
            });

            modelBuilder.Entity<SysAlus>(entity =>
            {
                entity.HasKey(e => new { e.CodiAlar, e.CodiUsua, e.OrigAlus })
                    .HasName("sys_alus_pk");

                entity.ToTable("sys_alus");

                entity.HasIndex(e => new { e.CodiUsua, e.OrigAlus })
                    .HasName("alus_ak");

                entity.Property(e => e.CodiAlar)
                    .HasColumnName("codi_alar")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrigAlus)
                    .HasColumnName("orig_alus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompAlus)
                    .HasColumnName("comp_alus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DiavAlus)
                    .HasColumnName("diav_alus")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ErroAlus)
                    .HasColumnName("erro_alus")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EstaAlus)
                    .HasColumnName("esta_alus")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FeasAlus)
                    .HasColumnName("feas_alus")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeavAlus)
                    .HasColumnName("feav_alus")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechAlus)
                    .HasColumnName("fech_alus")
                    .HasColumnType("datetime");

                entity.Property(e => e.FesiAlus)
                    .HasColumnName("fesi_alus")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrecAlus)
                    .HasColumnName("frec_alus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IndiAlus)
                    .HasColumnName("indi_alus")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.MailAlus)
                    .HasColumnName("mail_alus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrioAlus)
                    .HasColumnName("prio_alus")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.StatAlus)
                    .HasColumnName("stat_alus")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ValoAlus)
                    .HasColumnName("valo_alus")
                    .HasColumnType("numeric(22, 0)");

                entity.HasOne(d => d.CodiAlarNavigation)
                    .WithMany(p => p.SysAlus)
                    .HasForeignKey(d => d.CodiAlar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alus_fk_alar");

                entity.HasOne(d => d.CodiUsuaNavigation)
                    .WithMany(p => p.SysAlus)
                    .HasForeignKey(d => d.CodiUsua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_alus_fk_usua");
            });

            modelBuilder.Entity<SysAttrCult>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.AttrName, e.CodiCult })
                    .HasName("sys_attr_cult_pk");

                entity.ToTable("sys_attr_cult");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrName)
                    .HasColumnName("attr_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCult)
                    .HasColumnName("codi_cult")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectBrief)
                    .HasColumnName("object_brief")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectDesc)
                    .HasColumnName("object_desc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.SysAttribute)
                    .WithMany(p => p.SysAttrCult)
                    .HasForeignKey(d => new { d.ObjectName, d.AttrName })
                    .HasConstraintName("sys_attr_cult_attr");
            });

            modelBuilder.Entity<SysAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.AttrName })
                    .HasName("sys_attrribute_pk");

                entity.ToTable("sys_attribute");

                entity.HasIndex(e => e.AttrOrder)
                    .HasName("ia_sys_attribute");

                entity.HasIndex(e => e.CondAttr)
                    .HasName("if_sys_attribute1");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrName)
                    .HasColumnName("attr_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrBrief)
                    .HasColumnName("attr_brief")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrDate)
                    .HasColumnName("attr_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttrDefault)
                    .HasColumnName("attr_default")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrDesc)
                    .HasColumnName("attr_desc")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AttrKey)
                    .HasColumnName("ATTR_KEY")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AttrLength)
                    .HasColumnName("attr_length")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.AttrMand)
                    .HasColumnName("attr_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AttrOrder)
                    .HasColumnName("attr_order")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AttrPrec)
                    .HasColumnName("attr_prec")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AttrRela)
                    .HasColumnName("attr_rela")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrScale)
                    .HasColumnName("attr_scale")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.AttrState)
                    .HasColumnName("attr_state")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrStruct)
                    .HasColumnName("attr_struct")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AttrTag)
                    .HasColumnName("ATTR_TAG")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrType)
                    .HasColumnName("attr_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CondAttr)
                    .HasColumnName("cond_attr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CondDomain)
                    .HasColumnName("cond_domain")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DomainCode)
                    .HasColumnName("domain_code")
                    .HasColumnType("numeric(4, 0)");
            });

            modelBuilder.Entity<SysCode>(entity =>
            {
                entity.HasKey(e => new { e.DomainCode, e.Code })
                    .HasName("sys_code_pk");

                entity.ToTable("sys_code");

                entity.Property(e => e.DomainCode)
                    .HasColumnName("domain_code")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodeAux)
                    .HasColumnName("code_aux")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDele)
                    .HasColumnName("code_dele")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDesc)
                    .HasColumnName("code_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DomainCodeNavigation)
                    .WithMany(p => p.SysCode)
                    .HasForeignKey(d => d.DomainCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_c00108194");
            });

            modelBuilder.Entity<SysCodi>(entity =>
            {
                entity.HasKey(e => new { e.DomainCode, e.Code })
                    .HasName("sys_codi_pk");

                entity.ToTable("sys_codi");

                entity.Property(e => e.DomainCode)
                    .HasColumnName("domain_code")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodeAux)
                    .HasColumnName("code_aux")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDele)
                    .HasColumnName("code_dele")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDesc)
                    .HasColumnName("code_desc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DomainCodeNavigation)
                    .WithMany(p => p.SysCodi)
                    .HasForeignKey(d => d.DomainCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_c00108195");
            });

            modelBuilder.Entity<SysComment>(entity =>
            {
                entity.HasKey(e => new { e.ObjectProg, e.ObjectType, e.CommentLine })
                    .HasName("ip_sys_comment");

                entity.ToTable("sys_comment");

                entity.Property(e => e.ObjectProg)
                    .HasColumnName("object_prog")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CommentLine)
                    .HasColumnName("comment_line")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CommentText)
                    .HasColumnName("comment_text")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CommentType)
                    .HasColumnName("comment_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysConnection>(entity =>
            {
                entity.HasKey(e => new { e.CorrConn, e.CodiUsex, e.CorrSess });

                entity.ToTable("sys_connection");

                entity.HasIndex(e => e.CorrSess)
                    .HasName("sys_connection_sess");

                entity.HasIndex(e => e.FeinConn)
                    .HasName("sys_connection_fein");

                entity.Property(e => e.CorrConn)
                    .HasColumnName("corr_conn")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiUsex)
                    .HasColumnName("codi_usex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CorrSess)
                    .HasColumnName("corr_sess")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FeinConn)
                    .HasColumnName("fein_conn")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CorrSessNavigation)
                    .WithMany(p => p.SysConnection)
                    .HasForeignKey(d => d.CorrSess)
                    .HasConstraintName("sys_connection_usua");
            });

            modelBuilder.Entity<SysDefp>(entity =>
            {
                entity.HasKey(e => e.CorrDefp)
                    .HasName("sys_defp_pk");

                entity.ToTable("sys_defp");

                entity.HasIndex(e => e.ObjectName)
                    .HasName("defp_fk_object");

                entity.HasIndex(e => new { e.CorrFupr, e.ObjectName })
                    .HasName("defp_uk")
                    .IsUnique();

                entity.Property(e => e.CorrDefp)
                    .HasColumnName("corr_defp")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CorrFupr)
                    .HasColumnName("corr_fupr")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstaDefp)
                    .HasColumnName("esta_defp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechDefp)
                    .HasColumnName("fech_defp")
                    .HasColumnType("datetime");

                entity.Property(e => e.IndiDefp)
                    .HasColumnName("indi_defp")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObjectNameNavigation)
                    .WithMany(p => p.SysDefp)
                    .HasForeignKey(d => d.ObjectName)
                    .HasConstraintName("sys_defp_fk_obje");
            });

            modelBuilder.Entity<SysDomaCult>(entity =>
            {
                entity.HasKey(e => new { e.DomainCode, e.CodiCult })
                    .HasName("sys_doma_cult_pk");

                entity.ToTable("sys_doma_cult");

                entity.Property(e => e.DomainCode)
                    .HasColumnName("domain_code")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CodiCult)
                    .HasColumnName("codi_cult")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .HasColumnName("domain_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.DomainCodeNavigation)
                    .WithMany(p => p.SysDomaCult)
                    .HasForeignKey(d => d.DomainCode)
                    .HasConstraintName("sys_doma_cult_obje");
            });

            modelBuilder.Entity<SysDomain>(entity =>
            {
                entity.HasKey(e => e.DomainCode)
                    .HasName("sys_domain_pk");

                entity.ToTable("sys_domain");

                entity.Property(e => e.DomainCode)
                    .HasColumnName("domain_code")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.DomainAux)
                    .HasColumnName("domain_aux")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomainAuxlabel)
                    .HasColumnName("domain_auxlabel")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DomainClass)
                    .HasColumnName("domain_class")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomainHight)
                    .HasColumnName("domain_hight")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DomainLength)
                    .HasColumnName("domain_length")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.DomainLow)
                    .HasColumnName("domain_low")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .HasColumnName("domain_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DomainQuery)
                    .HasColumnName("domain_query")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomainSclass)
                    .HasColumnName("domain_sclass")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomainShow)
                    .HasColumnName("domain_show")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomainType)
                    .HasColumnName("domain_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomainView)
                    .HasColumnName("domain_view")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mantenedor)
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<SysFupr>(entity =>
            {
                entity.HasKey(e => e.CorrFupr)
                    .HasName("sys_fupr_pk");

                entity.ToTable("sys_fupr");

                entity.HasIndex(e => new { e.ObjectRela, e.CorrFupr, e.CodiUsua, e.EstaFupr })
                    .HasName("fupr_ak");

                entity.HasIndex(e => new { e.CodiPeri, e.ObjectRela, e.CodiRous, e.CodiUsua, e.Val1, e.Val2, e.Val3, e.Val4, e.Val5 })
                    .HasName("fupr_uk")
                    .IsUnique();

                entity.Property(e => e.CorrFupr)
                    .HasColumnName("corr_fupr")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiPeri)
                    .HasColumnName("codi_peri")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescFupr)
                    .HasColumnName("desc_fupr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstaFupr)
                    .HasColumnName("esta_fupr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechFupr)
                    .HasColumnName("fech_fupr")
                    .HasColumnType("datetime");

                entity.Property(e => e.FreqFupr)
                    .HasColumnName("freq_fupr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndiFupr)
                    .HasColumnName("indi_fupr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectRela)
                    .HasColumnName("object_rela")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObjectNameNavigation)
                    .WithMany(p => p.SysFuprObjectNameNavigation)
                    .HasForeignKey(d => d.ObjectName)
                    .HasConstraintName("sys_fupr_fk_obje");

                entity.HasOne(d => d.ObjectRelaNavigation)
                    .WithMany(p => p.SysFuprObjectRelaNavigation)
                    .HasForeignKey(d => d.ObjectRela)
                    .HasConstraintName("sys_fupr_fk_obre");
            });

            modelBuilder.Entity<SysFuro>(entity =>
            {
                entity.HasKey(e => new { e.CodiRous, e.ObjectName })
                    .HasName("sys_furo_pk");

                entity.ToTable("sys_furo");

                entity.HasIndex(e => e.ObjectBrief)
                    .HasName("furo_brief");

                entity.HasIndex(e => e.ObjectCode)
                    .HasName("furo_code");

                entity.HasIndex(e => e.ObjectDesc)
                    .HasName("ip_furo_desc");

                entity.HasIndex(e => e.ObjectRela)
                    .HasName("furo_rela");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("furo_type");

                entity.HasIndex(e => e.TableName)
                    .HasName("furo_table");

                entity.HasIndex(e => new { e.CodiModu, e.ObjectOrun })
                    .HasName("furo_fk_modu");

                entity.HasIndex(e => new { e.CodiRous, e.CodiModu })
                    .HasName("furo_fk_romo");

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AlterKey)
                    .HasColumnName("alter_key")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Appname)
                    .HasColumnName("appname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FormType)
                    .HasColumnName("form_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Key1)
                    .HasColumnName("key1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Key2)
                    .HasColumnName("key2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectBrief)
                    .HasColumnName("object_brief")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectCode)
                    .HasColumnName("object_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectDate)
                    .HasColumnName("object_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjectDesc)
                    .HasColumnName("object_desc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectEmpr)
                    .HasColumnName("object_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectFreq)
                    .HasColumnName("object_freq")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectLevel)
                    .HasColumnName("object_level")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.ObjectOrder)
                    .HasColumnName("object_order")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectOrun)
                    .HasColumnName("object_orun")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectPname)
                    .HasColumnName("object_pname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectPriv)
                    .HasColumnName("object_priv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectProg)
                    .HasColumnName("object_prog")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectRela)
                    .HasColumnName("object_rela")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSex)
                    .HasColumnName("object_sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectShell)
                    .HasColumnName("object_shell")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSingle)
                    .HasColumnName("object_single")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectState)
                    .HasColumnName("object_state")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderKey)
                    .HasColumnName("order_key")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Par0)
                    .HasColumnName("par0")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par1)
                    .HasColumnName("par1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par2)
                    .HasColumnName("par2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par3)
                    .HasColumnName("par3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par4)
                    .HasColumnName("par4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par5)
                    .HasColumnName("par5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par6)
                    .HasColumnName("par6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par7)
                    .HasColumnName("par7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par8)
                    .HasColumnName("par8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par9)
                    .HasColumnName("par9")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QueryClause)
                    .HasColumnName("query_clause")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasColumnName("report_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReportType)
                    .HasColumnName("report_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol0)
                    .HasColumnName("rol0")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol1)
                    .HasColumnName("rol1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol2)
                    .HasColumnName("rol2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol3)
                    .HasColumnName("rol3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol4)
                    .HasColumnName("rol4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol5)
                    .HasColumnName("rol5")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol6)
                    .HasColumnName("rol6")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol7)
                    .HasColumnName("rol7")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol8)
                    .HasColumnName("rol8")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol9)
                    .HasColumnName("rol9")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TableType)
                    .HasColumnName("table_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Val0)
                    .HasColumnName("val0")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val7)
                    .HasColumnName("val7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val8)
                    .HasColumnName("val8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val9)
                    .HasColumnName("val9")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysInst>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.ObjectNumber })
                    .HasName("sys_inst_pk");

                entity.ToTable("sys_inst");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectNumber)
                    .HasColumnName("object_number")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ObjectOrder)
                    .HasColumnName("object_order")
                    .HasColumnType("numeric(4, 0)");

                entity.HasOne(d => d.ObjectNameNavigation)
                    .WithMany(p => p.SysInst)
                    .HasForeignKey(d => d.ObjectName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_inst_fk_obje");
            });

            modelBuilder.Entity<SysKey>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.NumberKey })
                    .HasName("sys_key_pk");

                entity.ToTable("sys_key");

                entity.HasIndex(e => e.GenKey)
                    .HasName("id_sys_key7");

                entity.HasIndex(e => new { e.TableName, e.TypeKey })
                    .HasName("ia_sys_key");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumberKey)
                    .HasColumnName("number_key")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.GenKey)
                    .HasColumnName("gen_key")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KeyDepe)
                    .HasColumnName("key_depe")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KeyDesc)
                    .HasColumnName("key_desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TypeKey)
                    .HasColumnName("type_key")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueKey)
                    .HasColumnName("unique_key")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysKeyAttr>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.NumberKey, e.AttrName })
                    .HasName("sys_key_attr_pk");

                entity.ToTable("sys_key_attr");

                entity.HasIndex(e => e.AttrOrder)
                    .HasName("ia_sys_key_attr");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumberKey)
                    .HasColumnName("number_key")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.AttrName)
                    .HasColumnName("attr_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AttrOrder)
                    .HasColumnName("attr_order")
                    .HasColumnType("numeric(2, 0)");

                entity.HasOne(d => d.SysKey)
                    .WithMany(p => p.SysKeyAttr)
                    .HasForeignKey(d => new { d.TableName, d.NumberKey })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_key_attr_fk_key");
            });

            modelBuilder.Entity<SysMessCult>(entity =>
            {
                entity.HasKey(e => new { e.CodiMess, e.CodiCult })
                    .HasName("sys_mess_cult_pk");

                entity.ToTable("sys_mess_cult");

                entity.HasIndex(e => e.CodiCult)
                    .HasName("sys_mess_cult_modu");

                entity.Property(e => e.CodiMess)
                    .HasColumnName("codi_mess")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiCult)
                    .HasColumnName("codi_cult")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescMess)
                    .HasColumnName("desc_mess")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMess)
                    .HasColumnName("tipo_mess")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiMessNavigation)
                    .WithMany(p => p.SysMessCult)
                    .HasForeignKey(d => d.CodiMess)
                    .HasConstraintName("sys_mess_cult_mess");
            });

            modelBuilder.Entity<SysMessage>(entity =>
            {
                entity.HasKey(e => e.CodiMess)
                    .HasName("sys_message_pk");

                entity.ToTable("sys_message");

                entity.HasIndex(e => e.CodiModu)
                    .HasName("sys_message_modu");

                entity.Property(e => e.CodiMess)
                    .HasColumnName("codi_mess")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescMess)
                    .HasColumnName("desc_mess")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMess)
                    .HasColumnName("tipo_mess")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysModuObje>(entity =>
            {
                entity.HasKey(e => new { e.CodiModu, e.ObjectName, e.ObjectType })
                    .HasName("sys_modu_obje_pk");

                entity.ToTable("sys_modu_obje");

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysObac>(entity =>
            {
                entity.HasKey(e => new { e.CodiActi, e.ObjectName })
                    .HasName("sys_obac_pk");

                entity.ToTable("sys_obac");

                entity.HasIndex(e => new { e.ObjectName, e.CodiActi })
                    .HasName("sys_obac_ak");

                entity.Property(e => e.CodiActi)
                    .HasColumnName("codi_acti")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstaObac)
                    .HasColumnName("esta_obac")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechObac)
                    .HasColumnName("fech_obac")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjectProg)
                    .HasColumnName("object_prog")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObseObac)
                    .HasColumnName("obse_obac")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OrdeObac)
                    .HasColumnName("orde_obac")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.TipoObac)
                    .HasColumnName("tipo_obac")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObjectNameNavigation)
                    .WithMany(p => p.SysObac)
                    .HasForeignKey(d => d.ObjectName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_obac_fk_obje");
            });

            modelBuilder.Entity<SysObjeCult>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.CodiCult })
                    .HasName("sys_obje_cult_pk");

                entity.ToTable("sys_obje_cult");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCult)
                    .HasColumnName("codi_cult")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectBrief)
                    .HasColumnName("object_brief")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectDesc)
                    .HasColumnName("object_desc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSingle)
                    .HasColumnName("object_single")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ObjectNameNavigation)
                    .WithMany(p => p.SysObjeCult)
                    .HasForeignKey(d => d.ObjectName)
                    .HasConstraintName("sys_obje_cult_obje");
            });

            modelBuilder.Entity<SysObject>(entity =>
            {
                entity.HasKey(e => e.ObjectName)
                    .HasName("sys_obje_pk");

                entity.ToTable("sys_object");

                entity.HasIndex(e => e.ObjectBrief)
                    .HasName("ia_sys_object");

                entity.HasIndex(e => e.ObjectCode)
                    .HasName("ia_object_code");

                entity.HasIndex(e => e.ObjectDesc)
                    .HasName("obje_desc");

                entity.HasIndex(e => e.ObjectRela)
                    .HasName("obje_rela");

                entity.HasIndex(e => e.ObjectType)
                    .HasName("id_sys_object2");

                entity.HasIndex(e => e.TableName)
                    .HasName("if_sys_object");

                entity.HasIndex(e => new { e.CodiModu, e.ObjectOrun })
                    .HasName("obje_fk_modu");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AlterKey)
                    .HasColumnName("alter_key")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Appname)
                    .HasColumnName("appname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CodiActi)
                    .HasColumnName("codi_acti")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FormType)
                    .HasColumnName("form_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectBrief)
                    .HasColumnName("object_brief")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectCode)
                    .HasColumnName("object_code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectDate)
                    .HasColumnName("object_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ObjectDesc)
                    .HasColumnName("object_desc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectEmpr)
                    .HasColumnName("object_empr")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectFreq)
                    .HasColumnName("object_freq")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectLevel)
                    .HasColumnName("object_level")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.ObjectOrder)
                    .HasColumnName("object_order")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectOrun)
                    .HasColumnName("object_orun")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectPname)
                    .HasColumnName("object_pname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectPriv)
                    .HasColumnName("object_priv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectProg)
                    .HasColumnName("object_prog")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectRela)
                    .HasColumnName("object_rela")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSex)
                    .HasColumnName("object_sex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectShell)
                    .HasColumnName("object_shell")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectSingle)
                    .HasColumnName("object_single")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectState)
                    .HasColumnName("object_state")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderKey)
                    .HasColumnName("order_key")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Par0)
                    .HasColumnName("par0")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par1)
                    .HasColumnName("par1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par2)
                    .HasColumnName("par2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par3)
                    .HasColumnName("par3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par4)
                    .HasColumnName("par4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par5)
                    .HasColumnName("par5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par6)
                    .HasColumnName("par6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par7)
                    .HasColumnName("par7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par8)
                    .HasColumnName("par8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par9)
                    .HasColumnName("par9")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.QueryClause)
                    .HasColumnName("query_clause")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasColumnName("report_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReportType)
                    .HasColumnName("report_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol0)
                    .HasColumnName("rol0")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol1)
                    .HasColumnName("rol1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol2)
                    .HasColumnName("rol2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol3)
                    .HasColumnName("rol3")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol4)
                    .HasColumnName("rol4")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol5)
                    .HasColumnName("rol5")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol6)
                    .HasColumnName("rol6")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol7)
                    .HasColumnName("rol7")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol8)
                    .HasColumnName("rol8")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rol9)
                    .HasColumnName("rol9")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TableType)
                    .HasColumnName("table_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Val0)
                    .HasColumnName("val0")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val7)
                    .HasColumnName("val7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val8)
                    .HasColumnName("val8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val9)
                    .HasColumnName("val9")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysRelation>(entity =>
            {
                entity.HasKey(e => new { e.SourceObject, e.SourceType, e.TargetObject, e.TargetType, e.RelationType, e.NumberKey })
                    .HasName("sys_rela_pk");

                entity.ToTable("sys_relation");

                entity.HasIndex(e => e.RelationType)
                    .HasName("ir_relation");

                entity.HasIndex(e => e.SourceObject)
                    .HasName("is_sys_relation");

                entity.HasIndex(e => new { e.TargetType, e.TargetObject })
                    .HasName("rela_targ");

                entity.HasIndex(e => new { e.RelationType, e.TargetObject, e.TargetType })
                    .HasName("it_sys_relation");

                entity.HasIndex(e => new { e.TargetObject, e.RelationType, e.TargetType, e.NumberKey })
                    .HasName("ia_rel_1");

                entity.Property(e => e.SourceObject)
                    .HasColumnName("source_object")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceType)
                    .HasColumnName("source_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TargetObject)
                    .HasColumnName("target_object")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TargetType)
                    .HasColumnName("target_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelationType)
                    .HasColumnName("relation_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumberKey)
                    .HasColumnName("number_key")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Key0)
                    .HasColumnName("key0")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key1)
                    .HasColumnName("key1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key2)
                    .HasColumnName("key2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key3)
                    .HasColumnName("key3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key4)
                    .HasColumnName("key4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key5)
                    .HasColumnName("key5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key6)
                    .HasColumnName("key6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key7)
                    .HasColumnName("key7")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key8)
                    .HasColumnName("key8")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Key9)
                    .HasColumnName("key9")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCard)
                    .HasColumnName("source_card")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SourceDele)
                    .HasColumnName("source_dele")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SourceDesc)
                    .HasColumnName("source_desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceMand)
                    .HasColumnName("source_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TargetCard)
                    .HasColumnName("target_card")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TargetDesc)
                    .HasColumnName("target_desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TargetMand)
                    .HasColumnName("target_mand")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysSession>(entity =>
            {
                entity.HasKey(e => e.CorrSess)
                    .HasName("sys_session_pk");

                entity.ToTable("sys_session");

                entity.HasIndex(e => e.CodiUsua)
                    .HasName("sys_session_usua");

                entity.HasIndex(e => e.FeinSess)
                    .HasName("sys_session_fein");

                entity.Property(e => e.CorrSess)
                    .HasColumnName("corr_sess")
                    .HasColumnType("numeric(22, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCult)
                    .HasColumnName("codi_cult")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiDbst)
                    .HasColumnName("codi_dbst")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiMenu)
                    .HasColumnName("codi_menu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FeinSess)
                    .HasColumnName("fein_sess")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeteSess)
                    .HasColumnName("fete_sess")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SysUserObjects>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.ObjectType })
                    .HasName("sys_users_objects_pk");

                entity.ToTable("sys_user_objects");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysUsfa>(entity =>
            {
                entity.HasKey(e => new { e.CodiUsua, e.ObjectName })
                    .HasName("sys_usfa_pk");

                entity.ToTable("sys_usfa");

                entity.HasIndex(e => new { e.CodiUsua, e.ObjectOrun })
                    .HasName("usfa_fk_orun");

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasColumnName("object_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ComeUsfa)
                    .HasColumnName("come_usfa")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectBrief)
                    .HasColumnName("object_brief")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectFreq)
                    .HasColumnName("object_freq")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectLevel)
                    .HasColumnName("object_level")
                    .HasColumnType("numeric(22, 0)");

                entity.Property(e => e.ObjectOrder)
                    .HasColumnName("object_order")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectOrun)
                    .HasColumnName("object_orun")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectRela)
                    .HasColumnName("object_rela")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("object_type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrdeUsfa)
                    .HasColumnName("orde_usfa")
                    .HasColumnType("numeric(4, 0)");

                entity.HasOne(d => d.CodiUsuaNavigation)
                    .WithMany(p => p.SysUsfa)
                    .HasForeignKey(d => d.CodiUsua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_usfa_fk_usua");
            });

            modelBuilder.Entity<SysUsro>(entity =>
            {
                entity.HasKey(e => new { e.CodiUsua, e.CodiModu })
                    .HasName("sys_usro_pk");

                entity.ToTable("sys_usro");

                entity.HasIndex(e => e.CodiModu)
                    .HasName("usro_fk_modu");

                entity.HasIndex(e => new { e.CodiRous, e.CodiModu })
                    .HasName("ia_usro_1");

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiModu)
                    .HasColumnName("codi_modu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiUsuaNavigation)
                    .WithMany(p => p.SysUsro)
                    .HasForeignKey(d => d.CodiUsua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sys_usro_fk_usua");
            });

            modelBuilder.Entity<UsemExte>(entity =>
            {
                entity.HasKey(e => new { e.CodiUsex, e.CodiEmex })
                    .HasName("ueex_pk_ueex_1");

                entity.ToTable("usem_exte");

                entity.Property(e => e.CodiUsex)
                    .HasColumnName("codi_usex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FeinUeex)
                    .HasColumnName("fein_ueex")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeteUeex)
                    .HasColumnName("fete_ueex")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatUeex)
                    .HasColumnName("stat_ueex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmexNavigation)
                    .WithMany(p => p.UsemExte)
                    .HasForeignKey(d => d.CodiEmex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ueex_fk_emex_1");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.UsemExte)
                    .HasForeignKey(d => d.CodiPers)
                    .HasConstraintName("ueex_fk_pers");

                entity.HasOne(d => d.CodiUsexNavigation)
                    .WithMany(p => p.UsemExte)
                    .HasForeignKey(d => d.CodiUsex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ueex_fk_usex_1");
            });

            modelBuilder.Entity<UsuaEmpr>(entity =>
            {
                entity.HasKey(e => new { e.CodiEmpr, e.CodiUsua })
                    .HasName("emus_pk");

                entity.ToTable("usua_empr");

                entity.HasIndex(e => e.CodiEmpr)
                    .HasName("if_usem_1");

                entity.HasIndex(e => e.CodiUsua)
                    .HasName("if_usem_2");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOfic)
                    .HasColumnName("codi_ofic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.UsuaEmpr)
                    .HasForeignKey(d => d.CodiEmpr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usem_fk_empr");

                entity.HasOne(d => d.CodiUsuaNavigation)
                    .WithMany(p => p.UsuaEmpr)
                    .HasForeignKey(d => d.CodiUsua)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usem_fk_usua");
            });

            modelBuilder.Entity<UsuaExte>(entity =>
            {
                entity.HasKey(e => e.CodiUsex)
                    .HasName("usex_pk");

                entity.ToTable("usua_exte");

                entity.HasIndex(e => e.NombUsex)
                    .HasName("usex_uk")
                    .IsUnique();

                entity.Property(e => e.CodiUsex)
                    .HasColumnName("codi_usex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FeinUsex)
                    .HasColumnName("fein_usex")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeteUsex)
                    .HasColumnName("fete_usex")
                    .HasColumnType("datetime");

                entity.Property(e => e.FonoUsex)
                    .HasColumnName("fono_usex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LugaUsex)
                    .HasColumnName("luga_usex")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.MailUsex)
                    .HasColumnName("mail_usex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NocoUsex)
                    .HasColumnName("noco_usex")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombTabl)
                    .HasColumnName("nomb_tabl")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NombUsex)
                    .HasColumnName("nomb_usex")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Par1)
                    .HasColumnName("par1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par2)
                    .HasColumnName("par2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par3)
                    .HasColumnName("par3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par4)
                    .HasColumnName("par4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par5)
                    .HasColumnName("par5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Par6)
                    .HasColumnName("par6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PassUsar)
                    .HasColumnName("pass_usar")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PassUsex)
                    .HasColumnName("pass_usex")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StatUsex)
                    .HasColumnName("stat_usex")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Val1)
                    .HasColumnName("val1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val2)
                    .HasColumnName("val2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val3)
                    .HasColumnName("val3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val4)
                    .HasColumnName("val4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val5)
                    .HasColumnName("val5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Val6)
                    .HasColumnName("val6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiEmexNavigation)
                    .WithMany(p => p.UsuaExte)
                    .HasForeignKey(d => d.CodiEmex)
                    .HasConstraintName("usex_fk_emex");

                entity.HasOne(d => d.CodiEmprNavigation)
                    .WithMany(p => p.UsuaExte)
                    .HasForeignKey(d => d.CodiEmpr)
                    .HasConstraintName("usex_fk_empr");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithMany(p => p.UsuaExte)
                    .HasForeignKey(d => d.CodiPers)
                    .HasConstraintName("usex_fk_pers");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.UsuaExte)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .HasConstraintName("usex_fk_ceco");
            });

            modelBuilder.Entity<UsuaSist>(entity =>
            {
                entity.HasKey(e => e.CodiUsua)
                    .HasName("usua_pk");

                entity.ToTable("usua_sist");

                entity.HasIndex(e => e.CodiImpr)
                    .HasName("if_usua_1");

                entity.HasIndex(e => e.CodiPers)
                    .HasName("ia_usu_pers")
                    .IsUnique();

                entity.HasIndex(e => e.CodiRous)
                    .HasName("if_usua_3");

                entity.HasIndex(e => e.NombUsua)
                    .HasName("ia_usua_2");

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodiCeco)
                    .HasColumnName("codi_ceco")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiCult)
                    .HasColumnName("codi_cult")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiDbst)
                    .HasColumnName("codi_dbst")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiEmex)
                    .HasColumnName("codi_emex")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PROD_0000')");

                entity.Property(e => e.CodiEmpr)
                    .HasColumnName("codi_empr")
                    .HasColumnType("numeric(9, 0)");

                entity.Property(e => e.CodiImpr)
                    .HasColumnName("codi_impr")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodiMenu)
                    .HasColumnName("codi_menu")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiOfic)
                    .HasColumnName("codi_ofic")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodiPers)
                    .HasColumnName("codi_pers")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRamo)
                    .HasColumnName("codi_ramo")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CodiRous)
                    .HasColumnName("codi_rous")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodiZona)
                    .HasColumnName("codi_zona")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.DigiUsua)
                    .HasColumnName("digi_usua")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FechUsua)
                    .HasColumnName("fech_usua")
                    .HasColumnType("datetime");

                entity.Property(e => e.FeteUsua)
                    .HasColumnName("fete_usua")
                    .HasColumnType("datetime");

                entity.Property(e => e.FonoUsua)
                    .HasColumnName("fono_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LugaUsua)
                    .HasColumnName("luga_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MailUsua)
                    .HasColumnName("mail_usua")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NiveUsua)
                    .HasColumnName("nive_usua")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NocoUsua)
                    .HasColumnName("noco_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombUsua)
                    .HasColumnName("nomb_usua")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PassUsua)
                    .HasColumnName("pass_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFold)
                    .HasColumnName("tipo_fold")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUsua)
                    .HasColumnName("tipo_usua")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsuaFilt)
                    .HasColumnName("usua_filt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.HasOne(d => d.CodiPersNavigation)
                    .WithOne(p => p.UsuaSist)
                    .HasForeignKey<UsuaSist>(d => d.CodiPers)
                    .HasConstraintName("usua_fk_pers");

                entity.HasOne(d => d.Codi)
                    .WithMany(p => p.UsuaSist)
                    .HasForeignKey(d => new { d.CodiEmpr, d.CodiCeco })
                    .HasConstraintName("usua_fk_ceco");
            });

            modelBuilder.Entity<ValoCage>(entity =>
            {
                entity.HasKey(e => new { e.CodiCage, e.CodiVacg })
                    .HasName("vacg_pk");

                entity.ToTable("valo_cage");

                entity.Property(e => e.CodiCage)
                    .HasColumnName("codi_cage")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiVacg)
                    .HasColumnName("codi_vacg")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescVacg)
                    .HasColumnName("desc_vacg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodiCageNavigation)
                    .WithMany(p => p.ValoCage)
                    .HasForeignKey(d => d.CodiCage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacg_fk_cage_1");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasKey(e => new { e.Componente, e.Version1 });

                entity.ToTable("version");

                entity.Property(e => e.Componente)
                    .HasColumnName("componente")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Version1)
                    .HasColumnName("version")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEjecucion)
                    .HasColumnName("fecha_ejecucion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObservacionEjecucion)
                    .HasColumnName("observacion_ejecucion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableEjecucion)
                    .HasColumnName("responsable_ejecucion")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebEstaProc>(entity =>
            {
                entity.HasKey(e => e.CorrProc);

                entity.ToTable("web_esta_proc");

                entity.Property(e => e.CorrProc)
                    .HasColumnName("corr_proc")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.BorrMens)
                    .HasColumnName("borr_mens")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodiUsua)
                    .HasColumnName("codi_usua")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescProc)
                    .HasColumnName("desc_proc")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FechInic)
                    .HasColumnName("fech_inic")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechTerm)
                    .HasColumnName("fech_term")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombProc)
                    .IsRequired()
                    .HasColumnName("nomb_proc")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NumeProc)
                    .HasColumnName("nume_proc")
                    .HasColumnType("numeric(10, 0)");
            });
        }
    }
}
