namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WMSDBContext : DbContext
    {
        public WMSDBContext()
            : base("name=WMSDBConfig")
        {
        }

        public virtual DbSet<CheckTask> CheckTasks { get; set; }
        public virtual DbSet<CheckTaskDetail> CheckTaskDetails { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<InboundTask> InboundTasks { get; set; }
        public virtual DbSet<InboundTaskDetail> InboundTaskDetails { get; set; }
        public virtual DbSet<InboundType> InboundTypes { get; set; }
        public virtual DbSet<InventoryAdjustTask> InventoryAdjustTasks { get; set; }
        public virtual DbSet<InventoryAdjustTaskDetail> InventoryAdjustTaskDetails { get; set; }
        public virtual DbSet<InventoryAllocation> InventoryAllocations { get; set; }
        public virtual DbSet<InventoryArea> InventoryAreas { get; set; }
        public virtual DbSet<InventoryAreaType> InventoryAreaTypes { get; set; }
        public virtual DbSet<InventoryList> InventoryLists { get; set; }
        public virtual DbSet<InventoryLocation> InventoryLocations { get; set; }
        public virtual DbSet<InventoryLocationGroup> InventoryLocationGroups { get; set; }
        public virtual DbSet<InventoryLock> InventoryLocks { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialType> MaterialTypes { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuGroup> MenuGroups { get; set; }
        public virtual DbSet<Narrow> Narrows { get; set; }
        public virtual DbSet<OutboundTask> OutboundTasks { get; set; }
        public virtual DbSet<OutboundTaskDetail> OutboundTaskDetails { get; set; }
        public virtual DbSet<OutboundType> OutboundTypes { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PickingTask> PickingTasks { get; set; }
        public virtual DbSet<PickingTaskDetail> PickingTaskDetails { get; set; }
        public virtual DbSet<PickingType> PickingTypes { get; set; }
        public virtual DbSet<SaleType> SaleTypes { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tray> Trays { get; set; }
        public virtual DbSet<TrayDetail> TrayDetails { get; set; }
        public virtual DbSet<TrayType> TrayTypes { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WavePicking> WavePickings { get; set; }
        public virtual DbSet<WavePickingDetail> WavePickingDetails { get; set; }
        public virtual DbSet<WavePickingType> WavePickingTypes { get; set; }
        public virtual DbSet<View_Container> View_Container { get; set; }
        public virtual DbSet<View_InboundTask> View_InboundTask { get; set; }
        public virtual DbSet<View_InboundTaskDetail> View_InboundTaskDetail { get; set; }
        public virtual DbSet<View_InboundType> View_InboundType { get; set; }
        public virtual DbSet<View_InventoryArea> View_InventoryArea { get; set; }
        public virtual DbSet<View_InventoryAreaType> View_InventoryAreaType { get; set; }
        public virtual DbSet<View_InventoryList> View_InventoryList { get; set; }
        public virtual DbSet<View_InventoryLocation> View_InventoryLocation { get; set; }
        public virtual DbSet<View_Material> View_Material { get; set; }
        public virtual DbSet<View_MaterialType> View_MaterialType { get; set; }
        public virtual DbSet<View_Narrow> View_Narrow { get; set; }
        public virtual DbSet<View_OutboundTask> View_OutboundTask { get; set; }
        public virtual DbSet<View_OutboundTaskDetail> View_OutboundTaskDetail { get; set; }
        public virtual DbSet<View_OutboundType> View_OutboundType { get; set; }
        public virtual DbSet<View_PickingType> View_PickingType { get; set; }
        public virtual DbSet<View_SaleType> View_SaleType { get; set; }
        public virtual DbSet<View_Tray> View_Tray { get; set; }
        public virtual DbSet<View_TrayDetail> View_TrayDetail { get; set; }
        public virtual DbSet<View_TrayType> View_TrayType { get; set; }
        public virtual DbSet<View_Unit> View_Unit { get; set; }
        public virtual DbSet<View_User> View_User { get; set; }
        public virtual DbSet<View_Warehouse> View_Warehouse { get; set; }
        public virtual DbSet<View_WavePicking> View_WavePicking { get; set; }
        public virtual DbSet<View_WavePickingType> View_WavePickingType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckTask>()
                .Property(e => e.CheckTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<CheckTask>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<CheckTask>()
                .HasMany(e => e.CheckTask1)
                .WithOptional(e => e.CheckTask2)
                .HasForeignKey(e => e.RelCheckTaskID);

            modelBuilder.Entity<CheckTaskDetail>()
                .Property(e => e.MaterialNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<CheckTaskDetail>()
                .Property(e => e.PickingStation)
                .IsUnicode(false);

            modelBuilder.Entity<CheckTaskDetail>()
                .Property(e => e.ActualNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<Container>()
                .Property(e => e.ContainerName)
                .IsUnicode(false);

            modelBuilder.Entity<Container>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<Container>()
                .HasMany(e => e.InventoryLocations)
                .WithOptional(e => e.Container1)
                .HasForeignKey(e => e.Container);

            modelBuilder.Entity<Container>()
                .HasMany(e => e.Materials)
                .WithOptional(e => e.Container)
                .HasForeignKey(e => e.MaterialContainer);

            modelBuilder.Entity<Container>()
                .HasMany(e => e.PickingTaskDetails)
                .WithOptional(e => e.Container1)
                .HasForeignKey(e => e.Container);

            modelBuilder.Entity<Container>()
                .HasMany(e => e.Trays)
                .WithOptional(e => e.Container1)
                .HasForeignKey(e => e.Container);

            modelBuilder.Entity<InboundTask>()
                .Property(e => e.InboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTask>()
                .Property(e => e.InboundRemark)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTask>()
                .Property(e => e.ExterNo)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTask>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.MaterialNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.Weight)
                .HasPrecision(13, 2);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.BatchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.CarNum)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.Glaze)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<InboundTaskDetail>()
                .Property(e => e.ActualInboundNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<InboundType>()
                .Property(e => e.InboundTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<InboundType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<InboundType>()
                .HasMany(e => e.InboundTasks)
                .WithOptional(e => e.InboundType1)
                .HasForeignKey(e => e.InboundType);

            modelBuilder.Entity<InboundType>()
                .HasOptional(e => e.InboundType1)
                .WithRequired(e => e.InboundType2);

            modelBuilder.Entity<InventoryAdjustTask>()
                .Property(e => e.InventoryAdjustTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAdjustTask>()
                .Property(e => e.InventoryAdjustTaskType)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAdjustTask>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAdjustTaskDetail>()
                .Property(e => e.InventoryAdjustTaskDetailNo)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAdjustTaskDetail>()
                .Property(e => e.OldNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<InventoryAdjustTaskDetail>()
                .Property(e => e.NowNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<InventoryArea>()
                .Property(e => e.InventoryAreaNo)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryArea>()
                .Property(e => e.InventoryAreaName)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryArea>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryArea>()
                .Property(e => e.OtherInfo)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAreaType>()
                .Property(e => e.InventoryAreaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAreaType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryAreaType>()
                .HasMany(e => e.InventoryAreas)
                .WithOptional(e => e.InventoryAreaType1)
                .HasForeignKey(e => e.InventoryAreaType);

            modelBuilder.Entity<InventoryList>()
                .Property(e => e.InventoryType)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryList>()
                .HasMany(e => e.WavePickingDetails)
                .WithOptional(e => e.InventoryList)
                .HasForeignKey(e => e.InventoryID);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.InventoryLocationType)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.InventoryLocationNo)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.InventoryLocationName)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.InventoryLocationLength)
                .HasPrecision(10, 2);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.InventoryLocationHeight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<InventoryLocation>()
                .Property(e => e.InventoryLocationWidth)
                .HasPrecision(10, 2);

            modelBuilder.Entity<InventoryLocationGroup>()
                .Property(e => e.InventoryLocationGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<InventoryLock>()
                .Property(e => e.InventoryLockNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<Material>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Length)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Material>()
                .Property(e => e.Width)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Material>()
                .Property(e => e.Height)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Material>()
                .Property(e => e.Weight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Material>()
                .Property(e => e.MaterialModel)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.ParcelUnit)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.MaterialDensity)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Material>()
                .HasMany(e => e.InboundTaskDetails)
                .WithRequired(e => e.Material)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaterialType>()
                .Property(e => e.MaterialTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialType>()
                .Property(e => e.MaterialTypePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MaterialType>()
                .HasMany(e => e.MaterialType1)
                .WithOptional(e => e.MaterialType2)
                .HasForeignKey(e => e.MaterialTypeRoot);

            modelBuilder.Entity<Narrow>()
                .Property(e => e.NarrowName)
                .IsUnicode(false);

            modelBuilder.Entity<Narrow>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<Narrow>()
                .HasMany(e => e.InventoryLocations)
                .WithOptional(e => e.Narrow)
                .HasForeignKey(e => e.InventoryLocationNarrow);

            modelBuilder.Entity<OutboundTask>()
                .Property(e => e.OutboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTask>()
                .Property(e => e.OutboundRemark)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTask>()
                .Property(e => e.Client)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTask>()
                .Property(e => e.ExterNo)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTask>()
                .Property(e => e.SaleNo)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTask>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.MaterialNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.Weight)
                .HasPrecision(13, 2);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.BatchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.DeliveryUnit)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.CarNum)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.Glaze)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.QuantityAllotted)
                .HasPrecision(13, 2);

            modelBuilder.Entity<OutboundTaskDetail>()
                .Property(e => e.DispatchNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<OutboundType>()
                .Property(e => e.OutboundTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<OutboundType>()
                .HasMany(e => e.OutboundTasks)
                .WithOptional(e => e.OutboundType1)
                .HasForeignKey(e => e.OutboundType);

            modelBuilder.Entity<Page>()
                .Property(e => e.BlackList)
                .IsUnicode(false);

            modelBuilder.Entity<Page>()
                .Property(e => e.WhiteList)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTask>()
                .Property(e => e.PickingTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTask>()
                .Property(e => e.WavePickingNo)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTask>()
                .Property(e => e.PickingStation)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTask>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTask>()
                .HasOptional(e => e.PickingTask1)
                .WithRequired(e => e.PickingTask2);

            modelBuilder.Entity<PickingTaskDetail>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTaskDetail>()
                .Property(e => e.TrayCode)
                .IsUnicode(false);

            modelBuilder.Entity<PickingTaskDetail>()
                .Property(e => e.QuantityAllotted)
                .HasPrecision(13, 2);

            modelBuilder.Entity<PickingTaskDetail>()
                .Property(e => e.ActualPickingNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<PickingTaskDetail>()
                .Property(e => e.TrayCount)
                .HasPrecision(13, 2);

            modelBuilder.Entity<PickingTaskDetail>()
                .Property(e => e.PickerStation)
                .IsUnicode(false);

            modelBuilder.Entity<PickingType>()
                .Property(e => e.PickingTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<PickingType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<PickingType>()
                .HasMany(e => e.WavePickings)
                .WithOptional(e => e.PickingType1)
                .HasForeignKey(e => e.WavePickingTypeID);

            modelBuilder.Entity<SaleType>()
                .Property(e => e.SaleTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<SaleType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.CheckTasks)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.CheckTaskDetails)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.InboundTasks)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.InboundTaskDetails)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.InventoryLists)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.InventoryLocks)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.OutboundTasks)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.OutboundTaskDetails)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.PickingTasks)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.PickingTaskDetails)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Trays)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.TrayDetails)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.WavePickings)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.WavePickingDetails)
                .WithOptional(e => e.Status1)
                .HasForeignKey(e => e.Status);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierNo)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierPhoNum)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Tray>()
                .Property(e => e.TrayNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tray>()
                .Property(e => e.TrayCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tray>()
                .Property(e => e.Weight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Tray>()
                .Property(e => e.Height)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Tray>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TrayDetail>()
                .Property(e => e.ParcelMeasure)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TrayDetail>()
                .Property(e => e.MaterialSN)
                .IsUnicode(false);

            modelBuilder.Entity<TrayType>()
                .Property(e => e.TrayTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<TrayType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<TrayType>()
                .HasMany(e => e.Trays)
                .WithOptional(e => e.TrayType1)
                .HasForeignKey(e => e.TrayType);

            modelBuilder.Entity<TrayType>()
                .HasMany(e => e.Trays1)
                .WithOptional(e => e.TrayType2)
                .HasForeignKey(e => e.TrayType);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPasswd)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CheckTasks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CheckTasks1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CheckTaskDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.CheckTaskDetails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Containers)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Containers1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InboundTasks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InboundTasks1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InboundTaskDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InboundTaskDetails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InboundTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InboundTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAdjustTasks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAdjustTasks1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAdjustTaskDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAdjustTaskDetails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAllocations)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAllocations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAreas)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAreas1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAreaTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryAreaTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryLists)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryLists1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryLocations)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryLocations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryLocks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InventoryLocks1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Materials)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Materials1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MaterialTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MaterialTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Narrows)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Narrows1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OutboundTasks)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OutboundTasks1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OutboundTaskDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OutboundTaskDetails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OutboundTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OutboundTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PickingTaskDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PickingTaskDetails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PickingTaskDetails2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.Picker);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PickingTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.PickingTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SaleTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Status)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Status1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TrayTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TrayTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Units)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Units1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Warehouses)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Warehouses1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WavePickings)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WavePickings1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WavePickingDetails)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WavePickingDetails1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WavePickingTypes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.Changer);

            modelBuilder.Entity<User>()
                .HasMany(e => e.WavePickingTypes1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Creater);

            modelBuilder.Entity<UserGroup>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WarehouseNo)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WarehouseName)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.WarehouseType)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .Property(e => e.OtherInfo)
                .IsUnicode(false);

            modelBuilder.Entity<WavePicking>()
                .Property(e => e.WavePickingNo)
                .IsUnicode(false);

            modelBuilder.Entity<WavePicking>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<WavePickingDetail>()
                .Property(e => e.MaterialNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<WavePickingDetail>()
                .Property(e => e.BatchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<WavePickingDetail>()
                .Property(e => e.Glaze)
                .IsUnicode(false);

            modelBuilder.Entity<WavePickingDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<WavePickingDetail>()
                .Property(e => e.QuantityAllotted)
                .HasPrecision(13, 2);

            modelBuilder.Entity<WavePickingType>()
                .Property(e => e.WavePickingTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<WavePickingType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_Container>()
                .Property(e => e.ContainerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Container>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.InboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.InboundTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.InboundRemark)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.ExterNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.OrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTask>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.InboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.MaterialNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.Weight)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.BatchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.CarNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.Glaze)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.ActualInboundNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundTaskDetail>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<View_InboundType>()
                .Property(e => e.InboundTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryArea>()
                .Property(e => e.Warehouse)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryArea>()
                .Property(e => e.InventoryAreaName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryArea>()
                .Property(e => e.InventoryAreaNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryArea>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryArea>()
                .Property(e => e.InventoryAreaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryArea>()
                .Property(e => e.OtherInfo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryAreaType>()
                .Property(e => e.InventoryAreaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryAreaType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryList>()
                .Property(e => e.InventoryType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryList>()
                .Property(e => e.InboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryList>()
                .Property(e => e.OutboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryList>()
                .Property(e => e.TrayNoAndCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryList>()
                .Property(e => e.InventoryLocationNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryList>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.InventoryArea)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.InventoryLocationType)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.InventoryLocationName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.InventoryLocationNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.LWH)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.PLC)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.InventoryLocationGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.NarrowName)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.EnterExitDistance)
                .IsUnicode(false);

            modelBuilder.Entity<View_InventoryLocation>()
                .Property(e => e.ContainerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.SizeCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.LWH)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.Weight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.MaterialModel)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.ParcelUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.ContainerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Material>()
                .Property(e => e.MaterialDensity)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_MaterialType>()
                .Property(e => e.MaterialTypeNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_MaterialType>()
                .Property(e => e.MaterialTypePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_Narrow>()
                .Property(e => e.NarrowName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Narrow>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.OutboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.OutboundTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.OutboundRemark)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.Client)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.ExterNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.SaleNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.SaleTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTask>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.OutboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.MaterialNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.Weight)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.BatchNumber)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.DeliveryUnit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.CarNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.Glaze)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.QuantityAllotted)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.DispatchNum)
                .HasPrecision(13, 2);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundTaskDetail>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundType>()
                .Property(e => e.OutboundTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_OutboundType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickingType>()
                .Property(e => e.PickingTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_PickingType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_SaleType>()
                .Property(e => e.SaleTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_SaleType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.TrayTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.TrayNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.TrayCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.ContainerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.Weight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.Height)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Tray>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.InboundTaskNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.TrayNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.TrayCode)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.ParcelMeasure)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.ContainerName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.Weight)
                .HasPrecision(10, 2);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.MaterialSN)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayDetail>()
                .Property(e => e.HtmlAttributes)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayType>()
                .Property(e => e.TrayTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_TrayType>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_Unit>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<View_User>()
                .Property(e => e.UserPhoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<View_Warehouse>()
                .Property(e => e.WarehouseNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_Warehouse>()
                .Property(e => e.WarehouseName)
                .IsUnicode(false);

            modelBuilder.Entity<View_Warehouse>()
                .Property(e => e.WarehouseType)
                .IsUnicode(false);

            modelBuilder.Entity<View_Warehouse>()
                .Property(e => e.OtherInfo)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePicking>()
                .Property(e => e.WavePickingNo)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePicking>()
                .Property(e => e.WavePickingTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePicking>()
                .Property(e => e.PickingName)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePicking>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePicking>()
                .Property(e => e.StatusName)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePickingType>()
                .Property(e => e.WavePickingTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<View_WavePickingType>()
                .Property(e => e.Other)
                .IsUnicode(false);
        }
    }
}
