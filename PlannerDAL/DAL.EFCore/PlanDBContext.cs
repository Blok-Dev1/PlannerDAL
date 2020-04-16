using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.EFCore
{
    /// <summary>
    /// 
    /// </summary>
    /// Created with the following
    ///Scaffold-DbContext 'Data Source=MRPPLANQA;Initial Catalog=ConsiliumDEV;User Id=sa;Password=Password1;' 
    public partial class PlanDBContext : DbContext
    {
        public PlanDBContext()
        {
        }

        public PlanDBContext(DbContextOptions<PlanDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityCode> ActivityCode { get; set; }
        public virtual DbSet<AttributeRendering> AttributeRendering { get; set; }
        public virtual DbSet<Baseline> Baseline { get; set; }
        public virtual DbSet<BlockRefSys> BlockRefSys { get; set; }
        public virtual DbSet<CalendarTemplate> CalendarTemplate { get; set; }
        public virtual DbSet<CustomDependency> CustomDependency { get; set; }
        public virtual DbSet<Dependency> Dependency { get; set; }
        public virtual DbSet<DependencyType> DependencyType { get; set; }
        public virtual DbSet<DesignGraph> DesignGraph { get; set; }
        public virtual DbSet<DesignGraphNode> DesignGraphNode { get; set; }
        public virtual DbSet<DesignGraphNodeConnection> DesignGraphNodeConnection { get; set; }
        public virtual DbSet<DesignGraphNodeElements> DesignGraphNodeElements { get; set; }
        public virtual DbSet<DesignGraphNodeParameter> DesignGraphNodeParameter { get; set; }
        public virtual DbSet<DesignGraphNodeType> DesignGraphNodeType { get; set; }
        public virtual DbSet<DesignStandardEntity> DesignStandardEntity { get; set; }
        public virtual DbSet<DesignStandardLibrary> DesignStandardLibrary { get; set; }
        public virtual DbSet<DesignStandardTool> DesignStandardTool { get; set; }
        public virtual DbSet<DesignStandardToolParameter> DesignStandardToolParameter { get; set; }
        public virtual DbSet<Eavmapping> Eavmapping { get; set; }
        public virtual DbSet<EpsfieldGroup> EpsfieldGroup { get; set; }
        public virtual DbSet<Epsfile> Epsfile { get; set; }
        public virtual DbSet<Epsmapping> Epsmapping { get; set; }
        public virtual DbSet<EpsproductionField> EpsproductionField { get; set; }
        public virtual DbSet<Epstemplate> Epstemplate { get; set; }
        public virtual DbSet<Exception> Exception { get; set; }
        public virtual DbSet<FilterCategory> FilterCategory { get; set; }
        public virtual DbSet<FilterOperation> FilterOperation { get; set; }
        public virtual DbSet<FixedCrossSection> FixedCrossSection { get; set; }
        public virtual DbSet<Keys> Keys { get; set; }
        public virtual DbSet<Legend> Legend { get; set; }
        public virtual DbSet<LegendFilter> LegendFilter { get; set; }
        public virtual DbSet<LegendGroup> LegendGroup { get; set; }
        public virtual DbSet<LegendItem> LegendItem { get; set; }
        public virtual DbSet<LicenseLog> LicenseLog { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<PlanComment> PlanComment { get; set; }
        public virtual DbSet<PlanDependencies> PlanDependencies { get; set; }
        public virtual DbSet<PlanElements> PlanElements { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<ReportingCalendars> ReportingCalendars { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceAssignment> ResourceAssignment { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<SpatialRefSys> SpatialRefSys { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskBackup> TaskBackup { get; set; }
        public virtual DbSet<TaskField> TaskField { get; set; }
        public virtual DbSet<TaskFieldProperty> TaskFieldProperty { get; set; }
        public virtual DbSet<TaskFieldValues> TaskFieldValues { get; set; }
        public virtual DbSet<TaskFieldValuesBackup> TaskFieldValuesBackup { get; set; }
        public virtual DbSet<TaskScheduleType> TaskScheduleType { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<TextRendering> TextRendering { get; set; }
        public virtual DbSet<Waste> Waste { get; set; }
        public virtual DbSet<XdataAttribute> XdataAttribute { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=MRPPLANQA;Initial Catalog=ConsiliumDEV;User Id=sa;Password=Password1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityCode>(entity =>
            {
                entity.HasKey(e => e.ActivityCode1);

                entity.ToTable("ActivityCode", "plan");

                entity.Property(e => e.ActivityCode1)
                    .HasColumnName("ActivityCode")
                    .HasMaxLength(8);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("ExternalID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AttributeRendering>(entity =>
            {
                entity.ToTable("AttributeRendering", "plan");

                entity.HasIndex(e => new { e.AttributeRenderingId, e.GroupName, e.AttributeName, e.TextRenderingId })
                    .HasName("IX_AttributeRendering_Incl");

                entity.Property(e => e.AttributeRenderingId).HasColumnName("AttributeRenderingID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TextRenderingId).HasColumnName("TextRenderingID");

                entity.HasOne(d => d.TextRendering)
                    .WithMany(p => p.AttributeRendering)
                    .HasForeignKey(d => d.TextRenderingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TextRendering_AttributeRendering");
            });

            modelBuilder.Entity<Baseline>(entity =>
            {
                entity.ToTable("Baseline", "plan");

                entity.Property(e => e.BaselineId).HasColumnName("BaselineID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.Filename).IsRequired();

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Baseline)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_Baseline_Schedule");
            });

            modelBuilder.Entity<BlockRefSys>(entity =>
            {
                entity.HasKey(e => e.Brid);

                entity.ToTable("BLOCK_REF_SYS", "sdb");

                entity.HasIndex(e => e.Description)
                    .HasName("AK_BLOCK_REF_SYS")
                    .IsUnique();

                entity.Property(e => e.Brid)
                    .HasColumnName("BRID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsDestinationBr).HasColumnName("IsDestinationBR");

                entity.Property(e => e.IsLocalizedBr).HasColumnName("IsLocalizedBR");

                entity.Property(e => e.IsSourceBr).HasColumnName("IsSourceBR");

                entity.Property(e => e.Srid).HasColumnName("SRID");
            });

            modelBuilder.Entity<CalendarTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("CalendarTemplate", "plan");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.CalendarId).HasColumnName("CalendarID");

                entity.Property(e => e.Label).HasMaxLength(512);

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.CalendarTemplate)
                    .HasForeignKey(d => d.CalendarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CalendarTemplate_ReportingCalendars");
            });

            modelBuilder.Entity<CustomDependency>(entity =>
            {
                entity.ToTable("CustomDependency", "plan");

                entity.Property(e => e.CustomDependencyId).HasColumnName("CustomDependencyID");

                entity.Property(e => e.DelayAbbr).HasMaxLength(10);

                entity.Property(e => e.DependencyTypeId).HasColumnName("DependencyTypeID");

                entity.Property(e => e.FromTaskId).HasColumnName("FromTaskID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.ToTaskId).HasColumnName("ToTaskID");

                entity.HasOne(d => d.DependencyType)
                    .WithMany(p => p.CustomDependency)
                    .HasForeignKey(d => d.DependencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomDependency_DependencyType");

                entity.HasOne(d => d.FromTask)
                    .WithMany(p => p.CustomDependencyFromTask)
                    .HasForeignKey(d => d.FromTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomDependency_FromTask");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.CustomDependency)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomDependency_Schedule");

                entity.HasOne(d => d.ToTask)
                    .WithMany(p => p.CustomDependencyToTask)
                    .HasForeignKey(d => d.ToTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomDependency_ToTask");
            });

            modelBuilder.Entity<Dependency>(entity =>
            {
                entity.ToTable("Dependency", "plan");

                entity.HasIndex(e => e.FromPlanElementId);

                entity.HasIndex(e => e.FromTaskId);

                entity.HasIndex(e => e.ToPlanElementId);

                entity.HasIndex(e => e.ToSecondaryTaskId);

                entity.HasIndex(e => e.ToTaskId);

                entity.HasIndex(e => new { e.DependencyId, e.FromPlanElementId, e.ToPlanElementId, e.FromDistance, e.ToDistance, e.DependencyTypeId, e.IsInternal, e.IsManual, e.DependencyRuleId, e.SplitDirectionOnTo, e.FromPointX, e.FromPointY, e.FromPointZ, e.ToPointX, e.ToPointY, e.ToPointZ, e.VectorX, e.VectorY, e.VectorZ, e.FromTaskId, e.ToTaskId, e.ToSplitTaskId, e.ToSecondaryTaskId, e.BreakInternalDependency, e.Delay, e.DelayAbbr, e.DateCreated, e.CreatedBy, e.DateModified, e.ModifiedBy, e.PlanId })
                    .HasName("IX_Dependency_PlanID_Incl");

                entity.Property(e => e.DependencyId).HasColumnName("DependencyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DelayAbbr).HasMaxLength(10);

                entity.Property(e => e.DependencyRuleId).HasColumnName("DependencyRuleID");

                entity.Property(e => e.DependencyTypeId).HasColumnName("DependencyTypeID");

                entity.Property(e => e.FromPlanElementId).HasColumnName("FromPlanElementID");

                entity.Property(e => e.FromTaskId).HasColumnName("FromTaskID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ToPlanElementId).HasColumnName("ToPlanElementID");

                entity.Property(e => e.ToSecondaryTaskId).HasColumnName("ToSecondaryTaskID");

                entity.Property(e => e.ToSplitTaskId).HasColumnName("ToSplitTaskID");

                entity.Property(e => e.ToTaskId).HasColumnName("ToTaskID");

                entity.HasOne(d => d.DependencyType)
                    .WithMany(p => p.Dependency)
                    .HasForeignKey(d => d.DependencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependency_DependencyType");

                entity.HasOne(d => d.FromPlanElement)
                    .WithMany(p => p.DependencyFromPlanElement)
                    .HasForeignKey(d => d.FromPlanElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependency_FromPlanElements");

                entity.HasOne(d => d.FromTask)
                    .WithMany(p => p.DependencyFromTask)
                    .HasForeignKey(d => d.FromTaskId)
                    .HasConstraintName("FK_Dependency_FromTask");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Dependency)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependency_Plans");

                entity.HasOne(d => d.ToPlanElement)
                    .WithMany(p => p.DependencyToPlanElement)
                    .HasForeignKey(d => d.ToPlanElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dependency_ToPlanElements");

                entity.HasOne(d => d.ToSecondaryTask)
                    .WithMany(p => p.DependencyToSecondaryTask)
                    .HasForeignKey(d => d.ToSecondaryTaskId)
                    .HasConstraintName("FK_Dependency_ToSecondaryTask");

                entity.HasOne(d => d.ToSplitTask)
                    .WithMany(p => p.DependencyToSplitTask)
                    .HasForeignKey(d => d.ToSplitTaskId)
                    .HasConstraintName("FK_Dependency_ToSplitTask");

                entity.HasOne(d => d.ToTask)
                    .WithMany(p => p.DependencyToTask)
                    .HasForeignKey(d => d.ToTaskId)
                    .HasConstraintName("FK_Dependency_ToTask");
            });

            modelBuilder.Entity<DependencyType>(entity =>
            {
                entity.ToTable("DependencyType", "plan");

                entity.Property(e => e.DependencyTypeId)
                    .HasColumnName("DependencyTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DependencyType1)
                    .IsRequired()
                    .HasColumnName("DependencyType")
                    .HasMaxLength(255);

                entity.Property(e => e.DependencyTypeDescription)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<DesignGraph>(entity =>
            {
                entity.ToTable("DesignGraph", "plan");

                entity.Property(e => e.DesignGraphId).HasColumnName("DesignGraphID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DesignGraphName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.MasterDataViewId).HasColumnName("MasterDataViewID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.DesignGraph)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_DesignGraph_Plans");
            });

            modelBuilder.Entity<DesignGraphNode>(entity =>
            {
                entity.ToTable("DesignGraphNode", "plan");

                entity.Property(e => e.DesignGraphNodeId).HasColumnName("DesignGraphNodeID");

                entity.Property(e => e.DesignGraphId).HasColumnName("DesignGraphID");

                entity.Property(e => e.DesignGraphNodeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DesignGraphNodeTypeId).HasColumnName("DesignGraphNodeTypeID");

                entity.Property(e => e.GroupingParentId).HasColumnName("GroupingParentID");

                entity.Property(e => e.NodePath).HasMaxLength(255);

                entity.Property(e => e.RegenerateGraphOnChange)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DesignGraph)
                    .WithMany(p => p.DesignGraphNode)
                    .HasForeignKey(d => d.DesignGraphId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNode_DesignGraph");

                entity.HasOne(d => d.DesignGraphNodeType)
                    .WithMany(p => p.DesignGraphNode)
                    .HasForeignKey(d => d.DesignGraphNodeTypeId)
                    .HasConstraintName("FK_DesignGraphNode_DesignGraphNodeType");

                entity.HasOne(d => d.GroupingParent)
                    .WithMany(p => p.InverseGroupingParent)
                    .HasForeignKey(d => d.GroupingParentId)
                    .HasConstraintName("FK_DesignGraphNode_DesignGraphNode");
            });

            modelBuilder.Entity<DesignGraphNodeConnection>(entity =>
            {
                entity.ToTable("DesignGraphNodeConnection", "plan");

                entity.Property(e => e.DesignGraphNodeConnectionId).HasColumnName("DesignGraphNodeConnectionID");

                entity.Property(e => e.DesignGraphId).HasColumnName("DesignGraphID");

                entity.Property(e => e.DesignGraphNodeParameterId).HasColumnName("DesignGraphNodeParameterID");

                entity.Property(e => e.FeedObjectIndexes).IsUnicode(false);

                entity.Property(e => e.FromDesignGraphNodeId).HasColumnName("FromDesignGraphNodeID");

                entity.Property(e => e.Parameter)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParameterDisplay)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ToDesignGraphNodeId).HasColumnName("ToDesignGraphNodeID");

                entity.HasOne(d => d.DesignGraph)
                    .WithMany(p => p.DesignGraphNodeConnection)
                    .HasForeignKey(d => d.DesignGraphId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNodeConnection_DesignGraph");

                entity.HasOne(d => d.DesignGraphNodeParameter)
                    .WithMany(p => p.DesignGraphNodeConnection)
                    .HasForeignKey(d => d.DesignGraphNodeParameterId)
                    .HasConstraintName("FK_DesignGraphNodeConnection_DesignGraphNodeParameter");

                entity.HasOne(d => d.FromDesignGraphNode)
                    .WithMany(p => p.DesignGraphNodeConnectionFromDesignGraphNode)
                    .HasForeignKey(d => d.FromDesignGraphNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNodeConnection_FromDesignGraphNode");

                entity.HasOne(d => d.ToDesignGraphNode)
                    .WithMany(p => p.DesignGraphNodeConnectionToDesignGraphNode)
                    .HasForeignKey(d => d.ToDesignGraphNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNodeConnection_ToDesignGraphNode");
            });

            modelBuilder.Entity<DesignGraphNodeElements>(entity =>
            {
                entity.HasKey(e => e.DesignGraphNodeElementId);

                entity.ToTable("DesignGraphNodeElements", "plan");

                entity.HasIndex(e => new { e.DesignGraphNodeElementId, e.DesignGraphNodeId })
                    .HasName("IX_DesignGraphNodeElements_DesignGraphNodeID");

                entity.HasIndex(e => new { e.DesignGraphNodeElementId, e.PlanElementId })
                    .HasName("IX_DesignGraphNodeElements_PlanElementID");

                entity.Property(e => e.DesignGraphNodeElementId).HasColumnName("DesignGraphNodeElementID");

                entity.Property(e => e.DesignGraphNodeId).HasColumnName("DesignGraphNodeID");

                entity.Property(e => e.PlanElementId).HasColumnName("PlanElementID");

                entity.HasOne(d => d.DesignGraphNode)
                    .WithMany(p => p.DesignGraphNodeElements)
                    .HasForeignKey(d => d.DesignGraphNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNodeElements_DesignGraphNode");

                entity.HasOne(d => d.PlanElement)
                    .WithMany(p => p.DesignGraphNodeElements)
                    .HasForeignKey(d => d.PlanElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNodeElements_PlanElements");
            });

            modelBuilder.Entity<DesignGraphNodeParameter>(entity =>
            {
                entity.ToTable("DesignGraphNodeParameter", "plan");

                entity.HasIndex(e => new { e.DesignGraphNodeParameterId, e.DesignGraphNodeParameterName, e.DesignGraphNodeProperty, e.DesignGraphNodeValue, e.DesignGraphNodeId })
                    .HasName("IX_DesignGraphNodeParameter_DesignGraphNodeID");

                entity.Property(e => e.DesignGraphNodeParameterId).HasColumnName("DesignGraphNodeParameterID");

                entity.Property(e => e.DesignGraphNodeId).HasColumnName("DesignGraphNodeID");

                entity.Property(e => e.DesignGraphNodeParameterName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DesignGraphNodeProperty)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.DesignGraphNodeValue).HasColumnType("varbinary(max)");

                entity.HasOne(d => d.DesignGraphNode)
                    .WithMany(p => p.DesignGraphNodeParameter)
                    .HasForeignKey(d => d.DesignGraphNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignGraphNodeParameter_DesignGraphNode");
            });

            modelBuilder.Entity<DesignGraphNodeType>(entity =>
            {
                entity.ToTable("DesignGraphNodeType", "plan");

                entity.Property(e => e.DesignGraphNodeTypeId).HasColumnName("DesignGraphNodeTypeID");

                entity.Property(e => e.DesignGraphNodeTypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DesignStandardEntity>(entity =>
            {
                entity.ToTable("DesignStandardEntity", "plan");

                entity.HasIndex(e => e.CadentityId);

                entity.Property(e => e.DesignStandardEntityId).HasColumnName("DesignStandardEntityID");

                entity.Property(e => e.ActivityCode).HasMaxLength(8);

                entity.Property(e => e.CadentityId).HasColumnName("CADEntityID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DesignStandardToolId).HasColumnName("DesignStandardToolID");

                entity.Property(e => e.DesignType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Rate).HasMaxLength(128);

                entity.Property(e => e.RateUnit).HasMaxLength(6);

                entity.Property(e => e.SubType).HasMaxLength(50);

                entity.Property(e => e.TaskScheduleTypeId).HasColumnName("TaskScheduleTypeID");

                entity.HasOne(d => d.ActivityCodeNavigation)
                    .WithMany(p => p.DesignStandardEntity)
                    .HasForeignKey(d => d.ActivityCode)
                    .HasConstraintName("FK_DesignStandardEntity_ActivityCode");

                entity.HasOne(d => d.DesignStandardTool)
                    .WithMany(p => p.DesignStandardEntity)
                    .HasForeignKey(d => d.DesignStandardToolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DesignElement_ToolStandard");

                entity.HasOne(d => d.TaskScheduleType)
                    .WithMany(p => p.DesignStandardEntity)
                    .HasForeignKey(d => d.TaskScheduleTypeId)
                    .HasConstraintName("FK_DesignStandardEntity_TaskScheduleType");
            });

            modelBuilder.Entity<DesignStandardLibrary>(entity =>
            {
                entity.ToTable("DesignStandardLibrary", "plan");

                entity.HasIndex(e => e.CadlibraryId)
                    .HasName("IX_DesignStandardLibrary_CADLibraryId");

                entity.Property(e => e.DesignStandardLibraryId).HasColumnName("DesignStandardLibraryID");

                entity.Property(e => e.CadlibraryId).HasColumnName("CADLibraryID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DesignStandardTool>(entity =>
            {
                entity.ToTable("DesignStandardTool", "plan");

                entity.Property(e => e.DesignStandardToolId).HasColumnName("DesignStandardToolID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DesignStandardLibraryId).HasColumnName("DesignStandardLibraryID");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.ToolTypeFullName).IsRequired();

                entity.HasOne(d => d.DesignStandardLibrary)
                    .WithMany(p => p.DesignStandardTool)
                    .HasForeignKey(d => d.DesignStandardLibraryId)
                    .HasConstraintName("FK_ToolStandard_DesignStandardLibrary");
            });

            modelBuilder.Entity<DesignStandardToolParameter>(entity =>
            {
                entity.ToTable("DesignStandardToolParameter", "plan");

                entity.HasIndex(e => e.DesignStandardToolParameterId)
                    .HasName("AK_ParameterStandard_ToolStandardID_ParameterName")
                    .IsUnique();

                entity.Property(e => e.DesignStandardToolParameterId).HasColumnName("DesignStandardToolParameterID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(300);

                entity.Property(e => e.DefaultValueType).HasMaxLength(1024);

                entity.Property(e => e.DesignStandardToolId).HasColumnName("DesignStandardToolID");

                entity.Property(e => e.DisplayName).HasMaxLength(225);

                entity.Property(e => e.GroupName).HasMaxLength(150);

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.ParameterName).HasMaxLength(150);

                entity.HasOne(d => d.DesignStandardTool)
                    .WithMany(p => p.DesignStandardToolParameter)
                    .HasForeignKey(d => d.DesignStandardToolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParameterStandard_ToolStandard");
            });

            modelBuilder.Entity<Eavmapping>(entity =>
            {
                entity.ToTable("EAVMapping", "plan");

                entity.HasIndex(e => new { e.DesignAttribute, e.AttributeId })
                    .HasName("AK_EAV_DesignAttribute")
                    .IsUnique();

                entity.Property(e => e.EavmappingId).HasColumnName("EAVMappingID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttributeType)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DesignAttribute)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);
            });

            modelBuilder.Entity<EpsfieldGroup>(entity =>
            {
                entity.ToTable("EPSFieldGroup", "plan");

                entity.Property(e => e.EpsfieldGroupId).HasColumnName("EPSFieldGroupID");

                entity.Property(e => e.Name).HasMaxLength(1024);
            });

            modelBuilder.Entity<Epsfile>(entity =>
            {
                entity.ToTable("EPSFile", "plan");

                entity.Property(e => e.EpsfileId).HasColumnName("EPSFileID");

                entity.Property(e => e.Epsdata)
                    .IsRequired()
                    .HasColumnName("EPSData");

                entity.Property(e => e.Epsextension)
                    .IsRequired()
                    .HasColumnName("EPSExtension")
                    .HasMaxLength(5);

                entity.Property(e => e.Epsname)
                    .IsRequired()
                    .HasColumnName("EPSName")
                    .HasMaxLength(1024);

                entity.Property(e => e.EpstemplateId).HasColumnName("EPSTemplateID");

                entity.Property(e => e.Exfdata).HasColumnName("EXFData");

                entity.Property(e => e.FileHash).HasMaxLength(80);

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.Epstemplate)
                    .WithMany(p => p.Epsfile)
                    .HasForeignKey(d => d.EpstemplateId)
                    .HasConstraintName("FK_EPSFile_EPSTemplate");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Epsfile)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_EPSFiles_Schedule");
            });

            modelBuilder.Entity<Epsmapping>(entity =>
            {
                entity.HasKey(e => e.EpsfieldId);

                entity.ToTable("EPSMapping", "plan");

                entity.Property(e => e.EpsfieldId).HasColumnName("EPSFieldID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.EpsfieldDescription).HasColumnName("EPSFieldDescription");

                entity.Property(e => e.EpsfieldName)
                    .IsRequired()
                    .HasColumnName("EPSFieldName")
                    .HasMaxLength(50);

                entity.Property(e => e.EpsfieldType)
                    .IsRequired()
                    .HasColumnName("EPSFieldType")
                    .HasMaxLength(20);

                entity.Property(e => e.EpstemplateId).HasColumnName("EPSTemplateID");

                entity.HasOne(d => d.Epstemplate)
                    .WithMany(p => p.Epsmapping)
                    .HasForeignKey(d => d.EpstemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPSMapping_ESPTemplate");
            });

            modelBuilder.Entity<EpsproductionField>(entity =>
            {
                entity.HasKey(e => e.EpsfieldId);

                entity.ToTable("EPSProductionField", "plan");

                entity.Property(e => e.EpsfieldId)
                    .HasColumnName("EPSFieldID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CostField)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.NumberFormat).HasMaxLength(30);

                entity.Property(e => e.TargetPeriod).HasMaxLength(50);

                entity.HasOne(d => d.Epsfield)
                    .WithOne(p => p.EpsproductionField)
                    .HasForeignKey<EpsproductionField>(d => d.EpsfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPSProductionField_EPSMapping");
            });

            modelBuilder.Entity<Epstemplate>(entity =>
            {
                entity.HasKey(e => e.EsptemplateId);

                entity.ToTable("EPSTemplate", "plan");

                entity.Property(e => e.EsptemplateId).HasColumnName("ESPTemplateID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.DesignStandardLibraryNavigation)
                    .WithMany(p => p.Epstemplate)
                    .HasForeignKey(d => d.DesignStandardLibrary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPSTemplate_DesignStandardLibrary");
            });

            modelBuilder.Entity<Exception>(entity =>
            {
                entity.ToTable("Exception", "plan");

                entity.Property(e => e.ExceptionId).HasColumnName("ExceptionID");

                entity.Property(e => e.Cadusername)
                    .HasColumnName("CADUsername")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ExceptionType).HasMaxLength(512);

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WindowsUsername).HasMaxLength(50);
            });

            modelBuilder.Entity<FilterCategory>(entity =>
            {
                entity.ToTable("FilterCategory", "plan");

                entity.Property(e => e.FilterCategoryId).HasColumnName("FilterCategoryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FilterOperation>(entity =>
            {
                entity.ToTable("FilterOperation", "plan");

                entity.Property(e => e.FilterOperationId).HasColumnName("FilterOperationID");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FixedCrossSection>(entity =>
            {
                entity.ToTable("FixedCrossSection", "plan");

                entity.Property(e => e.FixedCrossSectionId).HasColumnName("FixedCrossSectionID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SerializedObject)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.SerializedObjectType)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ShapeType)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Keys>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Keys", "sdb");

                entity.Property(e => e.Key).IsRequired();

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Legend>(entity =>
            {
                entity.ToTable("Legend", "plan");

                entity.Property(e => e.LegendId).HasColumnName("LegendID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(1024);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Legend)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_Legend_Plans");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Legend)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_Legend_Schedule");
            });

            modelBuilder.Entity<LegendFilter>(entity =>
            {
                entity.ToTable("LegendFilter", "plan");

                entity.Property(e => e.LegendFilterId).HasColumnName("LegendFilterID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DataType).HasMaxLength(1024);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FieldName).HasMaxLength(150);

                entity.Property(e => e.FieldValue1).HasMaxLength(300);

                entity.Property(e => e.FieldValue2).HasMaxLength(300);

                entity.Property(e => e.LegendGroupId).HasColumnName("LegendGroupID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.TypeFullName).HasMaxLength(1024);

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.LegendFilter)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegendFilter_FilterCategory");

                entity.HasOne(d => d.LegendGroup)
                    .WithMany(p => p.LegendFilter)
                    .HasForeignKey(d => d.LegendGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegendFilter_LegendGroup");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.LegendFilter)
                    .HasForeignKey(d => d.OperationId)
                    .HasConstraintName("FK_LegendFilter_FilterOperation");
            });

            modelBuilder.Entity<LegendGroup>(entity =>
            {
                entity.ToTable("LegendGroup", "plan");

                entity.Property(e => e.LegendGroupId).HasColumnName("LegendGroupID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LegendItemId).HasColumnName("LegendItemID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ParentGroupId).HasColumnName("ParentGroupID");

                entity.HasOne(d => d.LegendItem)
                    .WithMany(p => p.LegendGroup)
                    .HasForeignKey(d => d.LegendItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegendGroup_LegendItem");

                entity.HasOne(d => d.ParentGroup)
                    .WithMany(p => p.InverseParentGroup)
                    .HasForeignKey(d => d.ParentGroupId)
                    .HasConstraintName("FK_LegendGroup_LegendGroup");
            });

            modelBuilder.Entity<LegendItem>(entity =>
            {
                entity.ToTable("LegendItem", "plan");

                entity.Property(e => e.LegendItemId).HasColumnName("LegendItemID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LegendId).HasColumnName("LegendID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Legend)
                    .WithMany(p => p.LegendItem)
                    .HasForeignKey(d => d.LegendId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LegendItem_Legend");
            });

            modelBuilder.Entity<LicenseLog>(entity =>
            {
                entity.HasKey(e => new { e.LogDate, e.DatabaseUserName, e.WindowsUserName, e.ComputerName });

                entity.ToTable("LicenseLog", "sdb");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.DatabaseUserName).HasMaxLength(128);

                entity.Property(e => e.WindowsUserName).HasMaxLength(128);

                entity.Property(e => e.ComputerName).HasMaxLength(128);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("Notifications", "plan");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Parameters).HasMaxLength(150);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PlanComment>(entity =>
            {
                entity.ToTable("PlanComment", "plan");

                entity.Property(e => e.PlanCommentId).HasColumnName("PlanCommentID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.CreatedByUser).HasMaxLength(250);

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanComment)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanComment_Plans");
            });

            modelBuilder.Entity<PlanDependencies>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PlanDependencies", "plan");

                entity.Property(e => e.DelayAbbr).HasMaxLength(10);

                entity.Property(e => e.DependencyId).HasColumnName("DependencyID");

                entity.Property(e => e.DependencyTypeId).HasColumnName("DependencyTypeID");

                entity.Property(e => e.FromTaskId).HasColumnName("FromTaskID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ToTaskId).HasColumnName("ToTaskID");
            });

            modelBuilder.Entity<PlanElements>(entity =>
            {
                entity.HasKey(e => e.PlanElementId)
                    .HasName("PK_DataView");

                entity.ToTable("PlanElements", "plan");

                entity.HasIndex(e => e.LinkedPlanElementId);

                entity.HasIndex(e => e.PlanId);

                entity.HasIndex(e => new { e.CadlibraryId, e.CadentityId, e.CadelementId, e.PlanId })
                    .HasName("AK_PlanElements_Element_Lib_Entity")
                    .IsUnique();

                entity.Property(e => e.PlanElementId).HasColumnName("PlanElementID");

                entity.Property(e => e.CadelementId).HasColumnName("CADElementID");

                entity.Property(e => e.CadentityId).HasColumnName("CADEntityID");

                entity.Property(e => e.CadlibraryId).HasColumnName("CADLibraryID");

                entity.Property(e => e.LinkedCenterlinePlanElementId).HasColumnName("LinkedCenterlinePlanElementID");

                entity.Property(e => e.LinkedPlanElementId).HasColumnName("LinkedPlanElementID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.XdataAttributesCsv).HasColumnName("XDataAttributesCSV");

                entity.HasOne(d => d.LinkedCenterlinePlanElement)
                    .WithMany(p => p.InverseLinkedCenterlinePlanElement)
                    .HasForeignKey(d => d.LinkedCenterlinePlanElementId)
                    .HasConstraintName("FK_PlanElements_LinkedCenterlinePlanElements");

                entity.HasOne(d => d.LinkedPlanElement)
                    .WithMany(p => p.InverseLinkedPlanElement)
                    .HasForeignKey(d => d.LinkedPlanElementId)
                    .HasConstraintName("FK_PlanElements_LinkedPlanElements");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.PlanElements)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanElements_Plans");
            });

            modelBuilder.Entity<Plans>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("Plans", "plan");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.CopiedFromPlanId).HasColumnName("CopiedFromPlanID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.CreatorCaduserId)
                    .HasColumnName("CreatorCADUserID")
                    .HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(1024);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('New')");

                entity.Property(e => e.VersionNumber).HasMaxLength(30);

                entity.HasOne(d => d.CopiedFromPlan)
                    .WithMany(p => p.InverseCopiedFromPlan)
                    .HasForeignKey(d => d.CopiedFromPlanId)
                    .HasConstraintName("FK_Plans_Plans_CopiedFromPlan");
            });

            modelBuilder.Entity<ReportingCalendars>(entity =>
            {
                entity.HasKey(e => e.CalendarId)
                    .HasName("PK_ReportingCalendar");

                entity.ToTable("ReportingCalendars", "plan");

                entity.Property(e => e.CalendarId).HasColumnName("CalendarID");

                entity.Property(e => e.Name).HasMaxLength(512);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.ReportingCalendars)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportingCalendars_Plans");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ReportingCalendars)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportingCalendars_Schedule");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("Resource", "plan");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.CodeOrExternalId)
                    .HasColumnName("CodeOrExternalID")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultProductionRateAbr).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.Epsid)
                    .IsRequired()
                    .HasColumnName("EPSId")
                    .HasMaxLength(128);

                entity.Property(e => e.ExternalSource).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Plans");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Schedule");
            });

            modelBuilder.Entity<ResourceAssignment>(entity =>
            {
                entity.ToTable("ResourceAssignment", "plan");

                entity.Property(e => e.ResourceAssignmentId).HasColumnName("ResourceAssignmentID");

                entity.Property(e => e.AssignmentType).HasMaxLength(50);

                entity.Property(e => e.Epsid)
                    .HasColumnName("EPSId")
                    .HasMaxLength(128);

                entity.Property(e => e.NumberOfUnits).HasDefaultValueSql("((1.0))");

                entity.Property(e => e.Operation).HasMaxLength(50);

                entity.Property(e => e.ProductionRateUnit).HasMaxLength(50);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceAssignment)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAssignment_Resource");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ResourceAssignment)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceAssignment_Task");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule", "plan");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CopiedFromScheduleId).HasColumnName("CopiedFromScheduleID");

                entity.Property(e => e.CreatedBy).HasMaxLength(260);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EpstemplateId).HasColumnName("EPSTemplateID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(512);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.CopiedFromSchedule)
                    .WithMany(p => p.InverseCopiedFromSchedule)
                    .HasForeignKey(d => d.CopiedFromScheduleId)
                    .HasConstraintName("FK_Schedule_Schedule_CopiedFromSchedule");

                entity.HasOne(d => d.Epstemplate)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.EpstemplateId)
                    .HasConstraintName("FK_Schedule_EPSTemplate");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_Plans");
            });

            modelBuilder.Entity<SpatialRefSys>(entity =>
            {
                entity.HasKey(e => e.Srid)
                    .HasName("PK__SPATIAL___A09710AA9A36E9E0");

                entity.ToTable("SPATIAL_REF_SYS", "sdb");

                entity.Property(e => e.Srid)
                    .HasColumnName("SRID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthName)
                    .HasColumnName("AUTH_NAME")
                    .HasMaxLength(256);

                entity.Property(e => e.AuthSrid).HasColumnName("AUTH_SRID");

                entity.Property(e => e.Srtext)
                    .HasColumnName("SRTEXT")
                    .HasMaxLength(2048);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task", "plan");

                entity.HasIndex(e => e.PlanElementId);

                entity.HasIndex(e => e.PlanId);

                entity.HasIndex(e => new { e.TaskId, e.PlanId, e.PlanElementId, e.TaskTypeId, e.ParentId, e.BreakInternalFrom, e.BreakInternalTo, e.IsTunnel, e.SequenceOrder, e.LevelNumber, e.EntityOrder, e.InternalToTaskId, e.Epsid, e.ReverseDirection, e.StartPointZ, e.EndPointX, e.EndPointY, e.EndPointZ, e.StartDistance, e.EndDistance, e.Weight, e.WeightAbbr, e.Volume, e.VolumeAbbr, e.StartPointX, e.StartPointY, e.Duration, e.DurationAbbr, e.Distance, e.DistanceAbbr, e.FloorArea, e.FloorAreaAbbr, e.Name, e.Description, e.Start, e.Finish, e.Rate, e.RateAbbr, e.ScheduleId })
                    .HasName("IX_Task_ScheduleID_InclMany");

                entity.HasIndex(e => new { e.TaskId, e.PlanId, e.PlanElementId, e.TaskTypeId, e.ParentId, e.Name, e.Description, e.Start, e.Finish, e.Rate, e.RateAbbr, e.Duration, e.DurationAbbr, e.Distance, e.DistanceAbbr, e.FloorArea, e.FloorAreaAbbr, e.Weight, e.WeightAbbr, e.Volume, e.VolumeAbbr, e.StartPointX, e.StartPointY, e.StartPointZ, e.EndPointX, e.EndPointY, e.EndPointZ, e.StartDistance, e.EndDistance, e.SequenceOrder, e.LevelNumber, e.EntityOrder, e.InternalToTaskId, e.InternalToTaskDelay, e.InternalToTaskDelayAbbr, e.Epsid, e.Resources, e.ResourcesLong, e.ReverseDirection, e.BreakInternalFrom, e.BreakInternalTo, e.IsTunnel, e.TunnelWallWidth, e.TaskScheduleTypeId, e.ActivityCode, e.ScheduleId })
                    .HasName("IX_Schedule_AllTask");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.ActivityCode).HasMaxLength(8);

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.DistanceAbbr).HasMaxLength(50);

                entity.Property(e => e.DrivingProperty).HasMaxLength(255);

                entity.Property(e => e.DrivingPropertyUnit).HasMaxLength(50);

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DurationAbbr).HasMaxLength(50);

                entity.Property(e => e.Epsid)
                    .IsRequired()
                    .HasColumnName("EPSId")
                    .HasMaxLength(128);

                entity.Property(e => e.FloorAreaAbbr).HasMaxLength(50);

                entity.Property(e => e.Fxsname)
                    .HasColumnName("FXSName")
                    .HasMaxLength(128);

                entity.Property(e => e.InternalToTaskDelayAbbr).HasMaxLength(50);

                entity.Property(e => e.InternalToTaskId).HasColumnName("InternalToTaskID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName).HasMaxLength(1024);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlanElementId).HasColumnName("PlanElementID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.Rate).HasMaxLength(128);

                entity.Property(e => e.RateAbbr).HasMaxLength(50);

                entity.Property(e => e.Resources).HasMaxLength(150);

                entity.Property(e => e.ResourcesLong).HasMaxLength(150);

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.TaskFieldValuesCsv).HasColumnName("TaskFieldValuesCSV");

                entity.Property(e => e.TaskGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TaskScheduleTypeId).HasColumnName("TaskScheduleTypeID");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.TunnelWallWidth).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VolumeAbbr).HasMaxLength(50);

                entity.Property(e => e.WeightAbbr).HasMaxLength(50);

                entity.HasOne(d => d.ActivityCodeNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.ActivityCode)
                    .HasConstraintName("FK_Task_ActivityCode");

                entity.HasOne(d => d.InternalToTask)
                    .WithMany(p => p.InverseInternalToTask)
                    .HasForeignKey(d => d.InternalToTaskId)
                    .HasConstraintName("FK_Task_InternalToTask");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Task_ParentTask");

                entity.HasOne(d => d.PlanElement)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.PlanElementId)
                    .HasConstraintName("FK_Task_PlanElements");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Plans");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Schedule");

                entity.HasOne(d => d.TaskScheduleType)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.TaskScheduleTypeId)
                    .HasConstraintName("FK_Task_TaskScheduleType");

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.TaskTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_TaskType");
            });

            modelBuilder.Entity<TaskBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaskBackup", "plan");

                entity.Property(e => e.ActivityCode).HasMaxLength(8);

                entity.Property(e => e.Description).HasMaxLength(2048);

                entity.Property(e => e.DistanceAbbr).HasMaxLength(50);

                entity.Property(e => e.DrivingProperty).HasMaxLength(255);

                entity.Property(e => e.DrivingPropertyUnit).HasMaxLength(50);

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DurationAbbr).HasMaxLength(50);

                entity.Property(e => e.Epsid)
                    .IsRequired()
                    .HasColumnName("EPSId")
                    .HasMaxLength(128);

                entity.Property(e => e.FloorAreaAbbr).HasMaxLength(50);

                entity.Property(e => e.Fxsname)
                    .HasColumnName("FXSName")
                    .HasMaxLength(128);

                entity.Property(e => e.InternalToTaskDelayAbbr).HasMaxLength(50);

                entity.Property(e => e.InternalToTaskId).HasColumnName("InternalToTaskID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName).HasMaxLength(1024);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlanElementId).HasColumnName("PlanElementID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.Rate).HasMaxLength(128);

                entity.Property(e => e.RateAbbr).HasMaxLength(50);

                entity.Property(e => e.Resources).HasMaxLength(150);

                entity.Property(e => e.ResourcesLong).HasMaxLength(150);

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.TaskFieldValuesCsv).HasColumnName("TaskFieldValuesCSV");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaskScheduleTypeId).HasColumnName("TaskScheduleTypeID");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.TunnelWallWidth).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VolumeAbbr).HasMaxLength(50);

                entity.Property(e => e.WeightAbbr).HasMaxLength(50);
            });

            modelBuilder.Entity<TaskField>(entity =>
            {
                entity.ToTable("TaskField", "plan");

                entity.HasIndex(e => new { e.TaskFieldId, e.TaskFieldName, e.ScheduleId, e.TaskFieldType })
                    .HasName("IX_TaskField_ScheduleID_Type");

                entity.Property(e => e.TaskFieldId).HasColumnName("TaskFieldID");

                entity.Property(e => e.EpsfieldGroupId).HasColumnName("EPSFieldGroupID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.TaskFieldName)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.EpsfieldGroup)
                    .WithMany(p => p.TaskField)
                    .HasForeignKey(d => d.EpsfieldGroupId)
                    .HasConstraintName("FK_TaskField_EPSFieldGroup");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.TaskField)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_TaskField_Schedule");
            });

            modelBuilder.Entity<TaskFieldProperty>(entity =>
            {
                entity.ToTable("TaskFieldProperty", "plan");

                entity.HasIndex(e => new { e.TaskFieldPropertyId, e.TaskFieldPropertyName, e.TaskFieldPropertyValue, e.TaskFieldId })
                    .HasName("IX_TaskFieldProperty_TaskFieldID");

                entity.Property(e => e.TaskFieldPropertyId).HasColumnName("TaskFieldPropertyID");

                entity.Property(e => e.TaskFieldId).HasColumnName("TaskFieldID");

                entity.Property(e => e.TaskFieldPropertyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TaskFieldPropertyValue).HasMaxLength(512);

                entity.HasOne(d => d.TaskField)
                    .WithMany(p => p.TaskFieldProperty)
                    .HasForeignKey(d => d.TaskFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskFieldProperty_TaskField");
            });

            modelBuilder.Entity<TaskFieldValues>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaskFieldValues", "plan");

                entity.Property(e => e.TaskFieldId).HasColumnName("TaskFieldID");

                entity.Property(e => e.TaskFieldValue).HasMaxLength(2048);

                entity.Property(e => e.TaskFieldValueId)
                    .HasColumnName("TaskFieldValueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<TaskFieldValuesBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaskFieldValuesBackup", "plan");

                entity.Property(e => e.TaskFieldId).HasColumnName("TaskFieldID");

                entity.Property(e => e.TaskFieldValue).HasMaxLength(2048);

                entity.Property(e => e.TaskFieldValueId)
                    .HasColumnName("TaskFieldValueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<TaskScheduleType>(entity =>
            {
                entity.ToTable("TaskScheduleType", "plan");

                entity.Property(e => e.TaskScheduleTypeId).HasColumnName("TaskScheduleTypeID");

                entity.Property(e => e.TaskScheduleType1)
                    .IsRequired()
                    .HasColumnName("TaskScheduleType")
                    .HasMaxLength(50);

                entity.Property(e => e.TaskTypeDescription).HasMaxLength(1024);
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.ToTable("TaskType", "plan");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.TaskType1)
                    .IsRequired()
                    .HasColumnName("TaskType")
                    .HasMaxLength(50);

                entity.Property(e => e.TaskTypeDescription).HasMaxLength(1024);
            });

            modelBuilder.Entity<TextRendering>(entity =>
            {
                entity.ToTable("TextRendering", "plan");

                entity.Property(e => e.TextRenderingId).HasColumnName("TextRenderingID");

                entity.Property(e => e.FontStyle).HasMaxLength(50);

                entity.Property(e => e.FontWeight).HasMaxLength(50);

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.Property(e => e.Position).HasMaxLength(20);

                entity.Property(e => e.TypeFace).HasMaxLength(50);

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.TextRendering)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_TextRendering_Plan");
            });

            modelBuilder.Entity<Waste>(entity =>
            {
                entity.ToTable("Waste", "plan");

                entity.Property(e => e.WasteId)
                    .HasColumnName("WasteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<XdataAttribute>(entity =>
            {
                entity.ToTable("XDataAttribute", "plan");

                entity.HasIndex(e => new { e.XdataAttributeId, e.PlanElementId })
                    .HasName("IX_XDataAttribute_PlanElementID_IncXDataAttrID");

                entity.HasIndex(e => new { e.XdataAttributeId, e.PlanElementId, e.AttributeName, e.AttributeValue, e.PlanId })
                    .HasName("IX_XDataAttribute_PlanID");

                entity.Property(e => e.XdataAttributeId).HasColumnName("XDataAttributeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.PlanElementId).HasColumnName("PlanElementID");

                entity.Property(e => e.PlanId).HasColumnName("PlanID");

                entity.HasOne(d => d.PlanElement)
                    .WithMany(p => p.XdataAttribute)
                    .HasForeignKey(d => d.PlanElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_XDataAttribute_PLanElementID");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.XdataAttribute)
                    .HasForeignKey(d => d.PlanId)
                    .HasConstraintName("FK_XDataAttribute_Plans");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
