﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
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
    public class tsy_ConcpetosRetencionIIBBDataset : DataSet {
        
        private tsy_ConcpetosRetencionIIBBDataTable tabletsy_ConcpetosRetencionIIBB;
        
        public tsy_ConcpetosRetencionIIBBDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_ConcpetosRetencionIIBBDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_ConcpetosRetencionIIBB"] != null)) {
                    this.Tables.Add(new tsy_ConcpetosRetencionIIBBDataTable(ds.Tables["tsy_ConcpetosRetencionIIBB"]));
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
        public tsy_ConcpetosRetencionIIBBDataTable tsy_ConcpetosRetencionIIBB {
            get {
                return this.tabletsy_ConcpetosRetencionIIBB;
            }
        }
        
        public override DataSet Clone() {
            tsy_ConcpetosRetencionIIBBDataset cln = ((tsy_ConcpetosRetencionIIBBDataset)(base.Clone()));
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
            if ((ds.Tables["tsy_ConcpetosRetencionIIBB"] != null)) {
                this.Tables.Add(new tsy_ConcpetosRetencionIIBBDataTable(ds.Tables["tsy_ConcpetosRetencionIIBB"]));
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
            this.tabletsy_ConcpetosRetencionIIBB = ((tsy_ConcpetosRetencionIIBBDataTable)(this.Tables["tsy_ConcpetosRetencionIIBB"]));
            if ((this.tabletsy_ConcpetosRetencionIIBB != null)) {
                this.tabletsy_ConcpetosRetencionIIBB.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_ConcpetosRetencionIIBBDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_ConcpetosRetencionIIBB.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_ConcpetosRetencionIIBB = new tsy_ConcpetosRetencionIIBBDataTable();
            this.Tables.Add(this.tabletsy_ConcpetosRetencionIIBB);
        }
        
        private bool ShouldSerializetsy_ConcpetosRetencionIIBB() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_ConcpetosRetencionIIBBRowChangeEventHandler(object sender, tsy_ConcpetosRetencionIIBBRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_ConcpetosRetencionIIBBDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdConcepto;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tsy_ConcpetosRetencionIIBBDataTable() : 
                    base("tsy_ConcpetosRetencionIIBB") {
                this.InitClass();
            }
            
            internal tsy_ConcpetosRetencionIIBBDataTable(DataTable table) : 
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
            
            internal DataColumn IdConceptoColumn {
                get {
                    return this.columnIdConcepto;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
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
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            public tsy_ConcpetosRetencionIIBBRow this[int index] {
                get {
                    return ((tsy_ConcpetosRetencionIIBBRow)(this.Rows[index]));
                }
            }
            
            public event tsy_ConcpetosRetencionIIBBRowChangeEventHandler tsy_ConcpetosRetencionIIBBRowChanged;
            
            public event tsy_ConcpetosRetencionIIBBRowChangeEventHandler tsy_ConcpetosRetencionIIBBRowChanging;
            
            public event tsy_ConcpetosRetencionIIBBRowChangeEventHandler tsy_ConcpetosRetencionIIBBRowDeleted;
            
            public event tsy_ConcpetosRetencionIIBBRowChangeEventHandler tsy_ConcpetosRetencionIIBBRowDeleting;
            
            public void Addtsy_ConcpetosRetencionIIBBRow(tsy_ConcpetosRetencionIIBBRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_ConcpetosRetencionIIBBRow Addtsy_ConcpetosRetencionIIBBRow(string IdConcepto, string Descripcion, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tsy_ConcpetosRetencionIIBBRow rowtsy_ConcpetosRetencionIIBBRow = ((tsy_ConcpetosRetencionIIBBRow)(this.NewRow()));
                rowtsy_ConcpetosRetencionIIBBRow.ItemArray = new object[] {
                        IdConcepto,
                        Descripcion,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtsy_ConcpetosRetencionIIBBRow);
                return rowtsy_ConcpetosRetencionIIBBRow;
            }
            
            public tsy_ConcpetosRetencionIIBBRow FindByIdConcepto(string IdConcepto) {
                return ((tsy_ConcpetosRetencionIIBBRow)(this.Rows.Find(new object[] {
                            IdConcepto})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_ConcpetosRetencionIIBBDataTable cln = ((tsy_ConcpetosRetencionIIBBDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_ConcpetosRetencionIIBBDataTable();
            }
            
            internal void InitVars() {
                this.columnIdConcepto = this.Columns["IdConcepto"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
            }
            
            private void InitClass() {
                this.columnIdConcepto = new DataColumn("IdConcepto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConcepto);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.Constraints.Add(new UniqueConstraint("tsy_ConcpetosRetencionIIBBKey1", new DataColumn[] {
                                this.columnIdConcepto}, true));
                this.columnIdConcepto.AllowDBNull = false;
                this.columnIdConcepto.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnActivo.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsy_ConcpetosRetencionIIBBRow Newtsy_ConcpetosRetencionIIBBRow() {
                return ((tsy_ConcpetosRetencionIIBBRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_ConcpetosRetencionIIBBRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_ConcpetosRetencionIIBBRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_ConcpetosRetencionIIBBRowChanged != null)) {
                    this.tsy_ConcpetosRetencionIIBBRowChanged(this, new tsy_ConcpetosRetencionIIBBRowChangeEvent(((tsy_ConcpetosRetencionIIBBRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_ConcpetosRetencionIIBBRowChanging != null)) {
                    this.tsy_ConcpetosRetencionIIBBRowChanging(this, new tsy_ConcpetosRetencionIIBBRowChangeEvent(((tsy_ConcpetosRetencionIIBBRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_ConcpetosRetencionIIBBRowDeleted != null)) {
                    this.tsy_ConcpetosRetencionIIBBRowDeleted(this, new tsy_ConcpetosRetencionIIBBRowChangeEvent(((tsy_ConcpetosRetencionIIBBRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_ConcpetosRetencionIIBBRowDeleting != null)) {
                    this.tsy_ConcpetosRetencionIIBBRowDeleting(this, new tsy_ConcpetosRetencionIIBBRowChangeEvent(((tsy_ConcpetosRetencionIIBBRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_ConcpetosRetencionIIBBRow(tsy_ConcpetosRetencionIIBBRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_ConcpetosRetencionIIBBRow : DataRow {
            
            private tsy_ConcpetosRetencionIIBBDataTable tabletsy_ConcpetosRetencionIIBB;
            
            internal tsy_ConcpetosRetencionIIBBRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_ConcpetosRetencionIIBB = ((tsy_ConcpetosRetencionIIBBDataTable)(this.Table));
            }
            
            public string IdConcepto {
                get {
                    return ((string)(this[this.tabletsy_ConcpetosRetencionIIBB.IdConceptoColumn]));
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.IdConceptoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsy_ConcpetosRetencionIIBB.DescripcionColumn]));
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.DescripcionColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    return ((bool)(this[this.tabletsy_ConcpetosRetencionIIBB.ActivoColumn]));
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsy_ConcpetosRetencionIIBB.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_ConcpetosRetencionIIBB.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsy_ConcpetosRetencionIIBB.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_ConcpetosRetencionIIBB.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsy_ConcpetosRetencionIIBB.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsy_ConcpetosRetencionIIBB.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsy_ConcpetosRetencionIIBB.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsy_ConcpetosRetencionIIBB.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ConcpetosRetencionIIBB.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsy_ConcpetosRetencionIIBB.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsy_ConcpetosRetencionIIBB.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_ConcpetosRetencionIIBBRowChangeEvent : EventArgs {
            
            private tsy_ConcpetosRetencionIIBBRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_ConcpetosRetencionIIBBRowChangeEvent(tsy_ConcpetosRetencionIIBBRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_ConcpetosRetencionIIBBRow Row {
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
