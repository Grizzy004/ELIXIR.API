﻿// <auto-generated />
using System;
using ELIXIR.DATA.DATA_ACCESS_LAYER.STORE_CONTEXT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ELIXIR.DATA.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220321022633_AddNewColumnInTransformationPlanning")]
    partial class AddNewColumnInTransformationPlanning
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.IMPORT_MODEL.ImportPOSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Billed")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Date_Cancellation")
                        .HasColumnType("Date");

                    b.Property<decimal>("Delivered")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ordered")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PO_Date")
                        .HasColumnType("Date");

                    b.Property<int>("PO_Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("PR_Date")
                        .HasColumnType("Date");

                    b.Property<int>("PR_Number")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UOM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("POSummary");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MainMenuId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubMenuName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainMenuId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.QC_MODEL.PO_Receiving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Actual_Delivered")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Batch_No")
                        .HasColumnType("int");

                    b.Property<string>("CancelBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CancelDate")
                        .HasColumnType("Date");

                    b.Property<bool>("Checking_Approval1")
                        .HasColumnType("bit");

                    b.Property<string>("Checking_Approval1_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Checking_Approval2")
                        .HasColumnType("bit");

                    b.Property<string>("Checking_Approval2_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ConfirmRejectByQc")
                        .HasColumnType("bit");

                    b.Property<decimal>("Expected_Delivery")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ExpiryApproveBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpiryDateOfApprove")
                        .HasColumnType("Date");

                    b.Property<bool?>("ExpiryIsApprove")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Expiry_Date")
                        .HasColumnType("Date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNearlyExpire")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsWareHouseReceive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Manufacturing_Date")
                        .HasColumnType("Date");

                    b.Property<int>("PO_Summary_Id")
                        .HasColumnType("int");

                    b.Property<bool>("QA_Approval")
                        .HasColumnType("bit");

                    b.Property<string>("QA_Approval_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("QC_ReceiveDate")
                        .HasColumnType("Date");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalReject")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Truck_Approval1")
                        .HasColumnType("bit");

                    b.Property<string>("Truck_Approval1_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Truck_Approval2")
                        .HasColumnType("bit");

                    b.Property<string>("Truck_Approval2_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Truck_Approval3")
                        .HasColumnType("bit");

                    b.Property<string>("Truck_Approval3_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Truck_Approval4")
                        .HasColumnType("bit");

                    b.Property<string>("Truck_Approval4_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Unloading_Approval1")
                        .HasColumnType("bit");

                    b.Property<string>("Unloading_Approval1_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Unloading_Approval2")
                        .HasColumnType("bit");

                    b.Property<string>("Unloading_Approval2_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Unloading_Approval3")
                        .HasColumnType("bit");

                    b.Property<string>("Unloading_Approval3_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Unloading_Approval4")
                        .HasColumnType("bit");

                    b.Property<string>("Unloading_Approval4_Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QC_Receiving");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.QC_MODEL.PO_Reject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PO_ReceivingId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QC_Reject");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("FarmTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LeadMan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FarmTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.FarmType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("FarmName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.ItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ItemCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemCategories");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.LotCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LotCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LotCategories");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.LotName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LotCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LotCategoryId");

                    b.ToTable("LotNames");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.RawMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BufferLevel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ItemCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemCategoryId");

                    b.HasIndex("UomId");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.Reason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("ReasonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reasons");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.TransformationFormula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Formulas");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.TransformationRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RawMaterialId")
                        .HasColumnType("int");

                    b.Property<int>("TransformationFormulaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RawMaterialId");

                    b.HasIndex("TransformationFormulaId");

                    b.ToTable("FormulaRequirements");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.UOM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UOM_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UOM_Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UOMS");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.TRANSFORMATION_MODEL.TransformationPlanning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Batch")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DateApproved")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Is_Approved")
                        .HasColumnType("bit");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProdPlan")
                        .HasColumnType("Date");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RejectedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RejectedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Uom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transformation_Planning");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.TRANSFORMATION_MODEL.TransformationRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Batch")
                        .HasColumnType("int");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProdPlan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TransformId")
                        .HasColumnType("int");

                    b.Property<string>("Uom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transformation_Request");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.USER_MODEL.MainMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MenuPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainMenus");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.UserRole_Modules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RoleModules");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.WAREHOUSE_MODEL.WarehouseReceiving", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("ActualDelivered")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ActualGood")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("ConfirmRejectbyQc")
                        .HasColumnType("bit");

                    b.Property<bool>("ConfirmRejectbyWarehouse")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("Date");

                    b.Property<int>("ExpirationDays")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWarehouseReceive")
                        .HasColumnType("bit");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("Date");

                    b.Property<int>("PO_Number")
                        .HasColumnType("int");

                    b.Property<int>("QcReceivingId")
                        .HasColumnType("int");

                    b.Property<decimal>("QuantityGood")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceivedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReceivingDate")
                        .HasColumnType("Date");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalReject")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Uom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WarehouseReceived");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.WAREHOUSE_MODEL.Warehouse_Reject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RejectByDate")
                        .HasColumnType("Date");

                    b.Property<string>("RejectedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WarehouseReceivingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Warehouse_Reject");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.Module", b =>
                {
                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.USER_MODEL.MainMenu", "MainMenu")
                        .WithMany()
                        .HasForeignKey("MainMenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainMenu");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.Customer", b =>
                {
                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.FarmType", "FarmType")
                        .WithMany()
                        .HasForeignKey("FarmTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FarmType");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.LotName", b =>
                {
                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.LotCategory", "LotCategory")
                        .WithMany()
                        .HasForeignKey("LotCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LotCategory");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.RawMaterial", b =>
                {
                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.ItemCategory", "ItemCategory")
                        .WithMany()
                        .HasForeignKey("ItemCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.UOM", "UOM")
                        .WithMany()
                        .HasForeignKey("UomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemCategory");

                    b.Navigation("UOM");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.TransformationRequirement", b =>
                {
                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.RawMaterial", "RawMaterial")
                        .WithMany()
                        .HasForeignKey("RawMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL.TransformationFormula", "TransformationFormula")
                        .WithMany()
                        .HasForeignKey("TransformationFormulaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RawMaterial");

                    b.Navigation("TransformationFormula");
                });

            modelBuilder.Entity("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.User", b =>
                {
                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
