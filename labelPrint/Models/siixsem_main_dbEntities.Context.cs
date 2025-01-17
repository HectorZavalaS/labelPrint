﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labelPrint.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class siixsem_main_dbEntities : DbContext
    {
        public siixsem_main_dbEntities()
            : base("name=siixsem_main_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<siixsem_families_t> siixsem_families_t { get; set; }
        public virtual DbSet<siixsem_flxb_t> siixsem_flxb_t { get; set; }
        public virtual DbSet<siixsem_flxsModel_td> siixsem_flxsModel_td { get; set; }
        public virtual DbSet<siixsem_models_t> siixsem_models_t { get; set; }
        public virtual DbSet<siixsem_sides_t> siixsem_sides_t { get; set; }
        public virtual DbSet<siixsem_sidesModel_td> siixsem_sidesModel_td { get; set; }
        public virtual DbSet<siixsem_user_role_t> siixsem_user_role_t { get; set; }
        public virtual DbSet<siixsem_users_t> siixsem_users_t { get; set; }
        public virtual DbSet<siixsem_voltageb_t> siixsem_voltageb_t { get; set; }
        public virtual DbSet<siixsem_VoltsModel_td> siixsem_VoltsModel_td { get; set; }
        public virtual DbSet<siixsem_colorsb_td> siixsem_colorsb_td { get; set; }
        public virtual DbSet<siixsem_lblTagColor_t> siixsem_lblTagColor_t { get; set; }
        public virtual DbSet<siixsem_colorb_t> siixsem_colorb_t { get; set; }
        public virtual DbSet<siixsem_ldmModels_td> siixsem_ldmModels_td { get; set; }
        public virtual DbSet<siixsem_printers_t> siixsem_printers_t { get; set; }
        public virtual DbSet<siixsem_modFourLbls_td> siixsem_modFourLbls_td { get; set; }
        public virtual DbSet<siixsem_colorsb_led2_td> siixsem_colorsb_led2_td { get; set; }
        public virtual DbSet<siixsem_flxsModel_led2_td> siixsem_flxsModel_led2_td { get; set; }
        public virtual DbSet<siixsem_VoltsModel_led2_td> siixsem_VoltsModel_led2_td { get; set; }
    
        public virtual ObjectResult<Nullable<int>> existModel(string model)
        {
            var modelParameter = model != null ?
                new ObjectParameter("model", model) :
                new ObjectParameter("model", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("existModel", modelParameter);
        }
    
        public virtual ObjectResult<getAllModels_Result> getAllModels()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllModels_Result>("getAllModels");
        }
    
        public virtual ObjectResult<getFluxesByIdModel_Result> getFluxesByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getFluxesByIdModel_Result>("getFluxesByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<getNumSidesByIdModel_Result> getNumSidesByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getNumSidesByIdModel_Result>("getNumSidesByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<getSidesByIdModel_Result> getSidesByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSidesByIdModel_Result>("getSidesByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<getVoltsByIdModel_Result> getVoltsByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getVoltsByIdModel_Result>("getVoltsByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<validate_user_Result> validate_user(string user, string pass)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<validate_user_Result>("validate_user", userParameter, passParameter);
        }
    
        public virtual ObjectResult<updatePartNumber_Result> updatePartNumber(Nullable<int> idModel, Nullable<int> idSide, string partNum)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idSideParameter = idSide.HasValue ?
                new ObjectParameter("idSide", idSide) :
                new ObjectParameter("idSide", typeof(int));
    
            var partNumParameter = partNum != null ?
                new ObjectParameter("partNum", partNum) :
                new ObjectParameter("partNum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<updatePartNumber_Result>("updatePartNumber", idModelParameter, idSideParameter, partNumParameter);
        }
    
        public virtual ObjectResult<getColorsByIdModel_Result> getColorsByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getColorsByIdModel_Result>("getColorsByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<isSerialContinuos_Result> isSerialContinuos(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<isSerialContinuos_Result>("isSerialContinuos", idModelParameter);
        }
    
        public virtual ObjectResult<getFluxLabelByID_Result> getFluxLabelByID(Nullable<int> idFlx)
        {
            var idFlxParameter = idFlx.HasValue ?
                new ObjectParameter("idFlx", idFlx) :
                new ObjectParameter("idFlx", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getFluxLabelByID_Result>("getFluxLabelByID", idFlxParameter);
        }
    
        public virtual ObjectResult<getFluxDescByID_Result> getFluxDescByID(Nullable<int> idFlx)
        {
            var idFlxParameter = idFlx.HasValue ?
                new ObjectParameter("idFlx", idFlx) :
                new ObjectParameter("idFlx", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getFluxDescByID_Result>("getFluxDescByID", idFlxParameter);
        }
    
        public virtual ObjectResult<getColorDescById_Result> getColorDescById(Nullable<int> idColor)
        {
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getColorDescById_Result>("getColorDescById", idColorParameter);
        }
    
        public virtual ObjectResult<getVoltDescById_Result> getVoltDescById(Nullable<int> idVolt)
        {
            var idVoltParameter = idVolt.HasValue ?
                new ObjectParameter("idVolt", idVolt) :
                new ObjectParameter("idVolt", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getVoltDescById_Result>("getVoltDescById", idVoltParameter);
        }
    
        public virtual ObjectResult<getPrinters_Result> getPrinters()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPrinters_Result>("getPrinters");
        }
    
        public virtual ObjectResult<hasLDM_Result> hasLDM(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hasLDM_Result>("hasLDM", idModelParameter);
        }
    
        public virtual ObjectResult<getPrintrById_Result> getPrintrById(Nullable<int> idP)
        {
            var idPParameter = idP.HasValue ?
                new ObjectParameter("idP", idP) :
                new ObjectParameter("idP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPrintrById_Result>("getPrintrById", idPParameter);
        }
    
        public virtual ObjectResult<isPrinting_Result> isPrinting(Nullable<int> idPrinter)
        {
            var idPrinterParameter = idPrinter.HasValue ?
                new ObjectParameter("idPrinter", idPrinter) :
                new ObjectParameter("idPrinter", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<isPrinting_Result>("isPrinting", idPrinterParameter);
        }
    
        public virtual int setIsPrinting(Nullable<int> value, Nullable<int> idPrinter)
        {
            var valueParameter = value.HasValue ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(int));
    
            var idPrinterParameter = idPrinter.HasValue ?
                new ObjectParameter("idPrinter", idPrinter) :
                new ObjectParameter("idPrinter", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("setIsPrinting", valueParameter, idPrinterParameter);
        }
    
        public virtual ObjectResult<getLDMSpec_Result> getLDMSpec(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLDMSpec_Result>("getLDMSpec", idModelParameter);
        }
    
        public virtual ObjectResult<hasFourLbls_Result> hasFourLbls(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hasFourLbls_Result>("hasFourLbls", idModelParameter);
        }
    
        public virtual ObjectResult<getModelSpecF_Result> getModelSpecF(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelSpecF_Result>("getModelSpecF", idModelParameter);
        }
    
        public virtual ObjectResult<getModelColor_Result> getModelColor(Nullable<int> idModel, Nullable<int> idColor)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelColor_Result>("getModelColor", idModelParameter, idColorParameter);
        }
    
        public virtual ObjectResult<getModelColorB_Result> getModelColorB(Nullable<int> idModel, Nullable<int> idColor)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelColorB_Result>("getModelColorB", idModelParameter, idColorParameter);
        }
    
        public virtual ObjectResult<getColorsLed2ByIdModel_Result> getColorsLed2ByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getColorsLed2ByIdModel_Result>("getColorsLed2ByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<getFluxesLed2ByIdModel_Result> getFluxesLed2ByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getFluxesLed2ByIdModel_Result>("getFluxesLed2ByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<getVoltsLed2ByIdModel_Result> getVoltsLed2ByIdModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getVoltsLed2ByIdModel_Result>("getVoltsLed2ByIdModel", idModelParameter);
        }
    
        public virtual ObjectResult<hasCoverFrame_Result> hasCoverFrame(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hasCoverFrame_Result>("hasCoverFrame", idModelParameter);
        }
    
        public virtual ObjectResult<hasFourSides_Result> hasFourSides(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hasFourSides_Result>("hasFourSides", idModelParameter);
        }
    
        public virtual ObjectResult<isDFCIFC_Result> isDFCIFC(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<isDFCIFC_Result>("isDFCIFC", idModelParameter);
        }
    
        public virtual ObjectResult<getModelPanel_Result> getModelPanel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("IdModel", idModel) :
                new ObjectParameter("IdModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelPanel_Result>("getModelPanel", idModelParameter);
        }
    
        public virtual ObjectResult<getPrinterById_Result> getPrinterById(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getPrinterById_Result>("getPrinterById", iDParameter);
        }
    
        public virtual ObjectResult<getModelPanelSpec_Result> getModelPanelSpec(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelPanelSpec_Result>("getModelPanelSpec", idModelParameter);
        }
    
        public virtual ObjectResult<hasPanel_Result> hasPanel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<hasPanel_Result>("hasPanel", idModelParameter);
        }
    
        public virtual ObjectResult<getModelColorP_Result> getModelColorP(Nullable<int> idModel, Nullable<int> idColor)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("idColor", idColor) :
                new ObjectParameter("idColor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelColorP_Result>("getModelColorP", idModelParameter, idColorParameter);
        }
    
        public virtual ObjectResult<getModelByID_Result> getModelByID(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getModelByID_Result>("getModelByID", idModelParameter);
        }
    
        public virtual ObjectResult<insertModel_Result> insertModel(string descr, Nullable<int> idProject, Nullable<int> isSpecial, Nullable<int> isValid, Nullable<int> isSC, Nullable<int> has2L, Nullable<int> isDFC, Nullable<int> isML, Nullable<int> hasPanel, Nullable<int> isLDM, Nullable<int> numPCB)
        {
            var descrParameter = descr != null ?
                new ObjectParameter("descr", descr) :
                new ObjectParameter("descr", typeof(string));
    
            var idProjectParameter = idProject.HasValue ?
                new ObjectParameter("idProject", idProject) :
                new ObjectParameter("idProject", typeof(int));
    
            var isSpecialParameter = isSpecial.HasValue ?
                new ObjectParameter("isSpecial", isSpecial) :
                new ObjectParameter("isSpecial", typeof(int));
    
            var isValidParameter = isValid.HasValue ?
                new ObjectParameter("isValid", isValid) :
                new ObjectParameter("isValid", typeof(int));
    
            var isSCParameter = isSC.HasValue ?
                new ObjectParameter("isSC", isSC) :
                new ObjectParameter("isSC", typeof(int));
    
            var has2LParameter = has2L.HasValue ?
                new ObjectParameter("has2L", has2L) :
                new ObjectParameter("has2L", typeof(int));
    
            var isDFCParameter = isDFC.HasValue ?
                new ObjectParameter("isDFC", isDFC) :
                new ObjectParameter("isDFC", typeof(int));
    
            var isMLParameter = isML.HasValue ?
                new ObjectParameter("isML", isML) :
                new ObjectParameter("isML", typeof(int));
    
            var hasPanelParameter = hasPanel.HasValue ?
                new ObjectParameter("hasPanel", hasPanel) :
                new ObjectParameter("hasPanel", typeof(int));
    
            var isLDMParameter = isLDM.HasValue ?
                new ObjectParameter("isLDM", isLDM) :
                new ObjectParameter("isLDM", typeof(int));
    
            var numPCBParameter = numPCB.HasValue ?
                new ObjectParameter("numPCB", numPCB) :
                new ObjectParameter("numPCB", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insertModel_Result>("insertModel", descrParameter, idProjectParameter, isSpecialParameter, isValidParameter, isSCParameter, has2LParameter, isDFCParameter, isMLParameter, hasPanelParameter, isLDMParameter, numPCBParameter);
        }
    
        public virtual ObjectResult<insertSideModel_Result> insertSideModel(Nullable<int> idModel, Nullable<int> idSide, string search, string lblTag, string oracle)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idSideParameter = idSide.HasValue ?
                new ObjectParameter("idSide", idSide) :
                new ObjectParameter("idSide", typeof(int));
    
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            var lblTagParameter = lblTag != null ?
                new ObjectParameter("lblTag", lblTag) :
                new ObjectParameter("lblTag", typeof(string));
    
            var oracleParameter = oracle != null ?
                new ObjectParameter("oracle", oracle) :
                new ObjectParameter("oracle", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insertSideModel_Result>("insertSideModel", idModelParameter, idSideParameter, searchParameter, lblTagParameter, oracleParameter);
        }
    
        public virtual ObjectResult<insertFluxModel_Result> insertFluxModel(Nullable<int> idModel, Nullable<int> idFlux)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            var idFluxParameter = idFlux.HasValue ?
                new ObjectParameter("idFlux", idFlux) :
                new ObjectParameter("idFlux", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<insertFluxModel_Result>("insertFluxModel", idModelParameter, idFluxParameter);
        }
    
        public virtual ObjectResult<getStep_Result> getStep(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getStep_Result>("getStep", idModelParameter);
        }
    
        public virtual ObjectResult<isWabcoModel_Result> isWabcoModel(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<isWabcoModel_Result>("isWabcoModel", idModelParameter);
        }
    
        public virtual ObjectResult<getLaserMarks_Result> getLaserMarks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLaserMarks_Result>("getLaserMarks");
        }
    
        public virtual ObjectResult<getNameCogiscan_Result> getNameCogiscan(Nullable<int> idModel)
        {
            var idModelParameter = idModel.HasValue ?
                new ObjectParameter("idModel", idModel) :
                new ObjectParameter("idModel", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getNameCogiscan_Result>("getNameCogiscan", idModelParameter);
        }
    }
}
