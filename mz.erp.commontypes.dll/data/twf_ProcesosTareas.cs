﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace mz.erp.commontypes.data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class twf_ProcesosTareasDataset : DataSet {
        
        private twf_ProcesosTareasDataTable tabletwf_ProcesosTareas;
        
        public twf_ProcesosTareasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected twf_ProcesosTareasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["twf_ProcesosTareas"] != null)) {
                    this.Tables.Add(new twf_ProcesosTareasDataTable(ds.Tables["twf_ProcesosTareas"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public twf_ProcesosTareasDataTable twf_ProcesosTareas {
            get {
                return this.tabletwf_ProcesosTareas;
            }
        }
        
        public override DataSet Clone() {
            twf_ProcesosTareasDataset cln = ((twf_ProcesosTareasDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["twf_ProcesosTareas"] != null)) {
                this.Tables.Add(new twf_ProcesosTareasDataTable(ds.Tables["twf_ProcesosTareas"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletwf_ProcesosTareas = ((twf_ProcesosTareasDataTable)(this.Tables["twf_ProcesosTareas"]));
            if ((this.tabletwf_ProcesosTareas != null)) {
                this.tabletwf_ProcesosTareas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "twf_ProcesosTareasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/twf_ProcesosTareas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletwf_ProcesosTareas = new twf_ProcesosTareasDataTable();
            this.Tables.Add(this.tabletwf_ProcesosTareas);
        }
        
        private bool ShouldSerializetwf_ProcesosTareas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void twf_ProcesosTareasRowChangeEventHandler(object sender, twf_ProcesosTareasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ProcesosTareasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdProceso;
            
            private DataColumn columnIdTarea;
            
            private DataColumn columnOrden;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnObservaciones;
            
            private DataColumn columnOrdenBR;
            
            private DataColumn columnOrdenDA;
            
            private DataColumn columnOrdenUI;
            
            internal twf_ProcesosTareasDataTable() : 
                    base("twf_ProcesosTareas") {
                this.InitClass();
            }
            
            internal twf_ProcesosTareasDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdProcesoColumn {
                get {
                    return this.columnIdProceso;
                }
            }
            
            internal DataColumn IdTareaColumn {
                get {
                    return this.columnIdTarea;
                }
            }
            
            internal DataColumn OrdenColumn {
                get {
                    return this.columnOrden;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
                }
            }
            
            internal DataColumn FechaCreacionColumn {
                get {
                    return this.columnFechaCreacion;
                }
            }
            
            internal DataColumn IdConexionCreacionColumn {
                get {
                    return this.columnIdConexionCreacion;
                }
            }
            
            internal DataColumn UltimaModificacionColumn {
                get {
                    return this.columnUltimaModificacion;
                }
            }
            
            internal DataColumn IdConexionUltimaModificacionColumn {
                get {
                    return this.columnIdConexionUltimaModificacion;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
                }
            }
            
            internal DataColumn OrdenBRColumn {
                get {
                    return this.columnOrdenBR;
                }
            }
            
            internal DataColumn OrdenDAColumn {
                get {
                    return this.columnOrdenDA;
                }
            }
            
            internal DataColumn OrdenUIColumn {
                get {
                    return this.columnOrdenUI;
                }
            }
            
            public twf_ProcesosTareasRow this[int index] {
                get {
                    return ((twf_ProcesosTareasRow)(this.Rows[index]));
                }
            }
            
            public event twf_ProcesosTareasRowChangeEventHandler twf_ProcesosTareasRowChanged;
            
            public event twf_ProcesosTareasRowChangeEventHandler twf_ProcesosTareasRowChanging;
            
            public event twf_ProcesosTareasRowChangeEventHandler twf_ProcesosTareasRowDeleted;
            
            public event twf_ProcesosTareasRowChangeEventHandler twf_ProcesosTareasRowDeleting;
            
            public void Addtwf_ProcesosTareasRow(twf_ProcesosTareasRow row) {
                this.Rows.Add(row);
            }
            
            public twf_ProcesosTareasRow Addtwf_ProcesosTareasRow(long IdProceso, long IdTarea, int Orden, string Descripcion, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, string Observaciones, int OrdenBR, int OrdenDA, int OrdenUI) {
                twf_ProcesosTareasRow rowtwf_ProcesosTareasRow = ((twf_ProcesosTareasRow)(this.NewRow()));
                rowtwf_ProcesosTareasRow.ItemArray = new object[] {
                        IdProceso,
                        IdTarea,
                        Orden,
                        Descripcion,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        Observaciones,
                        OrdenBR,
                        OrdenDA,
                        OrdenUI};
                this.Rows.Add(rowtwf_ProcesosTareasRow);
                return rowtwf_ProcesosTareasRow;
            }
            
            public twf_ProcesosTareasRow FindByIdProcesoIdTarea(long IdProceso, long IdTarea) {
                return ((twf_ProcesosTareasRow)(this.Rows.Find(new object[] {
                            IdProceso,
                            IdTarea})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                twf_ProcesosTareasDataTable cln = ((twf_ProcesosTareasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new twf_ProcesosTareasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdProceso = this.Columns["IdProceso"];
                this.columnIdTarea = this.Columns["IdTarea"];
                this.columnOrden = this.Columns["Orden"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnObservaciones = this.Columns["Observaciones"];
                this.columnOrdenBR = this.Columns["OrdenBR"];
                this.columnOrdenDA = this.Columns["OrdenDA"];
                this.columnOrdenUI = this.Columns["OrdenUI"];
            }
            
            private void InitClass() {
                this.columnIdProceso = new DataColumn("IdProceso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProceso);
                this.columnIdTarea = new DataColumn("IdTarea", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTarea);
                this.columnOrden = new DataColumn("Orden", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrden);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
                this.columnOrdenBR = new DataColumn("OrdenBR", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrdenBR);
                this.columnOrdenDA = new DataColumn("OrdenDA", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrdenDA);
                this.columnOrdenUI = new DataColumn("OrdenUI", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrdenUI);
                this.Constraints.Add(new UniqueConstraint("twf_ProcesosTareasKey1", new DataColumn[] {
                                this.columnIdProceso,
                                this.columnIdTarea}, true));
                this.columnIdProceso.AllowDBNull = false;
                this.columnIdTarea.AllowDBNull = false;
                this.columnOrden.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
            }
            
            public twf_ProcesosTareasRow Newtwf_ProcesosTareasRow() {
                return ((twf_ProcesosTareasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new twf_ProcesosTareasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(twf_ProcesosTareasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.twf_ProcesosTareasRowChanged != null)) {
                    this.twf_ProcesosTareasRowChanged(this, new twf_ProcesosTareasRowChangeEvent(((twf_ProcesosTareasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.twf_ProcesosTareasRowChanging != null)) {
                    this.twf_ProcesosTareasRowChanging(this, new twf_ProcesosTareasRowChangeEvent(((twf_ProcesosTareasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.twf_ProcesosTareasRowDeleted != null)) {
                    this.twf_ProcesosTareasRowDeleted(this, new twf_ProcesosTareasRowChangeEvent(((twf_ProcesosTareasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.twf_ProcesosTareasRowDeleting != null)) {
                    this.twf_ProcesosTareasRowDeleting(this, new twf_ProcesosTareasRowChangeEvent(((twf_ProcesosTareasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetwf_ProcesosTareasRow(twf_ProcesosTareasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ProcesosTareasRow : DataRow {
            
            private twf_ProcesosTareasDataTable tabletwf_ProcesosTareas;
            
            internal twf_ProcesosTareasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletwf_ProcesosTareas = ((twf_ProcesosTareasDataTable)(this.Table));
            }
            
            public long IdProceso {
                get {
                    return ((long)(this[this.tabletwf_ProcesosTareas.IdProcesoColumn]));
                }
                set {
                    this[this.tabletwf_ProcesosTareas.IdProcesoColumn] = value;
                }
            }
            
            public long IdTarea {
                get {
                    return ((long)(this[this.tabletwf_ProcesosTareas.IdTareaColumn]));
                }
                set {
                    this[this.tabletwf_ProcesosTareas.IdTareaColumn] = value;
                }
            }
            
            public int Orden {
                get {
                    return ((int)(this[this.tabletwf_ProcesosTareas.OrdenColumn]));
                }
                set {
                    this[this.tabletwf_ProcesosTareas.OrdenColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletwf_ProcesosTareas.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.DescripcionColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ProcesosTareas.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tabletwf_ProcesosTareas.FechaCreacionColumn]));
                }
                set {
                    this[this.tabletwf_ProcesosTareas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tabletwf_ProcesosTareas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tabletwf_ProcesosTareas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletwf_ProcesosTareas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_ProcesosTareas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletwf_ProcesosTareas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.RowIdColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletwf_ProcesosTareas.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.ObservacionesColumn] = value;
                }
            }
            
            public int OrdenBR {
                get {
                    try {
                        return ((int)(this[this.tabletwf_ProcesosTareas.OrdenBRColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.OrdenBRColumn] = value;
                }
            }
            
            public int OrdenDA {
                get {
                    try {
                        return ((int)(this[this.tabletwf_ProcesosTareas.OrdenDAColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.OrdenDAColumn] = value;
                }
            }
            
            public int OrdenUI {
                get {
                    try {
                        return ((int)(this[this.tabletwf_ProcesosTareas.OrdenUIColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_ProcesosTareas.OrdenUIColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletwf_ProcesosTareas.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tabletwf_ProcesosTareas.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletwf_ProcesosTareas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletwf_ProcesosTareas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletwf_ProcesosTareas.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletwf_ProcesosTareas.ObservacionesColumn] = System.Convert.DBNull;
            }
            
            public bool IsOrdenBRNull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.OrdenBRColumn);
            }
            
            public void SetOrdenBRNull() {
                this[this.tabletwf_ProcesosTareas.OrdenBRColumn] = System.Convert.DBNull;
            }
            
            public bool IsOrdenDANull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.OrdenDAColumn);
            }
            
            public void SetOrdenDANull() {
                this[this.tabletwf_ProcesosTareas.OrdenDAColumn] = System.Convert.DBNull;
            }
            
            public bool IsOrdenUINull() {
                return this.IsNull(this.tabletwf_ProcesosTareas.OrdenUIColumn);
            }
            
            public void SetOrdenUINull() {
                this[this.tabletwf_ProcesosTareas.OrdenUIColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ProcesosTareasRowChangeEvent : EventArgs {
            
            private twf_ProcesosTareasRow eventRow;
            
            private DataRowAction eventAction;
            
            public twf_ProcesosTareasRowChangeEvent(twf_ProcesosTareasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public twf_ProcesosTareasRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
